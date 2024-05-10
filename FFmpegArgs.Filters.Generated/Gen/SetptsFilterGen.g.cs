namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ..C setpts            V->V       Set PTS for the output video frame.
/// </summary>
public class SetptsFilterGen : ImageToImageFilter,ICommandSupport
{
internal SetptsFilterGen(ImageMap input) : base("setpts",input) { AddMapOut(); }
/// <summary>
///  Expression determining the frame timestamp (default "PTS")
/// </summary>
public SetptsFilterGen expr(ExpressionValue expr) => this.SetOption("expr",(string)expr);
}
/// <summary>
/// </summary>
public static class SetptsFilterGenExtensions
{
/// <summary>
/// Set PTS for the output video frame.
/// </summary>
public static SetptsFilterGen SetptsFilterGen(this ImageMap input0) => new SetptsFilterGen(input0);
}
}
