/*
channelmap AVOptions:
  map               <string>     ..F.A...... A comma-separated list of input channel numbers in output order.
  channel_layout    <string>     ..F.A...... Output channel layout.
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... channelmap        A->A       Remap audio channels.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#channelmap
    /// </summary>
    public class ChannelmapFilter : AudioToAudioFilter
    {
        internal ChannelmapFilter(AudioMap audioMap, Tuple<ChannelLayout, ChannelLayout>[] maps) : base("channelmap", audioMap)
        {
            AddMapOut();
            string _maps = string.Join("|", maps.Select(x => Inv($"{x.Item1.GetEnumAttribute<NameAttribute>().Name}-{x.Item2.GetEnumAttribute<NameAttribute>().Name}")));
            if (!string.IsNullOrEmpty(_maps)) this.SetOption("map", _maps);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelLayout"></param>
        /// <returns></returns>
        public ChannelmapFilter ChannelLayout(ChannelLayout channelLayout)
            => this.SetOption("channel_layout", channelLayout.GetEnumAttribute<NameAttribute>().Name);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class ChannelmapFilterExtensions
    {
        /// <summary>
        /// Remap input channels to new locations.
        /// </summary>
        [Obsolete("Need more information")]
        public static ChannelmapFilter ChannelmapFilter(this AudioMap audioMap, params Tuple<ChannelLayout, ChannelLayout>[] maps)
          => new ChannelmapFilter(audioMap, maps);
    }
}
