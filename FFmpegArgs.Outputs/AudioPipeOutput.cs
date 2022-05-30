namespace FFmpegArgs.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioPipeOutput : AudioOutput
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="streamOutput"></param>
        /// <param name="format"></param>
        /// <param name="audioMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public AudioPipeOutput(Stream streamOutput, MuxingFileFormat format, AudioMap audioMap) : base(audioMap)
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
                GetAVStreamArg(),
                GetFlagArgs(),
                GetOptionArgs(),
                $"pipe:{StdOut}"
            };
            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
