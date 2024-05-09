namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC readeia608        V->V       Read EIA-608 Closed Caption codes from input video and write them to frame metadata.
/// </summary>
public class Readeia608FilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal Readeia608FilterGen(ImageMap input) : base("readeia608",input) { AddMapOut(); }
/// <summary>
///  set from which line to scan for codes (from 0 to INT_MAX) (default 0)
/// </summary>
public Readeia608FilterGen scan_min(int scan_min) => this.SetOptionRange("scan_min", scan_min,0,INT_MAX);
/// <summary>
///  set to which line to scan for codes (from 0 to INT_MAX) (default 29)
/// </summary>
public Readeia608FilterGen scan_max(int scan_max) => this.SetOptionRange("scan_max", scan_max,0,INT_MAX);
/// <summary>
///  set ratio of width reserved for sync code detection (from 0.1 to 0.7) (default 0.27)
/// </summary>
public Readeia608FilterGen spw(float spw) => this.SetOptionRange("spw", spw,0.1,0.7);
/// <summary>
///  check and apply parity bit (default false)
/// </summary>
public Readeia608FilterGen chp(bool chp) => this.SetOption("chp",chp.ToFFmpegFlag());
/// <summary>
///  lowpass line prior to processing (default true)
/// </summary>
public Readeia608FilterGen lp(bool lp) => this.SetOption("lp",lp.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class Readeia608FilterGenExtensions
{
/// <summary>
/// Read EIA-608 Closed Caption codes from input video and write them to frame metadata.
/// </summary>
public static Readeia608FilterGen Readeia608FilterGen(this ImageMap input0) => new Readeia608FilterGen(input0);
}
}
