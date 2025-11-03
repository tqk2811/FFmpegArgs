namespace FFmpegArgs.Test
{
    [TestClass]
    public class FFplayArgTest : BaseTest
    {
        [TestMethod]
        public void TestStringEscape()
        {
            string outputFileName = $"{nameof(TestStringEscape)}.mp4";
            string filterFileName = $"{nameof(TestStringEscape)}.txt";
            FFplayArg ffplayArg = new FFplayArg();
            ImageFilterGraphInput filterInput = new ImageFilterGraphInput();
            filterInput.FilterGraph.ColorFilter().Color(Color.Red).Size(new Size(1280, 720)).MapOut
                .FpsFilter().Fps(25);
            var output = ffplayArg.AddImagesInput(filterInput).First()
                .DrawTextFilter()
                    .Text("this is a 'string\\': m\\: \n\t\rabc,\" [or more], 的 日本国 日本;")
                    .X("100")
                    .Y("100")
                    .FontFile("C:\\Windows\\Fonts\\arial.ttf")
                    .FontSize("36")
                    .MapOut;
            //ffplayArg.TestRender(filterFileName, outputFileName);
        }
    }
}
