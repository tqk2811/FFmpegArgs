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

        public override IEnumerable<string> GetAllArgs()
        {
            List<string> args =
            [
                .. GetFlagArgs(),
                .. GetOptionArgs(),
                .. GetAVStreamArgs(),
                "-i",
                $"pipe:{StdIn}"
            ];
            return args;
        }
    }
}
