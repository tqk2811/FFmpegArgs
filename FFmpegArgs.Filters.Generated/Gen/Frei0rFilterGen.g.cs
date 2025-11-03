namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. frei0r            V-&gt;V       Apply a frei0r effect.
    /// </summary>
    public class Frei0rFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal Frei0rFilterGen(ImageMap input) : base("frei0r", input)
        {
            AddMapOut();
        }

        /// <summary>
        /// 
        /// </summary>
        public Frei0rFilterGen filter_name(String filter_name) => this.SetOption("filter_name", filter_name.ToStringInv());
        /// <summary>
        /// 
        /// </summary>
        public Frei0rFilterGen filter_params(String filter_params) => this.SetOption("filter_params", filter_params.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply a frei0r effect.
        /// </summary>
        public static Frei0rFilterGen Frei0rFilterGen(this ImageMap input0) => new Frei0rFilterGen(input0);
    }
}