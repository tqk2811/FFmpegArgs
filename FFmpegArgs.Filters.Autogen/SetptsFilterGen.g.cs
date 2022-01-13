namespace FFmpegArgs.Filters.Autogens
{
public class SetptsFilterGen : ImageToImageFilter
{
internal SetptsFilterGen(ImageMap input) : base("setpts",input) { AddMapOut(); }
/// <summary>
///  Expression determining the frame timestamp (default "PTS")
/// </summary>
public SetptsFilterGen expr(string expr) => this.SetOption("expr",expr);
}
public static class SetptsFilterGenExtensions
{
/// <summary>
/// Set PTS for the output video frame.
/// </summary>
public static SetptsFilterGen SetptsFilterGen(this ImageMap input0) => new SetptsFilterGen(input0);
/// <summary>
/// Set PTS for the output video frame.
/// </summary>
public static SetptsFilterGen SetptsFilterGen(this ImageMap input0,SetptsFilterGenConfig config)
{
var result = new SetptsFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.expr)) result.expr(config.expr);
return result;
}
}
public class SetptsFilterGenConfig
{
/// <summary>
///  Expression determining the frame timestamp (default "PTS")
/// </summary>
public string expr { get; set; }
}
}
