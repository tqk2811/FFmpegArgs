using FFmpegArgs.Filters.VideoFilters;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ... openclsrc         |->V       Generate video using an OpenCL program<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#openclsrc
    /// </summary>
    public class OpenclsrcFilter : SourceImageFilter
    {
        internal OpenclsrcFilter(Size size, FormatPixFmt format, FilterGraph filterGraph) : base("openclsrc", filterGraph)
        {
            AddMapOut();
            this.SetOption("s", $"{size.Width}x{size.Height}");
            this.SetOption("format", format);
        }

        /// <summary>
        /// OpenCL program source file.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public OpenclsrcFilter Source(string source)
          => this.SetOption("source", source);

        /// <summary>
        /// Kernel name in program.
        /// </summary>
        /// <param name="kernel"></param>
        /// <returns></returns>
        public OpenclsrcFilter Kernel(string kernel)
          => this.SetOption("kernel", kernel);

        /// <summary>
        /// Number of frames generated every second. Default value is ’25’.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public OpenclsrcFilter Rate(int r)
         => this.SetOptionRange("r", r, 1, int.MaxValue);
    }

    public static class OpenclsrcFilterExtensions
    {
        /// <summary>
        /// Generate video using an OpenCL program.
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <param name="size">Size of frames to generate. This must be set.</param>
        /// <param name="format">Pixel format to use for the generated frames. This must be set.</param>
        /// <returns></returns>
        public static OpenclsrcFilter OpenclsrcFilter(this FilterGraph filterGraph, Size size, FormatPixFmt format)
          => new OpenclsrcFilter(size, format, filterGraph);
    }
}
