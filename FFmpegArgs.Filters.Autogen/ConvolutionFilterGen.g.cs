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
public class ConvolutionFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ConvolutionFilterGen(ImageMap input) : base("convolution",input) { AddMapOut(); }
/// <summary>
///  set matrix for 1st plane (default "0 0 0 0 1 0 0 0 0")
/// </summary>
public ConvolutionFilterGen _0m(string _0m) => this.SetOption("0m",_0m);
/// <summary>
///  set matrix for 2nd plane (default "0 0 0 0 1 0 0 0 0")
/// </summary>
public ConvolutionFilterGen _1m(string _1m) => this.SetOption("1m",_1m);
/// <summary>
///  set matrix for 3rd plane (default "0 0 0 0 1 0 0 0 0")
/// </summary>
public ConvolutionFilterGen _2m(string _2m) => this.SetOption("2m",_2m);
/// <summary>
///  set matrix for 4th plane (default "0 0 0 0 1 0 0 0 0")
/// </summary>
public ConvolutionFilterGen _3m(string _3m) => this.SetOption("3m",_3m);
/// <summary>
///  set rdiv for 1st plane (from 0 to INT_MAX) (default 0)
/// </summary>
public ConvolutionFilterGen _0rdiv(float _0rdiv) => this.SetOptionRange("0rdiv", _0rdiv,0,INT_MAX);
/// <summary>
///  set rdiv for 2nd plane (from 0 to INT_MAX) (default 0)
/// </summary>
public ConvolutionFilterGen _1rdiv(float _1rdiv) => this.SetOptionRange("1rdiv", _1rdiv,0,INT_MAX);
/// <summary>
///  set rdiv for 3rd plane (from 0 to INT_MAX) (default 0)
/// </summary>
public ConvolutionFilterGen _2rdiv(float _2rdiv) => this.SetOptionRange("2rdiv", _2rdiv,0,INT_MAX);
/// <summary>
///  set rdiv for 4th plane (from 0 to INT_MAX) (default 0)
/// </summary>
public ConvolutionFilterGen _3rdiv(float _3rdiv) => this.SetOptionRange("3rdiv", _3rdiv,0,INT_MAX);
/// <summary>
///  set bias for 1st plane (from 0 to INT_MAX) (default 0)
/// </summary>
public ConvolutionFilterGen _0bias(float _0bias) => this.SetOptionRange("0bias", _0bias,0,INT_MAX);
/// <summary>
///  set bias for 2nd plane (from 0 to INT_MAX) (default 0)
/// </summary>
public ConvolutionFilterGen _1bias(float _1bias) => this.SetOptionRange("1bias", _1bias,0,INT_MAX);
/// <summary>
///  set bias for 3rd plane (from 0 to INT_MAX) (default 0)
/// </summary>
public ConvolutionFilterGen _2bias(float _2bias) => this.SetOptionRange("2bias", _2bias,0,INT_MAX);
/// <summary>
///  set bias for 4th plane (from 0 to INT_MAX) (default 0)
/// </summary>
public ConvolutionFilterGen _3bias(float _3bias) => this.SetOptionRange("3bias", _3bias,0,INT_MAX);
/// <summary>
///  set matrix mode for 1st plane (from 0 to 2) (default square)
/// </summary>
public ConvolutionFilterGen _0mode(ConvolutionFilterGen_0mode _0mode) => this.SetOption("0mode", _0mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set matrix mode for 2nd plane (from 0 to 2) (default square)
/// </summary>
public ConvolutionFilterGen _1mode(ConvolutionFilterGen_1mode _1mode) => this.SetOption("1mode", _1mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set matrix mode for 3rd plane (from 0 to 2) (default square)
/// </summary>
public ConvolutionFilterGen _2mode(ConvolutionFilterGen_2mode _2mode) => this.SetOption("2mode", _2mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set matrix mode for 4th plane (from 0 to 2) (default square)
/// </summary>
public ConvolutionFilterGen _3mode(ConvolutionFilterGen_3mode _3mode) => this.SetOption("3mode", _3mode.GetAttribute<NameAttribute>().Name);
}
public static class ConvolutionFilterGenExtensions
{
/// <summary>
/// Apply convolution filter.
/// </summary>
public static ConvolutionFilterGen ConvolutionFilterGen(this ImageMap input) => new ConvolutionFilterGen(input);
}
public enum ConvolutionFilterGen_0mode
{
[Name("square")] square,
[Name("row")] row,
[Name("column")] column,
}

public enum ConvolutionFilterGen_1mode
{
[Name("square")] square,
[Name("row")] row,
[Name("column")] column,
}

public enum ConvolutionFilterGen_2mode
{
[Name("square")] square,
[Name("row")] row,
[Name("column")] column,
}

public enum ConvolutionFilterGen_3mode
{
[Name("square")] square,
[Name("row")] row,
[Name("column")] column,
}

}
