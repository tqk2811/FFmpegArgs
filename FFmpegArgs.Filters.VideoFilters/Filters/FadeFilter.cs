/*
fade AVOptions:
  type              <int>        ..FV....... set the fade direction (from 0 to 1) (default in)
     in              0            ..FV....... fade-in
     out             1            ..FV....... fade-out
  t                 <int>        ..FV....... set the fade direction (from 0 to 1) (default in)
     in              0            ..FV....... fade-in
     out             1            ..FV....... fade-out
  start_frame       <int>        ..FV....... Number of the first frame to which to apply the effect. (from 0 to INT_MAX) (default 0)
  s                 <int>        ..FV....... Number of the first frame to which to apply the effect. (from 0 to INT_MAX) (default 0)
  nb_frames         <int>        ..FV....... Number of frames to which the effect should be applied. (from 1 to INT_MAX) (default 25)
  n                 <int>        ..FV....... Number of frames to which the effect should be applied. (from 1 to INT_MAX) (default 25)
  alpha             <boolean>    ..FV....... fade alpha if it is available on the input (default false)
  start_time        <duration>   ..FV....... Number of seconds of the beginning of the effect. (default 0)
  st                <duration>   ..FV....... Number of seconds of the beginning of the effect. (default 0)
  duration          <duration>   ..FV....... Duration of the effect in seconds. (default 0)
  d                 <duration>   ..FV....... Duration of the effect in seconds. (default 0)
  color             <color>      ..FV....... set color (default "black")
  c                 <color>      ..FV....... set color (default "black")
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TS. fade              V->V       Fade in/out input video.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#fade
    /// </summary>
    public class FadeFilter : ImageToImageFilter
    {
        internal FadeFilter(ImageMap imageMap) : base("fade", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// The effect type can be either "in" for a fade-in, or "out" for a fade-out effect. Default is in.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public FadeFilter Type(FadeType t)
            => this.SetOption("t", t.ToString().ToLower());
        /// <summary>
        /// Specify the number of the frame to start applying the fade effect at. (from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public FadeFilter StartFrame(int s)
          => this.SetOptionRange("s", s, 0, int.MaxValue);
        /// <summary>
        /// The number of frames that the fade effect lasts. At the end of the fade-in effect, the output video will have the same intensity as the input video.<br>
        /// </br> At the end of the fade-out transition, the output video will be filled with the selected color.<br>
        /// </br> (from 1 to INT_MAX) (default 25)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public FadeFilter NbFrames(int n)
          => this.SetOptionRange("n", n, 1, int.MaxValue);
        /// <summary>
        /// If set to 1, fade only alpha channel, if one exists on the input. Default value is 0.
        /// </summary>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public FadeFilter Alpha(bool alpha)
          => this.SetOption("alpha", alpha.ToFFmpegFlag());
        /// <summary>
        /// Specify the timestamp (in seconds) of the frame to start to apply the fade effect.<br>
        /// </br> If both start_frame and start_time are specified, the fade will start at whichever comes last. Default is 0.
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public FadeFilter StartTime(TimeSpan st)
          => this.SetOptionRange("st", st, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// The number of seconds for which the fade effect has to last.<br>
        /// </br> At the end of the fade-in effect the output video will have the same intensity as the input video, at the end of the fade-out transition the output video will be filled with the selected color.<br>
        /// </br> If both duration and nb_frames are specified, duration is used.<br>
        /// </br> Default is 0 (nb_frames is used by default).
        /// </summary>
        /// <returns></returns>
        public FadeFilter Duration(TimeSpan duration)
          => this.SetOptionRange("d", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// Specify the color of the fade. Default is "black".
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public FadeFilter Color(Color c)
          => this.SetOption("c", c.ToHexStringRGBA());
    }
    public static class FadeFilterExtensions
    {
        /// <summary>
        /// Apply a fade-in/out effect to the input video.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static FadeFilter FadeFilter(this ImageMap imageMap) => new FadeFilter(imageMap);
    }
    public enum FadeType
    {
        In,
        Out
    }
}
