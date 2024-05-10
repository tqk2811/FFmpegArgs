/*
xfade AVOptions:
   transition        <int>        ..FV....... set cross fade transition (from -1 to 43) (default fade)
     custom          -1           ..FV....... custom transition
     fade            0            ..FV....... fade transition
     wipeleft        1            ..FV....... wipe left transition
     wiperight       2            ..FV....... wipe right transition
     wipeup          3            ..FV....... wipe up transition
     wipedown        4            ..FV....... wipe down transition
     slideleft       5            ..FV....... slide left transition
     slideright      6            ..FV....... slide right transition
     slideup         7            ..FV....... slide up transition
     slidedown       8            ..FV....... slide down transition
     circlecrop      9            ..FV....... circle crop transition
     rectcrop        10           ..FV....... rect crop transition
     distance        11           ..FV....... distance transition
     fadeblack       12           ..FV....... fadeblack transition
     fadewhite       13           ..FV....... fadewhite transition
     radial          14           ..FV....... radial transition
     smoothleft      15           ..FV....... smoothleft transition
     smoothright     16           ..FV....... smoothright transition
     smoothup        17           ..FV....... smoothup transition
     smoothdown      18           ..FV....... smoothdown transition
     circleopen      19           ..FV....... circleopen transition
     circleclose     20           ..FV....... circleclose transition
     vertopen        21           ..FV....... vert open transition
     vertclose       22           ..FV....... vert close transition
     horzopen        23           ..FV....... horz open transition
     horzclose       24           ..FV....... horz close transition
     dissolve        25           ..FV....... dissolve transition
     pixelize        26           ..FV....... pixelize transition
     diagtl          27           ..FV....... diag tl transition
     diagtr          28           ..FV....... diag tr transition
     diagbl          29           ..FV....... diag bl transition
     diagbr          30           ..FV....... diag br transition
     hlslice         31           ..FV....... hl slice transition
     hrslice         32           ..FV....... hr slice transition
     vuslice         33           ..FV....... vu slice transition
     vdslice         34           ..FV....... vd slice transition
     hblur           35           ..FV....... hblur transition
     fadegrays       36           ..FV....... fadegrays transition
     wipetl          37           ..FV....... wipe tl transition
     wipetr          38           ..FV....... wipe tr transition
     wipebl          39           ..FV....... wipe bl transition
     wipebr          40           ..FV....... wipe br transition
     squeezeh        41           ..FV....... squeeze h transition
     squeezev        42           ..FV....... squeeze v transition
     zoomin          43           ..FV....... zoom in transition
   duration          <duration>   ..FV....... set cross fade duration (default 1)
   offset            <duration>   ..FV....... set cross fade start relative to first input stream (default 0)
   expr              <string>     ..FV....... set expression for custom transition
*/
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// .S. xfade             VV->V      Cross fade one video with another video.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#xfade
    /// </summary>
    public class XfadeFilter : ImageToImageFilter, ISliceThreading
    {
        static readonly IEnumerable<string> _variables = new string[]
        {
            "X","Y", "W", "H", "P", "PLANE", "A", "B"
        };
        static readonly IEnumerable<ShuntingYardFunction> _functions = new ShuntingYardFunction[]
        {
            new ShuntingYardFunction("a0","a0_2"),
            new ShuntingYardFunction("a1","a1_2"),
            new ShuntingYardFunction("a2","a2_2"),
            new ShuntingYardFunction("a3","a3_2"),

            new ShuntingYardFunction("b0","b0_2"),
            new ShuntingYardFunction("b1","b1_2"),
            new ShuntingYardFunction("b2","b2_2"),
            new ShuntingYardFunction("b3","b3_2"),
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables, _functions);
        internal XfadeFilter(params ImageMap[] imageMaps) : base("xfade", imageMaps)
        {
            AddMapOut();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="transition"></param>
        /// <returns></returns>
        public XfadeFilter Transition(XfadeTransition transition)
            => this.SetOption("transition", transition);

        /// <summary>
        /// Set cross fade duration in seconds. Range is 0 to 60 seconds. Default duration is 1 second.
        /// </summary>
        /// <param name="duration"></param>
        /// <returns></returns>
        public XfadeFilter Duration(TimeSpan duration)
            => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.FromMinutes(1));

        /// <summary>
        /// Set cross fade start relative to first input stream in seconds. Default offset is 0.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public XfadeFilter Offset(TimeSpan offset)
            => this.SetOptionRange("offset", offset, TimeSpan.Zero, TimeSpan.MaxValue);

        /// <summary>
        /// Set expression for custom transition effect.
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        public XfadeFilter Expr(ExpressionValue expr)
            => this.SetOption("expr", expression.Check(expr));
    }
    /// <summary>
    /// 
    /// </summary>
    public static class XfadeFilderExtensions
    {
        /// <summary>
        /// Apply cross fade from one input video stream to another input video stream. The cross fade is applied for specified duration.<br>
        /// </br>Both inputs must be constant frame-rate and have the same resolution, pixel format, frame rate and timebase.
        /// </summary>
        public static XfadeFilter XfadeFilder(this ImageMap imageMap, ImageMap imageMap1)
          => new XfadeFilter(imageMap, imageMap1);
        
        /// <summary>
        /// Apply cross fade from one input video stream to another input video stream. The cross fade is applied for specified duration.<br>
        /// </br>Both inputs must be constant frame-rate and have the same resolution, pixel format, frame rate and timebase.
        /// </summary>
        public static XfadeFilter XfadeFilder(this IEnumerable<ImageMap> imageMaps)
        {
            var arr = imageMaps.ToArray();
            if (arr.Length != 2) throw new ArgumentException("XfadeFilder must have 2 inputs");
            return new XfadeFilter(arr);
        }
    }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum XfadeTransition
    {
        custom,
        fade,
        wipeleft,
        wiperight,
        wipeup,
        wipedown,
        slideleft,
        slideright,
        slideup,
        slidedown,
        circlecrop,
        rectcrop,
        distance,
        fadeblack,
        fadewhite,
        radial,
        smoothleft,
        smoothright,
        smoothup,
        smoothdown,
        circleopen,
        circleclose,
        vertopen,
        vertclose,
        horzopen,
        horzclose,
        dissolve,
        pixelize,
        diagtl,
        diagtr,
        diagbl,
        diagbr,
        hlslice,
        hrslice,
        vuslice,
        vdslice,
        hblur,
        fadegrays,
        wipetl,
        wipetr,
        wipebl,
        wipebr,
        squeezeh,
        squeezev,
        zoomin,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
