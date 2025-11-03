namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. asegment          A-&gt;N       Segment audio stream.
    /// </summary>
    public class AsegmentFilterGen : AudioToAudioFilter
    {
        internal AsegmentFilterGen(AudioMap input, int outputCount) : base("asegment", input)
        {
            AddMultiMapOut(outputCount);
        }

        /// <summary>
        ///  timestamps of input at which to split input
        /// </summary>
        public AsegmentFilterGen timestamps(String timestamps) => this.SetOption("timestamps", timestamps.ToStringInv());
        /// <summary>
        ///  samples at which to split input
        /// </summary>
        public AsegmentFilterGen samples(String samples) => this.SetOption("samples", samples.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Segment audio stream.
        /// </summary>
        public static AsegmentFilterGen AsegmentFilterGen(this AudioMap input0, int outputCount) => new AsegmentFilterGen(input0, outputCount);
    }
}