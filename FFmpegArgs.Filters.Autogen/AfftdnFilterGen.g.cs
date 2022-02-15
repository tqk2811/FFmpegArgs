namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC afftdn            A->A       Denoise audio samples using FFT.
/// </summary>
public class AfftdnFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AfftdnFilterGen(AudioMap input) : base("afftdn",input) { AddMapOut(); }
/// <summary>
///  set the noise reduction (from 0.01 to 97) (default 12)
/// </summary>
public AfftdnFilterGen nr(float nr) => this.SetOptionRange("nr", nr,0.01,97);
/// <summary>
///  set the noise floor (from -80 to -20) (default -50)
/// </summary>
public AfftdnFilterGen nf(float nf) => this.SetOptionRange("nf", nf,-80,-20);
/// <summary>
///  set the noise type (from 0 to 3) (default w)
/// </summary>
public AfftdnFilterGen nt(AfftdnFilterGenNt nt) => this.SetOption("nt", nt.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the custom bands noise
/// </summary>
public AfftdnFilterGen bn(string bn) => this.SetOption("bn",bn);
/// <summary>
///  set the residual floor (from -80 to -20) (default -38)
/// </summary>
public AfftdnFilterGen rf(float rf) => this.SetOptionRange("rf", rf,-80,-20);
/// <summary>
///  track noise (default false)
/// </summary>
public AfftdnFilterGen tn(bool tn) => this.SetOption("tn",tn.ToFFmpegFlag());
/// <summary>
///  track residual (default false)
/// </summary>
public AfftdnFilterGen tr(bool tr) => this.SetOption("tr",tr.ToFFmpegFlag());
/// <summary>
///  set output mode (from 0 to 2) (default o)
/// </summary>
public AfftdnFilterGen om(AfftdnFilterGenOm om) => this.SetOption("om", om.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class AfftdnFilterGenExtensions
{
/// <summary>
/// Denoise audio samples using FFT.
/// </summary>
public static AfftdnFilterGen AfftdnFilterGen(this AudioMap input0) => new AfftdnFilterGen(input0);
}
/// <summary>
///  set the noise type (from 0 to 3) (default w)
/// </summary>
public enum AfftdnFilterGenNt
{
/// <summary>
/// w               0            ..F.A...... white noise
/// </summary>
[Name("w")] w,
/// <summary>
/// v               1            ..F.A...... vinyl noise
/// </summary>
[Name("v")] v,
/// <summary>
/// s               2            ..F.A...... shellac noise
/// </summary>
[Name("s")] s,
/// <summary>
/// c               3            ..F.A...... custom noise
/// </summary>
[Name("c")] c,
}

/// <summary>
///  set output mode (from 0 to 2) (default o)
/// </summary>
public enum AfftdnFilterGenOm
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
