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
public class SubtitlesFilterGen : ImageToImageFilter
{
internal SubtitlesFilterGen(ImageMap input) : base("subtitles",input) { AddMapOut(); }
/// <summary>
///  set the filename of file to read
/// </summary>
public SubtitlesFilterGen filename(string filename) => this.SetOption("filename",filename);
/// <summary>
///  set the filename of file to read
/// </summary>
public SubtitlesFilterGen f(string f) => this.SetOption("f",f);
/// <summary>
///  set the size of the original video (used to scale fonts)
/// </summary>
public SubtitlesFilterGen original_size(Size size) => this.SetOption("original_size",$"{size.Width}x{size.Height}");
/// <summary>
///  set the directory containing the fonts to read
/// </summary>
public SubtitlesFilterGen fontsdir(string fontsdir) => this.SetOption("fontsdir",fontsdir);
/// <summary>
///  enable processing of alpha channel (default false)
/// </summary>
public SubtitlesFilterGen alpha(bool flag) => this.SetOption("alpha",flag.ToFFmpegFlag());
/// <summary>
///  set input character encoding
/// </summary>
public SubtitlesFilterGen charenc(string charenc) => this.SetOption("charenc",charenc);
/// <summary>
///  set stream index (from -1 to INT_MAX) (default -1)
/// </summary>
public SubtitlesFilterGen stream_index(int stream_index) => this.SetOptionRange("stream_index", stream_index,-1,INT_MAX);
/// <summary>
///  set stream index (from -1 to INT_MAX) (default -1)
/// </summary>
public SubtitlesFilterGen si(int si) => this.SetOptionRange("si", si,-1,INT_MAX);
/// <summary>
///  force subtitle style
/// </summary>
public SubtitlesFilterGen force_style(string force_style) => this.SetOption("force_style",force_style);
}
public static class SubtitlesFilterGenExtensions
{
/// <summary>
/// Render text subtitles onto input video using the libass library.
/// </summary>
public static SubtitlesFilterGen SubtitlesFilterGen(this ImageMap input0) => new SubtitlesFilterGen(input0);
}
}
