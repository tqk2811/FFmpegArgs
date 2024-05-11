namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC xmedian           N->V       Pick median pixels from several video inputs.
/// </summary>
public class XmedianFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal XmedianFilterGen(params ImageMap[] inputs) : base("xmedian",inputs) { AddMapOut(); }
/// <summary>
///  set number of inputs (from 3 to 255) (default 3)
/// </summary>
public XmedianFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs,3,255);
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public XmedianFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set percentile (from 0 to 1) (default 0.5)
/// </summary>
public XmedianFilterGen percentile(float percentile) => this.SetOptionRange("percentile", percentile,0,1);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Pick median pixels from several video inputs.
/// </summary>
public static XmedianFilterGen XmedianFilterGen(this IEnumerable<ImageMap> inputs) => new XmedianFilterGen(inputs.ToArray());
}
}
