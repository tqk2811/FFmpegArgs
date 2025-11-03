

using System.Globalization;

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class FadeInOne : BaseTest
    {
        /// <summary>
        /// Same as BlurredBackground
        /// </summary>
        [TestMethod]
        public void FadeInOneTest()
        {
            string outputFileName = $"{nameof(FadeInOneTest)}.mp4";
            string filterFileName = $"{nameof(FadeInOneTest)}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput().VSync(VSyncMethod.vfr);
            var images_inputmap = ffmpegArg.GetImagesInput();
            Config config = new Config();
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count - config.TransitionDuration;
            ScreenMode screenMode = ScreenMode.Blur;
            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenModes(screenMode, config);
            var overlaids = prepareInputs.Select(x => x.First()).Overlaids(config);
            var startEnd = prepareInputs.Select(x => x.Last()).ToList().StartEnd(config);
            string TRANSITION_DURATION = config.TransitionDuration.TotalSeconds.ToString(CultureInfo.InvariantCulture);
            var blendeds = startEnd.Blendeds(config, blend => blend
                .Shortest(true)
                .All_Expr(
                    Invariant($"A*(if( gte(T,{TRANSITION_DURATION}),{TRANSITION_DURATION},T/{TRANSITION_DURATION})) + ") +
                    Invariant($"B*(1-(if(gte(T,{TRANSITION_DURATION}),{TRANSITION_DURATION},T/{TRANSITION_DURATION})))")
                    ));
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
