

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    internal static class Shared
    {
        public static List<ImageMap> GetImagesInput(this FFmpegArg ffmpegArg)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(".\\Resources");
            var files = directoryInfo.GetFiles("*.jpg");
            return files
                .Select(x => ffmpegArg
                    .AddImagesInput(new ImageFileInput($"Resources\\{x.Name}")
                    .SetOption("-loop", 1)//https://ffmpeg.org/ffmpeg-formats.html#image2-1 image demux option
                    ).First()).ToList();
        }
        public static ImageMap FilmStripH(this FFmpegArg ffmpegArg)
        {
            return ffmpegArg.AddImagesInput(new ImageFileInput($"Resources\\film_strip.png").SetOption("-loop", 1)).First();
        }
        public static ImageMap FilmStripV(this FFmpegArg ffmpegArg)
        {
            return ffmpegArg.AddImagesInput(new ImageFileInput($"Resources\\film_strip_vertical.png").SetOption("-loop", 1)).First();
        }
        public static List<IEnumerable<ImageMap>> InputScreenModes(this IEnumerable<ImageMap> inputs,
            ScreenMode screenMode, Config config, string lumaRadius = "100")
            => inputs.InputScreenMode(screenMode, config, lumaRadius).Select(x => x.SplitFilter(2).MapsOut).ToList();
        public static List<ImageMap> InputScreenMode(this IEnumerable<ImageMap> inputs,
            ScreenMode screenMode, Config config, string lumaRadius = "100")
        {
            List<ImageMap> prepareInputs = new List<ImageMap>();
            prepareInputs.AddRange(inputs.Select(x => x.SetPtsFilter("PTS-STARTPTS").MapOut).Select(x =>
            {
                switch (screenMode)
                {
                    case ScreenMode.Center:
                        return x
                            .ScaleFilter()
                                .W($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),min(iw,{config.Size.Width}),-1)")
                                .H($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,min(ih,{config.Size.Height}))").MapOut
                            .ScaleFilter()
                                .W("trunc(iw/2)*2")
                                .H("trunc(ih/2)*2").MapOut
                            .SetSarFilter().Ratio("1/1").MapOut
                            .FpsFilter().Fps(config.Fps).MapOut
                            .FormatFilter(PixFmt.rgba).MapOut;
                    case ScreenMode.Crop:
                        return x
                            .ScaleFilter()
                                .W($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,{config.Size.Width})")
                                .H($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),{config.Size.Height},-1)").MapOut
                             .CropFilter()
                                .W($"{config.Size.Width}")
                                .H($"{config.Size.Height}").MapOut
                             .SetSarFilter().Ratio("1/1").MapOut
                             .FpsFilter().Fps(config.Fps).MapOut
                             .FormatFilter(PixFmt.rgba).MapOut;
                    case ScreenMode.Scale:
                        return x
                            .ScaleFilter()
                                .W($"{config.Size.Width}")
                                .H($"{config.Size.Height}").MapOut
                            .SetSarFilter().Ratio("1/1").MapOut
                            .FpsFilter().Fps(config.Fps).MapOut
                            .FormatFilter(PixFmt.rgba).MapOut;
                    case ScreenMode.Blur:
                        return x.MakeBlurredBackground(config.Size.Width, config.Size.Height, config.Fps, lumaRadius);
                }
                return null;
            }));
            return prepareInputs;
        }
        public static ImageMap MakeBlurredBackground(this ImageMap image,
          int width, int height, int fps = 24, string lumaRadius = "100")
        {
            List<ImageMap> inputs = new List<ImageMap>();
            if (image.IsInput)
            {
                inputs.Add(image);
                inputs.Add(image);
            }
            else
            {
                inputs.AddRange(image.SplitFilter(2).MapsOut);
            }
            var blurred = inputs.First()
                .ScaleFilter().W($"{width}").H($"{height}").MapOut
                .SetSarFilter().Ratio("1/1").MapOut
                .FpsFilter().Fps(fps).MapOut
                .FormatFilter(PixFmt.rgba).MapOut
                .BoxBlurFilter().LumaRadius($"{lumaRadius}").MapOut
                .SetSarFilter().Ratio("1/1").MapOut;
            var raw = inputs.Last()
                .ScaleFilter()
                    .W($"if(gte(iw/ih,{width}/{height}),min(iw,{width}),-1)")
                    .H($"if(gte(iw/ih,{width}/{height}),-1,min(ih,{height}))").MapOut
                .ScaleFilter()
                    .W("trunc(iw/2)*2")
                    .H("trunc(ih/2)*2").MapOut
                .SetSarFilter().Ratio("1/1").MapOut
                .FpsFilter().Fps(fps).MapOut
                .FormatFilter(PixFmt.rgba).MapOut;
            return raw
                .OverlayFilterOn(blurred)
                    .X("(main_w - overlay_w)/2")
                    .Y("(main_h-overlay_h)/2").MapOut//center
                .SetPtsFilter("PTS-STARTPTS").MapOut;
        }
        public static List<ImageMap> Overlaids(this IEnumerable<ImageMap> inputs, Config config)
        {
            return inputs.Select(x => x
                .PadFilter()
                    .W(config.Size.Width.ToString())
                    .H(config.Size.Height.ToString())
                    .X($"({config.Size.Width}-iw)/2")
                    .Y($"({config.Size.Height}-ih)/2")
                    .Color(config.BackgroundColor).MapOut
                .TrimFilter()
                    .Duration(config.ImageDuration).MapOut).ToList();
        }
        public static StartEnd StartEnd(this List<ImageMap> inputs, Config config)
        {
            StartEnd startEnd = new StartEnd();
            for (int i = 0; i < inputs.Count; i++)
            {
                //first create ed only (if only 1 image -> create ed)
                //mid: split to ed and op
                //last create op
                var res = inputs[i]
                  .PadFilter()
                    .W($"{config.Size.Width}")
                    .H($"{config.Size.Height}")
                    .X($"({config.Size.Width}-iw)/2")
                    .Y($"({config.Size.Height}-ih)/2")
                    .Color(config.BackgroundColor).MapOut
                  .TrimFilter()
                    .Duration(config.TransitionDuration).MapOut
                  .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut;
                if (i == 0)//first
                {
                    if (inputs.Count > 1)
                    {
                        startEnd.Endings.Add(res);
                    }
                }
                else if (i == inputs.Count - 1)//last
                {
                    startEnd.Startings.Add(res);
                }
                else//mid
                {
                    var splits = res.SplitFilter(2).MapsOut;
                    startEnd.Startings.Add(splits.First());
                    startEnd.Endings.Add(splits.Last());
                }
            }
            return startEnd;
        }
        public static List<ImageMap> Blendeds(this StartEnd startEnd, Config config, Action<BlendFilter> blend)
        {
            List<ImageMap> blendeds = new List<ImageMap>();
            for (int i = 0; i < startEnd.Startings.Count; i++)
            {
                var blendFilter = startEnd.Startings[i].BlendFilterOn(startEnd.Endings[i]);
                blend.Invoke(blendFilter);
                blendeds.Add(blendFilter.MapOut
                    .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut
                    );
            }
            return blendeds;
        }
        public static ImageMap ConcatOverlaidsAndBlendeds(this List<ImageMap> overlaids, List<ImageMap> blendeds)
        {
            List<ConcatGroup> concatGroups = new List<ConcatGroup>();
            for (int i = 0; i < overlaids.Count; i++)
            {
                concatGroups.Add(new ConcatGroup(overlaids[i]));
                if (i < overlaids.Count - 1) concatGroups.Add(new ConcatGroup(blendeds[i]));
            }
            ConcatFilter concatFilter = new ConcatFilter(concatGroups);
            return concatFilter.ImageMapsOut.First().FormatFilter(PixFmt.yuv420p).MapOut;
        }
    }
}
