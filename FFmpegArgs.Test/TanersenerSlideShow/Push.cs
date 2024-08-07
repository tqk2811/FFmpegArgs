﻿


namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class Push
    {
        [TestMethod]
        public void PushVerticalTopToBottomTest()
        {
            PushVerticalTest(VerticalDirection.TopToBottom);
        }
        [TestMethod]
        public void PushVerticalBottomToTopTest()
        {
            PushVerticalTest(VerticalDirection.BottomToTop);
        }
        public void PushVerticalTest(VerticalDirection verticalDirection)
        {
            ScreenMode screenMode = ScreenMode.Blur;
            string outputFileName = $"{nameof(PushVerticalTest)}-{screenMode}-{verticalDirection}.mp4";
            string filterFileName = $"{nameof(PushVerticalTest)}-{screenMode}-{verticalDirection}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput().VSync(VSyncMethod.vfr);
            var images_inputmap = ffmpegArg.GetImagesInput();
            Config config = new Config();
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count - config.TransitionDuration;
            ImageFilterGraphInput background_fi = new ImageFilterGraphInput();
            background_fi.FilterGraph.ColorFilter().Color(config.BackgroundColor).Size(config.Size).MapOut.FpsFilter().Fps(config.Fps);
            ImageMap background = ffmpegArg.AddImagesInput(background_fi).First();
            ImageFilterGraphInput transparent_fi = new ImageFilterGraphInput();
            transparent_fi.FilterGraph.NullsrcFilter().Size(config.Size).MapOut.FpsFilter().Fps(config.Fps);
            ImageMap transparent = ffmpegArg.AddImagesInput(transparent_fi).First();
            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenModes(screenMode, config);
            List<ImageMap> overlaids = new List<ImageMap>();
            List<ImageMap> startings = new List<ImageMap>();
            List<ImageMap> endings = new List<ImageMap>();
            for (int i = 0; i < images_inputmap.Count; i++)
            {
                overlaids.Add(prepareInputs[i].First()
                    .OverlayFilterOn(background)
                        .X("(main_w-overlay_w)/2")
                        .Y("(main_h-overlay_h)/2")
                        .Format(OverlayPixFmt.rgb).MapOut
                    .TrimFilter().Duration(config.ImageDuration).MapOut
                    .SelectFilter($"lte(n,{config.ImageFrameCount})").MapOut);
                var temp = prepareInputs[i].Last()
                    .OverlayFilterOn(background)
                        .X($"(main_w-overlay_w)/2")
                        .Y($"(main_h-overlay_h)/2")
                        .Format(OverlayPixFmt.rgb).MapOut
                    .TrimFilter().Duration(config.TransitionDuration).MapOut
                    .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut;
                if (i == 0)
                {
                    endings.Add(temp);
                }
                else if (i == images_inputmap.Count - 1)
                {
                    startings.Add(temp);
                }
                else
                {
                    var split = temp.SplitFilter(2).MapsOut;
                    startings.Add(split.First());
                    endings.Add(split.Last());
                }
            }
            List<ImageMap> blendeds = new List<ImageMap>();
            for (int i = 0; i < endings.Count; i++)
            {
                switch (verticalDirection)
                {
                    case VerticalDirection.TopToBottom:
                        {
                            var moving = endings[i]
                                .OverlayFilterOn(transparent)
                                    .X("0")
                                    .Y($"t/{config.TransitionDuration.TotalSeconds}*{config.Size.Height}").MapOut
                                .TrimFilter()
                                    .Duration(config.TransitionDuration).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut;
                            blendeds.Add(startings[i]
                                .OverlayFilterOn(moving)
                                    .X("0")
                                    .Y($"-h+t/{config.TransitionDuration.TotalSeconds}*{config.Size.Height}")
                                    .Shortest(true).MapOut
                                .TrimFilter()
                                    .Duration(config.TransitionDuration).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut);
                        }
                        break;
                    case VerticalDirection.BottomToTop:
                        {
                            var moving = endings[i]
                                .OverlayFilterOn(transparent)
                                    .X("0")
                                    .Y($"-t/{config.TransitionDuration.TotalSeconds}*{config.Size.Height}").MapOut
                                .TrimFilter()
                                    .Duration(config.TransitionDuration).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut;
                            blendeds.Add(startings[i]
                                .OverlayFilterOn(moving)
                                    .X("0")
                                    .Y($"h-t/{config.TransitionDuration.TotalSeconds}*{config.Size.Height}")
                                    .Shortest(true).MapOut
                                .TrimFilter()
                                    .Duration(config.TransitionDuration).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut);
                        }
                        break;
                }
            }
            var out_map = overlaids.ConcatOverlaidsAndBlendeds(blendeds);
            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
                .Duration(TOTAL_DURATION)
                .ImageOutputAVStreams.First()
                    .Codec("libx264")
                    //.Fps(config.Fps)
                    .SetOption("-g", "0")
                    .SetOption("-rc-lookahead", "0");
            ffmpegArg.AddOutput(imageFileOutput);
            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
        [TestMethod]
        public void PushHorizontalTopToBottomTest()
        {
            PushHorizontalTest(HorizontalDirection.LeftToRight);
        }
        [TestMethod]
        public void PushHorizontalBottomToTopTest()
        {
            PushHorizontalTest(HorizontalDirection.RightToLeft);
        }
        public void PushHorizontalTest(HorizontalDirection horizontalDirection)
        {
            ScreenMode screenMode = ScreenMode.Blur;
            string outputFileName = $"{nameof(PushHorizontalTest)}-{screenMode}-{horizontalDirection}.mp4";
            string filterFileName = $"{nameof(PushHorizontalTest)}-{screenMode}-{horizontalDirection}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput().VSync(VSyncMethod.vfr);
            var images_inputmap = ffmpegArg.GetImagesInput();
            Config config = new Config();
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count - config.TransitionDuration;
            ImageFilterGraphInput background_fi = new ImageFilterGraphInput();
            background_fi.FilterGraph.ColorFilter().Color(config.BackgroundColor).Size(config.Size).MapOut.FpsFilter().Fps(config.Fps);
            ImageMap background = ffmpegArg.AddImagesInput(background_fi).First();
            ImageFilterGraphInput transparent_fi = new ImageFilterGraphInput();
            transparent_fi.FilterGraph.NullsrcFilter().Size(config.Size).MapOut.FpsFilter().Fps(config.Fps);
            ImageMap transparent = ffmpegArg.AddImagesInput(transparent_fi).First();
            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenModes(screenMode, config);
            List<ImageMap> overlaids = new List<ImageMap>();
            List<ImageMap> startings = new List<ImageMap>();
            List<ImageMap> endings = new List<ImageMap>();
            for (int i = 0; i < images_inputmap.Count; i++)
            {
                overlaids.Add(prepareInputs[i].First()
                    .OverlayFilterOn(background)
                        .X("(main_w-overlay_w)/2")
                        .Y("(main_h-overlay_h)/2")
                        .Format(OverlayPixFmt.rgb).MapOut
                    .TrimFilter().Duration(config.ImageDuration).MapOut
                    .SelectFilter($"lte(n,{config.ImageFrameCount})").MapOut);
                var temp = prepareInputs[i].Last()
                    .OverlayFilterOn(background)
                        .X($"(main_w-overlay_w)/2")
                        .Y($"(main_h-overlay_h)/2")
                        .Format(OverlayPixFmt.rgb).MapOut
                    .TrimFilter().Duration(config.TransitionDuration).MapOut
                    .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut;
                if (i == 0)
                {
                    endings.Add(temp);
                }
                else if (i == images_inputmap.Count - 1)
                {
                    startings.Add(temp);
                }
                else
                {
                    var split = temp.SplitFilter(2).MapsOut;
                    startings.Add(split.First());
                    endings.Add(split.Last());
                }
            }
            List<ImageMap> blendeds = new List<ImageMap>();
            for (int i = 0; i < endings.Count; i++)
            {
                switch (horizontalDirection)
                {
                    case HorizontalDirection.LeftToRight:
                        {
                            var moving = endings[i]
                                .OverlayFilterOn(transparent)
                                    .X($"t/{config.TransitionDuration.TotalSeconds}*{config.Size.Width}")
                                    .Y($"0").MapOut
                                .TrimFilter()
                                    .Duration(config.TransitionDuration).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut;
                            blendeds.Add(startings[i]
                                .OverlayFilterOn(moving)
                                    .X($"-w+t/{config.TransitionDuration.TotalSeconds}*{config.Size.Width}")
                                    .Y($"0")
                                    .Shortest(true).MapOut
                                .TrimFilter()
                                    .Duration(config.TransitionDuration).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut);
                        }
                        break;
                    case HorizontalDirection.RightToLeft:
                        {
                            var moving = endings[i]
                                .OverlayFilterOn(transparent)
                                    .X($"-t/{config.TransitionDuration.TotalSeconds}*{config.Size.Width}")
                                    .Y("0").MapOut
                                .TrimFilter()
                                    .Duration(config.TransitionDuration).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut;
                            blendeds.Add(startings[i]
                                .OverlayFilterOn(moving)
                                    .Y("0")
                                    .X($"w-t/{config.TransitionDuration.TotalSeconds}*{config.Size.Width}")
                                    .Shortest(true).MapOut
                                .TrimFilter()
                                    .Duration(config.TransitionDuration).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut);
                        }
                        break;
                }
            }
            var out_map = overlaids.ConcatOverlaidsAndBlendeds(blendeds);
            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
                .Duration(TOTAL_DURATION)
                .ImageOutputAVStreams.First()
                    .Codec("libx264")
                    //.Fps(config.Fps)
                    .SetOption("-g", "0")
                    .SetOption("-rc-lookahead", "0");
            ffmpegArg.AddOutput(imageFileOutput);
            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
    }
}
