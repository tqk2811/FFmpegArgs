namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC anlmdn            A->A       Reduce broadband noise from stream using Non-Local Means.
/// </summary>
public class AnlmdnFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AnlmdnFilterGen(AudioMap input) : base("anlmdn",input) { AddMapOut(); }
/// <summary>
///  set denoising strength (from 1e-05 to 10) (default 1e-05)
/// </summary>
public AnlmdnFilterGen s(float s) => this.SetOptionRange("s", s,1e-05,10);
/// <summary>
///  set patch duration (default 0.002)
/// </summary>
public AnlmdnFilterGen p(TimeSpan p) => this.SetOptionRange("p",p,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set research duration (default 0.006)
/// </summary>
public AnlmdnFilterGen r(TimeSpan r) => this.SetOptionRange("r",r,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set output mode (from 0 to 2) (default o)
/// </summary>
public AnlmdnFilterGen o(AnlmdnFilterGenO o) => this.SetOption("o", o.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set smooth factor (from 1 to 15) (default 11)
/// </summary>
public AnlmdnFilterGen m(float m) => this.SetOptionRange("m", m,1,15);
}
/// <summary>
/// </summary>
public static class AnlmdnFilterGenExtensions
{
/// <summary>
/// Reduce broadband noise from stream using Non-Local Means.
/// </summary>
public static AnlmdnFilterGen AnlmdnFilterGen(this AudioMap input0) => new AnlmdnFilterGen(input0);
}
/// <summary>
///  set output mode (from 0 to 2) (default o)
/// </summary>
public enum AnlmdnFilterGenO
{
/// <summary>
/// i               0            ..F.A....T. input
/// </summary>
[Name("i")] i,
/// <summary>
/// o               1            ..F.A....T. output
/// </summary>
[Name("o")] o,
/// <summary>
/// n               2            ..F.A....T. noise
/// </summary>
[Name("n")] n,
}

}
