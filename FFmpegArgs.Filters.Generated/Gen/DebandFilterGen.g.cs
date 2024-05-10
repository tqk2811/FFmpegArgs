namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC deband            V->V       Debands video.
/// </summary>
public class DebandFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal DebandFilterGen(ImageMap input) : base("deband",input) { AddMapOut(); }
/// <summary>
///  set 1st plane threshold (from 3e-05 to 0.5) (default 0.02)
/// </summary>
public DebandFilterGen _1thr(float _1thr) => this.SetOptionRange("1thr", _1thr,3e-05,0.5);
/// <summary>
///  set 2nd plane threshold (from 3e-05 to 0.5) (default 0.02)
/// </summary>
public DebandFilterGen _2thr(float _2thr) => this.SetOptionRange("2thr", _2thr,3e-05,0.5);
/// <summary>
///  set 3rd plane threshold (from 3e-05 to 0.5) (default 0.02)
/// </summary>
public DebandFilterGen _3thr(float _3thr) => this.SetOptionRange("3thr", _3thr,3e-05,0.5);
/// <summary>
///  set 4th plane threshold (from 3e-05 to 0.5) (default 0.02)
/// </summary>
public DebandFilterGen _4thr(float _4thr) => this.SetOptionRange("4thr", _4thr,3e-05,0.5);
/// <summary>
///  set range (from INT_MIN to INT_MAX) (default 16)
/// </summary>
public DebandFilterGen range(int range) => this.SetOptionRange("range", range,INT_MIN,INT_MAX);
/// <summary>
///  set direction (from -6.28319 to 6.28319) (default 6.28319)
/// </summary>
public DebandFilterGen direction(float direction) => this.SetOptionRange("direction", direction,-6.28319,6.28319);
/// <summary>
///  set blur (default true)
/// </summary>
public DebandFilterGen blur(bool blur) => this.SetOption("blur",blur.ToFFmpegFlag());
/// <summary>
///  set plane coupling (default false)
/// </summary>
public DebandFilterGen coupling(bool coupling) => this.SetOption("coupling",coupling.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Debands video.
/// </summary>
public static DebandFilterGen DebandFilterGen(this ImageMap input0) => new DebandFilterGen(input0);
}
}
