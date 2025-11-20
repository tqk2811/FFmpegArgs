


using FFmpegArgs.Codec.Encoders.Images;

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class BarsOne
    {
        [TestMethod]
        public void BarsOneVerticalTest_Blur()
        {
            Config config = new Config();
            BarsOneVerticalTest(config, ScreenMode.Blur);
        }
        public void BarsOneVerticalTest(Config config, ScreenMode screenMode)
        {
            string outputFileName = $"{nameof(BarsOneVerticalTest)}-{screenMode}.mp4";
            string filterFileName = $"{nameof(BarsOneVerticalTest)}-{screenMode}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput().VSync(VSyncMethod.vfr);
            var images_inputmap = ffmpegArg.GetImagesInput();
            int BAR_COUNT = 16;
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count - config.TransitionDuration;
            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenModes(screenMode, config);
            var overlaids = prepareInputs.Select(x => x.First()).Overlaids(config);
            var startEnd = prepareInputs.Select(x => x.Last()).ToList().StartEnd(config);
            var blendeds = startEnd.Blendeds(config, blend => blend
                .Shortest(true)
                .All_Expr($"if((lte(mod(X,({config.Size.Width}/{BAR_COUNT})),({config.Size.Width}/{BAR_COUNT})*T/{config.TransitionDuration.TotalSeconds})),A,B)"));
            var out_map = overlaids.ConcatOverlaidsAndBlendeds(blendeds);
            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
                .ImageStreams.First()
                //.Fps(config.Fps)
                .G(0)
                .H264_libx264_Codec()
                    .RCLookahead(0)
                ;
            ffmpegArg.AddOutput(imageFileOutput);
            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
        [TestMethod]
        public void BarsOneHorizontalTest_Blur()
        {
            Config config = new Config();
            BarsOneHorizontalTest(config, ScreenMode.Blur);
        }
        public void BarsOneHorizontalTest(Config config, ScreenMode screenMode)
        {
            string outputFileName = $"{nameof(BarsOneHorizontalTest)}-{screenMode}.mp4";
            string filterFileName = $"{nameof(BarsOneHorizontalTest)}-{screenMode}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput().VSync(VSyncMethod.vfr);
            var images_inputmap = ffmpegArg.GetImagesInput();
            int BAR_COUNT = 16;
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count - config.TransitionDuration;
            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenModes(screenMode, config);
            var overlaids = prepareInputs.Select(x => x.First()).Overlaids(config);
            var startEnd = prepareInputs.Select(x => x.Last()).ToList().StartEnd(config);
            var blendeds = startEnd.Blendeds(config, blend => blend
                .Shortest(true)
                .All_Expr($"if((lte(mod(Y,({config.Size.Height}/{BAR_COUNT})),({config.Size.Height}/{BAR_COUNT})*T/{config.TransitionDuration.TotalSeconds})),A,B)"));
            var out_map = overlaids.ConcatOverlaidsAndBlendeds(blendeds);
            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
                .ImageStreams.First()
                .G(0)
                .H264_libx264_Codec()
                    .RCLookahead(0)
                    ;
            ffmpegArg.AddOutput(imageFileOutput);
            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
    }
}
