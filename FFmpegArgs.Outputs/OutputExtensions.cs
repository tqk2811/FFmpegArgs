using FFmpegArgs.Cores.Outputs;

namespace FFmpegArgs.Outputs
{
  public static class OutputExtensions
  {
    public static T VSync<T>(this T output, int vsync) where T : BaseOutput, IImageOutput
      => output.SetOption("-vsync", vsync);

    public static T ASync<T>(this T output, int async) where T : BaseOutput, IAudioOutput
      => output.SetOption("-async", async);

    public static T FrameRate<T>(this T output, int r) where T : BaseOutput, IImageOutput
     => output.SetOption("-r", r);
  }
}
