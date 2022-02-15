namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... sendcmd           V->V       Send commands to filters.
/// </summary>
public class SendcmdFilterGen : ImageToImageFilter
{
internal SendcmdFilterGen(ImageMap input) : base("sendcmd",input) { AddMapOut(); }
/// <summary>
///  set commands
/// </summary>
public SendcmdFilterGen commands(string commands) => this.SetOption("commands",commands);
/// <summary>
///  set commands file
/// </summary>
public SendcmdFilterGen filename(string filename) => this.SetOption("filename",filename);
}
/// <summary>
/// </summary>
public static class SendcmdFilterGenExtensions
{
/// <summary>
/// Send commands to filters.
/// </summary>
public static SendcmdFilterGen SendcmdFilterGen(this ImageMap input0) => new SendcmdFilterGen(input0);
}
}
