

using System.Globalization;

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class BlurredBackground : BaseTest
    {
        /// <summary>
        /// https://github.com/tanersener/ffmpeg-video-slideshow-scripts/blob/master/advanced_scripts/blurred_background.sh
        /// </summary>
        [TestMethod]
        public void BlurredBackgroundTest() //=>FadeInOne
        {
            string outputFileName = $"{nameof(BlurredBackgroundTest)}.mp4";
            string filterFileName = $"{nameof(BlurredBackgroundTest)}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput().VSync(VSyncMethod.vfr);
            var images_inputmap = ffmpegArg.GetImagesInput();
            Config config = new Config();
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count - config.TransitionDuration;
            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenModes(ScreenMode.Blur, config);
            var overlaids = prepareInputs.Select(x => x.First()).Overlaids(config);
            var startEnd = prepareInputs.Select(x => x.Last()).ToList().StartEnd(config);
            var blendeds = startEnd.Blendeds(config, blend => blend
                .Shortest(true)
                .All_Expr(
                    $"A*(if( gte(T,{config.TransitionDuration.TotalSeconds.ToString(BaseOption.DefaultCultureInfo)}),{config.TransitionDuration.TotalSeconds.ToString(BaseOption.DefaultCultureInfo)},T/{config.TransitionDuration.TotalSeconds.ToString(BaseOption.DefaultCultureInfo)})) + " +
                    $"B*(1-(if(gte(T,{config.TransitionDuration.TotalSeconds.ToString(BaseOption.DefaultCultureInfo)}),{config.TransitionDuration.TotalSeconds.ToString(BaseOption.DefaultCultureInfo)},T/{config.TransitionDuration.TotalSeconds.ToString(BaseOption.DefaultCultureInfo)})))"));
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
