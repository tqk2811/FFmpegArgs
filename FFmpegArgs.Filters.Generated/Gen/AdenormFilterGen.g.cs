namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC adenorm           A-&gt;A       Remedy denormals by adding extremely low-level noise.
/// </summary>
public class AdenormFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AdenormFilterGen(AudioMap input) : base("adenorm",input) { AddMapOut(); }
/// <summary>
///  set level (from -451 to -90) (default -351)
/// </summary>
public AdenormFilterGen level(double level) => this.SetOptionRange("level", level,-451,-90);
/// <summary>
///  set type (from 0 to 3) (default dc)
/// </summary>
public AdenormFilterGen type(AdenormFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Remedy denormals by adding extremely low-level noise.
/// </summary>
public static AdenormFilterGen AdenormFilterGen(this AudioMap input0) => new AdenormFilterGen(input0);
}
/// <summary>
///  set type (from 0 to 3) (default dc)
/// </summary>
public enum AdenormFilterGenType
{
/// <summary>
/// dc              0            ..F.A....T.
/// </summary>
[Name("dc")] dc,
/// <summary>
/// ac              1            ..F.A....T.
/// </summary>
[Name("ac")] ac,
/// <summary>
/// square          2            ..F.A....T.
/// </summary>
[Name("square")] square,
/// <summary>
/// pulse           3            ..F.A....T.
/// </summary>
[Name("pulse")] pulse,
}

}
