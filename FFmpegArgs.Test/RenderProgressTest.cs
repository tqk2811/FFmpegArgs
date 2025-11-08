using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Test
{
    [TestClass]
    public class RenderProgressTest
    {
        [TestMethod]
        public void Test0()
        {
            RenderProgress renderProgress = RenderProgress
                .FromProgressString($"frame= 1500 fps=537 q=-1.0 Lsize=    3584kB time=00:00:59.97 bitrate= 489.5kbits/s speed=21.5x    ");
            Assert.IsNotNull(renderProgress);
        }
        [TestMethod]
        public void Test1()
        {
            RenderProgress renderProgress = RenderProgress
                .FromProgressString($"frame= 1500 fps=537 q=-1.0 Lsize=    3584KiB time=00:00:59.97 bitrate= 489.5kbits/s speed=21.5x    ");
            Assert.IsNotNull(renderProgress);
        }
    }
}
