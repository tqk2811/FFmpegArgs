namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. chorus            A-&gt;A       Add a chorus effect to the audio.
    /// </summary>
    public class ChorusFilterGen : AudioToAudioFilter
    {
        internal ChorusFilterGen(AudioMap input) : base("chorus", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set input gain (from 0 to 1) (default 0.4)
        /// </summary>
        public ChorusFilterGen in_gain(float in_gain) => this.SetOptionRange("in_gain", in_gain, 0, 1);
        /// <summary>
        ///  set output gain (from 0 to 1) (default 0.4)
        /// </summary>
        public ChorusFilterGen out_gain(float out_gain) => this.SetOptionRange("out_gain", out_gain, 0, 1);
        /// <summary>
        ///  set delays
        /// </summary>
        public ChorusFilterGen delays(String delays) => this.SetOption("delays", delays.ToString());
        /// <summary>
        ///  set decays
        /// </summary>
        public ChorusFilterGen decays(String decays) => this.SetOption("decays", decays.ToString());
        /// <summary>
        ///  set speeds
        /// </summary>
        public ChorusFilterGen speeds(String speeds) => this.SetOption("speeds", speeds.ToString());
        /// <summary>
        ///  set depths
        /// </summary>
        public ChorusFilterGen depths(String depths) => this.SetOption("depths", depths.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Add a chorus effect to the audio.
        /// </summary>
        public static ChorusFilterGen ChorusFilterGen(this AudioMap input0) => new ChorusFilterGen(input0);
    }
}