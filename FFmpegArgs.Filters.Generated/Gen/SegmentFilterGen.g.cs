namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... segment           V-&gt;N       Segment video stream.
/// </summary>
public class SegmentFilterGen : ImageToImageFilter
{
internal SegmentFilterGen(int outputCount, ImageMap input) : base("segment",input) { AddMultiMapOut(outputCount); }
/// <summary>
///  timestamps of input at which to split input
/// </summary>
public SegmentFilterGen timestamps(string timestamps) => this.SetOption("timestamps",timestamps);
/// <summary>
///  frames at which to split input
/// </summary>
public SegmentFilterGen frames(string frames) => this.SetOption("frames",frames);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Segment video stream.
/// </summary>
public static SegmentFilterGen SegmentFilterGen(this ImageMap input0, int outputCount) => new SegmentFilterGen(outputCount, input0);
}
}
