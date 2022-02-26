namespace FFmpegArgs.Executes
{
    /// <summary>
    /// 
    /// </summary>
    public class FFmpegRenderResult
    {
        /// <summary>
        /// 
        /// </summary>
        public string Arguments { get; internal set; }
        internal List<string> _ErrorDatas { get; } = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public int ExitCode { get; internal set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<string> ErrorDatas { get { return _ErrorDatas; } }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FFmpegRenderException"></exception>
        public FFmpegRenderResult EnsureSuccess()
        {
            if (ExitCode != 0) throw new FFmpegRenderException(ExitCode, ErrorDatas);
            return this;
        }
    }
}
