namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS. selectivecolor    V-&gt;V       Apply CMYK adjustments to specific color ranges.
    /// </summary>
    public class SelectivecolorFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal SelectivecolorFilterGen(ImageMap input) : base("selectivecolor", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  select correction method (from 0 to 1) (default absolute)
        /// </summary>
        public SelectivecolorFilterGen correction_method(SelectivecolorFilterGenCorrection_method correction_method) => this.SetOption("correction_method", correction_method.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  adjust red regions
        /// </summary>
        public SelectivecolorFilterGen reds(String reds) => this.SetOption("reds", reds.ToString());
        /// <summary>
        ///  adjust yellow regions
        /// </summary>
        public SelectivecolorFilterGen yellows(String yellows) => this.SetOption("yellows", yellows.ToString());
        /// <summary>
        ///  adjust green regions
        /// </summary>
        public SelectivecolorFilterGen greens(String greens) => this.SetOption("greens", greens.ToString());
        /// <summary>
        ///  adjust cyan regions
        /// </summary>
        public SelectivecolorFilterGen cyans(String cyans) => this.SetOption("cyans", cyans.ToString());
        /// <summary>
        ///  adjust blue regions
        /// </summary>
        public SelectivecolorFilterGen blues(String blues) => this.SetOption("blues", blues.ToString());
        /// <summary>
        ///  adjust magenta regions
        /// </summary>
        public SelectivecolorFilterGen magentas(String magentas) => this.SetOption("magentas", magentas.ToString());
        /// <summary>
        ///  adjust white regions
        /// </summary>
        public SelectivecolorFilterGen whites(String whites) => this.SetOption("whites", whites.ToString());
        /// <summary>
        ///  adjust neutral regions
        /// </summary>
        public SelectivecolorFilterGen neutrals(String neutrals) => this.SetOption("neutrals", neutrals.ToString());
        /// <summary>
        ///  adjust black regions
        /// </summary>
        public SelectivecolorFilterGen blacks(String blacks) => this.SetOption("blacks", blacks.ToString());
        /// <summary>
        ///  set Photoshop selectivecolor file name
        /// </summary>
        public SelectivecolorFilterGen psfile(String psfile) => this.SetOption("psfile", psfile.ToString());
    }

    /// <summary>
    ///  select correction method (from 0 to 1) (default absolute)
    /// </summary>
    public enum SelectivecolorFilterGenCorrection_method
    {
        /// <summary>
        /// absolute        0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("absolute")]
        absolute = 0,
        /// <summary>
        /// relative        1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("relative")]
        relative = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply CMYK adjustments to specific color ranges.
        /// </summary>
        public static SelectivecolorFilterGen SelectivecolorFilterGen(this ImageMap input0) => new SelectivecolorFilterGen(input0);
    }
}