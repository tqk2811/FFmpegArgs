namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC pseudocolor       V->V       Make pseudocolored video frames.
/// </summary>
public class PseudocolorFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal PseudocolorFilterGen(ImageMap input) : base("pseudocolor",input) { AddMapOut(); }
/// <summary>
///  set component #0 expression (default "val")
/// </summary>
public PseudocolorFilterGen c0(ExpressionValue c0) => this.SetOption("c0",(string)c0);
/// <summary>
///  set component #1 expression (default "val")
/// </summary>
public PseudocolorFilterGen c1(ExpressionValue c1) => this.SetOption("c1",(string)c1);
/// <summary>
///  set component #2 expression (default "val")
/// </summary>
public PseudocolorFilterGen c2(ExpressionValue c2) => this.SetOption("c2",(string)c2);
/// <summary>
///  set component #3 expression (default "val")
/// </summary>
public PseudocolorFilterGen c3(ExpressionValue c3) => this.SetOption("c3",(string)c3);
/// <summary>
///  set component as base (from 0 to 3) (default 0)
/// </summary>
public PseudocolorFilterGen index(int index) => this.SetOptionRange("index", index,0,3);
/// <summary>
///  set preset (from -1 to 20) (default none)
/// </summary>
public PseudocolorFilterGen preset(PseudocolorFilterGenPreset preset) => this.SetOption("preset", preset.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set pseudocolor opacity (from 0 to 1) (default 1)
/// </summary>
public PseudocolorFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity,0,1);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Make pseudocolored video frames.
/// </summary>
public static PseudocolorFilterGen PseudocolorFilterGen(this ImageMap input0) => new PseudocolorFilterGen(input0);
}
/// <summary>
///  set preset (from -1 to 20) (default none)
/// </summary>
public enum PseudocolorFilterGenPreset
{
/// <summary>
/// none            -1           ..FV.....T.
/// </summary>
[Name("none")] none,
/// <summary>
/// magma           0            ..FV.....T.
/// </summary>
[Name("magma")] magma,
/// <summary>
/// inferno         1            ..FV.....T.
/// </summary>
[Name("inferno")] inferno,
/// <summary>
/// plasma          2            ..FV.....T.
/// </summary>
[Name("plasma")] plasma,
/// <summary>
/// viridis         3            ..FV.....T.
/// </summary>
[Name("viridis")] viridis,
/// <summary>
/// turbo           4            ..FV.....T.
/// </summary>
[Name("turbo")] turbo,
/// <summary>
/// cividis         5            ..FV.....T.
/// </summary>
[Name("cividis")] cividis,
/// <summary>
/// range1          6            ..FV.....T.
/// </summary>
[Name("range1")] range1,
/// <summary>
/// range2          7            ..FV.....T.
/// </summary>
[Name("range2")] range2,
/// <summary>
/// shadows         8            ..FV.....T.
/// </summary>
[Name("shadows")] shadows,
/// <summary>
/// highlights      9            ..FV.....T.
/// </summary>
[Name("highlights")] highlights,
/// <summary>
/// solar           10           ..FV.....T.
/// </summary>
[Name("solar")] solar,
/// <summary>
/// nominal         11           ..FV.....T.
/// </summary>
[Name("nominal")] nominal,
/// <summary>
/// preferred       12           ..FV.....T.
/// </summary>
[Name("preferred")] preferred,
/// <summary>
/// total           13           ..FV.....T.
/// </summary>
[Name("total")] total,
/// <summary>
/// spectral        14           ..FV.....T.
/// </summary>
[Name("spectral")] spectral,
/// <summary>
/// cool            15           ..FV.....T.
/// </summary>
[Name("cool")] cool,
/// <summary>
/// heat            16           ..FV.....T.
/// </summary>
[Name("heat")] heat,
/// <summary>
/// fiery           17           ..FV.....T.
/// </summary>
[Name("fiery")] fiery,
/// <summary>
/// blues           18           ..FV.....T.
/// </summary>
[Name("blues")] blues,
/// <summary>
/// green           19           ..FV.....T.
/// </summary>
[Name("green")] green,
/// <summary>
/// helix           20           ..FV.....T.
/// </summary>
[Name("helix")] helix,
}

}
