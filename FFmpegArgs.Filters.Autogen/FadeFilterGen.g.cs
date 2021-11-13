using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using FFmpegArgs;
using FFmpegArgs.Cores;
using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
namespace FFmpegArgs.Filters.Autogens
{
public class FadeFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal FadeFilterGen(ImageMap input) : base("fade",input) { AddMapOut(); }
/// <summary>
///  set the fade direction (from 0 to 1) (default in)
/// </summary>
public FadeFilterGen type(FadeFilterGenType type) => this.SetOption("type", type.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set the fade direction (from 0 to 1) (default in)
/// </summary>
public FadeFilterGen t(FadeFilterGenT t) => this.SetOption("t", t.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Number of the first frame to which to apply the effect. (from 0 to INT_MAX) (default 0)
/// </summary>
public FadeFilterGen start_frame(int start_frame) => this.SetOptionRange("start_frame", start_frame,0,INT_MAX);
/// <summary>
///  Number of the first frame to which to apply the effect. (from 0 to INT_MAX) (default 0)
/// </summary>
public FadeFilterGen s(int s) => this.SetOptionRange("s", s,0,INT_MAX);
/// <summary>
///  Number of frames to which the effect should be applied. (from 1 to INT_MAX) (default 25)
/// </summary>
public FadeFilterGen nb_frames(int nb_frames) => this.SetOptionRange("nb_frames", nb_frames,1,INT_MAX);
/// <summary>
///  Number of frames to which the effect should be applied. (from 1 to INT_MAX) (default 25)
/// </summary>
public FadeFilterGen n(int n) => this.SetOptionRange("n", n,1,INT_MAX);
/// <summary>
///  fade alpha if it is available on the input (default false)
/// </summary>
public FadeFilterGen alpha(bool flag) => this.SetOption("alpha",flag.ToFFmpegFlag());
/// <summary>
///  Number of seconds of the beginning of the effect. (default 0)
/// </summary>
public FadeFilterGen start_time(TimeSpan start_time) => this.SetOptionRange("start_time",start_time,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  Number of seconds of the beginning of the effect. (default 0)
/// </summary>
public FadeFilterGen st(TimeSpan st) => this.SetOptionRange("st",st,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  Duration of the effect in seconds. (default 0)
/// </summary>
public FadeFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  Duration of the effect in seconds. (default 0)
/// </summary>
public FadeFilterGen d(TimeSpan d) => this.SetOptionRange("d",d,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set color (default "black")
/// </summary>
public FadeFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
/// <summary>
///  set color (default "black")
/// </summary>
public FadeFilterGen c(Color c) => this.SetOption("c",c.ToHexStringRGBA());
}
public static class FadeFilterGenExtensions
{
/// <summary>
/// Fade in/out input video.
/// </summary>
public static FadeFilterGen FadeFilterGen(this ImageMap input) => new FadeFilterGen(input);
}
public enum FadeFilterGenType
{
[Name("in")] _in,
[Name("out")] _out,
}

public enum FadeFilterGenT
{
[Name("in")] _in,
[Name("out")] _out,
}

}
