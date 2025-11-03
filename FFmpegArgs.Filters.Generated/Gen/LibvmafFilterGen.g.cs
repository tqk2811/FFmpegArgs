namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. libvmaf           VV-&gt;V      Calculate the VMAF between two video streams.
    /// </summary>
    public class LibvmafFilterGen : ImageToImageFilter
    {
        internal LibvmafFilterGen(params ImageMap[] inputs) : base("libvmaf", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Set the file path to be used to write log.
        /// </summary>
        public LibvmafFilterGen log_path(String log_path) => this.SetOption("log_path", log_path.ToStringInv());
        /// <summary>
        ///  Set the format of the log (csv, json, xml, or sub). (default &quot;xml&quot;)
        /// </summary>
        public LibvmafFilterGen log_fmt(String log_fmt) => this.SetOption("log_fmt", log_fmt.ToStringInv());
        /// <summary>
        ///  Set the pool method to be used for computing vmaf.
        /// </summary>
        public LibvmafFilterGen pool(String pool) => this.SetOption("pool", pool.ToStringInv());
        /// <summary>
        ///  Set number of threads to be used when computing vmaf. (from 0 to UINT32_MAX) (default 0)
        /// </summary>
        public LibvmafFilterGen n_threads(int n_threads) => this.SetOptionRange("n_threads", n_threads, 0, UINT32_MAX);
        /// <summary>
        ///  Set interval for frame subsampling used when computing vmaf. (from 1 to UINT32_MAX) (default 1)
        /// </summary>
        public LibvmafFilterGen n_subsample(int n_subsample) => this.SetOptionRange("n_subsample", n_subsample, 1, UINT32_MAX);
        /// <summary>
        ///  Set the model to be used for computing vmaf. (default &quot;version=vmaf_v0.6.1&quot;)
        /// </summary>
        public LibvmafFilterGen model(String model) => this.SetOption("model", model.ToStringInv());
        /// <summary>
        ///  Set the feature to be used for computing vmaf.
        /// </summary>
        public LibvmafFilterGen feature(String feature) => this.SetOption("feature", feature.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Calculate the VMAF between two video streams.
        /// </summary>
        public static LibvmafFilterGen LibvmafFilterGen(this ImageMap input0, ImageMap input1) => new LibvmafFilterGen(input0, input1);
    }
}