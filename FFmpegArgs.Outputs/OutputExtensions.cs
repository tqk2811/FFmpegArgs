using FFmpegArgs.Cores.Outputs;

namespace FFmpegArgs.Outputs
{
  public static class OutputExtensions
  {
    public static T VSync<T>(this T output, int vsync) where T : ImageOutput
      => output.SetOption("-vsync", vsync);

    public static T ASync<T>(this T output, int async) where T : AudioOutput
      => output.SetOption("-async", async);

    public static T FrameRate<T>(this T output, int r) where T : ImageOutput
     => output.SetOption("-r", r);
  }
}
