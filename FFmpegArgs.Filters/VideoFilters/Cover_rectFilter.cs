/*
cover_rect AVOptions:
  cover             <string>     ..FV....... cover bitmap filename
  mode              <int>        ..FV....... set removal mode (from 0 to 1) (default blur)
     cover           0            ..FV....... cover area with bitmap
     blur            1            ..FV....... blur area
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... cover_rect        V->V       Find and cover a user specified object.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#cover_005frect
    /// </summary>
    public class Cover_rectFilter : ImageToImageFilter
    {
        internal Cover_rectFilter(ImageMap imageMap) : base("cover_rect", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Filepath of the optional cover image, needs to be in yuv420.
        /// </summary>
        /// <param name="filePathOrName"></param>
        /// <returns></returns>
        public Cover_rectFilter Cover(string filePathOrName) => this.SetOption("cover", filePathOrName);
        /// <summary>
        /// Set covering mode.<br></br>
        /// Default value is blur.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public Cover_rectFilter Mode(Cover_rectMode mode) => this.SetOption("mode", mode);
    }
    public static class Cover_rectFilterExtensions
    {
        /// <summary>
        /// Cover a rectangular object
        /// </summary>
        public static Cover_rectFilter Cover_rectFilter(this ImageMap imageMap) => new Cover_rectFilter(imageMap);
    }
    public enum Cover_rectMode
    {
        cover,
        blur
    }
}
