namespace FFmpegArgs.Test
{
    [TestClass]
    public class FFmpegArgTest
    {
        [TestMethod]
        public void Test1()
        {
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var green_video = ffmpegArg.AddVideoInput(new VideoFileInput(@"chromakey.mp4")
                .SsPosition(TimeSpan.FromSeconds(0.5)));
            var background_video = ffmpegArg.AddVideoInput(new VideoFileInput(@"background.mp4")
                .SsPosition(TimeSpan.FromSeconds(1))
                .ToPosition(TimeSpan.FromSeconds(10)));
            var color_keys = green_video.ImageMaps.First()
                .ColorKeyFilter(Color.FromArgb(101, 220, 8)).Similarity(0.25f)//ColorKey
                    .Enable("between(t,0,10)").MapOut//ITimelineSupport
                .ScaleFilter().W("iw/3").H("ih/3").MapOut
                .SplitFilter(2).MapsOut;//Scale
            var overlay = color_keys.First()
                //overlay color_key on-center background_video
                .OverlayFilterOn(background_video.ImageMaps.First()).X("(W-w)/2").Y("(H-h)/2").MapOut;
            
            ffmpegArg.AddOutput(
                new VideoFileOutput($"{nameof(FFmpegArgTest)}-{nameof(Test1)}.mp4", overlay, background_video.AudioMaps.First())
                .AndSet(x => x.ImageStreams.First().R(24)));
            
            ffmpegArg.AddOutput(
                new VideoFileOutput($"{nameof(FFmpegArgTest)}-{nameof(Test1)}2.mp4", color_keys.Last(), background_video.AudioMaps.First())
                .AndSet(x => x.ImageStreams.First().Fps(30)));
            
            var command = ffmpegArg.GetFullCommandline();
        }
        [TestMethod]
        public void Test2()
        {
            //var files = Directory.GetFiles(@"D:\temp\ffmpeg_encode_test\ImgsTest\*.jpg");
            int out_w = 1366;
            int out_h = 768;
            //total time per image = 3 sec
            double imageDuration = 2;
            double animationDuration = 1;
            double rotateSpeed = 2;//2 * 2PI radian/sec
            FFmpegArg ffmpegArg = new FFmpegArg();
            ffmpegArg.OverWriteOutput();
            var background = ffmpegArg.FilterGraph.ColorFilter()
              .Color(Color.FromArgb(00, 100, 00))
              .Size(new Size(out_w, out_h));
            var images = ImageFilesConcatInput.FromFilesSearch(@"D:\temp\ffmpeg_encode_test\ImgsTest\img%d.jpg");
            images.SetOption("-r", 1 / (imageDuration + animationDuration));
            var images_map = ffmpegArg.AddImagesInput(images).First();
            var pad = images_map.PadFilter().W("ceil(iw/2)*2").H("ceil(ih/2)*2");//fix image size not % 2 = 0
            var format = pad.MapOut.FormatFilter(PixFmt.rgba);
            var scale = format.MapOut.ScaleFilter().W($"if(gte(iw/ih,{out_w}/{out_h}),min(iw,{out_w}),-1)").H($"if(gte(iw/ih,{out_w}/{out_h}),-1,min(ih,{out_h}))");
            //rotate {animationDuration} sec and stop rotate {imageDuration} sec
            string _whenRotate = $"between(t,n*({imageDuration} + {animationDuration}),n *({imageDuration} + {animationDuration})+{animationDuration})";
            string _rotate = $"2*PI*t*{rotateSpeed}";
            string _nonRotate = $"2*PI*{rotateSpeed}*(n+{animationDuration})";
            var rotate = scale.MapOut.RotateFilter().Angle($"if({_whenRotate},{_rotate},{_nonRotate})");
            string _whenMove = $"between(t,n*({imageDuration} + {animationDuration}),n *({imageDuration} + {animationDuration})+{animationDuration})";
            string _move = $"-main_w/2 + main_w * (t - n*({imageDuration} + {animationDuration}))/({imageDuration} + {animationDuration})";
            string _stopMove = $"main_w/2";
            var overlay = rotate.MapOut.OverlayFilterOn(background.MapOut).X($"if({_whenMove},{_move},{_stopMove})").Y($"main_h/2");
            overlay.EofAction(EofAction.EndAll);
            var videout = new ImageFileOutput($"{nameof(FFmpegArgTest)}-{nameof(Test2)}.mp4", overlay.MapOut);
            videout.ImageStreams.First().Fps(24);
            ffmpegArg.AddOutput(videout);
            var command = ffmpegArg.GetFullCommandline();
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestFilterInput()
        {
            string outputFileName = $"{nameof(TestFilterInput)}.mp4";
            string filterFileName = $"{nameof(TestFilterInput)}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            ImageFilterGraphInput filterInput = new ImageFilterGraphInput();
            filterInput.FilterGraph.ColorFilter().Color(Color.Red).Size(new Size(1280, 720)).MapOut
                .FpsFilter().Fps(25);
            filterInput.FilterGraph.ColorFilter().Color(Color.Green).Size(new Size(1280 / 2, 720 / 2)).MapOut
                .FpsFilter().Fps(25);
            var imageMaps = ffmpegArg.AddImagesInput(filterInput);
            var output = imageMaps.Last().OverlayFilterOn(imageMaps.First()).X("(W-w)/2").Y("(H-h)/2").MapOut;
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, output);
            ffmpegArg.AddOutput(imageFileOutput);
            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
        [TestMethod]
        public void TestStringEscape()
        {
            string outputFileName = $"{nameof(TestStringEscape)}.mp4";
            string filterFileName = $"{nameof(TestStringEscape)}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            ImageFilterGraphInput filterInput = new ImageFilterGraphInput();
            filterInput.FilterGraph.ColorFilter().Color(Color.Red).Size(new Size(1280, 720)).MapOut
                .FpsFilter().Fps(25);
            var image_maps = ffmpegArg.AddImagesInput(filterInput);
            var output = image_maps.First()
                .DrawTextFilter()
                    .Text("this is a 'string\\': m\\: \n\t\rabc,\" [or more], 的 日本国 日本;")
                    .X("100")
                    .Y("100")
                    .FontFile("C:\\Windows\\Fonts\\arial.ttf")
                    .FontSize("36")
                    .MapOut
                    ;
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, output)
                .Duration(TimeSpan.FromSeconds(3));
            ffmpegArg.AddOutput(imageFileOutput);
            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
    }
}
