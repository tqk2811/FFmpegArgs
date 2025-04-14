namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAudioOutput : IAudio, IOutput
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<AudioOutputAVStream> AudioOutputAVStreams { get; }

        /// <summary>
        /// 
        /// </summary>
        AudioOutputAVStream AudioOutputAVStream { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<AudioMap> AudioMaps { get; }

        /// <summary>
        /// 
        /// </summary>
        AudioMap AudioMap { get; }
    }
}
