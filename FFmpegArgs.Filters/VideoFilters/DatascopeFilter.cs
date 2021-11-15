using FFmpegArgs.Cores.Maps;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// .SC datascope         V->V       Video data analysis.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#datascope
    /// </summary>
    public class DatascopeFilter : ImageToImageFilter, ISliceThreading, ICommandSupport
    {
        internal DatascopeFilter(ImageMap imageMap, Size size, int x, int y) : base("datascope", imageMap)
        {
            AddMapOut();
            this.SetOption("s", $"{size.Width}x{size.Height}");
            this.SetOptionRange("x", x, 0, int.MaxValue);
            this.SetOptionRange("y", y, 0, int.MaxValue);
        }

        /// <summary>
        /// Set scope mode
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public DatascopeFilter Mode(DatascopeMode mode)
            => this.SetOption("mode", mode);


        /// <summary>
        /// Draw rows and columns numbers on left and top of video.
        /// </summary>
        /// <param name="axis"></param>
        /// <returns></returns>
        public DatascopeFilter Axis(bool axis)
            => this.SetOption("axis", axis.ToFFmpegFlag());

        /// <summary>
        /// Set background opacity.
        /// </summary>
        /// <param name="opacity"></param>
        /// <returns></returns>
        public DatascopeFilter Opacity(float opacity)
            => this.SetOptionRange("opacity", opacity, 0, 1);

        /// <summary>
        /// Set display number format. Can be hex, or dec. Default is hex.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public DatascopeFilter Format(DatascopeFormat format)
            => this.SetOption("format", format);

        /// <summary>
        /// Set pixel components to display. By default all pixel components are displayed.<br>
        /// </br>set components to display (from 1 to 15) (default 15)
        /// </summary>
        /// <param name="components"></param>
        /// <returns></returns>
        public DatascopeFilter Components(int components)
             => this.SetOptionRange("components", components, 1, 15);
    }

    public static class DatascopeFilterExtensions
    {
        /// <summary>
        /// Video data analysis filter.<br></br>
        /// This filter shows hexadecimal pixel values of part of video.
        /// </summary>
        /// <param name="size">Set output video size.</param>
        /// <param name="x">Set x offset from where to pick pixels.(from 0 to INT_MAX) (default 0)</param>
        /// <param name="y">Set y offset from where to pick pixels.(from 0 to INT_MAX) (default 0)</param>
        /// <returns></returns>
        public static DatascopeFilter DatascopeFilter(this ImageMap imageMap, Size size, int x, int y)
          => new DatascopeFilter(imageMap, size, x, y);
    }

    public enum DatascopeMode
    {
        /// <summary>
        /// Draw hexadecimal pixel values with white color on black background.
        /// </summary>
        mono,
        /// <summary>
        /// Draw hexadecimal pixel values with input video pixel color on black background.
        /// </summary>
        color,
        /// <summary>
        /// Draw hexadecimal pixel values on color background picked from input video, the text color is picked in such way so its always visible.
        /// </summary>
        color2
    }

    public enum DatascopeFormat
    {
        hex,
        dec
    }
}
