namespace FFmpegArgs.Filters.Autogens
{
public class AmetadataFilterGen : AudioToAudioFilter,ITimelineSupport
{
internal AmetadataFilterGen(AudioMap input) : base("ametadata",input) { AddMapOut(); }
/// <summary>
///  set a mode of operation (from 0 to 4) (default select)
/// </summary>
public AmetadataFilterGen mode(AmetadataFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set metadata key
/// </summary>
public AmetadataFilterGen key(string key) => this.SetOption("key",key);
/// <summary>
///  set metadata value
/// </summary>
public AmetadataFilterGen value(string value) => this.SetOption("value",value);
/// <summary>
///  function for comparing values (from 0 to 6) (default same_str)
/// </summary>
public AmetadataFilterGen function(AmetadataFilterGenFunction function) => this.SetOption("function", function.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set expression for expr function
/// </summary>
public AmetadataFilterGen expr(string expr) => this.SetOption("expr",expr);
/// <summary>
///  set file where to print metadata information
/// </summary>
public AmetadataFilterGen file(string file) => this.SetOption("file",file);
/// <summary>
///  reduce buffering when printing to user-set file or pipe (default false)
/// </summary>
public AmetadataFilterGen direct(bool direct) => this.SetOption("direct",direct.ToFFmpegFlag());
}
public static class AmetadataFilterGenExtensions
{
/// <summary>
/// Manipulate audio frame metadata.
/// </summary>
public static AmetadataFilterGen AmetadataFilterGen(this AudioMap input0) => new AmetadataFilterGen(input0);
/// <summary>
/// Manipulate audio frame metadata.
/// </summary>
public static AmetadataFilterGen AmetadataFilterGen(this AudioMap input0,AmetadataFilterGenConfig config)
{
var result = new AmetadataFilterGen(input0);
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
public class AmetadataFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set a mode of operation (from 0 to 4) (default select)
/// </summary>
public AmetadataFilterGenMode? mode { get; set; }
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
public AmetadataFilterGenFunction? function { get; set; }
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
public enum AmetadataFilterGenMode
{
[Name("select")] select,
[Name("add")] add,
[Name("modify")] modify,
[Name("delete")] delete,
[Name("print")] print,
}

public enum AmetadataFilterGenFunction
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
