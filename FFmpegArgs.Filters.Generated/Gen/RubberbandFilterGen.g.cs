namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. rubberband        A-&gt;A       Apply time-stretching and pitch-shifting.
    /// </summary>
    public class RubberbandFilterGen : AudioToAudioFilter
    {
        internal RubberbandFilterGen(AudioMap input) : base("rubberband", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set tempo scale factor (from 0.01 to 100) (default 1)
        /// </summary>
        public RubberbandFilterGen tempo(double tempo) => this.SetOptionRange("tempo", tempo, 0.01, 100);
        /// <summary>
        ///  set pitch scale factor (from 0.01 to 100) (default 1)
        /// </summary>
        public RubberbandFilterGen pitch(double pitch) => this.SetOptionRange("pitch", pitch, 0.01, 100);
        /// <summary>
        ///  set transients (from 0 to INT_MAX) (default crisp)
        /// </summary>
        public RubberbandFilterGen transients(RubberbandFilterGenTransients transients) => this.SetOption("transients", transients.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set detector (from 0 to INT_MAX) (default compound)
        /// </summary>
        public RubberbandFilterGen detector(RubberbandFilterGenDetector detector) => this.SetOption("detector", detector.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set phase (from 0 to INT_MAX) (default laminar)
        /// </summary>
        public RubberbandFilterGen phase(RubberbandFilterGenPhase phase) => this.SetOption("phase", phase.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set window (from 0 to INT_MAX) (default standard)
        /// </summary>
        public RubberbandFilterGen window(RubberbandFilterGenWindow window) => this.SetOption("window", window.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set smoothing (from 0 to INT_MAX) (default off)
        /// </summary>
        public RubberbandFilterGen smoothing(RubberbandFilterGenSmoothing smoothing) => this.SetOption("smoothing", smoothing.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set formant (from 0 to INT_MAX) (default shifted)
        /// </summary>
        public RubberbandFilterGen formant(RubberbandFilterGenFormant formant) => this.SetOption("formant", formant.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set pitch quality (from 0 to INT_MAX) (default speed)
        /// </summary>
        public RubberbandFilterGen pitchq(RubberbandFilterGenPitchq pitchq) => this.SetOption("pitchq", pitchq.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set channels (from 0 to INT_MAX) (default apart)
        /// </summary>
        public RubberbandFilterGen channels(RubberbandFilterGenChannels channels) => this.SetOption("channels", channels.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set transients (from 0 to INT_MAX) (default crisp)
    /// </summary>
    public enum RubberbandFilterGenTransients
    {
        /// <summary>
        /// crisp           0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("crisp")]
        crisp = 0,
        /// <summary>
        /// mixed           256          ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mixed")]
        mixed = 256,
        /// <summary>
        /// smooth          512          ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smooth")]
        smooth = 512
    }

    /// <summary>
    ///  set detector (from 0 to INT_MAX) (default compound)
    /// </summary>
    public enum RubberbandFilterGenDetector
    {
        /// <summary>
        /// compound        0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("compound")]
        compound = 0,
        /// <summary>
        /// percussive      1024         ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("percussive")]
        percussive = 1024,
        /// <summary>
        /// soft            2048         ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("soft")]
        soft = 2048
    }

    /// <summary>
    ///  set phase (from 0 to INT_MAX) (default laminar)
    /// </summary>
    public enum RubberbandFilterGenPhase
    {
        /// <summary>
        /// laminar         0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("laminar")]
        laminar = 0,
        /// <summary>
        /// independent     8192         ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("independent")]
        independent = 8192
    }

    /// <summary>
    ///  set window (from 0 to INT_MAX) (default standard)
    /// </summary>
    public enum RubberbandFilterGenWindow
    {
        /// <summary>
        /// standard        0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("standard")]
        standard = 0,
        /// <summary>
        /// short           1048576      ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("short")]
        _short = 1048576,
        /// <summary>
        /// long            2097152      ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("long")]
        _long = 2097152
    }

    /// <summary>
    ///  set smoothing (from 0 to INT_MAX) (default off)
    /// </summary>
    public enum RubberbandFilterGenSmoothing
    {
        /// <summary>
        /// off             0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("off")]
        off = 0,
        /// <summary>
        /// on              8388608      ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("on")]
        on = 8388608
    }

    /// <summary>
    ///  set formant (from 0 to INT_MAX) (default shifted)
    /// </summary>
    public enum RubberbandFilterGenFormant
    {
        /// <summary>
        /// shifted         0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("shifted")]
        shifted = 0,
        /// <summary>
        /// preserved       16777216     ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("preserved")]
        preserved = 16777216
    }

    /// <summary>
    ///  set pitch quality (from 0 to INT_MAX) (default speed)
    /// </summary>
    public enum RubberbandFilterGenPitchq
    {
        /// <summary>
        /// quality         33554432     ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quality")]
        quality = 33554432,
        /// <summary>
        /// speed           0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("speed")]
        speed = 0,
        /// <summary>
        /// consistency     67108864     ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("consistency")]
        consistency = 67108864
    }

    /// <summary>
    ///  set channels (from 0 to INT_MAX) (default apart)
    /// </summary>
    public enum RubberbandFilterGenChannels
    {
        /// <summary>
        /// apart           0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("apart")]
        apart = 0,
        /// <summary>
        /// together        268435456    ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("together")]
        together = 268435456
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply time-stretching and pitch-shifting.
        /// </summary>
        public static RubberbandFilterGen RubberbandFilterGen(this AudioMap input0) => new RubberbandFilterGen(input0);
    }
}