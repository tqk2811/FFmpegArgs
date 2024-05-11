namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C fillborders       V-&gt;V       Fill borders of the input video.
/// </summary>
public class FillbordersFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal FillbordersFilterGen(ImageMap input) : base("fillborders",input) { AddMapOut(); }
/// <summary>
///  set the left fill border (from 0 to INT_MAX) (default 0)
/// </summary>
public FillbordersFilterGen left(int left) => this.SetOptionRange("left", left,0,INT_MAX);
/// <summary>
///  set the right fill border (from 0 to INT_MAX) (default 0)
/// </summary>
public FillbordersFilterGen right(int right) => this.SetOptionRange("right", right,0,INT_MAX);
/// <summary>
///  set the top fill border (from 0 to INT_MAX) (default 0)
/// </summary>
public FillbordersFilterGen top(int top) => this.SetOptionRange("top", top,0,INT_MAX);
/// <summary>
///  set the bottom fill border (from 0 to INT_MAX) (default 0)
/// </summary>
public FillbordersFilterGen bottom(int bottom) => this.SetOptionRange("bottom", bottom,0,INT_MAX);
/// <summary>
///  set the fill borders mode (from 0 to 6) (default smear)
/// </summary>
public FillbordersFilterGen mode(FillbordersFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the color for the fixed/fade mode (default &quot;black&quot;)
/// </summary>
public FillbordersFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Fill borders of the input video.
/// </summary>
public static FillbordersFilterGen FillbordersFilterGen(this ImageMap input0) => new FillbordersFilterGen(input0);
}
/// <summary>
///  set the fill borders mode (from 0 to 6) (default smear)
/// </summary>
public enum FillbordersFilterGenMode
{
/// <summary>
/// smear           0            ..FV.....T.
/// </summary>
[Name("smear")] smear,
/// <summary>
/// mirror          1            ..FV.....T.
/// </summary>
[Name("mirror")] mirror,
/// <summary>
/// fixed           2            ..FV.....T.
/// </summary>
[Name("fixed")] _fixed,
/// <summary>
/// reflect         3            ..FV.....T.
/// </summary>
[Name("reflect")] reflect,
/// <summary>
/// wrap            4            ..FV.....T.
/// </summary>
[Name("wrap")] wrap,
/// <summary>
/// fade            5            ..FV.....T.
/// </summary>
[Name("fade")] fade,
/// <summary>
/// margins         6            ..FV.....T.
/// </summary>
[Name("margins")] margins,
}

}
