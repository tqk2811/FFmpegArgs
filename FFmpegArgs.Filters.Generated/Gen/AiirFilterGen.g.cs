namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S. aiir              A-&gt;N       Apply Infinite Impulse Response filter with supplied coefficients.
    /// </summary>
    public class AiirFilterGen : AudioToAudioFilter, ISliceThreading
    {
        internal AiirFilterGen(AudioMap input, int outputCount) : base("aiir", input)
        {
            AddMultiMapOut(outputCount);
        }

        /// <summary>
        ///  set B/numerator/zeros/reflection coefficients (default &quot;1+0i 1-0i&quot;)
        /// </summary>
        public AiirFilterGen zeros(String zeros) => this.SetOption("zeros", zeros.ToString());
        /// <summary>
        ///  set A/denominator/poles/ladder coefficients (default &quot;1+0i 1-0i&quot;)
        /// </summary>
        public AiirFilterGen poles(String poles) => this.SetOption("poles", poles.ToString());
        /// <summary>
        ///  set channels gains (default &quot;1|1&quot;)
        /// </summary>
        public AiirFilterGen gains(String gains) => this.SetOption("gains", gains.ToString());
        /// <summary>
        ///  set channels gains (default &quot;1|1&quot;)
        /// </summary>
        public AiirFilterGen k(String k) => this.SetOption("k", k.ToString());
        /// <summary>
        ///  set dry gain (from 0 to 1) (default 1)
        /// </summary>
        public AiirFilterGen dry(double dry) => this.SetOptionRange("dry", dry, 0, 1);
        /// <summary>
        ///  set wet gain (from 0 to 1) (default 1)
        /// </summary>
        public AiirFilterGen wet(double wet) => this.SetOptionRange("wet", wet, 0, 1);
        /// <summary>
        ///  set coefficients format (from -2 to 4) (default zp)
        /// </summary>
        public AiirFilterGen format(AiirFilterGenFormat format) => this.SetOption("format", format.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set kind of processing (from 0 to 2) (default s)
        /// </summary>
        public AiirFilterGen process(AiirFilterGenProcess process) => this.SetOption("process", process.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set kind of processing (from 0 to 2) (default s)
        /// </summary>
        public AiirFilterGen r(AiirFilterGenR r) => this.SetOption("r", r.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set filtering precision (from 0 to 3) (default dbl)
        /// </summary>
        public AiirFilterGen precision(AiirFilterGenPrecision precision) => this.SetOption("precision", precision.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set precision (from 0 to 3) (default dbl)
        /// </summary>
        public AiirFilterGen e(AiirFilterGenE e) => this.SetOption("e", e.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  normalize coefficients (default true)
        /// </summary>
        public AiirFilterGen normalize(bool normalize) => this.SetOption("normalize", normalize.ToFFmpegFlag());
        /// <summary>
        ///  set mix (from 0 to 1) (default 1)
        /// </summary>
        public AiirFilterGen mix(double mix) => this.SetOptionRange("mix", mix, 0, 1);
        /// <summary>
        ///  show IR frequency response (default false)
        /// </summary>
        public AiirFilterGen response(bool response) => this.SetOption("response", response.ToFFmpegFlag());
        /// <summary>
        ///  set IR channel to display frequency response (from 0 to 1024) (default 0)
        /// </summary>
        public AiirFilterGen channel(int channel) => this.SetOptionRange("channel", channel, 0, 1024);
        /// <summary>
        ///  set video size (default &quot;hd720&quot;)
        /// </summary>
        public AiirFilterGen size(Size size) => this.SetOption("size", Inv($"{size.Width}x{size.Height}"));
        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public AiirFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToString());
    }

    /// <summary>
    ///  set coefficients format (from -2 to 4) (default zp)
    /// </summary>
    public enum AiirFilterGenFormat
    {
        /// <summary>
        /// ll              -2           ..F.A...... lattice-ladder function
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ll")]
        ll = -2,
        /// <summary>
        /// sf              -1           ..F.A...... analog transfer function
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sf")]
        sf = -1,
        /// <summary>
        /// tf              0            ..F.A...... digital transfer function
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tf")]
        tf = 0,
        /// <summary>
        /// zp              1            ..F.A...... Z-plane zeros/poles
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("zp")]
        zp = 1,
        /// <summary>
        /// pr              2            ..F.A...... Z-plane zeros/poles (polar radians)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pr")]
        pr = 2,
        /// <summary>
        /// pd              3            ..F.A...... Z-plane zeros/poles (polar degrees)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pd")]
        pd = 3,
        /// <summary>
        /// sp              4            ..F.A...... S-plane zeros/poles
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sp")]
        sp = 4
    }

    /// <summary>
    ///  set kind of processing (from 0 to 2) (default s)
    /// </summary>
    public enum AiirFilterGenProcess
    {
        /// <summary>
        /// d               0            ..F.A...... direct
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("d")]
        d = 0,
        /// <summary>
        /// s               1            ..F.A...... serial
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s")]
        s = 1,
        /// <summary>
        /// p               2            ..F.A...... parallel
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("p")]
        p = 2
    }

    /// <summary>
    ///  set kind of processing (from 0 to 2) (default s)
    /// </summary>
    public enum AiirFilterGenR
    {
        /// <summary>
        /// d               0            ..F.A...... direct
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("d")]
        d = 0,
        /// <summary>
        /// s               1            ..F.A...... serial
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s")]
        s = 1,
        /// <summary>
        /// p               2            ..F.A...... parallel
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("p")]
        p = 2
    }

    /// <summary>
    ///  set filtering precision (from 0 to 3) (default dbl)
    /// </summary>
    public enum AiirFilterGenPrecision
    {
        /// <summary>
        /// dbl             0            ..F.A...... double-precision floating-point
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dbl")]
        dbl = 0,
        /// <summary>
        /// flt             1            ..F.A...... single-precision floating-point
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("flt")]
        flt = 1,
        /// <summary>
        /// i32             2            ..F.A...... 32-bit integers
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("i32")]
        i32 = 2,
        /// <summary>
        /// i16             3            ..F.A...... 16-bit integers
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("i16")]
        i16 = 3
    }

    /// <summary>
    ///  set precision (from 0 to 3) (default dbl)
    /// </summary>
    public enum AiirFilterGenE
    {
        /// <summary>
        /// dbl             0            ..F.A...... double-precision floating-point
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dbl")]
        dbl = 0,
        /// <summary>
        /// flt             1            ..F.A...... single-precision floating-point
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("flt")]
        flt = 1,
        /// <summary>
        /// i32             2            ..F.A...... 32-bit integers
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("i32")]
        i32 = 2,
        /// <summary>
        /// i16             3            ..F.A...... 16-bit integers
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("i16")]
        i16 = 3
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply Infinite Impulse Response filter with supplied coefficients.
        /// </summary>
        public static AiirFilterGen AiirFilterGen(this AudioMap input0, int outputCount) => new AiirFilterGen(input0, outputCount);
    }
}