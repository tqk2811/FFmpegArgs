namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IImageOutput : IImage, IOutput
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<ImageOutputAVStream> ImageOutputAVStreams { get; }

        /// <summary>
        /// 
        /// </summary>
        ImageOutputAVStream ImageOutputAVStream { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<ImageMap> ImageMaps { get; }

        /// <summary>
        /// 
        /// </summary>
        ImageMap ImageMap { get; }
    }
}
