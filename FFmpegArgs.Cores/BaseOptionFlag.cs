namespace FFmpegArgs.Cores
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseOptionFlag : BaseArgsOption, IFlag
    {
        /// <summary>
        /// 
        /// </summary>
        public BaseOptionFlag()
        {
            this._flags = new HashSet<string>();
        }

        /// <inheritdoc cref="BaseOption.BaseOption(BaseOption)"/>
        public BaseOptionFlag(BaseOptionFlag parent) : base(parent)
        {
            this._flags = parent._flags;
        }

        internal readonly HashSet<string> _flags;

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<string> Flags => _flags;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string GetFlagArgs()
        {
            return string.Join(" ", Flags);
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
