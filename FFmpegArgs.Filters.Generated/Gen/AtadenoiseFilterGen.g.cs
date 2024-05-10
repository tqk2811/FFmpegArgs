namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC atadenoise        V->V       Apply an Adaptive Temporal Averaging Denoiser.
/// </summary>
public class AtadenoiseFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AtadenoiseFilterGen(ImageMap input) : base("atadenoise",input) { AddMapOut(); }
/// <summary>
///  set threshold A for 1st plane (from 0 to 0.3) (default 0.02)
/// </summary>
public AtadenoiseFilterGen _0a(float _0a) => this.SetOptionRange("0a", _0a,0,0.3);
/// <summary>
///  set threshold B for 1st plane (from 0 to 5) (default 0.04)
/// </summary>
public AtadenoiseFilterGen _0b(float _0b) => this.SetOptionRange("0b", _0b,0,5);
/// <summary>
///  set threshold A for 2nd plane (from 0 to 0.3) (default 0.02)
/// </summary>
public AtadenoiseFilterGen _1a(float _1a) => this.SetOptionRange("1a", _1a,0,0.3);
/// <summary>
///  set threshold B for 2nd plane (from 0 to 5) (default 0.04)
/// </summary>
public AtadenoiseFilterGen _1b(float _1b) => this.SetOptionRange("1b", _1b,0,5);
/// <summary>
///  set threshold A for 3rd plane (from 0 to 0.3) (default 0.02)
/// </summary>
public AtadenoiseFilterGen _2a(float _2a) => this.SetOptionRange("2a", _2a,0,0.3);
/// <summary>
///  set threshold B for 3rd plane (from 0 to 5) (default 0.04)
/// </summary>
public AtadenoiseFilterGen _2b(float _2b) => this.SetOptionRange("2b", _2b,0,5);
/// <summary>
///  set how many frames to use (from 5 to 129) (default 9)
/// </summary>
public AtadenoiseFilterGen s(int s) => this.SetOptionRange("s", s,5,129);
/// <summary>
///  set what planes to filter (default 7)
/// </summary>
public AtadenoiseFilterGen p(AtadenoiseFilterGenP p) => this.SetOption("p", p.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set variant of algorithm (from 0 to 1) (default p)
/// </summary>
public AtadenoiseFilterGen a(AtadenoiseFilterGenA a) => this.SetOption("a", a.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set sigma for 1st plane (from 0 to 32767) (default 32767)
/// </summary>
public AtadenoiseFilterGen _0s(float _0s) => this.SetOptionRange("0s", _0s,0,32767);
/// <summary>
///  set sigma for 2nd plane (from 0 to 32767) (default 32767)
/// </summary>
public AtadenoiseFilterGen _1s(float _1s) => this.SetOptionRange("1s", _1s,0,32767);
/// <summary>
///  set sigma for 3rd plane (from 0 to 32767) (default 32767)
/// </summary>
public AtadenoiseFilterGen _2s(float _2s) => this.SetOptionRange("2s", _2s,0,32767);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply an Adaptive Temporal Averaging Denoiser.
/// </summary>
public static AtadenoiseFilterGen AtadenoiseFilterGen(this ImageMap input0) => new AtadenoiseFilterGen(input0);
}
/// <summary>
///  set what planes to filter (default 7)
/// </summary>
public enum AtadenoiseFilterGenP
{
}

/// <summary>
///  set variant of algorithm (from 0 to 1) (default p)
/// </summary>
public enum AtadenoiseFilterGenA
{
/// <summary>
/// p               0            ..FV.....T. parallel
/// </summary>
[Name("p")] p,
/// <summary>
/// s               1            ..FV.....T. serial
/// </summary>
[Name("s")] s,
}

}
