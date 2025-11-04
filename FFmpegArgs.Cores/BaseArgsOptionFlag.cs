namespace FFmpegArgs.Cores
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseArgsOptionFlag : BaseArgsOption, IFlag
    {
        /// <summary>
        /// 
        /// </summary>
        public BaseArgsOptionFlag()
        {
            this._flags = new HashSet<string>();
        }

        /// <inheritdoc cref="BaseOption.BaseOption(BaseOption)"/>
        public BaseArgsOptionFlag(BaseArgsOptionFlag parent) : base(parent)
        {
            this._flags = parent._flags;
        }

        internal readonly HashSet<string> _flags;

        /// <summary>
        /// 
        /// </summary>
        public virtual IReadOnlyCollection<string> Flags => _flags;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> GetFlagArgs()
        {
            return Flags;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<string> GetAllArgs();

        [Obsolete]
        public override string ToString()
        {
            return string.Join(" ", GetAllArgs());
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
        /// <param name="throwIfDuplicate"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static T SetFlag<T>(this T baseOptionFlag, string flag, bool throwIfDuplicate = BaseOption.DEFAULT_ThrowIfDuplicate)
            where T : BaseArgsOptionFlag
        {
            if (string.IsNullOrEmpty(flag)) throw new ArgumentNullException(nameof(flag));
            if (throwIfDuplicate && baseOptionFlag._flags.Contains(flag))
                throw new InvalidOperationException($"Flag '{flag}' already exists");
            baseOptionFlag._flags.Add(flag);
            return baseOptionFlag;
        }
    }
}
