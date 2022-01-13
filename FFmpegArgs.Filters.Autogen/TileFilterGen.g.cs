namespace FFmpegArgs.Filters.Autogens
{
public class TileFilterGen : ImageToImageFilter
{
internal TileFilterGen(ImageMap input) : base("tile",input) { AddMapOut(); }
/// <summary>
///  set grid size (default "6x5")
/// </summary>
public TileFilterGen layout(Size layout) => this.SetOption("layout",$"{layout.Width}x{layout.Height}");
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
public static TileFilterGen TileFilterGen(this ImageMap input0) => new TileFilterGen(input0);
/// <summary>
/// Tile several successive frames together.
/// </summary>
public static TileFilterGen TileFilterGen(this ImageMap input0,TileFilterGenConfig config)
{
var result = new TileFilterGen(input0);
if(config?.layout != null) result.layout(config.layout.Value);
if(config?.nb_frames != null) result.nb_frames(config.nb_frames.Value);
if(config?.margin != null) result.margin(config.margin.Value);
if(config?.padding != null) result.padding(config.padding.Value);
if(config?.color != null) result.color(config.color.Value);
if(config?.overlap != null) result.overlap(config.overlap.Value);
if(config?.init_padding != null) result.init_padding(config.init_padding.Value);
return result;
}
}
public class TileFilterGenConfig
{
/// <summary>
///  set grid size (default "6x5")
/// </summary>
public Size? layout { get; set; }
/// <summary>
///  set maximum number of frame to render (from 0 to INT_MAX) (default 0)
/// </summary>
public int? nb_frames { get; set; }
/// <summary>
///  set outer border margin in pixels (from 0 to 1024) (default 0)
/// </summary>
public int? margin { get; set; }
/// <summary>
///  set inner border thickness in pixels (from 0 to 1024) (default 0)
/// </summary>
public int? padding { get; set; }
/// <summary>
///  set the color of the unused area (default "black")
/// </summary>
public Color? color { get; set; }
/// <summary>
///  set how many frames to overlap for each render (from 0 to INT_MAX) (default 0)
/// </summary>
public int? overlap { get; set; }
/// <summary>
///  set how many frames to initially pad (from 0 to INT_MAX) (default 0)
/// </summary>
public int? init_padding { get; set; }
}
}
