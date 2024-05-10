namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ..C crop              V->V       Crop the input video.
/// </summary>
public class CropFilterGen : ImageToImageFilter,ICommandSupport
{
internal CropFilterGen(ImageMap input) : base("crop",input) { AddMapOut(); }
/// <summary>
///  set the width crop area expression (default "iw")
/// </summary>
public CropFilterGen out_w(ExpressionValue out_w) => this.SetOption("out_w",(string)out_w);
/// <summary>
///  set the width crop area expression (default "iw")
/// </summary>
public CropFilterGen w(ExpressionValue w) => this.SetOption("w",(string)w);
/// <summary>
///  set the height crop area expression (default "ih")
/// </summary>
public CropFilterGen out_h(ExpressionValue out_h) => this.SetOption("out_h",(string)out_h);
/// <summary>
///  set the height crop area expression (default "ih")
/// </summary>
public CropFilterGen h(ExpressionValue h) => this.SetOption("h",(string)h);
/// <summary>
///  set the x crop area expression (default "(in_w-out_w)/2")
/// </summary>
public CropFilterGen x(ExpressionValue x) => this.SetOption("x",(string)x);
/// <summary>
///  set the y crop area expression (default "(in_h-out_h)/2")
/// </summary>
public CropFilterGen y(ExpressionValue y) => this.SetOption("y",(string)y);
/// <summary>
///  keep aspect ratio (default false)
/// </summary>
public CropFilterGen keep_aspect(bool keep_aspect) => this.SetOption("keep_aspect",keep_aspect.ToFFmpegFlag());
/// <summary>
///  do exact cropping (default false)
/// </summary>
public CropFilterGen exact(bool exact) => this.SetOption("exact",exact.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class CropFilterGenExtensions
{
/// <summary>
/// Crop the input video.
/// </summary>
public static CropFilterGen CropFilterGen(this ImageMap input0) => new CropFilterGen(input0);
}
}
