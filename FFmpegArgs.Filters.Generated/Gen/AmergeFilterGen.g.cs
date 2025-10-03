namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... amerge            N-&gt;A       Merge two or more audio streams into a single multi-channel stream.
    /// </summary>
    public class AmergeFilterGen : AudioToAudioFilter
    {
        internal AmergeFilterGen(params AudioMap[] inputs) : base("amerge", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  specify the number of inputs (from 1 to 64) (default 2)
        /// </summary>
        public AmergeFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs, 1, 64);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Merge two or more audio streams into a single multi-channel stream.
        /// </summary>
        public static AmergeFilterGen AmergeFilterGen(this AudioMap input) => new AmergeFilterGen(input);
    }
}