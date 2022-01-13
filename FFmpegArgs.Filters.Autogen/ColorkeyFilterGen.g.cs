namespace FFmpegArgs.Filters.Autogens
{
public class ColorkeyFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ColorkeyFilterGen(ImageMap input) : base("colorkey",input) { AddMapOut(); }
/// <summary>
///  set the colorkey key color (default "black")
/// </summary>
public ColorkeyFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
/// <summary>
///  set the colorkey similarity value (from 0.01 to 1) (default 0.01)
/// </summary>
public ColorkeyFilterGen similarity(float similarity) => this.SetOptionRange("similarity", similarity,0.01,1);
/// <summary>
///  set the colorkey key blend value (from 0 to 1) (default 0)
/// </summary>
public ColorkeyFilterGen blend(float blend) => this.SetOptionRange("blend", blend,0,1);
}
public static class ColorkeyFilterGenExtensions
{
/// <summary>
/// Turns a certain color into transparency. Operates on RGB colors.
/// </summary>
public static ColorkeyFilterGen ColorkeyFilterGen(this ImageMap input0) => new ColorkeyFilterGen(input0);
/// <summary>
/// Turns a certain color into transparency. Operates on RGB colors.
/// </summary>
public static ColorkeyFilterGen ColorkeyFilterGen(this ImageMap input0,ColorkeyFilterGenConfig config)
{
var result = new ColorkeyFilterGen(input0);
if(config?.color != null) result.color(config.color.Value);
if(config?.similarity != null) result.similarity(config.similarity.Value);
if(config?.blend != null) result.blend(config.blend.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class ColorkeyFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set the colorkey key color (default "black")
/// </summary>
public Color? color { get; set; }
/// <summary>
///  set the colorkey similarity value (from 0.01 to 1) (default 0.01)
/// </summary>
public float? similarity { get; set; }
/// <summary>
///  set the colorkey key blend value (from 0 to 1) (default 0)
/// </summary>
public float? blend { get; set; }
public string TimelineSupport { get; set; }
}
}
