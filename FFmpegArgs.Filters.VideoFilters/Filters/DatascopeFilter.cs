/*
datascope AVOptions:
  size              <image_size> ..FV....... set output size (default "hd720")
  s                 <image_size> ..FV....... set output size (default "hd720")
  x                 <int>        ..FV.....T. set x offset (from 0 to INT_MAX) (default 0)
  y                 <int>        ..FV.....T. set y offset (from 0 to INT_MAX) (default 0)
  mode              <int>        ..FV.....T. set scope mode (from 0 to 2) (default mono)
     mono            0            ..FV.....T.
     color           1            ..FV.....T.
     color2          2            ..FV.....T.
  axis              <boolean>    ..FV.....T. draw column/row numbers (default false)
  opacity           <float>      ..FV.....T. set background opacity (from 0 to 1) (default 0.75)
  format            <int>        ..FV.....T. set display number format (from 0 to 1) (default hex)
     hex             0            ..FV.....T.
     dec             1            ..FV.....T.
  components        <int>        ..FV.....T. set components to display (from 1 to 15) (default 15)
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// .SC datascope         V->V       Video data analysis.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#datascope
    /// </summary>
    public class DatascopeFilter : ImageToImageFilter, ISliceThreading, ICommandSupport
    {
        internal DatascopeFilter(ImageMap imageMap) : base("datascope", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set output video size.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public DatascopeFilter Mode(Size size) => this.SetOption("s", $"{size.Width}x{size.Height}");
        /// <summary>
        /// Set x offset from where to pick pixels.(from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public DatascopeFilter X(int x) => this.SetOptionRange("x", x, 0, INT_MAX);
        /// <summary>
        /// Set y offset from where to pick pixels.(from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public DatascopeFilter Y(int y) => this.SetOptionRange("y", y, 0, INT_MAX);
        /// <summary>
        /// Set scope mode
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public DatascopeFilter Mode(DatascopeMode mode) => this.SetOption("mode", mode);
        /// <summary>
        /// Draw rows and columns numbers on left and top of video.
        /// </summary>
        /// <param name="axis"></param>
        /// <returns></returns>
        public DatascopeFilter Axis(bool axis) => this.SetOption("axis", axis.ToFFmpegFlag());
        /// <summary>
        /// Set background opacity.
        /// </summary>
        /// <param name="opacity"></param>
        /// <returns></returns>
        public DatascopeFilter Opacity(float opacity) => this.SetOptionRange("opacity", opacity, 0, 1);
        /// <summary>
        /// Set display number format. Can be hex, or dec. Default is hex.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public DatascopeFilter Format(DatascopeFormat format) => this.SetOption("format", format);
        /// <summary>
        /// Set pixel components to display. By default all pixel components are displayed.<br>
        /// </br>set components to display (from 1 to 15) (default 15)
        /// </summary>
        /// <param name="components"></param>
        /// <returns></returns>
        public DatascopeFilter Components(int components) => this.SetOptionRange("components", components, 1, 15);
    }
    public static class DatascopeFilterExtensions
    {
        /// <summary>
        /// Video data analysis filter.<br></br>
        /// This filter shows hexadecimal pixel values of part of video.
        /// </summary>
        /// <returns></returns>
        public static DatascopeFilter DatascopeFilter(this ImageMap imageMap) => new DatascopeFilter(imageMap);
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
