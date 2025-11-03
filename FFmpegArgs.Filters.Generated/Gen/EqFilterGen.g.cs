namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. eq                V-&gt;V       Adjust brightness, contrast, gamma, and saturation.
    /// </summary>
    public class EqFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal EqFilterGen(ImageMap input) : base("eq", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the contrast adjustment, negative values give a negative image (default &quot;1.0&quot;)
        /// </summary>
        public EqFilterGen contrast(String contrast) => this.SetOption("contrast", contrast.ToStringInv());
        /// <summary>
        ///  set the brightness adjustment (default &quot;0.0&quot;)
        /// </summary>
        public EqFilterGen brightness(String brightness) => this.SetOption("brightness", brightness.ToStringInv());
        /// <summary>
        ///  set the saturation adjustment (default &quot;1.0&quot;)
        /// </summary>
        public EqFilterGen saturation(String saturation) => this.SetOption("saturation", saturation.ToStringInv());
        /// <summary>
        ///  set the initial gamma value (default &quot;1.0&quot;)
        /// </summary>
        public EqFilterGen gamma(String gamma) => this.SetOption("gamma", gamma.ToStringInv());
        /// <summary>
        ///  gamma value for red (default &quot;1.0&quot;)
        /// </summary>
        public EqFilterGen gamma_r(String gamma_r) => this.SetOption("gamma_r", gamma_r.ToStringInv());
        /// <summary>
        ///  gamma value for green (default &quot;1.0&quot;)
        /// </summary>
        public EqFilterGen gamma_g(String gamma_g) => this.SetOption("gamma_g", gamma_g.ToStringInv());
        /// <summary>
        ///  gamma value for blue (default &quot;1.0&quot;)
        /// </summary>
        public EqFilterGen gamma_b(String gamma_b) => this.SetOption("gamma_b", gamma_b.ToStringInv());
        /// <summary>
        ///  set the gamma weight which reduces the effect of gamma on bright areas (default &quot;1.0&quot;)
        /// </summary>
        public EqFilterGen gamma_weight(String gamma_weight) => this.SetOption("gamma_weight", gamma_weight.ToStringInv());
        /// <summary>
        ///  specify when to evaluate expressions (from 0 to 1) (default init)
        /// </summary>
        public EqFilterGen eval(EqFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  specify when to evaluate expressions (from 0 to 1) (default init)
    /// </summary>
    public enum EqFilterGenEval
    {
        /// <summary>
        /// init            0            ..FV....... eval expressions once during initialization
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("init")]
        init = 0,
        /// <summary>
        /// frame           1            ..FV....... eval expressions per-frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("frame")]
        frame = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Adjust brightness, contrast, gamma, and saturation.
        /// </summary>
        public static EqFilterGen EqFilterGen(this ImageMap input0) => new EqFilterGen(input0);
    }
}