namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.. qp                V->V       Change video quantization parameters.
/// </summary>
public class QpFilterGen : ImageToImageFilter,ITimelineSupport
{
internal QpFilterGen(ImageMap input) : base("qp",input) { AddMapOut(); }
/// <summary>
///  set qp expression
/// </summary>
public QpFilterGen qp(ExpressionValue qp) => this.SetOption("qp",(string)qp);
}
/// <summary>
/// </summary>
public static class QpFilterGenExtensions
{
/// <summary>
/// Change video quantization parameters.
/// </summary>
public static QpFilterGen QpFilterGen(this ImageMap input0) => new QpFilterGen(input0);
}
}
