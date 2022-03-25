namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// 
    /// </summary>
    public interface IChannels
    {
        
    }
    /// <summary>
    /// 
    /// </summary>
    public static class IChannelsExtension
    {

        /// <summary>
        /// set channels to filter (default 0xffffffffffffffff)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="channels"></param>
        /// <returns></returns>
        public static T Channels<T>(this T t, ChannelLayout channels) where T : BaseOption, IChannels
            => t.SetOption("c", channels.GetEnumAttribute<NameAttribute>().Name);
    }
}
