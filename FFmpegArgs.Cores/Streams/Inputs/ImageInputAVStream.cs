namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageInputAVStream : InputAVStream,
        IImage, IImageStream, IImageCodec,
        ICodec, ICodecDecoder, IImageCodecDecoder,
        IStream, IInputStream, IImageInputStream
    {
        /// <summary>
        /// 
        /// </summary>
        internal ImageInputAVStream(BaseInput baseInput, int streamIndex) : base(baseInput, streamIndex)
        {
        }

        protected override string StreamSymbol => "v";
    }
}
