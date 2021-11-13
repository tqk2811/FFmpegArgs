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
public class SendcmdFilterGen : ImageToImageFilter
{
internal SendcmdFilterGen(ImageMap input) : base("sendcmd",input) { AddMapOut(); }
/// <summary>
///  set commands
/// </summary>
public SendcmdFilterGen commands(string commands) => this.SetOption("commands",commands);
/// <summary>
///  set commands
/// </summary>
public SendcmdFilterGen c(string c) => this.SetOption("c",c);
/// <summary>
///  set commands file
/// </summary>
public SendcmdFilterGen filename(string filename) => this.SetOption("filename",filename);
/// <summary>
///  set commands file
/// </summary>
public SendcmdFilterGen f(string f) => this.SetOption("f",f);
}
public static class SendcmdFilterGenExtensions
{
/// <summary>
/// Send commands to filters.
/// </summary>
public static SendcmdFilterGen SendcmdFilterGen(this ImageMap input) => new SendcmdFilterGen(input);
}
}
