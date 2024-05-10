namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.. metadata          V->V       Manipulate video frame metadata.
/// </summary>
public class MetadataFilterGen : ImageToImageFilter,ITimelineSupport
{
internal MetadataFilterGen(ImageMap input) : base("metadata",input) { AddMapOut(); }
/// <summary>
///  set a mode of operation (from 0 to 4) (default select)
/// </summary>
public MetadataFilterGen mode(MetadataFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set metadata key
/// </summary>
public MetadataFilterGen key(string key) => this.SetOption("key",key);
/// <summary>
///  set metadata value
/// </summary>
public MetadataFilterGen value(string value) => this.SetOption("value",value);
/// <summary>
///  function for comparing values (from 0 to 6) (default same_str)
/// </summary>
public MetadataFilterGen function(MetadataFilterGenFunction function) => this.SetOption("function", function.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set expression for expr function
/// </summary>
public MetadataFilterGen expr(ExpressionValue expr) => this.SetOption("expr",(string)expr);
/// <summary>
///  set file where to print metadata information
/// </summary>
public MetadataFilterGen file(string file) => this.SetOption("file",file);
/// <summary>
///  reduce buffering when printing to user-set file or pipe (default false)
/// </summary>
public MetadataFilterGen direct(bool direct) => this.SetOption("direct",direct.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Manipulate video frame metadata.
/// </summary>
public static MetadataFilterGen MetadataFilterGen(this ImageMap input0) => new MetadataFilterGen(input0);
}
/// <summary>
///  set a mode of operation (from 0 to 4) (default select)
/// </summary>
public enum MetadataFilterGenMode
{
/// <summary>
/// select          0            ..FV....... select frame
/// </summary>
[Name("select")] select,
/// <summary>
/// add             1            ..FV....... add new metadata
/// </summary>
[Name("add")] add,
/// <summary>
/// modify          2            ..FV....... modify metadata
/// </summary>
[Name("modify")] modify,
/// <summary>
/// delete          3            ..FV....... delete metadata
/// </summary>
[Name("delete")] delete,
/// <summary>
/// print           4            ..FV....... print metadata
/// </summary>
[Name("print")] print,
}

/// <summary>
///  function for comparing values (from 0 to 6) (default same_str)
/// </summary>
public enum MetadataFilterGenFunction
{
/// <summary>
/// same_str        0            ..FV.......
/// </summary>
[Name("same_str")] same_str,
/// <summary>
/// starts_with     1            ..FV.......
/// </summary>
[Name("starts_with")] starts_with,
/// <summary>
/// less            2            ..FV.......
/// </summary>
[Name("less")] less,
/// <summary>
/// equal           3            ..FV.......
/// </summary>
[Name("equal")] equal,
/// <summary>
/// greater         4            ..FV.......
/// </summary>
[Name("greater")] greater,
/// <summary>
/// expr            5            ..FV.......
/// </summary>
[Name("expr")] expr,
/// <summary>
/// ends_with       6            ..FV.......
/// </summary>
[Name("ends_with")] ends_with,
}

}
