using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Cores.Outputs
{
  public interface IMediaOutput
  {
    string OutPath { get; }
  }

  public interface IAudioOutput : IMediaOutput
  {
    AudioMap AudioMap { get; }
  }

  public interface IImageOutput : IMediaOutput
  {
    ImageMap ImageMap { get; }
  }

  public interface IVideoOutput : IImageOutput, IAudioOutput
  {

  }
}
