/*
 drawtext AVOptions:
   fontfile          <string>     ..FV....... set font file
   text              <string>     ..FV....... set text
   textfile          <string>     ..FV....... set text file
   fontcolor         <color>      ..FV....... set foreground color (default "black")
   fontcolor_expr    <string>     ..FV....... set foreground color expression (default "")
   boxcolor          <color>      ..FV....... set box color (default "white")
   bordercolor       <color>      ..FV....... set border color (default "black")
   shadowcolor       <color>      ..FV....... set shadow color (default "black")
   box               <boolean>    ..FV....... set box (default false)
   boxborderw        <int>        ..FV....... set box border width (from INT_MIN to INT_MAX) (default 0)
   line_spacing      <int>        ..FV....... set line spacing in pixels (from INT_MIN to INT_MAX) (default 0)
   fontsize          <string>     ..FV....... set font size
   x                 <string>     ..FV....... set x expression (default "0")
   y                 <string>     ..FV....... set y expression (default "0")
   shadowx           <int>        ..FV....... set shadow x offset (from INT_MIN to INT_MAX) (default 0)
   shadowy           <int>        ..FV....... set shadow y offset (from INT_MIN to INT_MAX) (default 0)
   borderw           <int>        ..FV....... set border width (from INT_MIN to INT_MAX) (default 0)
   tabsize           <int>        ..FV....... set tab size (from 0 to INT_MAX) (default 4)
   basetime          <int64>      ..FV....... set base time (from I64_MIN to I64_MAX) (default I64_MIN)
   font              <string>     ..FV....... Font name (default "Sans")
   expansion         <int>        ..FV....... set the expansion mode (from 0 to 2) (default normal)
     none            0            ..FV....... set no expansion
     normal          1            ..FV....... set normal expansion
     strftime        2            ..FV....... set strftime expansion (deprecated)
   timecode          <string>     ..FV....... set initial timecode
   tc24hmax          <boolean>    ..FV....... set 24 hours max (timecode only) (default false)
   timecode_rate     <rational>   ..FV....... set rate (timecode only) (from 0 to INT_MAX) (default 0/1)
   r                 <rational>   ..FV....... set rate (timecode only) (from 0 to INT_MAX) (default 0/1)
   rate              <rational>   ..FV....... set rate (timecode only) (from 0 to INT_MAX) (default 0/1)
   reload            <boolean>    ..FV....... reload text file for each frame (default false)
   alpha             <string>     ..FV....... apply alpha while rendering (default "1")
   fix_bounds        <boolean>    ..FV....... check and fix text coords to avoid clipping (default false)
   start_number      <int>        ..FV....... start frame number for n/frame_num variable (from 0 to INT_MAX) (default 0)
   text_source       <string>     ..FV....... the source of text
   text_shaping      <boolean>    ..FV....... attempt to shape text before drawing (default true)
   ft_load_flags     <flags>      ..FV....... set font loading flags for libfreetype (default 0)
     default                      ..FV.......
     no_scale                     ..FV.......
     no_hinting                   ..FV.......
     render                       ..FV.......
     no_bitmap                    ..FV.......
     vertical_layout              ..FV.......
     force_autohint               ..FV.......
     crop_bitmap                  ..FV.......
     pedantic                     ..FV.......
     ignore_global_advance_width              ..FV.......
     no_recurse                   ..FV.......
     ignore_transform              ..FV.......
     monochrome                   ..FV.......
     linear_design                ..FV.......
     no_autohint                  ..FV.......
 */
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
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
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
        public DrawTextFilter FontColorExpr(ExpressionValue color)
          => this.SetOption("fontcolor_expr", expression.Check(color));
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
            => this.SetOption("ft_load_flags", flag.GetEnumAttribute<NameAttribute>().Name);
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
        /// <param name="timeCode"></param>
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
        public DrawTextFilter X(ExpressionValue x)
            => this.SetOption("x", expression.Check(x));
        /// <summary>
        /// The expressions which specify the offsets where text will be drawn within the video frame. They are relative to the top/left border of the output image.<br>
        /// </br>The default value of x and y is "0".
        /// </summary>
        public DrawTextFilter Y(ExpressionValue y)
            => this.SetOption("y", expression.Check(y));
        /// <summary>
        /// If set to 1, the textfile will be reloaded before each frame. Be sure to update it atomically, or it may be read partially, or even fail.
        /// </summary>
        /// <param name="reload"></param>
        /// <returns></returns>
        public DrawTextFilter Reload(bool reload)
         => this.SetOption("reload", reload.ToFFmpegFlag());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class DrawTextFilterExtension
    {
        /// <summary>
        /// Draw a text string or text from a specified file on top of a video, using the libfreetype library.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static DrawTextFilter DrawTextFilter(this ImageMap imageMap)
            => new DrawTextFilter(imageMap);
    }
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
