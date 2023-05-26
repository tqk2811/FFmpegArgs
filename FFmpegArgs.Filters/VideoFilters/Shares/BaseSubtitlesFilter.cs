namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseSubtitlesFilter : ImageToImageFilter
    {
        /// <summary>
        /// for <see cref="SubtitlesFilter"/> and <see cref="AssFilter"/>
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="imageMap"></param>
        internal BaseSubtitlesFilter(string filterName, ImageMap imageMap) : base(filterName, imageMap)
        {
            AddMapOut();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class BaseSubtitlesFilterExtension
    {
        /// <summary>
        /// File name or full path
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static T FileName<T>(this T t, string fileName) where T : BaseSubtitlesFilter
            => t.SetOption("f", fileName);
        /// <summary>
        /// Specify the size of the original video, the video for which the ASS file was composed.<br>
        /// </br>Due to a misdesign in ASS aspect ratio arithmetic, this is necessary to correctly scale the fonts if the aspect ratio has been changed.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="videoSize"></param>
        /// <returns></returns>
        public static T OriginalSize<T>(this T t, VideoSizeUtils videoSize) where T : BaseSubtitlesFilter
          => t.SetOption("original_size", videoSize.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        /// Specify the size of the original video, the video for which the ASS file was composed.<br>
        /// </br>Due to a misdesign in ASS aspect ratio arithmetic, this is necessary to correctly scale the fonts if the aspect ratio has been changed.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static T OriginalSize<T>(this T t, Size size) where T : BaseSubtitlesFilter
         => t.SetOption("original_size", $"{size.Width}x{size.Height}");
        /// <summary>
        /// Set a directory path containing fonts that can be used by the filter.<br>
        /// </br> These fonts will be used in addition to whatever the font provider uses.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="fontsdir"></param>
        /// <returns></returns>
        public static T FontsDir<T>(this T t, string fontsdir) where T : BaseSubtitlesFilter
         => t.SetOption("fontsdir", fontsdir);
        /// <summary>
        /// Process alpha channel, by default alpha channel is untouched.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public static T Alpha<T>(this T t, bool alpha) where T : BaseSubtitlesFilter
          => t.SetOption("alpha", alpha.ToFFmpegFlag());
        /// <summary>
        /// Override default style or script info parameters of the subtitles.<br>
        /// </br> It accepts a string containing ASS style format KEY=VALUE couples separated by ",".
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="force_style"></param>
        /// <returns></returns>
        public static T ForceStyle<T>(this T t, string force_style) where T : BaseSubtitlesFilter
          => t.SetOption("force_style", force_style);
        /// <summary>
        /// Override default style or script info parameters of the subtitles.<br>
        /// </br> It accepts a string containing ASS style format KEY=VALUE couples separated by ",".
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="force_style"></param>
        /// <returns></returns>
        public static T ForceStyle<T>(this T t, SubtitleStyleConfig force_style) where T : BaseSubtitlesFilter
          => t.SetOption("force_style", force_style);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string ToHexSubStringBGR(this Color color) => $"&H{color.B.ToString("X2")}{color.G.ToString("X2")}{color.R.ToString("X2")}";
    }
    /// <summary>
    /// http://www.tcax.org/docs/ass-specs.htm
    /// </summary>
    public class SubtitleStyleConfig
    {
        /// <summary>
        /// The name of the Style. Case sensitive. Cannot include commas.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The fontname as used by Windows. Case-sensitive.
        /// </summary>
        public string Fontname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Fontsize { get; set; }
        /// <summary>
        /// A long integer BGR (blue-green-red)  value. ie. the byte order in the hexadecimal equivelent of this number is BBGGRR<br>
        /// </br>This is the colour that a subtitle will normally appear in.
        /// </summary>
        public Color? PrimaryColour { get; set; }
        /// <summary>
        /// A long integer BGR (blue-green-red)  value. ie. the byte order in the hexadecimal equivelent of this number is BBGGRR<br>
        /// </br>This colour may be used instead of the Primary colour when a subtitle is automatically shifted to prevent an onscreen collsion, to distinguish the different subtitles.
        /// </summary>
        public Color? SecondaryColour { get; set; }
        /// <summary>
        /// A long integer BGR (blue-green-red)  value. ie. the byte order in the hexadecimal equivelent of this number is BBGGRR<br>
        /// </br>This colour may be used instead of the Primary or Secondary colour when a subtitle is automatically shifted to prevent an onscreen collsion, to distinguish the different subtitles.
        /// </summary>
        public Color? OutlineColor { get; set; }
        /// <summary>
        /// This is the colour of the subtitle outline or shadow, if these are used. A long integer BGR (blue-green-red)  value. ie. the byte order in the hexadecimal equivelent of this number is BBGGRR.
        /// </summary>
        public Color? BackColour { get; set; }
        /// <summary>
        /// This defines whether text is bold (true) or not (false). -1 is True, 0 is False. This is independant of the Italic attribute - you can have have text which is both bold and italic.
        /// </summary>
        public bool? Bold { get; set; }
        /// <summary>
        /// This defines whether text is italic (true) or not (false). -1 is True, 0 is False. This is independant of the bold attribute - you can have have text which is both bold and italic.
        /// </summary>
        public bool? Italic { get; set; }
        public bool? Underline { get; set; }
        public bool? Strikeout { get; set; }
        /// <summary>
        ///  Modifies the width of the font. [percent]
        /// </summary>
        public double? ScaleX { get; set; }
        /// <summary>
        /// Modifies the height of the font. [percent]
        /// </summary>
        public double? ScaleY { get; set; }
        /// <summary>
        /// Extra space between characters. [pixels]
        /// </summary>
        public int? Spacing { get; set; }
        /// <summary>
        /// The origin of the rotation is defined by the alignment. Can be a floating point number. [degrees]
        /// </summary>
        public int? Angle { get; set; }
        public SubtitleBorderStyle? BorderStyle { get; set; }
        /// <summary>
        /// If BorderStyle is 1,  then this specifies the width of the outline around the text, in pixels.<br>
        /// </br>Values may be 0, 1, 2, 3 or 4.
        /// </summary>
        public int? Outline { get; set; }
        /// <summary>
        /// If BorderStyle is 1,  then this specifies the depth of the drop shadow behind the text, in pixels. <br>
        /// </br>Values may be 0, 1, 2, 3 or 4. Drop shadow is always used in addition to an outline - SSA will force an outline of 1 pixel if no outline width is given.
        /// </summary>
        public int? Shadow { get; set; }
        public SubtitleAlignment? Alignment { get; set; }
        /// <summary>
        /// This defines the Left Margin in pixels. It is the distance from the left-hand edge of the screen.The three onscreen margins (MarginL, MarginR, MarginV) define areas in which the subtitle text will be displayed.
        /// </summary>
        public int? MarginL { get; set; }
        /// <summary>
        /// This defines the Right Margin in pixels. It is the distance from the right-hand edge of the screen. The three onscreen margins (MarginL, MarginR, MarginV) define areas in which the subtitle text will be displayed.
        /// </summary>
        public int? MarginR { get; set; }
        /// <summary>
        /// This defines the vertical Left Margin in pixels.<br>
        /// </br>For a subtitle, it is the distance from the bottom of the screen.<br>
        /// </br>For a toptitle, it is the distance from the top of the screen.<br>
        /// </br>For a midtitle, the value is ignored - the text will be vertically centred
        /// </summary>
        public int? MarginV { get; set; }
        /// <summary>
        /// This defines the transparency of the text. SSA and ASS does not use this yet.
        /// </summary>
        public double? AlphaLevel { get; set; }
        /// <summary>
        /// This specifies the font character set or encoding and on multi-lingual Windows installations it provides access to characters used in multiple than one languages.<br>
        /// </br> It is usually 0 (zero) for English (Western, ANSI) Windows.<br>
        /// </br>When the file is Unicode, this field is useful during file format conversions.
        /// </summary>
        public string Encoding { get; set; }
        public Dictionary<string, string> OtherStyle { get; set; }
        public override string ToString()
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            if (!string.IsNullOrWhiteSpace(Name)) pairs[nameof(Name)] = Name;
            if (!string.IsNullOrWhiteSpace(Fontname)) pairs[nameof(Fontname)] = Fontname;
            if (Fontsize != null) pairs[nameof(Fontsize)] = Fontsize.Value.ToString();
            if (PrimaryColour != null) pairs[nameof(PrimaryColour)] = PrimaryColour.Value.ToHexSubStringBGR();
            if (SecondaryColour != null) pairs[nameof(SecondaryColour)] = SecondaryColour.Value.ToHexSubStringBGR();
            if (OutlineColor != null) pairs[nameof(OutlineColor)] = OutlineColor.Value.ToHexSubStringBGR();
            if (BackColour != null) pairs[nameof(BackColour)] = BackColour.Value.ToHexSubStringBGR();
            if (Bold != null) pairs[nameof(Bold)] = (Bold.Value ? -1 : 0).ToString();
            if (Italic != null) pairs[nameof(Italic)] = (Italic.Value ? -1 : 0).ToString();
            if (Underline != null) pairs[nameof(Underline)] = (Underline.Value ? -1 : 0).ToString();
            if (Strikeout != null) pairs[nameof(Strikeout)] = (Strikeout.Value ? -1 : 0).ToString();
            if (ScaleX != null) pairs[nameof(ScaleX)] = ScaleX.Value.ToString();
            if (ScaleY != null) pairs[nameof(ScaleY)] = ScaleY.Value.ToString();
            if (Spacing != null) pairs[nameof(Spacing)] = Spacing.Value.ToString();
            if (Angle != null) pairs[nameof(Angle)] = Angle.Value.ToString();
            if (BorderStyle != null) pairs[nameof(BorderStyle)] = ((int)BorderStyle.Value).ToString();
            if (Outline != null) pairs[nameof(Outline)] = Outline.Value.ToString();
            if (Shadow != null) pairs[nameof(Shadow)] = Shadow.Value.ToString();
            if (Alignment != null) pairs[nameof(Alignment)] = ((int)Alignment.Value).ToString();
            if (MarginL != null) pairs[nameof(MarginL)] = MarginL.Value.ToString();
            if (MarginR != null) pairs[nameof(MarginR)] = MarginR.Value.ToString();
            if (MarginV != null) pairs[nameof(MarginV)] = MarginV.Value.ToString();
            if (AlphaLevel != null) pairs[nameof(AlphaLevel)] = AlphaLevel.Value.ToString();
            if (!string.IsNullOrWhiteSpace(Encoding)) pairs[nameof(Encoding)] = Encoding;
            if (OtherStyle != null) foreach (var pair in OtherStyle) pairs[pair.Key] = pair.Value;
            return string.Join(",", pairs.Select(x => $"{x.Key}={x.Value}"));
        }
    }
    public enum SubtitleBorderStyle : byte
    {
        OutlineAndDropShadow = 1,
        OpaqueBox = 3
    }
    public enum SubtitleAlignment : byte
    {
        LeftSub = 1,
        CenteredSub = 2,
        RightSub = 3,
        LeftMid = 4,
        CenteredMid = 5,
        RightMid = 6,
        LeftTop = 7,
        CenteredTop = 8,
        RightTop = 9,
    }
}
