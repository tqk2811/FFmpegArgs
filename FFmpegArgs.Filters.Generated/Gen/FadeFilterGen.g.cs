namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. fade              V-&gt;V       Fade in/out input video.
/// </summary>
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
///  set color (default &quot;black&quot;)
/// </summary>
public FadeFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Fade in/out input video.
/// </summary>
public static FadeFilterGen FadeFilterGen(this ImageMap input0) => new FadeFilterGen(input0);
}
/// <summary>
///  set the fade direction (from 0 to 1) (default in)
/// </summary>
public enum FadeFilterGenType
{
/// <summary>
/// in              0            ..FV....... fade-in
/// </summary>
[Name("in")] _in,
/// <summary>
/// out             1            ..FV....... fade-out
/// </summary>
[Name("out")] _out,
}

}
