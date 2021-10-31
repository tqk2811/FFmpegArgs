using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Cores.Outputs
{
  public interface IMediaOutput
  {
    string OutPath { get; }
  }

  public interface IAudioOutput : IMediaOutput
  {
    IAudioMap AudioMap { get; }
  }

  public interface IImageOutput : IMediaOutput
  {
    IImageMap ImageMap { get; }
  }

  public interface IVideoOutput : IImageOutput, IAudioOutput
  {

  }
}
