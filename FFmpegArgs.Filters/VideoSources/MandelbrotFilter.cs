using FFmpegArgs.Filters.Enums;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ... mandelbrot        |->V       Render a Mandelbrot fractal.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#mandelbrot
    /// </summary>
    public class MandelbrotFilter : SourceImageFilter
    {
        internal MandelbrotFilter(FilterGraph filterGraph) : base("mandelbrot", filterGraph)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set the terminal pts value. Default value is 400.
        /// </summary>
        /// <param name="end_pts"></param>
        /// <returns></returns>
        public MandelbrotFilter EndPts(double end_pts)
          => this.SetOptionRange("end_pts", end_pts, 0, I64_MAX);

        /// <summary>
        /// Set the terminal scale value. Must be a floating point value. Default value is 0.3.
        /// </summary>
        /// <param name="end_scale"></param>
        /// <returns></returns>
        public MandelbrotFilter EndScale(double end_scale)
          => this.SetOptionRange("end_scale", end_scale, 0, I64_MAX);

        /// <summary>
        /// Set the inner coloring mode, that is the algorithm used to draw the Mandelbrot fractal internal region.
        /// </summary>
        /// <param name="colorMode"></param>
        /// <returns></returns>
        public MandelbrotFilter Inner(MandelbrotInnerColorMode colorMode)
          => this.SetOption("inner", colorMode);

        /// <summary>
        /// Set the bailout value. (from 0 to FLT_MAX) (default 10)
        /// </summary>
        /// <param name="bailout"></param>
        /// <returns></returns>
        public MandelbrotFilter Bailout(double bailout)
          => this.SetOptionRange("bailout", bailout, 0, FLT_MAX);

        /// <summary>
        /// Set the maximum of iterations performed by the rendering algorithm. (from 1 to INT_MAX) (default 7189)
        /// </summary>
        /// <param name="maxiter"></param>
        /// <returns></returns>
        public MandelbrotFilter Maxiter(int maxiter)
         => this.SetOptionRange("maxiter", maxiter, 1, int.MaxValue);

        /// <summary>
        /// Set outer coloring mode
        /// </summary>
        /// <param name="outer"></param>
        /// <returns></returns>
        public MandelbrotFilter Outer(MandelbrotOuter outer)
         => this.SetOption("outer", outer);

        /// <summary>
        /// Set frame rate, expressed as number of frames per second. Default value is "25".
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public MandelbrotFilter Rate(int r)
          => this.SetOptionRange("r", r, 0, int.MaxValue);

        /// <summary>
        /// Set frame size. <br></br>
        /// Default value is "640x480".
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public MandelbrotFilter Size(VideoSizeUtils s)
          => this.SetOption("s", s.GetAttribute<NameAttribute>().Name);

        /// <summary>
        /// Set frame size. <br></br>
        /// Default value is "640x480".
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public MandelbrotFilter Size(Size s)
          => this.SetOption("s", $"{s.Width}x{s.Height}");

        /// <summary>
        /// Set the initial scale value. from 0 to FLT_MAX) (default 3)
        /// </summary>
        /// <param name="start_scale"></param>
        /// <returns></returns>
        public MandelbrotFilter StartScale(double start_scale)
          => this.SetOptionRange("start_scale", start_scale, 0, FLT_MAX);

        /// <summary>
        /// Set the initial x position. Must be a floating point value between -100 and 100.<br>
        /// </br> Default value is -0.743643887037158704752191506114774.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public MandelbrotFilter StartX(decimal x)
          => this.SetOptionRange("start_x", x, -100, 100);

        /// <summary>
        /// Set the initial y position. Must be a floating point value between -100 and 100.<br>
        /// </br> Default value is -0.131825904205311970493132056385139.
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public MandelbrotFilter StartY(decimal y)
          => this.SetOptionRange("start_y", y, -100, 100);


        /// <summary>
        /// set morph x frequency (from -FLT_MAX to FLT_MAX) (default 0.01)
        /// </summary>
        /// <param name="morphxf"></param>
        /// <returns></returns>
        public MandelbrotFilter morphxf(double morphxf)
            => this.SetOptionRange("morphxf", morphxf, double.MinValue, double.MaxValue);

        /// <summary>
        /// set morph y frequency (from -FLT_MAX to FLT_MAX) (default 0.0123)
        /// </summary>
        /// <param name="morphyf"></param>
        /// <returns></returns>
        public MandelbrotFilter Morphyf(double morphyf)
            => this.SetOptionRange("morphyf", morphyf, double.MinValue, double.MaxValue);
    }

    public static class MandelbrotFilterExtensions
    {
        /// <summary>
        /// Generate a Mandelbrot set fractal, and progressively zoom towards the point specified with start_x and start_y.
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static MandelbrotFilter MandelbrotFilter(this FilterGraph filterGraph)
          => new MandelbrotFilter(filterGraph);
    }

    public enum MandelbrotInnerColorMode
    {
        /// <summary>
        /// Set black mode.
        /// </summary>
        black,
        /// <summary>
        /// Show time until convergence.
        /// </summary>
        convergence,
        /// <summary>
        /// Set color based on point closest to the origin of the iterations.
        /// </summary>
        mincol,
        /// <summary>
        /// Set period mode.
        /// </summary>
        period
    }

    public enum MandelbrotOuter
    {
        /// <summary>
        /// Set iteration count mode.
        /// </summary>
        iteration_count,
        /// <summary>
        /// set normalized iteration count mode.
        /// </summary>
        normalized_iteration_count
    }
}
