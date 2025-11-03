namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS deconvolve        VV-&gt;V      Deconvolve first video stream with second video stream.
    /// </summary>
    public class DeconvolveFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal DeconvolveFilterGen(params ImageMap[] inputs) : base("deconvolve", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set planes to deconvolve (from 0 to 15) (default 7)
        /// </summary>
        public DeconvolveFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
        /// <summary>
        ///  when to process impulses (from 0 to 1) (default all)
        /// </summary>
        public DeconvolveFilterGen impulse(DeconvolveFilterGenImpulse impulse) => this.SetOption("impulse", impulse.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set noise (from 0 to 1) (default 1e-07)
        /// </summary>
        public DeconvolveFilterGen noise(float noise) => this.SetOptionRange("noise", noise, 0, 1);
    }

    /// <summary>
    ///  when to process impulses (from 0 to 1) (default all)
    /// </summary>
    public enum DeconvolveFilterGenImpulse
    {
        /// <summary>
        /// first           0            ..FV....... process only first impulse, ignore rest
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("first")]
        first = 0,
        /// <summary>
        /// all             1            ..FV....... process all impulses
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("all")]
        all = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Deconvolve first video stream with second video stream.
        /// </summary>
        public static DeconvolveFilterGen DeconvolveFilterGen(this ImageMap input0, ImageMap input1) => new DeconvolveFilterGen(input0, input1);
    }
}