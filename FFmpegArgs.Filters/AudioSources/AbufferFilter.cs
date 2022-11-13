/*
abuffer AVOptions:
  time_base         <rational>   ..F.A...... (from 0 to INT_MAX) (default 0/1)
  sample_rate       <int>        ..F.A...... (from 0 to INT_MAX) (default 0)
  sample_fmt        <sample_fmt> ..F.A...... (default none)
  channel_layout    <string>     ..F.A......
  channels          <int>        ..F.A...... (from 0 to INT_MAX) (default 0)
 */
namespace FFmpegArgs.Filters.AudioSources
{
    /// <summary>
    /// ... abuffer           |->A       Buffer audio frames, and make them accessible to the filterchain.<br>
    /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#abuffer"/>
    /// </summary>
    public class AbufferFilter : SourceAudioFilter
    {
        internal AbufferFilter(IAudioFilterGraph filterGraph) : base("abuffer", filterGraph)
        {
            AddMapOut();
        }
        /// <summary>
        /// The timebase which will be used for timestamps of submitted frames. It must be either a floating-point number or in numerator/denominator form.
        /// </summary>
        /// <param name="time_base"></param>
        /// <returns></returns>
        public AbufferFilter TimeBase(Rational time_base)
          => this.SetOption("time_base", time_base.Check(0, INT_MAX));
        /// <summary>
        /// The sample rate of the incoming audio buffers.
        /// </summary>
        /// <param name="sample_rate"></param>
        /// <returns></returns>
        public AbufferFilter SampleRate(int sample_rate)
          => this.SetOptionRange("sample_rate", sample_rate, 0, INT_MAX);
        /// <summary>
        /// The sample format of the incoming audio buffers.<br>
        /// </br> Either a sample format name or its corresponding integer representation from the enum AVSampleFormat in libavutil/samplefmt.h
        /// </summary>
        /// <param name="sample_fmt"></param>
        /// <returns></returns>
        public AbufferFilter SampleFmt(AVSampleFormat sample_fmt)
          => this.SetOption("sample_fmt", sample_fmt.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        /// The channel layout of the incoming audio buffers.<br>
        /// </br> Either a channel layout name from channel_layout_map in libavutil/channel_layout.c or its corresponding integer representation from the AV_CH_LAYOUT_* macros in libavutil/channel_layout.h
        /// </summary>
        /// <param name="channel_layout"></param>
        /// <returns></returns>
        public AbufferFilter ChannelLayout(ChannelLayout channel_layout)
          => this.SetOption("channel_layout", channel_layout.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        /// The number of channels of the incoming audio buffers. If both channels and channel_layout are specified, then they must be consistent.
        /// </summary>
        /// <param name="channels"></param>
        /// <returns></returns>
        public AbufferFilter Channels(int channels)
          => this.SetOptionRange("channels", channels, 0, int.MaxValue);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AbufferFilterExtensions
    {
        /// <summary>
        /// Buffer audio frames, and make them available to the filter chain.<br></br>
        /// This source is mainly intended for a programmatic use, in particular through the interface defined in libavfilter/buffersrc.h.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#abuffer"/>
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static AbufferFilter AbufferFilter(this IAudioFilterGraph filterGraph)
          => new AbufferFilter(filterGraph);
    }
}
