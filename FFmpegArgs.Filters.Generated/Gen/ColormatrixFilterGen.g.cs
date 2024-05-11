namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. colormatrix       V-&gt;V       Convert color matrix.
/// </summary>
public class ColormatrixFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal ColormatrixFilterGen(ImageMap input) : base("colormatrix",input) { AddMapOut(); }
/// <summary>
///  set source color matrix (from -1 to 4) (default -1)
/// </summary>
public ColormatrixFilterGen src(ColormatrixFilterGenSrc src) => this.SetOption("src", src.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set destination color matrix (from -1 to 4) (default -1)
/// </summary>
public ColormatrixFilterGen dst(ColormatrixFilterGenDst dst) => this.SetOption("dst", dst.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Convert color matrix.
/// </summary>
public static ColormatrixFilterGen ColormatrixFilterGen(this ImageMap input0) => new ColormatrixFilterGen(input0);
}
/// <summary>
///  set source color matrix (from -1 to 4) (default -1)
/// </summary>
public enum ColormatrixFilterGenSrc
{
/// <summary>
/// bt709           0            ..FV....... set BT.709 colorspace
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// fcc             1            ..FV....... set FCC colorspace
/// </summary>
[Name("fcc")] fcc,
/// <summary>
/// bt601           2            ..FV....... set BT.601 colorspace
/// </summary>
[Name("bt601")] bt601,
/// <summary>
/// bt470           2            ..FV....... set BT.470 colorspace
/// </summary>
[Name("bt470")] bt470,
/// <summary>
/// bt470bg         2            ..FV....... set BT.470 colorspace
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       2            ..FV....... set SMTPE-170M colorspace
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       3            ..FV....... set SMPTE-240M colorspace
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// bt2020          4            ..FV....... set BT.2020 colorspace
/// </summary>
[Name("bt2020")] bt2020,
}

/// <summary>
///  set destination color matrix (from -1 to 4) (default -1)
/// </summary>
public enum ColormatrixFilterGenDst
{
/// <summary>
/// bt709           0            ..FV....... set BT.709 colorspace
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// fcc             1            ..FV....... set FCC colorspace
/// </summary>
[Name("fcc")] fcc,
/// <summary>
/// bt601           2            ..FV....... set BT.601 colorspace
/// </summary>
[Name("bt601")] bt601,
/// <summary>
/// bt470           2            ..FV....... set BT.470 colorspace
/// </summary>
[Name("bt470")] bt470,
/// <summary>
/// bt470bg         2            ..FV....... set BT.470 colorspace
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       2            ..FV....... set SMTPE-170M colorspace
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       3            ..FV....... set SMPTE-240M colorspace
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// bt2020          4            ..FV....... set BT.2020 colorspace
/// </summary>
[Name("bt2020")] bt2020,
}

}
