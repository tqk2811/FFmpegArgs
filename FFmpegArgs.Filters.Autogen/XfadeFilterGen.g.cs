namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// .S. xfade             VV->V      Cross fade one video with another video.
/// </summary>
public class XfadeFilterGen : ImageToImageFilter,ISliceThreading
{
internal XfadeFilterGen(params ImageMap[] inputs) : base("xfade",inputs) { AddMapOut(); }
/// <summary>
///  set cross fade transition (from -1 to 42) (default fade)
/// </summary>
public XfadeFilterGen transition(XfadeFilterGenTransition transition) => this.SetOption("transition", transition.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set cross fade duration (default 1)
/// </summary>
public XfadeFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set cross fade start relative to first input stream (default 0)
/// </summary>
public XfadeFilterGen offset(TimeSpan offset) => this.SetOptionRange("offset",offset,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set expression for custom transition
/// </summary>
public XfadeFilterGen expr(string expr) => this.SetOption("expr",expr);
}
/// <summary>
/// </summary>
public static class XfadeFilterGenExtensions
{
/// <summary>
/// Cross fade one video with another video.
/// </summary>
public static XfadeFilterGen XfadeFilterGen(this ImageMap input0, ImageMap input1) => new XfadeFilterGen(input0, input1);
}
/// <summary>
///  set cross fade transition (from -1 to 42) (default fade)
/// </summary>
public enum XfadeFilterGenTransition
{
/// <summary>
/// custom          -1           ..FV....... custom transition
/// </summary>
[Name("custom")] custom,
/// <summary>
/// fade            0            ..FV....... fade transition
/// </summary>
[Name("fade")] fade,
/// <summary>
/// wipeleft        1            ..FV....... wipe left transition
/// </summary>
[Name("wipeleft")] wipeleft,
/// <summary>
/// wiperight       2            ..FV....... wipe right transition
/// </summary>
[Name("wiperight")] wiperight,
/// <summary>
/// wipeup          3            ..FV....... wipe up transition
/// </summary>
[Name("wipeup")] wipeup,
/// <summary>
/// wipedown        4            ..FV....... wipe down transition
/// </summary>
[Name("wipedown")] wipedown,
/// <summary>
/// slideleft       5            ..FV....... slide left transition
/// </summary>
[Name("slideleft")] slideleft,
/// <summary>
/// slideright      6            ..FV....... slide right transition
/// </summary>
[Name("slideright")] slideright,
/// <summary>
/// slideup         7            ..FV....... slide up transition
/// </summary>
[Name("slideup")] slideup,
/// <summary>
/// slidedown       8            ..FV....... slide down transition
/// </summary>
[Name("slidedown")] slidedown,
/// <summary>
/// circlecrop      9            ..FV....... circle crop transition
/// </summary>
[Name("circlecrop")] circlecrop,
/// <summary>
/// rectcrop        10           ..FV....... rect crop transition
/// </summary>
[Name("rectcrop")] rectcrop,
/// <summary>
/// distance        11           ..FV....... distance transition
/// </summary>
[Name("distance")] distance,
/// <summary>
/// fadeblack       12           ..FV....... fadeblack transition
/// </summary>
[Name("fadeblack")] fadeblack,
/// <summary>
/// fadewhite       13           ..FV....... fadewhite transition
/// </summary>
[Name("fadewhite")] fadewhite,
/// <summary>
/// radial          14           ..FV....... radial transition
/// </summary>
[Name("radial")] radial,
/// <summary>
/// smoothleft      15           ..FV....... smoothleft transition
/// </summary>
[Name("smoothleft")] smoothleft,
/// <summary>
/// smoothright     16           ..FV....... smoothright transition
/// </summary>
[Name("smoothright")] smoothright,
/// <summary>
/// smoothup        17           ..FV....... smoothup transition
/// </summary>
[Name("smoothup")] smoothup,
/// <summary>
/// smoothdown      18           ..FV....... smoothdown transition
/// </summary>
[Name("smoothdown")] smoothdown,
/// <summary>
/// circleopen      19           ..FV....... circleopen transition
/// </summary>
[Name("circleopen")] circleopen,
/// <summary>
/// circleclose     20           ..FV....... circleclose transition
/// </summary>
[Name("circleclose")] circleclose,
/// <summary>
/// vertopen        21           ..FV....... vert open transition
/// </summary>
[Name("vertopen")] vertopen,
/// <summary>
/// vertclose       22           ..FV....... vert close transition
/// </summary>
[Name("vertclose")] vertclose,
/// <summary>
/// horzopen        23           ..FV....... horz open transition
/// </summary>
[Name("horzopen")] horzopen,
/// <summary>
/// horzclose       24           ..FV....... horz close transition
/// </summary>
[Name("horzclose")] horzclose,
/// <summary>
/// dissolve        25           ..FV....... dissolve transition
/// </summary>
[Name("dissolve")] dissolve,
/// <summary>
/// pixelize        26           ..FV....... pixelize transition
/// </summary>
[Name("pixelize")] pixelize,
/// <summary>
/// diagtl          27           ..FV....... diag tl transition
/// </summary>
[Name("diagtl")] diagtl,
/// <summary>
/// diagtr          28           ..FV....... diag tr transition
/// </summary>
[Name("diagtr")] diagtr,
/// <summary>
/// diagbl          29           ..FV....... diag bl transition
/// </summary>
[Name("diagbl")] diagbl,
/// <summary>
/// diagbr          30           ..FV....... diag br transition
/// </summary>
[Name("diagbr")] diagbr,
/// <summary>
/// hlslice         31           ..FV....... hl slice transition
/// </summary>
[Name("hlslice")] hlslice,
/// <summary>
/// hrslice         32           ..FV....... hr slice transition
/// </summary>
[Name("hrslice")] hrslice,
/// <summary>
/// vuslice         33           ..FV....... vu slice transition
/// </summary>
[Name("vuslice")] vuslice,
/// <summary>
/// vdslice         34           ..FV....... vd slice transition
/// </summary>
[Name("vdslice")] vdslice,
/// <summary>
/// hblur           35           ..FV....... hblur transition
/// </summary>
[Name("hblur")] hblur,
/// <summary>
/// fadegrays       36           ..FV....... fadegrays transition
/// </summary>
[Name("fadegrays")] fadegrays,
/// <summary>
/// wipetl          37           ..FV....... wipe tl transition
/// </summary>
[Name("wipetl")] wipetl,
/// <summary>
/// wipetr          38           ..FV....... wipe tr transition
/// </summary>
[Name("wipetr")] wipetr,
/// <summary>
/// wipebl          39           ..FV....... wipe bl transition
/// </summary>
[Name("wipebl")] wipebl,
/// <summary>
/// wipebr          40           ..FV....... wipe br transition
/// </summary>
[Name("wipebr")] wipebr,
/// <summary>
/// squeezeh        41           ..FV....... squeeze h transition
/// </summary>
[Name("squeezeh")] squeezeh,
/// <summary>
/// squeezev        42           ..FV....... squeeze v transition
/// </summary>
[Name("squeezev")] squeezev,
}

}
