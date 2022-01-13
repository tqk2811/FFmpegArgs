namespace FFmpegArgs.Filters.Autogens
{
public class SetfieldFilterGen : ImageToImageFilter
{
internal SetfieldFilterGen(ImageMap input) : base("setfield",input) { AddMapOut(); }
/// <summary>
///  select interlace mode (from -1 to 2) (default auto)
/// </summary>
public SetfieldFilterGen mode(SetfieldFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
}
public static class SetfieldFilterGenExtensions
{
/// <summary>
/// Force field for the output video frame.
/// </summary>
public static SetfieldFilterGen SetfieldFilterGen(this ImageMap input0) => new SetfieldFilterGen(input0);
/// <summary>
/// Force field for the output video frame.
/// </summary>
public static SetfieldFilterGen SetfieldFilterGen(this ImageMap input0,SetfieldFilterGenConfig config)
{
var result = new SetfieldFilterGen(input0);
if(config?.mode != null) result.mode(config.mode.Value);
return result;
}
}
public class SetfieldFilterGenConfig
{
/// <summary>
///  select interlace mode (from -1 to 2) (default auto)
/// </summary>
public SetfieldFilterGenMode? mode { get; set; }
}
public enum SetfieldFilterGenMode
{
[Name("auto")] auto,
[Name("bff")] bff,
[Name("tff")] tff,
[Name("prog")] prog,
}

}
