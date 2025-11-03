namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. stereotools       A-&gt;A       Apply various stereo tools.
    /// </summary>
    public class StereotoolsFilterGen : AudioToAudioFilter, ITimelineSupport
    {
        internal StereotoolsFilterGen(AudioMap input) : base("stereotools", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set level in (from 0.015625 to 64) (default 1)
        /// </summary>
        public StereotoolsFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in, 0.015625, 64);
        /// <summary>
        ///  set level out (from 0.015625 to 64) (default 1)
        /// </summary>
        public StereotoolsFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out, 0.015625, 64);
        /// <summary>
        ///  set balance in (from -1 to 1) (default 0)
        /// </summary>
        public StereotoolsFilterGen balance_in(double balance_in) => this.SetOptionRange("balance_in", balance_in, -1, 1);
        /// <summary>
        ///  set balance out (from -1 to 1) (default 0)
        /// </summary>
        public StereotoolsFilterGen balance_out(double balance_out) => this.SetOptionRange("balance_out", balance_out, -1, 1);
        /// <summary>
        ///  enable softclip (default false)
        /// </summary>
        public StereotoolsFilterGen softclip(bool softclip) => this.SetOption("softclip", softclip.ToFFmpegFlag());
        /// <summary>
        ///  mute L (default false)
        /// </summary>
        public StereotoolsFilterGen mutel(bool mutel) => this.SetOption("mutel", mutel.ToFFmpegFlag());
        /// <summary>
        ///  mute R (default false)
        /// </summary>
        public StereotoolsFilterGen muter(bool muter) => this.SetOption("muter", muter.ToFFmpegFlag());
        /// <summary>
        ///  phase L (default false)
        /// </summary>
        public StereotoolsFilterGen phasel(bool phasel) => this.SetOption("phasel", phasel.ToFFmpegFlag());
        /// <summary>
        ///  phase R (default false)
        /// </summary>
        public StereotoolsFilterGen phaser(bool phaser) => this.SetOption("phaser", phaser.ToFFmpegFlag());
        /// <summary>
        ///  set stereo mode (from 0 to 10) (default lr&gt;lr)
        /// </summary>
        public StereotoolsFilterGen mode(StereotoolsFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set side level (from 0.015625 to 64) (default 1)
        /// </summary>
        public StereotoolsFilterGen slev(double slev) => this.SetOptionRange("slev", slev, 0.015625, 64);
        /// <summary>
        ///  set side balance (from -1 to 1) (default 0)
        /// </summary>
        public StereotoolsFilterGen sbal(double sbal) => this.SetOptionRange("sbal", sbal, -1, 1);
        /// <summary>
        ///  set middle level (from 0.015625 to 64) (default 1)
        /// </summary>
        public StereotoolsFilterGen mlev(double mlev) => this.SetOptionRange("mlev", mlev, 0.015625, 64);
        /// <summary>
        ///  set middle pan (from -1 to 1) (default 0)
        /// </summary>
        public StereotoolsFilterGen mpan(double mpan) => this.SetOptionRange("mpan", mpan, -1, 1);
        /// <summary>
        ///  set stereo base (from -1 to 1) (default 0)
        /// </summary>
        public StereotoolsFilterGen _base(double _base) => this.SetOptionRange("base", _base, -1, 1);
        /// <summary>
        ///  set delay (from -20 to 20) (default 0)
        /// </summary>
        public StereotoolsFilterGen delay(double delay) => this.SetOptionRange("delay", delay, -20, 20);
        /// <summary>
        ///  set S/C level (from 1 to 100) (default 1)
        /// </summary>
        public StereotoolsFilterGen sclevel(double sclevel) => this.SetOptionRange("sclevel", sclevel, 1, 100);
        /// <summary>
        ///  set stereo phase (from 0 to 360) (default 0)
        /// </summary>
        public StereotoolsFilterGen phase(double phase) => this.SetOptionRange("phase", phase, 0, 360);
        /// <summary>
        ///  set balance in mode (from 0 to 2) (default balance)
        /// </summary>
        public StereotoolsFilterGen bmode_in(StereotoolsFilterGenBmode_in bmode_in) => this.SetOption("bmode_in", bmode_in.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set balance out mode (from 0 to 2) (default balance)
        /// </summary>
        public StereotoolsFilterGen bmode_out(StereotoolsFilterGenBmode_out bmode_out) => this.SetOption("bmode_out", bmode_out.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set stereo mode (from 0 to 10) (default lr&gt;lr)
    /// </summary>
    public enum StereotoolsFilterGenMode
    {
        /// <summary>
        /// lr&gt;lr           0            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lr>lr")]
        lrGreaterThanlr = 0,
        /// <summary>
        /// lr&gt;ms           1            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lr>ms")]
        lrGreaterThanms = 1,
        /// <summary>
        /// ms&gt;lr           2            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ms>lr")]
        msGreaterThanlr = 2,
        /// <summary>
        /// lr&gt;ll           3            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lr>ll")]
        lrGreaterThanll = 3,
        /// <summary>
        /// lr&gt;rr           4            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lr>rr")]
        lrGreaterThanrr = 4,
        /// <summary>
        /// lr&gt;l+r          5            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lr>l+r")]
        lrGreaterThanlPlusr = 5,
        /// <summary>
        /// lr&gt;rl           6            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lr>rl")]
        lrGreaterThanrl = 6,
        /// <summary>
        /// ms&gt;ll           7            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ms>ll")]
        msGreaterThanll = 7,
        /// <summary>
        /// ms&gt;rr           8            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ms>rr")]
        msGreaterThanrr = 8,
        /// <summary>
        /// ms&gt;rl           9            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ms>rl")]
        msGreaterThanrl = 9,
        /// <summary>
        /// lr&gt;l-r          10           ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lr>l-r")]
        lrGreaterThanl_r = 10
    }

    /// <summary>
    ///  set balance in mode (from 0 to 2) (default balance)
    /// </summary>
    public enum StereotoolsFilterGenBmode_in
    {
        /// <summary>
        /// balance         0            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("balance")]
        balance = 0,
        /// <summary>
        /// amplitude       1            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("amplitude")]
        amplitude = 1,
        /// <summary>
        /// power           2            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("power")]
        power = 2
    }

    /// <summary>
    ///  set balance out mode (from 0 to 2) (default balance)
    /// </summary>
    public enum StereotoolsFilterGenBmode_out
    {
        /// <summary>
        /// balance         0            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("balance")]
        balance = 0,
        /// <summary>
        /// amplitude       1            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("amplitude")]
        amplitude = 1,
        /// <summary>
        /// power           2            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("power")]
        power = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply various stereo tools.
        /// </summary>
        public static StereotoolsFilterGen StereotoolsFilterGen(this AudioMap input0) => new StereotoolsFilterGen(input0);
    }
}