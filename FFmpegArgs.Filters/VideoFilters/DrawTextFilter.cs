using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// T.C drawtext          V->V       Draw text on top of video frames using libfreetype library.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#drawtext-1 
    /// </summary>
    public class DrawTextFilter : ImageToImageFilter, ITimelineSupport, ICommandSupport
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "dar",
            "hsub", "vsub",
            "line_h", "lh",
            "main_h", "h", "H",
            "main_w", "w", "W",
            "max_glyph_a, ascent",
            "max_glyph_d, descent",
            "max_glyph_h", "max_glyph_w",
            "n", "sar", "t",
            "text_h", "th",
            "text_w", "tw",
            "x", "y",
            "pict_type",
            "pkt_pos",
            "pkt_duration",
            "pkt_size"
        };

        readonly Expression expression = new Expression(_variables);
        internal DrawTextFilter(string text, ImageMap imageMap) : base("drawtext", imageMap)
        {
            AddMapOut();
            this.SetOption("text", text);
        }

        /// <summary>
        /// Used to draw a box around text using the background color. The value must be either 1 (enable) or 0 (disable). The default value of box is 0.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public DrawTextFilter Box(bool flag)
            => this.SetOption("box", flag.ToFFmpegFlag());

        /// <summary>
        /// Set the width of the border to be drawn around the box using boxcolor. (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        /// <param name="boxborderw"></param>
        /// <returns></returns>
        public DrawTextFilter Boxborderw(int boxborderw)
            => this.SetOption("boxborderw", boxborderw);

        /// <summary>
        /// /he color to be used for drawing box around text
        /// </summary>
        /// <param name="boxcolor"></param>
        /// <returns></returns>
        public DrawTextFilter Boxcolor(Color boxcolor)
            => this.SetOption("boxcolor", boxcolor.ToHexStringRGBA());

        /// <summary>
        /// Set the line spacing in pixels of the border to be drawn around the box using box. (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        /// <param name="line_spacing"></param>
        /// <returns></returns>
        public DrawTextFilter LineSpacing(int line_spacing)
            => this.SetOption("line_spacing", line_spacing);

        /// <summary>
        /// Set the width of the border to be drawn around the text using bordercolor. (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        /// <param name="borderw"></param>
        /// <returns></returns>
        public DrawTextFilter Borderw(int borderw)
            => this.SetOption("borderw", borderw);

        /// <summary>
        /// Set the color to be used for drawing border around text.
        /// </summary>
        /// <param name="bordercolor"></param>
        /// <returns></returns>
        public DrawTextFilter Bordercolor(Color bordercolor)
            => this.SetOption("bordercolor", bordercolor.ToHexStringRGBA());

        /// <summary>
        /// Select how the text is expanded. Can be either none, strftime (deprecated) or normal (default). See the Text expansion section below for details.
        /// </summary>
        /// <param name="expansion"></param>
        /// <returns></returns>
        public DrawTextFilter Expansion(DrawTextExpansion expansion)
            => this.SetOption("expansion", expansion);

        /// <summary>
        /// Set a start time for the count. Value is in microseconds. Only applied in the deprecated strftime expansion mode. To emulate in normal expansion mode use the pts function, supplying the start time (in seconds) as the second argument.<br>
        /// </br>(from I64_MIN to I64_MAX) (default I64_MIN)
        /// </summary>
        /// <param name="basetime"></param>
        /// <returns></returns>
        public DrawTextFilter Basetime(long basetime)
            => this.SetOptionRange("basetime", basetime, long.MinValue, long.MaxValue);

        /// <summary>
        /// If true, check and fix text coords to avoid clipping.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public DrawTextFilter FixBounds(bool flag)
            => this.SetOption("fix_bounds", flag.ToFFmpegFlag());

        /// <summary>
        /// The color to be used for drawing fonts
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public DrawTextFilter FontColor(Color color)
          => this.SetOption("fontcolor", color.ToHexStringRGB());

        /// <summary>
        /// String which is expanded the same way as text to obtain dynamic fontcolor value. By default this option has empty value and is not processed. When this option is set, it overrides fontcolor option.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public DrawTextFilter FontColorExpr(string color)
          => FontColorExpr(color.Expression());

        /// <summary>
        /// String which is expanded the same way as text to obtain dynamic fontcolor value. By default this option has empty value and is not processed. When this option is set, it overrides fontcolor option.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public DrawTextFilter FontColorExpr(Action<Expression> color)
          => this.SetOption("fontcolor_expr", color.Run(expression));

        /// <summary>
        /// The font family to be used for drawing text. By default Sans.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DrawTextFilter Font(string name)
          => this.SetOption("font", name);

        /// <summary>
        /// The font file to be used for drawing text. The path must be included. This parameter is mandatory if the fontconfig support is disabled.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public DrawTextFilter FontFile(string path)
          => this.SetOption("fontfile", path);

        /// <summary>
        /// Draw the text applying alpha blending. The value can be a number between 0.0 and 1.0. The expression accepts the same variables x, y as well. The default value is 1. Please see fontcolor_expr.
        /// </summary>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public DrawTextFilter Alpha(float alpha)
            => this.SetOptionRange("alpha", alpha, 0, 1);

        /// <summary>
        /// The font size to be used for drawing text. The default value of fontsize is 16.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public DrawTextFilter FontSize(int size)
            => this.SetOptionRange("fontsize", size, 0, int.MaxValue);

        /// <summary>
        /// If set to 1, attempt to shape the text (for example, reverse the order of right-to-left text and join Arabic characters) before drawing it. Otherwise, just draw the text exactly as given. By default 1 (if supported).
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public DrawTextFilter TextShaping(bool flag)
            => this.SetOption("text_shaping", flag.ToFFmpegFlag());

        /// <summary>
        /// The flags to be used for loading the fonts.<br>
        /// </br>The flags map the corresponding flags supported by libfreetype
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public DrawTextFilter FtLoadFlags(DrawTextFtLoadFlags flag)
            => this.SetOption("ft_load_flags", flag.GetAttribute<NameAttribute>().Name);

        /// <summary>
        /// The color to be used for drawing a shadow behind the drawn text.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public DrawTextFilter Shadowcolor(Color color)
          => this.SetOption("shadowcolor", color.ToHexStringRGB());

        /// <summary>
        /// The x and y offsets for the text shadow position with respect to the position of the text. They can be either positive or negative values. The default value for both is "0". (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public DrawTextFilter ShadowXY(int x, int y)
            => this.SetOptionRange("x", x, INT_MIN, INT_MAX).SetOptionRange("y", y, INT_MIN, INT_MAX);

        /// <summary>
        /// The starting frame number for the n/frame_num variable. (from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="start_number"></param>
        /// <returns></returns>
        public DrawTextFilter StartNumber(int start_number)
            => this.SetOptionRange("start_number", start_number, 0, INT_MAX);

        /// <summary>
        /// The size in number of spaces to use for rendering the tab. (from 0 to INT_MAX) (default 4)
        /// </summary>
        /// <returns></returns>
        public DrawTextFilter TabSize(int tabsize)
            => this.SetOptionRange("tabsize", tabsize, 0, INT_MAX);

        /// <summary>
        /// Set the initial timecode representation in "hh:mm:ss[:;.]ff" format. It can be used with or without text parameter. timecode_rate option must be specified.
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public DrawTextFilter TimeCode(TimeSpan time)
            => this.SetOption("timecode", time.ToString("hh\\:mm\\:ss\\.fff"));

        /// <summary>
        /// Set the timecode frame rate (timecode only). Value will be rounded to nearest integer. Minimum value is "1". Drop-frame timecode is supported for frame rates 30 & 60.
        /// </summary>
        /// <param name="rational"></param>
        /// <returns></returns>
        public DrawTextFilter TimeCodeRate(Rational rational)
            => this.SetOption("timecode_rate", rational.Check(0, INT_MAX));

        /// <summary>
        /// If set to 1, the output of the timecode option will wrap around at 24 hours. Default is 0 (disabled).
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public DrawTextFilter Tc24hMax(bool flag)
            => this.SetOption("tc24hmax", flag.ToFFmpegFlag());

        /// <summary>
        /// The expressions which specify the offsets where text will be drawn within the video frame. They are relative to the top/left border of the output image.<br>
        /// </br>The default value of x and y is "0".
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public DrawTextFilter Pos(Action<Expression> x, Action<Expression> y)
          => this.SetOption("x", x.Run(expression)).SetOption("y", y.Run(expression));
        /// <summary>
        /// The expressions which specify the offsets where text will be drawn within the video frame. They are relative to the top/left border of the output image.<br>
        /// </br>The default value of x and y is "0".
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public DrawTextFilter Pos(string x, string y)
          => Pos(x.Expression(), y.Expression());
    }

    public static class DrawTextFilterExtension
    {
        /// <summary>
        /// Draw a text string or text from a specified file on top of a video, using the libfreetype library.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DrawTextFilter DrawTextFilter(this ImageMap imageMap, string text)
            => new DrawTextFilter(text, imageMap);
    }

    public enum DrawTextExpansion
    {
        none,
        [Obsolete]
        strftime,
        normal
    }

    public enum DrawTextFtLoadFlags
    {
        [Name("default")] _default,
        [Name("no_scale")] no_scale,
        [Name("no_hinting")] no_hinting,
        [Name("render")] render,
        [Name("no_bitmap")] no_bitmap,
        [Name("vertical_layout")] vertical_layout,
        [Name("force_autohint")] force_autohint,
        [Name("crop_bitmap")] crop_bitmap,
        [Name("pedantic")] pedantic,
        [Name("ignore_global_advance_width")] ignore_global_advance_width,
        [Name("no_recurse")] no_recurse,
        [Name("ignore_transform")] ignore_transform,
        [Name("monochrome")] monochrome,
        [Name("linear_design")] linear_design,
        [Name("no_autohint")] no_autohint,
    }
}
