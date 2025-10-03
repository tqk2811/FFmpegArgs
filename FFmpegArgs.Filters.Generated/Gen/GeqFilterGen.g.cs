﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS. geq               V-&gt;V       Apply generic equation to each pixel.
    /// </summary>
    public class GeqFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal GeqFilterGen(ImageMap input) : base("geq", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set luminance expression
        /// </summary>
        public GeqFilterGen lum_expr(ExpressionValue lum_expr) => this.SetOption("lum_expr", (string)lum_expr);
        /// <summary>
        ///  set chroma blue expression
        /// </summary>
        public GeqFilterGen cb_expr(ExpressionValue cb_expr) => this.SetOption("cb_expr", (string)cb_expr);
        /// <summary>
        ///  set chroma red expression
        /// </summary>
        public GeqFilterGen cr_expr(ExpressionValue cr_expr) => this.SetOption("cr_expr", (string)cr_expr);
        /// <summary>
        ///  set alpha expression
        /// </summary>
        public GeqFilterGen alpha_expr(ExpressionValue alpha_expr) => this.SetOption("alpha_expr", (string)alpha_expr);
        /// <summary>
        ///  set red expression
        /// </summary>
        public GeqFilterGen red_expr(ExpressionValue red_expr) => this.SetOption("red_expr", (string)red_expr);
        /// <summary>
        ///  set green expression
        /// </summary>
        public GeqFilterGen green_expr(ExpressionValue green_expr) => this.SetOption("green_expr", (string)green_expr);
        /// <summary>
        ///  set blue expression
        /// </summary>
        public GeqFilterGen blue_expr(ExpressionValue blue_expr) => this.SetOption("blue_expr", (string)blue_expr);
        /// <summary>
        ///  set interpolation method (from 0 to 1) (default bilinear)
        /// </summary>
        public GeqFilterGen interpolation(GeqFilterGenInterpolation interpolation) => this.SetOption("interpolation", interpolation.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set interpolation method (from 0 to 1) (default bilinear)
    /// </summary>
    public enum GeqFilterGenInterpolation
    {
        /// <summary>
        /// nearest         0            ..FV....... nearest interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nearest")]
        nearest = 0,
        /// <summary>
        /// n               0            ..FV....... nearest interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("n")]
        n = 0,
        /// <summary>
        /// bilinear        1            ..FV....... bilinear interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bilinear")]
        bilinear = 1,
        /// <summary>
        /// b               1            ..FV....... bilinear interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("b")]
        b = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply generic equation to each pixel.
        /// </summary>
        public static GeqFilterGen GeqFilterGen(this ImageMap input0) => new GeqFilterGen(input0);
    }
}