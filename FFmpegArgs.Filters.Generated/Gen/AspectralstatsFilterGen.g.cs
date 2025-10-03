namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S. aspectralstats    A-&gt;A       Show frequency domain statistics about audio frames.
    /// </summary>
    public class AspectralstatsFilterGen : AudioToAudioFilter, ISliceThreading
    {
        internal AspectralstatsFilterGen(AudioMap input) : base("aspectralstats", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the window size (from 32 to 65536) (default 2048)
        /// </summary>
        public AspectralstatsFilterGen win_size(int win_size) => this.SetOptionRange("win_size", win_size, 32, 65536);
        /// <summary>
        ///  set window function (from 0 to 20) (default hann)
        /// </summary>
        public AspectralstatsFilterGen win_func(AspectralstatsFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set window overlap (from 0 to 1) (default 0.5)
        /// </summary>
        public AspectralstatsFilterGen overlap(float overlap) => this.SetOptionRange("overlap", overlap, 0, 1);
        /// <summary>
        ///  select the parameters which are measured (default all+mean+variance+centroid+spread+skewness+kurtosis+entropy+flatness+crest+flux+slope+decrease+rolloff)
        /// </summary>
        public AspectralstatsFilterGen measure(AspectralstatsFilterGenMeasure measure) => this.SetOption("measure", measure.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set window function (from 0 to 20) (default hann)
    /// </summary>
    public enum AspectralstatsFilterGenWin_func
    {
        /// <summary>
        /// rect            0            ..F.A...... Rectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rect")]
        rect = 0,
        /// <summary>
        /// bartlett        4            ..F.A...... Bartlett
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bartlett")]
        bartlett = 4,
        /// <summary>
        /// hann            1            ..F.A...... Hann
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hann")]
        hann = 1,
        /// <summary>
        /// hanning         1            ..F.A...... Hanning
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hanning")]
        hanning = 1,
        /// <summary>
        /// hamming         2            ..F.A...... Hamming
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hamming")]
        hamming = 2,
        /// <summary>
        /// blackman        3            ..F.A...... Blackman
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blackman")]
        blackman = 3,
        /// <summary>
        /// welch           5            ..F.A...... Welch
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("welch")]
        welch = 5,
        /// <summary>
        /// flattop         6            ..F.A...... Flat-top
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("flattop")]
        flattop = 6,
        /// <summary>
        /// bharris         7            ..F.A...... Blackman-Harris
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bharris")]
        bharris = 7,
        /// <summary>
        /// bnuttall        8            ..F.A...... Blackman-Nuttall
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bnuttall")]
        bnuttall = 8,
        /// <summary>
        /// bhann           11           ..F.A...... Bartlett-Hann
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bhann")]
        bhann = 11,
        /// <summary>
        /// sine            9            ..F.A...... Sine
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sine")]
        sine = 9,
        /// <summary>
        /// nuttall         10           ..F.A...... Nuttall
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nuttall")]
        nuttall = 10,
        /// <summary>
        /// lanczos         12           ..F.A...... Lanczos
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lanczos")]
        lanczos = 12,
        /// <summary>
        /// gauss           13           ..F.A...... Gauss
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gauss")]
        gauss = 13,
        /// <summary>
        /// tukey           14           ..F.A...... Tukey
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tukey")]
        tukey = 14,
        /// <summary>
        /// dolph           15           ..F.A...... Dolph-Chebyshev
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dolph")]
        dolph = 15,
        /// <summary>
        /// cauchy          16           ..F.A...... Cauchy
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cauchy")]
        cauchy = 16,
        /// <summary>
        /// parzen          17           ..F.A...... Parzen
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("parzen")]
        parzen = 17,
        /// <summary>
        /// poisson         18           ..F.A...... Poisson
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("poisson")]
        poisson = 18,
        /// <summary>
        /// bohman          19           ..F.A...... Bohman
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bohman")]
        bohman = 19,
        /// <summary>
        /// kaiser          20           ..F.A...... Kaiser
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("kaiser")]
        kaiser = 20
    }

    /// <summary>
    ///  select the parameters which are measured (default all+mean+variance+centroid+spread+skewness+kurtosis+entropy+flatness+crest+flux+slope+decrease+rolloff)
    /// </summary>
    public enum AspectralstatsFilterGenMeasure
    {
        /// <summary>
        /// none                         ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none,
        /// <summary>
        /// all                          ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("all")]
        all,
        /// <summary>
        /// mean                         ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mean")]
        mean,
        /// <summary>
        /// variance                     ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("variance")]
        variance,
        /// <summary>
        /// centroid                     ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("centroid")]
        centroid,
        /// <summary>
        /// spread                       ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("spread")]
        spread,
        /// <summary>
        /// skewness                     ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("skewness")]
        skewness,
        /// <summary>
        /// kurtosis                     ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("kurtosis")]
        kurtosis,
        /// <summary>
        /// entropy                      ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("entropy")]
        entropy,
        /// <summary>
        /// flatness                     ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("flatness")]
        flatness,
        /// <summary>
        /// crest                        ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("crest")]
        crest,
        /// <summary>
        /// flux                         ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("flux")]
        flux,
        /// <summary>
        /// slope                        ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("slope")]
        slope,
        /// <summary>
        /// decrease                     ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("decrease")]
        decrease,
        /// <summary>
        /// rolloff                      ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rolloff")]
        rolloff
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Show frequency domain statistics about audio frames.
        /// </summary>
        public static AspectralstatsFilterGen AspectralstatsFilterGen(this AudioMap input0) => new AspectralstatsFilterGen(input0);
    }
}