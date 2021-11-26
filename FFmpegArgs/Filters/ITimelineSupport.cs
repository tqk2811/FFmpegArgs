using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;

namespace FFmpegArgs.Filters
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg-filters.html#Timeline-editing
    /// </summary>
    public interface ITimelineSupport
    {
    }

    public static class TimelineSupportExtension
    {
        public static T Enable<T>(this T timelineSupport, Action<TimelineEditingExpression> timelineExpression)
            where T : BaseOption, IFilter<IMap, IMap>, ITimelineSupport
        {
            TimelineEditingExpression timelineEditingExpression = new TimelineEditingExpression();
            timelineExpression?.Invoke(timelineEditingExpression);
            return timelineSupport.SetOption("enable", $"{timelineEditingExpression}");
        }

        public static T Enable<T>(this T timelineSupport, string timelineExpression)
            where T : BaseOption, IFilter<IMap, IMap>, ITimelineSupport
          => timelineSupport.Enable(timelineExpression.Expression());
    }
}
