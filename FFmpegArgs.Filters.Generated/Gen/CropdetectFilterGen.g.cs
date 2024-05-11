namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C cropdetect        V-&gt;V       Auto-detect crop size.
/// </summary>
public class CropdetectFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal CropdetectFilterGen(ImageMap input) : base("cropdetect",input) { AddMapOut(); }
/// <summary>
///  Threshold below which the pixel is considered black (from 0 to 65535) (default 0.0941176)
/// </summary>
public CropdetectFilterGen limit(float limit) => this.SetOptionRange("limit", limit,0,65535);
/// <summary>
///  Value by which the width/height should be divisible (from 0 to INT_MAX) (default 16)
/// </summary>
public CropdetectFilterGen round(int round) => this.SetOptionRange("round", round,0,INT_MAX);
/// <summary>
///  Number of initial frames to skip (from 0 to INT_MAX) (default 2)
/// </summary>
public CropdetectFilterGen skip(int skip) => this.SetOptionRange("skip", skip,0,INT_MAX);
/// <summary>
///  Recalculate the crop area after this many frames (from 0 to INT_MAX) (default 0)
/// </summary>
public CropdetectFilterGen reset_count(int reset_count) => this.SetOptionRange("reset_count", reset_count,0,INT_MAX);
/// <summary>
///  Threshold count of outliers (from 0 to INT_MAX) (default 0)
/// </summary>
public CropdetectFilterGen max_outliers(int max_outliers) => this.SetOptionRange("max_outliers", max_outliers,0,INT_MAX);
/// <summary>
///  set mode (from 0 to 1) (default black)
/// </summary>
public CropdetectFilterGen mode(CropdetectFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Set high threshold for edge detection (from 0 to 1) (default 0.0980392)
/// </summary>
public CropdetectFilterGen high(float high) => this.SetOptionRange("high", high,0,1);
/// <summary>
///  Set low threshold for edge detection (from 0 to 1) (default 0.0588235)
/// </summary>
public CropdetectFilterGen low(float low) => this.SetOptionRange("low", low,0,1);
/// <summary>
///  motion vector threshold when estimating video window size (from 0 to 100) (default 8)
/// </summary>
public CropdetectFilterGen mv_threshold(int mv_threshold) => this.SetOptionRange("mv_threshold", mv_threshold,0,100);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Auto-detect crop size.
/// </summary>
public static CropdetectFilterGen CropdetectFilterGen(this ImageMap input0) => new CropdetectFilterGen(input0);
}
/// <summary>
///  set mode (from 0 to 1) (default black)
/// </summary>
public enum CropdetectFilterGenMode
{
/// <summary>
/// black           0            ..FV....... detect black pixels surrounding the video
/// </summary>
[Name("black")] black,
/// <summary>
/// mvedges         1            ..FV....... detect motion and edged surrounding the video
/// </summary>
[Name("mvedges")] mvedges,
}

}
