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
public class Deinterlace_qsvFilterGen : ImageToImageFilter
{
internal Deinterlace_qsvFilterGen(ImageMap input) : base("deinterlace_qsv",input) { AddMapOut(); }
/// <summary>
///  set deinterlace mode (from 1 to 2) (default advanced)
/// </summary>
public Deinterlace_qsvFilterGen mode(Deinterlace_qsvFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
}
public static class Deinterlace_qsvFilterGenExtensions
{
/// <summary>
/// QuickSync video deinterlacing
/// </summary>
public static Deinterlace_qsvFilterGen Deinterlace_qsvFilterGen(this ImageMap input0) => new Deinterlace_qsvFilterGen(input0);
}
public enum Deinterlace_qsvFilterGenMode
{
[Name("bob")] bob,
[Name("advanced")] advanced,
}

}
