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
    [TestClass]
    public class Expand
    {
        [TestMethod]
        public void ExpandTest()
        {
            ScreenMode screenMode = ScreenMode.Blur;
            CollapseExpandMode collapseMode = CollapseExpandMode.Circular;
            string outputFileName = $"{nameof(ExpandTest)}-{screenMode}-{collapseMode}.mp4";
            string filterFileName = $"{nameof(ExpandTest)}-{screenMode}-{collapseMode}.txt";
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
                case CollapseExpandMode.Vertical:
                    expr = $"if(lte(Y,(H/2)-(H/2)*T/{TRANSITION_DURATION})+gte(Y,(H/2)+(H/2)*T/{TRANSITION_DURATION}),B,A)";
                    break;

                case CollapseExpandMode.Horizontal:
                    expr = $"if(lte(X,(W/2)-(W/2)*T/{TRANSITION_DURATION})+gte(X,(W/2)+(W/2)*T/{TRANSITION_DURATION}),B,A)";
                    break;

                case CollapseExpandMode.Circular:
                    StartEnd _startEnd = new StartEnd();

                    _startEnd.Startings = startEnd.Startings.Select(x => x
                       .GeqFilter()
                           .Lum("p(X,Y)")
                           .A($"if(lte(pow(sqrt(pow(T/{TRANSITION_DURATION}*W/2,2)+pow(T/{TRANSITION_DURATION}*H/2,2)),2),pow(X-(W/2),2)+pow(Y-(H/2),2)),0,255)").MapOut).ToList();
                    _startEnd.Endings = startEnd.Endings;

                    startEnd = _startEnd;
                    break;

                case CollapseExpandMode.Both:
                    expr = $"if((lte(X,(W/2)-(W/2)*T/{TRANSITION_DURATION})+lte(Y,(H/2)-(H/2)*T/{TRANSITION_DURATION}))+(gte(X,(W/2)+(W/2)*T/{TRANSITION_DURATION})+gte(Y,(H/2)+(H/2)*T/{TRANSITION_DURATION})),B,A)";
                    break;
            }

            ImageMap out_map = null;
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
