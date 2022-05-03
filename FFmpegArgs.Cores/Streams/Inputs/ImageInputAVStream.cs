namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageInputAVStream : InputAVStream, IImage
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageInputAVStream(BaseInput baseInput, int streamIndex) : base(baseInput, streamIndex)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override string ToString()
        {
            List<string> options = base._options.Select(x => $"{x.Key}:v:{StreamIndex} {x.Value}").ToList();
            options.AddRange(base._flags.Select(x => x));
            return string.Join(" ", options);
        }
    }
}
