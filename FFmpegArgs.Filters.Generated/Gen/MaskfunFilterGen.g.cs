namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC maskfun           V-&gt;V       Create Mask.
/// </summary>
public class MaskfunFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal MaskfunFilterGen(ImageMap input) : base("maskfun",input) { AddMapOut(); }
/// <summary>
///  set low threshold (from 0 to 65535) (default 10)
/// </summary>
public MaskfunFilterGen low(int low) => this.SetOptionRange("low", low,0,65535);
/// <summary>
///  set high threshold (from 0 to 65535) (default 10)
/// </summary>
public MaskfunFilterGen high(int high) => this.SetOptionRange("high", high,0,65535);
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public MaskfunFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set fill value (from 0 to 65535) (default 0)
/// </summary>
public MaskfunFilterGen fill(int fill) => this.SetOptionRange("fill", fill,0,65535);
/// <summary>
///  set sum value (from 0 to 65535) (default 10)
/// </summary>
public MaskfunFilterGen sum(int sum) => this.SetOptionRange("sum", sum,0,65535);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Create Mask.
/// </summary>
public static MaskfunFilterGen MaskfunFilterGen(this ImageMap input0) => new MaskfunFilterGen(input0);
}
}
