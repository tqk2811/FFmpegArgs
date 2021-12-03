using System;
using System.Collections.Generic;

namespace FFmpegArgs.Executes
{
    public class FFmpegRenderException: Exception
    {
        public int ExitCode { get; }
        public IEnumerable<string> OutputDatas { get; }
        public FFmpegRenderException(int ExitCode, IEnumerable<string> outputData) : base()
        {
            this.ExitCode = ExitCode;
            this.OutputDatas = outputData;
        }
    }
}
