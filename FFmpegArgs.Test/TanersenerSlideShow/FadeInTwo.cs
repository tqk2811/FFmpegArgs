﻿using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Executes;
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
            int WIDTH = 1366;
            int HEIGHT = 768;
            int TRANSITION_DURATION = 3;
            int IMAGE_DURATION = 2;
            int FPS = 24;
            double TRANSITION_FRAME_COUNT = TRANSITION_DURATION * FPS;
            double IMAGE_FRAME_COUNT = FPS * IMAGE_DURATION;
            Color backGroundColor = Color.FromArgb(0, 0, 0, 0);
            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\temp\ffmpeg_encode_test\ImgsTest");
            var files = directoryInfo.GetFiles("*.jpg");

            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();

            var inputs = files.Select(x => ffmpegArg.AddImageInput(new ImageFileInput(x.Name).SetOption("-loop", 1))).ToList();


            List<IEnumerable<ImageMap>> splitInputs = new List<IEnumerable<ImageMap>>();
            splitInputs.AddRange(inputs.Select(x => x
              .SetSarFilter("1/1").MapOut
              .ScaleFilter($"if(gte(iw/ih,{WIDTH}/{HEIGHT}),min(iw,{WIDTH}),-1)",
                            $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,min(ih,{HEIGHT}))").MapOut
              .PadFilter($"{WIDTH}", $"{HEIGHT}").Position($"({HEIGHT} - ow)/2", $"({HEIGHT} - oh)/2").Color(backGroundColor).MapOut
              .FpsFilter($"{FPS}").MapOut
              .SetPtsFilter("PTS-STARTPTS").MapOut
              .SplitFilter(2).MapsOut));

            List<ImageMap> startings = new List<ImageMap>();
            List<ImageMap> endings = new List<ImageMap>();
            for (int i = 0; i < splitInputs.Count; i++)
            {
                var res = splitInputs[i].Last()
                 .TrimFilter().Duration(TimeSpan.FromSeconds(TRANSITION_DURATION)).MapOut
                 .SelectFilter($"lte(n,{TRANSITION_FRAME_COUNT})").MapOut;

                if (i == 0)
                {
                    endings.Add(res);
                }
                else if (i == splitInputs.Count - 1)
                {
                    startings.Add(res);
                }
                else
                {
                    var splits = res.SplitFilter(2).MapsOut;
                    startings.Add(splits.First());
                    endings.Add(splits.Last());
                }
            }

            //CREATE TRANSITION FRAMES
            List<ImageMap> blendeds = new List<ImageMap>();
            for (int i = 0; i < startings.Count; i++)
            {
                blendeds.Add(startings[i]
                  .BlendFilterOn(endings[i]).All_Expr(
                    $"A*(if(gte(T,{TRANSITION_DURATION}),{TRANSITION_DURATION},T/{TRANSITION_DURATION})) + " +
                    $"B*(1-(if(gte(T,{TRANSITION_DURATION}),{TRANSITION_DURATION},T/{TRANSITION_DURATION})))").MapOut);
            }

            //concat
            List<ConcatGroup> concatGroups = new List<ConcatGroup>();
            for (int i = 0; i < splitInputs.Count; i++)
            {
                concatGroups.Add(new ConcatGroup(splitInputs[i].First()
                  .TrimFilter().Duration(TimeSpan.FromSeconds(IMAGE_DURATION)).MapOut
                  .SelectFilter($"lte(n,{IMAGE_FRAME_COUNT})").MapOut
                  .SetSarFilter("1/1").MapOut));

                if (i < splitInputs.Count - 1) concatGroups.Add(new ConcatGroup(blendeds[i].SetSarFilter("1/1").MapOut));
            }
            ConcatFilter concatFilter = new ConcatFilter(concatGroups);
            var mapout = concatFilter.ImageMapsOut.First()
              .FormatFilter(PixFmt.yuv420p).MapOut;

            var output = new ImageFileOutput($"{nameof(FadeInTwoTest)}.mp4", mapout);
            ffmpegArg.AddOutput(output);

            FFmpegRender fFmpegRender = ffmpegArg.Render(new FFmpegRenderConfig()
            {
                WorkingDirectory = directoryInfo.FullName
            });
            FFmpegRenderResult result = fFmpegRender.Execute();
            Assert.IsTrue(result.ExitCode == 0);
            Process.Start("ffplay", Path.Combine(directoryInfo.FullName, $"{nameof(FadeInTwoTest)}.mp4"));
        }
    }
}