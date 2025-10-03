namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... dnn_processing    V-&gt;V       Apply DNN processing filter to the input.
    /// </summary>
    public class Dnn_processingFilterGen : ImageToImageFilter
    {
        internal Dnn_processingFilterGen(ImageMap input) : base("dnn_processing", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  DNN backend (from INT_MIN to INT_MAX) (default 1)
        /// </summary>
        public Dnn_processingFilterGen dnn_backend(int dnn_backend) => this.SetOptionRange("dnn_backend", dnn_backend, INT_MIN, INT_MAX);
        /// <summary>
        ///  path to model file
        /// </summary>
        public Dnn_processingFilterGen model(String model) => this.SetOption("model", model.ToString());
        /// <summary>
        ///  input name of the model
        /// </summary>
        public Dnn_processingFilterGen input(String input) => this.SetOption("input", input.ToString());
        /// <summary>
        ///  output name of the model
        /// </summary>
        public Dnn_processingFilterGen output(String output) => this.SetOption("output", output.ToString());
        /// <summary>
        ///  backend configs
        /// </summary>
        public Dnn_processingFilterGen backend_configs(String backend_configs) => this.SetOption("backend_configs", backend_configs.ToString());
        /// <summary>
        ///  backend configs (deprecated, use backend_configs)
        /// </summary>
        public Dnn_processingFilterGen options(String options) => this.SetOption("options", options.ToString());
        /// <summary>
        ///  use DNN async inference (ignored, use backend_configs=&#39;async=1&#39;) (default true)
        /// </summary>
        public Dnn_processingFilterGen _async(bool _async) => this.SetOption("async", _async.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply DNN processing filter to the input.
        /// </summary>
        public static Dnn_processingFilterGen Dnn_processingFilterGen(this ImageMap input0) => new Dnn_processingFilterGen(input0);
    }
}