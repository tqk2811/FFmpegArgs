namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. colorspace        V->V       Convert between colorspaces.
/// </summary>
public class ColorspaceFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal ColorspaceFilterGen(ImageMap input) : base("colorspace",input) { AddMapOut(); }
/// <summary>
///  Set all color properties together (from 0 to 8) (default 0)
/// </summary>
public ColorspaceFilterGen all(ColorspaceFilterGenAll all) => this.SetOption("all", all.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Output colorspace (from 0 to 14) (default 2)
/// </summary>
public ColorspaceFilterGen space(ColorspaceFilterGenSpace space) => this.SetOption("space", space.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Output color range (from 0 to 2) (default 0)
/// </summary>
public ColorspaceFilterGen range(ColorspaceFilterGenRange range) => this.SetOption("range", range.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Output color primaries (from 0 to 22) (default 2)
/// </summary>
public ColorspaceFilterGen primaries(ColorspaceFilterGenPrimaries primaries) => this.SetOption("primaries", primaries.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Output transfer characteristics (from 0 to 18) (default 2)
/// </summary>
public ColorspaceFilterGen trc(ColorspaceFilterGenTrc trc) => this.SetOption("trc", trc.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Output pixel format (from -1 to 162) (default -1)
/// </summary>
public ColorspaceFilterGen format(ColorspaceFilterGenFormat format) => this.SetOption("format", format.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Ignore primary chromaticity and gamma correction (default false)
/// </summary>
public ColorspaceFilterGen fast(bool fast) => this.SetOption("fast",fast.ToFFmpegFlag());
/// <summary>
///  Dithering mode (from 0 to 1) (default none)
/// </summary>
public ColorspaceFilterGen dither(ColorspaceFilterGenDither dither) => this.SetOption("dither", dither.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Whitepoint adaptation method (from 0 to 2) (default bradford)
/// </summary>
public ColorspaceFilterGen wpadapt(ColorspaceFilterGenWpadapt wpadapt) => this.SetOption("wpadapt", wpadapt.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Set all input color properties together (from 0 to 8) (default 0)
/// </summary>
public ColorspaceFilterGen iall(ColorspaceFilterGenIall iall) => this.SetOption("iall", iall.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Input colorspace (from 0 to 22) (default 2)
/// </summary>
public ColorspaceFilterGen ispace(ColorspaceFilterGenIspace ispace) => this.SetOption("ispace", ispace.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Input color range (from 0 to 2) (default 0)
/// </summary>
public ColorspaceFilterGen irange(ColorspaceFilterGenIrange irange) => this.SetOption("irange", irange.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Input color primaries (from 0 to 22) (default 2)
/// </summary>
public ColorspaceFilterGen iprimaries(ColorspaceFilterGenIprimaries iprimaries) => this.SetOption("iprimaries", iprimaries.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Input transfer characteristics (from 0 to 18) (default 2)
/// </summary>
public ColorspaceFilterGen itrc(ColorspaceFilterGenItrc itrc) => this.SetOption("itrc", itrc.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Convert between colorspaces.
/// </summary>
public static ColorspaceFilterGen ColorspaceFilterGen(this ImageMap input0) => new ColorspaceFilterGen(input0);
}
/// <summary>
///  Set all color properties together (from 0 to 8) (default 0)
/// </summary>
public enum ColorspaceFilterGenAll
{
/// <summary>
/// bt470m          1            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
/// <summary>
/// bt470bg         2            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// bt601-6-525     3            ..FV.......
/// </summary>
[Name("bt601-6-525")] bt601_6_525,
/// <summary>
/// bt601-6-625     4            ..FV.......
/// </summary>
[Name("bt601-6-625")] bt601_6_625,
/// <summary>
/// bt709           5            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// bt2020          8            ..FV.......
/// </summary>
[Name("bt2020")] bt2020,
}

/// <summary>
///  Output colorspace (from 0 to 14) (default 2)
/// </summary>
public enum ColorspaceFilterGenSpace
{
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// fcc             4            ..FV.......
/// </summary>
[Name("fcc")] fcc,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// ycgco           8            ..FV.......
/// </summary>
[Name("ycgco")] ycgco,
/// <summary>
/// gbr             0            ..FV.......
/// </summary>
[Name("gbr")] gbr,
/// <summary>
/// bt2020nc        9            ..FV.......
/// </summary>
[Name("bt2020nc")] bt2020nc,
/// <summary>
/// bt2020ncl       9            ..FV.......
/// </summary>
[Name("bt2020ncl")] bt2020ncl,
}

/// <summary>
///  Output color range (from 0 to 2) (default 0)
/// </summary>
public enum ColorspaceFilterGenRange
{
/// <summary>
/// tv              1            ..FV.......
/// </summary>
[Name("tv")] tv,
/// <summary>
/// mpeg            1            ..FV.......
/// </summary>
[Name("mpeg")] mpeg,
/// <summary>
/// pc              2            ..FV.......
/// </summary>
[Name("pc")] pc,
/// <summary>
/// jpeg            2            ..FV.......
/// </summary>
[Name("jpeg")] jpeg,
}

/// <summary>
///  Output color primaries (from 0 to 22) (default 2)
/// </summary>
public enum ColorspaceFilterGenPrimaries
{
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// bt470m          4            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// smpte428        10           ..FV.......
/// </summary>
[Name("smpte428")] smpte428,
/// <summary>
/// film            8            ..FV.......
/// </summary>
[Name("film")] film,
/// <summary>
/// smpte431        11           ..FV.......
/// </summary>
[Name("smpte431")] smpte431,
/// <summary>
/// smpte432        12           ..FV.......
/// </summary>
[Name("smpte432")] smpte432,
/// <summary>
/// bt2020          9            ..FV.......
/// </summary>
[Name("bt2020")] bt2020,
/// <summary>
/// jedec-p22       22           ..FV.......
/// </summary>
[Name("jedec-p22")] jedec_p22,
/// <summary>
/// ebu3213         22           ..FV.......
/// </summary>
[Name("ebu3213")] ebu3213,
}

/// <summary>
///  Output transfer characteristics (from 0 to 18) (default 2)
/// </summary>
public enum ColorspaceFilterGenTrc
{
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// bt470m          4            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
/// <summary>
/// gamma22         4            ..FV.......
/// </summary>
[Name("gamma22")] gamma22,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// gamma28         5            ..FV.......
/// </summary>
[Name("gamma28")] gamma28,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// linear          8            ..FV.......
/// </summary>
[Name("linear")] linear,
/// <summary>
/// srgb            13           ..FV.......
/// </summary>
[Name("srgb")] srgb,
/// <summary>
/// iec61966-2-1    13           ..FV.......
/// </summary>
[Name("iec61966-2-1")] iec61966_2_1,
/// <summary>
/// xvycc           11           ..FV.......
/// </summary>
[Name("xvycc")] xvycc,
/// <summary>
/// iec61966-2-4    11           ..FV.......
/// </summary>
[Name("iec61966-2-4")] iec61966_2_4,
/// <summary>
/// bt2020-10       14           ..FV.......
/// </summary>
[Name("bt2020-10")] bt2020_10,
/// <summary>
/// bt2020-12       15           ..FV.......
/// </summary>
[Name("bt2020-12")] bt2020_12,
}

/// <summary>
///  Output pixel format (from -1 to 162) (default -1)
/// </summary>
public enum ColorspaceFilterGenFormat
{
/// <summary>
/// yuv420p         0            ..FV.......
/// </summary>
[Name("yuv420p")] yuv420p,
/// <summary>
/// yuv420p10       62           ..FV.......
/// </summary>
[Name("yuv420p10")] yuv420p10,
/// <summary>
/// yuv420p12       123          ..FV.......
/// </summary>
[Name("yuv420p12")] yuv420p12,
/// <summary>
/// yuv422p         4            ..FV.......
/// </summary>
[Name("yuv422p")] yuv422p,
/// <summary>
/// yuv422p10       64           ..FV.......
/// </summary>
[Name("yuv422p10")] yuv422p10,
/// <summary>
/// yuv422p12       127          ..FV.......
/// </summary>
[Name("yuv422p12")] yuv422p12,
/// <summary>
/// yuv444p         5            ..FV.......
/// </summary>
[Name("yuv444p")] yuv444p,
/// <summary>
/// yuv444p10       68           ..FV.......
/// </summary>
[Name("yuv444p10")] yuv444p10,
/// <summary>
/// yuv444p12       131          ..FV.......
/// </summary>
[Name("yuv444p12")] yuv444p12,
}

/// <summary>
///  Dithering mode (from 0 to 1) (default none)
/// </summary>
public enum ColorspaceFilterGenDither
{
/// <summary>
/// none            0            ..FV.......
/// </summary>
[Name("none")] none,
/// <summary>
/// fsb             1            ..FV.......
/// </summary>
[Name("fsb")] fsb,
}

/// <summary>
///  Whitepoint adaptation method (from 0 to 2) (default bradford)
/// </summary>
public enum ColorspaceFilterGenWpadapt
{
/// <summary>
/// bradford        0            ..FV.......
/// </summary>
[Name("bradford")] bradford,
/// <summary>
/// vonkries        1            ..FV.......
/// </summary>
[Name("vonkries")] vonkries,
/// <summary>
/// identity        2            ..FV.......
/// </summary>
[Name("identity")] identity,
}

/// <summary>
///  Set all input color properties together (from 0 to 8) (default 0)
/// </summary>
public enum ColorspaceFilterGenIall
{
/// <summary>
/// bt470m          1            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
/// <summary>
/// bt470bg         2            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// bt601-6-525     3            ..FV.......
/// </summary>
[Name("bt601-6-525")] bt601_6_525,
/// <summary>
/// bt601-6-625     4            ..FV.......
/// </summary>
[Name("bt601-6-625")] bt601_6_625,
/// <summary>
/// bt709           5            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// bt2020          8            ..FV.......
/// </summary>
[Name("bt2020")] bt2020,
}

/// <summary>
///  Input colorspace (from 0 to 22) (default 2)
/// </summary>
public enum ColorspaceFilterGenIspace
{
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// fcc             4            ..FV.......
/// </summary>
[Name("fcc")] fcc,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// ycgco           8            ..FV.......
/// </summary>
[Name("ycgco")] ycgco,
/// <summary>
/// gbr             0            ..FV.......
/// </summary>
[Name("gbr")] gbr,
/// <summary>
/// bt2020nc        9            ..FV.......
/// </summary>
[Name("bt2020nc")] bt2020nc,
/// <summary>
/// bt2020ncl       9            ..FV.......
/// </summary>
[Name("bt2020ncl")] bt2020ncl,
}

/// <summary>
///  Input color range (from 0 to 2) (default 0)
/// </summary>
public enum ColorspaceFilterGenIrange
{
/// <summary>
/// tv              1            ..FV.......
/// </summary>
[Name("tv")] tv,
/// <summary>
/// mpeg            1            ..FV.......
/// </summary>
[Name("mpeg")] mpeg,
/// <summary>
/// pc              2            ..FV.......
/// </summary>
[Name("pc")] pc,
/// <summary>
/// jpeg            2            ..FV.......
/// </summary>
[Name("jpeg")] jpeg,
}

/// <summary>
///  Input color primaries (from 0 to 22) (default 2)
/// </summary>
public enum ColorspaceFilterGenIprimaries
{
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// bt470m          4            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// smpte428        10           ..FV.......
/// </summary>
[Name("smpte428")] smpte428,
/// <summary>
/// film            8            ..FV.......
/// </summary>
[Name("film")] film,
/// <summary>
/// smpte431        11           ..FV.......
/// </summary>
[Name("smpte431")] smpte431,
/// <summary>
/// smpte432        12           ..FV.......
/// </summary>
[Name("smpte432")] smpte432,
/// <summary>
/// bt2020          9            ..FV.......
/// </summary>
[Name("bt2020")] bt2020,
/// <summary>
/// jedec-p22       22           ..FV.......
/// </summary>
[Name("jedec-p22")] jedec_p22,
/// <summary>
/// ebu3213         22           ..FV.......
/// </summary>
[Name("ebu3213")] ebu3213,
}

/// <summary>
///  Input transfer characteristics (from 0 to 18) (default 2)
/// </summary>
public enum ColorspaceFilterGenItrc
{
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// bt470m          4            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
/// <summary>
/// gamma22         4            ..FV.......
/// </summary>
[Name("gamma22")] gamma22,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// gamma28         5            ..FV.......
/// </summary>
[Name("gamma28")] gamma28,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// linear          8            ..FV.......
/// </summary>
[Name("linear")] linear,
/// <summary>
/// srgb            13           ..FV.......
/// </summary>
[Name("srgb")] srgb,
/// <summary>
/// iec61966-2-1    13           ..FV.......
/// </summary>
[Name("iec61966-2-1")] iec61966_2_1,
/// <summary>
/// xvycc           11           ..FV.......
/// </summary>
[Name("xvycc")] xvycc,
/// <summary>
/// iec61966-2-4    11           ..FV.......
/// </summary>
[Name("iec61966-2-4")] iec61966_2_4,
/// <summary>
/// bt2020-10       14           ..FV.......
/// </summary>
[Name("bt2020-10")] bt2020_10,
/// <summary>
/// bt2020-12       15           ..FV.......
/// </summary>
[Name("bt2020-12")] bt2020_12,
}

}
