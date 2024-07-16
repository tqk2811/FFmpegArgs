namespace FFmpegArgs.Filters
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg-filters.html#Timeline-editing
    /// </summary>
    public interface ITimelineSupport
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public interface ITimelineSupportConfig
    {
        /// <summary>
        /// 
        /// </summary>
        string TimelineSupport { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class TimelineSupportExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="timelineSupport"></param>
        /// <param name="timelineExpression"></param>
        /// <returns></returns>
        public static T Enable<T>(this T timelineSupport, ExpressionValue timelineExpression)
            where T : BaseOption, ITimelineSupport
          => timelineSupport.SetOption("enable", TimelineEditingExpression.Instance.Check(timelineExpression));
    }
}
