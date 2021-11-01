using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Cores.Outputs
{
  public abstract class AudioOutput : BaseOutput
  {
    public AudioMap AudioMap { get; protected set; }
  }
}
