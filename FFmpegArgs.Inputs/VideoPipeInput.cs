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
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public VideoPipeInput(
            Stream stream,
            DemuxingFileFormat format,
            int imageStreamCount = 1,
            int audioStreamCount = 1) : base(imageStreamCount, audioStreamCount)
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
                GetFlagArgs(),
                GetOptionArgs(),
                GetAVStreamArg(),
                $"-i pipe:{StdIn}"
            };
            return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
        }
    }
}
