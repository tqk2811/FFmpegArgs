namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.C adelay            A-&gt;A       Delay one or more audio channels.
    /// </summary>
    public class AdelayFilterGen : AudioToAudioFilter, ITimelineSupport, ICommandSupport
    {
        internal AdelayFilterGen(AudioMap input) : base("adelay", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set list of delays for each channel
        /// </summary>
        public AdelayFilterGen delays(String delays) => this.SetOption("delays", delays.ToString());
        /// <summary>
        ///  use last available delay for remained channels (default false)
        /// </summary>
        public AdelayFilterGen all(bool all) => this.SetOption("all", all.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Delay one or more audio channels.
        /// </summary>
        public static AdelayFilterGen AdelayFilterGen(this AudioMap input0) => new AdelayFilterGen(input0);
    }
}