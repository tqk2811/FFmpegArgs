namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... vidstabtransform  V-&gt;V       Transform the frames, pass 2 of 2 for stabilization (see vidstabdetect for pass 1).
/// </summary>
public class VidstabtransformFilterGen : ImageToImageFilter
{
internal VidstabtransformFilterGen(ImageMap input) : base("vidstabtransform",input) { AddMapOut(); }
/// <summary>
///  set path to the file storing the transforms (default &quot;transforms.trf&quot;)
/// </summary>
public VidstabtransformFilterGen input(string input) => this.SetOption("input",input);
/// <summary>
///  set number of frames*2 + 1 used for lowpass filtering (from 0 to 1000) (default 15)
/// </summary>
public VidstabtransformFilterGen smoothing(int smoothing) => this.SetOptionRange("smoothing", smoothing,0,1000);
/// <summary>
///  set camera path optimization algo (from 0 to 2) (default opt)
/// </summary>
public VidstabtransformFilterGen optalgo(VidstabtransformFilterGenOptalgo optalgo) => this.SetOption("optalgo", optalgo.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set maximal number of pixels to translate image (from -1 to 500) (default -1)
/// </summary>
public VidstabtransformFilterGen maxshift(int maxshift) => this.SetOptionRange("maxshift", maxshift,-1,500);
/// <summary>
///  set maximal angle in rad to rotate image (from -1 to 3.14) (default -1)
/// </summary>
public VidstabtransformFilterGen maxangle(double maxangle) => this.SetOptionRange("maxangle", maxangle,-1,3.14);
/// <summary>
///  set cropping mode (from 0 to 1) (default keep)
/// </summary>
public VidstabtransformFilterGen crop(VidstabtransformFilterGenCrop crop) => this.SetOption("crop", crop.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  invert transforms (from 0 to 1) (default 0)
/// </summary>
public VidstabtransformFilterGen invert(int invert) => this.SetOptionRange("invert", invert,0,1);
/// <summary>
///  consider transforms as relative (from 0 to 1) (default 1)
/// </summary>
public VidstabtransformFilterGen relative(int relative) => this.SetOptionRange("relative", relative,0,1);
/// <summary>
///  set percentage to zoom (&gt;0: zoom in, &lt;0: zoom out (from -100 to 100) (default 0)
/// </summary>
public VidstabtransformFilterGen zoom(double zoom) => this.SetOptionRange("zoom", zoom,-100,100);
/// <summary>
///  set optimal zoom (0: nothing, 1: optimal static zoom, 2: optimal dynamic zoom) (from 0 to 2) (default 1)
/// </summary>
public VidstabtransformFilterGen optzoom(int optzoom) => this.SetOptionRange("optzoom", optzoom,0,2);
/// <summary>
///  for adative zoom: percent to zoom maximally each frame (from 0 to 5) (default 0.25)
/// </summary>
public VidstabtransformFilterGen zoomspeed(double zoomspeed) => this.SetOptionRange("zoomspeed", zoomspeed,0,5);
/// <summary>
///  set type of interpolation (from 0 to 3) (default bilinear)
/// </summary>
public VidstabtransformFilterGen interpol(VidstabtransformFilterGenInterpol interpol) => this.SetOption("interpol", interpol.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  enable virtual tripod mode (same as relative=0:smoothing=0) (default false)
/// </summary>
public VidstabtransformFilterGen tripod(bool tripod) => this.SetOption("tripod",tripod.ToFFmpegFlag());
/// <summary>
///  enable debug mode and writer global motions information to file (default false)
/// </summary>
public VidstabtransformFilterGen debug(bool debug) => this.SetOption("debug",debug.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Transform the frames, pass 2 of 2 for stabilization (see vidstabdetect for pass 1).
/// </summary>
public static VidstabtransformFilterGen VidstabtransformFilterGen(this ImageMap input0) => new VidstabtransformFilterGen(input0);
}
/// <summary>
///  set camera path optimization algo (from 0 to 2) (default opt)
/// </summary>
public enum VidstabtransformFilterGenOptalgo
{
/// <summary>
/// opt             0            ..FV....... global optimization
/// </summary>
[Name("opt")] opt,
/// <summary>
/// gauss           1            ..FV....... gaussian kernel
/// </summary>
[Name("gauss")] gauss,
/// <summary>
/// avg             2            ..FV....... simple averaging on motion
/// </summary>
[Name("avg")] avg,
}

/// <summary>
///  set cropping mode (from 0 to 1) (default keep)
/// </summary>
public enum VidstabtransformFilterGenCrop
{
/// <summary>
/// keep            0            ..FV....... keep border
/// </summary>
[Name("keep")] keep,
/// <summary>
/// black           1            ..FV....... black border
/// </summary>
[Name("black")] black,
}

/// <summary>
///  set type of interpolation (from 0 to 3) (default bilinear)
/// </summary>
public enum VidstabtransformFilterGenInterpol
{
/// <summary>
/// no              0            ..FV....... no interpolation
/// </summary>
[Name("no")] no,
/// <summary>
/// linear          1            ..FV....... linear (horizontal)
/// </summary>
[Name("linear")] linear,
/// <summary>
/// bilinear        2            ..FV....... bi-linear
/// </summary>
[Name("bilinear")] bilinear,
/// <summary>
/// bicubic         3            ..FV....... bi-cubic
/// </summary>
[Name("bicubic")] bicubic,
}

}
