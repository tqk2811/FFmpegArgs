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
public class RandomFilterGen : ImageToImageFilter
{
internal RandomFilterGen(ImageMap input) : base("random",input) { AddMapOut(); }
/// <summary>
///  set number of frames in cache (from 2 to 512) (default 30)
/// </summary>
public RandomFilterGen frames(int frames) => this.SetOptionRange("frames", frames,2,512);
/// <summary>
///  set the seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public RandomFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
}
public static class RandomFilterGenExtensions
{
/// <summary>
/// Return random frames.
/// </summary>
public static RandomFilterGen RandomFilterGen(this ImageMap input0) => new RandomFilterGen(input0);
/// <summary>
/// Return random frames.
/// </summary>
public static RandomFilterGen RandomFilterGen(this ImageMap input0,RandomFilterGenConfig config)
{
var result = new RandomFilterGen(input0);
if(config?.frames != null) result.frames(config.frames.Value);
if(config?.seed != null) result.seed(config.seed.Value);
return result;
}
}
public class RandomFilterGenConfig
{
/// <summary>
///  set number of frames in cache (from 2 to 512) (default 30)
/// </summary>
public int? frames { get; set; }
/// <summary>
///  set the seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public long? seed { get; set; }
}
}
