﻿using FFmpegArgs.Cores.Maps;
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
        public void PushHorizontalFilm_Crop_LeftToRight()
        {
            PushHorizontalFilmTest(ScreenMode.Crop, HorizontalDirection.LeftToRight);
        }
        [TestMethod]
        public void PushHorizontalFilm_Scale_LeftToRight()
        {
            PushHorizontalFilmTest(ScreenMode.Scale, HorizontalDirection.LeftToRight);
        }

        public void PushHorizontalFilmTest(ScreenMode screenMode, HorizontalDirection direction)
        {
            string outputFileName = $"{nameof(PushHorizontalFilmTest)}-{screenMode}-{direction}.mp4";
            string filterFileName = $"{nameof(PushHorizontalFilmTest)}-{screenMode}-{direction}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var images_inputmap = ffmpegArg.GetImagesInput();


            int WIDTH = 1280;
            int HEIGHT = 720;
            int FPS = 60;
            double TRANSITION_DURATION = 3;
            Color BACKGROUND_COLOR = Color.FromArgb(0, 0, 0, 0);

            int IMAGE_COUNT = images_inputmap.Count;

            double TRANSITION_FRAME_COUNT = TRANSITION_DURATION * FPS;
            double TOTAL_DURATION = TRANSITION_DURATION * IMAGE_COUNT;
            double TOTAL_FRAME_COUNT = TOTAL_DURATION * FPS;

            var film_strip_map = ffmpegArg.FilmStripH();

            var background = ffmpegArg.FilterGraph
                .ColorFilter()
                    .Color(BACKGROUND_COLOR)
                    .Size(new Size(WIDTH, HEIGHT))
                    .Duration(TimeSpan.FromSeconds(TOTAL_DURATION)).MapOut
                .FpsFilter($"{FPS}").MapOut;

            List<ImageMap> images_Prepare = new List<ImageMap>();
            for (int i = 0; i < images_inputmap.Count; i++)
            {
                switch (screenMode)
                {
                    case ScreenMode.Center:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter($"if(gte(iw/ih,{WIDTH}/{HEIGHT}),min(iw,{WIDTH}),-1)",
                                                $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,min(ih,{HEIGHT}))").MapOut
                                .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                                .PadFilter($"{WIDTH}", $"{HEIGHT}")
                                    .Position($"({WIDTH}-iw)/2", $"({HEIGHT}-ih)/2")
                                    .Color(BACKGROUND_COLOR).MapOut
                                .SetSarFilter("1/1").MapOut);
                            break;
                        }

                    case ScreenMode.Crop:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter($"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,{WIDTH})",
                                                $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),{HEIGHT},-1)").MapOut
                                .OverlayFilterOn(film_strip_map, "0", "0").MapOut
                                .CropFilter().WH($"{WIDTH}", $"{HEIGHT}").MapOut
                                .SetSarFilter("1/1").MapOut);
                            break;
                        }

                    case ScreenMode.Scale:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter($"{WIDTH}", $"{HEIGHT}").MapOut
                                .SetSarFilter("1/1").MapOut);
                            break;
                        }

                    case ScreenMode.Blur:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .MakeBlurredBackground(WIDTH, HEIGHT, FPS, "100")
                                .FormatFilter(PixFmt.rgba).MapOut
                                .SetSarFilter("1/1").MapOut);
                            break;
                        }
                }
            }

            var strip_images = film_strip_map
                .SetPtsFilter("PTS-STARTPTS").MapOut
                .ScaleFilter($"if(gte(iw/ih,{WIDTH}/{HEIGHT}),min(iw,{WIDTH}),-1)",
                                $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,min(ih,{HEIGHT}))").MapOut
                .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                .SetSarFilter("1/1").MapOut
                .SplitFilter(IMAGE_COUNT).MapsOut.ToList();

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
                var start = i * TRANSITION_DURATION;
                var end = start + TRANSITION_DURATION * 2;
                switch (direction)
                {
                    case HorizontalDirection.LeftToRight:
                        {
                            lastOverLay = image_overlay_on_strips[i].SetPtsFilter("PTS-STARTPTS").MapOut
                               .OverlayFilterOn(lastOverLay, $"-{WIDTH}+(t-{start})/{TRANSITION_DURATION}*{WIDTH}", "0")//from -WIDTH to +WIDTH
                                   .Enable($"between(t,{start},{end})").MapOut;
                            break;
                        }

                    case HorizontalDirection.RightToLeft:
                        {
                            lastOverLay = image_overlay_on_strips[i].SetPtsFilter("PTS-STARTPTS").MapOut
                                .OverlayFilterOn(lastOverLay, $"{WIDTH}-(t-{start})/{TRANSITION_DURATION}*{WIDTH}", "0")//from +WIDTH to -WIDTH
                                    .Enable($"between(t,{start},{end})").MapOut;
                            break;
                        }
                }
            }

            var out_map = lastOverLay
                .TrimFilter().Duration(TimeSpan.FromSeconds(TOTAL_DURATION)).MapOut
                .FpsFilter($"{FPS}").MapOut
                .FormatFilter(PixFmt.yuv420p).MapOut;

            var videoOut = new ImageFileOutput(outputFileName, out_map)
                .VSync(VSyncMethod.vfr)
                .SetOption("-rc-lookahead", 0)
                .SetOption("-g", 0)
                .VCodec("libx264")
                //.SetOption("-b:v", "3000")
                .Fps((int)FPS);

            ffmpegArg.AddOutput(videoOut);

            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
    }
}
