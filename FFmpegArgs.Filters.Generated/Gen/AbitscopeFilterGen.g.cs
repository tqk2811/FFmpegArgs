namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... abitscope         A->V       Convert input audio to audio bit scope video output.
/// </summary>
public class AbitscopeFilterGen : AudioToImageFilter
{
internal AbitscopeFilterGen(AudioMap input) : base("abitscope",input) { AddMapOut(); }
/// <summary>
///  set video rate (default "25")
/// </summary>
public AbitscopeFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video size (default "1024x256")
/// </summary>
public AbitscopeFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set channels colors (default "red|green|blue|yellow|orange|lime|pink|magenta|brown")
/// </summary>
public AbitscopeFilterGen colors(string colors) => this.SetOption("colors",colors);
/// <summary>
///  set output mode (from 0 to 1) (default bars)
/// </summary>
public AbitscopeFilterGen mode(AbitscopeFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Convert input audio to audio bit scope video output.
/// </summary>
public static AbitscopeFilterGen AbitscopeFilterGen(this AudioMap input0) => new AbitscopeFilterGen(input0);
}
/// <summary>
///  set output mode (from 0 to 1) (default bars)
/// </summary>
public enum AbitscopeFilterGenMode
{
/// <summary>
/// bars            0            ..FV.......
/// </summary>
[Name("bars")] bars,
/// <summary>
/// trace           1            ..FV.......
/// </summary>
[Name("trace")] trace,
}

}
