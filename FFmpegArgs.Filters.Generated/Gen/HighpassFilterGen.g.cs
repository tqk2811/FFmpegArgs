namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS highpass          A-&gt;A       Apply a high-pass filter with 3dB point frequency.
    /// </summary>
    public class HighpassFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal HighpassFilterGen(AudioMap input) : base("highpass", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set frequency (from 0 to 999999) (default 3000)
        /// </summary>
        public HighpassFilterGen frequency(double frequency) => this.SetOptionRange("frequency", frequency, 0, 999999);
        /// <summary>
        ///  set filter-width type (from 1 to 5) (default q)
        /// </summary>
        public HighpassFilterGen width_type(HighpassFilterGenWidth_type width_type) => this.SetOption("width_type", width_type.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set filter-width type (from 1 to 5) (default q)
        /// </summary>
        public HighpassFilterGen t(HighpassFilterGenT t) => this.SetOption("t", t.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set width (from 0 to 99999) (default 0.707)
        /// </summary>
        public HighpassFilterGen width(double width) => this.SetOptionRange("width", width, 0, 99999);
        /// <summary>
        ///  set number of poles (from 1 to 2) (default 2)
        /// </summary>
        public HighpassFilterGen poles(int poles) => this.SetOptionRange("poles", poles, 1, 2);
        /// <summary>
        ///  set mix (from 0 to 1) (default 1)
        /// </summary>
        public HighpassFilterGen mix(double mix) => this.SetOptionRange("mix", mix, 0, 1);
        /// <summary>
        ///  set channels to filter (default &quot;all&quot;)
        /// </summary>
        public HighpassFilterGen channels(String channels) => this.SetOption("channels", channels.ToString());
        /// <summary>
        ///  normalize coefficients (default false)
        /// </summary>
        public HighpassFilterGen normalize(bool normalize) => this.SetOption("normalize", normalize.ToFFmpegFlag());
        /// <summary>
        ///  set transform type (from 0 to 6) (default di)
        /// </summary>
        public HighpassFilterGen transform(HighpassFilterGenTransform transform) => this.SetOption("transform", transform.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set transform type (from 0 to 6) (default di)
        /// </summary>
        public HighpassFilterGen a(HighpassFilterGenA a) => this.SetOption("a", a.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set filtering precision (from -1 to 3) (default auto)
        /// </summary>
        public HighpassFilterGen precision(HighpassFilterGenPrecision precision) => this.SetOption("precision", precision.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set filtering precision (from -1 to 3) (default auto)
        /// </summary>
        public HighpassFilterGen r(HighpassFilterGenR r) => this.SetOption("r", r.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the block size (from 0 to 32768) (default 0)
        /// </summary>
        public HighpassFilterGen blocksize(int blocksize) => this.SetOptionRange("blocksize", blocksize, 0, 32768);
    }

    /// <summary>
    ///  set filter-width type (from 1 to 5) (default q)
    /// </summary>
    public enum HighpassFilterGenWidth_type
    {
        /// <summary>
        /// h               1            ..F.A....T. Hz
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("h")]
        h = 1,
        /// <summary>
        /// q               3            ..F.A....T. Q-Factor
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("q")]
        q = 3,
        /// <summary>
        /// o               2            ..F.A....T. octave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("o")]
        o = 2,
        /// <summary>
        /// s               4            ..F.A....T. slope
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s")]
        s = 4,
        /// <summary>
        /// k               5            ..F.A....T. kHz
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("k")]
        k = 5
    }

    /// <summary>
    ///  set filter-width type (from 1 to 5) (default q)
    /// </summary>
    public enum HighpassFilterGenT
    {
        /// <summary>
        /// h               1            ..F.A....T. Hz
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("h")]
        h = 1,
        /// <summary>
        /// q               3            ..F.A....T. Q-Factor
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("q")]
        q = 3,
        /// <summary>
        /// o               2            ..F.A....T. octave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("o")]
        o = 2,
        /// <summary>
        /// s               4            ..F.A....T. slope
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s")]
        s = 4,
        /// <summary>
        /// k               5            ..F.A....T. kHz
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("k")]
        k = 5
    }

    /// <summary>
    ///  set transform type (from 0 to 6) (default di)
    /// </summary>
    public enum HighpassFilterGenTransform
    {
        /// <summary>
        /// di              0            ..F.A...... direct form I
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("di")]
        di = 0,
        /// <summary>
        /// dii             1            ..F.A...... direct form II
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dii")]
        dii = 1,
        /// <summary>
        /// tdi             2            ..F.A...... transposed direct form I
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tdi")]
        tdi = 2,
        /// <summary>
        /// tdii            3            ..F.A...... transposed direct form II
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tdii")]
        tdii = 3,
        /// <summary>
        /// latt            4            ..F.A...... lattice-ladder form
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("latt")]
        latt = 4,
        /// <summary>
        /// svf             5            ..F.A...... state variable filter form
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("svf")]
        svf = 5,
        /// <summary>
        /// zdf             6            ..F.A...... zero-delay filter form
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("zdf")]
        zdf = 6
    }

    /// <summary>
    ///  set transform type (from 0 to 6) (default di)
    /// </summary>
    public enum HighpassFilterGenA
    {
        /// <summary>
        /// di              0            ..F.A...... direct form I
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("di")]
        di = 0,
        /// <summary>
        /// dii             1            ..F.A...... direct form II
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dii")]
        dii = 1,
        /// <summary>
        /// tdi             2            ..F.A...... transposed direct form I
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tdi")]
        tdi = 2,
        /// <summary>
        /// tdii            3            ..F.A...... transposed direct form II
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tdii")]
        tdii = 3,
        /// <summary>
        /// latt            4            ..F.A...... lattice-ladder form
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("latt")]
        latt = 4,
        /// <summary>
        /// svf             5            ..F.A...... state variable filter form
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("svf")]
        svf = 5,
        /// <summary>
        /// zdf             6            ..F.A...... zero-delay filter form
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("zdf")]
        zdf = 6
    }

    /// <summary>
    ///  set filtering precision (from -1 to 3) (default auto)
    /// </summary>
    public enum HighpassFilterGenPrecision
    {
        /// <summary>
        /// auto            -1           ..F.A...... automatic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
        /// <summary>
        /// s16             0            ..F.A...... signed 16-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s16")]
        s16 = 0,
        /// <summary>
        /// s32             1            ..F.A...... signed 32-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s32")]
        s32 = 1,
        /// <summary>
        /// f32             2            ..F.A...... floating-point single
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("f32")]
        f32 = 2,
        /// <summary>
        /// f64             3            ..F.A...... floating-point double
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("f64")]
        f64 = 3
    }

    /// <summary>
    ///  set filtering precision (from -1 to 3) (default auto)
    /// </summary>
    public enum HighpassFilterGenR
    {
        /// <summary>
        /// auto            -1           ..F.A...... automatic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
        /// <summary>
        /// s16             0            ..F.A...... signed 16-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s16")]
        s16 = 0,
        /// <summary>
        /// s32             1            ..F.A...... signed 32-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s32")]
        s32 = 1,
        /// <summary>
        /// f32             2            ..F.A...... floating-point single
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("f32")]
        f32 = 2,
        /// <summary>
        /// f64             3            ..F.A...... floating-point double
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("f64")]
        f64 = 3
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply a high-pass filter with 3dB point frequency.
        /// </summary>
        public static HighpassFilterGen HighpassFilterGen(this AudioMap input0) => new HighpassFilterGen(input0);
    }
}