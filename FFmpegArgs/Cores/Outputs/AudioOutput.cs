using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Cores.Outputs
{
    public abstract class AudioOutput : BaseOutput , IAudio
    {
        public AudioMap AudioMap { get; protected set; }
    }
}
