namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. deesser           A-&gt;A       Apply de-essing to the audio.
    /// </summary>
    public class DeesserFilterGen : AudioToAudioFilter, ITimelineSupport
    {
        internal DeesserFilterGen(AudioMap input) : base("deesser", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set intensity (from 0 to 1) (default 0)
        /// </summary>
        public DeesserFilterGen i(double i) => this.SetOptionRange("i", i, 0, 1);
        /// <summary>
        ///  set max deessing (from 0 to 1) (default 0.5)
        /// </summary>
        public DeesserFilterGen m(double m) => this.SetOptionRange("m", m, 0, 1);
        /// <summary>
        ///  set frequency (from 0 to 1) (default 0.5)
        /// </summary>
        public DeesserFilterGen f(double f) => this.SetOptionRange("f", f, 0, 1);
        /// <summary>
        ///  set output mode (from 0 to 2) (default o)
        /// </summary>
        public DeesserFilterGen s(DeesserFilterGenS s) => this.SetOption("s", s.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set output mode (from 0 to 2) (default o)
    /// </summary>
    public enum DeesserFilterGenS
    {
        /// <summary>
        /// i               0            ..F.A...... input
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("i")]
        i = 0,
        /// <summary>
        /// o               1            ..F.A...... output
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("o")]
        o = 1,
        /// <summary>
        /// e               2            ..F.A...... ess
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("e")]
        e = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply de-essing to the audio.
        /// </summary>
        public static DeesserFilterGen DeesserFilterGen(this AudioMap input0) => new DeesserFilterGen(input0);
    }
}