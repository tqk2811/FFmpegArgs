namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S. xfade             VV-&gt;V      Cross fade one video with another video.
    /// </summary>
    public class XfadeFilterGen : ImageToImageFilter, ISliceThreading
    {
        internal XfadeFilterGen(params ImageMap[] inputs) : base("xfade", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set cross fade transition (from -1 to 57) (default fade)
        /// </summary>
        public XfadeFilterGen transition(XfadeFilterGenTransition transition) => this.SetOption("transition", transition.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set cross fade duration (default 1)
        /// </summary>
        public XfadeFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set cross fade start relative to first input stream (default 0)
        /// </summary>
        public XfadeFilterGen offset(TimeSpan offset) => this.SetOptionRange("offset", offset, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set expression for custom transition
        /// </summary>
        public XfadeFilterGen expr(ExpressionValue expr) => this.SetOption("expr", (string)expr);
    }

    /// <summary>
    ///  set cross fade transition (from -1 to 57) (default fade)
    /// </summary>
    public enum XfadeFilterGenTransition
    {
        /// <summary>
        /// custom          -1           ..FV....... custom transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("custom")]
        custom = -1,
        /// <summary>
        /// fade            0            ..FV....... fade transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fade")]
        fade = 0,
        /// <summary>
        /// wipeleft        1            ..FV....... wipe left transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wipeleft")]
        wipeleft = 1,
        /// <summary>
        /// wiperight       2            ..FV....... wipe right transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wiperight")]
        wiperight = 2,
        /// <summary>
        /// wipeup          3            ..FV....... wipe up transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wipeup")]
        wipeup = 3,
        /// <summary>
        /// wipedown        4            ..FV....... wipe down transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wipedown")]
        wipedown = 4,
        /// <summary>
        /// slideleft       5            ..FV....... slide left transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("slideleft")]
        slideleft = 5,
        /// <summary>
        /// slideright      6            ..FV....... slide right transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("slideright")]
        slideright = 6,
        /// <summary>
        /// slideup         7            ..FV....... slide up transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("slideup")]
        slideup = 7,
        /// <summary>
        /// slidedown       8            ..FV....... slide down transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("slidedown")]
        slidedown = 8,
        /// <summary>
        /// circlecrop      9            ..FV....... circle crop transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("circlecrop")]
        circlecrop = 9,
        /// <summary>
        /// rectcrop        10           ..FV....... rect crop transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rectcrop")]
        rectcrop = 10,
        /// <summary>
        /// distance        11           ..FV....... distance transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("distance")]
        distance = 11,
        /// <summary>
        /// fadeblack       12           ..FV....... fadeblack transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fadeblack")]
        fadeblack = 12,
        /// <summary>
        /// fadewhite       13           ..FV....... fadewhite transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fadewhite")]
        fadewhite = 13,
        /// <summary>
        /// radial          14           ..FV....... radial transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("radial")]
        radial = 14,
        /// <summary>
        /// smoothleft      15           ..FV....... smoothleft transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smoothleft")]
        smoothleft = 15,
        /// <summary>
        /// smoothright     16           ..FV....... smoothright transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smoothright")]
        smoothright = 16,
        /// <summary>
        /// smoothup        17           ..FV....... smoothup transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smoothup")]
        smoothup = 17,
        /// <summary>
        /// smoothdown      18           ..FV....... smoothdown transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smoothdown")]
        smoothdown = 18,
        /// <summary>
        /// circleopen      19           ..FV....... circleopen transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("circleopen")]
        circleopen = 19,
        /// <summary>
        /// circleclose     20           ..FV....... circleclose transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("circleclose")]
        circleclose = 20,
        /// <summary>
        /// vertopen        21           ..FV....... vert open transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vertopen")]
        vertopen = 21,
        /// <summary>
        /// vertclose       22           ..FV....... vert close transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vertclose")]
        vertclose = 22,
        /// <summary>
        /// horzopen        23           ..FV....... horz open transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("horzopen")]
        horzopen = 23,
        /// <summary>
        /// horzclose       24           ..FV....... horz close transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("horzclose")]
        horzclose = 24,
        /// <summary>
        /// dissolve        25           ..FV....... dissolve transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dissolve")]
        dissolve = 25,
        /// <summary>
        /// pixelize        26           ..FV....... pixelize transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pixelize")]
        pixelize = 26,
        /// <summary>
        /// diagtl          27           ..FV....... diag tl transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("diagtl")]
        diagtl = 27,
        /// <summary>
        /// diagtr          28           ..FV....... diag tr transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("diagtr")]
        diagtr = 28,
        /// <summary>
        /// diagbl          29           ..FV....... diag bl transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("diagbl")]
        diagbl = 29,
        /// <summary>
        /// diagbr          30           ..FV....... diag br transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("diagbr")]
        diagbr = 30,
        /// <summary>
        /// hlslice         31           ..FV....... hl slice transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hlslice")]
        hlslice = 31,
        /// <summary>
        /// hrslice         32           ..FV....... hr slice transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hrslice")]
        hrslice = 32,
        /// <summary>
        /// vuslice         33           ..FV....... vu slice transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vuslice")]
        vuslice = 33,
        /// <summary>
        /// vdslice         34           ..FV....... vd slice transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vdslice")]
        vdslice = 34,
        /// <summary>
        /// hblur           35           ..FV....... hblur transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hblur")]
        hblur = 35,
        /// <summary>
        /// fadegrays       36           ..FV....... fadegrays transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fadegrays")]
        fadegrays = 36,
        /// <summary>
        /// wipetl          37           ..FV....... wipe tl transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wipetl")]
        wipetl = 37,
        /// <summary>
        /// wipetr          38           ..FV....... wipe tr transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wipetr")]
        wipetr = 38,
        /// <summary>
        /// wipebl          39           ..FV....... wipe bl transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wipebl")]
        wipebl = 39,
        /// <summary>
        /// wipebr          40           ..FV....... wipe br transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wipebr")]
        wipebr = 40,
        /// <summary>
        /// squeezeh        41           ..FV....... squeeze h transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("squeezeh")]
        squeezeh = 41,
        /// <summary>
        /// squeezev        42           ..FV....... squeeze v transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("squeezev")]
        squeezev = 42,
        /// <summary>
        /// zoomin          43           ..FV....... zoom in transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("zoomin")]
        zoomin = 43,
        /// <summary>
        /// fadefast        44           ..FV....... fast fade transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fadefast")]
        fadefast = 44,
        /// <summary>
        /// fadeslow        45           ..FV....... slow fade transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fadeslow")]
        fadeslow = 45,
        /// <summary>
        /// hlwind          46           ..FV....... hl wind transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hlwind")]
        hlwind = 46,
        /// <summary>
        /// hrwind          47           ..FV....... hr wind transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hrwind")]
        hrwind = 47,
        /// <summary>
        /// vuwind          48           ..FV....... vu wind transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vuwind")]
        vuwind = 48,
        /// <summary>
        /// vdwind          49           ..FV....... vd wind transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vdwind")]
        vdwind = 49,
        /// <summary>
        /// coverleft       50           ..FV....... cover left transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("coverleft")]
        coverleft = 50,
        /// <summary>
        /// coverright      51           ..FV....... cover right transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("coverright")]
        coverright = 51,
        /// <summary>
        /// coverup         52           ..FV....... cover up transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("coverup")]
        coverup = 52,
        /// <summary>
        /// coverdown       53           ..FV....... cover down transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("coverdown")]
        coverdown = 53,
        /// <summary>
        /// revealleft      54           ..FV....... reveal left transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("revealleft")]
        revealleft = 54,
        /// <summary>
        /// revealright     55           ..FV....... reveal right transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("revealright")]
        revealright = 55,
        /// <summary>
        /// revealup        56           ..FV....... reveal up transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("revealup")]
        revealup = 56,
        /// <summary>
        /// revealdown      57           ..FV....... reveal down transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("revealdown")]
        revealdown = 57
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Cross fade one video with another video.
        /// </summary>
        public static XfadeFilterGen XfadeFilterGen(this ImageMap input0, ImageMap input1) => new XfadeFilterGen(input0, input1);
    }
}