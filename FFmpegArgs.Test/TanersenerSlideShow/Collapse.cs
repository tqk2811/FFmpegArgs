using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Filters.MultimediaFilters;
using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Filters.VideoSources;
using FFmpegArgs.Inputs;
using FFmpegArgs.Outputs;
using FFmpegArgs.Filters;
using FFmpegArgs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using FFmpegArgs.Executes;
using FFmpegArgs.Cores.Maps;
using System.Diagnostics;

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    public enum CollapseMode
    {
        Both,
        Circular,
        Horizontal,
        Vertical,

    }
    [TestClass]
    public class Collapse
    {
        [TestMethod]
        public void CollapseTest()
        {
            ScreenMode screenMode = ScreenMode.Blur;
            CollapseMode collapseMode = CollapseMode.Circular;
            string outputFileName = $"{nameof(CollapseTest)}-{screenMode}-{collapseMode}.mp4";
            string filterFileName = $"{nameof(CollapseTest)}-{screenMode}-{collapseMode}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
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
                case CollapseMode.Vertical:
                    expr = $"if(gte(Y,(H/2)*T/{TRANSITION_DURATION})*lte(Y,H-(H/2)*T/{TRANSITION_DURATION}),B,A)";
                    break;

                case CollapseMode.Horizontal:
                    expr = $"if(gte(X,(W/2)*T/{TRANSITION_DURATION})*lte(X,W-(W/2)*T/{TRANSITION_DURATION}),B,A)";
                    break;

                case CollapseMode.Circular:
                    StartEnd _startEnd = new StartEnd();

                    _startEnd.Startings  = startEnd.Startings.Select(x => x
                        .GeqFilter()
                            .Lum("p(X,Y)")
                            .A($"if(lte(pow(sqrt(pow(W/2,2)+pow(H/2,2))-sqrt(pow(T/{TRANSITION_DURATION}*W/2,2)+pow(T/{TRANSITION_DURATION}*H/2,2)),2),pow(X-(W/2),2)+pow(Y-(H/2),2)),255,0)").MapOut).ToList();
                    _startEnd.Endings = startEnd.Endings;

                    startEnd = _startEnd;
                    break;

                case CollapseMode.Both:
                    expr = $"if((gte(X,(W/2)*T/{TRANSITION_DURATION})*gte(Y,(H/2)*T/{TRANSITION_DURATION}))*(lte(X,W-(W/2)*T/{TRANSITION_DURATION})*lte(Y,H-(H/2)*T/{TRANSITION_DURATION})),B,A)";
                    break;
            }

            ImageMap out_map = null;
            switch (collapseMode)
            {
                case CollapseMode.Circular:
                    {
                        var blendeds = new List<ImageMap>();
                        for(int i = 0; i < startEnd.Startings.Count; i++)
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
