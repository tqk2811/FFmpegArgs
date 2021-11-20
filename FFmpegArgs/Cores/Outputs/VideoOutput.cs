using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Cores.Outputs
{
    public abstract class VideoOutput : BaseOutput, IImage, IAudio
    {
        public ImageMap ImageMap { get; protected set; }
        public AudioMap AudioMap { get; protected set; }
    }
}
