


namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class PushBox
    {
        [TestMethod]
        public void PushBoxVerticalTopToBottomTest()
        {
            PushBoxVerticalTest(VerticalDirection.TopToBottom);
        }
        [TestMethod]
        public void PushBoxVerticalBottomToTopTest()
        {
            PushBoxVerticalTest(VerticalDirection.BottomToTop);
        }
        public void PushBoxVerticalTest(VerticalDirection verticalDirection)
        {
            ScreenMode screenMode = ScreenMode.Blur;
            string outputFileName = $"{nameof(PushBoxVerticalTest)}-{screenMode}-{verticalDirection}.mp4";
            string filterFileName = $"{nameof(PushBoxVerticalTest)}-{screenMode}-{verticalDirection}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var images_inputmap = ffmpegArg.GetImagesInput();
            Config config = new Config();
            config.TransitionDuration = TimeSpan.FromSeconds(1);
            TimeSpan TOTAL_DURATION = (config.ImageDuration + 2 * config.TransitionDuration) * images_inputmap.Count +
                config.TransitionDuration * 2 * images_inputmap.Count / 5;
            TOTAL_DURATION = config.ImageDuration * images_inputmap.Count + (29 * config.TransitionDuration * images_inputmap.Count + 5 * config.TransitionDuration) / 10;
            var TRANSITION_PHASE_DURATION = config.TransitionDuration / 2;
            var CHECKPOINT_DURATION = config.TransitionDuration / 5;
            ImageFilterGraphInput background_fi = new ImageFilterGraphInput();
            background_fi.FilterGraph.ColorFilter().Color(config.BackgroundColor).Size(config.Size).MapOut.FpsFilter().Fps(config.Fps);
            ImageMap background = ffmpegArg.AddImagesInput(background_fi).First();
            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenModes(screenMode, config);
            List<ImageMap> overlaids = prepareInputs.Select(x => x.First()
                .TrimFilter().Duration(config.ImageDuration).MapOut
                .SelectFilter($"lte(n,{config.ImageFrameCount})").MapOut).ToList();
            List<List<ImageMap>> pres = prepareInputs.Select(x => x.Last()
                .ScaleFilter()
                    .W($"{config.Size.Width}/2")
                    .H("-1").MapOut
                .PadFilter()
                    .W($"{config.Size.Width}")
                    .H($"{config.Size.Height}")
                    .X("(ow-iw)/2")
                    .Y("(oh-ih)/2")
                    .Color(config.BackgroundColor).MapOut
                .TrimFilter().Duration(config.TransitionDuration).MapOut
                .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut
                .SplitFilter(5).MapsOut.ToList()).ToList();//prephasein, checkpoint, prezoomin, prezoomout, prephaseout
            var phaseouts = verticalDirection switch
            {
                VerticalDirection.TopToBottom => pres.Select(x => x[4]//prephaseout
                                .OverlayFilterOn(background)
                                    .X("0")
                                    .Y($"t/({config.TransitionDuration.TotalSeconds}/2)*{config.Size.Height}").MapOut
                                .TrimFilter().Duration(TRANSITION_PHASE_DURATION).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount}/2)").MapOut).ToList(),
                VerticalDirection.BottomToTop => pres.Select(x => x[4]//prephaseout
                                .OverlayFilterOn(background)
                                    .X("0")
                                    .Y($"-t/({config.TransitionDuration.TotalSeconds}/2)*{config.Size.Height}").MapOut
                                .TrimFilter().Duration(TRANSITION_PHASE_DURATION).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount}/2)").MapOut).ToList(),
                _ => throw new NotImplementedException()
            };
            var phaseins = verticalDirection switch
            {
                VerticalDirection.TopToBottom => pres.Select(x => x[0]//prephasein
                                .OverlayFilterOn(pres.IndexOf(x) == 0 ? background : phaseouts[pres.IndexOf(x)-1])//phaseouts.Last()
                                    .X("0")
                                    .Y($"-h+{config.Size.Height}*t/({config.TransitionDuration.TotalSeconds}/2)").MapOut
                                .TrimFilter().Duration(TRANSITION_PHASE_DURATION).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount}/2)").MapOut).ToList(),
                VerticalDirection.BottomToTop => pres.Select(x => x[0]//prephasein
                                .OverlayFilterOn(pres.IndexOf(x) == 0 ? background : phaseouts[pres.IndexOf(x)-1])//phaseouts.Last()
                                    .X("0")
                                    .Y($"h-{config.Size.Height}*t/({config.TransitionDuration.TotalSeconds}/2)").MapOut
                                .TrimFilter().Duration(TRANSITION_PHASE_DURATION).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount}/2)").MapOut).ToList(),
                _ => throw new NotImplementedException()
            };
            List<List<ImageMap>> checkin_checkout = pres.Select(x => x[1]//checkpoint
                .TrimFilter().Duration(CHECKPOINT_DURATION).MapOut
                .SplitFilter(2).MapsOut.ToList()).ToList();
            var checkins = checkin_checkout.Select(x => x.First()).ToList();
            var checkouts = checkin_checkout.Select(x => x.Last()).ToList();
            var zoomins = pres.Select(x => x[2]
                .ScaleFilter()
                    .W("iw*5")
                    .H("ih*5").MapOut
                .ZoompanFilter()
                    .Zoom("min(pzoom+0.04,2)")
                    .D(config.TransitionDuration)
                    .Fps(config.Fps)
                    .X("iw/2-(iw/zoom/2)")
                    .Y("ih/2-(ih/zoom/2)")
                    .S(config.Size).MapOut
                .SetPtsFilter("0.5*PTS").MapOut).ToList();
            var zoomouts = pres.Select(x => x[3]
                .ScaleFilter()
                    .W("iw*5")
                    .H("ih*5").MapOut
                .ZoompanFilter()
                    .Zoom("2-in*0.04")
                    .D(config.TransitionDuration)
                    .Fps(config.Fps)
                    .X("iw/2-(iw/zoom/2)")
                    .Y("ih/2-(ih/zoom/2)")
                    .S(config.Size).MapOut
                .SetPtsFilter("0.5*PTS").MapOut).ToList();
            List<ConcatGroup> concatGroups = new List<ConcatGroup>();
            for(int i = 0; i< images_inputmap.Count; i++)
            {
                concatGroups.Add(new ConcatGroup(phaseins[i]));//TRANSITION_PHASE_DURATION = TransitionDuration/2
                concatGroups.Add(new ConcatGroup(checkins[i]));//CHECKPOINT_DURATION = TransitionDuration/5
                concatGroups.Add(new ConcatGroup(zoomins[i]));//TransitionDuration
                concatGroups.Add(new ConcatGroup(overlaids[i]));//ImageDuration
                concatGroups.Add(new ConcatGroup(zoomouts[i]));//TransitionDuration
                concatGroups.Add(new ConcatGroup(checkouts[i]));//CHECKPOINT_DURATION
            }
            concatGroups.Add(new ConcatGroup(phaseouts.Last()));//TRANSITION_PHASE_DURATION
            //total = (TRANSITION_PHASE_DURATION + 2*CHECKPOINT_DURATION + 2*TransitionDuration + ImageDuration) * ImageCount + TRANSITION_PHASE_DURATION
            //=(TransitionDuration/2 + 2 * TransitionDuration/5 + 2*TransitionDuration + ImageDuration) * ImageCount + TransitionDuration/2
            //=(5*TransitionDuration + 4*TransitionDuration + 2*10*TransitionDuration + 10*ImageDuration)*ImageCount / 10 + TransitionDuration/2
            //=(29*TransitionDuration + 10*ImageDuration)*ImageCount / 10 + TransitionDuration/2
            //=ImageDuration * ImageCount + (29*TransitionDuration*ImageCount + 5*TransitionDuration)/10
            ConcatFilter concatFilter = new ConcatFilter(concatGroups);
            var out_map = concatFilter.ImageMapsOut.First().FormatFilter(PixFmt.yuv420p).MapOut;
            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
              .VSync(VSyncMethod.vfr)
              .SetOption("-c:v", "libx264")
              .Duration(TOTAL_DURATION)
              .Fps(config.Fps)
              .SetOption("-g", "0")
              .SetOption("-rc-lookahead", "0");
            ffmpegArg.AddOutput(imageFileOutput);
            ffmpegArg.TestRender(filterFileName, outputFileName);
        }

        [TestMethod]
        public void PushBoxHorizontalTopToBottomTest()
        {
            PushBoxHorizontalTest(HorizontalDirection.LeftToRight);
        }
        [TestMethod]
        public void PushBoxHorizontalBottomToTopTest()
        {
            PushBoxHorizontalTest(HorizontalDirection.RightToLeft);
        }
        public void PushBoxHorizontalTest(HorizontalDirection horizontalDirection)
        {
            ScreenMode screenMode = ScreenMode.Blur;
            string outputFileName = $"{nameof(PushBoxHorizontalTest)}-{screenMode}-{horizontalDirection}.mp4";
            string filterFileName = $"{nameof(PushBoxHorizontalTest)}-{screenMode}-{horizontalDirection}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var images_inputmap = ffmpegArg.GetImagesInput();
            Config config = new Config();
            config.TransitionDuration = TimeSpan.FromSeconds(1);
            TimeSpan TOTAL_DURATION = (config.ImageDuration + 2 * config.TransitionDuration) * images_inputmap.Count +
                config.TransitionDuration * 2 * images_inputmap.Count / 5;
            TOTAL_DURATION = config.ImageDuration * images_inputmap.Count + (29 * config.TransitionDuration * images_inputmap.Count + 5 * config.TransitionDuration) / 10;
            var TRANSITION_PHASE_DURATION = config.TransitionDuration / 2;
            var CHECKPOINT_DURATION = config.TransitionDuration / 5;
            ImageFilterGraphInput background_fi = new ImageFilterGraphInput();
            background_fi.FilterGraph.ColorFilter().Color(config.BackgroundColor).Size(config.Size).MapOut.FpsFilter().Fps(config.Fps);
            ImageMap background = ffmpegArg.AddImagesInput(background_fi).First();
            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenModes(screenMode, config);
            List<ImageMap> overlaids = prepareInputs.Select(x => x.First()
                .TrimFilter().Duration(config.ImageDuration).MapOut
                .SelectFilter($"lte(n,{config.ImageFrameCount})").MapOut).ToList();
            List<List<ImageMap>> pres = prepareInputs.Select(x => x.Last()
                .ScaleFilter()
                    .W($"{config.Size.Width}/2")
                    .H("-1").MapOut
                .PadFilter()
                    .W($"{config.Size.Width}")
                    .H($"{config.Size.Height}")
                    .X("(ow-iw)/2")
                    .Y("(oh-ih)/2")
                    .Color(config.BackgroundColor).MapOut
                .TrimFilter().Duration(config.TransitionDuration).MapOut
                .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut
                .SplitFilter(5).MapsOut.ToList()).ToList();//prephasein, checkpoint, prezoomin, prezoomout, prephaseout
            var phaseouts = horizontalDirection switch
            {
                HorizontalDirection.LeftToRight => pres.Select(x => x[4]//prephaseout
                                .OverlayFilterOn(background)
                                    .Y("0")
                                    .X($"t/({config.TransitionDuration.TotalSeconds}/2)*{config.Size.Width}").MapOut
                                .TrimFilter().Duration(TRANSITION_PHASE_DURATION).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount}/2)").MapOut).ToList(),
                HorizontalDirection.RightToLeft => pres.Select(x => x[4]//prephaseout
                                .OverlayFilterOn(background)
                                    .Y("0")
                                    .X($"-t/({config.TransitionDuration.TotalSeconds}/2)*{config.Size.Width}").MapOut
                                .TrimFilter().Duration(TRANSITION_PHASE_DURATION).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount}/2)").MapOut).ToList(),
                _ => throw new NotImplementedException()
            };
            var phaseins = horizontalDirection switch
            {
                HorizontalDirection.LeftToRight => pres.Select(x => x[0]//prephasein
                                .OverlayFilterOn(pres.IndexOf(x) == 0 ? background : phaseouts[pres.IndexOf(x) - 1])//phaseouts.Last()
                                    .Y("0")
                                    .X($"-{config.Size.Width}+{config.Size.Width}*t/({config.TransitionDuration.TotalSeconds}/2)").MapOut
                                .TrimFilter().Duration(TRANSITION_PHASE_DURATION).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount}/2)").MapOut).ToList(),
                HorizontalDirection.RightToLeft => pres.Select(x => x[0]//prephasein
                                .OverlayFilterOn(pres.IndexOf(x) == 0 ? background : phaseouts[pres.IndexOf(x) - 1])//phaseouts.Last()
                                    .Y("0")
                                    .X($"{config.Size.Width}-{config.Size.Width}*t/({config.TransitionDuration.TotalSeconds}/2)").MapOut
                                .TrimFilter().Duration(TRANSITION_PHASE_DURATION).MapOut
                                .SelectFilter($"lte(n,{config.TransitionFrameCount}/2)").MapOut).ToList(),
                _ => throw new NotImplementedException()
            };
            List<List<ImageMap>> checkin_checkout = pres.Select(x => x[1]//checkpoint
                .TrimFilter().Duration(CHECKPOINT_DURATION).MapOut
                .SplitFilter(2).MapsOut.ToList()).ToList();
            var checkins = checkin_checkout.Select(x => x.First()).ToList();
            var checkouts = checkin_checkout.Select(x => x.Last()).ToList();
            var zoomins = pres.Select(x => x[2]
                .ScaleFilter()
                    .W("iw*5")
                    .H("ih*5").MapOut
                .ZoompanFilter()
                    .Zoom("min(pzoom+0.04,2)")
                    .D(config.TransitionDuration)
                    .Fps(config.Fps)
                    .X("iw/2-(iw/zoom/2)")
                    .Y("ih/2-(ih/zoom/2)")
                    .S(config.Size).MapOut
                .SetPtsFilter("0.5*PTS").MapOut).ToList();
            var zoomouts = pres.Select(x => x[3]
                .ScaleFilter()
                    .W("iw*5")
                    .H("ih*5").MapOut
                .ZoompanFilter()
                    .Zoom("2-in*0.04")
                    .D(config.TransitionDuration)
                    .Fps(config.Fps)
                    .X("iw/2-(iw/zoom/2)")
                    .Y("ih/2-(ih/zoom/2)")
                    .S(config.Size).MapOut
                .SetPtsFilter("0.5*PTS").MapOut).ToList();
            List<ConcatGroup> concatGroups = new List<ConcatGroup>();
            for (int i = 0; i < images_inputmap.Count; i++)
            {
                concatGroups.Add(new ConcatGroup(phaseins[i]));//TRANSITION_PHASE_DURATION = TransitionDuration/2
                concatGroups.Add(new ConcatGroup(checkins[i]));//CHECKPOINT_DURATION = TransitionDuration/5
                concatGroups.Add(new ConcatGroup(zoomins[i]));//TransitionDuration
                concatGroups.Add(new ConcatGroup(overlaids[i]));//ImageDuration
                concatGroups.Add(new ConcatGroup(zoomouts[i]));//TransitionDuration
                concatGroups.Add(new ConcatGroup(checkouts[i]));//CHECKPOINT_DURATION
            }
            concatGroups.Add(new ConcatGroup(phaseouts.Last()));//TRANSITION_PHASE_DURATION
            //total = (TRANSITION_PHASE_DURATION + 2*CHECKPOINT_DURATION + 2*TransitionDuration + ImageDuration) * ImageCount + TRANSITION_PHASE_DURATION
            //=(TransitionDuration/2 + 2 * TransitionDuration/5 + 2*TransitionDuration + ImageDuration) * ImageCount + TransitionDuration/2
            //=(5*TransitionDuration + 4*TransitionDuration + 2*10*TransitionDuration + 10*ImageDuration)*ImageCount / 10 + TransitionDuration/2
            //=(29*TransitionDuration + 10*ImageDuration)*ImageCount / 10 + TransitionDuration/2
            //=ImageDuration * ImageCount + (29*TransitionDuration*ImageCount + 5*TransitionDuration)/10
            ConcatFilter concatFilter = new ConcatFilter(concatGroups);
            var out_map = concatFilter.ImageMapsOut.First().FormatFilter(PixFmt.yuv420p).MapOut;
            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
              .VSync(VSyncMethod.vfr)
              .SetOption("-c:v", "libx264")
              .Duration(TOTAL_DURATION)
              .Fps(config.Fps)
              .SetOption("-g", "0")
              .SetOption("-rc-lookahead", "0");
            ffmpegArg.AddOutput(imageFileOutput);
            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
    }
}
