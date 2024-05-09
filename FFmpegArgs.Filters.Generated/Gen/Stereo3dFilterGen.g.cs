namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .S. stereo3d          V->V       Convert video stereoscopic 3D view.
/// </summary>
public class Stereo3dFilterGen : ImageToImageFilter,ISliceThreading
{
internal Stereo3dFilterGen(ImageMap input) : base("stereo3d",input) { AddMapOut(); }
/// <summary>
///  set input format (from 16 to 32) (default sbsl)
/// </summary>
public Stereo3dFilterGen _in(Stereo3dFilterGenIn _in) => this.SetOption("in", _in.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set output format (from 0 to 32) (default arcd)
/// </summary>
public Stereo3dFilterGen _out(Stereo3dFilterGenOut _out) => this.SetOption("out", _out.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class Stereo3dFilterGenExtensions
{
/// <summary>
/// Convert video stereoscopic 3D view.
/// </summary>
public static Stereo3dFilterGen Stereo3dFilterGen(this ImageMap input0) => new Stereo3dFilterGen(input0);
}
/// <summary>
///  set input format (from 16 to 32) (default sbsl)
/// </summary>
public enum Stereo3dFilterGenIn
{
/// <summary>
/// ab2l            24           ..FV....... above below half height left first
/// </summary>
[Name("ab2l")] ab2l,
/// <summary>
/// tb2l            24           ..FV....... above below half height left first
/// </summary>
[Name("tb2l")] tb2l,
/// <summary>
/// ab2r            25           ..FV....... above below half height right first
/// </summary>
[Name("ab2r")] ab2r,
/// <summary>
/// tb2r            25           ..FV....... above below half height right first
/// </summary>
[Name("tb2r")] tb2r,
/// <summary>
/// abl             22           ..FV....... above below left first
/// </summary>
[Name("abl")] abl,
/// <summary>
/// tbl             22           ..FV....... above below left first
/// </summary>
[Name("tbl")] tbl,
/// <summary>
/// abr             23           ..FV....... above below right first
/// </summary>
[Name("abr")] abr,
/// <summary>
/// tbr             23           ..FV....... above below right first
/// </summary>
[Name("tbr")] tbr,
/// <summary>
/// al              26           ..FV....... alternating frames left first
/// </summary>
[Name("al")] al,
/// <summary>
/// ar              27           ..FV....... alternating frames right first
/// </summary>
[Name("ar")] ar,
/// <summary>
/// sbs2l           20           ..FV....... side by side half width left first
/// </summary>
[Name("sbs2l")] sbs2l,
/// <summary>
/// sbs2r           21           ..FV....... side by side half width right first
/// </summary>
[Name("sbs2r")] sbs2r,
/// <summary>
/// sbsl            18           ..FV....... side by side left first
/// </summary>
[Name("sbsl")] sbsl,
/// <summary>
/// sbsr            19           ..FV....... side by side right first
/// </summary>
[Name("sbsr")] sbsr,
/// <summary>
/// irl             16           ..FV....... interleave rows left first
/// </summary>
[Name("irl")] irl,
/// <summary>
/// irr             17           ..FV....... interleave rows right first
/// </summary>
[Name("irr")] irr,
/// <summary>
/// icl             30           ..FV....... interleave columns left first
/// </summary>
[Name("icl")] icl,
/// <summary>
/// icr             31           ..FV....... interleave columns right first
/// </summary>
[Name("icr")] icr,
}

/// <summary>
///  set output format (from 0 to 32) (default arcd)
/// </summary>
public enum Stereo3dFilterGenOut
{
/// <summary>
/// ab2l            24           ..FV....... above below half height left first
/// </summary>
[Name("ab2l")] ab2l,
/// <summary>
/// tb2l            24           ..FV....... above below half height left first
/// </summary>
[Name("tb2l")] tb2l,
/// <summary>
/// ab2r            25           ..FV....... above below half height right first
/// </summary>
[Name("ab2r")] ab2r,
/// <summary>
/// tb2r            25           ..FV....... above below half height right first
/// </summary>
[Name("tb2r")] tb2r,
/// <summary>
/// abl             22           ..FV....... above below left first
/// </summary>
[Name("abl")] abl,
/// <summary>
/// tbl             22           ..FV....... above below left first
/// </summary>
[Name("tbl")] tbl,
/// <summary>
/// abr             23           ..FV....... above below right first
/// </summary>
[Name("abr")] abr,
/// <summary>
/// tbr             23           ..FV....... above below right first
/// </summary>
[Name("tbr")] tbr,
/// <summary>
/// agmc            6            ..FV....... anaglyph green magenta color
/// </summary>
[Name("agmc")] agmc,
/// <summary>
/// agmd            7            ..FV....... anaglyph green magenta dubois
/// </summary>
[Name("agmd")] agmd,
/// <summary>
/// agmg            4            ..FV....... anaglyph green magenta gray
/// </summary>
[Name("agmg")] agmg,
/// <summary>
/// agmh            5            ..FV....... anaglyph green magenta half color
/// </summary>
[Name("agmh")] agmh,
/// <summary>
/// al              26           ..FV....... alternating frames left first
/// </summary>
[Name("al")] al,
/// <summary>
/// ar              27           ..FV....... alternating frames right first
/// </summary>
[Name("ar")] ar,
/// <summary>
/// arbg            12           ..FV....... anaglyph red blue gray
/// </summary>
[Name("arbg")] arbg,
/// <summary>
/// arcc            2            ..FV....... anaglyph red cyan color
/// </summary>
[Name("arcc")] arcc,
/// <summary>
/// arcd            3            ..FV....... anaglyph red cyan dubois
/// </summary>
[Name("arcd")] arcd,
/// <summary>
/// arcg            0            ..FV....... anaglyph red cyan gray
/// </summary>
[Name("arcg")] arcg,
/// <summary>
/// arch            1            ..FV....... anaglyph red cyan half color
/// </summary>
[Name("arch")] arch,
/// <summary>
/// argg            13           ..FV....... anaglyph red green gray
/// </summary>
[Name("argg")] argg,
/// <summary>
/// aybc            10           ..FV....... anaglyph yellow blue color
/// </summary>
[Name("aybc")] aybc,
/// <summary>
/// aybd            11           ..FV....... anaglyph yellow blue dubois
/// </summary>
[Name("aybd")] aybd,
/// <summary>
/// aybg            8            ..FV....... anaglyph yellow blue gray
/// </summary>
[Name("aybg")] aybg,
/// <summary>
/// aybh            9            ..FV....... anaglyph yellow blue half color
/// </summary>
[Name("aybh")] aybh,
/// <summary>
/// irl             16           ..FV....... interleave rows left first
/// </summary>
[Name("irl")] irl,
/// <summary>
/// irr             17           ..FV....... interleave rows right first
/// </summary>
[Name("irr")] irr,
/// <summary>
/// ml              14           ..FV....... mono left
/// </summary>
[Name("ml")] ml,
/// <summary>
/// mr              15           ..FV....... mono right
/// </summary>
[Name("mr")] mr,
/// <summary>
/// sbs2l           20           ..FV....... side by side half width left first
/// </summary>
[Name("sbs2l")] sbs2l,
/// <summary>
/// sbs2r           21           ..FV....... side by side half width right first
/// </summary>
[Name("sbs2r")] sbs2r,
/// <summary>
/// sbsl            18           ..FV....... side by side left first
/// </summary>
[Name("sbsl")] sbsl,
/// <summary>
/// sbsr            19           ..FV....... side by side right first
/// </summary>
[Name("sbsr")] sbsr,
/// <summary>
/// chl             28           ..FV....... checkerboard left first
/// </summary>
[Name("chl")] chl,
/// <summary>
/// chr             29           ..FV....... checkerboard right first
/// </summary>
[Name("chr")] chr,
/// <summary>
/// icl             30           ..FV....... interleave columns left first
/// </summary>
[Name("icl")] icl,
/// <summary>
/// icr             31           ..FV....... interleave columns right first
/// </summary>
[Name("icr")] icr,
/// <summary>
/// hdmi            32           ..FV....... HDMI frame pack
/// </summary>
[Name("hdmi")] hdmi,
}

}
