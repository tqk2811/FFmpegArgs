namespace FFmpegArgs.Cores
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseOptionFlag : BaseOption, IFlag
    {
        internal readonly HashSet<string> _flags = new HashSet<string>();

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<string> Flags => _flags;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetFlagArgs()
        {
            return string.Join(" ", _flags);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class BaseOptionFlagExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseOptionFlag"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static T SetFlag<T>(this T baseOptionFlag, string flag) where T : BaseOptionFlag
        {
            if (string.IsNullOrEmpty(flag)) throw new ArgumentNullException(nameof(flag));
            baseOptionFlag._flags.Add(flag);
            return baseOptionFlag;
        }
    }
}
