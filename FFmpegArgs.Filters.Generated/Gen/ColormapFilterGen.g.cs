namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC colormap          VVV-&gt;V     Apply custom Color Maps to video stream.
    /// </summary>
    public class ColormapFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ColormapFilterGen(params ImageMap[] inputs) : base("colormap", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set patch size (default &quot;64x64&quot;)
        /// </summary>
        public ColormapFilterGen patch_size(Size patch_size) => this.SetOption("patch_size", Inv($"{patch_size.Width}x{patch_size.Height}"));
        /// <summary>
        ///  set number of patches (from 0 to 64) (default 0)
        /// </summary>
        public ColormapFilterGen nb_patches(int nb_patches) => this.SetOptionRange("nb_patches", nb_patches, 0, 64);
        /// <summary>
        ///  set the target type used (from 0 to 1) (default absolute)
        /// </summary>
        public ColormapFilterGen type(ColormapFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the kernel used for measuring color difference (from 0 to 1) (default euclidean)
        /// </summary>
        public ColormapFilterGen kernel(ColormapFilterGenKernel kernel) => this.SetOption("kernel", kernel.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set the target type used (from 0 to 1) (default absolute)
    /// </summary>
    public enum ColormapFilterGenType
    {
        /// <summary>
        /// relative        0            ..FV.....T. the target colors are relative
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("relative")]
        relative = 0,
        /// <summary>
        /// absolute        1            ..FV.....T. the target colors are absolute
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("absolute")]
        absolute = 1
    }

    /// <summary>
    ///  set the kernel used for measuring color difference (from 0 to 1) (default euclidean)
    /// </summary>
    public enum ColormapFilterGenKernel
    {
        /// <summary>
        /// euclidean       0            ..FV.....T. square root of sum of squared differences
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("euclidean")]
        euclidean = 0,
        /// <summary>
        /// weuclidean      1            ..FV.....T. weighted square root of sum of squared differences
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("weuclidean")]
        weuclidean = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply custom Color Maps to video stream.
        /// </summary>
        public static ColormapFilterGen ColormapFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2) => new ColormapFilterGen(input0, input1, input2);
    }
}