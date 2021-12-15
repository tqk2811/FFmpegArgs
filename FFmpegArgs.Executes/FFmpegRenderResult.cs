using System.Collections.Generic;

namespace FFmpegArgs.Executes
{
    public class FFmpegRenderResult
    {
        public string Arguments { get; internal set; }
        internal List<string> _OutputDatas { get; } = new List<string>();
        internal List<string> _ErrorDatas { get; } = new List<string>();
        public int ExitCode { get; internal set; } = 0;
        public IEnumerable<string> OutputDatas { get { return _OutputDatas; } }
        public IEnumerable<string> ErrorDatas { get { return _ErrorDatas; } }
        public FFmpegRenderResult EnsureSuccess()
        {
            if (ExitCode != 0) throw new FFmpegRenderException(ExitCode, OutputDatas);
            return this;
        }
    }
}
