using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.AudioSources
{
  /// <summary>
  /// ... anoisesrc         |->A       Generate a noise audio signal.<br>
  /// </br>https://ffmpeg.org/ffmpeg-filters.html#anoisesrc
  /// </summary>
  public class AnoisesrcFilter : SourceAudioFilter
  {
    internal AnoisesrcFilter(FilterGraph filterGraph) : base("anoisesrc", filterGraph)
    {
      AddMapOut();
    }

    /// <summary>
    /// Specify the sample rate. Default value is 48000 Hz.
    /// </summary>
    /// <param name="r"></param>
    /// <returns></returns>
    public AnoisesrcFilter SampleRate(int r)
      => this.SetOptionRange("r", r, 0, int.MaxValue);

    /// <summary>
    /// Specify the amplitude (0.0 - 1.0) of the generated audio stream. Default value is 1.0.
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    public AnoisesrcFilter Amplitude(float a)
      => this.SetOptionRange("a", a, 0.0f, 1.0f);

    /// <summary>
    /// Specify the duration of the generated audio stream. Not specifying this option results in noise with an infinite length.
    /// </summary>
    /// <param name="d"></param>
    /// <returns></returns>
    public AnoisesrcFilter Duration(TimeSpan d)
      => this.SetOptionRange("d", d, TimeSpan.Zero, TimeSpan.MaxValue);

    /// <summary>
    /// Specify the color of noise. Available noise colors are white, pink, brown, blue, violet and velvet. Default color is white.
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    public AnoisesrcFilter Color(AnoisesrcColor c)
      => this.SetOption("c", c.ToString());

    /// <summary>
    /// Specify a value used to seed the PRNG.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public AnoisesrcFilter Seed(int s)
      => this.SetOption("s", s);

    /// <summary>
    /// Set the number of samples per each output frame, default is 1024.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public AnoisesrcFilter NbSamples(int n)
      => this.SetOptionRange("n", n, 0, int.MaxValue);
  }

  public static class AnoisesrcFilterExtensions
  {
    /// <summary>
    /// Generate a noise audio signal.
    /// </summary>
    /// <param name="filterGraph"></param>
    /// <returns></returns>
    public static AnoisesrcFilter AnoisesrcFilter(this FilterGraph filterGraph)
      => new AnoisesrcFilter(filterGraph);
  }

  public enum AnoisesrcColor
  {
    white,
    pink,
    brown, 
    blue, 
    violet,
    velvet
  }
}
