namespace FFmpegArgs.Inputs
{
    public class AudioPipeInput : AudioInput
    {
        public AudioPipeInput(
            Stream stream,
            DemuxingFileFormat format,
            int audioStreamCount = 1
            )
            : base(audioStreamCount)
        {
            this.PipeStream = stream ?? throw new ArgumentNullException(nameof(stream));
            if (!stream.CanRead) throw new InvalidOperationException("input stream.CanRead is required");
            this.Format(format);
        }

        /// <summary>
        /// 
        /// </summary>
        public override Stream PipeStream { get; }

        public override string ToString()
        {
            List<string> args = new List<string>()
            {
                GetFlagArgs(),
                GetOptionArgs(),
                GetAVStreamArg(),
                Inv($"-i pipe:{StdIn}")
            };
            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
