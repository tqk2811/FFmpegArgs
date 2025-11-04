namespace FFmpegArgs.Inputs
{
    public class ImagePipeInput : ImageInput
    {
        public ImagePipeInput(
            Stream stream,
            DemuxingFileFormat format,
            int imageStreamCount = 1
            )
            : base(imageStreamCount)
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
                Inv($"pipe:{StdIn}")
            ];
            return args;
        }
    }
}
