namespace FFmpegArgs.Filters.Autogens
{
public class QpFilterGen : ImageToImageFilter,ITimelineSupport
{
internal QpFilterGen(ImageMap input) : base("qp",input) { AddMapOut(); }
/// <summary>
///  set qp expression
/// </summary>
public QpFilterGen qp(string qp) => this.SetOption("qp",qp);
}
public static class QpFilterGenExtensions
{
/// <summary>
/// Change video quantization parameters.
/// </summary>
public static QpFilterGen QpFilterGen(this ImageMap input0) => new QpFilterGen(input0);
/// <summary>
/// Change video quantization parameters.
/// </summary>
public static QpFilterGen QpFilterGen(this ImageMap input0,QpFilterGenConfig config)
{
var result = new QpFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.qp)) result.qp(config.qp);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class QpFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set qp expression
/// </summary>
public string qp { get; set; }
public string TimelineSupport { get; set; }
}
}
