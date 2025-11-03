namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S datascope         V-&gt;V       Video data analysis.
    /// </summary>
    public class DatascopeFilterGen : ImageToImageFilter, ISliceThreading
    {
        internal DatascopeFilterGen(ImageMap input) : base("datascope", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set output size (default &quot;hd720&quot;)
        /// </summary>
        public DatascopeFilterGen size(Size size) => this.SetOption("size", Inv($"{size.Width}x{size.Height}"));
        /// <summary>
        ///  set x offset (from 0 to INT_MAX) (default 0)
        /// </summary>
        public DatascopeFilterGen x(int x) => this.SetOptionRange("x", x, 0, INT_MAX);
        /// <summary>
        ///  set y offset (from 0 to INT_MAX) (default 0)
        /// </summary>
        public DatascopeFilterGen y(int y) => this.SetOptionRange("y", y, 0, INT_MAX);
        /// <summary>
        ///  set scope mode (from 0 to 2) (default mono)
        /// </summary>
        public DatascopeFilterGen mode(DatascopeFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  draw column/row numbers (default false)
        /// </summary>
        public DatascopeFilterGen axis(bool axis) => this.SetOption("axis", axis.ToFFmpegFlag());
        /// <summary>
        ///  set background opacity (from 0 to 1) (default 0.75)
        /// </summary>
        public DatascopeFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity, 0, 1);
        /// <summary>
        ///  set display number format (from 0 to 1) (default hex)
        /// </summary>
        public DatascopeFilterGen format(DatascopeFilterGenFormat format) => this.SetOption("format", format.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set components to display (from 1 to 15) (default 15)
        /// </summary>
        public DatascopeFilterGen components(int components) => this.SetOptionRange("components", components, 1, 15);
    }

    /// <summary>
    ///  set scope mode (from 0 to 2) (default mono)
    /// </summary>
    public enum DatascopeFilterGenMode
    {
        /// <summary>
        /// mono            0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mono")]
        mono = 0,
        /// <summary>
        /// color           1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("color")]
        color = 1,
        /// <summary>
        /// color2          2            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("color2")]
        color2 = 2
    }

    /// <summary>
    ///  set display number format (from 0 to 1) (default hex)
    /// </summary>
    public enum DatascopeFilterGenFormat
    {
        /// <summary>
        /// hex             0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hex")]
        hex = 0,
        /// <summary>
        /// dec             1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dec")]
        dec = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Video data analysis.
        /// </summary>
        public static DatascopeFilterGen DatascopeFilterGen(this ImageMap input0) => new DatascopeFilterGen(input0);
    }
}