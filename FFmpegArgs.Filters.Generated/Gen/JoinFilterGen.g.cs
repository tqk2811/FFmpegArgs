namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... join              N->A       Join multiple audio streams into multi-channel output.
/// </summary>
public class JoinFilterGen : AudioToAudioFilter
{
internal JoinFilterGen(params AudioMap[] inputs) : base("join",inputs) { AddMapOut(); }
/// <summary>
///  Number of input streams. (from 1 to INT_MAX) (default 2)
/// </summary>
public JoinFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs,1,INT_MAX);
/// <summary>
///  Channel layout of the output stream. (default "stereo")
/// </summary>
public JoinFilterGen channel_layout(string channel_layout) => this.SetOption("channel_layout",channel_layout);
/// <summary>
///  A comma-separated list of channels maps in the format 'input_stream.input_channel-output_channel.
/// </summary>
public JoinFilterGen map(string map) => this.SetOption("map",map);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Join multiple audio streams into multi-channel output.
/// </summary>
public static JoinFilterGen JoinFilterGen(this IEnumerable<AudioMap> inputs) => new JoinFilterGen(inputs.ToArray());
}
}
