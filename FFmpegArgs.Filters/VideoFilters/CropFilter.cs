using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ..C crop              V->V       Crop the input video.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#crop
    /// </summary>
    public class CropFilter : ImageToImageFilter, ICommandSupport
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "x", "y",
            "in_w","in_h", "iw", "ih",
            "out_w","out_h", "ow", "oh",
            "a", "sar", "dar", "hsub", "vsub",
            "n", "pos", "t"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);

        internal CropFilter(ImageMap imageMap) : base("crop", imageMap)
        {
            AddMapOut();
        }

        internal CropFilter(ImageMap imageMap,
            Action<FFmpegExpression> x, Action<FFmpegExpression> y,
            Action<FFmpegExpression> w, Action<FFmpegExpression> h) : this(imageMap)
        {
            this.SetOption("x", x.Run(expression));
            this.SetOption("y", y.Run(expression));
            this.SetOption("w", w.Run(expression));
            this.SetOption("h", h.Run(expression));
        }

        /// <summary>
        /// The horizontal position, in the input video, of the left edge of the output video. It defaults to (in_w-out_w)/2. This expression is evaluated per-frame.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public CropFilter X(Action<FFmpegExpression> x) => this.SetOption("x", x.Run(expression));
        /// <summary>
        /// The horizontal position, in the input video, of the left edge of the output video. It defaults to (in_w-out_w)/2. This expression is evaluated per-frame.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public CropFilter X(string x) => X(x.Expression());

        /// <summary>
        /// The vertical position, in the input video, of the top edge of the output video. It defaults to (in_h-out_h)/2. This expression is evaluated per-frame.
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public CropFilter Y(Action<FFmpegExpression> y) => this.SetOption("y", y.Run(expression));
        /// <summary>
        /// The vertical position, in the input video, of the top edge of the output video. It defaults to (in_h-out_h)/2. This expression is evaluated per-frame.
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public CropFilter Y(string y) => Y(y.Expression());

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The horizontal position, in the input video, of the left edge of the output video. It defaults to (in_w-out_w)/2. This expression is evaluated per-frame.</param>
        /// <param name="y">The vertical position, in the input video, of the top edge of the output video. It defaults to (in_h-out_h)/2. This expression is evaluated per-frame.</param>
        /// <returns></returns>
        public CropFilter XY(string x, string y) => X(x).Y(y);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The horizontal position, in the input video, of the left edge of the output video. It defaults to (in_w-out_w)/2. This expression is evaluated per-frame.</param>
        /// <param name="y">The vertical position, in the input video, of the top edge of the output video. It defaults to (in_h-out_h)/2. This expression is evaluated per-frame.</param>
        /// <returns></returns>
        public CropFilter XY(Action<FFmpegExpression> x, Action<FFmpegExpression> y) => X(x).Y(y);


        /// <summary>
        /// The width of the output video. It defaults to iw. This expression is evaluated only once during the filter configuration, or when the ‘w’ or ‘out_w’ command is sent.
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public CropFilter W(Action<FFmpegExpression> w) => this.SetOption("w", w.Run(expression));
        /// <summary>
        /// The width of the output video. It defaults to iw. This expression is evaluated only once during the filter configuration, or when the ‘w’ or ‘out_w’ command is sent.
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public CropFilter W(string w) => W(w.Expression());

        /// <summary>
        /// The height of the output video. It defaults to ih. This expression is evaluated only once during the filter configuration, or when the ‘h’ or ‘out_h’ command is sent.
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public CropFilter H(Action<FFmpegExpression> h) => this.SetOption("h", h.Run(expression));
        /// <summary>
        /// The height of the output video. It defaults to ih. This expression is evaluated only once during the filter configuration, or when the ‘h’ or ‘out_h’ command is sent.
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public CropFilter H(string h) => H(h.Expression());

        /// <summary>
        /// 
        /// </summary>
        /// <param name="w">The width of the output video. It defaults to iw. This expression is evaluated only once during the filter configuration, or when the ‘w’ or ‘out_w’ command is sent.</param>
        /// <param name="h">The height of the output video. It defaults to ih. This expression is evaluated only once during the filter configuration, or when the ‘h’ or ‘out_h’ command is sent.</param>
        /// <returns></returns>
        public CropFilter WH(string w, string h) => W(w).H(h);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w">The width of the output video. It defaults to iw. This expression is evaluated only once during the filter configuration, or when the ‘w’ or ‘out_w’ command is sent.</param>
        /// <param name="h">The height of the output video. It defaults to ih. This expression is evaluated only once during the filter configuration, or when the ‘h’ or ‘out_h’ command is sent.</param>
        /// <returns></returns>
        public CropFilter WH(Action<FFmpegExpression> w, Action<FFmpegExpression> h) => W(w).H(h);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The horizontal position, in the input video, of the left edge of the output video. It defaults to (in_w-out_w)/2. This expression is evaluated per-frame.</param>
        /// <param name="y">The vertical position, in the input video, of the top edge of the output video. It defaults to (in_h-out_h)/2. This expression is evaluated per-frame.</param>
        /// <param name="w">The width of the output video. It defaults to iw. This expression is evaluated only once during the filter configuration, or when the ‘w’ or ‘out_w’ command is sent.</param>
        /// <param name="h">The height of the output video. It defaults to ih. This expression is evaluated only once during the filter configuration, or when the ‘h’ or ‘out_h’ command is sent.</param>
        /// <returns></returns>
        public CropFilter XYWH(string x, string y, string w, string h) => X(x).Y(y).W(w).H(h);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The horizontal position, in the input video, of the left edge of the output video. It defaults to (in_w-out_w)/2. This expression is evaluated per-frame.</param>
        /// <param name="y">The vertical position, in the input video, of the top edge of the output video. It defaults to (in_h-out_h)/2. This expression is evaluated per-frame.</param>
        /// <param name="w">The width of the output video. It defaults to iw. This expression is evaluated only once during the filter configuration, or when the ‘w’ or ‘out_w’ command is sent.</param>
        /// <param name="h">The height of the output video. It defaults to ih. This expression is evaluated only once during the filter configuration, or when the ‘h’ or ‘out_h’ command is sent.</param>
        /// <returns></returns>
        public CropFilter XYWH(Action<FFmpegExpression> x, Action<FFmpegExpression> y, Action<FFmpegExpression> w, Action<FFmpegExpression> h) => X(x).Y(y).W(w).H(h);


        /// <summary>
        /// If set to 1 will force the output display aspect ratio to be the same of the input, by changing the output sample aspect ratio. It defaults to 0.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public CropFilter KeepAspect(bool flag) => this.SetOption("keep_aspect", flag.ToFFmpegFlag());

        /// <summary>
        /// Enable exact cropping. If enabled, subsampled videos will be cropped at exact width/height/x/y as specified and will not be rounded to nearest smaller value. It defaults to 0.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public CropFilter Exact(bool flag) => this.SetOption("exact", flag.ToFFmpegFlag());
    }

    public static class CropFilterExtension
    {
        /// <summary>
        /// Crop the input video to given dimensions.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static CropFilter CropFilter(this ImageMap imageMap)
            => new CropFilter(imageMap);

        /// <summary>
        /// Crop the input video to given dimensions.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="x">The horizontal position, in the input video, of the left edge of the output video. It defaults to (in_w-out_w)/2. This expression is evaluated per-frame.</param>
        /// <param name="y">The vertical position, in the input video, of the top edge of the output video. It defaults to (in_h-out_h)/2. This expression is evaluated per-frame.</param>
        /// <param name="w">The width of the output video. It defaults to iw. This expression is evaluated only once during the filter configuration, or when the ‘w’ or ‘out_w’ command is sent.</param>
        /// <param name="h">The height of the output video. It defaults to ih. This expression is evaluated only once during the filter configuration, or when the ‘h’ or ‘out_h’ command is sent.</param>
        /// <returns></returns>
        public static CropFilter CropFilter(this ImageMap imageMap,
            Action<FFmpegExpression> x, Action<FFmpegExpression> y,
            Action<FFmpegExpression> w, Action<FFmpegExpression> h)
            => new CropFilter(imageMap, x, y, w, h);

        /// <summary>
        /// Crop the input video to given dimensions.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="x">The horizontal position, in the input video, of the left edge of the output video. It defaults to (in_w-out_w)/2. This expression is evaluated per-frame.</param>
        /// <param name="y">The vertical position, in the input video, of the top edge of the output video. It defaults to (in_h-out_h)/2. This expression is evaluated per-frame.</param>
        /// <param name="w">The width of the output video. It defaults to iw. This expression is evaluated only once during the filter configuration, or when the ‘w’ or ‘out_w’ command is sent.</param>
        /// <param name="h">The height of the output video. It defaults to ih. This expression is evaluated only once during the filter configuration, or when the ‘h’ or ‘out_h’ command is sent.</param>
        /// <returns></returns>
        public static CropFilter CropFilter(this ImageMap imageMap,
            string x, string y,
            string w, string h)
            => new CropFilter(imageMap, x.Expression(), y.Expression(), w.Expression(), h.Expression());
    }
}
