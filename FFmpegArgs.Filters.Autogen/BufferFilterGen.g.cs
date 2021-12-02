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
public class BufferFilterGen : SourceImageFilter
{
internal BufferFilterGen(FilterGraph input) : base("buffer",input) { AddMapOut(); }
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public BufferFilterGen width(int width) => this.SetOptionRange("width", width,0,INT_MAX);
/// <summary>
/// 
/// </summary>
public BufferFilterGen video_size(Size video_size) => this.SetOption("video_size",$"{video_size.Width}x{video_size.Height}");
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public BufferFilterGen height(int height) => this.SetOptionRange("height", height,0,INT_MAX);
/// <summary>
///  (default none)
/// </summary>
public BufferFilterGen pix_fmt(PixFmt pix_fmt) => this.SetOption("pix_fmt",pix_fmt.ToString());
/// <summary>
///  sample aspect ratio (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public BufferFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,DBL_MAX));
/// <summary>
///  sample aspect ratio (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public BufferFilterGen pixel_aspect(Rational pixel_aspect) => this.SetOption("pixel_aspect",pixel_aspect.Check(0,DBL_MAX));
/// <summary>
///  (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public BufferFilterGen time_base(Rational time_base) => this.SetOption("time_base",time_base.Check(0,DBL_MAX));
/// <summary>
///  (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public BufferFilterGen frame_rate(Rational frame_rate) => this.SetOption("frame_rate",frame_rate.Check(0,DBL_MAX));
/// <summary>
/// 
/// </summary>
public BufferFilterGen sws_param(string sws_param) => this.SetOption("sws_param",sws_param);
}
public static class BufferFilterGenExtensions
{
/// <summary>
/// Buffer video frames, and make them accessible to the filterchain.
/// </summary>
public static BufferFilterGen BufferFilterGen(this FilterGraph input0) => new BufferFilterGen(input0);
/// <summary>
/// Buffer video frames, and make them accessible to the filterchain.
/// </summary>
public static BufferFilterGen BufferFilterGen(this FilterGraph input0,BufferFilterGenConfig config)
{
var result = new BufferFilterGen(input0);
if(config?.width != null) result.width(config.width);
if(config?.video_size != null) result.video_size(config.video_size);
if(config?.height != null) result.height(config.height);
if(config?.pix_fmt != null) result.pix_fmt(config.pix_fmt);
if(config?.sar != null) result.sar(config.sar);
if(config?.pixel_aspect != null) result.pixel_aspect(config.pixel_aspect);
if(config?.time_base != null) result.time_base(config.time_base);
if(config?.frame_rate != null) result.frame_rate(config.frame_rate);
if(config?.sws_param != null) result.sws_param(config.sws_param);
return result;
}
}
public class BufferFilterGenConfig
{
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public int width { get; set; }
/// <summary>
/// 
/// </summary>
public Size video_size { get; set; }
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public int height { get; set; }
/// <summary>
///  (default none)
/// </summary>
public PixFmt pix_fmt { get; set; }
/// <summary>
///  sample aspect ratio (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public Rational sar { get; set; }
/// <summary>
///  sample aspect ratio (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public Rational pixel_aspect { get; set; }
/// <summary>
///  (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public Rational time_base { get; set; }
/// <summary>
///  (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public Rational frame_rate { get; set; }
/// <summary>
/// 
/// </summary>
public string sws_param { get; set; }
}
}
