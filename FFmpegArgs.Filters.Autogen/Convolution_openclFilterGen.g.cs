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
public class Convolution_openclFilterGen : ImageToImageFilter
{
internal Convolution_openclFilterGen(ImageMap input) : base("convolution_opencl",input) { AddMapOut(); }
/// <summary>
///  set matrix for 2nd plane (default "0 0 0 0 1 0 0 0 0")
/// </summary>
public Convolution_openclFilterGen _0m(string _0m) => this.SetOption("0m",_0m);
/// <summary>
///  set matrix for 2nd plane (default "0 0 0 0 1 0 0 0 0")
/// </summary>
public Convolution_openclFilterGen _1m(string _1m) => this.SetOption("1m",_1m);
/// <summary>
///  set matrix for 3rd plane (default "0 0 0 0 1 0 0 0 0")
/// </summary>
public Convolution_openclFilterGen _2m(string _2m) => this.SetOption("2m",_2m);
/// <summary>
///  set matrix for 4th plane (default "0 0 0 0 1 0 0 0 0")
/// </summary>
public Convolution_openclFilterGen _3m(string _3m) => this.SetOption("3m",_3m);
/// <summary>
///  set rdiv for 1nd plane (from 0 to INT_MAX) (default 1)
/// </summary>
public Convolution_openclFilterGen _0rdiv(float _0rdiv) => this.SetOptionRange("0rdiv", _0rdiv,0,INT_MAX);
/// <summary>
///  set rdiv for 2nd plane (from 0 to INT_MAX) (default 1)
/// </summary>
public Convolution_openclFilterGen _1rdiv(float _1rdiv) => this.SetOptionRange("1rdiv", _1rdiv,0,INT_MAX);
/// <summary>
///  set rdiv for 3rd plane (from 0 to INT_MAX) (default 1)
/// </summary>
public Convolution_openclFilterGen _2rdiv(float _2rdiv) => this.SetOptionRange("2rdiv", _2rdiv,0,INT_MAX);
/// <summary>
///  set rdiv for 4th plane (from 0 to INT_MAX) (default 1)
/// </summary>
public Convolution_openclFilterGen _3rdiv(float _3rdiv) => this.SetOptionRange("3rdiv", _3rdiv,0,INT_MAX);
/// <summary>
///  set bias for 1st plane (from 0 to INT_MAX) (default 0)
/// </summary>
public Convolution_openclFilterGen _0bias(float _0bias) => this.SetOptionRange("0bias", _0bias,0,INT_MAX);
/// <summary>
///  set bias for 2nd plane (from 0 to INT_MAX) (default 0)
/// </summary>
public Convolution_openclFilterGen _1bias(float _1bias) => this.SetOptionRange("1bias", _1bias,0,INT_MAX);
/// <summary>
///  set bias for 3rd plane (from 0 to INT_MAX) (default 0)
/// </summary>
public Convolution_openclFilterGen _2bias(float _2bias) => this.SetOptionRange("2bias", _2bias,0,INT_MAX);
/// <summary>
///  set bias for 4th plane (from 0 to INT_MAX) (default 0)
/// </summary>
public Convolution_openclFilterGen _3bias(float _3bias) => this.SetOptionRange("3bias", _3bias,0,INT_MAX);
}
public static class Convolution_openclFilterGenExtensions
{
/// <summary>
/// Apply convolution mask to input video
/// </summary>
public static Convolution_openclFilterGen Convolution_openclFilterGen(this ImageMap input0) => new Convolution_openclFilterGen(input0);
/// <summary>
/// Apply convolution mask to input video
/// </summary>
public static Convolution_openclFilterGen Convolution_openclFilterGen(this ImageMap input0,Convolution_openclFilterGenConfig config)
{
var result = new Convolution_openclFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?._0m)) result._0m(config._0m);
if(!string.IsNullOrWhiteSpace(config?._1m)) result._1m(config._1m);
if(!string.IsNullOrWhiteSpace(config?._2m)) result._2m(config._2m);
if(!string.IsNullOrWhiteSpace(config?._3m)) result._3m(config._3m);
if(config?._0rdiv != null) result._0rdiv(config._0rdiv.Value);
if(config?._1rdiv != null) result._1rdiv(config._1rdiv.Value);
if(config?._2rdiv != null) result._2rdiv(config._2rdiv.Value);
if(config?._3rdiv != null) result._3rdiv(config._3rdiv.Value);
if(config?._0bias != null) result._0bias(config._0bias.Value);
if(config?._1bias != null) result._1bias(config._1bias.Value);
if(config?._2bias != null) result._2bias(config._2bias.Value);
if(config?._3bias != null) result._3bias(config._3bias.Value);
return result;
}
}
public class Convolution_openclFilterGenConfig
{
/// <summary>
///  set matrix for 2nd plane (default "0 0 0 0 1 0 0 0 0")
/// </summary>
public string _0m { get; set; }
/// <summary>
///  set matrix for 2nd plane (default "0 0 0 0 1 0 0 0 0")
/// </summary>
public string _1m { get; set; }
/// <summary>
///  set matrix for 3rd plane (default "0 0 0 0 1 0 0 0 0")
/// </summary>
public string _2m { get; set; }
/// <summary>
///  set matrix for 4th plane (default "0 0 0 0 1 0 0 0 0")
/// </summary>
public string _3m { get; set; }
/// <summary>
///  set rdiv for 1nd plane (from 0 to INT_MAX) (default 1)
/// </summary>
public float? _0rdiv { get; set; }
/// <summary>
///  set rdiv for 2nd plane (from 0 to INT_MAX) (default 1)
/// </summary>
public float? _1rdiv { get; set; }
/// <summary>
///  set rdiv for 3rd plane (from 0 to INT_MAX) (default 1)
/// </summary>
public float? _2rdiv { get; set; }
/// <summary>
///  set rdiv for 4th plane (from 0 to INT_MAX) (default 1)
/// </summary>
public float? _3rdiv { get; set; }
/// <summary>
///  set bias for 1st plane (from 0 to INT_MAX) (default 0)
/// </summary>
public float? _0bias { get; set; }
/// <summary>
///  set bias for 2nd plane (from 0 to INT_MAX) (default 0)
/// </summary>
public float? _1bias { get; set; }
/// <summary>
///  set bias for 3rd plane (from 0 to INT_MAX) (default 0)
/// </summary>
public float? _2bias { get; set; }
/// <summary>
///  set bias for 4th plane (from 0 to INT_MAX) (default 0)
/// </summary>
public float? _3bias { get; set; }
}
}
