namespace FFmpegArgs.Outputs
{
    /// <summary>
    /// Image/Video non audio
    /// </summary>
    public class ImagePipeOutput : ImageOutput
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="streamOutput"></param>
        /// <param name="format"></param>
        /// <param name="imageMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public ImagePipeOutput(Stream streamOutput, MuxingFileFormat format, ImageMap imageMap) : base(imageMap)
        {
            PipeStream = streamOutput ?? throw new ArgumentNullException(nameof(streamOutput));
            if (!streamOutput.CanWrite) throw new InvalidOperationException("input stream.CanWrite is required");
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
                "-map",
                ImageMap.IsInput ? ImageMap.MapName : $"[{ImageMap.MapName}]",
                $"pipe:{StdOut}"
            };
            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
