namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.C acrusher          A-&gt;A       Reduce audio bit resolution.
    /// </summary>
    public class AcrusherFilterGen : AudioToAudioFilter, ITimelineSupport, ICommandSupport
    {
        internal AcrusherFilterGen(AudioMap input) : base("acrusher", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set level in (from 0.015625 to 64) (default 1)
        /// </summary>
        public AcrusherFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in, 0.015625, 64);
        /// <summary>
        ///  set level out (from 0.015625 to 64) (default 1)
        /// </summary>
        public AcrusherFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out, 0.015625, 64);
        /// <summary>
        ///  set bit reduction (from 1 to 64) (default 8)
        /// </summary>
        public AcrusherFilterGen bits(double bits) => this.SetOptionRange("bits", bits, 1, 64);
        /// <summary>
        ///  set mix (from 0 to 1) (default 0.5)
        /// </summary>
        public AcrusherFilterGen mix(double mix) => this.SetOptionRange("mix", mix, 0, 1);
        /// <summary>
        ///  set mode (from 0 to 1) (default lin)
        /// </summary>
        public AcrusherFilterGen mode(AcrusherFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set DC (from 0.25 to 4) (default 1)
        /// </summary>
        public AcrusherFilterGen dc(double dc) => this.SetOptionRange("dc", dc, 0.25, 4);
        /// <summary>
        ///  set anti-aliasing (from 0 to 1) (default 0.5)
        /// </summary>
        public AcrusherFilterGen aa(double aa) => this.SetOptionRange("aa", aa, 0, 1);
        /// <summary>
        ///  set sample reduction (from 1 to 250) (default 1)
        /// </summary>
        public AcrusherFilterGen samples(double samples) => this.SetOptionRange("samples", samples, 1, 250);
        /// <summary>
        ///  enable LFO (default false)
        /// </summary>
        public AcrusherFilterGen lfo(bool lfo) => this.SetOption("lfo", lfo.ToFFmpegFlag());
        /// <summary>
        ///  set LFO depth (from 1 to 250) (default 20)
        /// </summary>
        public AcrusherFilterGen lforange(double lforange) => this.SetOptionRange("lforange", lforange, 1, 250);
        /// <summary>
        ///  set LFO rate (from 0.01 to 200) (default 0.3)
        /// </summary>
        public AcrusherFilterGen lforate(double lforate) => this.SetOptionRange("lforate", lforate, 0.01, 200);
    }

    /// <summary>
    ///  set mode (from 0 to 1) (default lin)
    /// </summary>
    public enum AcrusherFilterGenMode
    {
        /// <summary>
        /// lin             0            ..F.A....T. linear
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lin")]
        lin = 0,
        /// <summary>
        /// log             1            ..F.A....T. logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Reduce audio bit resolution.
        /// </summary>
        public static AcrusherFilterGen AcrusherFilterGen(this AudioMap input0) => new AcrusherFilterGen(input0);
    }
}