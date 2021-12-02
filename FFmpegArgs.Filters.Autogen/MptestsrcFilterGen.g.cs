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
public class MptestsrcFilterGen : SourceImageFilter
{
internal MptestsrcFilterGen(FilterGraph input) : base("mptestsrc",input) { AddMapOut(); }
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
public MptestsrcFilterGen test(MptestsrcFilterGenTest test) => this.SetOption("test", test.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Set the maximum number of frames generated for each test (from 1 to I64_MAX) (default 30)
/// </summary>
public MptestsrcFilterGen max_frames(long max_frames) => this.SetOptionRange("max_frames", max_frames,1,I64_MAX);
}
public static class MptestsrcFilterGenExtensions
{
/// <summary>
/// Generate various test pattern.
/// </summary>
public static MptestsrcFilterGen MptestsrcFilterGen(this FilterGraph input0) => new MptestsrcFilterGen(input0);
/// <summary>
/// Generate various test pattern.
/// </summary>
public static MptestsrcFilterGen MptestsrcFilterGen(this FilterGraph input0,MptestsrcFilterGenConfig config)
{
var result = new MptestsrcFilterGen(input0);
if(config?.rate != null) result.rate(config.rate);
if(config?.duration != null) result.duration(config.duration.Value);
if(config?.test != null) result.test(config.test.Value);
if(config?.max_frames != null) result.max_frames(config.max_frames.Value);
return result;
}
}
public class MptestsrcFilterGenConfig
{
/// <summary>
///  set video rate (default "25")
/// </summary>
public Rational rate { get; set; }
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public TimeSpan? duration { get; set; }
/// <summary>
///  set test to perform (from 0 to INT_MAX) (default all)
/// </summary>
public MptestsrcFilterGenTest? test { get; set; }
/// <summary>
///  Set the maximum number of frames generated for each test (from 1 to I64_MAX) (default 30)
/// </summary>
public long? max_frames { get; set; }
}
public enum MptestsrcFilterGenTest
{
[Name("dc_luma")] dc_luma,
[Name("dc_chroma")] dc_chroma,
[Name("freq_luma")] freq_luma,
[Name("freq_chroma")] freq_chroma,
[Name("amp_luma")] amp_luma,
[Name("amp_chroma")] amp_chroma,
[Name("cbp")] cbp,
[Name("mv")] mv,
[Name("ring1")] ring1,
[Name("ring2")] ring2,
[Name("all")] all,
}

}
