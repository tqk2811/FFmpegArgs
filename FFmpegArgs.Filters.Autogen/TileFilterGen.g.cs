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
public class TileFilterGen : ImageToImageFilter
{
internal TileFilterGen(ImageMap input) : base("tile",input) { AddMapOut(); }
/// <summary>
///  set grid size (default "6x5")
/// </summary>
public TileFilterGen layout(Size size) => this.SetOption("layout",$"{size.Width}x{size.Height}");
/// <summary>
///  set maximum number of frame to render (from 0 to INT_MAX) (default 0)
/// </summary>
public TileFilterGen nb_frames(int nb_frames) => this.SetOptionRange("nb_frames", nb_frames,0,INT_MAX);
/// <summary>
///  set outer border margin in pixels (from 0 to 1024) (default 0)
/// </summary>
public TileFilterGen margin(int margin) => this.SetOptionRange("margin", margin,0,1024);
/// <summary>
///  set inner border thickness in pixels (from 0 to 1024) (default 0)
/// </summary>
public TileFilterGen padding(int padding) => this.SetOptionRange("padding", padding,0,1024);
/// <summary>
///  set the color of the unused area (default "black")
/// </summary>
public TileFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
/// <summary>
///  set how many frames to overlap for each render (from 0 to INT_MAX) (default 0)
/// </summary>
public TileFilterGen overlap(int overlap) => this.SetOptionRange("overlap", overlap,0,INT_MAX);
/// <summary>
///  set how many frames to initially pad (from 0 to INT_MAX) (default 0)
/// </summary>
public TileFilterGen init_padding(int init_padding) => this.SetOptionRange("init_padding", init_padding,0,INT_MAX);
}
public static class TileFilterGenExtensions
{
/// <summary>
/// Tile several successive frames together.
/// </summary>
public static TileFilterGen TileFilterGen(this ImageMap input) => new TileFilterGen(input);
}
}
