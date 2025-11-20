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
        IEnumerable<ImageOutputAVStream> ImageStreams { get; }

        /// <summary>
        /// 
        /// </summary>
        ImageOutputAVStream ImageStream { get; }

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
