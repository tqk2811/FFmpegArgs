namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... minterpolate      V->V       Frame rate conversion using Motion Interpolation.
/// </summary>
public class MinterpolateFilterGen : ImageToImageFilter
{
internal MinterpolateFilterGen(ImageMap input) : base("minterpolate",input) { AddMapOut(); }
/// <summary>
///  output's frame rate (default "60")
/// </summary>
public MinterpolateFilterGen fps(Rational fps) => this.SetOption("fps",fps);
/// <summary>
///  motion interpolation mode (from 0 to 2) (default mci)
/// </summary>
public MinterpolateFilterGen mi_mode(MinterpolateFilterGenMi_mode mi_mode) => this.SetOption("mi_mode", mi_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  motion compensation mode (from 0 to 1) (default obmc)
/// </summary>
public MinterpolateFilterGen mc_mode(MinterpolateFilterGenMc_mode mc_mode) => this.SetOption("mc_mode", mc_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  motion estimation mode (from 0 to 1) (default bilat)
/// </summary>
public MinterpolateFilterGen me_mode(MinterpolateFilterGenMe_mode me_mode) => this.SetOption("me_mode", me_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  motion estimation method (from 1 to 9) (default epzs)
/// </summary>
public MinterpolateFilterGen me(MinterpolateFilterGenMe me) => this.SetOption("me", me.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  macroblock size (from 4 to 16) (default 16)
/// </summary>
public MinterpolateFilterGen mb_size(int mb_size) => this.SetOptionRange("mb_size", mb_size,4,16);
/// <summary>
///  search parameter (from 4 to INT_MAX) (default 32)
/// </summary>
public MinterpolateFilterGen search_param(int search_param) => this.SetOptionRange("search_param", search_param,4,INT_MAX);
/// <summary>
///  variable-size block motion compensation (from 0 to 1) (default 0)
/// </summary>
public MinterpolateFilterGen vsbmc(int vsbmc) => this.SetOptionRange("vsbmc", vsbmc,0,1);
/// <summary>
///  scene change detection method (from 0 to 1) (default fdiff)
/// </summary>
public MinterpolateFilterGen scd(MinterpolateFilterGenScd scd) => this.SetOption("scd", scd.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  scene change threshold (from 0 to 100) (default 10)
/// </summary>
public MinterpolateFilterGen scd_threshold(double scd_threshold) => this.SetOptionRange("scd_threshold", scd_threshold,0,100);
}
/// <summary>
/// </summary>
public static class MinterpolateFilterGenExtensions
{
/// <summary>
/// Frame rate conversion using Motion Interpolation.
/// </summary>
public static MinterpolateFilterGen MinterpolateFilterGen(this ImageMap input0) => new MinterpolateFilterGen(input0);
}
/// <summary>
///  motion interpolation mode (from 0 to 2) (default mci)
/// </summary>
public enum MinterpolateFilterGenMi_mode
{
/// <summary>
/// dup             0            ..FV....... duplicate frames
/// </summary>
[Name("dup")] dup,
/// <summary>
/// blend           1            ..FV....... blend frames
/// </summary>
[Name("blend")] blend,
/// <summary>
/// mci             2            ..FV....... motion compensated interpolation
/// </summary>
[Name("mci")] mci,
}

/// <summary>
///  motion compensation mode (from 0 to 1) (default obmc)
/// </summary>
public enum MinterpolateFilterGenMc_mode
{
/// <summary>
/// obmc            0            ..FV....... overlapped block motion compensation
/// </summary>
[Name("obmc")] obmc,
/// <summary>
/// aobmc           1            ..FV....... adaptive overlapped block motion compensation
/// </summary>
[Name("aobmc")] aobmc,
}

/// <summary>
///  motion estimation mode (from 0 to 1) (default bilat)
/// </summary>
public enum MinterpolateFilterGenMe_mode
{
/// <summary>
/// bidir           0            ..FV....... bidirectional motion estimation
/// </summary>
[Name("bidir")] bidir,
/// <summary>
/// bilat           1            ..FV....... bilateral motion estimation
/// </summary>
[Name("bilat")] bilat,
}

/// <summary>
///  motion estimation method (from 1 to 9) (default epzs)
/// </summary>
public enum MinterpolateFilterGenMe
{
/// <summary>
/// esa             1            ..FV....... exhaustive search
/// </summary>
[Name("esa")] esa,
/// <summary>
/// tss             2            ..FV....... three step search
/// </summary>
[Name("tss")] tss,
/// <summary>
/// tdls            3            ..FV....... two dimensional logarithmic search
/// </summary>
[Name("tdls")] tdls,
/// <summary>
/// ntss            4            ..FV....... new three step search
/// </summary>
[Name("ntss")] ntss,
/// <summary>
/// fss             5            ..FV....... four step search
/// </summary>
[Name("fss")] fss,
/// <summary>
/// ds              6            ..FV....... diamond search
/// </summary>
[Name("ds")] ds,
/// <summary>
/// hexbs           7            ..FV....... hexagon-based search
/// </summary>
[Name("hexbs")] hexbs,
/// <summary>
/// epzs            8            ..FV....... enhanced predictive zonal search
/// </summary>
[Name("epzs")] epzs,
/// <summary>
/// umh             9            ..FV....... uneven multi-hexagon search
/// </summary>
[Name("umh")] umh,
}

/// <summary>
///  scene change detection method (from 0 to 1) (default fdiff)
/// </summary>
public enum MinterpolateFilterGenScd
{
/// <summary>
/// none            0            ..FV....... disable detection
/// </summary>
[Name("none")] none,
/// <summary>
/// fdiff           1            ..FV....... frame difference
/// </summary>
[Name("fdiff")] fdiff,
}

}
