namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. ametadata         A-&gt;A       Manipulate audio frame metadata.
    /// </summary>
    public class AmetadataFilterGen : AudioToAudioFilter, ITimelineSupport
    {
        internal AmetadataFilterGen(AudioMap input) : base("ametadata", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set a mode of operation (from 0 to 4) (default select)
        /// </summary>
        public AmetadataFilterGen mode(AmetadataFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set metadata key
        /// </summary>
        public AmetadataFilterGen key(String key) => this.SetOption("key", key.ToStringInv());
        /// <summary>
        ///  set metadata value
        /// </summary>
        public AmetadataFilterGen value(String value) => this.SetOption("value", value.ToStringInv());
        /// <summary>
        ///  function for comparing values (from 0 to 6) (default same_str)
        /// </summary>
        public AmetadataFilterGen function(AmetadataFilterGenFunction function) => this.SetOption("function", function.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set expression for expr function
        /// </summary>
        public AmetadataFilterGen expr(ExpressionValue expr) => this.SetOption("expr", (string)expr);
        /// <summary>
        ///  set file where to print metadata information
        /// </summary>
        public AmetadataFilterGen file(String file) => this.SetOption("file", file.ToStringInv());
        /// <summary>
        ///  reduce buffering when printing to user-set file or pipe (default false)
        /// </summary>
        public AmetadataFilterGen direct(bool direct) => this.SetOption("direct", direct.ToFFmpegFlag());
    }

    /// <summary>
    ///  set a mode of operation (from 0 to 4) (default select)
    /// </summary>
    public enum AmetadataFilterGenMode
    {
        /// <summary>
        /// select          0            ..F.A...... select frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("select")]
        select = 0,
        /// <summary>
        /// add             1            ..F.A...... add new metadata
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("add")]
        add = 1,
        /// <summary>
        /// modify          2            ..F.A...... modify metadata
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("modify")]
        modify = 2,
        /// <summary>
        /// delete          3            ..F.A...... delete metadata
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("delete")]
        delete = 3,
        /// <summary>
        /// print           4            ..F.A...... print metadata
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("print")]
        print = 4
    }

    /// <summary>
    ///  function for comparing values (from 0 to 6) (default same_str)
    /// </summary>
    public enum AmetadataFilterGenFunction
    {
        /// <summary>
        /// same_str        0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("same_str")]
        same_str = 0,
        /// <summary>
        /// starts_with     1            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("starts_with")]
        starts_with = 1,
        /// <summary>
        /// less            2            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("less")]
        less = 2,
        /// <summary>
        /// equal           3            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("equal")]
        equal = 3,
        /// <summary>
        /// greater         4            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("greater")]
        greater = 4,
        /// <summary>
        /// expr            5            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("expr")]
        expr = 5,
        /// <summary>
        /// ends_with       6            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ends_with")]
        ends_with = 6
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Manipulate audio frame metadata.
        /// </summary>
        public static AmetadataFilterGen AmetadataFilterGen(this AudioMap input0) => new AmetadataFilterGen(input0);
    }
}