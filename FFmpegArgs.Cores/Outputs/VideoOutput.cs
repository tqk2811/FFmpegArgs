namespace FFmpegArgs.Cores.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class VideoOutput : BaseOutput, IImage, IAudio
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="audioMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        protected VideoOutput(ImageMap imageMap, AudioMap audioMap) : base(imageMap, audioMap)
        {
            this.ImageMap = imageMap;
            this.AudioMap = audioMap;
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageMap ImageMap { get; }
        /// <summary>
        /// 
        /// </summary>
        public AudioMap AudioMap { get; }
    }
}
