


using System.Globalization;

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class BarsOne : BaseTest
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
                .All_Expr($"if((lte(mod(X,({config.Size.Width}/{BAR_COUNT})),({config.Size.Width}/{BAR_COUNT})*T/{config.TransitionDuration.TotalSeconds.ToString(CultureInfo.InvariantCulture)})),A,B)"));
            var out_map = overlaids.ConcatOverlaidsAndBlendeds(blendeds);
            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
                .ImageOutputAVStreams.First()
                .SetOption("-c", "libx264")
                //.Fps(config.Fps)
                .SetOption("-g", "0")
                .SetOption("-rc-lookahead", "0");
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
                .All_Expr($"if((lte(mod(Y,({config.Size.Height}/{BAR_COUNT})),({config.Size.Height}/{BAR_COUNT})*T/{config.TransitionDuration.TotalSeconds.ToString(CultureInfo.InvariantCulture)})),A,B)"));
            var out_map = overlaids.ConcatOverlaidsAndBlendeds(blendeds);
            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
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
