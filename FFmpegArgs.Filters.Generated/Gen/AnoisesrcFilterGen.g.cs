namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. anoisesrc         |-&gt;A       Generate a noise audio signal.
    /// </summary>
    public class AnoisesrcFilterGen : SourceToAudioFilter
    {
        internal AnoisesrcFilterGen(IAudioFilterGraph input) : base("anoisesrc", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set sample rate (from 15 to INT_MAX) (default 48000)
        /// </summary>
        public AnoisesrcFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate, 15, INT_MAX);
        /// <summary>
        ///  set sample rate (from 15 to INT_MAX) (default 48000)
        /// </summary>
        public AnoisesrcFilterGen r(int r) => this.SetOptionRange("r", r, 15, INT_MAX);
        /// <summary>
        ///  set amplitude (from 0 to 1) (default 1)
        /// </summary>
        public AnoisesrcFilterGen amplitude(double amplitude) => this.SetOptionRange("amplitude", amplitude, 0, 1);
        /// <summary>
        ///  set duration (default 0)
        /// </summary>
        public AnoisesrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set noise color (from 0 to 5) (default white)
        /// </summary>
        public AnoisesrcFilterGen color(AnoisesrcFilterGenColor color) => this.SetOption("color", color.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set noise color (from 0 to 5) (default white)
        /// </summary>
        public AnoisesrcFilterGen colour(AnoisesrcFilterGenColour colour) => this.SetOption("colour", colour.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set noise color (from 0 to 5) (default white)
        /// </summary>
        public AnoisesrcFilterGen c(AnoisesrcFilterGenC c) => this.SetOption("c", c.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set random seed (from -1 to UINT32_MAX) (default -1)
        /// </summary>
        public AnoisesrcFilterGen seed(long seed) => this.SetOptionRange("seed", seed, -1, UINT32_MAX);
        /// <summary>
        ///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
        /// </summary>
        public AnoisesrcFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples, 1, INT_MAX);
        /// <summary>
        ///  set density (from 0 to 1) (default 0.05)
        /// </summary>
        public AnoisesrcFilterGen density(double density) => this.SetOptionRange("density", density, 0, 1);
    }

    /// <summary>
    ///  set noise color (from 0 to 5) (default white)
    /// </summary>
    public enum AnoisesrcFilterGenColor
    {
        /// <summary>
        /// white           0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("white")]
        white = 0,
        /// <summary>
        /// pink            1            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pink")]
        pink = 1,
        /// <summary>
        /// brown           2            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("brown")]
        brown = 2,
        /// <summary>
        /// blue            3            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blue")]
        blue = 3,
        /// <summary>
        /// violet          4            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("violet")]
        violet = 4,
        /// <summary>
        /// velvet          5            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("velvet")]
        velvet = 5
    }

    /// <summary>
    ///  set noise color (from 0 to 5) (default white)
    /// </summary>
    public enum AnoisesrcFilterGenColour
    {
        /// <summary>
        /// white           0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("white")]
        white = 0,
        /// <summary>
        /// pink            1            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pink")]
        pink = 1,
        /// <summary>
        /// brown           2            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("brown")]
        brown = 2,
        /// <summary>
        /// blue            3            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blue")]
        blue = 3,
        /// <summary>
        /// violet          4            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("violet")]
        violet = 4,
        /// <summary>
        /// velvet          5            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("velvet")]
        velvet = 5
    }

    /// <summary>
    ///  set noise color (from 0 to 5) (default white)
    /// </summary>
    public enum AnoisesrcFilterGenC
    {
        /// <summary>
        /// white           0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("white")]
        white = 0,
        /// <summary>
        /// pink            1            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pink")]
        pink = 1,
        /// <summary>
        /// brown           2            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("brown")]
        brown = 2,
        /// <summary>
        /// blue            3            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blue")]
        blue = 3,
        /// <summary>
        /// violet          4            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("violet")]
        violet = 4,
        /// <summary>
        /// velvet          5            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("velvet")]
        velvet = 5
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate a noise audio signal.
        /// </summary>
        public static AnoisesrcFilterGen AnoisesrcFilterGen(this IAudioFilterGraph input) => new AnoisesrcFilterGen(input);
    }
}