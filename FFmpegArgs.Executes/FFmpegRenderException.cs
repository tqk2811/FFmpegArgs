namespace FFmpegArgs.Executes
{
    /// <summary>
    /// 
    /// </summary>
    public class FFmpegRenderException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public int ExitCode { get; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<string> OutputDatas { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ExitCode"></param>
        /// <param name="outputData"></param>
        public FFmpegRenderException(int ExitCode, IEnumerable<string> outputData) : base()
        {
            this.ExitCode = ExitCode;
            this.OutputDatas = outputData;
        }
    }
}
