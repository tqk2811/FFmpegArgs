namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. firequalizer      A-&gt;A       Finite Impulse Response Equalizer.
    /// </summary>
    public class FirequalizerFilterGen : AudioToAudioFilter
    {
        internal FirequalizerFilterGen(AudioMap input) : base("firequalizer", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set gain curve (default &quot;gain_interpolate(f)&quot;)
        /// </summary>
        public FirequalizerFilterGen gain(String gain) => this.SetOption("gain", gain.ToStringInv());
        /// <summary>
        ///  set gain entry
        /// </summary>
        public FirequalizerFilterGen gain_entry(String gain_entry) => this.SetOption("gain_entry", gain_entry.ToStringInv());
        /// <summary>
        ///  set delay (from 0 to 1e+10) (default 0.01)
        /// </summary>
        public FirequalizerFilterGen delay(double delay) => this.SetOptionRange("delay", delay, 0, 1e+10);
        /// <summary>
        ///  set accuracy (from 0 to 1e+10) (default 5)
        /// </summary>
        public FirequalizerFilterGen accuracy(double accuracy) => this.SetOptionRange("accuracy", accuracy, 0, 1e+10);
        /// <summary>
        ///  set window function (from 0 to 9) (default hann)
        /// </summary>
        public FirequalizerFilterGen wfunc(FirequalizerFilterGenWfunc wfunc) => this.SetOption("wfunc", wfunc.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set fixed frame samples (default false)
        /// </summary>
        public FirequalizerFilterGen _fixed(bool _fixed) => this.SetOption("fixed", _fixed.ToFFmpegFlag());
        /// <summary>
        ///  set multi channels mode (default false)
        /// </summary>
        public FirequalizerFilterGen multi(bool multi) => this.SetOption("multi", multi.ToFFmpegFlag());
        /// <summary>
        ///  set zero phase mode (default false)
        /// </summary>
        public FirequalizerFilterGen zero_phase(bool zero_phase) => this.SetOption("zero_phase", zero_phase.ToFFmpegFlag());
        /// <summary>
        ///  set gain scale (from 0 to 3) (default linlog)
        /// </summary>
        public FirequalizerFilterGen scale(FirequalizerFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set dump file
        /// </summary>
        public FirequalizerFilterGen dumpfile(String dumpfile) => this.SetOption("dumpfile", dumpfile.ToStringInv());
        /// <summary>
        ///  set dump scale (from 0 to 3) (default linlog)
        /// </summary>
        public FirequalizerFilterGen dumpscale(FirequalizerFilterGenDumpscale dumpscale) => this.SetOption("dumpscale", dumpscale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set 2-channels fft (default false)
        /// </summary>
        public FirequalizerFilterGen fft2(bool fft2) => this.SetOption("fft2", fft2.ToFFmpegFlag());
        /// <summary>
        ///  set minimum phase mode (default false)
        /// </summary>
        public FirequalizerFilterGen min_phase(bool min_phase) => this.SetOption("min_phase", min_phase.ToFFmpegFlag());
    }

    /// <summary>
    ///  set window function (from 0 to 9) (default hann)
    /// </summary>
    public enum FirequalizerFilterGenWfunc
    {
        /// <summary>
        /// rectangular     0            ..F.A...... rectangular window
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rectangular")]
        rectangular = 0,
        /// <summary>
        /// hann            1            ..F.A...... hann window
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hann")]
        hann = 1,
        /// <summary>
        /// hamming         2            ..F.A...... hamming window
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hamming")]
        hamming = 2,
        /// <summary>
        /// blackman        3            ..F.A...... blackman window
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blackman")]
        blackman = 3,
        /// <summary>
        /// nuttall3        4            ..F.A...... 3-term nuttall window
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nuttall3")]
        nuttall3 = 4,
        /// <summary>
        /// mnuttall3       5            ..F.A...... minimum 3-term nuttall window
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mnuttall3")]
        mnuttall3 = 5,
        /// <summary>
        /// nuttall         6            ..F.A...... nuttall window
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nuttall")]
        nuttall = 6,
        /// <summary>
        /// bnuttall        7            ..F.A...... blackman-nuttall window
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bnuttall")]
        bnuttall = 7,
        /// <summary>
        /// bharris         8            ..F.A...... blackman-harris window
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bharris")]
        bharris = 8,
        /// <summary>
        /// tukey           9            ..F.A...... tukey window
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tukey")]
        tukey = 9
    }

    /// <summary>
    ///  set gain scale (from 0 to 3) (default linlog)
    /// </summary>
    public enum FirequalizerFilterGenScale
    {
        /// <summary>
        /// linlin          0            ..F.A...... linear-freq linear-gain
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linlin")]
        linlin = 0,
        /// <summary>
        /// linlog          1            ..F.A...... linear-freq logarithmic-gain
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linlog")]
        linlog = 1,
        /// <summary>
        /// loglin          2            ..F.A...... logarithmic-freq linear-gain
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("loglin")]
        loglin = 2,
        /// <summary>
        /// loglog          3            ..F.A...... logarithmic-freq logarithmic-gain
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("loglog")]
        loglog = 3
    }

    /// <summary>
    ///  set dump scale (from 0 to 3) (default linlog)
    /// </summary>
    public enum FirequalizerFilterGenDumpscale
    {
        /// <summary>
        /// linlin          0            ..F.A...... linear-freq linear-gain
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linlin")]
        linlin = 0,
        /// <summary>
        /// linlog          1            ..F.A...... linear-freq logarithmic-gain
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linlog")]
        linlog = 1,
        /// <summary>
        /// loglin          2            ..F.A...... logarithmic-freq linear-gain
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("loglin")]
        loglin = 2,
        /// <summary>
        /// loglog          3            ..F.A...... logarithmic-freq logarithmic-gain
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("loglog")]
        loglog = 3
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Finite Impulse Response Equalizer.
        /// </summary>
        public static FirequalizerFilterGen FirequalizerFilterGen(this AudioMap input0) => new FirequalizerFilterGen(input0);
    }
}