namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... xfade_vulkan      VV-&gt;V      Cross fade one video with another video.
    /// </summary>
    public class Xfade_vulkanFilterGen : ImageToImageFilter
    {
        internal Xfade_vulkanFilterGen(params ImageMap[] inputs) : base("xfade_vulkan", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set cross fade transition (from 0 to 16) (default fade)
        /// </summary>
        public Xfade_vulkanFilterGen transition(Xfade_vulkanFilterGenTransition transition) => this.SetOption("transition", transition.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set cross fade duration (default 1)
        /// </summary>
        public Xfade_vulkanFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set cross fade start relative to first input stream (default 0)
        /// </summary>
        public Xfade_vulkanFilterGen offset(TimeSpan offset) => this.SetOptionRange("offset", offset, TimeSpan.Zero, TimeSpan.MaxValue);
    }

    /// <summary>
    ///  set cross fade transition (from 0 to 16) (default fade)
    /// </summary>
    public enum Xfade_vulkanFilterGenTransition
    {
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
        /// slidedown       5            ..FV....... slide down transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("slidedown")]
        slidedown = 5,
        /// <summary>
        /// slideup         6            ..FV....... slide up transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("slideup")]
        slideup = 6,
        /// <summary>
        /// slideleft       7            ..FV....... slide left transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("slideleft")]
        slideleft = 7,
        /// <summary>
        /// slideright      8            ..FV....... slide right transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("slideright")]
        slideright = 8,
        /// <summary>
        /// circleopen      9            ..FV....... circleopen transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("circleopen")]
        circleopen = 9,
        /// <summary>
        /// circleclose     10           ..FV....... circleclose transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("circleclose")]
        circleclose = 10,
        /// <summary>
        /// dissolve        11           ..FV....... dissolve transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dissolve")]
        dissolve = 11,
        /// <summary>
        /// pixelize        12           ..FV....... pixelize transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pixelize")]
        pixelize = 12,
        /// <summary>
        /// wipetl          13           ..FV....... wipe top left transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wipetl")]
        wipetl = 13,
        /// <summary>
        /// wipetr          14           ..FV....... wipe top right transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wipetr")]
        wipetr = 14,
        /// <summary>
        /// wipebl          15           ..FV....... wipe bottom left transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wipebl")]
        wipebl = 15,
        /// <summary>
        /// wipebr          16           ..FV....... wipe bottom right transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wipebr")]
        wipebr = 16
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Cross fade one video with another video.
        /// </summary>
        public static Xfade_vulkanFilterGen Xfade_vulkanFilterGen(this ImageMap input0, ImageMap input1) => new Xfade_vulkanFilterGen(input0, input1);
    }
}