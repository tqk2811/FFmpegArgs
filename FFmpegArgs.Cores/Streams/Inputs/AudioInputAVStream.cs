namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioInputAVStream : InputAVStream,
        IAudio, IAudioStream, IAudioCodec,
        ICodec, ICodecDecoder, IAudioCodecDecoder,
        IStream, IInputStream, IAudioInputStream
    {
        /// <summary>
        /// 
        /// </summary>
        internal AudioInputAVStream(BaseInput baseInput, int streamIndex) : base(baseInput, streamIndex)
        {
        }

        protected override string StreamSymbol => "a";
    }
}
