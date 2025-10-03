namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC anlmdn            A-&gt;A       Reduce broadband noise from stream using Non-Local Means.
    /// </summary>
    public class AnlmdnFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AnlmdnFilterGen(AudioMap input) : base("anlmdn", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set denoising strength (from 1e-05 to 10000) (default 1e-05)
        /// </summary>
        public AnlmdnFilterGen strength(float strength) => this.SetOptionRange("strength", strength, 1e-05, 10000);
        /// <summary>
        ///  set patch duration (default 0.002)
        /// </summary>
        public AnlmdnFilterGen patch(TimeSpan patch) => this.SetOptionRange("patch", patch, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set research duration (default 0.006)
        /// </summary>
        public AnlmdnFilterGen research(TimeSpan research) => this.SetOptionRange("research", research, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set output mode (from 0 to 2) (default o)
        /// </summary>
        public AnlmdnFilterGen output(AnlmdnFilterGenOutput output) => this.SetOption("output", output.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set smooth factor (from 1 to 1000) (default 11)
        /// </summary>
        public AnlmdnFilterGen smooth(float smooth) => this.SetOptionRange("smooth", smooth, 1, 1000);
        /// <summary>
        ///  set smooth factor (from 1 to 1000) (default 11)
        /// </summary>
        public AnlmdnFilterGen m(float m) => this.SetOptionRange("m", m, 1, 1000);
    }

    /// <summary>
    ///  set output mode (from 0 to 2) (default o)
    /// </summary>
    public enum AnlmdnFilterGenOutput
    {
        /// <summary>
        /// i               0            ..F.A....T. input
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("i")]
        i = 0,
        /// <summary>
        /// o               1            ..F.A....T. output
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("o")]
        o = 1,
        /// <summary>
        /// n               2            ..F.A....T. noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("n")]
        n = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Reduce broadband noise from stream using Non-Local Means.
        /// </summary>
        public static AnlmdnFilterGen AnlmdnFilterGen(this AudioMap input0) => new AnlmdnFilterGen(input0);
    }
}