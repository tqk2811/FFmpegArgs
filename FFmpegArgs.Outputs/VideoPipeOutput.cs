namespace FFmpegArgs.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoPipeOutput : VideoOutput
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="streamOutput"></param>
        /// <param name="format"></param>
        /// <param name="imageMap"></param>
        /// <param name="audioMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public VideoPipeOutput(Stream streamOutput, MuxingFileFormat format, ImageMap imageMap, AudioMap audioMap)
            : base(new List<ImageMap>() { imageMap }, new List<AudioMap>() { audioMap })
        {
            PipeStream = streamOutput ?? throw new ArgumentNullException(nameof(streamOutput));
            if (!streamOutput.CanWrite) throw new InvalidOperationException("input stream.CanWrite is required");
            this.Format(format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="streamOutput"></param>
        /// <param name="format"></param>
        /// <param name="imageMaps"></param>
        /// <param name="audioMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public VideoPipeOutput(Stream streamOutput, MuxingFileFormat format, IEnumerable<ImageMap> imageMaps, IEnumerable<AudioMap> audioMaps)
            : base(imageMaps, audioMaps)
        {
            PipeStream = streamOutput ?? throw new ArgumentNullException(nameof(streamOutput));
            if (!streamOutput.CanWrite) throw new InvalidOperationException("input stream.CanWrite is required");
            this.Format(format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="streamOutput"></param>
        /// <param name="format"></param>
        /// <param name="imageMaps"></param>
        /// <param name="audioMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public VideoPipeOutput(Stream streamOutput, MuxingFileFormat format, ImageMap[] imageMaps, AudioMap[] audioMaps)
            : base(imageMaps, audioMaps)
        {
            PipeStream = streamOutput ?? throw new ArgumentNullException(nameof(streamOutput));
            if (!streamOutput.CanWrite) throw new InvalidOperationException("input stream.CanWrite is required");
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
                Inv($"pipe:{StdOut}")
            ];
            return args;
        }
    }
}
