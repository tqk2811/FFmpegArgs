using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Filters.MultimediaFilters;
using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Filters.VideoSources;
using FFmpegArgs.Inputs;
using FFmpegArgs.Outputs;
using FFmpegArgs.Executes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class PushHorizontalFilm
    {
        [TestMethod]
        public void PushHorizontalFilm_Blur_LeftToRight()
        {
            PushHorizontalFilmTest(ScreenMode.Blur, HorizontalDirection.LeftToRight);
        }
        [TestMethod]
        public void PushHorizontalFilm_Center_LeftToRight()
        {
            PushHorizontalFilmTest(ScreenMode.Center, HorizontalDirection.LeftToRight);
        }
        [TestMethod]
        public void PushHorizontalFilm_Crop_RightToLeft()
        {
            PushHorizontalFilmTest(ScreenMode.Crop, HorizontalDirection.RightToLeft);
        }
        [TestMethod]
        public void PushHorizontalFilm_Scale_RightToLeft()
        {
            PushHorizontalFilmTest(ScreenMode.Scale, HorizontalDirection.RightToLeft);
        }

        public void PushHorizontalFilmTest(ScreenMode screenMode, HorizontalDirection direction)
        {
            string outputFileName = $"{nameof(PushHorizontalFilmTest)}-{screenMode}-{direction}.mp4";
            string filterFileName = $"{nameof(PushHorizontalFilmTest)}-{screenMode}-{direction}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var images_inputmap = ffmpegArg.GetImagesInput();

            Config config = new Config();
            TimeSpan TOTAL_DURATION = config.TransitionDuration * images_inputmap.Count;

            var film_strip_map = ffmpegArg.FilmStripH();

            var background = ffmpegArg.FilterGraph
                .ColorFilter()
                    .Color(config.BackgroundColor)
                    .Size(config.Size)
                    .Duration(TOTAL_DURATION).MapOut
                .FpsFilter($"{config.Fps}").MapOut;

            List<ImageMap> images_Prepare = new List<ImageMap>();
            for (int i = 0; i < images_inputmap.Count; i++)
            {
                switch (screenMode)
                {
                    case ScreenMode.Center:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),min(iw,{config.Size.Width}),-1)",
                                                $"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,min(ih,{config.Size.Height}))").MapOut
                                .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                                .PadFilter($"{config.Size.Width}", $"{config.Size.Height}")
                                    .Position($"({config.Size.Width}-iw)/2", $"({config.Size.Height}-ih)/2")
                                    .Color(config.BackgroundColor).MapOut
                                .SetSarFilter("1/1").MapOut);
                            break;
                        }

                    case ScreenMode.Crop:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,{config.Size.Width})",
                                                $"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),{config.Size.Height},-1)").MapOut
                                .OverlayFilterOn(film_strip_map, "0", "0").MapOut
                                .CropFilter().WH($"{config.Size.Width}", $"{config.Size.Height}").MapOut
                                .SetSarFilter("1/1").MapOut);
                            break;
                        }

                    case ScreenMode.Scale:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter($"{config.Size.Width}", $"{config.Size.Height}").MapOut
                                .SetSarFilter("1/1").MapOut);
                            break;
                        }

                    case ScreenMode.Blur:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .MakeBlurredBackground(config.Size.Width, config.Size.Height, config.Fps, "100")
                                .FormatFilter(PixFmt.rgba).MapOut
                                .SetSarFilter("1/1").MapOut);
                            break;
                        }
                }
            }

            var strip_images = film_strip_map
                .SetPtsFilter("PTS-STARTPTS").MapOut
                .ScaleFilter($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),min(iw,{config.Size.Width}),-1)",
                                $"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,min(ih,{config.Size.Height}))").MapOut
                .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                .SetSarFilter("1/1").MapOut
                .SplitFilter(images_inputmap.Count).MapsOut.ToList();

            // OVERLAY FILM STRIP ON TOP OF INPUTS

            List<ImageMap> image_overlay_on_strips = new List<ImageMap>();
            for (int i = 0; i < images_Prepare.Count; i++)
            {
                image_overlay_on_strips.Add(strip_images[i]
                    .OverlayFilterOn(images_Prepare[i], "(main_w-overlay_w)/2", "(main_h-overlay_h)/2").Format(OverlayPixFmt.rgb).MapOut);
            }

            var lastOverLay = background;
            for (int i = 0; i < images_Prepare.Count; i++)
            {
                var start = i * config.TransitionDuration;
                var end = start + config.TransitionDuration * 2;
                switch (direction)
                {
                    case HorizontalDirection.LeftToRight:
                        {
                            lastOverLay = image_overlay_on_strips[i].SetPtsFilter("PTS-STARTPTS").MapOut
                               .OverlayFilterOn(lastOverLay, $"-{config.Size.Width}+(t-{start.TotalSeconds})/{config.TransitionDuration.TotalSeconds}*{config.Size.Width}", "0")//from -WIDTH to +WIDTH
                                   .Enable($"between(t,{start.TotalSeconds},{end.TotalSeconds})").MapOut;
                            break;
                        }

                    case HorizontalDirection.RightToLeft:
                        {
                            lastOverLay = image_overlay_on_strips[i].SetPtsFilter("PTS-STARTPTS").MapOut
                                .OverlayFilterOn(lastOverLay, $"{config.Size.Width}-(t-{start.TotalSeconds})/{config.TransitionDuration.TotalSeconds}*{config.Size.Width}", "0")//from +WIDTH to -WIDTH
                                    .Enable($"between(t,{start.TotalSeconds},{end.TotalSeconds})").MapOut;
                            break;
                        }
                }
            }

            var out_map = lastOverLay
                .TrimFilter().Duration(TOTAL_DURATION).MapOut
                .FpsFilter($"{config.Fps}").MapOut
                .FormatFilter(PixFmt.yuv420p).MapOut;

            var videoOut = new ImageFileOutput(outputFileName, out_map)
                .VSync(VSyncMethod.vfr)
                .SetOption("-rc-lookahead", 0)
                .SetOption("-g", 0)
                .VCodec("libx264")
                //.SetOption("-b:v", "3000")
                .Fps(config.Fps);

            ffmpegArg.AddOutput(videoOut);

            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
    }
}
