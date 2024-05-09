namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.. entropy           V->V       Measure video frames entropy.
/// </summary>
public class EntropyFilterGen : ImageToImageFilter,ITimelineSupport
{
internal EntropyFilterGen(ImageMap input) : base("entropy",input) { AddMapOut(); }
/// <summary>
///  set kind of histogram entropy measurement (from 0 to 1) (default normal)
/// </summary>
public EntropyFilterGen mode(EntropyFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class EntropyFilterGenExtensions
{
/// <summary>
/// Measure video frames entropy.
/// </summary>
public static EntropyFilterGen EntropyFilterGen(this ImageMap input0) => new EntropyFilterGen(input0);
}
/// <summary>
///  set kind of histogram entropy measurement (from 0 to 1) (default normal)
/// </summary>
public enum EntropyFilterGenMode
{
/// <summary>
/// normal          0            ..FV.......
/// </summary>
[Name("normal")] normal,
/// <summary>
/// diff            1            ..FV.......
/// </summary>
[Name("diff")] diff,
}

}
