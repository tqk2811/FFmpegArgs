namespace FFmpegArgs.Filters.Autogens
{
public class V360FilterGen : ImageToImageFilter,ISliceThreading,ICommandSupport
{
internal V360FilterGen(ImageMap input) : base("v360",input) { AddMapOut(); }
/// <summary>
///  set input projection (from 0 to 23) (default e)
/// </summary>
public V360FilterGen input(V360FilterGenInput input) => this.SetOption("input", input.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set output projection (from 0 to 23) (default c3x2)
/// </summary>
public V360FilterGen output(V360FilterGenOutput output) => this.SetOption("output", output.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set interpolation method (from 0 to 7) (default line)
/// </summary>
public V360FilterGen interp(V360FilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  output width (from 0 to 32767) (default 0)
/// </summary>
public V360FilterGen w(int w) => this.SetOptionRange("w", w,0,32767);
/// <summary>
///  output height (from 0 to 32767) (default 0)
/// </summary>
public V360FilterGen h(int h) => this.SetOptionRange("h", h,0,32767);
/// <summary>
///  input stereo format (from 0 to 2) (default 2d)
/// </summary>
public V360FilterGen in_stereo(V360FilterGenIn_stereo in_stereo) => this.SetOption("in_stereo", in_stereo.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  output stereo format (from 0 to 2) (default 2d)
/// </summary>
public V360FilterGen out_stereo(V360FilterGenOut_stereo out_stereo) => this.SetOption("out_stereo", out_stereo.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  input cubemap face order (default "rludfb")
/// </summary>
public V360FilterGen in_forder(string in_forder) => this.SetOption("in_forder",in_forder);
/// <summary>
///  output cubemap face order (default "rludfb")
/// </summary>
public V360FilterGen out_forder(string out_forder) => this.SetOption("out_forder",out_forder);
/// <summary>
///  input cubemap face rotation (default "000000")
/// </summary>
public V360FilterGen in_frot(string in_frot) => this.SetOption("in_frot",in_frot);
/// <summary>
///  output cubemap face rotation (default "000000")
/// </summary>
public V360FilterGen out_frot(string out_frot) => this.SetOption("out_frot",out_frot);
/// <summary>
///  percent input cubemap pads (from 0 to 0.1) (default 0)
/// </summary>
public V360FilterGen in_pad(float in_pad) => this.SetOptionRange("in_pad", in_pad,0,0.1);
/// <summary>
///  percent output cubemap pads (from 0 to 0.1) (default 0)
/// </summary>
public V360FilterGen out_pad(float out_pad) => this.SetOptionRange("out_pad", out_pad,0,0.1);
/// <summary>
///  fixed input cubemap pads (from 0 to 100) (default 0)
/// </summary>
public V360FilterGen fin_pad(int fin_pad) => this.SetOptionRange("fin_pad", fin_pad,0,100);
/// <summary>
///  fixed output cubemap pads (from 0 to 100) (default 0)
/// </summary>
public V360FilterGen fout_pad(int fout_pad) => this.SetOptionRange("fout_pad", fout_pad,0,100);
/// <summary>
///  yaw rotation (from -180 to 180) (default 0)
/// </summary>
public V360FilterGen yaw(float yaw) => this.SetOptionRange("yaw", yaw,-180,180);
/// <summary>
///  pitch rotation (from -180 to 180) (default 0)
/// </summary>
public V360FilterGen pitch(float pitch) => this.SetOptionRange("pitch", pitch,-180,180);
/// <summary>
///  roll rotation (from -180 to 180) (default 0)
/// </summary>
public V360FilterGen roll(float roll) => this.SetOptionRange("roll", roll,-180,180);
/// <summary>
///  rotation order (default "ypr")
/// </summary>
public V360FilterGen rorder(string rorder) => this.SetOption("rorder",rorder);
/// <summary>
///  output horizontal field of view (from 1e-05 to 360) (default 90)
/// </summary>
public V360FilterGen h_fov(float h_fov) => this.SetOptionRange("h_fov", h_fov,1e-05,360);
/// <summary>
///  output vertical field of view (from 1e-05 to 360) (default 45)
/// </summary>
public V360FilterGen v_fov(float v_fov) => this.SetOptionRange("v_fov", v_fov,1e-05,360);
/// <summary>
///  output diagonal field of view (from 0 to 360) (default 0)
/// </summary>
public V360FilterGen d_fov(float d_fov) => this.SetOptionRange("d_fov", d_fov,0,360);
/// <summary>
///  flip out video horizontally (default false)
/// </summary>
public V360FilterGen h_flip(bool h_flip) => this.SetOption("h_flip",h_flip.ToFFmpegFlag());
/// <summary>
///  flip out video vertically (default false)
/// </summary>
public V360FilterGen v_flip(bool v_flip) => this.SetOption("v_flip",v_flip.ToFFmpegFlag());
/// <summary>
///  flip out video indepth (default false)
/// </summary>
public V360FilterGen d_flip(bool d_flip) => this.SetOption("d_flip",d_flip.ToFFmpegFlag());
/// <summary>
///  flip in video horizontally (default false)
/// </summary>
public V360FilterGen ih_flip(bool ih_flip) => this.SetOption("ih_flip",ih_flip.ToFFmpegFlag());
/// <summary>
///  flip in video vertically (default false)
/// </summary>
public V360FilterGen iv_flip(bool iv_flip) => this.SetOption("iv_flip",iv_flip.ToFFmpegFlag());
/// <summary>
///  transpose video input (default false)
/// </summary>
public V360FilterGen in_trans(bool in_trans) => this.SetOption("in_trans",in_trans.ToFFmpegFlag());
/// <summary>
///  transpose video output (default false)
/// </summary>
public V360FilterGen out_trans(bool out_trans) => this.SetOption("out_trans",out_trans.ToFFmpegFlag());
/// <summary>
///  input horizontal field of view (from 1e-05 to 360) (default 90)
/// </summary>
public V360FilterGen ih_fov(float ih_fov) => this.SetOptionRange("ih_fov", ih_fov,1e-05,360);
/// <summary>
///  input vertical field of view (from 1e-05 to 360) (default 45)
/// </summary>
public V360FilterGen iv_fov(float iv_fov) => this.SetOptionRange("iv_fov", iv_fov,1e-05,360);
/// <summary>
///  input diagonal field of view (from 0 to 360) (default 0)
/// </summary>
public V360FilterGen id_fov(float id_fov) => this.SetOptionRange("id_fov", id_fov,0,360);
/// <summary>
///  build mask in alpha plane (default false)
/// </summary>
public V360FilterGen alpha_mask(bool alpha_mask) => this.SetOption("alpha_mask",alpha_mask.ToFFmpegFlag());
}
public static class V360FilterGenExtensions
{
/// <summary>
/// Convert 360 projection of video.
/// </summary>
public static V360FilterGen V360FilterGen(this ImageMap input0) => new V360FilterGen(input0);
/// <summary>
/// Convert 360 projection of video.
/// </summary>
public static V360FilterGen V360FilterGen(this ImageMap input0,V360FilterGenConfig config)
{
var result = new V360FilterGen(input0);
if(config?.input != null) result.input(config.input.Value);
if(config?.output != null) result.output(config.output.Value);
if(config?.interp != null) result.interp(config.interp.Value);
if(config?.w != null) result.w(config.w.Value);
if(config?.h != null) result.h(config.h.Value);
if(config?.in_stereo != null) result.in_stereo(config.in_stereo.Value);
if(config?.out_stereo != null) result.out_stereo(config.out_stereo.Value);
if(!string.IsNullOrWhiteSpace(config?.in_forder)) result.in_forder(config.in_forder);
if(!string.IsNullOrWhiteSpace(config?.out_forder)) result.out_forder(config.out_forder);
if(!string.IsNullOrWhiteSpace(config?.in_frot)) result.in_frot(config.in_frot);
if(!string.IsNullOrWhiteSpace(config?.out_frot)) result.out_frot(config.out_frot);
if(config?.in_pad != null) result.in_pad(config.in_pad.Value);
if(config?.out_pad != null) result.out_pad(config.out_pad.Value);
if(config?.fin_pad != null) result.fin_pad(config.fin_pad.Value);
if(config?.fout_pad != null) result.fout_pad(config.fout_pad.Value);
if(config?.yaw != null) result.yaw(config.yaw.Value);
if(config?.pitch != null) result.pitch(config.pitch.Value);
if(config?.roll != null) result.roll(config.roll.Value);
if(!string.IsNullOrWhiteSpace(config?.rorder)) result.rorder(config.rorder);
if(config?.h_fov != null) result.h_fov(config.h_fov.Value);
if(config?.v_fov != null) result.v_fov(config.v_fov.Value);
if(config?.d_fov != null) result.d_fov(config.d_fov.Value);
if(config?.h_flip != null) result.h_flip(config.h_flip.Value);
if(config?.v_flip != null) result.v_flip(config.v_flip.Value);
if(config?.d_flip != null) result.d_flip(config.d_flip.Value);
if(config?.ih_flip != null) result.ih_flip(config.ih_flip.Value);
if(config?.iv_flip != null) result.iv_flip(config.iv_flip.Value);
if(config?.in_trans != null) result.in_trans(config.in_trans.Value);
if(config?.out_trans != null) result.out_trans(config.out_trans.Value);
if(config?.ih_fov != null) result.ih_fov(config.ih_fov.Value);
if(config?.iv_fov != null) result.iv_fov(config.iv_fov.Value);
if(config?.id_fov != null) result.id_fov(config.id_fov.Value);
if(config?.alpha_mask != null) result.alpha_mask(config.alpha_mask.Value);
return result;
}
}
public class V360FilterGenConfig
{
/// <summary>
///  set input projection (from 0 to 23) (default e)
/// </summary>
public V360FilterGenInput? input { get; set; }
/// <summary>
///  set output projection (from 0 to 23) (default c3x2)
/// </summary>
public V360FilterGenOutput? output { get; set; }
/// <summary>
///  set interpolation method (from 0 to 7) (default line)
/// </summary>
public V360FilterGenInterp? interp { get; set; }
/// <summary>
///  output width (from 0 to 32767) (default 0)
/// </summary>
public int? w { get; set; }
/// <summary>
///  output height (from 0 to 32767) (default 0)
/// </summary>
public int? h { get; set; }
/// <summary>
///  input stereo format (from 0 to 2) (default 2d)
/// </summary>
public V360FilterGenIn_stereo? in_stereo { get; set; }
/// <summary>
///  output stereo format (from 0 to 2) (default 2d)
/// </summary>
public V360FilterGenOut_stereo? out_stereo { get; set; }
/// <summary>
///  input cubemap face order (default "rludfb")
/// </summary>
public string in_forder { get; set; }
/// <summary>
///  output cubemap face order (default "rludfb")
/// </summary>
public string out_forder { get; set; }
/// <summary>
///  input cubemap face rotation (default "000000")
/// </summary>
public string in_frot { get; set; }
/// <summary>
///  output cubemap face rotation (default "000000")
/// </summary>
public string out_frot { get; set; }
/// <summary>
///  percent input cubemap pads (from 0 to 0.1) (default 0)
/// </summary>
public float? in_pad { get; set; }
/// <summary>
///  percent output cubemap pads (from 0 to 0.1) (default 0)
/// </summary>
public float? out_pad { get; set; }
/// <summary>
///  fixed input cubemap pads (from 0 to 100) (default 0)
/// </summary>
public int? fin_pad { get; set; }
/// <summary>
///  fixed output cubemap pads (from 0 to 100) (default 0)
/// </summary>
public int? fout_pad { get; set; }
/// <summary>
///  yaw rotation (from -180 to 180) (default 0)
/// </summary>
public float? yaw { get; set; }
/// <summary>
///  pitch rotation (from -180 to 180) (default 0)
/// </summary>
public float? pitch { get; set; }
/// <summary>
///  roll rotation (from -180 to 180) (default 0)
/// </summary>
public float? roll { get; set; }
/// <summary>
///  rotation order (default "ypr")
/// </summary>
public string rorder { get; set; }
/// <summary>
///  output horizontal field of view (from 1e-05 to 360) (default 90)
/// </summary>
public float? h_fov { get; set; }
/// <summary>
///  output vertical field of view (from 1e-05 to 360) (default 45)
/// </summary>
public float? v_fov { get; set; }
/// <summary>
///  output diagonal field of view (from 0 to 360) (default 0)
/// </summary>
public float? d_fov { get; set; }
/// <summary>
///  flip out video horizontally (default false)
/// </summary>
public bool? h_flip { get; set; }
/// <summary>
///  flip out video vertically (default false)
/// </summary>
public bool? v_flip { get; set; }
/// <summary>
///  flip out video indepth (default false)
/// </summary>
public bool? d_flip { get; set; }
/// <summary>
///  flip in video horizontally (default false)
/// </summary>
public bool? ih_flip { get; set; }
/// <summary>
///  flip in video vertically (default false)
/// </summary>
public bool? iv_flip { get; set; }
/// <summary>
///  transpose video input (default false)
/// </summary>
public bool? in_trans { get; set; }
/// <summary>
///  transpose video output (default false)
/// </summary>
public bool? out_trans { get; set; }
/// <summary>
///  input horizontal field of view (from 1e-05 to 360) (default 90)
/// </summary>
public float? ih_fov { get; set; }
/// <summary>
///  input vertical field of view (from 1e-05 to 360) (default 45)
/// </summary>
public float? iv_fov { get; set; }
/// <summary>
///  input diagonal field of view (from 0 to 360) (default 0)
/// </summary>
public float? id_fov { get; set; }
/// <summary>
///  build mask in alpha plane (default false)
/// </summary>
public bool? alpha_mask { get; set; }
}
public enum V360FilterGenInput
{
[Name("e")] e,
[Name("equirect")] equirect,
[Name("c3x2")] c3x2,
[Name("c6x1")] c6x1,
[Name("eac")] eac,
[Name("dfisheye")] dfisheye,
[Name("flat")] flat,
[Name("rectilinear")] rectilinear,
[Name("gnomonic")] gnomonic,
[Name("barrel")] barrel,
[Name("fb")] fb,
[Name("c1x6")] c1x6,
[Name("sg")] sg,
[Name("mercator")] mercator,
[Name("ball")] ball,
[Name("hammer")] hammer,
[Name("sinusoidal")] sinusoidal,
[Name("fisheye")] fisheye,
[Name("pannini")] pannini,
[Name("cylindrical")] cylindrical,
[Name("tetrahedron")] tetrahedron,
[Name("barrelsplit")] barrelsplit,
[Name("tsp")] tsp,
[Name("hequirect")] hequirect,
[Name("he")] he,
[Name("equisolid")] equisolid,
[Name("og")] og,
[Name("octahedron")] octahedron,
}

public enum V360FilterGenOutput
{
[Name("e")] e,
[Name("equirect")] equirect,
[Name("c3x2")] c3x2,
[Name("c6x1")] c6x1,
[Name("eac")] eac,
[Name("dfisheye")] dfisheye,
[Name("flat")] flat,
[Name("rectilinear")] rectilinear,
[Name("gnomonic")] gnomonic,
[Name("barrel")] barrel,
[Name("fb")] fb,
[Name("c1x6")] c1x6,
[Name("sg")] sg,
[Name("mercator")] mercator,
[Name("ball")] ball,
[Name("hammer")] hammer,
[Name("sinusoidal")] sinusoidal,
[Name("fisheye")] fisheye,
[Name("pannini")] pannini,
[Name("cylindrical")] cylindrical,
[Name("perspective")] perspective,
[Name("tetrahedron")] tetrahedron,
[Name("barrelsplit")] barrelsplit,
[Name("tsp")] tsp,
[Name("hequirect")] hequirect,
[Name("he")] he,
[Name("equisolid")] equisolid,
[Name("og")] og,
[Name("octahedron")] octahedron,
}

public enum V360FilterGenInterp
{
[Name("near")] near,
[Name("nearest")] nearest,
[Name("line")] line,
[Name("linear")] linear,
[Name("lagrange9")] lagrange9,
[Name("cube")] cube,
[Name("cubic")] cubic,
[Name("lanc")] lanc,
[Name("lanczos")] lanczos,
[Name("sp16")] sp16,
[Name("spline16")] spline16,
[Name("gauss")] gauss,
[Name("gaussian")] gaussian,
[Name("mitchell")] mitchell,
}

public enum V360FilterGenIn_stereo
{
[Name("2d")] _2d,
[Name("sbs")] sbs,
[Name("tb")] tb,
}

public enum V360FilterGenOut_stereo
{
[Name("2d")] _2d,
[Name("sbs")] sbs,
[Name("tb")] tb,
}

}
