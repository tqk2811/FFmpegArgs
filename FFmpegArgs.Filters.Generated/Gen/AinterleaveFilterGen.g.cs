namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... ainterleave       N-&gt;A       Temporally interleave audio inputs.
    /// </summary>
    public class AinterleaveFilterGen : AudioToAudioFilter
    {
        internal AinterleaveFilterGen(params AudioMap[] inputs) : base("ainterleave", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set number of inputs (from 1 to INT_MAX) (default 2)
        /// </summary>
        public AinterleaveFilterGen nb_inputs(int nb_inputs) => this.SetOptionRange("nb_inputs", nb_inputs, 1, INT_MAX);
        /// <summary>
        ///  how to determine the end-of-stream (from 0 to 2) (default longest)
        /// </summary>
        public AinterleaveFilterGen duration(AinterleaveFilterGenDuration duration) => this.SetOption("duration", duration.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  how to determine the end-of-stream (from 0 to 2) (default longest)
    /// </summary>
    public enum AinterleaveFilterGenDuration
    {
        /// <summary>
        /// longest         0            ..F.A...... Duration of longest input
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("longest")]
        longest = 0,
        /// <summary>
        /// shortest        1            ..F.A...... Duration of shortest input
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("shortest")]
        shortest = 1,
        /// <summary>
        /// first           2            ..F.A...... Duration of first input
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("first")]
        first = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Temporally interleave audio inputs.
        /// </summary>
        public static AinterleaveFilterGen AinterleaveFilterGen(this AudioMap input) => new AinterleaveFilterGen(input);
    }
}