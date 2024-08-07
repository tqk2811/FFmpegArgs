﻿

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class PushFilm
    {
        [TestMethod]
        public void PushHorizontalFilm_Blur_LeftToRight()
        {
            PushHorizontalFilmTest(ScreenMode.Blur, HorizontalDirection.LeftToRight);
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
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput().VSync(VSyncMethod.vfr);
            var images_inputmap = ffmpegArg.GetImagesInput();
            Config config = new Config();
            TimeSpan TOTAL_DURATION = config.TransitionDuration * images_inputmap.Count;
            var film_strip_map = ffmpegArg.FilmStripH();
            var background = ffmpegArg.FilterGraph
                .ColorFilter()
                    .Color(config.BackgroundColor)
                    .Size(config.Size)
                    .Duration(TOTAL_DURATION).MapOut
                .FpsFilter().Fps(config.Fps).MapOut;
            List<ImageMap> images_Prepare = new List<ImageMap>();
            for (int i = 0; i < images_inputmap.Count; i++)
            {
                switch (screenMode)
                {
                    case ScreenMode.Center:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter()
                                    .W($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),min(iw,{config.Size.Width}),-1)")
                                    .H($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,min(ih,{config.Size.Height}))").MapOut
                                .ScaleFilter().W("trunc(iw/2)*2").H("trunc(ih/2)*2").MapOut
                                .PadFilter()
                                    .W($"{config.Size.Width}")
                                    .H($"{config.Size.Height}")
                                    .X($"({config.Size.Width}-iw)/2")
                                    .Y($"({config.Size.Height}-ih)/2")
                                    .Color(config.BackgroundColor).MapOut
                                .SetSarFilter().Ratio(1).MapOut);
                            break;
                        }
                    case ScreenMode.Crop:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter()
                                    .W($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,{config.Size.Width})")
                                    .H($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),{config.Size.Height},-1)").MapOut
                                .OverlayFilterOn(film_strip_map).X("0").Y("0").MapOut
                                .CropFilter()
                                    .W($"{config.Size.Width}")
                                    .H($"{config.Size.Height}").MapOut
                                .SetSarFilter().Ratio(1).MapOut);
                            break;
                        }
                    case ScreenMode.Scale:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter().W($"{config.Size.Width}").H($"{config.Size.Height}").MapOut
                                .SetSarFilter().Ratio(1).MapOut);
                            break;
                        }
                    case ScreenMode.Blur:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .MakeBlurredBackground(config.Size.Width, config.Size.Height, config.Fps, "100")
                                .FormatFilter(PixFmt.rgba).MapOut
                                .SetSarFilter().Ratio(1).MapOut);
                            break;
                        }
                }
            }
            var strip_images = film_strip_map
                .SetPtsFilter("PTS-STARTPTS").MapOut
                .ScaleFilter()
                    .W($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),min(iw,{config.Size.Width}),-1)")
                    .H($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,min(ih,{config.Size.Height}))").MapOut
                .ScaleFilter().W("trunc(iw/2)*2").H("trunc(ih/2)*2").MapOut
                .SetSarFilter().Ratio(1).MapOut
                .SplitFilter(images_inputmap.Count).MapsOut.ToList();
            // OVERLAY FILM STRIP ON TOP OF INPUTS
            List<ImageMap> image_overlay_on_strips = new List<ImageMap>();
            for (int i = 0; i < images_Prepare.Count; i++)
            {
                image_overlay_on_strips.Add(strip_images[i]
                    .OverlayFilterOn(images_Prepare[i]).X("(main_w-overlay_w)/2").Y("(main_h-overlay_h)/2").Format(OverlayPixFmt.rgb).MapOut);
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
                                .OverlayFilterOn(lastOverLay)
                                    .X($"-{config.Size.Width}+(t-{start.TotalSeconds})/{config.TransitionDuration.TotalSeconds}*{config.Size.Width}")
                                    .Y("0")//from -WIDTH to +WIDTH
                                    .Enable($"between(t,{start.TotalSeconds},{end.TotalSeconds})").MapOut;
                            break;
                        }
                    case HorizontalDirection.RightToLeft:
                        {
                            lastOverLay = image_overlay_on_strips[i].SetPtsFilter("PTS-STARTPTS").MapOut
                                .OverlayFilterOn(lastOverLay)
                                    .X($"{config.Size.Width}-(t-{start.TotalSeconds})/{config.TransitionDuration.TotalSeconds}*{config.Size.Width}")
                                    .Y("0")//from +WIDTH to -WIDTH
                                    .Enable($"between(t,{start.TotalSeconds},{end.TotalSeconds})").MapOut;
                            break;
                        }
                }
            }
            var out_map = lastOverLay
                .TrimFilter().Duration(TOTAL_DURATION).MapOut
                .FpsFilter().Fps(config.Fps).MapOut
                .FormatFilter(PixFmt.yuv420p).MapOut;
            var videoOut = new ImageFileOutput(outputFileName, out_map);
            videoOut.ImageOutputAVStreams.First()
                .Codec("libx264")
                .SetOption("-rc-lookahead", 0)
                .SetOption("-g", 0)
                //.SetOption("-b:v", "3000")
                //.Fps(config.Fps)
                ;
            ffmpegArg.AddOutput(videoOut);
            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
        [TestMethod]
        public void PushVerticalFilmTest_Center_BottomToTop()
        {
            PushVerticalFilmTest(ScreenMode.Center, VerticalDirection.BottomToTop);
        }
        [TestMethod]
        public void PushVerticalFilmTest_Crop_TopToBottom()
        {
            PushVerticalFilmTest(ScreenMode.Crop, VerticalDirection.TopToBottom);
        }
        public void PushVerticalFilmTest(ScreenMode screenMode, VerticalDirection direction)
        {
            string outputFileName = $"{nameof(PushVerticalFilmTest)}-{screenMode}-{direction}.mp4";
            string filterFileName = $"{nameof(PushVerticalFilmTest)}-{screenMode}-{direction}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput().VSync(VSyncMethod.vfr);
            var images_inputmap = ffmpegArg.GetImagesInput();
            Config config = new Config();
            TimeSpan TOTAL_DURATION = config.TransitionDuration * images_inputmap.Count;
            var film_strip_map = ffmpegArg.FilmStripV();
            var background = ffmpegArg.FilterGraph
               .ColorFilter()
                   .Color(config.BackgroundColor)
                   .Size(config.Size)
                   .Duration(TOTAL_DURATION).MapOut
               .FpsFilter().Fps(config.Fps).MapOut;
            List<ImageMap> images_Prepare = new List<ImageMap>();
            for (int i = 0; i < images_inputmap.Count; i++)
            {
                switch (screenMode)
                {
                    case ScreenMode.Center:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter()
                                    .W($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),min(iw,{config.Size.Width}),-1)")
                                    .H($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,min(ih,{config.Size.Height}))").MapOut
                                .ScaleFilter().W("trunc(iw/2)*2").H("trunc(ih/2)*2").MapOut
                                .PadFilter()
                                    .W($"{config.Size.Width}")
                                    .H($"{config.Size.Height}")
                                    .X($"({config.Size.Width}-iw)/2")
                                    .Y($"({config.Size.Height}-ih)/2")
                                    .Color(config.BackgroundColor).MapOut
                                .SetSarFilter().Ratio(1).MapOut);
                            break;
                        }
                    case ScreenMode.Crop:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter()
                                    .W($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,{config.Size.Width})")
                                    .H($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),{config.Size.Height},-1)").MapOut
                                .OverlayFilterOn(film_strip_map).X("0").Y("0").MapOut
                                .CropFilter().W($"{config.Size.Width}").H($"{config.Size.Height}").MapOut
                                .SetSarFilter().Ratio(1).MapOut);
                            break;
                        }
                    case ScreenMode.Scale:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter().W($"{config.Size.Width}").H($"{config.Size.Height}").MapOut
                                .SetSarFilter().Ratio(1).MapOut);
                            break;
                        }
                    case ScreenMode.Blur:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .MakeBlurredBackground(config.Size.Width, config.Size.Height, config.Fps, "100")
                                .FormatFilter(PixFmt.rgba).MapOut
                                .SetSarFilter().Ratio(1).MapOut);
                            break;
                        }
                }
            }
            var strip_images = film_strip_map
                .SetPtsFilter("PTS-STARTPTS").MapOut
                .ScaleFilter()
                    .W($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),min(iw,{config.Size.Width}),-1)")
                    .H($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,min(ih,{config.Size.Height}))").MapOut
                .ScaleFilter().W("trunc(iw/2)*2").H("trunc(ih/2)*2").MapOut
                .SetSarFilter().Ratio(1).MapOut
                .SplitFilter(images_inputmap.Count).MapsOut.ToList();
            // OVERLAY FILM STRIP ON TOP OF INPUTS
            List<ImageMap> image_overlay_on_strips = new List<ImageMap>();
            for (int i = 0; i < images_Prepare.Count; i++)
            {
                image_overlay_on_strips.Add(strip_images[i]
                    .OverlayFilterOn(images_Prepare[i])
                        .X("(main_w-overlay_w)/2")
                        .Y("(main_h-overlay_h)/2")
                        .Format(OverlayPixFmt.rgb).MapOut);
            }
            var lastOverLay = background;
            for (int i = 0; i < images_Prepare.Count; i++)
            {
                var start = i * config.TransitionDuration;
                var end = start + config.TransitionDuration * 2;
                switch (direction)
                {
                    case VerticalDirection.TopToBottom:
                        {
                            lastOverLay = image_overlay_on_strips[i].SetPtsFilter("PTS-STARTPTS").MapOut
                                .OverlayFilterOn(lastOverLay)
                                    .X("0")
                                    .Y($"-{config.Size.Height}+(t-{start.TotalSeconds})/{config.TransitionDuration.TotalSeconds}*{config.Size.Height}")//from -HEIGHT to +HEIGHT
                                    .Enable($"between(t,{start.TotalSeconds},{end.TotalSeconds})").MapOut;
                            break;
                        }
                    case VerticalDirection.BottomToTop:
                        {
                            lastOverLay = image_overlay_on_strips[i].SetPtsFilter("PTS-STARTPTS").MapOut
                                .OverlayFilterOn(lastOverLay)
                                    .X("0")
                                    .Y($"{config.Size.Height}-(t-{start.TotalSeconds})/{config.TransitionDuration.TotalSeconds}*{config.Size.Height}")//from +HEIGHT to -HEIGHT
                                    .Enable($"between(t,{start.TotalSeconds},{end.TotalSeconds})").MapOut;
                            break;
                        }
                }
            }
            var out_map = lastOverLay
                .TrimFilter().Duration(TOTAL_DURATION).MapOut
                .FpsFilter().Fps(config.Fps).MapOut
                .FormatFilter(PixFmt.yuv420p).MapOut;
            var videoOut = new ImageFileOutput(outputFileName, out_map);
            videoOut.ImageOutputAVStreams.First()                
                .SetOption("-rc-lookahead", 0)
                .SetOption("-g", 0)
                .Codec("libx264")
                //.SetOption("-b:v", "3000")
                //.Fps(config.Fps)
                ;
            ffmpegArg.AddOutput(videoOut);
            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
    }
}
