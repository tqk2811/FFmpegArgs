namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.. entropy           V-&gt;V       Measure video frames entropy.
    /// </summary>
    public class EntropyFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal EntropyFilterGen(ImageMap input) : base("entropy", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set kind of histogram entropy measurement (from 0 to 1) (default normal)
        /// </summary>
        public EntropyFilterGen mode(EntropyFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set kind of histogram entropy measurement (from 0 to 1) (default normal)
    /// </summary>
    public enum EntropyFilterGenMode
    {
        /// <summary>
        /// normal          0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("normal")]
        normal = 0,
        /// <summary>
        /// diff            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("diff")]
        diff = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Measure video frames entropy.
        /// </summary>
        public static EntropyFilterGen EntropyFilterGen(this ImageMap input0) => new EntropyFilterGen(input0);
    }
}