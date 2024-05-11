namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... pullup            V-&gt;V       Pullup from field sequence to frames.
/// </summary>
public class PullupFilterGen : ImageToImageFilter
{
internal PullupFilterGen(ImageMap input) : base("pullup",input) { AddMapOut(); }
/// <summary>
///  set left junk size (from 0 to INT_MAX) (default 1)
/// </summary>
public PullupFilterGen jl(int jl) => this.SetOptionRange("jl", jl,0,INT_MAX);
/// <summary>
///  set right junk size (from 0 to INT_MAX) (default 1)
/// </summary>
public PullupFilterGen jr(int jr) => this.SetOptionRange("jr", jr,0,INT_MAX);
/// <summary>
///  set top junk size (from 1 to INT_MAX) (default 4)
/// </summary>
public PullupFilterGen jt(int jt) => this.SetOptionRange("jt", jt,1,INT_MAX);
/// <summary>
///  set bottom junk size (from 1 to INT_MAX) (default 4)
/// </summary>
public PullupFilterGen jb(int jb) => this.SetOptionRange("jb", jb,1,INT_MAX);
/// <summary>
///  set strict breaks (default false)
/// </summary>
public PullupFilterGen sb(bool sb) => this.SetOption("sb",sb.ToFFmpegFlag());
/// <summary>
///  set metric plane (from 0 to 2) (default y)
/// </summary>
public PullupFilterGen mp(PullupFilterGenMp mp) => this.SetOption("mp", mp.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Pullup from field sequence to frames.
/// </summary>
public static PullupFilterGen PullupFilterGen(this ImageMap input0) => new PullupFilterGen(input0);
}
/// <summary>
///  set metric plane (from 0 to 2) (default y)
/// </summary>
public enum PullupFilterGenMp
{
/// <summary>
/// y               0            ..FV....... luma
/// </summary>
[Name("y")] y,
/// <summary>
/// u               1            ..FV....... chroma blue
/// </summary>
[Name("u")] u,
/// <summary>
/// v               2            ..FV....... chroma red
/// </summary>
[Name("v")] v,
}

}
