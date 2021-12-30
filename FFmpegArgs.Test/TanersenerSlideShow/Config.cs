using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    public class Config
    {
        public Size Size { get; set; } = new Size(1280, 720);
        public int Fps { get; set; } = 30;
        public TimeSpan ImageDuration { get; set; } = TimeSpan.FromSeconds(1.5);
        public TimeSpan TransitionDuration { get; set; } = TimeSpan.FromSeconds(2.5);
        public Color BackgroundColor { get; set; } = Color.FromArgb(0, 0, 0, 0);

        public int ImageFrameCount { get { return (int)(ImageDuration.TotalSeconds * Fps); } }
        public int TransitionFrameCount { get { return (int)(TransitionDuration.TotalSeconds * Fps); } }
    }
}
