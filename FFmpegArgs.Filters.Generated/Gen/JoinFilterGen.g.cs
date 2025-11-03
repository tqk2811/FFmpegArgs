namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. join              N-&gt;A       Join multiple audio streams into multi-channel output.
    /// </summary>
    public class JoinFilterGen : AudioToAudioFilter
    {
        internal JoinFilterGen(params AudioMap[] inputs) : base("join", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Number of input streams. (from 1 to INT_MAX) (default 2)
        /// </summary>
        public JoinFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs, 1, INT_MAX);
        /// <summary>
        ///  Channel layout of the output stream. (default &quot;stereo&quot;)
        /// </summary>
        public JoinFilterGen channel_layout(ChannelLayout channel_layout) => this.SetOption("channel_layout", channel_layout.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  A comma-separated list of channels maps in the format &#39;input_stream.input_channel-output_channel.
        /// </summary>
        public JoinFilterGen map(String map) => this.SetOption("map", map.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Join multiple audio streams into multi-channel output.
        /// </summary>
        public static JoinFilterGen JoinFilterGen(this AudioMap input) => new JoinFilterGen(input);
    }
}