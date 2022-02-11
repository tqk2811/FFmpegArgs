


namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class Clock
    {
        [TestMethod]
        public void ClockTest_Blur()
        {
            ClockTest(ScreenMode.Blur);
        }
        public void ClockTest(ScreenMode screenMode)
        {
            string outputFileName = $"{nameof(ClockTest)}-{screenMode}.mp4";
            string filterFileName = $"{nameof(ClockTest)}-{screenMode}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var images_inputmap = ffmpegArg.GetImagesInput();
            Config config = new Config();
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count - config.TransitionDuration;
            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenModes(screenMode, config);
            var overlaids = prepareInputs.Select(x => x.First()).Overlaids(config);
            var startEnd = prepareInputs.Select(x => x.Last()).ToList().StartEnd(config);
            string expr = $"if(" +
                                $"lte(T,0.125)," +
                                $"if(" +
                                    $"gt(X,W/2)*lte(Y,H/2)*lte(X-W/2+Y-H/2,0)," +
                                    $"A," +
                                    $"B)," +
                                $"if(" +
                                    $"lte(T,0.25)," +
                                    $"if(" +
                                        $"gt(X,W/2)*lte(Y,H/2)," +
                                        $"A," +
                                        $"B)," +
                                    $"if(" +
                                        $"lte(T,0.375)," +
                                        $"if(" +
                                            $"(gt(X,W/2)*gt(Y,H/2)*gt(X-W/2-Y+H/2,0))+(gt(X,W/2)*lte(Y,H/2))," +
                                            $"A," +
                                            $"B)," +
                                        $"if(" +
                                            $"lte(T,0.5)," +
                                            $"if(" +
                                                $"gt(X,W/2)," +
                                                $"A," +
                                                $"B)," +
                                            $"if(" +
                                                $"lte(T,0.625)," +
                                                $"if(" +
                                                    $"(lte(X,W/2)*gt(Y,H/2)*gt(X-W/2+Y-H/2,0))+gt(X,W/2)," +
                                                    $"A," +
                                                    $"B)," +
                                                $"if(" +
                                                    $"lte(T,0.75)," +
                                                    $"if(" +
                                                        $"(lte(X,W/2)*gt(Y,H/2))+gt(X,W/2)," +
                                                        $"A," +
                                                        $"B)," +
                                                    $"if(" +
                                                        $"lte(T,0.875)," +
                                                        $"if(" +
                                                            $"(lte(X,W/2)*lte(Y,H/2)*lte(Y-H/2-X+W/2,0))," +
                                                            $"B," +
                                                            $"A)," +
                                                            $"A)))))))";
            var blendeds = startEnd.Blendeds(config, blend => blend
                .Shortest(true)
                .All_Expr(expr));
            var out_map = overlaids.ConcatOverlaidsAndBlendeds(blendeds);
            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
              .VSync(VSyncMethod.vfr)
              .SetOption("-c:v", "libx264")
              .Fps(config.Fps)
              .SetOption("-g", "0")
              .SetOption("-rc-lookahead", "0");
            ffmpegArg.AddOutput(imageFileOutput);
            ffmpegArg.TestRender(filterFileName, outputFileName);
        }



        [TestMethod]
        public void ClockTestCustom_Blur()
        {
            ClockTestCustom(ScreenMode.Blur);
        }
        public void ClockTestCustom(ScreenMode screenMode)
        {
            string outputFileName = $"{nameof(ClockTestCustom)}-{screenMode}.mp4";
            string filterFileName = $"{nameof(ClockTestCustom)}-{screenMode}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var images_inputmap = ffmpegArg.GetImagesInput();
            Config config = new Config();
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count - config.TransitionDuration;
            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenModes(screenMode, config);
            var overlaids = prepareInputs.Select(x => x.First()).Overlaids(config);
            var startEnd = prepareInputs.Select(x => x.Last()).ToList().StartEnd(config);
            // (0.5W, 0.5H) -> (0.5W, 0) => vecto v1 = (0.5W-0.5W,0-0.5H)   = (0        ,    -0.5*H)
            // (0.5W, 0.5H) -> (X, Y) => vecto v2                           = (X - 0.5*W ,   Y - 0.5*H);
            // cos(v1,v2) = (a1*a2 + b1*b2)/[sqrt(a1*a1 + b1*b1) * sqrt(a2*a2 + b2*b2)]
            // = (-0.5*H * (Y - 0.5*H))/(sqrt(0.5*H*0.5*H) * sqrt((X - 0.5*W)*(X - 0.5*W) + (Y - 0.5*H)*(Y - 0.5*H)))
            //0 degrees => 1, 90 degrees => 0, 180 degrees => -1:   cos range 1 -> -1, acos 0 -> PI
            //                                                      cos range -1 -> 1, acos PI -> 0
            var cos_result = "((-0.5*H * (Y - 0.5*H))/(0.5*H * sqrt((X - 0.5*W)*(X - 0.5*W) + (Y - 0.5*H)*(Y - 0.5*H))))";
            var expr = $"if(" +
                            $"lt(T,{config.TransitionDuration.TotalSeconds})," +
                            $"if(" +
                                $"lte(" +
                                    $"if(" +
                                        $"gte(X,W/2)," +
                                        $"acos({cos_result})," +// 0 -> PI
                                        $"2*PI-acos({cos_result}))," +// PI -> 0 => 2PI -  (PI -> 0) = PI -> 2PI
                                        $"T*2*PI/{config.TransitionDuration.TotalSeconds})," +//0 -> 2 PI
                                $"A," +
                                $"B)," +
                            $"B)";
            var blendeds = startEnd.Blendeds(config, blend => blend
                .Shortest(true)
                .All_Expr(expr));
            var out_map = overlaids.ConcatOverlaidsAndBlendeds(blendeds);
            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
              .VSync(VSyncMethod.vfr)
              .SetOption("-c:v", "libx264")
              .Fps(config.Fps)
              .SetOption("-g", "0")
              .SetOption("-rc-lookahead", "0");
            ffmpegArg.AddOutput(imageFileOutput);
            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
    }
}
