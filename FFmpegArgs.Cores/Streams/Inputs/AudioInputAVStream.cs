namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioInputAVStream : InputAVStream,
        IAudio, IAudioStream, IAudioCodec,
        ICodec, ICodecDecoder, IAudioCodecDecoder,
        IStream, IAudioInputStream
    {
        /// <summary>
        /// 
        /// </summary>
        internal AudioInputAVStream(BaseInput baseInput, int streamIndex) : base(baseInput, streamIndex)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            List<string> options = base.Options.Select(x => $"{x.Key}:a:{StreamIndex} {x.Value}").ToList();
            options.AddRange(base.Flags.Select(x => x));
            return string.Join(" ", options);
        }
    }
}
