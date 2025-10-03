namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.C phase             V-&gt;V       Phase shift fields.
    /// </summary>
    public class PhaseFilterGen : ImageToImageFilter, ITimelineSupport, ICommandSupport
    {
        internal PhaseFilterGen(ImageMap input) : base("phase", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set phase mode (from 0 to 8) (default A)
        /// </summary>
        public PhaseFilterGen mode(PhaseFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set phase mode (from 0 to 8) (default A)
    /// </summary>
    public enum PhaseFilterGenMode
    {
        /// <summary>
        /// p               0            ..FV.....T. progressive
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("p")]
        p = 0,
        /// <summary>
        /// t               1            ..FV.....T. top first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("t")]
        t = 1,
        /// <summary>
        /// b               2            ..FV.....T. bottom first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("b")]
        b = 2,
        /// <summary>
        /// T               3            ..FV.....T. top first analyze
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("T")]
        T = 3,
        /// <summary>
        /// B               4            ..FV.....T. bottom first analyze
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("B")]
        B = 4,
        /// <summary>
        /// u               5            ..FV.....T. analyze
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("u")]
        u = 5,
        /// <summary>
        /// U               6            ..FV.....T. full analyze
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("U")]
        U = 6,
        /// <summary>
        /// a               7            ..FV.....T. auto
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("a")]
        a = 7,
        /// <summary>
        /// A               8            ..FV.....T. auto analyze
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("A")]
        A = 8
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Phase shift fields.
        /// </summary>
        public static PhaseFilterGen PhaseFilterGen(this ImageMap input0) => new PhaseFilterGen(input0);
    }
}