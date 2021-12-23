using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC rotate            V->V       Rotate the input image.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#rotate 
    /// </summary>
    public class RotateFilter : ImageToImageFilter, ICommandSupport, ITimelineSupport, ISliceThreading
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "n", "t",
            "hsub","vsub",
            "in_w", "iw",
            "in_h","ih",
            "out_w", "ow",
            "out_h", "oh"
        };
        static readonly IEnumerable<ShuntingYardFunction> _func = new List<ShuntingYardFunction>()
        {
            new ShuntingYardFunction("rotw","rotw_1"),
            new ShuntingYardFunction("roth","roth_1"),
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables, _func);

        internal RotateFilter(ImageMap imageMap) : base("rotate", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set an expression for the angle by which to rotate the input video clockwise, expressed as a number of radians. A negative value will result in a counter-clockwise rotation. By default it is set to "0".<br>
        /// </br>This expression is evaluated for each frame.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public RotateFilter Angle(string a)
            => Angle(a.Expression());

        /// <summary>
        /// Set an expression for the angle by which to rotate the input video clockwise, expressed as a number of radians. A negative value will result in a counter-clockwise rotation. By default it is set to "0".<br>
        /// </br>This expression is evaluated for each frame.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public RotateFilter Angle(Action<FFmpegExpression> a)
            => this.SetOption("a", a.Run(expression));

        /// <summary>
        /// Set the output width expression, default value is "iw". This expression is evaluated just once during configuration.
        /// </summary>
        /// <param name="ow"></param>
        /// <returns></returns>
        public RotateFilter OW(string ow)
            => OW(ow.Expression());
        /// <summary>
        /// Set the output width expression, default value is "iw". This expression is evaluated just once during configuration.
        /// </summary>
        /// <param name="ow"></param>
        /// <returns></returns>
        public RotateFilter OW(Action<FFmpegExpression> ow)
            => this.SetOption("ow", ow.Run(expression));
        /// <summary>
        /// Set the output height expression, default value is "ih". This expression is evaluated just once during configuration.
        /// </summary>
        /// <param name="oh"></param>
        /// <returns></returns>
        public RotateFilter OH(string oh)
            => OH(oh.Expression());
        /// <summary>
        /// /Set the output height expression, default value is "ih". This expression is evaluated just once during configuration.
        /// </summary>
        /// <param name="oh"></param>
        /// <returns></returns>
        public RotateFilter OH(Action<FFmpegExpression> oh)
            => this.SetOption("oh", oh.Run(expression));

        public RotateFilter OutWH(string ow, string oh)
          => OutWH(ow.Expression(), oh.Expression());
        public RotateFilter OutWH(Action<FFmpegExpression> ow, Action<FFmpegExpression> oh)
          => this.SetOption("ow", ow.Run(expression)).SetOption("oh", oh.Run(expression));

        /// <summary>
        /// Enable bilinear interpolation if set to 1, a value of 0 disables it. Default value is 1.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public RotateFilter Bilinear(bool flag)
          => this.SetOption("bilinear", flag.ToFFmpegFlag());

        /// <summary>
        /// Set the color used to fill the output area not covered by the rotated image. If the special value "none" is selected then no background is printed (useful for example if the background is never shown).
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public RotateFilter FillColor(Color color)
           => this.SetOption("c", color.ToHexStringRGBA());
    }

    public static class RotateFilterExtension
    {
        /// <summary>
        /// Rotate video by an arbitrary angle expressed in radians.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static RotateFilter RotateFilter(this ImageMap imageMap)
            => new RotateFilter(imageMap);

        /// <summary>
        /// Rotate video by an arbitrary angle expressed in radians.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="angle">Set an expression for the angle by which to rotate the input video clockwise, expressed as a number of radians. A negative value will result in a counter-clockwise rotation. By default it is set to "0".<br>
        /// </br>This expression is evaluated for each frame.</param>
        /// <returns></returns>
        public static RotateFilter RotateFilter(this ImageMap imageMap, string angle)
            => new RotateFilter(imageMap).Angle(angle);

        /// <summary>
        /// Rotate video by an arbitrary angle expressed in radians.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="angle">Set an expression for the angle by which to rotate the input video clockwise, expressed as a number of radians. A negative value will result in a counter-clockwise rotation. By default it is set to "0".<br>
        /// </br>This expression is evaluated for each frame.</param>
        /// <returns></returns>
        public static RotateFilter RotateFilter(this ImageMap imageMap, Action<FFmpegExpression> angle)
            => new RotateFilter(imageMap).Angle(angle);
    }
}
