namespace FFmpegArgs.Filters.Autogens
{
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
public MetadataFilterGen expr(string expr) => this.SetOption("expr",expr);
/// <summary>
///  set file where to print metadata information
/// </summary>
public MetadataFilterGen file(string file) => this.SetOption("file",file);
/// <summary>
///  reduce buffering when printing to user-set file or pipe (default false)
/// </summary>
public MetadataFilterGen direct(bool direct) => this.SetOption("direct",direct.ToFFmpegFlag());
}
public static class MetadataFilterGenExtensions
{
/// <summary>
/// Manipulate video frame metadata.
/// </summary>
public static MetadataFilterGen MetadataFilterGen(this ImageMap input0) => new MetadataFilterGen(input0);
/// <summary>
/// Manipulate video frame metadata.
/// </summary>
public static MetadataFilterGen MetadataFilterGen(this ImageMap input0,MetadataFilterGenConfig config)
{
var result = new MetadataFilterGen(input0);
if(config?.mode != null) result.mode(config.mode.Value);
if(!string.IsNullOrWhiteSpace(config?.key)) result.key(config.key);
if(!string.IsNullOrWhiteSpace(config?.value)) result.value(config.value);
if(config?.function != null) result.function(config.function.Value);
if(!string.IsNullOrWhiteSpace(config?.expr)) result.expr(config.expr);
if(!string.IsNullOrWhiteSpace(config?.file)) result.file(config.file);
if(config?.direct != null) result.direct(config.direct.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class MetadataFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set a mode of operation (from 0 to 4) (default select)
/// </summary>
public MetadataFilterGenMode? mode { get; set; }
/// <summary>
///  set metadata key
/// </summary>
public string key { get; set; }
/// <summary>
///  set metadata value
/// </summary>
public string value { get; set; }
/// <summary>
///  function for comparing values (from 0 to 6) (default same_str)
/// </summary>
public MetadataFilterGenFunction? function { get; set; }
/// <summary>
///  set expression for expr function
/// </summary>
public string expr { get; set; }
/// <summary>
///  set file where to print metadata information
/// </summary>
public string file { get; set; }
/// <summary>
///  reduce buffering when printing to user-set file or pipe (default false)
/// </summary>
public bool? direct { get; set; }
public string TimelineSupport { get; set; }
}
public enum MetadataFilterGenMode
{
[Name("select")] select,
[Name("add")] add,
[Name("modify")] modify,
[Name("delete")] delete,
[Name("print")] print,
}

public enum MetadataFilterGenFunction
{
[Name("same_str")] same_str,
[Name("starts_with")] starts_with,
[Name("less")] less,
[Name("equal")] equal,
[Name("greater")] greater,
[Name("expr")] expr,
[Name("ends_with")] ends_with,
}

}
