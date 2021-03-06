namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TS. blend             VV->V      Blend two video frames into each other.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#blend-1
    /// </summary>
    public class BlendFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, IFramesync
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "N",
            "X", "Y",
            "W", "H",
            "SW", "SH",
            "T",
            "TOP", "A",
            "BOTTOM", "B"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
        internal BlendFilter(ImageMap top, ImageMap bottom) : base("blend", top, bottom)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set blend mode for specific pixel component or all pixel components in case of all_mode. Default value is normal.
        /// </summary>
        /// <param name="blendMode"></param>
        /// <returns></returns>
        public BlendFilter C0_Mode(BlendMode blendMode)
          => this.SetOption("c0_mode", blendMode);
        /// <summary>
        /// Set blend mode for specific pixel component or all pixel components in case of all_mode. Default value is normal.
        /// </summary>
        /// <param name="blendMode"></param>
        /// <returns></returns>
        public BlendFilter C1_Mode(BlendMode blendMode)
          => this.SetOption("c1_mode", blendMode);
        /// <summary>
        /// Set blend mode for specific pixel component or all pixel components in case of all_mode. Default value is normal.
        /// </summary>
        /// <param name="blendMode"></param>
        /// <returns></returns>
        public BlendFilter C2_Mode(BlendMode blendMode)
          => this.SetOption("c2_mode", blendMode);
        /// <summary>
        /// Set blend mode for specific pixel component or all pixel components in case of all_mode. Default value is normal.
        /// </summary>
        /// <param name="blendMode"></param>
        /// <returns></returns>
        public BlendFilter C3_Mode(BlendMode blendMode)
          => this.SetOption("c3_mode", blendMode);
        /// <summary>
        /// Set blend mode for specific pixel component or all pixel components in case of all_mode. Default value is normal.
        /// </summary>
        /// <param name="blendMode"></param>
        /// <returns></returns>
        public BlendFilter All_Mode(BlendMode blendMode)
          => this.SetOption("all_mode", blendMode);
        /// <summary>
        /// Set blend opacity for specific pixel component or all pixel components in case of all_opacity. Only used in combination with pixel component blend modes.
        /// </summary>
        /// <param name="opacity"></param>
        /// <returns></returns>
        public BlendFilter C0_Opacity(double opacity)
          => this.SetOptionRange("c0_opacity", opacity, 0, 1);
        /// <summary>
        /// Set blend opacity for specific pixel component or all pixel components in case of all_opacity. Only used in combination with pixel component blend modes.
        /// <br></br>(from 0 to 1) (default 1)
        /// </summary>
        /// <param name="opacity"></param>
        /// <returns></returns>
        public BlendFilter C1_Opacity(double opacity)
          => this.SetOptionRange("c1_opacity", opacity, 0, 1);
        /// <summary>
        /// Set blend opacity for specific pixel component or all pixel components in case of all_opacity. Only used in combination with pixel component blend modes.
        /// <br></br>(from 0 to 1) (default 1)
        /// </summary>
        /// <param name="opacity"></param>
        /// <returns></returns>
        public BlendFilter C2_Opacity(double opacity)
          => this.SetOptionRange("c2_opacity", opacity, 0, 1);
        /// <summary>
        /// Set blend opacity for specific pixel component or all pixel components in case of all_opacity. Only used in combination with pixel component blend modes.
        /// <br></br>(from 0 to 1) (default 1)
        /// </summary>
        /// <param name="opacity"></param>
        /// <returns></returns>
        public BlendFilter C3_Opacity(double opacity)
          => this.SetOptionRange("c3_opacity", opacity, 0, 1);
        /// <summary>
        /// Set blend opacity for specific pixel component or all pixel components in case of all_opacity. Only used in combination with pixel component blend modes.
        /// <br></br>(from 0 to 1) (default 1)
        /// </summary>
        /// <param name="opacity"></param>
        /// <returns></returns>
        public BlendFilter All_Opacity(double opacity)
          => this.SetOptionRange("all_opacity", opacity, 0, 1);
        /// <summary>
        /// Set blend expression for specific pixel component or all pixel components in case of all_expr. Note that related mode options will be ignored if those are set.
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        public BlendFilter C0_Expr(Action<FFmpegExpression> expr)
          => this.SetOption("c0_expr", expr.Run(expression));
        /// <summary>
        /// Set blend expression for specific pixel component or all pixel components in case of all_expr. Note that related mode options will be ignored if those are set.
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        public BlendFilter C0_Expr(string expr)
         => C0_Expr(expr.Expression());
        /// <summary>
        /// Set blend expression for specific pixel component or all pixel components in case of all_expr. Note that related mode options will be ignored if those are set.
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        public BlendFilter C1_Expr(Action<FFmpegExpression> expr)
          => this.SetOption("c1_expr", expr.Run(expression));
        /// <summary>
        /// Set blend expression for specific pixel component or all pixel components in case of all_expr. Note that related mode options will be ignored if those are set.
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        public BlendFilter C1_Expr(string expr)
         => C1_Expr(expr.Expression());
        /// <summary>
        /// Set blend expression for specific pixel component or all pixel components in case of all_expr. Note that related mode options will be ignored if those are set.
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        public BlendFilter C2_Expr(Action<FFmpegExpression> expr)
          => this.SetOption("c2_expr", expr.Run(expression));
        /// <summary>
        /// Set blend expression for specific pixel component or all pixel components in case of all_expr. Note that related mode options will be ignored if those are set.
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        public BlendFilter C2_Expr(string expr)
         => C2_Expr(expr.Expression());
        /// <summary>
        /// Set blend expression for specific pixel component or all pixel components in case of all_expr. Note that related mode options will be ignored if those are set.
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        public BlendFilter C3_Expr(Action<FFmpegExpression> expr)
          => this.SetOption("c3_expr", expr.Run(expression));
        /// <summary>
        /// Set blend expression for specific pixel component or all pixel components in case of all_expr. Note that related mode options will be ignored if those are set.
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        public BlendFilter C3_Expr(string expr)
         => C3_Expr(expr.Expression());
        /// <summary>
        /// Set blend expression for specific pixel component or all pixel components in case of all_expr. Note that related mode options will be ignored if those are set.
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        public BlendFilter All_Expr(Action<FFmpegExpression> expr)
          => this.SetOption("all_expr", expr.Run(expression));
        /// <summary>
        /// Set blend expression for specific pixel component or all pixel components in case of all_expr. Note that related mode options will be ignored if those are set.
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        public BlendFilter All_Expr(string expr)
         => All_Expr(expr.Expression());
    }
    public static class BlendFilterExtension
    {
        /// <summary>
        /// Blend two video frames into each other.<br></br>
        /// The blend filter takes two input streams and outputs one stream, the first input is the "top" layer and second input is "bottom" layer.By default, the output terminates when the longest input terminates.<br></br>
        /// The tblend (time blend) filter takes two consecutive frames from one single stream, and outputs the result obtained by blending the new frame on top of the old frame.
        /// </summary>
        /// <param name="top"></param>
        /// <param name="bottom"></param>
        /// <returns></returns>
        public static BlendFilter BlendFilterOn(this ImageMap top, ImageMap bottom)
        {
            return new BlendFilter(top, bottom);
        }
    }
    public enum BlendMode
    {
        addition,
        and,
        average,
        bleach,
        burn,
        darken,
        difference,
        divide,
        dodge,
        exclusion,
        extremity,
        freeze,
        geometric,
        glow,
        grainextract,
        grainmerge,
        hardlight,
        hardmix,
        hardoverlay,
        harmonic,
        heat,
        interpolate,
        lighten,
        linearlight,
        multiply,
        multiply128,
        negation,
        normal,
        or,
        overlay,
        phoenix,
        pinlight,
        reflect,
        screen,
        softdifference,
        softlight,
        stain,
        subtract,
        vividlight,
        xor
    }
}
