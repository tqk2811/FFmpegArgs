using FFmpegArgs.Executes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Test
{
    internal static class Render
    {
        internal static void TestRender(this FFmpegArg ffmpegArg,string filterFileName, string outputFileName)
        {
#if Render
            var render = ffmpegArg.Render(b => b.WithFilterScriptName(filterFileName));
            var render_result = render.Execute();
            Assert.IsTrue(render_result.ExitCode == 0);
#if Play
            Process.Start("ffplay", outputFileName);
#endif
#endif
        }

    }
}
