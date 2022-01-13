namespace FFmpegArgs.Filters.Autogens
{
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
public static class SendcmdFilterGenExtensions
{
/// <summary>
/// Send commands to filters.
/// </summary>
public static SendcmdFilterGen SendcmdFilterGen(this ImageMap input0) => new SendcmdFilterGen(input0);
/// <summary>
/// Send commands to filters.
/// </summary>
public static SendcmdFilterGen SendcmdFilterGen(this ImageMap input0,SendcmdFilterGenConfig config)
{
var result = new SendcmdFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.commands)) result.commands(config.commands);
if(!string.IsNullOrWhiteSpace(config?.filename)) result.filename(config.filename);
return result;
}
}
public class SendcmdFilterGenConfig
{
/// <summary>
///  set commands
/// </summary>
public string commands { get; set; }
/// <summary>
///  set commands file
/// </summary>
public string filename { get; set; }
}
}
