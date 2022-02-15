namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC tblend            V->V       Blend successive frames.
/// </summary>
public class TblendFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal TblendFilterGen(ImageMap input) : base("tblend",input) { AddMapOut(); }
/// <summary>
///  set component #0 blend mode (from 0 to 32) (default normal)
/// </summary>
public TblendFilterGen c0_mode(TblendFilterGenC0_mode c0_mode) => this.SetOption("c0_mode", c0_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set component #1 blend mode (from 0 to 32) (default normal)
/// </summary>
public TblendFilterGen c1_mode(TblendFilterGenC1_mode c1_mode) => this.SetOption("c1_mode", c1_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set component #2 blend mode (from 0 to 32) (default normal)
/// </summary>
public TblendFilterGen c2_mode(TblendFilterGenC2_mode c2_mode) => this.SetOption("c2_mode", c2_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set component #3 blend mode (from 0 to 32) (default normal)
/// </summary>
public TblendFilterGen c3_mode(TblendFilterGenC3_mode c3_mode) => this.SetOption("c3_mode", c3_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set blend mode for all components (from -1 to 32) (default -1)
/// </summary>
public TblendFilterGen all_mode(TblendFilterGenAll_mode all_mode) => this.SetOption("all_mode", all_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set color component #0 expression
/// </summary>
public TblendFilterGen c0_expr(string c0_expr) => this.SetOption("c0_expr",c0_expr);
/// <summary>
///  set color component #1 expression
/// </summary>
public TblendFilterGen c1_expr(string c1_expr) => this.SetOption("c1_expr",c1_expr);
/// <summary>
///  set color component #2 expression
/// </summary>
public TblendFilterGen c2_expr(string c2_expr) => this.SetOption("c2_expr",c2_expr);
/// <summary>
///  set color component #3 expression
/// </summary>
public TblendFilterGen c3_expr(string c3_expr) => this.SetOption("c3_expr",c3_expr);
/// <summary>
///  set expression for all color components
/// </summary>
public TblendFilterGen all_expr(string all_expr) => this.SetOption("all_expr",all_expr);
/// <summary>
///  set color component #0 opacity (from 0 to 1) (default 1)
/// </summary>
public TblendFilterGen c0_opacity(double c0_opacity) => this.SetOptionRange("c0_opacity", c0_opacity,0,1);
/// <summary>
///  set color component #1 opacity (from 0 to 1) (default 1)
/// </summary>
public TblendFilterGen c1_opacity(double c1_opacity) => this.SetOptionRange("c1_opacity", c1_opacity,0,1);
/// <summary>
///  set color component #2 opacity (from 0 to 1) (default 1)
/// </summary>
public TblendFilterGen c2_opacity(double c2_opacity) => this.SetOptionRange("c2_opacity", c2_opacity,0,1);
/// <summary>
///  set color component #3 opacity (from 0 to 1) (default 1)
/// </summary>
public TblendFilterGen c3_opacity(double c3_opacity) => this.SetOptionRange("c3_opacity", c3_opacity,0,1);
/// <summary>
///  set opacity for all color components (from 0 to 1) (default 1)
/// </summary>
public TblendFilterGen all_opacity(double all_opacity) => this.SetOptionRange("all_opacity", all_opacity,0,1);
}
/// <summary>
/// </summary>
public static class TblendFilterGenExtensions
{
/// <summary>
/// Blend successive frames.
/// </summary>
public static TblendFilterGen TblendFilterGen(this ImageMap input0) => new TblendFilterGen(input0);
}
/// <summary>
///  set component #0 blend mode (from 0 to 32) (default normal)
/// </summary>
public enum TblendFilterGenC0_mode
{
/// <summary>
/// addition        1            ..FV.....T.
/// </summary>
[Name("addition")] addition,
/// <summary>
/// addition128     28           ..FV.....T.
/// </summary>
[Name("addition128")] addition128,
/// <summary>
/// grainmerge      28           ..FV.....T.
/// </summary>
[Name("grainmerge")] grainmerge,
/// <summary>
/// and             2            ..FV.....T.
/// </summary>
[Name("and")] and,
/// <summary>
/// average         3            ..FV.....T.
/// </summary>
[Name("average")] average,
/// <summary>
/// burn            4            ..FV.....T.
/// </summary>
[Name("burn")] burn,
/// <summary>
/// darken          5            ..FV.....T.
/// </summary>
[Name("darken")] darken,
/// <summary>
/// difference      6            ..FV.....T.
/// </summary>
[Name("difference")] difference,
/// <summary>
/// difference128   7            ..FV.....T.
/// </summary>
[Name("difference128")] difference128,
/// <summary>
/// grainextract    7            ..FV.....T.
/// </summary>
[Name("grainextract")] grainextract,
/// <summary>
/// divide          8            ..FV.....T.
/// </summary>
[Name("divide")] divide,
/// <summary>
/// dodge           9            ..FV.....T.
/// </summary>
[Name("dodge")] dodge,
/// <summary>
/// exclusion       10           ..FV.....T.
/// </summary>
[Name("exclusion")] exclusion,
/// <summary>
/// extremity       32           ..FV.....T.
/// </summary>
[Name("extremity")] extremity,
/// <summary>
/// freeze          31           ..FV.....T.
/// </summary>
[Name("freeze")] freeze,
/// <summary>
/// glow            27           ..FV.....T.
/// </summary>
[Name("glow")] glow,
/// <summary>
/// hardlight       11           ..FV.....T.
/// </summary>
[Name("hardlight")] hardlight,
/// <summary>
/// hardmix         25           ..FV.....T.
/// </summary>
[Name("hardmix")] hardmix,
/// <summary>
/// heat            30           ..FV.....T.
/// </summary>
[Name("heat")] heat,
/// <summary>
/// lighten         12           ..FV.....T.
/// </summary>
[Name("lighten")] lighten,
/// <summary>
/// linearlight     26           ..FV.....T.
/// </summary>
[Name("linearlight")] linearlight,
/// <summary>
/// multiply        13           ..FV.....T.
/// </summary>
[Name("multiply")] multiply,
/// <summary>
/// multiply128     29           ..FV.....T.
/// </summary>
[Name("multiply128")] multiply128,
/// <summary>
/// negation        14           ..FV.....T.
/// </summary>
[Name("negation")] negation,
/// <summary>
/// normal          0            ..FV.....T.
/// </summary>
[Name("normal")] normal,
/// <summary>
/// or              15           ..FV.....T.
/// </summary>
[Name("or")] or,
/// <summary>
/// overlay         16           ..FV.....T.
/// </summary>
[Name("overlay")] overlay,
/// <summary>
/// phoenix         17           ..FV.....T.
/// </summary>
[Name("phoenix")] phoenix,
/// <summary>
/// pinlight        18           ..FV.....T.
/// </summary>
[Name("pinlight")] pinlight,
/// <summary>
/// reflect         19           ..FV.....T.
/// </summary>
[Name("reflect")] reflect,
/// <summary>
/// screen          20           ..FV.....T.
/// </summary>
[Name("screen")] screen,
/// <summary>
/// softlight       21           ..FV.....T.
/// </summary>
[Name("softlight")] softlight,
/// <summary>
/// subtract        22           ..FV.....T.
/// </summary>
[Name("subtract")] subtract,
/// <summary>
/// vividlight      23           ..FV.....T.
/// </summary>
[Name("vividlight")] vividlight,
/// <summary>
/// xor             24           ..FV.....T.
/// </summary>
[Name("xor")] xor,
}

/// <summary>
///  set component #1 blend mode (from 0 to 32) (default normal)
/// </summary>
public enum TblendFilterGenC1_mode
{
/// <summary>
/// addition        1            ..FV.....T.
/// </summary>
[Name("addition")] addition,
/// <summary>
/// addition128     28           ..FV.....T.
/// </summary>
[Name("addition128")] addition128,
/// <summary>
/// grainmerge      28           ..FV.....T.
/// </summary>
[Name("grainmerge")] grainmerge,
/// <summary>
/// and             2            ..FV.....T.
/// </summary>
[Name("and")] and,
/// <summary>
/// average         3            ..FV.....T.
/// </summary>
[Name("average")] average,
/// <summary>
/// burn            4            ..FV.....T.
/// </summary>
[Name("burn")] burn,
/// <summary>
/// darken          5            ..FV.....T.
/// </summary>
[Name("darken")] darken,
/// <summary>
/// difference      6            ..FV.....T.
/// </summary>
[Name("difference")] difference,
/// <summary>
/// difference128   7            ..FV.....T.
/// </summary>
[Name("difference128")] difference128,
/// <summary>
/// grainextract    7            ..FV.....T.
/// </summary>
[Name("grainextract")] grainextract,
/// <summary>
/// divide          8            ..FV.....T.
/// </summary>
[Name("divide")] divide,
/// <summary>
/// dodge           9            ..FV.....T.
/// </summary>
[Name("dodge")] dodge,
/// <summary>
/// exclusion       10           ..FV.....T.
/// </summary>
[Name("exclusion")] exclusion,
/// <summary>
/// extremity       32           ..FV.....T.
/// </summary>
[Name("extremity")] extremity,
/// <summary>
/// freeze          31           ..FV.....T.
/// </summary>
[Name("freeze")] freeze,
/// <summary>
/// glow            27           ..FV.....T.
/// </summary>
[Name("glow")] glow,
/// <summary>
/// hardlight       11           ..FV.....T.
/// </summary>
[Name("hardlight")] hardlight,
/// <summary>
/// hardmix         25           ..FV.....T.
/// </summary>
[Name("hardmix")] hardmix,
/// <summary>
/// heat            30           ..FV.....T.
/// </summary>
[Name("heat")] heat,
/// <summary>
/// lighten         12           ..FV.....T.
/// </summary>
[Name("lighten")] lighten,
/// <summary>
/// linearlight     26           ..FV.....T.
/// </summary>
[Name("linearlight")] linearlight,
/// <summary>
/// multiply        13           ..FV.....T.
/// </summary>
[Name("multiply")] multiply,
/// <summary>
/// multiply128     29           ..FV.....T.
/// </summary>
[Name("multiply128")] multiply128,
/// <summary>
/// negation        14           ..FV.....T.
/// </summary>
[Name("negation")] negation,
/// <summary>
/// normal          0            ..FV.....T.
/// </summary>
[Name("normal")] normal,
/// <summary>
/// or              15           ..FV.....T.
/// </summary>
[Name("or")] or,
/// <summary>
/// overlay         16           ..FV.....T.
/// </summary>
[Name("overlay")] overlay,
/// <summary>
/// phoenix         17           ..FV.....T.
/// </summary>
[Name("phoenix")] phoenix,
/// <summary>
/// pinlight        18           ..FV.....T.
/// </summary>
[Name("pinlight")] pinlight,
/// <summary>
/// reflect         19           ..FV.....T.
/// </summary>
[Name("reflect")] reflect,
/// <summary>
/// screen          20           ..FV.....T.
/// </summary>
[Name("screen")] screen,
/// <summary>
/// softlight       21           ..FV.....T.
/// </summary>
[Name("softlight")] softlight,
/// <summary>
/// subtract        22           ..FV.....T.
/// </summary>
[Name("subtract")] subtract,
/// <summary>
/// vividlight      23           ..FV.....T.
/// </summary>
[Name("vividlight")] vividlight,
/// <summary>
/// xor             24           ..FV.....T.
/// </summary>
[Name("xor")] xor,
}

/// <summary>
///  set component #2 blend mode (from 0 to 32) (default normal)
/// </summary>
public enum TblendFilterGenC2_mode
{
/// <summary>
/// addition        1            ..FV.....T.
/// </summary>
[Name("addition")] addition,
/// <summary>
/// addition128     28           ..FV.....T.
/// </summary>
[Name("addition128")] addition128,
/// <summary>
/// grainmerge      28           ..FV.....T.
/// </summary>
[Name("grainmerge")] grainmerge,
/// <summary>
/// and             2            ..FV.....T.
/// </summary>
[Name("and")] and,
/// <summary>
/// average         3            ..FV.....T.
/// </summary>
[Name("average")] average,
/// <summary>
/// burn            4            ..FV.....T.
/// </summary>
[Name("burn")] burn,
/// <summary>
/// darken          5            ..FV.....T.
/// </summary>
[Name("darken")] darken,
/// <summary>
/// difference      6            ..FV.....T.
/// </summary>
[Name("difference")] difference,
/// <summary>
/// difference128   7            ..FV.....T.
/// </summary>
[Name("difference128")] difference128,
/// <summary>
/// grainextract    7            ..FV.....T.
/// </summary>
[Name("grainextract")] grainextract,
/// <summary>
/// divide          8            ..FV.....T.
/// </summary>
[Name("divide")] divide,
/// <summary>
/// dodge           9            ..FV.....T.
/// </summary>
[Name("dodge")] dodge,
/// <summary>
/// exclusion       10           ..FV.....T.
/// </summary>
[Name("exclusion")] exclusion,
/// <summary>
/// extremity       32           ..FV.....T.
/// </summary>
[Name("extremity")] extremity,
/// <summary>
/// freeze          31           ..FV.....T.
/// </summary>
[Name("freeze")] freeze,
/// <summary>
/// glow            27           ..FV.....T.
/// </summary>
[Name("glow")] glow,
/// <summary>
/// hardlight       11           ..FV.....T.
/// </summary>
[Name("hardlight")] hardlight,
/// <summary>
/// hardmix         25           ..FV.....T.
/// </summary>
[Name("hardmix")] hardmix,
/// <summary>
/// heat            30           ..FV.....T.
/// </summary>
[Name("heat")] heat,
/// <summary>
/// lighten         12           ..FV.....T.
/// </summary>
[Name("lighten")] lighten,
/// <summary>
/// linearlight     26           ..FV.....T.
/// </summary>
[Name("linearlight")] linearlight,
/// <summary>
/// multiply        13           ..FV.....T.
/// </summary>
[Name("multiply")] multiply,
/// <summary>
/// multiply128     29           ..FV.....T.
/// </summary>
[Name("multiply128")] multiply128,
/// <summary>
/// negation        14           ..FV.....T.
/// </summary>
[Name("negation")] negation,
/// <summary>
/// normal          0            ..FV.....T.
/// </summary>
[Name("normal")] normal,
/// <summary>
/// or              15           ..FV.....T.
/// </summary>
[Name("or")] or,
/// <summary>
/// overlay         16           ..FV.....T.
/// </summary>
[Name("overlay")] overlay,
/// <summary>
/// phoenix         17           ..FV.....T.
/// </summary>
[Name("phoenix")] phoenix,
/// <summary>
/// pinlight        18           ..FV.....T.
/// </summary>
[Name("pinlight")] pinlight,
/// <summary>
/// reflect         19           ..FV.....T.
/// </summary>
[Name("reflect")] reflect,
/// <summary>
/// screen          20           ..FV.....T.
/// </summary>
[Name("screen")] screen,
/// <summary>
/// softlight       21           ..FV.....T.
/// </summary>
[Name("softlight")] softlight,
/// <summary>
/// subtract        22           ..FV.....T.
/// </summary>
[Name("subtract")] subtract,
/// <summary>
/// vividlight      23           ..FV.....T.
/// </summary>
[Name("vividlight")] vividlight,
/// <summary>
/// xor             24           ..FV.....T.
/// </summary>
[Name("xor")] xor,
}

/// <summary>
///  set component #3 blend mode (from 0 to 32) (default normal)
/// </summary>
public enum TblendFilterGenC3_mode
{
/// <summary>
/// addition        1            ..FV.....T.
/// </summary>
[Name("addition")] addition,
/// <summary>
/// addition128     28           ..FV.....T.
/// </summary>
[Name("addition128")] addition128,
/// <summary>
/// grainmerge      28           ..FV.....T.
/// </summary>
[Name("grainmerge")] grainmerge,
/// <summary>
/// and             2            ..FV.....T.
/// </summary>
[Name("and")] and,
/// <summary>
/// average         3            ..FV.....T.
/// </summary>
[Name("average")] average,
/// <summary>
/// burn            4            ..FV.....T.
/// </summary>
[Name("burn")] burn,
/// <summary>
/// darken          5            ..FV.....T.
/// </summary>
[Name("darken")] darken,
/// <summary>
/// difference      6            ..FV.....T.
/// </summary>
[Name("difference")] difference,
/// <summary>
/// difference128   7            ..FV.....T.
/// </summary>
[Name("difference128")] difference128,
/// <summary>
/// grainextract    7            ..FV.....T.
/// </summary>
[Name("grainextract")] grainextract,
/// <summary>
/// divide          8            ..FV.....T.
/// </summary>
[Name("divide")] divide,
/// <summary>
/// dodge           9            ..FV.....T.
/// </summary>
[Name("dodge")] dodge,
/// <summary>
/// exclusion       10           ..FV.....T.
/// </summary>
[Name("exclusion")] exclusion,
/// <summary>
/// extremity       32           ..FV.....T.
/// </summary>
[Name("extremity")] extremity,
/// <summary>
/// freeze          31           ..FV.....T.
/// </summary>
[Name("freeze")] freeze,
/// <summary>
/// glow            27           ..FV.....T.
/// </summary>
[Name("glow")] glow,
/// <summary>
/// hardlight       11           ..FV.....T.
/// </summary>
[Name("hardlight")] hardlight,
/// <summary>
/// hardmix         25           ..FV.....T.
/// </summary>
[Name("hardmix")] hardmix,
/// <summary>
/// heat            30           ..FV.....T.
/// </summary>
[Name("heat")] heat,
/// <summary>
/// lighten         12           ..FV.....T.
/// </summary>
[Name("lighten")] lighten,
/// <summary>
/// linearlight     26           ..FV.....T.
/// </summary>
[Name("linearlight")] linearlight,
/// <summary>
/// multiply        13           ..FV.....T.
/// </summary>
[Name("multiply")] multiply,
/// <summary>
/// multiply128     29           ..FV.....T.
/// </summary>
[Name("multiply128")] multiply128,
/// <summary>
/// negation        14           ..FV.....T.
/// </summary>
[Name("negation")] negation,
/// <summary>
/// normal          0            ..FV.....T.
/// </summary>
[Name("normal")] normal,
/// <summary>
/// or              15           ..FV.....T.
/// </summary>
[Name("or")] or,
/// <summary>
/// overlay         16           ..FV.....T.
/// </summary>
[Name("overlay")] overlay,
/// <summary>
/// phoenix         17           ..FV.....T.
/// </summary>
[Name("phoenix")] phoenix,
/// <summary>
/// pinlight        18           ..FV.....T.
/// </summary>
[Name("pinlight")] pinlight,
/// <summary>
/// reflect         19           ..FV.....T.
/// </summary>
[Name("reflect")] reflect,
/// <summary>
/// screen          20           ..FV.....T.
/// </summary>
[Name("screen")] screen,
/// <summary>
/// softlight       21           ..FV.....T.
/// </summary>
[Name("softlight")] softlight,
/// <summary>
/// subtract        22           ..FV.....T.
/// </summary>
[Name("subtract")] subtract,
/// <summary>
/// vividlight      23           ..FV.....T.
/// </summary>
[Name("vividlight")] vividlight,
/// <summary>
/// xor             24           ..FV.....T.
/// </summary>
[Name("xor")] xor,
}

/// <summary>
///  set blend mode for all components (from -1 to 32) (default -1)
/// </summary>
public enum TblendFilterGenAll_mode
{
/// <summary>
/// addition        1            ..FV.....T.
/// </summary>
[Name("addition")] addition,
/// <summary>
/// addition128     28           ..FV.....T.
/// </summary>
[Name("addition128")] addition128,
/// <summary>
/// grainmerge      28           ..FV.....T.
/// </summary>
[Name("grainmerge")] grainmerge,
/// <summary>
/// and             2            ..FV.....T.
/// </summary>
[Name("and")] and,
/// <summary>
/// average         3            ..FV.....T.
/// </summary>
[Name("average")] average,
/// <summary>
/// burn            4            ..FV.....T.
/// </summary>
[Name("burn")] burn,
/// <summary>
/// darken          5            ..FV.....T.
/// </summary>
[Name("darken")] darken,
/// <summary>
/// difference      6            ..FV.....T.
/// </summary>
[Name("difference")] difference,
/// <summary>
/// difference128   7            ..FV.....T.
/// </summary>
[Name("difference128")] difference128,
/// <summary>
/// grainextract    7            ..FV.....T.
/// </summary>
[Name("grainextract")] grainextract,
/// <summary>
/// divide          8            ..FV.....T.
/// </summary>
[Name("divide")] divide,
/// <summary>
/// dodge           9            ..FV.....T.
/// </summary>
[Name("dodge")] dodge,
/// <summary>
/// exclusion       10           ..FV.....T.
/// </summary>
[Name("exclusion")] exclusion,
/// <summary>
/// extremity       32           ..FV.....T.
/// </summary>
[Name("extremity")] extremity,
/// <summary>
/// freeze          31           ..FV.....T.
/// </summary>
[Name("freeze")] freeze,
/// <summary>
/// glow            27           ..FV.....T.
/// </summary>
[Name("glow")] glow,
/// <summary>
/// hardlight       11           ..FV.....T.
/// </summary>
[Name("hardlight")] hardlight,
/// <summary>
/// hardmix         25           ..FV.....T.
/// </summary>
[Name("hardmix")] hardmix,
/// <summary>
/// heat            30           ..FV.....T.
/// </summary>
[Name("heat")] heat,
/// <summary>
/// lighten         12           ..FV.....T.
/// </summary>
[Name("lighten")] lighten,
/// <summary>
/// linearlight     26           ..FV.....T.
/// </summary>
[Name("linearlight")] linearlight,
/// <summary>
/// multiply        13           ..FV.....T.
/// </summary>
[Name("multiply")] multiply,
/// <summary>
/// multiply128     29           ..FV.....T.
/// </summary>
[Name("multiply128")] multiply128,
/// <summary>
/// negation        14           ..FV.....T.
/// </summary>
[Name("negation")] negation,
/// <summary>
/// normal          0            ..FV.....T.
/// </summary>
[Name("normal")] normal,
/// <summary>
/// or              15           ..FV.....T.
/// </summary>
[Name("or")] or,
/// <summary>
/// overlay         16           ..FV.....T.
/// </summary>
[Name("overlay")] overlay,
/// <summary>
/// phoenix         17           ..FV.....T.
/// </summary>
[Name("phoenix")] phoenix,
/// <summary>
/// pinlight        18           ..FV.....T.
/// </summary>
[Name("pinlight")] pinlight,
/// <summary>
/// reflect         19           ..FV.....T.
/// </summary>
[Name("reflect")] reflect,
/// <summary>
/// screen          20           ..FV.....T.
/// </summary>
[Name("screen")] screen,
/// <summary>
/// softlight       21           ..FV.....T.
/// </summary>
[Name("softlight")] softlight,
/// <summary>
/// subtract        22           ..FV.....T.
/// </summary>
[Name("subtract")] subtract,
/// <summary>
/// vividlight      23           ..FV.....T.
/// </summary>
[Name("vividlight")] vividlight,
/// <summary>
/// xor             24           ..FV.....T.
/// </summary>
[Name("xor")] xor,
}

}
