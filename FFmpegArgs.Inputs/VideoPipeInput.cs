namespace FFmpegArgs.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoPipeInput : VideoInput
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="format"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public VideoPipeInput(Stream stream,DemuxingFileFormat format)
        {
            this.PipeStream = stream ?? throw new ArgumentNullException(nameof(stream));
            if (!stream.CanRead) throw new InvalidOperationException("input stream.CanRead is required");
            this.Format(format);
        }

        /// <summary>
        /// 
        /// </summary>
        public override Stream PipeStream { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            List<string> args = new List<string>()
            {
                GetArgs(),
                $"-i pipe:{StdIn}"
            };
            return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
        }
    }
}
