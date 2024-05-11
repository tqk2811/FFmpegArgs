namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... mptestsrc         |->V       Generate various test pattern.
/// </summary>
public class MptestsrcFilterGen : SourceToImageFilter
{
internal MptestsrcFilterGen(IImageFilterGraph input) : base("mptestsrc",input) { AddMapOut(); }
/// <summary>
///  set video rate (default "25")
/// </summary>
public MptestsrcFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public MptestsrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set test to perform (from 0 to INT_MAX) (default all)
/// </summary>
public MptestsrcFilterGen test(MptestsrcFilterGenTest test) => this.SetOption("test", test.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Set the maximum number of frames generated for each test (from 1 to I64_MAX) (default 30)
/// </summary>
public MptestsrcFilterGen max_frames(long max_frames) => this.SetOptionRange("max_frames", max_frames,1,I64_MAX);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Generate various test pattern.
/// </summary>
public static MptestsrcFilterGen MptestsrcFilterGen(this IImageFilterGraph input0) => new MptestsrcFilterGen(input0);
}
/// <summary>
///  set test to perform (from 0 to INT_MAX) (default all)
/// </summary>
public enum MptestsrcFilterGenTest
{
/// <summary>
/// dc_luma         0            ..FV.......
/// </summary>
[Name("dc_luma")] dc_luma,
/// <summary>
/// dc_chroma       1            ..FV.......
/// </summary>
[Name("dc_chroma")] dc_chroma,
/// <summary>
/// freq_luma       2            ..FV.......
/// </summary>
[Name("freq_luma")] freq_luma,
/// <summary>
/// freq_chroma     3            ..FV.......
/// </summary>
[Name("freq_chroma")] freq_chroma,
/// <summary>
/// amp_luma        4            ..FV.......
/// </summary>
[Name("amp_luma")] amp_luma,
/// <summary>
/// amp_chroma      5            ..FV.......
/// </summary>
[Name("amp_chroma")] amp_chroma,
/// <summary>
/// cbp             6            ..FV.......
/// </summary>
[Name("cbp")] cbp,
/// <summary>
/// mv              7            ..FV.......
/// </summary>
[Name("mv")] mv,
/// <summary>
/// ring1           8            ..FV.......
/// </summary>
[Name("ring1")] ring1,
/// <summary>
/// ring2           9            ..FV.......
/// </summary>
[Name("ring2")] ring2,
/// <summary>
/// all             10           ..FV.......
/// </summary>
[Name("all")] all,
}

}
