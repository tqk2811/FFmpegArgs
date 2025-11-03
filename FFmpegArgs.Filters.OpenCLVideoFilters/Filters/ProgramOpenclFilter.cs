/*
program_opencl AVOptions:
   source            <string>     ..FV....... OpenCL program source file
   kernel            <string>     ..FV....... Kernel name in program
   inputs            <int>        ..FV....... Number of inputs (from 1 to INT_MAX) (default 1)
   size              <image_size> ..FV....... Video size
   s                 <image_size> ..FV....... Video size
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... program_opencl    N->V       Filter video using an OpenCL program<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#program_005fopencl-1
    /// </summary>
    public class ProgramOpenclFilter : ImageToImageFilter, IFramesync
    {
        internal ProgramOpenclFilter(ImageMap imageMap) : base("program_opencl", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// OpenCL program source file.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public ProgramOpenclFilter Source(string source)
            => this.SetOption("source", source);
        /// <summary>
        /// Kernel name in program.
        /// </summary>
        /// <param name="kernel"></param>
        /// <returns></returns>
        public ProgramOpenclFilter Kernel(string kernel)
            => this.SetOption("kernel", kernel);
        /// <summary>
        /// Number of inputs to the filter. (from 1 to INT_MAX) (default 1)
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public ProgramOpenclFilter Inputs(int inputs)
            => this.SetOptionRange("inputs", inputs, 1, INT_MAX);
        /// <summary>
        /// Size of output frames. Defaults to the same as the first input.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public ProgramOpenclFilter Size(Size size)
            => this.SetOption("size", Inv($"{size.Width}x{size.Height}"));
    }
    /// <summary>
    /// 
    /// </summary>
    public static class ProgramOpenclFilterExtensions
    {
        /// <summary>
        /// Filter video using an OpenCL program.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#program_005fopencl-1">Document</see>
        /// </summary>
        public static ProgramOpenclFilter ProgramOpenclFilter(this ImageMap imageMap)
          => new ProgramOpenclFilter(imageMap);
    }
}
