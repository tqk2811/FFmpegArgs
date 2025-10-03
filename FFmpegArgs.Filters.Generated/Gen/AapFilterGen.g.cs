namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC aap               AA-&gt;A      Apply Affine Projection algorithm to first audio stream.
    /// </summary>
    public class AapFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AapFilterGen(params AudioMap[] inputs) : base("aap", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the filter order (from 1 to 32767) (default 16)
        /// </summary>
        public AapFilterGen order(int order) => this.SetOptionRange("order", order, 1, 32767);
        /// <summary>
        ///  set the filter projection (from 1 to 256) (default 2)
        /// </summary>
        public AapFilterGen projection(int projection) => this.SetOptionRange("projection", projection, 1, 256);
        /// <summary>
        ///  set the filter mu (from 0 to 1) (default 0.0001)
        /// </summary>
        public AapFilterGen mu(float mu) => this.SetOptionRange("mu", mu, 0, 1);
        /// <summary>
        ///  set the filter delta (from 0 to 1) (default 0.001)
        /// </summary>
        public AapFilterGen delta(float delta) => this.SetOptionRange("delta", delta, 0, 1);
        /// <summary>
        ///  set output mode (from 0 to 4) (default o)
        /// </summary>
        public AapFilterGen out_mode(AapFilterGenOut_mode out_mode) => this.SetOption("out_mode", out_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set processing precision (from 0 to 2) (default auto)
        /// </summary>
        public AapFilterGen precision(AapFilterGenPrecision precision) => this.SetOption("precision", precision.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set output mode (from 0 to 4) (default o)
    /// </summary>
    public enum AapFilterGenOut_mode
    {
        /// <summary>
        /// i               0            ..F.A....T. input
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("i")]
        i = 0,
        /// <summary>
        /// d               1            ..F.A....T. desired
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("d")]
        d = 1,
        /// <summary>
        /// o               2            ..F.A....T. output
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("o")]
        o = 2,
        /// <summary>
        /// n               3            ..F.A....T. noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("n")]
        n = 3,
        /// <summary>
        /// e               4            ..F.A....T. error
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("e")]
        e = 4
    }

    /// <summary>
    ///  set processing precision (from 0 to 2) (default auto)
    /// </summary>
    public enum AapFilterGenPrecision
    {
        /// <summary>
        /// auto            0            ..F.A...... set auto processing precision
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = 0,
        /// <summary>
        /// float           1            ..F.A...... set single-floating point processing precision
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("float")]
        _float = 1,
        /// <summary>
        /// double          2            ..F.A...... set double-floating point processing precision
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("double")]
        _double = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply Affine Projection algorithm to first audio stream.
        /// </summary>
        public static AapFilterGen AapFilterGen(this AudioMap input0, AudioMap input1) => new AapFilterGen(input0, input1);
    }
}