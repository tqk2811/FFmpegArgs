namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .S. transpose         V-&gt;V       Transpose input video.
/// </summary>
public class TransposeFilterGen : ImageToImageFilter,ISliceThreading
{
internal TransposeFilterGen(ImageMap input) : base("transpose",input) { AddMapOut(); }
/// <summary>
///  set transpose direction (from 0 to 7) (default cclock_flip)
/// </summary>
public TransposeFilterGen dir(TransposeFilterGenDir dir) => this.SetOption("dir", dir.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  do not apply transposition if the input matches the specified geometry (from 0 to INT_MAX) (default none)
/// </summary>
public TransposeFilterGen passthrough(TransposeFilterGenPassthrough passthrough) => this.SetOption("passthrough", passthrough.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Transpose input video.
/// </summary>
public static TransposeFilterGen TransposeFilterGen(this ImageMap input0) => new TransposeFilterGen(input0);
}
/// <summary>
///  set transpose direction (from 0 to 7) (default cclock_flip)
/// </summary>
public enum TransposeFilterGenDir
{
/// <summary>
/// cclock_flip     0            ..FV....... rotate counter-clockwise with vertical flip
/// </summary>
[Name("cclock_flip")] cclock_flip,
/// <summary>
/// clock           1            ..FV....... rotate clockwise
/// </summary>
[Name("clock")] clock,
/// <summary>
/// cclock          2            ..FV....... rotate counter-clockwise
/// </summary>
[Name("cclock")] cclock,
/// <summary>
/// clock_flip      3            ..FV....... rotate clockwise with vertical flip
/// </summary>
[Name("clock_flip")] clock_flip,
}

/// <summary>
///  do not apply transposition if the input matches the specified geometry (from 0 to INT_MAX) (default none)
/// </summary>
public enum TransposeFilterGenPassthrough
{
/// <summary>
/// none            0            ..FV....... always apply transposition
/// </summary>
[Name("none")] none,
/// <summary>
/// portrait        2            ..FV....... preserve portrait geometry
/// </summary>
[Name("portrait")] portrait,
/// <summary>
/// landscape       1            ..FV....... preserve landscape geometry
/// </summary>
[Name("landscape")] landscape,
}

}
