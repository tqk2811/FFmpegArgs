namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... fps               V->V       Force constant framerate.
/// </summary>
public class FpsFilterGen : ImageToImageFilter
{
internal FpsFilterGen(ImageMap input) : base("fps",input) { AddMapOut(); }
/// <summary>
///  A string describing desired output framerate (default "25")
/// </summary>
public FpsFilterGen fps(string fps) => this.SetOption("fps",fps);
/// <summary>
///  Assume the first PTS should be this value. (from -DBL_MAX to DBL_MAX) (default DBL_MAX)
/// </summary>
public FpsFilterGen start_time(double start_time) => this.SetOptionRange("start_time", start_time,-DBL_MAX,DBL_MAX);
/// <summary>
///  set rounding method for timestamps (from 0 to 5) (default near)
/// </summary>
public FpsFilterGen round(FpsFilterGenRound round) => this.SetOption("round", round.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  action performed for last frame (from 0 to 1) (default round)
/// </summary>
public FpsFilterGen eof_action(FpsFilterGenEof_action eof_action) => this.SetOption("eof_action", eof_action.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class FpsFilterGenExtensions
{
/// <summary>
/// Force constant framerate.
/// </summary>
public static FpsFilterGen FpsFilterGen(this ImageMap input0) => new FpsFilterGen(input0);
}
/// <summary>
///  set rounding method for timestamps (from 0 to 5) (default near)
/// </summary>
public enum FpsFilterGenRound
{
/// <summary>
/// zero            0            ..FV....... round towards 0
/// </summary>
[Name("zero")] zero,
/// <summary>
/// inf             1            ..FV....... round away from 0
/// </summary>
[Name("inf")] inf,
/// <summary>
/// down            2            ..FV....... round towards -infty
/// </summary>
[Name("down")] down,
/// <summary>
/// up              3            ..FV....... round towards +infty
/// </summary>
[Name("up")] up,
/// <summary>
/// near            5            ..FV....... round to nearest
/// </summary>
[Name("near")] near,
}

/// <summary>
///  action performed for last frame (from 0 to 1) (default round)
/// </summary>
public enum FpsFilterGenEof_action
{
/// <summary>
/// round           0            ..FV....... round similar to other frames
/// </summary>
[Name("round")] round,
/// <summary>
/// pass            1            ..FV....... pass through last frame
/// </summary>
[Name("pass")] pass,
}

}
