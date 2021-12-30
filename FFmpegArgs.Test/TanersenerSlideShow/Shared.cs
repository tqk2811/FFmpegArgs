using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Filters.MultimediaFilters;
using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Inputs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    internal static class Shared
    {
        public static List<ImageMap> GetImagesInput(this FFmpegArg ffmpegArg)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(".\\Images");
            var files = directoryInfo.GetFiles("*.jpg");
            return files.Select(x => ffmpegArg.AddImageInput(new ImageFileInput($"Images\\{x.Name}").SetOption("-loop", 1))).ToList();
        }

        public static ImageMap FilmStripH(this FFmpegArg ffmpegArg)
        {
            return ffmpegArg.AddImageInput(new ImageFileInput($"Images\\film_strip.png").SetOption("-loop", 1));
        }
        public static ImageMap FilmStripV(this FFmpegArg ffmpegArg)
        {
            return ffmpegArg.AddImageInput(new ImageFileInput($"Images\\film_strip_vertical.png").SetOption("-loop", 1));
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
                            .ScaleFilter(
                                $"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),min(iw,{config.Size.Width}),-1)",
                                $"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,min(ih,{config.Size.Height}))").MapOut
                            .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                            .SetSarFilter("1/1").MapOut
                            .FpsFilter($"{config.Fps}").MapOut
                            .FormatFilter(PixFmt.rgba).MapOut;

                    case ScreenMode.Crop:
                        return x
                            .ScaleFilter(
                                 $"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,{config.Size.Width})",
                                 $"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),{config.Size.Height},-1)").MapOut
                             .CropFilter().WH($"{config.Size.Width}", $"{config.Size.Height}").MapOut
                             .SetSarFilter("1/1").MapOut
                             .FpsFilter($"{config.Fps}").MapOut
                             .FormatFilter(PixFmt.rgba).MapOut;

                    case ScreenMode.Scale:
                        return x
                            .ScaleFilter($"{config.Size.Width}", $"{config.Size.Height}").MapOut
                            .SetSarFilter("1/1").MapOut
                            .FpsFilter($"{config.Fps}").MapOut
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
                .ScaleFilter($"{width}", $"{height}").MapOut
                .SetSarFilter("1/1").MapOut
                .FpsFilter(fps).MapOut
                .FormatFilter(PixFmt.rgba).MapOut
                .BoxBlurFilter().LumaRadius($"{lumaRadius}").MapOut
                .SetSarFilter("1/1").MapOut;

            var raw = inputs.Last()
                .ScaleFilter($"if(gte(iw/ih,{width}/{height}),min(iw,{width}),-1)",
                            $"if(gte(iw/ih,{width}/{height}),-1,min(ih,{height}))").MapOut
                .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                .SetSarFilter("1/1").MapOut
                .FpsFilter(fps).MapOut
                .FormatFilter(PixFmt.rgba).MapOut;

            return raw
                .OverlayFilterOn(blurred, "(main_w - overlay_w)/2", "(main_h-overlay_h)/2").MapOut//center
                .SetPtsFilter("PTS-STARTPTS").MapOut;
        }




        public static List<ImageMap> Overlaids(this IEnumerable<ImageMap> inputs, Config config)
        {
            return inputs.Select(x => x
                .PadFilter()
                    .Size(config.Size.Width.ToString(), config.Size.Height.ToString())
                    .Position($"({config.Size.Width} - iw)/2", $"({config.Size.Height} - ih)/2")
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
                    .Size($"{config.Size.Width}", $"{config.Size.Height}")
                    .Position($"({config.Size.Width}-iw)/2", $"({config.Size.Height}-ih)/2")
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

        public static List<ImageMap> Blendeds(this StartEnd startEnd, Config config,Action<BlendFilter> blend)
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
