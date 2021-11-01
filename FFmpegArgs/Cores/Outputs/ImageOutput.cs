using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Cores.Outputs
{
  public abstract class ImageOutput : BaseOutput
  {
    public ImageMap ImageMap { get; protected set; }
  }
}
