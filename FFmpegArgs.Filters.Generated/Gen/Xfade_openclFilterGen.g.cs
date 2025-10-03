namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... xfade_opencl      VV-&gt;V      Cross fade one video with another video.
    /// </summary>
    public class Xfade_openclFilterGen : ImageToImageFilter
    {
        internal Xfade_openclFilterGen(params ImageMap[] inputs) : base("xfade_opencl", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set cross fade transition (from 0 to 9) (default fade)
        /// </summary>
        public Xfade_openclFilterGen transition(Xfade_openclFilterGenTransition transition) => this.SetOption("transition", transition.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set OpenCL program source file for custom transition
        /// </summary>
        public Xfade_openclFilterGen source(String source) => this.SetOption("source", source.ToString());
        /// <summary>
        ///  set kernel name in program file for custom transition
        /// </summary>
        public Xfade_openclFilterGen kernel(String kernel) => this.SetOption("kernel", kernel.ToString());
        /// <summary>
        ///  set cross fade duration (default 1)
        /// </summary>
        public Xfade_openclFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set cross fade start relative to first input stream (default 0)
        /// </summary>
        public Xfade_openclFilterGen offset(TimeSpan offset) => this.SetOptionRange("offset", offset, TimeSpan.Zero, TimeSpan.MaxValue);
    }

    /// <summary>
    ///  set cross fade transition (from 0 to 9) (default fade)
    /// </summary>
    public enum Xfade_openclFilterGenTransition
    {
        /// <summary>
        /// custom          0            ..FV....... custom transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("custom")]
        custom = 0,
        /// <summary>
        /// fade            1            ..FV....... fade transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fade")]
        fade = 1,
        /// <summary>
        /// wipeleft        2            ..FV....... wipe left transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wipeleft")]
        wipeleft = 2,
        /// <summary>
        /// wiperight       3            ..FV....... wipe right transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wiperight")]
        wiperight = 3,
        /// <summary>
        /// wipeup          4            ..FV....... wipe up transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wipeup")]
        wipeup = 4,
        /// <summary>
        /// wipedown        5            ..FV....... wipe down transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wipedown")]
        wipedown = 5,
        /// <summary>
        /// slideleft       6            ..FV....... slide left transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("slideleft")]
        slideleft = 6,
        /// <summary>
        /// slideright      7            ..FV....... slide right transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("slideright")]
        slideright = 7,
        /// <summary>
        /// slideup         8            ..FV....... slide up transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("slideup")]
        slideup = 8,
        /// <summary>
        /// slidedown       9            ..FV....... slide down transition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("slidedown")]
        slidedown = 9
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Cross fade one video with another video.
        /// </summary>
        public static Xfade_openclFilterGen Xfade_openclFilterGen(this ImageMap input0, ImageMap input1) => new Xfade_openclFilterGen(input0, input1);
    }
}