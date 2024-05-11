namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .SC v360              V-&gt;V       Convert 360 projection of video.
/// </summary>
public class V360FilterGen : ImageToImageFilter,ISliceThreading,ICommandSupport
{
internal V360FilterGen(ImageMap input) : base("v360",input) { AddMapOut(); }
/// <summary>
///  set input projection (from 0 to 24) (default e)
/// </summary>
public V360FilterGen input(V360FilterGenInput input) => this.SetOption("input", input.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set output projection (from 0 to 24) (default c3x2)
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
///  input cubemap face order (default &quot;rludfb&quot;)
/// </summary>
public V360FilterGen in_forder(string in_forder) => this.SetOption("in_forder",in_forder);
/// <summary>
///  output cubemap face order (default &quot;rludfb&quot;)
/// </summary>
public V360FilterGen out_forder(string out_forder) => this.SetOption("out_forder",out_forder);
/// <summary>
///  input cubemap face rotation (default &quot;000000&quot;)
/// </summary>
public V360FilterGen in_frot(string in_frot) => this.SetOption("in_frot",in_frot);
/// <summary>
///  output cubemap face rotation (default &quot;000000&quot;)
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
///  rotation order (default &quot;ypr&quot;)
/// </summary>
public V360FilterGen rorder(string rorder) => this.SetOption("rorder",rorder);
/// <summary>
///  output horizontal field of view (from 0 to 360) (default 0)
/// </summary>
public V360FilterGen h_fov(float h_fov) => this.SetOptionRange("h_fov", h_fov,0,360);
/// <summary>
///  output vertical field of view (from 0 to 360) (default 0)
/// </summary>
public V360FilterGen v_fov(float v_fov) => this.SetOptionRange("v_fov", v_fov,0,360);
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
///  input horizontal field of view (from 0 to 360) (default 0)
/// </summary>
public V360FilterGen ih_fov(float ih_fov) => this.SetOptionRange("ih_fov", ih_fov,0,360);
/// <summary>
///  input vertical field of view (from 0 to 360) (default 0)
/// </summary>
public V360FilterGen iv_fov(float iv_fov) => this.SetOptionRange("iv_fov", iv_fov,0,360);
/// <summary>
///  input diagonal field of view (from 0 to 360) (default 0)
/// </summary>
public V360FilterGen id_fov(float id_fov) => this.SetOptionRange("id_fov", id_fov,0,360);
/// <summary>
///  output horizontal off-axis offset (from -1 to 1) (default 0)
/// </summary>
public V360FilterGen h_offset(float h_offset) => this.SetOptionRange("h_offset", h_offset,-1,1);
/// <summary>
///  output vertical off-axis offset (from -1 to 1) (default 0)
/// </summary>
public V360FilterGen v_offset(float v_offset) => this.SetOptionRange("v_offset", v_offset,-1,1);
/// <summary>
///  build mask in alpha plane (default false)
/// </summary>
public V360FilterGen alpha_mask(bool alpha_mask) => this.SetOption("alpha_mask",alpha_mask.ToFFmpegFlag());
/// <summary>
///  reset rotation (default false)
/// </summary>
public V360FilterGen reset_rot(bool reset_rot) => this.SetOption("reset_rot",reset_rot.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Convert 360 projection of video.
/// </summary>
public static V360FilterGen V360FilterGen(this ImageMap input0) => new V360FilterGen(input0);
}
/// <summary>
///  set input projection (from 0 to 24) (default e)
/// </summary>
public enum V360FilterGenInput
{
/// <summary>
/// e               0            ..FV....... equirectangular
/// </summary>
[Name("e")] e,
/// <summary>
/// equirect        0            ..FV....... equirectangular
/// </summary>
[Name("equirect")] equirect,
/// <summary>
/// c3x2            1            ..FV....... cubemap 3x2
/// </summary>
[Name("c3x2")] c3x2,
/// <summary>
/// c6x1            2            ..FV....... cubemap 6x1
/// </summary>
[Name("c6x1")] c6x1,
/// <summary>
/// eac             3            ..FV....... equi-angular cubemap
/// </summary>
[Name("eac")] eac,
/// <summary>
/// dfisheye        5            ..FV....... dual fisheye
/// </summary>
[Name("dfisheye")] dfisheye,
/// <summary>
/// flat            4            ..FV....... regular video
/// </summary>
[Name("flat")] flat,
/// <summary>
/// rectilinear     4            ..FV....... regular video
/// </summary>
[Name("rectilinear")] rectilinear,
/// <summary>
/// gnomonic        4            ..FV....... regular video
/// </summary>
[Name("gnomonic")] gnomonic,
/// <summary>
/// barrel          6            ..FV....... barrel facebook&#39;s 360 format
/// </summary>
[Name("barrel")] barrel,
/// <summary>
/// fb              6            ..FV....... barrel facebook&#39;s 360 format
/// </summary>
[Name("fb")] fb,
/// <summary>
/// c1x6            7            ..FV....... cubemap 1x6
/// </summary>
[Name("c1x6")] c1x6,
/// <summary>
/// sg              8            ..FV....... stereographic
/// </summary>
[Name("sg")] sg,
/// <summary>
/// mercator        9            ..FV....... mercator
/// </summary>
[Name("mercator")] mercator,
/// <summary>
/// ball            10           ..FV....... ball
/// </summary>
[Name("ball")] ball,
/// <summary>
/// hammer          11           ..FV....... hammer
/// </summary>
[Name("hammer")] hammer,
/// <summary>
/// sinusoidal      12           ..FV....... sinusoidal
/// </summary>
[Name("sinusoidal")] sinusoidal,
/// <summary>
/// fisheye         13           ..FV....... fisheye
/// </summary>
[Name("fisheye")] fisheye,
/// <summary>
/// pannini         14           ..FV....... pannini
/// </summary>
[Name("pannini")] pannini,
/// <summary>
/// cylindrical     15           ..FV....... cylindrical
/// </summary>
[Name("cylindrical")] cylindrical,
/// <summary>
/// tetrahedron     17           ..FV....... tetrahedron
/// </summary>
[Name("tetrahedron")] tetrahedron,
/// <summary>
/// barrelsplit     18           ..FV....... barrel split facebook&#39;s 360 format
/// </summary>
[Name("barrelsplit")] barrelsplit,
/// <summary>
/// tsp             19           ..FV....... truncated square pyramid
/// </summary>
[Name("tsp")] tsp,
/// <summary>
/// hequirect       20           ..FV....... half equirectangular
/// </summary>
[Name("hequirect")] hequirect,
/// <summary>
/// he              20           ..FV....... half equirectangular
/// </summary>
[Name("he")] he,
/// <summary>
/// equisolid       21           ..FV....... equisolid
/// </summary>
[Name("equisolid")] equisolid,
/// <summary>
/// og              22           ..FV....... orthographic
/// </summary>
[Name("og")] og,
/// <summary>
/// octahedron      23           ..FV....... octahedron
/// </summary>
[Name("octahedron")] octahedron,
/// <summary>
/// cylindricalea   24           ..FV....... cylindrical equal area
/// </summary>
[Name("cylindricalea")] cylindricalea,
}

/// <summary>
///  set output projection (from 0 to 24) (default c3x2)
/// </summary>
public enum V360FilterGenOutput
{
/// <summary>
/// e               0            ..FV....... equirectangular
/// </summary>
[Name("e")] e,
/// <summary>
/// equirect        0            ..FV....... equirectangular
/// </summary>
[Name("equirect")] equirect,
/// <summary>
/// c3x2            1            ..FV....... cubemap 3x2
/// </summary>
[Name("c3x2")] c3x2,
/// <summary>
/// c6x1            2            ..FV....... cubemap 6x1
/// </summary>
[Name("c6x1")] c6x1,
/// <summary>
/// eac             3            ..FV....... equi-angular cubemap
/// </summary>
[Name("eac")] eac,
/// <summary>
/// dfisheye        5            ..FV....... dual fisheye
/// </summary>
[Name("dfisheye")] dfisheye,
/// <summary>
/// flat            4            ..FV....... regular video
/// </summary>
[Name("flat")] flat,
/// <summary>
/// rectilinear     4            ..FV....... regular video
/// </summary>
[Name("rectilinear")] rectilinear,
/// <summary>
/// gnomonic        4            ..FV....... regular video
/// </summary>
[Name("gnomonic")] gnomonic,
/// <summary>
/// barrel          6            ..FV....... barrel facebook&#39;s 360 format
/// </summary>
[Name("barrel")] barrel,
/// <summary>
/// fb              6            ..FV....... barrel facebook&#39;s 360 format
/// </summary>
[Name("fb")] fb,
/// <summary>
/// c1x6            7            ..FV....... cubemap 1x6
/// </summary>
[Name("c1x6")] c1x6,
/// <summary>
/// sg              8            ..FV....... stereographic
/// </summary>
[Name("sg")] sg,
/// <summary>
/// mercator        9            ..FV....... mercator
/// </summary>
[Name("mercator")] mercator,
/// <summary>
/// ball            10           ..FV....... ball
/// </summary>
[Name("ball")] ball,
/// <summary>
/// hammer          11           ..FV....... hammer
/// </summary>
[Name("hammer")] hammer,
/// <summary>
/// sinusoidal      12           ..FV....... sinusoidal
/// </summary>
[Name("sinusoidal")] sinusoidal,
/// <summary>
/// fisheye         13           ..FV....... fisheye
/// </summary>
[Name("fisheye")] fisheye,
/// <summary>
/// pannini         14           ..FV....... pannini
/// </summary>
[Name("pannini")] pannini,
/// <summary>
/// cylindrical     15           ..FV....... cylindrical
/// </summary>
[Name("cylindrical")] cylindrical,
/// <summary>
/// perspective     16           ..FV....... perspective
/// </summary>
[Name("perspective")] perspective,
/// <summary>
/// tetrahedron     17           ..FV....... tetrahedron
/// </summary>
[Name("tetrahedron")] tetrahedron,
/// <summary>
/// barrelsplit     18           ..FV....... barrel split facebook&#39;s 360 format
/// </summary>
[Name("barrelsplit")] barrelsplit,
/// <summary>
/// tsp             19           ..FV....... truncated square pyramid
/// </summary>
[Name("tsp")] tsp,
/// <summary>
/// hequirect       20           ..FV....... half equirectangular
/// </summary>
[Name("hequirect")] hequirect,
/// <summary>
/// he              20           ..FV....... half equirectangular
/// </summary>
[Name("he")] he,
/// <summary>
/// equisolid       21           ..FV....... equisolid
/// </summary>
[Name("equisolid")] equisolid,
/// <summary>
/// og              22           ..FV....... orthographic
/// </summary>
[Name("og")] og,
/// <summary>
/// octahedron      23           ..FV....... octahedron
/// </summary>
[Name("octahedron")] octahedron,
/// <summary>
/// cylindricalea   24           ..FV....... cylindrical equal area
/// </summary>
[Name("cylindricalea")] cylindricalea,
}

/// <summary>
///  set interpolation method (from 0 to 7) (default line)
/// </summary>
public enum V360FilterGenInterp
{
/// <summary>
/// near            0            ..FV....... nearest neighbour
/// </summary>
[Name("near")] near,
/// <summary>
/// nearest         0            ..FV....... nearest neighbour
/// </summary>
[Name("nearest")] nearest,
/// <summary>
/// line            1            ..FV....... bilinear interpolation
/// </summary>
[Name("line")] line,
/// <summary>
/// linear          1            ..FV....... bilinear interpolation
/// </summary>
[Name("linear")] linear,
/// <summary>
/// lagrange9       2            ..FV....... lagrange9 interpolation
/// </summary>
[Name("lagrange9")] lagrange9,
/// <summary>
/// cube            3            ..FV....... bicubic interpolation
/// </summary>
[Name("cube")] cube,
/// <summary>
/// cubic           3            ..FV....... bicubic interpolation
/// </summary>
[Name("cubic")] cubic,
/// <summary>
/// lanc            4            ..FV....... lanczos interpolation
/// </summary>
[Name("lanc")] lanc,
/// <summary>
/// lanczos         4            ..FV....... lanczos interpolation
/// </summary>
[Name("lanczos")] lanczos,
/// <summary>
/// sp16            5            ..FV....... spline16 interpolation
/// </summary>
[Name("sp16")] sp16,
/// <summary>
/// spline16        5            ..FV....... spline16 interpolation
/// </summary>
[Name("spline16")] spline16,
/// <summary>
/// gauss           6            ..FV....... gaussian interpolation
/// </summary>
[Name("gauss")] gauss,
/// <summary>
/// gaussian        6            ..FV....... gaussian interpolation
/// </summary>
[Name("gaussian")] gaussian,
/// <summary>
/// mitchell        7            ..FV....... mitchell interpolation
/// </summary>
[Name("mitchell")] mitchell,
}

/// <summary>
///  input stereo format (from 0 to 2) (default 2d)
/// </summary>
public enum V360FilterGenIn_stereo
{
/// <summary>
/// 2d              0            ..FV....... 2d mono
/// </summary>
[Name("2d")] _2d,
/// <summary>
/// sbs             1            ..FV....... side by side
/// </summary>
[Name("sbs")] sbs,
/// <summary>
/// tb              2            ..FV....... top bottom
/// </summary>
[Name("tb")] tb,
}

/// <summary>
///  output stereo format (from 0 to 2) (default 2d)
/// </summary>
public enum V360FilterGenOut_stereo
{
/// <summary>
/// 2d              0            ..FV....... 2d mono
/// </summary>
[Name("2d")] _2d,
/// <summary>
/// sbs             1            ..FV....... side by side
/// </summary>
[Name("sbs")] sbs,
/// <summary>
/// tb              2            ..FV....... top bottom
/// </summary>
[Name("tb")] tb,
}

}
