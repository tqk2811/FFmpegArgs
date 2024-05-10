namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C phase             V->V       Phase shift fields.
/// </summary>
public class PhaseFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal PhaseFilterGen(ImageMap input) : base("phase",input) { AddMapOut(); }
/// <summary>
///  set phase mode (from 0 to 8) (default A)
/// </summary>
public PhaseFilterGen mode(PhaseFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Phase shift fields.
/// </summary>
public static PhaseFilterGen PhaseFilterGen(this ImageMap input0) => new PhaseFilterGen(input0);
}
/// <summary>
///  set phase mode (from 0 to 8) (default A)
/// </summary>
public enum PhaseFilterGenMode
{
/// <summary>
/// p               0            ..FV.....T. progressive
/// </summary>
[Name("p")] p,
/// <summary>
/// t               1            ..FV.....T. top first
/// </summary>
[Name("t")] t,
/// <summary>
/// b               2            ..FV.....T. bottom first
/// </summary>
[Name("b")] b,
/// <summary>
/// T               3            ..FV.....T. top first analyze
/// </summary>
[Name("T")] T,
/// <summary>
/// B               4            ..FV.....T. bottom first analyze
/// </summary>
[Name("B")] B,
/// <summary>
/// u               5            ..FV.....T. analyze
/// </summary>
[Name("u")] u,
/// <summary>
/// U               6            ..FV.....T. full analyze
/// </summary>
[Name("U")] U,
/// <summary>
/// a               7            ..FV.....T. auto
/// </summary>
[Name("a")] a,
/// <summary>
/// A               8            ..FV.....T. auto analyze
/// </summary>
[Name("A")] A,
}

}
