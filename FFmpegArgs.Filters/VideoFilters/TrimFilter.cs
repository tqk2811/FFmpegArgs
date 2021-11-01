using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// ... trim              V->V       Pick one continuous section from the input, drop the rest.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#trim
  /// </summary>
  public class TrimFilter : ImageToImageFilter
  {
    internal TrimFilter(ImageMap imageMap) : base("trim", imageMap)
    {
      _mapsOut.Add(new ImageMap(FilterGraph, $"f_{FilterIndex}"));
    }

    public TrimFilter Start(double val)
      => this.SetOption("start", val);

    public TrimFilter End(double val)
     => this.SetOption("end", val);

    public TrimFilter StartPts(double val)
     => this.SetOption("start_pts", val);

    public TrimFilter EndPts(double val)
     => this.SetOption("end_pts", val);

    public TrimFilter Duration(double val)
     => this.SetOption("duration", val);

    public TrimFilter StartFrame(double val)
     => this.SetOption("start_frame", val);

    public TrimFilter EndFrame(double val)
    => this.SetOption("end_frame", val);
  }

  public static class TrimFilterExtension
  {
    public static TrimFilter TrimFilter(this ImageMap imageMap)
    {
      return new TrimFilter(imageMap);
    }
  }
}
