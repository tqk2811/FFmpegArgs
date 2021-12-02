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
public class ChromanrFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ChromanrFilterGen(ImageMap input) : base("chromanr",input) { AddMapOut(); }
/// <summary>
///  set y+u+v threshold (from 1 to 200) (default 30)
/// </summary>
public ChromanrFilterGen thres(float thres) => this.SetOptionRange("thres", thres,1,200);
/// <summary>
///  set horizontal size (from 1 to 100) (default 5)
/// </summary>
public ChromanrFilterGen sizew(int sizew) => this.SetOptionRange("sizew", sizew,1,100);
/// <summary>
///  set vertical size (from 1 to 100) (default 5)
/// </summary>
public ChromanrFilterGen sizeh(int sizeh) => this.SetOptionRange("sizeh", sizeh,1,100);
/// <summary>
///  set horizontal step (from 1 to 50) (default 1)
/// </summary>
public ChromanrFilterGen stepw(int stepw) => this.SetOptionRange("stepw", stepw,1,50);
/// <summary>
///  set vertical step (from 1 to 50) (default 1)
/// </summary>
public ChromanrFilterGen steph(int steph) => this.SetOptionRange("steph", steph,1,50);
/// <summary>
///  set y threshold (from 1 to 200) (default 200)
/// </summary>
public ChromanrFilterGen threy(float threy) => this.SetOptionRange("threy", threy,1,200);
/// <summary>
///  set u threshold (from 1 to 200) (default 200)
/// </summary>
public ChromanrFilterGen threu(float threu) => this.SetOptionRange("threu", threu,1,200);
/// <summary>
///  set v threshold (from 1 to 200) (default 200)
/// </summary>
public ChromanrFilterGen threv(float threv) => this.SetOptionRange("threv", threv,1,200);
}
public static class ChromanrFilterGenExtensions
{
/// <summary>
/// Reduce chrominance noise.
/// </summary>
public static ChromanrFilterGen ChromanrFilterGen(this ImageMap input0) => new ChromanrFilterGen(input0);
/// <summary>
/// Reduce chrominance noise.
/// </summary>
public static ChromanrFilterGen ChromanrFilterGen(this ImageMap input0,ChromanrFilterGenConfig config)
{
var result = new ChromanrFilterGen(input0);
if(config?.thres != null) result.thres(config.thres);
if(config?.sizew != null) result.sizew(config.sizew);
if(config?.sizeh != null) result.sizeh(config.sizeh);
if(config?.stepw != null) result.stepw(config.stepw);
if(config?.steph != null) result.steph(config.steph);
if(config?.threy != null) result.threy(config.threy);
if(config?.threu != null) result.threu(config.threu);
if(config?.threv != null) result.threv(config.threv);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class ChromanrFilterGenConfig
{
/// <summary>
///  set y+u+v threshold (from 1 to 200) (default 30)
/// </summary>
public float thres { get; set; }
/// <summary>
///  set horizontal size (from 1 to 100) (default 5)
/// </summary>
public int sizew { get; set; }
/// <summary>
///  set vertical size (from 1 to 100) (default 5)
/// </summary>
public int sizeh { get; set; }
/// <summary>
///  set horizontal step (from 1 to 50) (default 1)
/// </summary>
public int stepw { get; set; }
/// <summary>
///  set vertical step (from 1 to 50) (default 1)
/// </summary>
public int steph { get; set; }
/// <summary>
///  set y threshold (from 1 to 200) (default 200)
/// </summary>
public float threy { get; set; }
/// <summary>
///  set u threshold (from 1 to 200) (default 200)
/// </summary>
public float threu { get; set; }
/// <summary>
///  set v threshold (from 1 to 200) (default 200)
/// </summary>
public float threv { get; set; }
public string TimelineSupport { get; set; }
}
}
