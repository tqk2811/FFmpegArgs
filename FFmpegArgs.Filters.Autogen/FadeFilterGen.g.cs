namespace FFmpegArgs.Filters.Autogens
{
public class FadeFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal FadeFilterGen(ImageMap input) : base("fade",input) { AddMapOut(); }
/// <summary>
///  set the fade direction (from 0 to 1) (default in)
/// </summary>
public FadeFilterGen type(FadeFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Number of the first frame to which to apply the effect. (from 0 to INT_MAX) (default 0)
/// </summary>
public FadeFilterGen start_frame(int start_frame) => this.SetOptionRange("start_frame", start_frame,0,INT_MAX);
/// <summary>
///  Number of frames to which the effect should be applied. (from 1 to INT_MAX) (default 25)
/// </summary>
public FadeFilterGen nb_frames(int nb_frames) => this.SetOptionRange("nb_frames", nb_frames,1,INT_MAX);
/// <summary>
///  fade alpha if it is available on the input (default false)
/// </summary>
public FadeFilterGen alpha(bool alpha) => this.SetOption("alpha",alpha.ToFFmpegFlag());
/// <summary>
///  Number of seconds of the beginning of the effect. (default 0)
/// </summary>
public FadeFilterGen start_time(TimeSpan start_time) => this.SetOptionRange("start_time",start_time,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  Duration of the effect in seconds. (default 0)
/// </summary>
public FadeFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set color (default "black")
/// </summary>
public FadeFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
}
public static class FadeFilterGenExtensions
{
/// <summary>
/// Fade in/out input video.
/// </summary>
public static FadeFilterGen FadeFilterGen(this ImageMap input0) => new FadeFilterGen(input0);
/// <summary>
/// Fade in/out input video.
/// </summary>
public static FadeFilterGen FadeFilterGen(this ImageMap input0,FadeFilterGenConfig config)
{
var result = new FadeFilterGen(input0);
if(config?.type != null) result.type(config.type.Value);
if(config?.start_frame != null) result.start_frame(config.start_frame.Value);
if(config?.nb_frames != null) result.nb_frames(config.nb_frames.Value);
if(config?.alpha != null) result.alpha(config.alpha.Value);
if(config?.start_time != null) result.start_time(config.start_time.Value);
if(config?.duration != null) result.duration(config.duration.Value);
if(config?.color != null) result.color(config.color.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class FadeFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set the fade direction (from 0 to 1) (default in)
/// </summary>
public FadeFilterGenType? type { get; set; }
/// <summary>
///  Number of the first frame to which to apply the effect. (from 0 to INT_MAX) (default 0)
/// </summary>
public int? start_frame { get; set; }
/// <summary>
///  Number of frames to which the effect should be applied. (from 1 to INT_MAX) (default 25)
/// </summary>
public int? nb_frames { get; set; }
/// <summary>
///  fade alpha if it is available on the input (default false)
/// </summary>
public bool? alpha { get; set; }
/// <summary>
///  Number of seconds of the beginning of the effect. (default 0)
/// </summary>
public TimeSpan? start_time { get; set; }
/// <summary>
///  Duration of the effect in seconds. (default 0)
/// </summary>
public TimeSpan? duration { get; set; }
/// <summary>
///  set color (default "black")
/// </summary>
public Color? color { get; set; }
public string TimelineSupport { get; set; }
}
public enum FadeFilterGenType
{
[Name("in")] _in,
[Name("out")] _out,
}

}
