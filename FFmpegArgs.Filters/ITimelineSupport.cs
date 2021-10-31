using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Utils;
using System;

namespace FFmpegArgs.Filters
{
  /// <summary>
  /// https://ffmpeg.org/ffmpeg-filters.html#Timeline-editing
  /// </summary>
  public interface ITimelineSupport : IFilter
  {
  }

  public static class TimelineSupportExtension
  {
    public static T Enable<T>(this T timelineSupport, Action<TimelineEditingExpression> timelineExpression) where T : BaseOption, ITimelineSupport
    {
      TimelineEditingExpression timelineEditingExpression = new TimelineEditingExpression();
      timelineExpression?.Invoke(timelineEditingExpression);
      return timelineSupport.SetOption("enable", $"'{timelineEditingExpression}'");
    }

    public static T Enable<T>(this T timelineSupport, string timelineExpression) where T : BaseOption, ITimelineSupport
      => timelineSupport.Enable(timelineExpression.Expression());
  }
}
