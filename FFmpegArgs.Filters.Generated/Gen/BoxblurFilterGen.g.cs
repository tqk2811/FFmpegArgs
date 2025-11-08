namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. boxblur           V-&gt;V       Blur the input.
    /// </summary>
    public class BoxblurFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal BoxblurFilterGen(ImageMap input) : base("boxblur", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Radius of the luma blurring box (default &quot;2&quot;)
        /// </summary>
        public BoxblurFilterGen luma_radius(String luma_radius) => this.SetOption("luma_radius", luma_radius.ToString());
        /// <summary>
        ///  Radius of the luma blurring box (default &quot;2&quot;)
        /// </summary>
        public BoxblurFilterGen lr(String lr) => this.SetOption("lr", lr.ToString());
        /// <summary>
        ///  How many times should the boxblur be applied to luma (from 0 to INT_MAX) (default 2)
        /// </summary>
        public BoxblurFilterGen luma_power(int luma_power) => this.SetOptionRange("luma_power", luma_power, 0, INT_MAX);
        /// <summary>
        ///  How many times should the boxblur be applied to luma (from 0 to INT_MAX) (default 2)
        /// </summary>
        public BoxblurFilterGen lp(int lp) => this.SetOptionRange("lp", lp, 0, INT_MAX);
        /// <summary>
        ///  Radius of the chroma blurring box
        /// </summary>
        public BoxblurFilterGen chroma_radius(String chroma_radius) => this.SetOption("chroma_radius", chroma_radius.ToString());
        /// <summary>
        ///  Radius of the chroma blurring box
        /// </summary>
        public BoxblurFilterGen cr(String cr) => this.SetOption("cr", cr.ToString());
        /// <summary>
        ///  How many times should the boxblur be applied to chroma (from -1 to INT_MAX) (default -1)
        /// </summary>
        public BoxblurFilterGen chroma_power(int chroma_power) => this.SetOptionRange("chroma_power", chroma_power, -1, INT_MAX);
        /// <summary>
        ///  How many times should the boxblur be applied to chroma (from -1 to INT_MAX) (default -1)
        /// </summary>
        public BoxblurFilterGen cp(int cp) => this.SetOptionRange("cp", cp, -1, INT_MAX);
        /// <summary>
        ///  Radius of the alpha blurring box
        /// </summary>
        public BoxblurFilterGen alpha_radius(String alpha_radius) => this.SetOption("alpha_radius", alpha_radius.ToString());
        /// <summary>
        ///  Radius of the alpha blurring box
        /// </summary>
        public BoxblurFilterGen ar(String ar) => this.SetOption("ar", ar.ToString());
        /// <summary>
        ///  How many times should the boxblur be applied to alpha (from -1 to INT_MAX) (default -1)
        /// </summary>
        public BoxblurFilterGen alpha_power(int alpha_power) => this.SetOptionRange("alpha_power", alpha_power, -1, INT_MAX);
        /// <summary>
        ///  How many times should the boxblur be applied to alpha (from -1 to INT_MAX) (default -1)
        /// </summary>
        public BoxblurFilterGen ap(int ap) => this.SetOptionRange("ap", ap, -1, INT_MAX);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Blur the input.
        /// </summary>
        public static BoxblurFilterGen BoxblurFilterGen(this ImageMap input0) => new BoxblurFilterGen(input0);
    }
}