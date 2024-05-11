namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.. ametadata         A-&gt;A       Manipulate audio frame metadata.
/// </summary>
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
public AmetadataFilterGen expr(ExpressionValue expr) => this.SetOption("expr",(string)expr);
/// <summary>
///  set file where to print metadata information
/// </summary>
public AmetadataFilterGen file(string file) => this.SetOption("file",file);
/// <summary>
///  reduce buffering when printing to user-set file or pipe (default false)
/// </summary>
public AmetadataFilterGen direct(bool direct) => this.SetOption("direct",direct.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Manipulate audio frame metadata.
/// </summary>
public static AmetadataFilterGen AmetadataFilterGen(this AudioMap input0) => new AmetadataFilterGen(input0);
}
/// <summary>
///  set a mode of operation (from 0 to 4) (default select)
/// </summary>
public enum AmetadataFilterGenMode
{
/// <summary>
/// select          0            ..F.A...... select frame
/// </summary>
[Name("select")] select,
/// <summary>
/// add             1            ..F.A...... add new metadata
/// </summary>
[Name("add")] add,
/// <summary>
/// modify          2            ..F.A...... modify metadata
/// </summary>
[Name("modify")] modify,
/// <summary>
/// delete          3            ..F.A...... delete metadata
/// </summary>
[Name("delete")] delete,
/// <summary>
/// print           4            ..F.A...... print metadata
/// </summary>
[Name("print")] print,
}

/// <summary>
///  function for comparing values (from 0 to 6) (default same_str)
/// </summary>
public enum AmetadataFilterGenFunction
{
/// <summary>
/// same_str        0            ..F.A......
/// </summary>
[Name("same_str")] same_str,
/// <summary>
/// starts_with     1            ..F.A......
/// </summary>
[Name("starts_with")] starts_with,
/// <summary>
/// less            2            ..F.A......
/// </summary>
[Name("less")] less,
/// <summary>
/// equal           3            ..F.A......
/// </summary>
[Name("equal")] equal,
/// <summary>
/// greater         4            ..F.A......
/// </summary>
[Name("greater")] greater,
/// <summary>
/// expr            5            ..F.A......
/// </summary>
[Name("expr")] expr,
/// <summary>
/// ends_with       6            ..F.A......
/// </summary>
[Name("ends_with")] ends_with,
}

}
