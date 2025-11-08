namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. program_opencl    N-&gt;V       Filter video using an OpenCL program
    /// </summary>
    public class Program_openclFilterGen : ImageToImageFilter
    {
        internal Program_openclFilterGen(params ImageMap[] inputs) : base("program_opencl", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  OpenCL program source file
        /// </summary>
        public Program_openclFilterGen source(String source) => this.SetOption("source", source.ToStringInv());
        /// <summary>
        ///  Kernel name in program
        /// </summary>
        public Program_openclFilterGen kernel(String kernel) => this.SetOption("kernel", kernel.ToStringInv());
        /// <summary>
        ///  Number of inputs (from 1 to INT_MAX) (default 1)
        /// </summary>
        public Program_openclFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs, 1, INT_MAX);
        /// <summary>
        ///  Video size
        /// </summary>
        public Program_openclFilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Filter video using an OpenCL program
        /// </summary>
        public static Program_openclFilterGen Program_openclFilterGen(this ImageMap input) => new Program_openclFilterGen(input);
    }
}