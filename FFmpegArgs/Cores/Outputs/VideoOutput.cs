using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Cores.Outputs
{
    public abstract class VideoOutput : BaseOutput
    {
        public ImageMap ImageMap { get; protected set; }
        public AudioMap AudioMap { get; protected set; }
    }
}
