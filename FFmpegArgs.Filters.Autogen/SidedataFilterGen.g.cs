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
public class SidedataFilterGen : ImageToImageFilter,ITimelineSupport
{
internal SidedataFilterGen(ImageMap input) : base("sidedata",input) { AddMapOut(); }
/// <summary>
///  set a mode of operation (from 0 to 1) (default select)
/// </summary>
public SidedataFilterGen mode(SidedataFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set side data type (from -1 to INT_MAX) (default -1)
/// </summary>
public SidedataFilterGen type(SidedataFilterGenType type) => this.SetOption("type", type.GetAttribute<NameAttribute>().Name);
}
public static class SidedataFilterGenExtensions
{
/// <summary>
/// Manipulate video frame side data.
/// </summary>
public static SidedataFilterGen SidedataFilterGen(this ImageMap input0) => new SidedataFilterGen(input0);
/// <summary>
/// Manipulate video frame side data.
/// </summary>
public static SidedataFilterGen SidedataFilterGen(this ImageMap input0,SidedataFilterGenConfig config)
{
var result = new SidedataFilterGen(input0);
if(config?.mode != null) result.mode(config.mode);
if(config?.type != null) result.type(config.type);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class SidedataFilterGenConfig
{
/// <summary>
///  set a mode of operation (from 0 to 1) (default select)
/// </summary>
public SidedataFilterGenMode mode { get; set; }
/// <summary>
///  set side data type (from -1 to INT_MAX) (default -1)
/// </summary>
public SidedataFilterGenType type { get; set; }
public string TimelineSupport { get; set; }
}
public enum SidedataFilterGenMode
{
[Name("select")] select,
[Name("delete")] delete,
}

public enum SidedataFilterGenType
{
[Name("PANSCAN")] PANSCAN,
[Name("A53_CC")] A53_CC,
[Name("STEREO3D")] STEREO3D,
[Name("MATRIXENCODING")] MATRIXENCODING,
[Name("DOWNMIX_INFO")] DOWNMIX_INFO,
[Name("REPLAYGAIN")] REPLAYGAIN,
[Name("DISPLAYMATRIX")] DISPLAYMATRIX,
[Name("AFD")] AFD,
[Name("MOTION_VECTORS")] MOTION_VECTORS,
[Name("SKIP_SAMPLES")] SKIP_SAMPLES,
[Name("AUDIO_SERVICE_TYPE")] AUDIO_SERVICE_TYPE,
[Name("MASTERING_DISPLAY_METADATA")] MASTERING_DISPLAY_METADATA,
[Name("GOP_TIMECODE")] GOP_TIMECODE,
[Name("SPHERICAL")] SPHERICAL,
[Name("CONTENT_LIGHT_LEVEL")] CONTENT_LIGHT_LEVEL,
[Name("ICC_PROFILE")] ICC_PROFILE,
[Name("QP_TABLE_PROPERTIES")] QP_TABLE_PROPERTIES,
[Name("QP_TABLE_DATA")] QP_TABLE_DATA,
[Name("S12M_TIMECOD")] S12M_TIMECOD,
[Name("DYNAMIC_HDR_PLUS")] DYNAMIC_HDR_PLUS,
[Name("REGIONS_OF_INTEREST")] REGIONS_OF_INTEREST,
[Name("SEI_UNREGISTERED")] SEI_UNREGISTERED,
}

}
