namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. metadata          V-&gt;V       Manipulate video frame metadata.
    /// </summary>
    public class MetadataFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal MetadataFilterGen(ImageMap input) : base("metadata", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set a mode of operation (from 0 to 4) (default select)
        /// </summary>
        public MetadataFilterGen mode(MetadataFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set metadata key
        /// </summary>
        public MetadataFilterGen key(String key) => this.SetOption("key", key.ToString());
        /// <summary>
        ///  set metadata value
        /// </summary>
        public MetadataFilterGen value(String value) => this.SetOption("value", value.ToString());
        /// <summary>
        ///  function for comparing values (from 0 to 6) (default same_str)
        /// </summary>
        public MetadataFilterGen function(MetadataFilterGenFunction function) => this.SetOption("function", function.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set expression for expr function
        /// </summary>
        public MetadataFilterGen expr(ExpressionValue expr) => this.SetOption("expr", (string)expr);
        /// <summary>
        ///  set file where to print metadata information
        /// </summary>
        public MetadataFilterGen file(String file) => this.SetOption("file", file.ToString());
        /// <summary>
        ///  reduce buffering when printing to user-set file or pipe (default false)
        /// </summary>
        public MetadataFilterGen direct(bool direct) => this.SetOption("direct", direct.ToFFmpegFlag());
    }

    /// <summary>
    ///  set a mode of operation (from 0 to 4) (default select)
    /// </summary>
    public enum MetadataFilterGenMode
    {
        /// <summary>
        /// select          0            ..FV....... select frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("select")]
        select = 0,
        /// <summary>
        /// add             1            ..FV....... add new metadata
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("add")]
        add = 1,
        /// <summary>
        /// modify          2            ..FV....... modify metadata
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("modify")]
        modify = 2,
        /// <summary>
        /// delete          3            ..FV....... delete metadata
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("delete")]
        delete = 3,
        /// <summary>
        /// print           4            ..FV....... print metadata
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("print")]
        print = 4
    }

    /// <summary>
    ///  function for comparing values (from 0 to 6) (default same_str)
    /// </summary>
    public enum MetadataFilterGenFunction
    {
        /// <summary>
        /// same_str        0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("same_str")]
        same_str = 0,
        /// <summary>
        /// starts_with     1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("starts_with")]
        starts_with = 1,
        /// <summary>
        /// less            2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("less")]
        less = 2,
        /// <summary>
        /// equal           3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("equal")]
        equal = 3,
        /// <summary>
        /// greater         4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("greater")]
        greater = 4,
        /// <summary>
        /// expr            5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("expr")]
        expr = 5,
        /// <summary>
        /// ends_with       6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ends_with")]
        ends_with = 6
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Manipulate video frame metadata.
        /// </summary>
        public static MetadataFilterGen MetadataFilterGen(this ImageMap input0) => new MetadataFilterGen(input0);
    }
}