namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.C afade             A-&gt;A       Fade in/out input audio.
    /// </summary>
    public class AfadeFilterGen : AudioToAudioFilter, ITimelineSupport, ICommandSupport
    {
        internal AfadeFilterGen(AudioMap input) : base("afade", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the fade direction (from 0 to 1) (default in)
        /// </summary>
        public AfadeFilterGen type(AfadeFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set number of first sample to start fading (from 0 to I64_MAX) (default 0)
        /// </summary>
        public AfadeFilterGen start_sample(long start_sample) => this.SetOptionRange("start_sample", start_sample, 0, I64_MAX);
        /// <summary>
        ///  set number of first sample to start fading (from 0 to I64_MAX) (default 0)
        /// </summary>
        public AfadeFilterGen ss(long ss) => this.SetOptionRange("ss", ss, 0, I64_MAX);
        /// <summary>
        ///  set number of samples for fade duration (from 1 to I64_MAX) (default 44100)
        /// </summary>
        public AfadeFilterGen nb_samples(long nb_samples) => this.SetOptionRange("nb_samples", nb_samples, 1, I64_MAX);
        /// <summary>
        ///  set number of samples for fade duration (from 1 to I64_MAX) (default 44100)
        /// </summary>
        public AfadeFilterGen ns(long ns) => this.SetOptionRange("ns", ns, 1, I64_MAX);
        /// <summary>
        ///  set time to start fading (default 0)
        /// </summary>
        public AfadeFilterGen start_time(TimeSpan start_time) => this.SetOptionRange("start_time", start_time, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set fade duration (default 0)
        /// </summary>
        public AfadeFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set fade curve type (from -1 to 22) (default tri)
        /// </summary>
        public AfadeFilterGen curve(AfadeFilterGenCurve curve) => this.SetOption("curve", curve.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the silence gain (from 0 to 1) (default 0)
        /// </summary>
        public AfadeFilterGen silence(double silence) => this.SetOptionRange("silence", silence, 0, 1);
        /// <summary>
        ///  set the unity gain (from 0 to 1) (default 1)
        /// </summary>
        public AfadeFilterGen unity(double unity) => this.SetOptionRange("unity", unity, 0, 1);
    }

    /// <summary>
    ///  set the fade direction (from 0 to 1) (default in)
    /// </summary>
    public enum AfadeFilterGenType
    {
        /// <summary>
        /// in              0            ..F.A....T. fade-in
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("in")]
        _in = 0,
        /// <summary>
        /// out             1            ..F.A....T. fade-out
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("out")]
        _out = 1
    }

    /// <summary>
    ///  set fade curve type (from -1 to 22) (default tri)
    /// </summary>
    public enum AfadeFilterGenCurve
    {
        /// <summary>
        /// nofade          -1           ..F.A....T. no fade; keep audio as-is
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nofade")]
        nofade = -1,
        /// <summary>
        /// tri             0            ..F.A....T. linear slope
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tri")]
        tri = 0,
        /// <summary>
        /// qsin            1            ..F.A....T. quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qsin")]
        qsin = 1,
        /// <summary>
        /// esin            2            ..F.A....T. exponential sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("esin")]
        esin = 2,
        /// <summary>
        /// hsin            3            ..F.A....T. half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hsin")]
        hsin = 3,
        /// <summary>
        /// log             4            ..F.A....T. logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 4,
        /// <summary>
        /// ipar            5            ..F.A....T. inverted parabola
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ipar")]
        ipar = 5,
        /// <summary>
        /// qua             6            ..F.A....T. quadratic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qua")]
        qua = 6,
        /// <summary>
        /// cub             7            ..F.A....T. cubic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cub")]
        cub = 7,
        /// <summary>
        /// squ             8            ..F.A....T. square root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("squ")]
        squ = 8,
        /// <summary>
        /// cbr             9            ..F.A....T. cubic root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cbr")]
        cbr = 9,
        /// <summary>
        /// par             10           ..F.A....T. parabola
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("par")]
        par = 10,
        /// <summary>
        /// exp             11           ..F.A....T. exponential
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("exp")]
        exp = 11,
        /// <summary>
        /// iqsin           12           ..F.A....T. inverted quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iqsin")]
        iqsin = 12,
        /// <summary>
        /// ihsin           13           ..F.A....T. inverted half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ihsin")]
        ihsin = 13,
        /// <summary>
        /// dese            14           ..F.A....T. double-exponential seat
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dese")]
        dese = 14,
        /// <summary>
        /// desi            15           ..F.A....T. double-exponential sigmoid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("desi")]
        desi = 15,
        /// <summary>
        /// losi            16           ..F.A....T. logistic sigmoid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("losi")]
        losi = 16,
        /// <summary>
        /// sinc            17           ..F.A....T. sine cardinal function
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sinc")]
        sinc = 17,
        /// <summary>
        /// isinc           18           ..F.A....T. inverted sine cardinal function
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("isinc")]
        isinc = 18,
        /// <summary>
        /// quat            19           ..F.A....T. quartic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quat")]
        quat = 19,
        /// <summary>
        /// quatr           20           ..F.A....T. quartic root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quatr")]
        quatr = 20,
        /// <summary>
        /// qsin2           21           ..F.A....T. squared quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qsin2")]
        qsin2 = 21,
        /// <summary>
        /// hsin2           22           ..F.A....T. squared half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hsin2")]
        hsin2 = 22
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Fade in/out input audio.
        /// </summary>
        public static AfadeFilterGen AfadeFilterGen(this AudioMap input0) => new AfadeFilterGen(input0);
    }
}