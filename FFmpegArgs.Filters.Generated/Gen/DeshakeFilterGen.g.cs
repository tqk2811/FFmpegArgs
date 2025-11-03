namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. deshake           V-&gt;V       Stabilize shaky video.
    /// </summary>
    public class DeshakeFilterGen : ImageToImageFilter
    {
        internal DeshakeFilterGen(ImageMap input) : base("deshake", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set x for the rectangular search area (from -1 to INT_MAX) (default -1)
        /// </summary>
        public DeshakeFilterGen x(int x) => this.SetOptionRange("x", x, -1, INT_MAX);
        /// <summary>
        ///  set y for the rectangular search area (from -1 to INT_MAX) (default -1)
        /// </summary>
        public DeshakeFilterGen y(int y) => this.SetOptionRange("y", y, -1, INT_MAX);
        /// <summary>
        ///  set width for the rectangular search area (from -1 to INT_MAX) (default -1)
        /// </summary>
        public DeshakeFilterGen w(int w) => this.SetOptionRange("w", w, -1, INT_MAX);
        /// <summary>
        ///  set height for the rectangular search area (from -1 to INT_MAX) (default -1)
        /// </summary>
        public DeshakeFilterGen h(int h) => this.SetOptionRange("h", h, -1, INT_MAX);
        /// <summary>
        ///  set x for the rectangular search area (from 0 to 64) (default 16)
        /// </summary>
        public DeshakeFilterGen rx(int rx) => this.SetOptionRange("rx", rx, 0, 64);
        /// <summary>
        ///  set y for the rectangular search area (from 0 to 64) (default 16)
        /// </summary>
        public DeshakeFilterGen ry(int ry) => this.SetOptionRange("ry", ry, 0, 64);
        /// <summary>
        ///  set edge mode (from 0 to 3) (default mirror)
        /// </summary>
        public DeshakeFilterGen edge(DeshakeFilterGenEdge edge) => this.SetOption("edge", edge.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set motion search blocksize (from 4 to 128) (default 8)
        /// </summary>
        public DeshakeFilterGen blocksize(int blocksize) => this.SetOptionRange("blocksize", blocksize, 4, 128);
        /// <summary>
        ///  set contrast threshold for blocks (from 1 to 255) (default 125)
        /// </summary>
        public DeshakeFilterGen contrast(int contrast) => this.SetOptionRange("contrast", contrast, 1, 255);
        /// <summary>
        ///  set search strategy (from 0 to 1) (default exhaustive)
        /// </summary>
        public DeshakeFilterGen search(DeshakeFilterGenSearch search) => this.SetOption("search", search.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set motion search detailed log file name
        /// </summary>
        public DeshakeFilterGen filename(String filename) => this.SetOption("filename", filename.ToStringInv());
        /// <summary>
        ///  ignored (default false)
        /// </summary>
        public DeshakeFilterGen opencl(bool opencl) => this.SetOption("opencl", opencl.ToFFmpegFlag());
    }

    /// <summary>
    ///  set edge mode (from 0 to 3) (default mirror)
    /// </summary>
    public enum DeshakeFilterGenEdge
    {
        /// <summary>
        /// blank           0            ..FV....... fill zeroes at blank locations
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blank")]
        blank = 0,
        /// <summary>
        /// original        1            ..FV....... original image at blank locations
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("original")]
        original = 1,
        /// <summary>
        /// clamp           2            ..FV....... extruded edge value at blank locations
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("clamp")]
        clamp = 2,
        /// <summary>
        /// mirror          3            ..FV....... mirrored edge at blank locations
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mirror")]
        mirror = 3
    }

    /// <summary>
    ///  set search strategy (from 0 to 1) (default exhaustive)
    /// </summary>
    public enum DeshakeFilterGenSearch
    {
        /// <summary>
        /// exhaustive      0            ..FV....... exhaustive search
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("exhaustive")]
        exhaustive = 0,
        /// <summary>
        /// less            1            ..FV....... less exhaustive search
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("less")]
        less = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Stabilize shaky video.
        /// </summary>
        public static DeshakeFilterGen DeshakeFilterGen(this ImageMap input0) => new DeshakeFilterGen(input0);
    }
}