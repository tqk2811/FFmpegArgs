namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S waveform          V-&gt;V       Video waveform monitor.
    /// </summary>
    public class WaveformFilterGen : ImageToImageFilter, ISliceThreading
    {
        internal WaveformFilterGen(ImageMap input) : base("waveform", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set mode (from 0 to 1) (default column)
        /// </summary>
        public WaveformFilterGen mode(WaveformFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set intensity (from 0 to 1) (default 0.04)
        /// </summary>
        public WaveformFilterGen intensity(float intensity) => this.SetOptionRange("intensity", intensity, 0, 1);
        /// <summary>
        ///  set mirroring (default true)
        /// </summary>
        public WaveformFilterGen mirror(bool mirror) => this.SetOption("mirror", mirror.ToFFmpegFlag());
        /// <summary>
        ///  set mirroring (default true)
        /// </summary>
        public WaveformFilterGen r(bool r) => this.SetOption("r", r.ToFFmpegFlag());
        /// <summary>
        ///  set display mode (from 0 to 2) (default stack)
        /// </summary>
        public WaveformFilterGen display(WaveformFilterGenDisplay display) => this.SetOption("display", display.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set components to display (from 1 to 15) (default 1)
        /// </summary>
        public WaveformFilterGen components(int components) => this.SetOptionRange("components", components, 1, 15);
        /// <summary>
        ///  set envelope to display (from 0 to 3) (default none)
        /// </summary>
        public WaveformFilterGen envelope(WaveformFilterGenEnvelope envelope) => this.SetOption("envelope", envelope.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set filter (from 0 to 7) (default lowpass)
        /// </summary>
        public WaveformFilterGen filter(WaveformFilterGenFilter filter) => this.SetOption("filter", filter.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set graticule (from 0 to 3) (default none)
        /// </summary>
        public WaveformFilterGen graticule(WaveformFilterGenGraticule graticule) => this.SetOption("graticule", graticule.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set graticule opacity (from 0 to 1) (default 0.75)
        /// </summary>
        public WaveformFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity, 0, 1);
        /// <summary>
        ///  set graticule flags (default numbers)
        /// </summary>
        public WaveformFilterGen flags(WaveformFilterGenFlags flags) => this.SetOption("flags", flags.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set scale (from 0 to 2) (default digital)
        /// </summary>
        public WaveformFilterGen scale(WaveformFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set background opacity (from 0 to 1) (default 0.75)
        /// </summary>
        public WaveformFilterGen bgopacity(float bgopacity) => this.SetOptionRange("bgopacity", bgopacity, 0, 1);
        /// <summary>
        ///  set 1st tint (from -1 to 1) (default 0)
        /// </summary>
        public WaveformFilterGen tint0(float tint0) => this.SetOptionRange("tint0", tint0, -1, 1);
        /// <summary>
        ///  set 1st tint (from -1 to 1) (default 0)
        /// </summary>
        public WaveformFilterGen t0(float t0) => this.SetOptionRange("t0", t0, -1, 1);
        /// <summary>
        ///  set 2nd tint (from -1 to 1) (default 0)
        /// </summary>
        public WaveformFilterGen tint1(float tint1) => this.SetOptionRange("tint1", tint1, -1, 1);
        /// <summary>
        ///  set 2nd tint (from -1 to 1) (default 0)
        /// </summary>
        public WaveformFilterGen t1(float t1) => this.SetOptionRange("t1", t1, -1, 1);
        /// <summary>
        ///  set fit mode (from 0 to 1) (default none)
        /// </summary>
        public WaveformFilterGen fitmode(WaveformFilterGenFitmode fitmode) => this.SetOption("fitmode", fitmode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set fit mode (from 0 to 1) (default none)
        /// </summary>
        public WaveformFilterGen fm(WaveformFilterGenFm fm) => this.SetOption("fm", fm.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input formats selection (from 0 to 1) (default first)
        /// </summary>
        public WaveformFilterGen input(WaveformFilterGenInput input) => this.SetOption("input", input.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set mode (from 0 to 1) (default column)
    /// </summary>
    public enum WaveformFilterGenMode
    {
        /// <summary>
        /// row             0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("row")]
        row = 0,
        /// <summary>
        /// column          1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("column")]
        column = 1
    }

    /// <summary>
    ///  set display mode (from 0 to 2) (default stack)
    /// </summary>
    public enum WaveformFilterGenDisplay
    {
        /// <summary>
        /// overlay         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("overlay")]
        overlay = 0,
        /// <summary>
        /// stack           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("stack")]
        stack = 1,
        /// <summary>
        /// parade          2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("parade")]
        parade = 2
    }

    /// <summary>
    ///  set envelope to display (from 0 to 3) (default none)
    /// </summary>
    public enum WaveformFilterGenEnvelope
    {
        /// <summary>
        /// none            0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// instant         1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("instant")]
        instant = 1,
        /// <summary>
        /// peak            2            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("peak")]
        peak = 2,
        /// <summary>
        /// peak+instant    3            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("peak+instant")]
        peakPlusinstant = 3
    }

    /// <summary>
    ///  set filter (from 0 to 7) (default lowpass)
    /// </summary>
    public enum WaveformFilterGenFilter
    {
        /// <summary>
        /// lowpass         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lowpass")]
        lowpass = 0,
        /// <summary>
        /// flat            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("flat")]
        flat = 1,
        /// <summary>
        /// aflat           2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("aflat")]
        aflat = 2,
        /// <summary>
        /// chroma          3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("chroma")]
        chroma = 3,
        /// <summary>
        /// color           4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("color")]
        color = 4,
        /// <summary>
        /// acolor          5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("acolor")]
        acolor = 5,
        /// <summary>
        /// xflat           6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("xflat")]
        xflat = 6,
        /// <summary>
        /// yflat           7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yflat")]
        yflat = 7
    }

    /// <summary>
    ///  set graticule (from 0 to 3) (default none)
    /// </summary>
    public enum WaveformFilterGenGraticule
    {
        /// <summary>
        /// none            0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// green           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("green")]
        green = 1,
        /// <summary>
        /// orange          2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("orange")]
        orange = 2,
        /// <summary>
        /// invert          3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("invert")]
        invert = 3
    }

    /// <summary>
    ///  set graticule flags (default numbers)
    /// </summary>
    public enum WaveformFilterGenFlags
    {
        /// <summary>
        /// numbers                      ..FV.....T. draw numbers
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("numbers")]
        numbers,
        /// <summary>
        /// dots                         ..FV.....T. draw dots instead of lines
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dots")]
        dots
    }

    /// <summary>
    ///  set scale (from 0 to 2) (default digital)
    /// </summary>
    public enum WaveformFilterGenScale
    {
        /// <summary>
        /// digital         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("digital")]
        digital = 0,
        /// <summary>
        /// millivolts      1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("millivolts")]
        millivolts = 1,
        /// <summary>
        /// ire             2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ire")]
        ire = 2
    }

    /// <summary>
    ///  set fit mode (from 0 to 1) (default none)
    /// </summary>
    public enum WaveformFilterGenFitmode
    {
        /// <summary>
        /// none            0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// size            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("size")]
        size = 1
    }

    /// <summary>
    ///  set fit mode (from 0 to 1) (default none)
    /// </summary>
    public enum WaveformFilterGenFm
    {
        /// <summary>
        /// none            0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// size            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("size")]
        size = 1
    }

    /// <summary>
    ///  set input formats selection (from 0 to 1) (default first)
    /// </summary>
    public enum WaveformFilterGenInput
    {
        /// <summary>
        /// all             0            ..FV....... try to select from all available formats
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("all")]
        all = 0,
        /// <summary>
        /// first           1            ..FV....... pick first available format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("first")]
        first = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Video waveform monitor.
        /// </summary>
        public static WaveformFilterGen WaveformFilterGen(this ImageMap input0) => new WaveformFilterGen(input0);
    }
}