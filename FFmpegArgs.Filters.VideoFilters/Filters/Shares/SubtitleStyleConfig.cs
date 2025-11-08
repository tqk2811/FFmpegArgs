namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// http://www.tcax.org/docs/ass-specs.htm
    /// </summary>
    public class SubtitleStyleConfig
    {
        /// <summary>
        /// The name of the Style. Case sensitive. Cannot include commas.
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// The fontname as used by Windows. Case-sensitive.
        /// </summary>
        public string? Fontname { get; set; }
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
        public Color? OutlineColour { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        public bool? Underline { get; set; }
        /// <summary>
        /// 
        /// </summary>
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
        public float? Spacing { get; set; }
        /// <summary>
        /// The origin of the rotation is defined by the alignment. Can be a floating point number. [degrees]
        /// </summary>
        public int? Angle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SubtitleBorderStyle? BorderStyle { get; set; }
        /// <summary>
        /// If BorderStyle is 1,  then this specifies the width of the outline around the text, in pixels.<br>
        /// </br>Values may be 0, 1, 2, 3 or 4.
        /// </summary>
        public float? Outline { get; set; }
        /// <summary>
        /// If BorderStyle is 1,  then this specifies the depth of the drop shadow behind the text, in pixels. <br>
        /// </br>Values may be 0, 1, 2, 3 or 4. Drop shadow is always used in addition to an outline - SSA will force an outline of 1 pixel if no outline width is given.
        /// </summary>
        public float? Shadow { get; set; }
        /// <summary>
        /// 
        /// </summary>
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
        public int? Encoding { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string>? OtherStyle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            if (!string.IsNullOrWhiteSpace(Name)) pairs[nameof(Name)] = Name!;
            if (!string.IsNullOrWhiteSpace(Fontname)) pairs[nameof(Fontname)] = Fontname!;
            if (Fontsize != null) pairs[nameof(Fontsize)] = Fontsize.Value.ToString();
            if (PrimaryColour != null) pairs[nameof(PrimaryColour)] = PrimaryColour.Value.ToHexSubStringBGR();
            if (SecondaryColour != null) pairs[nameof(SecondaryColour)] = SecondaryColour.Value.ToHexSubStringBGR();
            if (OutlineColour != null) pairs[nameof(OutlineColour)] = OutlineColour.Value.ToHexSubStringBGR();
            if (BackColour != null) pairs[nameof(BackColour)] = BackColour.Value.ToHexSubStringBGR();
            if (Bold != null) pairs[nameof(Bold)] = (Bold.Value ? -1 : 0).ToString();
            if (Italic != null) pairs[nameof(Italic)] = (Italic.Value ? -1 : 0).ToString();
            if (Underline != null) pairs[nameof(Underline)] = (Underline.Value ? -1 : 0).ToString();
            if (Strikeout != null) pairs[nameof(Strikeout)] = (Strikeout.Value ? -1 : 0).ToString();
            if (ScaleX != null) pairs[nameof(ScaleX)] = ScaleX.Value.ToString();
            if (ScaleY != null) pairs[nameof(ScaleY)] = ScaleY.Value.ToString();
            if (Spacing != null) pairs[nameof(Spacing)] = Spacing.Value.ToString("F1");
            if (Angle != null) pairs[nameof(Angle)] = Angle.Value.ToString();
            if (BorderStyle != null) pairs[nameof(BorderStyle)] = ((int)BorderStyle.Value).ToString();
            if (Outline != null) pairs[nameof(Outline)] = Outline.Value.ToString("F1");
            if (Shadow != null) pairs[nameof(Shadow)] = Shadow.Value.ToString("F1");
            if (Alignment != null) pairs[nameof(Alignment)] = ((int)Alignment.Value).ToString();
            if (MarginL != null) pairs[nameof(MarginL)] = MarginL.Value.ToString();
            if (MarginR != null) pairs[nameof(MarginR)] = MarginR.Value.ToString();
            if (MarginV != null) pairs[nameof(MarginV)] = MarginV.Value.ToString();
            if (AlphaLevel != null) pairs[nameof(AlphaLevel)] = AlphaLevel.Value.ToString();
            if (Encoding.HasValue) pairs[nameof(Encoding)] = Encoding.Value.ToString()!;
            if (OtherStyle != null) foreach (var pair in OtherStyle) pairs[pair.Key] = pair.Value;
            return string.Join(",", pairs.Select(x => $"{x.Key}={x.Value}"));
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
