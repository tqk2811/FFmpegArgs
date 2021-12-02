using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using FFmpegArgs;
using FFmpegArgs.Cores;
using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
namespace FFmpegArgs.Filters.Autogens
{
public class ColorspaceFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal ColorspaceFilterGen(ImageMap input) : base("colorspace",input) { AddMapOut(); }
/// <summary>
///  Set all color properties together (from 0 to 8) (default 0)
/// </summary>
public ColorspaceFilterGen all(ColorspaceFilterGenAll all) => this.SetOption("all", all.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Output colorspace (from 0 to 14) (default 2)
/// </summary>
public ColorspaceFilterGen space(ColorspaceFilterGenSpace space) => this.SetOption("space", space.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Output color range (from 0 to 2) (default 0)
/// </summary>
public ColorspaceFilterGen range(ColorspaceFilterGenRange range) => this.SetOption("range", range.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Output color primaries (from 0 to 22) (default 2)
/// </summary>
public ColorspaceFilterGen primaries(ColorspaceFilterGenPrimaries primaries) => this.SetOption("primaries", primaries.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Output transfer characteristics (from 0 to 18) (default 2)
/// </summary>
public ColorspaceFilterGen trc(ColorspaceFilterGenTrc trc) => this.SetOption("trc", trc.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Output pixel format (from -1 to 164) (default -1)
/// </summary>
public ColorspaceFilterGen format(ColorspaceFilterGenFormat format) => this.SetOption("format", format.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Ignore primary chromaticity and gamma correction (default false)
/// </summary>
public ColorspaceFilterGen fast(bool fast) => this.SetOption("fast",fast.ToFFmpegFlag());
/// <summary>
///  Dithering mode (from 0 to 1) (default none)
/// </summary>
public ColorspaceFilterGen dither(ColorspaceFilterGenDither dither) => this.SetOption("dither", dither.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Whitepoint adaptation method (from 0 to 2) (default bradford)
/// </summary>
public ColorspaceFilterGen wpadapt(ColorspaceFilterGenWpadapt wpadapt) => this.SetOption("wpadapt", wpadapt.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Set all input color properties together (from 0 to 8) (default 0)
/// </summary>
public ColorspaceFilterGen iall(ColorspaceFilterGenIall iall) => this.SetOption("iall", iall.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Input colorspace (from 0 to 22) (default 2)
/// </summary>
public ColorspaceFilterGen ispace(ColorspaceFilterGenIspace ispace) => this.SetOption("ispace", ispace.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Input color range (from 0 to 2) (default 0)
/// </summary>
public ColorspaceFilterGen irange(ColorspaceFilterGenIrange irange) => this.SetOption("irange", irange.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Input color primaries (from 0 to 22) (default 2)
/// </summary>
public ColorspaceFilterGen iprimaries(ColorspaceFilterGenIprimaries iprimaries) => this.SetOption("iprimaries", iprimaries.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Input transfer characteristics (from 0 to 18) (default 2)
/// </summary>
public ColorspaceFilterGen itrc(ColorspaceFilterGenItrc itrc) => this.SetOption("itrc", itrc.GetAttribute<NameAttribute>().Name);
}
public static class ColorspaceFilterGenExtensions
{
/// <summary>
/// Convert between colorspaces.
/// </summary>
public static ColorspaceFilterGen ColorspaceFilterGen(this ImageMap input0) => new ColorspaceFilterGen(input0);
/// <summary>
/// Convert between colorspaces.
/// </summary>
public static ColorspaceFilterGen ColorspaceFilterGen(this ImageMap input0,ColorspaceFilterGenConfig config)
{
var result = new ColorspaceFilterGen(input0);
if(config?.all != null) result.all(config.all.Value);
if(config?.space != null) result.space(config.space.Value);
if(config?.range != null) result.range(config.range.Value);
if(config?.primaries != null) result.primaries(config.primaries.Value);
if(config?.trc != null) result.trc(config.trc.Value);
if(config?.format != null) result.format(config.format.Value);
if(config?.fast != null) result.fast(config.fast.Value);
if(config?.dither != null) result.dither(config.dither.Value);
if(config?.wpadapt != null) result.wpadapt(config.wpadapt.Value);
if(config?.iall != null) result.iall(config.iall.Value);
if(config?.ispace != null) result.ispace(config.ispace.Value);
if(config?.irange != null) result.irange(config.irange.Value);
if(config?.iprimaries != null) result.iprimaries(config.iprimaries.Value);
if(config?.itrc != null) result.itrc(config.itrc.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class ColorspaceFilterGenConfig
{
/// <summary>
///  Set all color properties together (from 0 to 8) (default 0)
/// </summary>
public ColorspaceFilterGenAll? all { get; set; }
/// <summary>
///  Output colorspace (from 0 to 14) (default 2)
/// </summary>
public ColorspaceFilterGenSpace? space { get; set; }
/// <summary>
///  Output color range (from 0 to 2) (default 0)
/// </summary>
public ColorspaceFilterGenRange? range { get; set; }
/// <summary>
///  Output color primaries (from 0 to 22) (default 2)
/// </summary>
public ColorspaceFilterGenPrimaries? primaries { get; set; }
/// <summary>
///  Output transfer characteristics (from 0 to 18) (default 2)
/// </summary>
public ColorspaceFilterGenTrc? trc { get; set; }
/// <summary>
///  Output pixel format (from -1 to 164) (default -1)
/// </summary>
public ColorspaceFilterGenFormat? format { get; set; }
/// <summary>
///  Ignore primary chromaticity and gamma correction (default false)
/// </summary>
public bool? fast { get; set; }
/// <summary>
///  Dithering mode (from 0 to 1) (default none)
/// </summary>
public ColorspaceFilterGenDither? dither { get; set; }
/// <summary>
///  Whitepoint adaptation method (from 0 to 2) (default bradford)
/// </summary>
public ColorspaceFilterGenWpadapt? wpadapt { get; set; }
/// <summary>
///  Set all input color properties together (from 0 to 8) (default 0)
/// </summary>
public ColorspaceFilterGenIall? iall { get; set; }
/// <summary>
///  Input colorspace (from 0 to 22) (default 2)
/// </summary>
public ColorspaceFilterGenIspace? ispace { get; set; }
/// <summary>
///  Input color range (from 0 to 2) (default 0)
/// </summary>
public ColorspaceFilterGenIrange? irange { get; set; }
/// <summary>
///  Input color primaries (from 0 to 22) (default 2)
/// </summary>
public ColorspaceFilterGenIprimaries? iprimaries { get; set; }
/// <summary>
///  Input transfer characteristics (from 0 to 18) (default 2)
/// </summary>
public ColorspaceFilterGenItrc? itrc { get; set; }
public string TimelineSupport { get; set; }
}
public enum ColorspaceFilterGenAll
{
[Name("bt470m")] bt470m,
[Name("bt470bg")] bt470bg,
[Name("bt601-6-525")] bt601_6_525,
[Name("bt601-6-625")] bt601_6_625,
[Name("bt709")] bt709,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("bt2020")] bt2020,
}

public enum ColorspaceFilterGenSpace
{
[Name("bt709")] bt709,
[Name("fcc")] fcc,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("ycgco")] ycgco,
[Name("gbr")] gbr,
[Name("bt2020nc")] bt2020nc,
[Name("bt2020ncl")] bt2020ncl,
}

public enum ColorspaceFilterGenRange
{
[Name("tv")] tv,
[Name("mpeg")] mpeg,
[Name("pc")] pc,
[Name("jpeg")] jpeg,
}

public enum ColorspaceFilterGenPrimaries
{
[Name("bt709")] bt709,
[Name("bt470m")] bt470m,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("smpte428")] smpte428,
[Name("film")] film,
[Name("smpte431")] smpte431,
[Name("smpte432")] smpte432,
[Name("bt2020")] bt2020,
[Name("jedec-p22")] jedec_p22,
[Name("ebu3213")] ebu3213,
}

public enum ColorspaceFilterGenTrc
{
[Name("bt709")] bt709,
[Name("bt470m")] bt470m,
[Name("gamma22")] gamma22,
[Name("bt470bg")] bt470bg,
[Name("gamma28")] gamma28,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("linear")] linear,
[Name("srgb")] srgb,
[Name("iec61966-2-1")] iec61966_2_1,
[Name("xvycc")] xvycc,
[Name("iec61966-2-4")] iec61966_2_4,
[Name("bt2020-10")] bt2020_10,
[Name("bt2020-12")] bt2020_12,
}

public enum ColorspaceFilterGenFormat
{
[Name("yuv420p")] yuv420p,
[Name("yuv420p10")] yuv420p10,
[Name("yuv420p12")] yuv420p12,
[Name("yuv422p")] yuv422p,
[Name("yuv422p10")] yuv422p10,
[Name("yuv422p12")] yuv422p12,
[Name("yuv444p")] yuv444p,
[Name("yuv444p10")] yuv444p10,
[Name("yuv444p12")] yuv444p12,
}

public enum ColorspaceFilterGenDither
{
[Name("none")] none,
[Name("fsb")] fsb,
}

public enum ColorspaceFilterGenWpadapt
{
[Name("bradford")] bradford,
[Name("vonkries")] vonkries,
[Name("identity")] identity,
}

public enum ColorspaceFilterGenIall
{
[Name("bt470m")] bt470m,
[Name("bt470bg")] bt470bg,
[Name("bt601-6-525")] bt601_6_525,
[Name("bt601-6-625")] bt601_6_625,
[Name("bt709")] bt709,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("bt2020")] bt2020,
}

public enum ColorspaceFilterGenIspace
{
[Name("bt709")] bt709,
[Name("fcc")] fcc,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("ycgco")] ycgco,
[Name("gbr")] gbr,
[Name("bt2020nc")] bt2020nc,
[Name("bt2020ncl")] bt2020ncl,
}

public enum ColorspaceFilterGenIrange
{
[Name("tv")] tv,
[Name("mpeg")] mpeg,
[Name("pc")] pc,
[Name("jpeg")] jpeg,
}

public enum ColorspaceFilterGenIprimaries
{
[Name("bt709")] bt709,
[Name("bt470m")] bt470m,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("smpte428")] smpte428,
[Name("film")] film,
[Name("smpte431")] smpte431,
[Name("smpte432")] smpte432,
[Name("bt2020")] bt2020,
[Name("jedec-p22")] jedec_p22,
[Name("ebu3213")] ebu3213,
}

public enum ColorspaceFilterGenItrc
{
[Name("bt709")] bt709,
[Name("bt470m")] bt470m,
[Name("gamma22")] gamma22,
[Name("bt470bg")] bt470bg,
[Name("gamma28")] gamma28,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("linear")] linear,
[Name("srgb")] srgb,
[Name("iec61966-2-1")] iec61966_2_1,
[Name("xvycc")] xvycc,
[Name("iec61966-2-4")] iec61966_2_4,
[Name("bt2020-10")] bt2020_10,
[Name("bt2020-12")] bt2020_12,
}

}
