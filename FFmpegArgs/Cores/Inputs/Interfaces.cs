namespace FFmpegArgs.Cores.Inputs
{
  public interface IMediaInput
  {
  }
  public interface IImageInput : IMediaInput
  {
  }
  public interface IAudioInput : IMediaInput
  {
  }
  public interface IVideoInput : IImageInput, IAudioInput
  {
  }
}
