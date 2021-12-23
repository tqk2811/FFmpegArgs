using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... fps               V->V       Force constant framerate.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#fps-1
    /// </summary>
    public class FpsFilter : ImageToImageFilter
    {
        static readonly IEnumerable<string> _consts = new List<string>()
        {
            "source_fps",
            "ntsc",
            "pal",
            "film",
            "ntsc_film"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_consts);
        internal FpsFilter(ImageMap imageMap) : base("fps", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// The desired output frame rate.
        /// </summary>
        /// <param name="fps"></param>
        /// <returns></returns>
        public FpsFilter Fps(int fps) => this.SetOptionRange("fps", fps, 1, int.MaxValue);

        /// <summary>
        /// The desired output frame rate.
        /// </summary>
        /// <param name="fps"></param>
        /// <returns></returns>
        public FpsFilter Fps(double fps) => this.SetOptionRange("fps", fps, 1, int.MaxValue);

        /// <summary>
        /// The desired output frame rate.
        /// </summary>
        /// <param name="fps"></param>
        /// <returns></returns>
        public FpsFilter Fps(string fps) => this.Fps(fps.Expression());

        /// <summary>
        /// The desired output frame rate.
        /// </summary>
        /// <param name="fps"></param>
        /// <returns></returns>
        public FpsFilter Fps(Action<FFmpegExpression> fps) => this.SetOption("fps", fps.Run(expression));

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
        public FpsFilter EofAction(FpsEofAction fpsEofAction) => this.SetOption("round", fpsEofAction);
    }

    public static class FpsFilterExtension
    {
        /// <summary>
        /// Convert the video to specified constant frame rate by duplicating or dropping frames as necessary.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static FpsFilter FpsFilter(this ImageMap imageMap) => new FpsFilter(imageMap);

        /// <summary>
        /// Convert the video to specified constant frame rate by duplicating or dropping frames as necessary.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="fps">The desired output frame rate.</param>
        /// <returns></returns>
        public static FpsFilter FpsFilter(this ImageMap imageMap, Action<FFmpegExpression> fps) => new FpsFilter(imageMap).Fps(fps);

        /// <summary>
        /// Convert the video to specified constant frame rate by duplicating or dropping frames as necessary.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="fps">The desired output frame rate.</param>
        /// <returns></returns>
        public static FpsFilter FpsFilter(this ImageMap imageMap, string fps) => new FpsFilter(imageMap).Fps(fps);

        /// <summary>
        /// Convert the video to specified constant frame rate by duplicating or dropping frames as necessary.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="fps">The desired output frame rate.</param>
        /// <returns></returns>
        public static FpsFilter FpsFilter(this ImageMap imageMap, int fps) => new FpsFilter(imageMap).Fps(fps);

        /// <summary>
        /// Convert the video to specified constant frame rate by duplicating or dropping frames as necessary.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="fps">The desired output frame rate.</param>
        /// <returns></returns>
        public static FpsFilter FpsFilter(this ImageMap imageMap, double fps) => new FpsFilter(imageMap).Fps(fps);
    }

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
}
