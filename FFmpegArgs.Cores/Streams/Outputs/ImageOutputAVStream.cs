namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageOutputAVStream : OutputAVStream,
        IImage, IImageCodec, IImageStream,
        ICodec, ICodecEncoder, IImageCodecEncoder,
        IStream, IOutputStream, IImageOutputStream
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageMap ImageMap { get; }

        /// <summary>
        /// 
        /// </summary>
        internal ImageOutputAVStream(ImageMap imageMap, int streamIndex) : base(imageMap, streamIndex)
        {
            this.ImageMap = imageMap;
        }

        protected override string StreamSymbol => "v";
    }
}
