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
public static Convolution_openclFilterGen Convolution_openclFilterGen(this ImageMap input) => new Convolution_openclFilterGen(input);
}
}
