/*
showinfo AVOptions:
   checksum          <boolean>    ..FV....... calculate checksums (default true)
   udu_sei_as_ascii  <boolean>    ..FV....... try to print user data unregistered SEI as ascii character when possible (default false)
*/
namespace FFmpegArgs.Filters.VideoFilters.Filters
{
    /// <summary>
    ///  ... showinfo          V->V       Show textual information for each video frame.<br></br>
    /// https://ffmpeg.org/ffmpeg-all.html#toc-showinfo-1
    /// </summary>
    public class ShowinfoFilter : ImageToImageFilter
    {
        public ShowinfoFilter(ImageMap mapIn) : base("showinfo", mapIn)
        {
            this.AddMapOut();
        }

        /// <summary>
        /// Calculate checksums of each plane. By default enabled.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public ShowinfoFilter Checksum(bool flag)
            => this.SetOption("checksum", flag.ToFFmpegFlag());
        /// <summary>
        /// Try to print user data unregistered SEI as ascii character when possible, in hex format otherwise.<br/>
        /// Default: false
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public ShowinfoFilter UduSeiAsAscii(bool flag)
            => this.SetOption("udu_sei_as_ascii", flag.ToFFmpegFlag());

    }
    public static class ShowinfoFilterExtensions
    {
        public static ShowinfoFilter ShowinfoFilter(this ImageMap imageMap)
            => new ShowinfoFilter(imageMap);
    }
}
