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
public class CompensationdelayFilterGen : AudioToAudioFilter
{
internal CompensationdelayFilterGen(AudioMap input) : base("compensationdelay",input) { AddMapOut(); }
/// <summary>
///  set mm distance (from 0 to 10) (default 0)
/// </summary>
public CompensationdelayFilterGen mm(int mm) => this.SetOptionRange("mm", mm,0,10);
/// <summary>
///  set cm distance (from 0 to 100) (default 0)
/// </summary>
public CompensationdelayFilterGen cm(int cm) => this.SetOptionRange("cm", cm,0,100);
/// <summary>
///  set meter distance (from 0 to 100) (default 0)
/// </summary>
public CompensationdelayFilterGen m(int m) => this.SetOptionRange("m", m,0,100);
/// <summary>
///  set dry amount (from 0 to 1) (default 0)
/// </summary>
public CompensationdelayFilterGen dry(double dry) => this.SetOptionRange("dry", dry,0,1);
/// <summary>
///  set wet amount (from 0 to 1) (default 1)
/// </summary>
public CompensationdelayFilterGen wet(double wet) => this.SetOptionRange("wet", wet,0,1);
/// <summary>
///  set temperature °C (from -50 to 50) (default 20)
/// </summary>
public CompensationdelayFilterGen temp(int temp) => this.SetOptionRange("temp", temp,-50,50);
}
public static class CompensationdelayFilterGenExtensions
{
/// <summary>
/// Audio Compensation Delay Line.
/// </summary>
public static CompensationdelayFilterGen CompensationdelayFilterGen(this AudioMap input0) => new CompensationdelayFilterGen(input0);
/// <summary>
/// Audio Compensation Delay Line.
/// </summary>
public static CompensationdelayFilterGen CompensationdelayFilterGen(this AudioMap input0,CompensationdelayFilterGenConfig config)
{
var result = new CompensationdelayFilterGen(input0);
if(config?.mm != null) result.mm(config.mm.Value);
if(config?.cm != null) result.cm(config.cm.Value);
if(config?.m != null) result.m(config.m.Value);
if(config?.dry != null) result.dry(config.dry.Value);
if(config?.wet != null) result.wet(config.wet.Value);
if(config?.temp != null) result.temp(config.temp.Value);
return result;
}
}
public class CompensationdelayFilterGenConfig
{
/// <summary>
///  set mm distance (from 0 to 10) (default 0)
/// </summary>
public int? mm { get; set; }
/// <summary>
///  set cm distance (from 0 to 100) (default 0)
/// </summary>
public int? cm { get; set; }
/// <summary>
///  set meter distance (from 0 to 100) (default 0)
/// </summary>
public int? m { get; set; }
/// <summary>
///  set dry amount (from 0 to 1) (default 0)
/// </summary>
public double? dry { get; set; }
/// <summary>
///  set wet amount (from 0 to 1) (default 1)
/// </summary>
public double? wet { get; set; }
/// <summary>
///  set temperature °C (from -50 to 50) (default 20)
/// </summary>
public int? temp { get; set; }
}
}
