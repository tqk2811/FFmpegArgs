using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Filters.MultimediaFilters;
using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Inputs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    public static class Shared
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


        public static List<IEnumerable<ImageMap>> InputScreenMode(this IEnumerable<ImageMap> inputs,
            ScreenMode screenMode, int WIDTH, int HEIGHT, int FPS = 24, string lumaRadius = "100")
        {
            List<IEnumerable<ImageMap>> prepareInputs = new List<IEnumerable<ImageMap>>();
            switch (screenMode)
            {
                case ScreenMode.Center:
                    prepareInputs.AddRange(inputs.Select(x => x
                        .SetPtsFilter("PTS-STARTPTS").MapOut
                        .ScaleFilter(
                            $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),min(iw,{WIDTH}),-1)",
                            $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,min(ih,{HEIGHT}))").MapOut
                        .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                        .SetSarFilter("1/1").MapOut
                        .FpsFilter($"{FPS}").MapOut
                        .FormatFilter(PixFmt.rgba).MapOut
                        .SplitFilter(2).MapsOut));
                    break;

                case ScreenMode.Crop:
                    prepareInputs.AddRange(inputs.Select(x => x
                         .SetPtsFilter("PTS-STARTPTS").MapOut
                         .ScaleFilter(
                             $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,{WIDTH})",
                             $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),{HEIGHT},-1)").MapOut
                         .CropFilter().WH($"{WIDTH}", $"{HEIGHT}").MapOut
                         .SetSarFilter("1/1").MapOut
                         .FpsFilter($"{FPS}").MapOut
                         .FormatFilter(PixFmt.rgba).MapOut
                         .SplitFilter(2).MapsOut));
                    break;

                case ScreenMode.Scale:
                    prepareInputs.AddRange(inputs.Select(x => x
                        .ScaleFilter($"{WIDTH}", $"{HEIGHT}").MapOut
                        .SetSarFilter("1/1").MapOut
                        .FpsFilter($"{FPS}").MapOut
                        .FormatFilter(PixFmt.rgba).MapOut
                        .SplitFilter(2).MapsOut));
                    break;

                case ScreenMode.Blur:
                    prepareInputs.AddRange(inputs.Select(x => x
                        .MakeBlurredBackground(WIDTH, HEIGHT, FPS, lumaRadius)
                        .SplitFilter(2).MapsOut));
                    break;
            }
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
    }
}
