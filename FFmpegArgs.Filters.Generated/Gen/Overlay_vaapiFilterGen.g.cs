namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... overlay_vaapi     VV-&gt;V      Overlay one video on top of another
    /// </summary>
    public class Overlay_vaapiFilterGen : ImageToImageFilter
    {
        internal Overlay_vaapiFilterGen(params ImageMap[] inputs) : base("overlay_vaapi", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Overlay x position (default &quot;0&quot;)
        /// </summary>
        public Overlay_vaapiFilterGen x(String x) => this.SetOption("x", x.ToString());
        /// <summary>
        ///  Overlay y position (default &quot;0&quot;)
        /// </summary>
        public Overlay_vaapiFilterGen y(String y) => this.SetOption("y", y.ToString());
        /// <summary>
        ///  Overlay width (default &quot;overlay_iw&quot;)
        /// </summary>
        public Overlay_vaapiFilterGen w(String w) => this.SetOption("w", w.ToString());
        /// <summary>
        ///  Overlay height (default &quot;overlay_ih*w/overlay_iw&quot;)
        /// </summary>
        public Overlay_vaapiFilterGen h(String h) => this.SetOption("h", h.ToString());
        /// <summary>
        ///  Overlay global alpha (from 0 to 1) (default 1)
        /// </summary>
        public Overlay_vaapiFilterGen alpha(float alpha) => this.SetOptionRange("alpha", alpha, 0, 1);
        /// <summary>
        ///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
        /// </summary>
        public Overlay_vaapiFilterGen eof_action(Overlay_vaapiFilterGenEof_action eof_action) => this.SetOption("eof_action", eof_action.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  force termination when the shortest input terminates (default false)
        /// </summary>
        public Overlay_vaapiFilterGen shortest(bool shortest) => this.SetOption("shortest", shortest.ToFFmpegFlag());
        /// <summary>
        ///  repeat overlay of the last overlay frame (default true)
        /// </summary>
        public Overlay_vaapiFilterGen repeatlast(bool repeatlast) => this.SetOption("repeatlast", repeatlast.ToFFmpegFlag());
    }

    /// <summary>
    ///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
    /// </summary>
    public enum Overlay_vaapiFilterGenEof_action
    {
        /// <summary>
        /// repeat          0            ..FV....... Repeat the previous frame.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("repeat")]
        repeat = 0,
        /// <summary>
        /// endall          1            ..FV....... End both streams.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("endall")]
        endall = 1,
        /// <summary>
        /// pass            2            ..FV....... Pass through the main input.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pass")]
        pass = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Overlay one video on top of another
        /// </summary>
        public static Overlay_vaapiFilterGen Overlay_vaapiFilterGen(this ImageMap input0, ImageMap input1) => new Overlay_vaapiFilterGen(input0, input1);
    }
}