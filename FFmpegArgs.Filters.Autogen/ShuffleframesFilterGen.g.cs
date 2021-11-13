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
public class ShuffleframesFilterGen : ImageToImageFilter,ITimelineSupport
{
internal ShuffleframesFilterGen(ImageMap input) : base("shuffleframes",input) { AddMapOut(); }
/// <summary>
///  set destination indexes of input frames (default "0")
/// </summary>
public ShuffleframesFilterGen mapping(string mapping) => this.SetOption("mapping",mapping);
}
public static class ShuffleframesFilterGenExtensions
{
/// <summary>
/// Shuffle video frames.
/// </summary>
public static ShuffleframesFilterGen ShuffleframesFilterGen(this ImageMap input) => new ShuffleframesFilterGen(input);
}
}
