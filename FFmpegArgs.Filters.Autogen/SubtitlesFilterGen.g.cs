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
///  set the size of the original video (used to scale fonts)
/// </summary>
public SubtitlesFilterGen original_size(Size original_size) => this.SetOption("original_size",$"{original_size.Width}x{original_size.Height}");
/// <summary>
///  set the directory containing the fonts to read
/// </summary>
public SubtitlesFilterGen fontsdir(string fontsdir) => this.SetOption("fontsdir",fontsdir);
/// <summary>
///  enable processing of alpha channel (default false)
/// </summary>
public SubtitlesFilterGen alpha(bool alpha) => this.SetOption("alpha",alpha.ToFFmpegFlag());
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
/// <summary>
/// Render text subtitles onto input video using the libass library.
/// </summary>
public static SubtitlesFilterGen SubtitlesFilterGen(this ImageMap input0,SubtitlesFilterGenConfig config)
{
var result = new SubtitlesFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.filename)) result.filename(config.filename);
if(config?.original_size != null) result.original_size(config.original_size.Value);
if(!string.IsNullOrWhiteSpace(config?.fontsdir)) result.fontsdir(config.fontsdir);
if(config?.alpha != null) result.alpha(config.alpha.Value);
if(!string.IsNullOrWhiteSpace(config?.charenc)) result.charenc(config.charenc);
if(config?.stream_index != null) result.stream_index(config.stream_index.Value);
if(config?.si != null) result.si(config.si.Value);
if(!string.IsNullOrWhiteSpace(config?.force_style)) result.force_style(config.force_style);
return result;
}
}
public class SubtitlesFilterGenConfig
{
/// <summary>
///  set the filename of file to read
/// </summary>
public string filename { get; set; }
/// <summary>
///  set the size of the original video (used to scale fonts)
/// </summary>
public Size? original_size { get; set; }
/// <summary>
///  set the directory containing the fonts to read
/// </summary>
public string fontsdir { get; set; }
/// <summary>
///  enable processing of alpha channel (default false)
/// </summary>
public bool? alpha { get; set; }
/// <summary>
///  set input character encoding
/// </summary>
public string charenc { get; set; }
/// <summary>
///  set stream index (from -1 to INT_MAX) (default -1)
/// </summary>
public int? stream_index { get; set; }
/// <summary>
///  set stream index (from -1 to INT_MAX) (default -1)
/// </summary>
public int? si { get; set; }
/// <summary>
///  force subtitle style
/// </summary>
public string force_style { get; set; }
}
}
