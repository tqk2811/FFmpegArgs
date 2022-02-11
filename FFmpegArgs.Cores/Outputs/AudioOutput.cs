namespace FFmpegArgs.Cores.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AudioOutput : BaseOutput, IAudio
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="audioMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        protected AudioOutput(AudioMap audioMap) : base(audioMap)
        {
            this.AudioMap = audioMap;
        }
        /// <summary>
        /// 
        /// </summary>
        public AudioMap AudioMap { get; }
    }
}
