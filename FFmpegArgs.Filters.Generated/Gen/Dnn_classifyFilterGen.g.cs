﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... dnn_classify      V-&gt;V       Apply DNN classify filter to the input.
    /// </summary>
    public class Dnn_classifyFilterGen : ImageToImageFilter
    {
        internal Dnn_classifyFilterGen(ImageMap input) : base("dnn_classify", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  DNN backend (from INT_MIN to INT_MAX) (default 2)
        /// </summary>
        public Dnn_classifyFilterGen dnn_backend(int dnn_backend) => this.SetOptionRange("dnn_backend", dnn_backend, INT_MIN, INT_MAX);
        /// <summary>
        ///  path to model file
        /// </summary>
        public Dnn_classifyFilterGen model(String model) => this.SetOption("model", model.ToString());
        /// <summary>
        ///  input name of the model
        /// </summary>
        public Dnn_classifyFilterGen input(String input) => this.SetOption("input", input.ToString());
        /// <summary>
        ///  output name of the model
        /// </summary>
        public Dnn_classifyFilterGen output(String output) => this.SetOption("output", output.ToString());
        /// <summary>
        ///  backend configs
        /// </summary>
        public Dnn_classifyFilterGen backend_configs(String backend_configs) => this.SetOption("backend_configs", backend_configs.ToString());
        /// <summary>
        ///  backend configs (deprecated, use backend_configs)
        /// </summary>
        public Dnn_classifyFilterGen options(String options) => this.SetOption("options", options.ToString());
        /// <summary>
        ///  use DNN async inference (ignored, use backend_configs=&#39;async=1&#39;) (default true)
        /// </summary>
        public Dnn_classifyFilterGen _async(bool _async) => this.SetOption("async", _async.ToFFmpegFlag());
        /// <summary>
        ///  threshold of confidence (from 0 to 1) (default 0.5)
        /// </summary>
        public Dnn_classifyFilterGen confidence(float confidence) => this.SetOptionRange("confidence", confidence, 0, 1);
        /// <summary>
        ///  path to labels file
        /// </summary>
        public Dnn_classifyFilterGen labels(String labels) => this.SetOption("labels", labels.ToString());
        /// <summary>
        ///  which one to be classified
        /// </summary>
        public Dnn_classifyFilterGen target(String target) => this.SetOption("target", target.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply DNN classify filter to the input.
        /// </summary>
        public static Dnn_classifyFilterGen Dnn_classifyFilterGen(this ImageMap input0) => new Dnn_classifyFilterGen(input0);
    }
}