namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.. derain            V-&gt;V       Apply derain filter to the input.
    /// </summary>
    public class DerainFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal DerainFilterGen(ImageMap input) : base("derain", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  filter type(derain/dehaze) (from 0 to 1) (default derain)
        /// </summary>
        public DerainFilterGen filter_type(DerainFilterGenFilter_type filter_type) => this.SetOption("filter_type", filter_type.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  DNN backend (from 0 to 1) (default 1)
        /// </summary>
        public DerainFilterGen dnn_backend(int dnn_backend) => this.SetOptionRange("dnn_backend", dnn_backend, 0, 1);
        /// <summary>
        ///  path to model file
        /// </summary>
        public DerainFilterGen model(String model) => this.SetOption("model", model.ToString());
        /// <summary>
        ///  input name of the model (default &quot;x&quot;)
        /// </summary>
        public DerainFilterGen input(String input) => this.SetOption("input", input.ToString());
        /// <summary>
        ///  output name of the model (default &quot;y&quot;)
        /// </summary>
        public DerainFilterGen output(String output) => this.SetOption("output", output.ToString());
    }

    /// <summary>
    ///  filter type(derain/dehaze) (from 0 to 1) (default derain)
    /// </summary>
    public enum DerainFilterGenFilter_type
    {
        /// <summary>
        /// derain          0            ..FV....... derain filter flag
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("derain")]
        derain = 0,
        /// <summary>
        /// dehaze          1            ..FV....... dehaze filter flag
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dehaze")]
        dehaze = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply derain filter to the input.
        /// </summary>
        public static DerainFilterGen DerainFilterGen(this ImageMap input0) => new DerainFilterGen(input0);
    }
}