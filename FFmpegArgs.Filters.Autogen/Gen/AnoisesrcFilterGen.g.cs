namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... anoisesrc         |->A       Generate a noise audio signal.
/// </summary>
public class AnoisesrcFilterGen : SourceAudioFilter
{
internal AnoisesrcFilterGen(IAudioFilterGraph input) : base("anoisesrc",input) { AddMapOut(); }
/// <summary>
///  set sample rate (from 15 to INT_MAX) (default 48000)
/// </summary>
public AnoisesrcFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,15,INT_MAX);
/// <summary>
///  set sample rate (from 15 to INT_MAX) (default 48000)
/// </summary>
public AnoisesrcFilterGen r(int r) => this.SetOptionRange("r", r,15,INT_MAX);
/// <summary>
///  set amplitude (from 0 to 1) (default 1)
/// </summary>
public AnoisesrcFilterGen amplitude(double amplitude) => this.SetOptionRange("amplitude", amplitude,0,1);
/// <summary>
///  set duration (default 0)
/// </summary>
public AnoisesrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set noise color (from 0 to 5) (default white)
/// </summary>
public AnoisesrcFilterGen color(AnoisesrcFilterGenColor color) => this.SetOption("color", color.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set noise color (from 0 to 5) (default white)
/// </summary>
public AnoisesrcFilterGen colour(AnoisesrcFilterGenColour colour) => this.SetOption("colour", colour.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set noise color (from 0 to 5) (default white)
/// </summary>
public AnoisesrcFilterGen c(AnoisesrcFilterGenC c) => this.SetOption("c", c.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set random seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public AnoisesrcFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public AnoisesrcFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples,1,INT_MAX);
}
/// <summary>
/// </summary>
public static class AnoisesrcFilterGenExtensions
{
/// <summary>
/// Generate a noise audio signal.
/// </summary>
public static AnoisesrcFilterGen AnoisesrcFilterGen(this IAudioFilterGraph input0) => new AnoisesrcFilterGen(input0);
}
/// <summary>
///  set noise color (from 0 to 5) (default white)
/// </summary>
public enum AnoisesrcFilterGenColor
{
/// <summary>
/// white           0            ..F.A......
/// </summary>
[Name("white")] white,
/// <summary>
/// pink            1            ..F.A......
/// </summary>
[Name("pink")] pink,
/// <summary>
/// brown           2            ..F.A......
/// </summary>
[Name("brown")] brown,
/// <summary>
/// blue            3            ..F.A......
/// </summary>
[Name("blue")] blue,
/// <summary>
/// violet          4            ..F.A......
/// </summary>
[Name("violet")] violet,
/// <summary>
/// velvet          5            ..F.A......
/// </summary>
[Name("velvet")] velvet,
}

/// <summary>
///  set noise color (from 0 to 5) (default white)
/// </summary>
public enum AnoisesrcFilterGenColour
{
/// <summary>
/// white           0            ..F.A......
/// </summary>
[Name("white")] white,
/// <summary>
/// pink            1            ..F.A......
/// </summary>
[Name("pink")] pink,
/// <summary>
/// brown           2            ..F.A......
/// </summary>
[Name("brown")] brown,
/// <summary>
/// blue            3            ..F.A......
/// </summary>
[Name("blue")] blue,
/// <summary>
/// violet          4            ..F.A......
/// </summary>
[Name("violet")] violet,
/// <summary>
/// velvet          5            ..F.A......
/// </summary>
[Name("velvet")] velvet,
}

/// <summary>
///  set noise color (from 0 to 5) (default white)
/// </summary>
public enum AnoisesrcFilterGenC
{
/// <summary>
/// white           0            ..F.A......
/// </summary>
[Name("white")] white,
/// <summary>
/// pink            1            ..F.A......
/// </summary>
[Name("pink")] pink,
/// <summary>
/// brown           2            ..F.A......
/// </summary>
[Name("brown")] brown,
/// <summary>
/// blue            3            ..F.A......
/// </summary>
[Name("blue")] blue,
/// <summary>
/// violet          4            ..F.A......
/// </summary>
[Name("violet")] violet,
/// <summary>
/// velvet          5            ..F.A......
/// </summary>
[Name("velvet")] velvet,
}

}
