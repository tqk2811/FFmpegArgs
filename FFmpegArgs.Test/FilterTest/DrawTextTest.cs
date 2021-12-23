using FFmpegArgs.Executes;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Filters.VideoSources;
using FFmpegArgs.Inputs;
using FFmpegArgs.Outputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;

namespace FFmpegArgs.Test.FilterTest
{
    [TestClass]
    public class DrawTextTest
    {

        [TestMethod]
        public void DrawText()
        {
            Size videoSize = new Size(1280, 720);
            int speed = 300;//50pixel/s
            int fps = 24;//t = 1/24
            int y = 500;
            FFmpegArg ffmpegArg = new FFmpegArg();
            ffmpegArg.OverWriteOutput();

            FilterInput filterInput = new FilterInput();
            filterInput.FilterGraph.ColorFilter().Color(Color.Red).Size(videoSize).MapOut
                .FpsFilter(fps);
            var videos = ffmpegArg.AddVideoInput(filterInput, 1, 0);

            string from = $"main_w";
            string to = $"-text_w";
            string range = $"(main_w+text_w)";//from - to
            string pixelPerFrame = $"({speed}/{fps})";//pixel/s / 1/s
            string durationFrame = $"({range}/{pixelPerFrame})";
            string time = $"mod(n,{durationFrame})";//from 0 to durationFrame, durationFrame + 1 -> durationFrame*2,......
            string x = $"{from}-{time}*{pixelPerFrame}";

            var output = videos.ImageMaps.First()
                .DrawTextFilter()
                    .Text("Bản dịch chính xác cho dòng thứ 2: Theo những gì tôi \"nghe ngóng\" được, có thể là Zhongli và Ganyu. Nhưng không có chứng cứ nên phần lớn là Xiao.")
                    .X(x)
                    .Y($"min(max({y},0),{videoSize.Height}-text_h)")
                    .FontFile("C:\\Windows\\Fonts\\arial.ttf")
                    .FontSize("36")
                    .MapOut
                    ;

            ImageFileOutput imageFileOutput = new ImageFileOutput("DrawTextTest.DrawText.mp4", output)
                .Duration(TimeSpan.FromSeconds(30)).Fps(fps);
            ffmpegArg.AddOutput(imageFileOutput);

            FFmpegRender fFmpegRender = ffmpegArg.Render(new FFmpegRenderConfig()
            {
                WorkingDirectory = Directory.GetCurrentDirectory(),
                //IsForceUseScript = true,
            });
            FFmpegRenderResult renderResult = fFmpegRender.Execute();
            Assert.IsTrue(renderResult.ExitCode == 0);
            Process.Start("ffplay", "DrawTextTest.DrawText.mp4");
        }



    }
}
