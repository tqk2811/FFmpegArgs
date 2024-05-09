namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... setfield          V->V       Force field for the output video frame.
/// </summary>
public class SetfieldFilterGen : ImageToImageFilter
{
internal SetfieldFilterGen(ImageMap input) : base("setfield",input) { AddMapOut(); }
/// <summary>
///  select interlace mode (from -1 to 2) (default auto)
/// </summary>
public SetfieldFilterGen mode(SetfieldFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class SetfieldFilterGenExtensions
{
/// <summary>
/// Force field for the output video frame.
/// </summary>
public static SetfieldFilterGen SetfieldFilterGen(this ImageMap input0) => new SetfieldFilterGen(input0);
}
/// <summary>
///  select interlace mode (from -1 to 2) (default auto)
/// </summary>
public enum SetfieldFilterGenMode
{
/// <summary>
/// auto            -1           ..FV....... keep the same input field
/// </summary>
[Name("auto")] auto,
/// <summary>
/// bff             0            ..FV....... mark as bottom-field-first
/// </summary>
[Name("bff")] bff,
/// <summary>
/// tff             1            ..FV....... mark as top-field-first
/// </summary>
[Name("tff")] tff,
/// <summary>
/// prog            2            ..FV....... mark as progressive
/// </summary>
[Name("prog")] prog,
}

}
