

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class FadeInOne
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
            var blendeds = startEnd.Blendeds(config, blend => blend
                .Shortest(true)
                .All_Expr(
                    $"A*(if( gte(T,{config.TransitionDuration.TotalSeconds}),{config.TransitionDuration.TotalSeconds},T/{config.TransitionDuration.TotalSeconds})) + " +
                    $"B*(1-(if(gte(T,{config.TransitionDuration.TotalSeconds}),{config.TransitionDuration.TotalSeconds},T/{config.TransitionDuration.TotalSeconds})))"));
            var out_map = overlaids.ConcatOverlaidsAndBlendeds(blendeds);
            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
                .ImageOutputAVStreams.First()
                    .Codec("libx264")
                    .Fps(config.Fps)
                    .SetOption("-g", "0")
                    .SetOption("-rc-lookahead", "0");
            ffmpegArg.AddOutput(imageFileOutput);
            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
    }
}
