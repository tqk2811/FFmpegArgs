/*
tpad AVOptions:
  start             <int>        ..FV....... set the number of frames to delay input (from 0 to INT_MAX) (default 0)
  stop              <int>        ..FV....... set the number of frames to add after input finished (from -1 to INT_MAX) (default 0)
  start_mode        <int>        ..FV....... set the mode of added frames to start (from 0 to 1) (default add)
     add             0            ..FV....... add solid-color frames
     clone           1            ..FV....... clone first/last frame
  stop_mode         <int>        ..FV....... set the mode of added frames to end (from 0 to 1) (default add)
     add             0            ..FV....... add solid-color frames
     clone           1            ..FV....... clone first/last frame
  start_duration    <duration>   ..FV....... set the duration to delay input (default 0)
  stop_duration     <duration>   ..FV....... set the duration to pad input (default 0)
  color             <color>      ..FV....... set the color of the added frames (default "black")
*/
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... tpad              V->V       Temporarily pad video frames.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#tpad
    /// </summary>
    public class TpadFilter : ImageToImageFilter
    {
        internal TpadFilter(ImageMap imageMap) : base("tpad", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Specify number of delay frames before input video stream. (from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public TpadFilter Start(int start)
            => this.SetOptionRange("start", start, 0, INT_MAX);

        /// <summary>
        /// Specify number of padding frames after input video stream. Set to -1 to pad indefinitely. (from -1 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="stop"></param>
        /// <returns></returns>
        public TpadFilter Stop(int stop)
            => this.SetOptionRange("stop", stop, -1, INT_MAX);

        /// <summary>
        /// Set kind of frames added to beginning of stream. Can be either add or clone. With add frames of solid-color are added. With clone frames are clones of first frame. Default is add.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public TpadFilter StartMode(TpadMode mode)
            => this.SetOption("start_mode", mode.GetEnumAttribute<NameAttribute>().Name);

        /// <summary>
        /// Set kind of frames added to end of stream. Can be either add or clone. With add frames of solid-color are added. With clone frames are clones of last frame. Default is add.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public TpadFilter StopMode(TpadMode mode)
            => this.SetOption("stop_mode", mode.GetEnumAttribute<NameAttribute>().Name);

        /// <summary>
        /// set the duration to delay input (default 0)
        /// </summary>
        /// <param name="start_duration"></param>
        /// <returns></returns>
        public TpadFilter StartDuration(TimeSpan start_duration)
            => this.SetOptionRange("start_duration", start_duration, TimeSpan.Zero, TimeSpan.MaxValue);

        /// <summary>
        /// set the duration to pad input (default 0)
        /// </summary>
        /// <param name="stop_duration"></param>
        /// <returns></returns>
        public TpadFilter StopDuration(TimeSpan stop_duration)
            => this.SetOptionRange("stop_duration", stop_duration, TimeSpan.Zero, TimeSpan.MaxValue);

       /// <summary>
       /// Specify the color of the padded area. The default value of color is "black".
       /// </summary>
       /// <param name="color"></param>
       /// <returns></returns>
        public TpadFilter Color(Color color)
            => this.SetOption("color", color.ToHexStringRGBA());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class TpadFilterExtensions
    {
        /// <summary>
        /// Temporarily pad video frames.
        /// </summary>
        public static TpadFilter TpadFilter(this ImageMap imageMap)
          => new TpadFilter(imageMap);
    }

    /// <summary>
    /// set the mode of added frames to start (from 0 to 1) (default add)
    /// </summary>
    public enum TpadMode
    {
        /// <summary>
        /// add solid-color frames
        /// </summary>
        [Name("add")]
        Add = 0,

        /// <summary>
        /// clone first/last frame
        /// </summary>
        [Name("clone")]
        Clone = 1,
    }
}
