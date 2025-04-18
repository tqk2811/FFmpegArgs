/*
fps AVOptions:
  fps               <video_rate> ..FV....... A string describing desired output framerate (default "25")
  start_time        <double>     ..FV....... Assume the first PTS should be this value. (from -DBL_MAX to DBL_MAX) (default DBL_MAX)
  round             <int>        ..FV....... set rounding method for timestamps (from 0 to 5) (default near)
     zero            0            ..FV....... round towards 0
     inf             1            ..FV....... round away from 0
     down            2            ..FV....... round towards -infty
     up              3            ..FV....... round towards +infty
     near            5            ..FV....... round to nearest
  eof_action        <int>        ..FV....... action performed for last frame (from 0 to 1) (default round)
     round           0            ..FV....... round similar to other frames
     pass            1            ..FV....... pass through last frame
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... fps               V->V       Force constant framerate.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#fps-1
    /// </summary>
    public class FpsFilter : ImageToImageFilter
    {
        internal FpsFilter(ImageMap imageMap) : base("fps", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// The desired output frame rate.
        /// </summary>
        /// <param name="fps"></param>
        /// <returns></returns>
        public FpsFilter Fps(Rational fps) => this.SetOption("fps", fps.Check(0, double.MaxValue));
        /// <summary>
        /// The desired output frame rate.
        /// </summary>
        /// <param name="fps"></param>
        /// <returns></returns>
        public FpsFilter Fps(FpsConstants fps) => this.SetOption("fps", fps);
        /// <summary>
        /// Assume the first PTS should be the given value, in seconds. This allows for padding/trimming at the start of stream. By default, no assumption is made about the first frame’s expected PTS, so no padding or trimming is done. For example, this could be set to 0 to pad the beginning with duplicates of the first frame if a video stream starts after the audio stream or to trim any frames with a negative PTS.
        /// </summary>
        /// <param name="startTime"></param>
        /// <returns></returns>
        public FpsFilter StartTime(double startTime) => this.SetOption("start_time", startTime);
        /// <summary>
        /// Timestamp (PTS) rounding method.
        /// </summary>
        /// <param name="fpsRound"></param>
        /// <returns></returns>
        public FpsFilter Round(FpsRound fpsRound) => this.SetOption("round", fpsRound);
        /// <summary>
        /// Action performed when reading the last frame.
        /// </summary>
        /// <param name="fpsEofAction"></param>
        /// <returns></returns>
        public FpsFilter EofAction(FpsEofAction fpsEofAction) => this.SetOption("eof_action", fpsEofAction);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class FpsFilterExtension
    {
        /// <summary>
        /// Convert the video to specified constant frame rate by duplicating or dropping frames as necessary.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static FpsFilter FpsFilter(this ImageMap imageMap) => new FpsFilter(imageMap);
    }

    /// <summary>
    /// 
    /// </summary>
    public enum FpsRound
    {
        /// <summary>
        /// round towards 0
        /// </summary>
        zero,
        /// <summary>
        /// round away from 0
        /// </summary>
        inf,
        /// <summary>
        /// round towards -infinity
        /// </summary>
        down,
        /// <summary>
        /// round towards +infinity
        /// </summary>
        up,
        /// <summary>
        /// round to nearest
        /// </summary>
        near,
    }

    /// <summary>
    /// 
    /// </summary>
    public enum FpsEofAction
    {
        /// <summary>
        /// Use same timestamp rounding method as used for other frames.
        /// </summary>
        round,
        /// <summary>
        /// Pass through last frame if input duration has not been reached yet.
        /// </summary>
        pass
    }

    /// <summary>
    /// 
    /// </summary>
    public enum FpsConstants
    {
        /// <summary>
        /// The input’s frame rate
        /// </summary>
        source_fps,
        /// <summary>
        /// NTSC frame rate of 30000/1001
        /// </summary>
        ntsc,
        /// <summary>
        /// PAL frame rate of 25.0
        /// </summary>
        pal,
        /// <summary>
        /// Film frame rate of 24.0
        /// </summary>
        film,
        /// <summary>
        /// NTSC-film frame rate of 24000/1001
        /// </summary>
        ntsc_film
    }
}
