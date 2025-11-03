namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS afwtdn            A-&gt;A       Denoise audio stream using Wavelets.
    /// </summary>
    public class AfwtdnFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal AfwtdnFilterGen(AudioMap input) : base("afwtdn", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set noise sigma (from 0 to 1) (default 0)
        /// </summary>
        public AfwtdnFilterGen sigma(double sigma) => this.SetOptionRange("sigma", sigma, 0, 1);
        /// <summary>
        ///  set number of wavelet levels (from 1 to 12) (default 10)
        /// </summary>
        public AfwtdnFilterGen levels(int levels) => this.SetOptionRange("levels", levels, 1, 12);
        /// <summary>
        ///  set wavelet type (from 0 to 6) (default sym10)
        /// </summary>
        public AfwtdnFilterGen wavet(AfwtdnFilterGenWavet wavet) => this.SetOption("wavet", wavet.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set percent of full denoising (from 0 to 100) (default 85)
        /// </summary>
        public AfwtdnFilterGen percent(double percent) => this.SetOptionRange("percent", percent, 0, 100);
        /// <summary>
        ///  profile noise (default false)
        /// </summary>
        public AfwtdnFilterGen profile(bool profile) => this.SetOption("profile", profile.ToFFmpegFlag());
        /// <summary>
        ///  adaptive profiling of noise (default false)
        /// </summary>
        public AfwtdnFilterGen adaptive(bool adaptive) => this.SetOption("adaptive", adaptive.ToFFmpegFlag());
        /// <summary>
        ///  set frame size in number of samples (from 512 to 65536) (default 8192)
        /// </summary>
        public AfwtdnFilterGen samples(int samples) => this.SetOptionRange("samples", samples, 512, 65536);
        /// <summary>
        ///  set thresholding softness (from 0 to 10) (default 1)
        /// </summary>
        public AfwtdnFilterGen softness(double softness) => this.SetOptionRange("softness", softness, 0, 10);
    }

    /// <summary>
    ///  set wavelet type (from 0 to 6) (default sym10)
    /// </summary>
    public enum AfwtdnFilterGenWavet
    {
        /// <summary>
        /// sym2            0            ..F.A...... sym2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sym2")]
        sym2 = 0,
        /// <summary>
        /// sym4            1            ..F.A...... sym4
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sym4")]
        sym4 = 1,
        /// <summary>
        /// rbior68         2            ..F.A...... rbior68
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rbior68")]
        rbior68 = 2,
        /// <summary>
        /// deb10           3            ..F.A...... deb10
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("deb10")]
        deb10 = 3,
        /// <summary>
        /// sym10           4            ..F.A...... sym10
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sym10")]
        sym10 = 4,
        /// <summary>
        /// coif5           5            ..F.A...... coif5
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("coif5")]
        coif5 = 5,
        /// <summary>
        /// bl3             6            ..F.A...... bl3
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bl3")]
        bl3 = 6
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Denoise audio stream using Wavelets.
        /// </summary>
        public static AfwtdnFilterGen AfwtdnFilterGen(this AudioMap input0) => new AfwtdnFilterGen(input0);
    }
}