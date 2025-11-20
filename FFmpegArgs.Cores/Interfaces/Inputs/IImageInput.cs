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
        IEnumerable<ImageInputAVStream> ImageStreams { get; }

        /// <summary>
        /// 
        /// </summary>
        ImageInputAVStream ImageStream { get; }
    }
}
