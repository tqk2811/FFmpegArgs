

namespace FFmpegArgs.Test.FiltersTest
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
            ImageFilterGraphInput filterInput = new ImageFilterGraphInput();
            filterInput.FilterGraph
                .ColorFilter().Color(Color.Red).Size(videoSize).MapOut
                .FpsFilter().Fps(fps);
            var imageMaps = ffmpegArg.AddImagesInput(filterInput);
            string from = $"main_w";
            string to = $"-text_w";
            string range = $"(main_w+text_w)";//from - to
            string pixelPerFrame = $"({speed}/{fps})";//pixel/s / 1/s
            string durationFrame = $"({range}/{pixelPerFrame})";
            string time = $"mod(n,{durationFrame})";//from 0 to durationFrame, durationFrame + 1 -> durationFrame*2,......
            string x = $"{from}-{time}*{pixelPerFrame}";
            var output = imageMaps.First()
                .DrawTextFilter()
                    .Text("Bản dịch chính xác cho dòng thứ 2: Theo những gì tôi \"nghe ngóng\" được, có thể là Zhongli và Ganyu. Nhưng không có chứng cứ nên phần lớn là Xiao.")
                    .X(x)
                    .Y($"min(max({y},0),{videoSize.Height}-text_h)")
                    .FontFile("C:\\Windows\\Fonts\\arial.ttf")
                    .FontSize("36")
                    .MapOut
                    ;
            ImageFileOutput imageFileOutput = new ImageFileOutput("DrawTextTest.DrawText.mp4", output)
                .Duration(TimeSpan.FromSeconds(30)).AndSet(x => x.ImageOutputAVStreams.First().Fps(fps));
            ffmpegArg.AddOutput(imageFileOutput);
            ffmpegArg.TestRender("DrawText.fs", "DrawTextTest.DrawText.mp4");
        }
    }
}
