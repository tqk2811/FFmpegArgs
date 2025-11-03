namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. drawtext          V-&gt;V       Draw text on top of video frames using libfreetype library.
    /// </summary>
    public class DrawtextFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal DrawtextFilterGen(ImageMap input) : base("drawtext", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set font file
        /// </summary>
        public DrawtextFilterGen fontfile(String fontfile) => this.SetOption("fontfile", fontfile.ToStringInv());
        /// <summary>
        ///  set text
        /// </summary>
        public DrawtextFilterGen text(String text) => this.SetOption("text", text.ToStringInv());
        /// <summary>
        ///  set text file
        /// </summary>
        public DrawtextFilterGen textfile(String textfile) => this.SetOption("textfile", textfile.ToStringInv());
        /// <summary>
        ///  set foreground color (default &quot;black&quot;)
        /// </summary>
        public DrawtextFilterGen fontcolor(Color fontcolor) => this.SetOption("fontcolor", fontcolor.ToHexStringRGBA());
        /// <summary>
        ///  set foreground color expression (default &quot;&quot;)
        /// </summary>
        public DrawtextFilterGen fontcolor_expr(ExpressionValue fontcolor_expr) => this.SetOption("fontcolor_expr", (string)fontcolor_expr);
        /// <summary>
        ///  set box color (default &quot;white&quot;)
        /// </summary>
        public DrawtextFilterGen boxcolor(Color boxcolor) => this.SetOption("boxcolor", boxcolor.ToHexStringRGBA());
        /// <summary>
        ///  set border color (default &quot;black&quot;)
        /// </summary>
        public DrawtextFilterGen bordercolor(Color bordercolor) => this.SetOption("bordercolor", bordercolor.ToHexStringRGBA());
        /// <summary>
        ///  set shadow color (default &quot;black&quot;)
        /// </summary>
        public DrawtextFilterGen shadowcolor(Color shadowcolor) => this.SetOption("shadowcolor", shadowcolor.ToHexStringRGBA());
        /// <summary>
        ///  set box (default false)
        /// </summary>
        public DrawtextFilterGen box(bool box) => this.SetOption("box", box.ToFFmpegFlag());
        /// <summary>
        ///  set box borders width (default &quot;0&quot;)
        /// </summary>
        public DrawtextFilterGen boxborderw(String boxborderw) => this.SetOption("boxborderw", boxborderw.ToStringInv());
        /// <summary>
        ///  set line spacing in pixels (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public DrawtextFilterGen line_spacing(int line_spacing) => this.SetOptionRange("line_spacing", line_spacing, INT_MIN, INT_MAX);
        /// <summary>
        ///  set font size
        /// </summary>
        public DrawtextFilterGen fontsize(String fontsize) => this.SetOption("fontsize", fontsize.ToStringInv());
        /// <summary>
        ///  set text alignment (default 0)
        /// </summary>
        public DrawtextFilterGen text_align(DrawtextFilterGenText_align text_align) => this.SetOption("text_align", text_align.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set x expression (default &quot;0&quot;)
        /// </summary>
        public DrawtextFilterGen x(ExpressionValue x) => this.SetOption("x", (string)x);
        /// <summary>
        ///  set y expression (default &quot;0&quot;)
        /// </summary>
        public DrawtextFilterGen y(ExpressionValue y) => this.SetOption("y", (string)y);
        /// <summary>
        ///  set box width (from 0 to INT_MAX) (default 0)
        /// </summary>
        public DrawtextFilterGen boxw(int boxw) => this.SetOptionRange("boxw", boxw, 0, INT_MAX);
        /// <summary>
        ///  set box height (from 0 to INT_MAX) (default 0)
        /// </summary>
        public DrawtextFilterGen boxh(int boxh) => this.SetOptionRange("boxh", boxh, 0, INT_MAX);
        /// <summary>
        ///  set shadow x offset (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public DrawtextFilterGen shadowx(int shadowx) => this.SetOptionRange("shadowx", shadowx, INT_MIN, INT_MAX);
        /// <summary>
        ///  set shadow y offset (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public DrawtextFilterGen shadowy(int shadowy) => this.SetOptionRange("shadowy", shadowy, INT_MIN, INT_MAX);
        /// <summary>
        ///  set border width (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public DrawtextFilterGen borderw(int borderw) => this.SetOptionRange("borderw", borderw, INT_MIN, INT_MAX);
        /// <summary>
        ///  set tab size (from 0 to INT_MAX) (default 4)
        /// </summary>
        public DrawtextFilterGen tabsize(int tabsize) => this.SetOptionRange("tabsize", tabsize, 0, INT_MAX);
        /// <summary>
        ///  set base time (from I64_MIN to I64_MAX) (default I64_MIN)
        /// </summary>
        public DrawtextFilterGen basetime(long basetime) => this.SetOptionRange("basetime", basetime, I64_MIN, I64_MAX);
        /// <summary>
        ///  Font name (default &quot;Sans&quot;)
        /// </summary>
        public DrawtextFilterGen font(String font) => this.SetOption("font", font.ToStringInv());
        /// <summary>
        ///  set the expansion mode (from 0 to 2) (default normal)
        /// </summary>
        public DrawtextFilterGen expansion(DrawtextFilterGenExpansion expansion) => this.SetOption("expansion", expansion.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the y alignment (from 0 to 2) (default text)
        /// </summary>
        public DrawtextFilterGen y_align(DrawtextFilterGenY_align y_align) => this.SetOption("y_align", y_align.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set initial timecode
        /// </summary>
        public DrawtextFilterGen timecode(String timecode) => this.SetOption("timecode", timecode.ToStringInv());
        /// <summary>
        ///  set 24 hours max (timecode only) (default false)
        /// </summary>
        public DrawtextFilterGen tc24hmax(bool tc24hmax) => this.SetOption("tc24hmax", tc24hmax.ToFFmpegFlag());
        /// <summary>
        ///  set rate (timecode only) (from 0 to INT_MAX) (default 0/1)
        /// </summary>
        public DrawtextFilterGen timecode_rate(Rational timecode_rate) => this.SetOption("timecode_rate", timecode_rate.Check(0, INT_MAX));
        /// <summary>
        ///  set rate (timecode only) (from 0 to INT_MAX) (default 0/1)
        /// </summary>
        public DrawtextFilterGen r(Rational r) => this.SetOption("r", r.Check(0, INT_MAX));
        /// <summary>
        ///  set rate (timecode only) (from 0 to INT_MAX) (default 0/1)
        /// </summary>
        public DrawtextFilterGen rate(Rational rate) => this.SetOption("rate", rate.Check(0, INT_MAX));
        /// <summary>
        ///  reload text file at specified frame interval (from 0 to INT_MAX) (default 0)
        /// </summary>
        public DrawtextFilterGen reload(int reload) => this.SetOptionRange("reload", reload, 0, INT_MAX);
        /// <summary>
        ///  apply alpha while rendering (default &quot;1&quot;)
        /// </summary>
        public DrawtextFilterGen alpha(String alpha) => this.SetOption("alpha", alpha.ToStringInv());
        /// <summary>
        ///  check and fix text coords to avoid clipping (default false)
        /// </summary>
        public DrawtextFilterGen fix_bounds(bool fix_bounds) => this.SetOption("fix_bounds", fix_bounds.ToFFmpegFlag());
        /// <summary>
        ///  start frame number for n/frame_num variable (from 0 to INT_MAX) (default 0)
        /// </summary>
        public DrawtextFilterGen start_number(int start_number) => this.SetOptionRange("start_number", start_number, 0, INT_MAX);
        /// <summary>
        ///  the source of text
        /// </summary>
        public DrawtextFilterGen text_source(String text_source) => this.SetOption("text_source", text_source.ToStringInv());
        /// <summary>
        ///  attempt to shape text before drawing (default true)
        /// </summary>
        public DrawtextFilterGen text_shaping(bool text_shaping) => this.SetOption("text_shaping", text_shaping.ToFFmpegFlag());
        /// <summary>
        ///  set font loading flags for libfreetype (default 0)
        /// </summary>
        public DrawtextFilterGen ft_load_flags(DrawtextFilterGenFt_load_flags ft_load_flags) => this.SetOption("ft_load_flags", ft_load_flags.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set text alignment (default 0)
    /// </summary>
    public enum DrawtextFilterGenText_align
    {
        /// <summary>
        /// left                         ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("left")]
        left,
        /// <summary>
        /// L                            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("L")]
        L,
        /// <summary>
        /// right                        ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("right")]
        right,
        /// <summary>
        /// R                            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("R")]
        R,
        /// <summary>
        /// center                       ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("center")]
        center,
        /// <summary>
        /// C                            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("C")]
        C,
        /// <summary>
        /// top                          ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("top")]
        top,
        /// <summary>
        /// T                            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("T")]
        T,
        /// <summary>
        /// bottom                       ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bottom")]
        bottom,
        /// <summary>
        /// B                            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("B")]
        B,
        /// <summary>
        /// middle                       ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("middle")]
        middle,
        /// <summary>
        /// M                            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("M")]
        M
    }

    /// <summary>
    ///  set the expansion mode (from 0 to 2) (default normal)
    /// </summary>
    public enum DrawtextFilterGenExpansion
    {
        /// <summary>
        /// none            0            ..FV....... set no expansion
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// normal          1            ..FV....... set normal expansion
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("normal")]
        normal = 1,
        /// <summary>
        /// strftime        2            ..FV....... set strftime expansion (deprecated)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("strftime")]
        strftime = 2
    }

    /// <summary>
    ///  set the y alignment (from 0 to 2) (default text)
    /// </summary>
    public enum DrawtextFilterGenY_align
    {
        /// <summary>
        /// text            0            ..FV....... y is referred to the top of the first text line
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("text")]
        text = 0,
        /// <summary>
        /// baseline        1            ..FV....... y is referred to the baseline of the first line
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("baseline")]
        baseline = 1,
        /// <summary>
        /// font            2            ..FV....... y is referred to the font defined line metrics
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("font")]
        font = 2
    }

    /// <summary>
    ///  set font loading flags for libfreetype (default 0)
    /// </summary>
    public enum DrawtextFilterGenFt_load_flags
    {
        /// <summary>
        /// default                      ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("default")]
        _default,
        /// <summary>
        /// no_scale                     ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("no_scale")]
        no_scale,
        /// <summary>
        /// no_hinting                   ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("no_hinting")]
        no_hinting,
        /// <summary>
        /// render                       ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("render")]
        render,
        /// <summary>
        /// no_bitmap                    ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("no_bitmap")]
        no_bitmap,
        /// <summary>
        /// vertical_layout              ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vertical_layout")]
        vertical_layout,
        /// <summary>
        /// force_autohint               ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("force_autohint")]
        force_autohint,
        /// <summary>
        /// crop_bitmap                  ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("crop_bitmap")]
        crop_bitmap,
        /// <summary>
        /// pedantic                     ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pedantic")]
        pedantic,
        /// <summary>
        /// ignore_global_advance_width              ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ignore_global_advance_width")]
        ignore_global_advance_width,
        /// <summary>
        /// no_recurse                   ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("no_recurse")]
        no_recurse,
        /// <summary>
        /// ignore_transform              ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ignore_transform")]
        ignore_transform,
        /// <summary>
        /// monochrome                   ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("monochrome")]
        monochrome,
        /// <summary>
        /// linear_design                ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear_design")]
        linear_design,
        /// <summary>
        /// no_autohint                  ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("no_autohint")]
        no_autohint
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Draw text on top of video frames using libfreetype library.
        /// </summary>
        public static DrawtextFilterGen DrawtextFilterGen(this ImageMap input0) => new DrawtextFilterGen(input0);
    }
}