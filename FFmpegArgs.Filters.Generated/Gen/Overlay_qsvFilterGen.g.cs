namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. overlay_qsv       VV-&gt;V      Quick Sync Video overlay.
    /// </summary>
    public class Overlay_qsvFilterGen : ImageToImageFilter
    {
        internal Overlay_qsvFilterGen(params ImageMap[] inputs) : base("overlay_qsv", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Overlay x position (default &quot;0&quot;)
        /// </summary>
        public Overlay_qsvFilterGen x(String x) => this.SetOption("x", x.ToString());
        /// <summary>
        ///  Overlay y position (default &quot;0&quot;)
        /// </summary>
        public Overlay_qsvFilterGen y(String y) => this.SetOption("y", y.ToString());
        /// <summary>
        ///  Overlay width (default &quot;overlay_iw&quot;)
        /// </summary>
        public Overlay_qsvFilterGen w(String w) => this.SetOption("w", w.ToString());
        /// <summary>
        ///  Overlay height (default &quot;overlay_ih*w/overlay_iw&quot;)
        /// </summary>
        public Overlay_qsvFilterGen h(String h) => this.SetOption("h", h.ToString());
        /// <summary>
        ///  Overlay global alpha (from 0 to 255) (default 255)
        /// </summary>
        public Overlay_qsvFilterGen alpha(int alpha) => this.SetOptionRange("alpha", alpha, 0, 255);
        /// <summary>
        ///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
        /// </summary>
        public Overlay_qsvFilterGen eof_action(Overlay_qsvFilterGenEof_action eof_action) => this.SetOption("eof_action", eof_action.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  force termination when the shortest input terminates (default false)
        /// </summary>
        public Overlay_qsvFilterGen shortest(bool shortest) => this.SetOption("shortest", shortest.ToFFmpegFlag());
        /// <summary>
        ///  repeat overlay of the last overlay frame (default true)
        /// </summary>
        public Overlay_qsvFilterGen repeatlast(bool repeatlast) => this.SetOption("repeatlast", repeatlast.ToFFmpegFlag());
    }

    /// <summary>
    ///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
    /// </summary>
    public enum Overlay_qsvFilterGenEof_action
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
        /// Quick Sync Video overlay.
        /// </summary>
        public static Overlay_qsvFilterGen Overlay_qsvFilterGen(this ImageMap input0, ImageMap input1) => new Overlay_qsvFilterGen(input0, input1);
    }
}