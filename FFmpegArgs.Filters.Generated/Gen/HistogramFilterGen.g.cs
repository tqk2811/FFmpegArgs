namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. histogram         V-&gt;V       Compute and draw a histogram.
    /// </summary>
    public class HistogramFilterGen : ImageToImageFilter
    {
        internal HistogramFilterGen(ImageMap input) : base("histogram", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set level height (from 50 to 2048) (default 200)
        /// </summary>
        public HistogramFilterGen level_height(int level_height) => this.SetOptionRange("level_height", level_height, 50, 2048);
        /// <summary>
        ///  set scale height (from 0 to 40) (default 12)
        /// </summary>
        public HistogramFilterGen scale_height(int scale_height) => this.SetOptionRange("scale_height", scale_height, 0, 40);
        /// <summary>
        ///  set display mode (from 0 to 2) (default stack)
        /// </summary>
        public HistogramFilterGen display_mode(HistogramFilterGenDisplay_mode display_mode) => this.SetOption("display_mode", display_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set levels mode (from 0 to 1) (default linear)
        /// </summary>
        public HistogramFilterGen levels_mode(HistogramFilterGenLevels_mode levels_mode) => this.SetOption("levels_mode", levels_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set levels mode (from 0 to 1) (default linear)
        /// </summary>
        public HistogramFilterGen m(HistogramFilterGenM m) => this.SetOption("m", m.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set color components to display (from 1 to 15) (default 7)
        /// </summary>
        public HistogramFilterGen components(int components) => this.SetOptionRange("components", components, 1, 15);
        /// <summary>
        ///  set foreground opacity (from 0 to 1) (default 0.7)
        /// </summary>
        public HistogramFilterGen fgopacity(float fgopacity) => this.SetOptionRange("fgopacity", fgopacity, 0, 1);
        /// <summary>
        ///  set background opacity (from 0 to 1) (default 0.5)
        /// </summary>
        public HistogramFilterGen bgopacity(float bgopacity) => this.SetOptionRange("bgopacity", bgopacity, 0, 1);
        /// <summary>
        ///  set colors mode (from 0 to 9) (default whiteonblack)
        /// </summary>
        public HistogramFilterGen colors_mode(HistogramFilterGenColors_mode colors_mode) => this.SetOption("colors_mode", colors_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set colors mode (from 0 to 9) (default whiteonblack)
        /// </summary>
        public HistogramFilterGen l(HistogramFilterGenL l) => this.SetOption("l", l.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set display mode (from 0 to 2) (default stack)
    /// </summary>
    public enum HistogramFilterGenDisplay_mode
    {
        /// <summary>
        /// overlay         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("overlay")]
        overlay = 0,
        /// <summary>
        /// parade          1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("parade")]
        parade = 1,
        /// <summary>
        /// stack           2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("stack")]
        stack = 2
    }

    /// <summary>
    ///  set levels mode (from 0 to 1) (default linear)
    /// </summary>
    public enum HistogramFilterGenLevels_mode
    {
        /// <summary>
        /// linear          0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 0,
        /// <summary>
        /// logarithmic     1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("logarithmic")]
        logarithmic = 1
    }

    /// <summary>
    ///  set levels mode (from 0 to 1) (default linear)
    /// </summary>
    public enum HistogramFilterGenM
    {
        /// <summary>
        /// linear          0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 0,
        /// <summary>
        /// logarithmic     1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("logarithmic")]
        logarithmic = 1
    }

    /// <summary>
    ///  set colors mode (from 0 to 9) (default whiteonblack)
    /// </summary>
    public enum HistogramFilterGenColors_mode
    {
        /// <summary>
        /// whiteonblack    0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("whiteonblack")]
        whiteonblack = 0,
        /// <summary>
        /// blackonwhite    1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blackonwhite")]
        blackonwhite = 1,
        /// <summary>
        /// whiteongray     2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("whiteongray")]
        whiteongray = 2,
        /// <summary>
        /// blackongray     3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blackongray")]
        blackongray = 3,
        /// <summary>
        /// coloronblack    4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("coloronblack")]
        coloronblack = 4,
        /// <summary>
        /// coloronwhite    5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("coloronwhite")]
        coloronwhite = 5,
        /// <summary>
        /// colorongray     6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("colorongray")]
        colorongray = 6,
        /// <summary>
        /// blackoncolor    7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blackoncolor")]
        blackoncolor = 7,
        /// <summary>
        /// whiteoncolor    8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("whiteoncolor")]
        whiteoncolor = 8,
        /// <summary>
        /// grayoncolor     9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("grayoncolor")]
        grayoncolor = 9
    }

    /// <summary>
    ///  set colors mode (from 0 to 9) (default whiteonblack)
    /// </summary>
    public enum HistogramFilterGenL
    {
        /// <summary>
        /// whiteonblack    0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("whiteonblack")]
        whiteonblack = 0,
        /// <summary>
        /// blackonwhite    1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blackonwhite")]
        blackonwhite = 1,
        /// <summary>
        /// whiteongray     2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("whiteongray")]
        whiteongray = 2,
        /// <summary>
        /// blackongray     3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blackongray")]
        blackongray = 3,
        /// <summary>
        /// coloronblack    4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("coloronblack")]
        coloronblack = 4,
        /// <summary>
        /// coloronwhite    5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("coloronwhite")]
        coloronwhite = 5,
        /// <summary>
        /// colorongray     6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("colorongray")]
        colorongray = 6,
        /// <summary>
        /// blackoncolor    7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blackoncolor")]
        blackoncolor = 7,
        /// <summary>
        /// whiteoncolor    8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("whiteoncolor")]
        whiteoncolor = 8,
        /// <summary>
        /// grayoncolor     9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("grayoncolor")]
        grayoncolor = 9
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Compute and draw a histogram.
        /// </summary>
        public static HistogramFilterGen HistogramFilterGen(this ImageMap input0) => new HistogramFilterGen(input0);
    }
}