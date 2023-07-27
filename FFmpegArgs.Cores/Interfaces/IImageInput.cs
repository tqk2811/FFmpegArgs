namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IImageInput : IImage, IInput
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<ImageInputAVStream> ImageInputAVStreams { get; }

        /// <summary>
        /// 
        /// </summary>
        ImageInputAVStream ImageInputAVStream { get; }
    }
}
