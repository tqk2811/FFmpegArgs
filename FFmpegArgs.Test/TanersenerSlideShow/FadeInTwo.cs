using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Executes;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Filters.MultimediaFilters;
using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Inputs;
using FFmpegArgs.Outputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class FadeInTwo
    {
        [TestMethod]
        public void FadeInTwoTest()
        {
            ScreenMode screenMode = ScreenMode.Blur;
            string outputFileName = $"{nameof(FadeInTwoTest)}-{screenMode}.mp4";
            string filterFileName = $"{nameof(FadeInTwoTest)}-{screenMode}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var images_inputmap = ffmpegArg.GetImagesInput();

            Config config = new Config();
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count - config.TransitionDuration;

            var inputs = images_inputmap.InputScreenModes(screenMode, config);

            var overlaids = inputs.Select(x => x.First()).Overlaids(config);

            List<ImageMap> fadeIns = new List<ImageMap>();
            List<ImageMap> fadeOuts = new List<ImageMap>();
            var fades = inputs.Select(x => x.Last()).ToList();
            foreach (var input in fades)
            {
                var temp = input
                    .PadFilter()
                        .W($"{config.Size.Width}")
                        .H($"{config.Size.Height}")
                        .X($"({config.Size.Width}-iw)/2")
                        .Y($"({config.Size.Height}-ih)/2")
                        .Color(config.BackgroundColor).MapOut
                    .TrimFilter().Duration(config.TransitionDuration).MapOut
                    .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut;

                if (input.Equals(fades.First()))
                {
                    fadeOuts.Add(temp.FadeFilter(FadeType.Out).StartFrame(0).NbFrames(config.TransitionFrameCount).MapOut);
                } 
                else if (input.Equals(fades.Last()))
                {
                    fadeIns.Add(temp.FadeFilter(FadeType.In).StartFrame(0).NbFrames(config.TransitionFrameCount).MapOut);
                }
                else
                {
                    var split = temp.SplitFilter(2).MapsOut;
                    fadeOuts.Add(split.First().FadeFilter(FadeType.Out).StartFrame(0).NbFrames(config.TransitionFrameCount).MapOut);
                    fadeIns.Add(split.Last().FadeFilter(FadeType.In).StartFrame(0).NbFrames(config.TransitionFrameCount).MapOut);
                }
            }

            List<ImageMap> blendeds = new List<ImageMap>();
            for(int i = 0; i < fadeIns.Count; i++)
            {
                blendeds.Add(fadeOuts[i].OverlayFilterOn(fadeIns[i])
                        .X($"(main_w-overlay_w)/2")
                        .Y($"(main_h-overlay_h)/2").MapOut
                    .TrimFilter().Duration(config.TransitionDuration).MapOut
                    .SelectFilter($"lte(n,{config.TransitionFrameCount})").MapOut);
            }

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
