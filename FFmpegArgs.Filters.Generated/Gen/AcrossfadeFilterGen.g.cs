namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. acrossfade        AA-&gt;A      Cross fade two input audio streams.
    /// </summary>
    public class AcrossfadeFilterGen : AudioToAudioFilter
    {
        internal AcrossfadeFilterGen(params AudioMap[] inputs) : base("acrossfade", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set number of samples for cross fade duration (from 1 to 2.14748e+08) (default 44100)
        /// </summary>
        public AcrossfadeFilterGen nb_samples(long nb_samples) => this.SetOptionRange("nb_samples", nb_samples, 1, 2.14748e+08);
        /// <summary>
        ///  set number of samples for cross fade duration (from 1 to 2.14748e+08) (default 44100)
        /// </summary>
        public AcrossfadeFilterGen ns(long ns) => this.SetOptionRange("ns", ns, 1, 2.14748e+08);
        /// <summary>
        ///  set cross fade duration (default 0)
        /// </summary>
        public AcrossfadeFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  overlap 1st stream end with 2nd stream start (default true)
        /// </summary>
        public AcrossfadeFilterGen overlap(bool overlap) => this.SetOption("overlap", overlap.ToFFmpegFlag());
        /// <summary>
        ///  set fade curve type for 1st stream (from -1 to 22) (default tri)
        /// </summary>
        public AcrossfadeFilterGen curve1(AcrossfadeFilterGenCurve1 curve1) => this.SetOption("curve1", curve1.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set fade curve type for 1st stream (from -1 to 22) (default tri)
        /// </summary>
        public AcrossfadeFilterGen c1(AcrossfadeFilterGenC1 c1) => this.SetOption("c1", c1.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set fade curve type for 2nd stream (from -1 to 22) (default tri)
        /// </summary>
        public AcrossfadeFilterGen curve2(AcrossfadeFilterGenCurve2 curve2) => this.SetOption("curve2", curve2.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set fade curve type for 2nd stream (from -1 to 22) (default tri)
        /// </summary>
        public AcrossfadeFilterGen c2(AcrossfadeFilterGenC2 c2) => this.SetOption("c2", c2.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set fade curve type for 1st stream (from -1 to 22) (default tri)
    /// </summary>
    public enum AcrossfadeFilterGenCurve1
    {
        /// <summary>
        /// nofade          -1           ..F.A...... no fade; keep audio as-is
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nofade")]
        nofade = -1,
        /// <summary>
        /// tri             0            ..F.A...... linear slope
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tri")]
        tri = 0,
        /// <summary>
        /// qsin            1            ..F.A...... quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qsin")]
        qsin = 1,
        /// <summary>
        /// esin            2            ..F.A...... exponential sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("esin")]
        esin = 2,
        /// <summary>
        /// hsin            3            ..F.A...... half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hsin")]
        hsin = 3,
        /// <summary>
        /// log             4            ..F.A...... logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 4,
        /// <summary>
        /// ipar            5            ..F.A...... inverted parabola
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ipar")]
        ipar = 5,
        /// <summary>
        /// qua             6            ..F.A...... quadratic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qua")]
        qua = 6,
        /// <summary>
        /// cub             7            ..F.A...... cubic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cub")]
        cub = 7,
        /// <summary>
        /// squ             8            ..F.A...... square root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("squ")]
        squ = 8,
        /// <summary>
        /// cbr             9            ..F.A...... cubic root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cbr")]
        cbr = 9,
        /// <summary>
        /// par             10           ..F.A...... parabola
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("par")]
        par = 10,
        /// <summary>
        /// exp             11           ..F.A...... exponential
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("exp")]
        exp = 11,
        /// <summary>
        /// iqsin           12           ..F.A...... inverted quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iqsin")]
        iqsin = 12,
        /// <summary>
        /// ihsin           13           ..F.A...... inverted half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ihsin")]
        ihsin = 13,
        /// <summary>
        /// dese            14           ..F.A...... double-exponential seat
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dese")]
        dese = 14,
        /// <summary>
        /// desi            15           ..F.A...... double-exponential sigmoid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("desi")]
        desi = 15,
        /// <summary>
        /// losi            16           ..F.A...... logistic sigmoid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("losi")]
        losi = 16,
        /// <summary>
        /// sinc            17           ..F.A...... sine cardinal function
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sinc")]
        sinc = 17,
        /// <summary>
        /// isinc           18           ..F.A...... inverted sine cardinal function
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("isinc")]
        isinc = 18,
        /// <summary>
        /// quat            19           ..F.A...... quartic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quat")]
        quat = 19,
        /// <summary>
        /// quatr           20           ..F.A...... quartic root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quatr")]
        quatr = 20,
        /// <summary>
        /// qsin2           21           ..F.A...... squared quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qsin2")]
        qsin2 = 21,
        /// <summary>
        /// hsin2           22           ..F.A...... squared half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hsin2")]
        hsin2 = 22
    }

    /// <summary>
    ///  set fade curve type for 1st stream (from -1 to 22) (default tri)
    /// </summary>
    public enum AcrossfadeFilterGenC1
    {
        /// <summary>
        /// nofade          -1           ..F.A...... no fade; keep audio as-is
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nofade")]
        nofade = -1,
        /// <summary>
        /// tri             0            ..F.A...... linear slope
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tri")]
        tri = 0,
        /// <summary>
        /// qsin            1            ..F.A...... quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qsin")]
        qsin = 1,
        /// <summary>
        /// esin            2            ..F.A...... exponential sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("esin")]
        esin = 2,
        /// <summary>
        /// hsin            3            ..F.A...... half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hsin")]
        hsin = 3,
        /// <summary>
        /// log             4            ..F.A...... logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 4,
        /// <summary>
        /// ipar            5            ..F.A...... inverted parabola
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ipar")]
        ipar = 5,
        /// <summary>
        /// qua             6            ..F.A...... quadratic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qua")]
        qua = 6,
        /// <summary>
        /// cub             7            ..F.A...... cubic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cub")]
        cub = 7,
        /// <summary>
        /// squ             8            ..F.A...... square root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("squ")]
        squ = 8,
        /// <summary>
        /// cbr             9            ..F.A...... cubic root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cbr")]
        cbr = 9,
        /// <summary>
        /// par             10           ..F.A...... parabola
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("par")]
        par = 10,
        /// <summary>
        /// exp             11           ..F.A...... exponential
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("exp")]
        exp = 11,
        /// <summary>
        /// iqsin           12           ..F.A...... inverted quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iqsin")]
        iqsin = 12,
        /// <summary>
        /// ihsin           13           ..F.A...... inverted half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ihsin")]
        ihsin = 13,
        /// <summary>
        /// dese            14           ..F.A...... double-exponential seat
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dese")]
        dese = 14,
        /// <summary>
        /// desi            15           ..F.A...... double-exponential sigmoid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("desi")]
        desi = 15,
        /// <summary>
        /// losi            16           ..F.A...... logistic sigmoid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("losi")]
        losi = 16,
        /// <summary>
        /// sinc            17           ..F.A...... sine cardinal function
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sinc")]
        sinc = 17,
        /// <summary>
        /// isinc           18           ..F.A...... inverted sine cardinal function
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("isinc")]
        isinc = 18,
        /// <summary>
        /// quat            19           ..F.A...... quartic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quat")]
        quat = 19,
        /// <summary>
        /// quatr           20           ..F.A...... quartic root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quatr")]
        quatr = 20,
        /// <summary>
        /// qsin2           21           ..F.A...... squared quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qsin2")]
        qsin2 = 21,
        /// <summary>
        /// hsin2           22           ..F.A...... squared half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hsin2")]
        hsin2 = 22
    }

    /// <summary>
    ///  set fade curve type for 2nd stream (from -1 to 22) (default tri)
    /// </summary>
    public enum AcrossfadeFilterGenCurve2
    {
        /// <summary>
        /// nofade          -1           ..F.A...... no fade; keep audio as-is
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nofade")]
        nofade = -1,
        /// <summary>
        /// tri             0            ..F.A...... linear slope
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tri")]
        tri = 0,
        /// <summary>
        /// qsin            1            ..F.A...... quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qsin")]
        qsin = 1,
        /// <summary>
        /// esin            2            ..F.A...... exponential sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("esin")]
        esin = 2,
        /// <summary>
        /// hsin            3            ..F.A...... half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hsin")]
        hsin = 3,
        /// <summary>
        /// log             4            ..F.A...... logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 4,
        /// <summary>
        /// ipar            5            ..F.A...... inverted parabola
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ipar")]
        ipar = 5,
        /// <summary>
        /// qua             6            ..F.A...... quadratic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qua")]
        qua = 6,
        /// <summary>
        /// cub             7            ..F.A...... cubic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cub")]
        cub = 7,
        /// <summary>
        /// squ             8            ..F.A...... square root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("squ")]
        squ = 8,
        /// <summary>
        /// cbr             9            ..F.A...... cubic root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cbr")]
        cbr = 9,
        /// <summary>
        /// par             10           ..F.A...... parabola
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("par")]
        par = 10,
        /// <summary>
        /// exp             11           ..F.A...... exponential
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("exp")]
        exp = 11,
        /// <summary>
        /// iqsin           12           ..F.A...... inverted quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iqsin")]
        iqsin = 12,
        /// <summary>
        /// ihsin           13           ..F.A...... inverted half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ihsin")]
        ihsin = 13,
        /// <summary>
        /// dese            14           ..F.A...... double-exponential seat
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dese")]
        dese = 14,
        /// <summary>
        /// desi            15           ..F.A...... double-exponential sigmoid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("desi")]
        desi = 15,
        /// <summary>
        /// losi            16           ..F.A...... logistic sigmoid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("losi")]
        losi = 16,
        /// <summary>
        /// sinc            17           ..F.A...... sine cardinal function
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sinc")]
        sinc = 17,
        /// <summary>
        /// isinc           18           ..F.A...... inverted sine cardinal function
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("isinc")]
        isinc = 18,
        /// <summary>
        /// quat            19           ..F.A...... quartic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quat")]
        quat = 19,
        /// <summary>
        /// quatr           20           ..F.A...... quartic root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quatr")]
        quatr = 20,
        /// <summary>
        /// qsin2           21           ..F.A...... squared quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qsin2")]
        qsin2 = 21,
        /// <summary>
        /// hsin2           22           ..F.A...... squared half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hsin2")]
        hsin2 = 22
    }

    /// <summary>
    ///  set fade curve type for 2nd stream (from -1 to 22) (default tri)
    /// </summary>
    public enum AcrossfadeFilterGenC2
    {
        /// <summary>
        /// nofade          -1           ..F.A...... no fade; keep audio as-is
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nofade")]
        nofade = -1,
        /// <summary>
        /// tri             0            ..F.A...... linear slope
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tri")]
        tri = 0,
        /// <summary>
        /// qsin            1            ..F.A...... quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qsin")]
        qsin = 1,
        /// <summary>
        /// esin            2            ..F.A...... exponential sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("esin")]
        esin = 2,
        /// <summary>
        /// hsin            3            ..F.A...... half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hsin")]
        hsin = 3,
        /// <summary>
        /// log             4            ..F.A...... logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 4,
        /// <summary>
        /// ipar            5            ..F.A...... inverted parabola
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ipar")]
        ipar = 5,
        /// <summary>
        /// qua             6            ..F.A...... quadratic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qua")]
        qua = 6,
        /// <summary>
        /// cub             7            ..F.A...... cubic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cub")]
        cub = 7,
        /// <summary>
        /// squ             8            ..F.A...... square root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("squ")]
        squ = 8,
        /// <summary>
        /// cbr             9            ..F.A...... cubic root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cbr")]
        cbr = 9,
        /// <summary>
        /// par             10           ..F.A...... parabola
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("par")]
        par = 10,
        /// <summary>
        /// exp             11           ..F.A...... exponential
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("exp")]
        exp = 11,
        /// <summary>
        /// iqsin           12           ..F.A...... inverted quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iqsin")]
        iqsin = 12,
        /// <summary>
        /// ihsin           13           ..F.A...... inverted half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ihsin")]
        ihsin = 13,
        /// <summary>
        /// dese            14           ..F.A...... double-exponential seat
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dese")]
        dese = 14,
        /// <summary>
        /// desi            15           ..F.A...... double-exponential sigmoid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("desi")]
        desi = 15,
        /// <summary>
        /// losi            16           ..F.A...... logistic sigmoid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("losi")]
        losi = 16,
        /// <summary>
        /// sinc            17           ..F.A...... sine cardinal function
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sinc")]
        sinc = 17,
        /// <summary>
        /// isinc           18           ..F.A...... inverted sine cardinal function
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("isinc")]
        isinc = 18,
        /// <summary>
        /// quat            19           ..F.A...... quartic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quat")]
        quat = 19,
        /// <summary>
        /// quatr           20           ..F.A...... quartic root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quatr")]
        quatr = 20,
        /// <summary>
        /// qsin2           21           ..F.A...... squared quarter of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qsin2")]
        qsin2 = 21,
        /// <summary>
        /// hsin2           22           ..F.A...... squared half of sine wave
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hsin2")]
        hsin2 = 22
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Cross fade two input audio streams.
        /// </summary>
        public static AcrossfadeFilterGen AcrossfadeFilterGen(this AudioMap input0, AudioMap input1) => new AcrossfadeFilterGen(input0, input1);
    }
}