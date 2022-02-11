namespace FFmpegArgs.Cores.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ImageOutput : BaseOutput, IImage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        protected ImageOutput(ImageMap imageMap) : base(imageMap)
        {
            this.ImageMap = imageMap;
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageMap ImageMap { get; }
    }
}
