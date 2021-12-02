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
public class MaskedmergeFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal MaskedmergeFilterGen(params ImageMap[] inputs) : base("maskedmerge",inputs) { AddMapOut(); }
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public MaskedmergeFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
public static class MaskedmergeFilterGenExtensions
{
/// <summary>
/// Merge first stream with second stream using third stream as mask.
/// </summary>
public static MaskedmergeFilterGen MaskedmergeFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2) => new MaskedmergeFilterGen(input0, input1, input2);
/// <summary>
/// Merge first stream with second stream using third stream as mask.
/// </summary>
public static MaskedmergeFilterGen MaskedmergeFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2,MaskedmergeFilterGenConfig config)
{
var result = new MaskedmergeFilterGen(input0, input1, input2);
if(config?.planes != null) result.planes(config.planes.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class MaskedmergeFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public int? planes { get; set; }
public string TimelineSupport { get; set; }
}
}
