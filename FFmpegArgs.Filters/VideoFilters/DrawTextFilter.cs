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
        internal DrawTextFilter(ImageMap imageMap) : base("drawtext", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// The text string to be drawn. The text must be a sequence of UTF-8 encoded characters. This parameter is mandatory if no file is specified with the parameter textfile.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public DrawTextFilter Text(string text)
            => this.SetOption("text", text);


        /// <summary>
        /// A text file containing text to be drawn. The text must be a sequence of UTF-8 encoded characters.<br>
        /// </br>This parameter is mandatory if no text string is specified with the parameter text.<br>
        /// </br>If both text and textfile are specified, an error is thrown.
        /// </summary>
        /// <param name="textFile"></param>
        /// <returns></returns>
        public DrawTextFilter TextFile(string textFile)
            => this.SetOption("textfile", textFile);


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
        public DrawTextFilter Alpha(string alpha)
            => this.SetOption("alpha", alpha);

        /// <summary>
        /// The font size to be used for drawing text. The default value of fontsize is 16.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public DrawTextFilter FontSize(string size)
            => this.SetOption("fontsize", size);

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
        public DrawTextFilter ShadowX(int x)
           => this.SetOptionRange("x", x, INT_MIN, INT_MAX);

        /// <summary>
        /// The x and y offsets for the text shadow position with respect to the position of the text. They can be either positive or negative values. The default value for both is "0". (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public DrawTextFilter ShadowY(int y)
          => this.SetOptionRange("y", y, INT_MIN, INT_MAX);

        /// <summary>
        /// The x and y offsets for the text shadow position with respect to the position of the text. They can be either positive or negative values. The default value for both is "0". (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public DrawTextFilter ShadowXY(int x, int y)
            => this.ShadowX(x).ShadowY(y);

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
        public DrawTextFilter TimeCode(string timeCode)
            => this.SetOption("timecode", timeCode);

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
        public DrawTextFilter X(string x)
            => this.X(x.Expression());

        /// <summary>
        /// The expressions which specify the offsets where text will be drawn within the video frame. They are relative to the top/left border of the output image.<br>
        /// </br>The default value of x and y is "0".
        /// </summary>
        public DrawTextFilter X(Action<Expression> x)
            => this.SetOption("x", x.Run(expression));

        /// <summary>
        /// The expressions which specify the offsets where text will be drawn within the video frame. They are relative to the top/left border of the output image.<br>
        /// </br>The default value of x and y is "0".
        /// </summary>
        public DrawTextFilter Y(string y)
            => this.Y(y.Expression());

        /// <summary>
        /// The expressions which specify the offsets where text will be drawn within the video frame. They are relative to the top/left border of the output image.<br>
        /// </br>The default value of x and y is "0".
        /// </summary>
        public DrawTextFilter Y(Action<Expression> y)
            => this.SetOption("y", y.Run(expression));

        /// <summary>
        /// The expressions which specify the offsets where text will be drawn within the video frame. They are relative to the top/left border of the output image.<br>
        /// </br>The default value of x and y is "0".
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public DrawTextFilter XY(Action<Expression> x, Action<Expression> y)
          => this.X(x).Y(y);

        /// <summary>
        /// The expressions which specify the offsets where text will be drawn within the video frame. They are relative to the top/left border of the output image.<br>
        /// </br>The default value of x and y is "0".
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public DrawTextFilter XY(string x, string y)
          => this.X(x).Y(y);

        /// <summary>
        /// If set to 1, the textfile will be reloaded before each frame. Be sure to update it atomically, or it may be read partially, or even fail.
        /// </summary>
        /// <param name="reload"></param>
        /// <returns></returns>
        public DrawTextFilter Reload(bool reload)
         => this.SetOption("reload", reload.ToFFmpegFlag());
    }

    public static class DrawTextFilterExtension
    {
        /// <summary>
        /// Draw a text string or text from a specified file on top of a video, using the libfreetype library.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DrawTextFilter DrawTextFilter(this ImageMap imageMap)
            => new DrawTextFilter(imageMap);

        public static DrawTextFilter DrawTextFilter(this ImageMap imageMap, DrawTextFilterConfig config)
        {
            var result = new DrawTextFilter(imageMap);
            if (!string.IsNullOrWhiteSpace(config?.FontFile)) result.FontFile(config.FontFile);
            if (!string.IsNullOrWhiteSpace(config?.Text)) result.Text(config.Text);
            if (!string.IsNullOrWhiteSpace(config?.TextFile)) result.TextFile(config.TextFile);
            if (config?.FontColor != null) result.FontColor(config.FontColor.Value);
            if (!string.IsNullOrWhiteSpace(config?.FontColor_Expr)) result.FontColorExpr(config.FontColor_Expr);
            if (config?.Boxcolor != null) result.Boxcolor(config.Boxcolor.Value);
            if (config?.Bordercolor != null) result.Bordercolor(config.Bordercolor.Value);
            if (config?.ShadowColor != null) result.Shadowcolor(config.ShadowColor.Value);
            if (config?.Box != null) result.Box(config.Box.Value);
            if (config?.BoxBorderW != null) result.Boxborderw(config.BoxBorderW.Value);
            if (config?.LineSpacing != null) result.LineSpacing(config.LineSpacing.Value);
            if (!string.IsNullOrWhiteSpace(config?.FontSize)) result.FontSize(config.FontSize);
            if (!string.IsNullOrWhiteSpace(config?.X)) result.X(config.X);
            if (!string.IsNullOrWhiteSpace(config?.Y)) result.Y(config.Y);
            if (config?.ShadowX != null) result.ShadowX(config.ShadowX.Value);
            if (config?.ShadowY != null) result.ShadowY(config.ShadowY.Value);
            if (config?.BorderW != null) result.Borderw(config.BorderW.Value);
            if (config?.TabSize != null) result.TabSize(config.TabSize.Value);
            if (config?.BaseTime != null) result.Basetime(config.BaseTime.Value);
            if (!string.IsNullOrWhiteSpace(config?.Font)) result.Font(config.Font);
            if (config?.Expansion != null) result.Expansion(config.Expansion.Value);
            if (!string.IsNullOrWhiteSpace(config?.TimeCode)) result.TimeCode(config.TimeCode);
            if (config?.Tc24hMax != null) result.Tc24hMax(config.Tc24hMax.Value);
            if (config?.TimeCodeRate != null) result.TimeCodeRate(config.TimeCodeRate);
            if (config?.Reload != null) result.Reload(config.Reload.Value);
            if (!string.IsNullOrWhiteSpace(config?.Alpha)) result.Alpha(config.Alpha);
            if (config?.FixBounds != null) result.FixBounds(config.FixBounds.Value);
            if (config?.StartNumber != null) result.StartNumber(config.StartNumber.Value);
            if (config?.TextShaping != null) result.TextShaping(config.TextShaping.Value);
            if (config?.FtLoadFlags != null) result.FtLoadFlags(config.FtLoadFlags.Value);
            if (!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
            return result;
        }
    }


    public class DrawTextFilterConfig : ITimelineSupportConfig
    {
        /// <summary>
        ///  set font file
        /// </summary>
        public string FontFile { get; set; }
        /// <summary>
        ///  set text
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        ///  set text file
        /// </summary>
        public string TextFile { get; set; }
        /// <summary>
        ///  set foreground color (default "black")
        /// </summary>
        public Color? FontColor { get; set; }
        /// <summary>
        ///  set foreground color expression (default "")
        /// </summary>
        public string FontColor_Expr { get; set; }
        /// <summary>
        ///  set box color (default "white")
        /// </summary>
        public Color? Boxcolor { get; set; }
        /// <summary>
        ///  set border color (default "black")
        /// </summary>
        public Color? Bordercolor { get; set; }
        /// <summary>
        ///  set shadow color (default "black")
        /// </summary>
        public Color? ShadowColor { get; set; }
        /// <summary>
        ///  set box (default false)
        /// </summary>
        public bool? Box { get; set; }
        /// <summary>
        ///  set box border width (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public int? BoxBorderW { get; set; }
        /// <summary>
        ///  set line spacing in pixels (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public int? LineSpacing { get; set; }
        /// <summary>
        ///  set font size
        /// </summary>
        public string FontSize { get; set; }
        /// <summary>
        ///  set x expression (default "0")
        /// </summary>
        public string X { get; set; }
        /// <summary>
        ///  set y expression (default "0")
        /// </summary>
        public string Y { get; set; }
        /// <summary>
        ///  set shadow x offset (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public int? ShadowX { get; set; }
        /// <summary>
        ///  set shadow y offset (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public int? ShadowY { get; set; }
        /// <summary>
        ///  set border width (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public int? BorderW { get; set; }
        /// <summary>
        ///  set tab size (from 0 to INT_MAX) (default 4)
        /// </summary>
        public int? TabSize { get; set; }
        /// <summary>
        ///  set base time (from I64_MIN to I64_MAX) (default I64_MIN)
        /// </summary>
        public long? BaseTime { get; set; }
        /// <summary>
        ///  Font name (default "Sans")
        /// </summary>
        public string Font { get; set; }
        /// <summary>
        ///  set the expansion mode (from 0 to 2) (default normal)
        /// </summary>
        public DrawTextExpansion? Expansion { get; set; }
        /// <summary>
        ///  set initial timecode
        /// </summary>
        public string TimeCode { get; set; }
        /// <summary>
        ///  set 24 hours max (timecode only) (default false)
        /// </summary>
        public bool? Tc24hMax { get; set; }
        /// <summary>
        ///  set rate (timecode only) (from 0 to INT_MAX) (default 0/1)
        /// </summary>
        public Rational TimeCodeRate { get; set; }
        /// <summary>
        ///  reload text file for each frame (default false)
        /// </summary>
        public bool? Reload { get; set; }
        /// <summary>
        ///  apply alpha while rendering (default "1")
        /// </summary>
        public string Alpha { get; set; }
        /// <summary>
        ///  check and fix text coords to avoid clipping (default false)
        /// </summary>
        public bool? FixBounds { get; set; }
        /// <summary>
        ///  start frame number for n/frame_num variable (from 0 to INT_MAX) (default 0)
        /// </summary>
        public int? StartNumber { get; set; }
        /// <summary>
        ///  attempt to shape text before drawing (default true)
        /// </summary>
        public bool? TextShaping { get; set; }
        /// <summary>
        ///  set font loading flags for libfreetype (default 0)
        /// </summary>
        public DrawTextFtLoadFlags? FtLoadFlags { get; set; }
        public string TimelineSupport { get; set; }
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
