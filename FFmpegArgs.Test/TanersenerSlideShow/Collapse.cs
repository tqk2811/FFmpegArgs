


namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class Collapse
    {
        [TestMethod]
        public void CollapseTest()
        {
            ScreenMode screenMode = ScreenMode.Blur;
            CollapseExpandMode collapseMode = CollapseExpandMode.Circular;
            string outputFileName = $"{nameof(CollapseTest)}-{screenMode}-{collapseMode}.mp4";
            string filterFileName = $"{nameof(CollapseTest)}-{screenMode}-{collapseMode}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput().VSync(VSyncMethod.vfr);
            var images_inputmap = ffmpegArg.GetImagesInput();
            Config config = new Config();
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count - config.TransitionDuration;
            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenModes(screenMode, config);
            var overlaids = prepareInputs.Select(x => x.First()).Overlaids(config);
            var startEnd = prepareInputs.Select(x => x.Last()).ToList().StartEnd(config);
            string expr = string.Empty;
            double TRANSITION_DURATION = config.TransitionDuration.TotalSeconds;
            
            switch (collapseMode)
            {
                case CollapseExpandMode.Vertical:
                    expr = Invariant($"if(gte(Y,(H/2)*T/{TRANSITION_DURATION})*lte(Y,H-(H/2)*T/{TRANSITION_DURATION}),B,A)");
                    break;
                case CollapseExpandMode.Horizontal:
                    expr = Invariant($"if(gte(X,(W/2)*T/{TRANSITION_DURATION})*lte(X,W-(W/2)*T/{TRANSITION_DURATION}),B,A)");
                    break;
                case CollapseExpandMode.Circular:
                    StartEnd _startEnd = new StartEnd();
                    _startEnd.Startings = startEnd.Startings.Select(x => x
                        .GeqFilter()
                            .Lum("p(X,Y)")
                            .A((FormattableString)$"if(lte(pow(sqrt(pow(W/2,2)+pow(H/2,2))-sqrt(pow(T/{TRANSITION_DURATION}*W/2,2)+pow(T/{TRANSITION_DURATION}*H/2,2)),2),pow(X-(W/2),2)+pow(Y-(H/2),2)),255,0)").MapOut).ToList();
                    _startEnd.Endings = startEnd.Endings;
                    startEnd = _startEnd;
                    break;
                case CollapseExpandMode.Both:
                    expr = Invariant($"if((gte(X,(W/2)*T/{TRANSITION_DURATION})*gte(Y,(H/2)*T/{TRANSITION_DURATION}))*(lte(X,W-(W/2)*T/{TRANSITION_DURATION})*lte(Y,H-(H/2)*T/{TRANSITION_DURATION})),B,A)");
                    break;
            }
            ImageMap? out_map = null;
            switch (collapseMode)
            {
                case CollapseExpandMode.Circular:
                    {
                        var blendeds = new List<ImageMap>();
                        for (int i = 0; i < startEnd.Startings.Count; i++)
                        {
                            blendeds.Add(startEnd.Startings[i].OverlayFilterOn(startEnd.Endings[i])
                                .X("0").Y("0").Shortest(true).MapOut);
                        }
                        out_map = overlaids.ConcatOverlaidsAndBlendeds(blendeds);
                    }
                    break;
                default:
                    {
                        var blendeds = startEnd.Blendeds(config, blend =>
                        {
                            blend.Shortest(true);
                            blend.All_Expr(expr);
                        });
                        out_map = overlaids.ConcatOverlaidsAndBlendeds(blendeds);
                    }
                    break;
            }

            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
              .Duration(TOTAL_DURATION)
              .ImageStreams.First()
                  .Codec("libx264")
                  //.Fps(config.Fps)
                  .SetOption("-g", "0")
                  .SetOption("-rc-lookahead", "0");
            ffmpegArg.AddOutput(imageFileOutput);
            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
    }
}
