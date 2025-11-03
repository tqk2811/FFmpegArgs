namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS colorcorrect      V-&gt;V       Adjust color white balance selectively for blacks and whites.
    /// </summary>
    public class ColorcorrectFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal ColorcorrectFilterGen(ImageMap input) : base("colorcorrect", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the red shadow spot (from -1 to 1) (default 0)
        /// </summary>
        public ColorcorrectFilterGen rl(float rl) => this.SetOptionRange("rl", rl, -1, 1);
        /// <summary>
        ///  set the blue shadow spot (from -1 to 1) (default 0)
        /// </summary>
        public ColorcorrectFilterGen bl(float bl) => this.SetOptionRange("bl", bl, -1, 1);
        /// <summary>
        ///  set the red highlight spot (from -1 to 1) (default 0)
        /// </summary>
        public ColorcorrectFilterGen rh(float rh) => this.SetOptionRange("rh", rh, -1, 1);
        /// <summary>
        ///  set the blue highlight spot (from -1 to 1) (default 0)
        /// </summary>
        public ColorcorrectFilterGen bh(float bh) => this.SetOptionRange("bh", bh, -1, 1);
        /// <summary>
        ///  set the amount of saturation (from -3 to 3) (default 1)
        /// </summary>
        public ColorcorrectFilterGen saturation(float saturation) => this.SetOptionRange("saturation", saturation, -3, 3);
        /// <summary>
        ///  set the analyze mode (from 0 to 3) (default manual)
        /// </summary>
        public ColorcorrectFilterGen analyze(ColorcorrectFilterGenAnalyze analyze) => this.SetOption("analyze", analyze.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set the analyze mode (from 0 to 3) (default manual)
    /// </summary>
    public enum ColorcorrectFilterGenAnalyze
    {
        /// <summary>
        /// manual          0            ..FV.....T. manually set options
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("manual")]
        manual = 0,
        /// <summary>
        /// average         1            ..FV.....T. use average pixels
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("average")]
        average = 1,
        /// <summary>
        /// minmax          2            ..FV.....T. use minmax pixels
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("minmax")]
        minmax = 2,
        /// <summary>
        /// median          3            ..FV.....T. use median pixels
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("median")]
        median = 3
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Adjust color white balance selectively for blacks and whites.
        /// </summary>
        public static ColorcorrectFilterGen ColorcorrectFilterGen(this ImageMap input0) => new ColorcorrectFilterGen(input0);
    }
}