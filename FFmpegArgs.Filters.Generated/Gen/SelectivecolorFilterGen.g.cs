namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS selectivecolor    V-&gt;V       Apply CMYK adjustments to specific color ranges.
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
        public SelectivecolorFilterGen reds(String reds) => this.SetOption("reds", reds.ToStringInv());
        /// <summary>
        ///  adjust yellow regions
        /// </summary>
        public SelectivecolorFilterGen yellows(String yellows) => this.SetOption("yellows", yellows.ToStringInv());
        /// <summary>
        ///  adjust green regions
        /// </summary>
        public SelectivecolorFilterGen greens(String greens) => this.SetOption("greens", greens.ToStringInv());
        /// <summary>
        ///  adjust cyan regions
        /// </summary>
        public SelectivecolorFilterGen cyans(String cyans) => this.SetOption("cyans", cyans.ToStringInv());
        /// <summary>
        ///  adjust blue regions
        /// </summary>
        public SelectivecolorFilterGen blues(String blues) => this.SetOption("blues", blues.ToStringInv());
        /// <summary>
        ///  adjust magenta regions
        /// </summary>
        public SelectivecolorFilterGen magentas(String magentas) => this.SetOption("magentas", magentas.ToStringInv());
        /// <summary>
        ///  adjust white regions
        /// </summary>
        public SelectivecolorFilterGen whites(String whites) => this.SetOption("whites", whites.ToStringInv());
        /// <summary>
        ///  adjust neutral regions
        /// </summary>
        public SelectivecolorFilterGen neutrals(String neutrals) => this.SetOption("neutrals", neutrals.ToStringInv());
        /// <summary>
        ///  adjust black regions
        /// </summary>
        public SelectivecolorFilterGen blacks(String blacks) => this.SetOption("blacks", blacks.ToStringInv());
        /// <summary>
        ///  set Photoshop selectivecolor file name
        /// </summary>
        public SelectivecolorFilterGen psfile(String psfile) => this.SetOption("psfile", psfile.ToStringInv());
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