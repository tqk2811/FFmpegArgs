namespace FFmpegArgs.Filters.Autogens
{
public class Transpose_openclFilterGen : ImageToImageFilter
{
internal Transpose_openclFilterGen(ImageMap input) : base("transpose_opencl",input) { AddMapOut(); }
/// <summary>
///  set transpose direction (from 0 to 3) (default cclock_flip)
/// </summary>
public Transpose_openclFilterGen dir(Transpose_openclFilterGenDir dir) => this.SetOption("dir", dir.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  do not apply transposition if the input matches the specified geometry (from 0 to INT_MAX) (default none)
/// </summary>
public Transpose_openclFilterGen passthrough(Transpose_openclFilterGenPassthrough passthrough) => this.SetOption("passthrough", passthrough.GetEnumAttribute<NameAttribute>().Name);
}
public static class Transpose_openclFilterGenExtensions
{
/// <summary>
/// Transpose input video
/// </summary>
public static Transpose_openclFilterGen Transpose_openclFilterGen(this ImageMap input0) => new Transpose_openclFilterGen(input0);
/// <summary>
/// Transpose input video
/// </summary>
public static Transpose_openclFilterGen Transpose_openclFilterGen(this ImageMap input0,Transpose_openclFilterGenConfig config)
{
var result = new Transpose_openclFilterGen(input0);
if(config?.dir != null) result.dir(config.dir.Value);
if(config?.passthrough != null) result.passthrough(config.passthrough.Value);
return result;
}
}
public class Transpose_openclFilterGenConfig
{
/// <summary>
///  set transpose direction (from 0 to 3) (default cclock_flip)
/// </summary>
public Transpose_openclFilterGenDir? dir { get; set; }
/// <summary>
///  do not apply transposition if the input matches the specified geometry (from 0 to INT_MAX) (default none)
/// </summary>
public Transpose_openclFilterGenPassthrough? passthrough { get; set; }
}
public enum Transpose_openclFilterGenDir
{
[Name("cclock_flip")] cclock_flip,
[Name("clock")] clock,
[Name("cclock")] cclock,
[Name("clock_flip")] clock_flip,
}

public enum Transpose_openclFilterGenPassthrough
{
[Name("none")] none,
[Name("portrait")] portrait,
[Name("landscape")] landscape,
}

}
