namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... dnn_detect        V-&gt;V       Apply DNN detect filter to the input.
    /// </summary>
    public class Dnn_detectFilterGen : ImageToImageFilter
    {
        internal Dnn_detectFilterGen(ImageMap input) : base("dnn_detect", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  DNN backend (from INT_MIN to INT_MAX) (default 2)
        /// </summary>
        public Dnn_detectFilterGen dnn_backend(int dnn_backend) => this.SetOptionRange("dnn_backend", dnn_backend, INT_MIN, INT_MAX);
        /// <summary>
        ///  path to model file
        /// </summary>
        public Dnn_detectFilterGen model(String model) => this.SetOption("model", model.ToString());
        /// <summary>
        ///  input name of the model
        /// </summary>
        public Dnn_detectFilterGen input(String input) => this.SetOption("input", input.ToString());
        /// <summary>
        ///  output name of the model
        /// </summary>
        public Dnn_detectFilterGen output(String output) => this.SetOption("output", output.ToString());
        /// <summary>
        ///  backend configs
        /// </summary>
        public Dnn_detectFilterGen backend_configs(String backend_configs) => this.SetOption("backend_configs", backend_configs.ToString());
        /// <summary>
        ///  backend configs (deprecated, use backend_configs)
        /// </summary>
        public Dnn_detectFilterGen options(String options) => this.SetOption("options", options.ToString());
        /// <summary>
        ///  use DNN async inference (ignored, use backend_configs=&#39;async=1&#39;) (default true)
        /// </summary>
        public Dnn_detectFilterGen _async(bool _async) => this.SetOption("async", _async.ToFFmpegFlag());
        /// <summary>
        ///  threshold of confidence (from 0 to 1) (default 0.5)
        /// </summary>
        public Dnn_detectFilterGen confidence(float confidence) => this.SetOptionRange("confidence", confidence, 0, 1);
        /// <summary>
        ///  path to labels file
        /// </summary>
        public Dnn_detectFilterGen labels(String labels) => this.SetOption("labels", labels.ToString());
        /// <summary>
        ///  DNN detection model type (from INT_MIN to INT_MAX) (default ssd)
        /// </summary>
        public Dnn_detectFilterGen model_type(Dnn_detectFilterGenModel_type model_type) => this.SetOption("model_type", model_type.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  cell width (from 0 to I64_MAX) (default 0)
        /// </summary>
        public Dnn_detectFilterGen cell_w(int cell_w) => this.SetOptionRange("cell_w", cell_w, 0, I64_MAX);
        /// <summary>
        ///  cell height (from 0 to I64_MAX) (default 0)
        /// </summary>
        public Dnn_detectFilterGen cell_h(int cell_h) => this.SetOptionRange("cell_h", cell_h, 0, I64_MAX);
        /// <summary>
        ///  The number of class (from 0 to I64_MAX) (default 0)
        /// </summary>
        public Dnn_detectFilterGen nb_classes(int nb_classes) => this.SetOptionRange("nb_classes", nb_classes, 0, I64_MAX);
        /// <summary>
        ///  anchors, splited by &#39;&amp;&#39;
        /// </summary>
        public Dnn_detectFilterGen anchors(String anchors) => this.SetOption("anchors", anchors.ToString());
    }

    /// <summary>
    ///  DNN detection model type (from INT_MIN to INT_MAX) (default ssd)
    /// </summary>
    public enum Dnn_detectFilterGenModel_type
    {
        /// <summary>
        /// ssd             0            ..FV....... output shape [1, 1, N, 7]
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ssd")]
        ssd = 0,
        /// <summary>
        /// yolo            1            ..FV....... output shape [1, N*Cx*Cy*DetectionBox]
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yolo")]
        yolo = 1,
        /// <summary>
        /// yolov3          2            ..FV....... outputs shape [1, N*D, Cx, Cy]
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yolov3")]
        yolov3 = 2,
        /// <summary>
        /// yolov4          3            ..FV....... outputs shape [1, N*D, Cx, Cy]
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yolov4")]
        yolov4 = 3
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply DNN detect filter to the input.
        /// </summary>
        public static Dnn_detectFilterGen Dnn_detectFilterGen(this ImageMap input0) => new Dnn_detectFilterGen(input0);
    }
}