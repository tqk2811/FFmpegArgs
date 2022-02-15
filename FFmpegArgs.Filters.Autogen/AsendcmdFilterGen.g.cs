namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... asendcmd          A->A       Send commands to filters.
/// </summary>
public class AsendcmdFilterGen : AudioToAudioFilter
{
internal AsendcmdFilterGen(AudioMap input) : base("asendcmd",input) { AddMapOut(); }
/// <summary>
///  set commands
/// </summary>
public AsendcmdFilterGen commands(string commands) => this.SetOption("commands",commands);
/// <summary>
///  set commands file
/// </summary>
public AsendcmdFilterGen filename(string filename) => this.SetOption("filename",filename);
}
/// <summary>
/// </summary>
public static class AsendcmdFilterGenExtensions
{
/// <summary>
/// Send commands to filters.
/// </summary>
public static AsendcmdFilterGen AsendcmdFilterGen(this AudioMap input0) => new AsendcmdFilterGen(input0);
}
}
