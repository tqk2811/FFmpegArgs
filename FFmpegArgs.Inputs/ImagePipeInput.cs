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
