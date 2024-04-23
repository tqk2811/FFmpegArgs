namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageInputAVStream : InputAVStream, IImage, IImageStream, IImageCodec
    {
        /// <summary>
        /// 
        /// </summary>
        internal ImageInputAVStream(BaseInput baseInput, int streamIndex) : base(baseInput, streamIndex)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            List<string> options = base.Options.Select(x => $"{x.Key}:v:{StreamIndex} {x.Value}").ToList();
            options.AddRange(base.Flags.Select(x => x));
            return string.Join(" ", options);
        }
    }
}
