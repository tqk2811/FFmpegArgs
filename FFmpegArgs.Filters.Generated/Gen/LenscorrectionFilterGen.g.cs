namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS lenscorrection    V-&gt;V       Rectify the image by correcting for lens distortion.
    /// </summary>
    public class LenscorrectionFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal LenscorrectionFilterGen(ImageMap input) : base("lenscorrection", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set relative center x (from 0 to 1) (default 0.5)
        /// </summary>
        public LenscorrectionFilterGen cx(double cx) => this.SetOptionRange("cx", cx, 0, 1);
        /// <summary>
        ///  set relative center y (from 0 to 1) (default 0.5)
        /// </summary>
        public LenscorrectionFilterGen cy(double cy) => this.SetOptionRange("cy", cy, 0, 1);
        /// <summary>
        ///  set quadratic distortion factor (from -1 to 1) (default 0)
        /// </summary>
        public LenscorrectionFilterGen k1(double k1) => this.SetOptionRange("k1", k1, -1, 1);
        /// <summary>
        ///  set double quadratic distortion factor (from -1 to 1) (default 0)
        /// </summary>
        public LenscorrectionFilterGen k2(double k2) => this.SetOptionRange("k2", k2, -1, 1);
        /// <summary>
        ///  set interpolation type (from 0 to 64) (default nearest)
        /// </summary>
        public LenscorrectionFilterGen i(LenscorrectionFilterGenI i) => this.SetOption("i", i.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the color of the unmapped pixels (default &quot;black@0&quot;)
        /// </summary>
        public LenscorrectionFilterGen fc(Color fc) => this.SetOption("fc", fc.ToHexStringRGBA());
    }

    /// <summary>
    ///  set interpolation type (from 0 to 64) (default nearest)
    /// </summary>
    public enum LenscorrectionFilterGenI
    {
        /// <summary>
        /// nearest         0            ..FV.....T. nearest neighbour
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nearest")]
        nearest = 0,
        /// <summary>
        /// bilinear        1            ..FV.....T. bilinear
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bilinear")]
        bilinear = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Rectify the image by correcting for lens distortion.
        /// </summary>
        public static LenscorrectionFilterGen LenscorrectionFilterGen(this ImageMap input0) => new LenscorrectionFilterGen(input0);
    }
}