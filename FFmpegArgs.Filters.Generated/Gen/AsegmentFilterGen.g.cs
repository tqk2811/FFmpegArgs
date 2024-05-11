namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... asegment          A->N       Segment audio stream.
/// </summary>
public class AsegmentFilterGen : AudioToAudioFilter
{
internal AsegmentFilterGen(int outputCount, AudioMap input) : base("asegment",input) { AddMultiMapOut(outputCount); }
/// <summary>
///  timestamps of input at which to split input
/// </summary>
public AsegmentFilterGen timestamps(string timestamps) => this.SetOption("timestamps",timestamps);
/// <summary>
///  samples at which to split input
/// </summary>
public AsegmentFilterGen samples(string samples) => this.SetOption("samples",samples);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Segment audio stream.
/// </summary>
public static AsegmentFilterGen AsegmentFilterGen(this AudioMap input0, int outputCount) => new AsegmentFilterGen(outputCount, input0);
}
}
