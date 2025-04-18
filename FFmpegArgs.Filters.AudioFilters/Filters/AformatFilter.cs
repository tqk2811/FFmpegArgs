/*
aformat AVOptions:
  sample_fmts       <string>     ..F.A...... A '|'-separated list of sample formats.
  f                 <string>     ..F.A...... A '|'-separated list of sample formats.
  sample_rates      <string>     ..F.A...... A '|'-separated list of sample rates.
  r                 <string>     ..F.A...... A '|'-separated list of sample rates.
  channel_layouts   <string>     ..F.A...... A '|'-separated list of channel layouts.
  cl                <string>     ..F.A...... A '|'-separated list of channel layouts.
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... aformat           A->A       Convert the input audio to one of the specified formats.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#aformat
    /// </summary>
    public class AformatFilter : AudioToAudioFilter
    {
        internal AformatFilter(AudioMap audioMap) : base("aformat", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// A ’|’-separated list of requested sample formats.
        /// </summary>
        /// <param name="fmts"></param>
        /// <returns></returns>
        public AformatFilter SampleFmts(params AVSampleFormat[] fmts)
          => this.SetOption("f", string.Join("|", fmts.Select(x => x.GetEnumAttribute<NameAttribute>().Name)));
        /// <summary>
        /// list of requested sample rates.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public AformatFilter SampleRates(params int[] r)
          => this.SetOption("r", string.Join("|", r));
        /// <summary>
        /// A ’|’-separated list of requested channel layouts.<br>
        /// </br>https://ffmpeg.org/ffmpeg-utils.html#channel-layout-syntax
        /// </summary>
        /// <param name="cls"></param>
        /// <returns></returns>
        public AformatFilter ChannelLayouts(params ChannelLayout[] cls)
          => this.SetOption("cl", string.Join("|", cls.Select(x => x.GetEnumAttribute<NameAttribute>().Name)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AformatFilterExtensions
    {
        /// <summary>
        /// Set output format constraints for the input audio. The framework will negotiate the most appropriate format to minimize conversions.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <returns></returns>
        public static AformatFilter AformatFilter(this AudioMap audioMap)
          => new AformatFilter(audioMap);
    }
}
