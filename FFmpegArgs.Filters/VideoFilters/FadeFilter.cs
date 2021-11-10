using FFmpegArgs.Cores.Maps;
using System;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// TS. fade              V->V       Fade in/out input video.<br>
  /// </br>https://ffmpeg.org/ffmpeg-filters.html#fade
  /// </summary>
  public class FadeFilter : ImageToImageFilter
  {
    internal FadeFilter(ImageMap imageMap, FadeType type) : base("fade", imageMap)
    {
      this.SetOption("type", type.ToString().ToLower());
      AddMapOut();
    }

    /// <summary>
    /// Specify the number of the frame to start applying the fade effect at. Default is 0.
    /// </summary>
    /// <param name="frame"></param>
    /// <returns></returns>
    public FadeFilter StartFrame(long frame)
      => this.SetOptionRange("s", frame, 0, long.MaxValue);

    /// <summary>
    /// The number of frames that the fade effect lasts. At the end of the fade-in effect, the output video will have the same intensity as the input video.<br>
    /// </br> At the end of the fade-out transition, the output video will be filled with the selected color.<br>
    /// </br> Default is 25.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public FadeFilter NbFrames(int n)
      => this.SetOptionRange("n", n, 0, int.MaxValue);

    /// <summary>
    /// If set to 1, fade only alpha channel, if one exists on the input. Default value is 0.
    /// </summary>
    /// <param name="alpha"></param>
    /// <returns></returns>
    public FadeFilter Alpha(float alpha)
      => this.SetOptionRange("alpha", alpha, 0, 1);

    /// <summary>
    /// Specify the timestamp (in seconds) of the frame to start to apply the fade effect.<br>
    /// </br> If both start_frame and start_time are specified, the fade will start at whichever comes last. Default is 0.
    /// </summary>
    /// <param name="st"></param>
    /// <returns></returns>
    public FadeFilter StartTime(double st)
      => this.SetOptionRange("st", st, 0, double.MaxValue);

    /// <summary>
    /// The number of seconds for which the fade effect has to last.<br>
    /// </br> At the end of the fade-in effect the output video will have the same intensity as the input video, at the end of the fade-out transition the output video will be filled with the selected color.<br>
    /// </br> If both duration and nb_frames are specified, duration is used.<br>
    /// </br> Default is 0 (nb_frames is used by default).
    /// </summary>
    /// <returns></returns>
    public FadeFilter Duration(TimeSpan duration)
      => this.SetOptionRange("d", duration, TimeSpan.Zero, TimeSpan.MaxValue);

    /// <summary>
    /// Specify the color of the fade. Default is "black".
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    public FadeFilter Color(Color c)
      => this.SetOption("c", c.ToHexStringRGBA());
  }

  public static class FadeFilterExtensions
  {
    /// <summary>
    /// Apply a fade-in/out effect to the input video.
    /// </summary>
    /// <param name="imageMap"></param>
    /// <param name="type">The effect type can be either "in" for a fade-in, or "out" for a fade-out effect. Default is in.</param>
    /// <returns></returns>
    public static FadeFilter FadeFilter(this ImageMap imageMap, FadeType type = FadeType.In)
      => new FadeFilter(imageMap, type);
  }


  public enum FadeType
  {
    In,
    Out
  }
}
