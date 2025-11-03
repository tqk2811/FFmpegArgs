namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S acrossover        A-&gt;N       Split audio into per-bands streams.
    /// </summary>
    public class AcrossoverFilterGen : AudioToAudioFilter, ISliceThreading
    {
        internal AcrossoverFilterGen(AudioMap input, int outputCount) : base("acrossover", input)
        {
            AddMultiMapOut(outputCount);
        }

        /// <summary>
        ///  set split frequencies (default &quot;500&quot;)
        /// </summary>
        public AcrossoverFilterGen split(String split) => this.SetOption("split", split.ToStringInv());
        /// <summary>
        ///  set filter order (from 0 to 9) (default 4th)
        /// </summary>
        public AcrossoverFilterGen order(AcrossoverFilterGenOrder order) => this.SetOption("order", order.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input gain (from 0 to 1) (default 1)
        /// </summary>
        public AcrossoverFilterGen level(float level) => this.SetOptionRange("level", level, 0, 1);
        /// <summary>
        ///  set output bands gain (default &quot;1.f&quot;)
        /// </summary>
        public AcrossoverFilterGen gain(String gain) => this.SetOption("gain", gain.ToStringInv());
        /// <summary>
        ///  set processing precision (from 0 to 2) (default auto)
        /// </summary>
        public AcrossoverFilterGen precision(AcrossoverFilterGenPrecision precision) => this.SetOption("precision", precision.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set filter order (from 0 to 9) (default 4th)
    /// </summary>
    public enum AcrossoverFilterGenOrder
    {
        /// <summary>
        /// 2nd             0            ..F.A...... 2nd order (12 dB/8ve)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2nd")]
        _2nd = 0,
        /// <summary>
        /// 4th             1            ..F.A...... 4th order (24 dB/8ve)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("4th")]
        _4th = 1,
        /// <summary>
        /// 6th             2            ..F.A...... 6th order (36 dB/8ve)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("6th")]
        _6th = 2,
        /// <summary>
        /// 8th             3            ..F.A...... 8th order (48 dB/8ve)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("8th")]
        _8th = 3,
        /// <summary>
        /// 10th            4            ..F.A...... 10th order (60 dB/8ve)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("10th")]
        _10th = 4,
        /// <summary>
        /// 12th            5            ..F.A...... 12th order (72 dB/8ve)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("12th")]
        _12th = 5,
        /// <summary>
        /// 14th            6            ..F.A...... 14th order (84 dB/8ve)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("14th")]
        _14th = 6,
        /// <summary>
        /// 16th            7            ..F.A...... 16th order (96 dB/8ve)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("16th")]
        _16th = 7,
        /// <summary>
        /// 18th            8            ..F.A...... 18th order (108 dB/8ve)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("18th")]
        _18th = 8,
        /// <summary>
        /// 20th            9            ..F.A...... 20th order (120 dB/8ve)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("20th")]
        _20th = 9
    }

    /// <summary>
    ///  set processing precision (from 0 to 2) (default auto)
    /// </summary>
    public enum AcrossoverFilterGenPrecision
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
        /// Split audio into per-bands streams.
        /// </summary>
        public static AcrossoverFilterGen AcrossoverFilterGen(this AudioMap input0, int outputCount) => new AcrossoverFilterGen(input0, outputCount);
    }
}