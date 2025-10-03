namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... interleave        N-&gt;V       Temporally interleave video inputs.
    /// </summary>
    public class InterleaveFilterGen : ImageToImageFilter
    {
        internal InterleaveFilterGen(params ImageMap[] inputs) : base("interleave", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set number of inputs (from 1 to INT_MAX) (default 2)
        /// </summary>
        public InterleaveFilterGen nb_inputs(int nb_inputs) => this.SetOptionRange("nb_inputs", nb_inputs, 1, INT_MAX);
        /// <summary>
        ///  how to determine the end-of-stream (from 0 to 2) (default longest)
        /// </summary>
        public InterleaveFilterGen duration(InterleaveFilterGenDuration duration) => this.SetOption("duration", duration.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  how to determine the end-of-stream (from 0 to 2) (default longest)
    /// </summary>
    public enum InterleaveFilterGenDuration
    {
        /// <summary>
        /// longest         0            ..FV....... Duration of longest input
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("longest")]
        longest = 0,
        /// <summary>
        /// shortest        1            ..FV....... Duration of shortest input
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("shortest")]
        shortest = 1,
        /// <summary>
        /// first           2            ..FV....... Duration of first input
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("first")]
        first = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Temporally interleave video inputs.
        /// </summary>
        public static InterleaveFilterGen InterleaveFilterGen(this ImageMap input) => new InterleaveFilterGen(input);
    }
}