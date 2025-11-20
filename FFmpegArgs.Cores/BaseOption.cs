namespace FFmpegArgs.Cores
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseOption : IOption
    {
        internal const bool DEFAULT_ThrowIfDuplicate = false;
        /// <summary>
        /// 
        /// </summary>
        public BaseOption()
        {
            this._options = new Dictionary<string, string>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public BaseOption(BaseOption parent)
        {
            this._options = parent?._options ?? throw new ArgumentNullException(nameof(parent));
        }

        internal readonly Dictionary<string, string> _options;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected const float FLT_MIN = 0;
        protected const float FLT_MAX = float.MaxValue;
        protected const int INT_MAX = int.MaxValue;
        protected const int INT_MIN = int.MinValue;
        protected const long I64_MAX = long.MaxValue;
        protected const long I64_MIN = long.MinValue;
        protected const uint UINT32_MAX = uint.MaxValue;
        protected const double DBL_MAX = double.MaxValue;
        protected const double DBL_MIN = double.MinValue;

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member


        /// <summary>
        /// 
        /// </summary>
        public virtual IReadOnlyDictionary<string, string> Options => _options;

    }
    /// <summary>
    /// 
    /// </summary>
    public static class BaseOptionExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseOption"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        /// <param name="throwIfDuplicate"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static T SetOption<T>(
            this T baseOption,
            string key,
            string val,
            bool throwIfDuplicate = BaseOption.DEFAULT_ThrowIfDuplicate
            )
            where T : BaseOption
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));
            if (string.IsNullOrEmpty(val))
                throw new ArgumentNullException(nameof(val));
            if (throwIfDuplicate && baseOption._options.ContainsKey(key))
                throw new InvalidOperationException($"Option '{key}' already exists with value {baseOption._options[key]}");
            baseOption._options[key] = val;
            return baseOption;
        }
        /// <summary>
        /// Adds or updates an option with a size value in the specified option set using the given key.
        /// </summary>
        /// <remarks>The size value is stored as a string in the format "{Width}x{Height}". This method
        /// enables fluent configuration of option sets by returning the updated instance.</remarks>
        /// <typeparam name="T">The type of option set to update. Must inherit from <see cref="BaseOption"/>.</typeparam>
        /// <param name="baseOption">The option set to which the size option will be added or updated.</param>
        /// <param name="key">The key that identifies the option. Cannot be null or empty.</param>
        /// <param name="size">The <see cref="Size"/> value to associate with the specified key.</param>
        /// <param name="throwIfDuplicate">If <see langword="true"/>, throws an exception if the key already exists; otherwise, overwrites the existing
        /// value. The default is <see langword="true"/>.</param>
        /// <returns>The updated option set with the specified size option added or updated.</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null or empty.</exception>
        /// <exception cref="InvalidOperationException">Thrown if <paramref name="throwIfDuplicate"/> is <see langword="true"/> and the specified key already exists
        /// in the option set.</exception>
        public static T SetOption<T>(
            this T baseOption,
            string key,
            Size size,
            bool throwIfDuplicate = BaseOption.DEFAULT_ThrowIfDuplicate
            )
            where T : BaseOption
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));
            if (throwIfDuplicate && baseOption._options.ContainsKey(key))
                throw new InvalidOperationException($"Option '{key}' already exists with value {baseOption._options[key]}");
            baseOption._options[key] = $"{size.Width}x{size.Height}";
            return baseOption;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseOption"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        /// <param name="throwIfDuplicate"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static T SetOption<T>(
            this T baseOption,
            string key,
            object val,
            bool throwIfDuplicate = BaseOption.DEFAULT_ThrowIfDuplicate
            )
            where T : BaseOption
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));
            if (val is null)
                throw new ArgumentNullException(nameof(val));
            return baseOption.SetOption(key, val.ToString(), throwIfDuplicate);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseOption"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="throwIfDuplicate"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidRangeException"></exception>
        public static T SetOptionRange<T>(
            this T baseOption,
            string key,
            int val,
            int min,
            int max,
            bool throwIfDuplicate = BaseOption.DEFAULT_ThrowIfDuplicate
            )
            where T : BaseOption
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));
            if (val < min || val > max)
                throw new InvalidRangeException($"Range Required: {min} <= {key} <= {max}");
            return baseOption.SetOption(key, val.ToString(), throwIfDuplicate);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseOption"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="throwIfDuplicate"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidRangeException"></exception>
        public static T SetOptionRange<T>(
            this T baseOption,
            string key,
            float val,
            float min,
            float max,
            bool throwIfDuplicate = BaseOption.DEFAULT_ThrowIfDuplicate
            )
            where T : BaseOption
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));
            if (float.IsNaN(val) || val < min || val > max)
                throw new InvalidRangeException($"Range Required: {min} <= {key} <= {max}");
            return baseOption.SetOption(key, val.ToString(), throwIfDuplicate);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseOption"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="throwIfDuplicate"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidRangeException"></exception>
        public static T SetOptionRange<T>(
            this T baseOption,
            string key,
            double val,
            double min,
            double max,
            bool throwIfDuplicate = BaseOption.DEFAULT_ThrowIfDuplicate
            )
            where T : BaseOption
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));
            if (double.IsNaN(val) || val < min || val > max)
                throw new InvalidRangeException($"Range Required: {min} <= {key} <= {max}");
            return baseOption.SetOption(key, val.ToString(), throwIfDuplicate);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseOption"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="throwIfDuplicate"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidRangeException"></exception>
        public static T SetOptionRange<T>(
            this T baseOption,
            string key,
            long val,
            long min,
            long max,
            bool throwIfDuplicate = BaseOption.DEFAULT_ThrowIfDuplicate
            )
            where T : BaseOption
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));
            if (val < min || val > max)
                throw new InvalidRangeException($"Range Required: {min} <= {key} <= {max}");
            return baseOption.SetOption(key, val.ToString(), throwIfDuplicate);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseOption"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="throwIfDuplicate"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidRangeException"></exception>
        public static T SetOptionRange<T>(
            this T baseOption,
            string key,
            decimal val,
            decimal min,
            decimal max,
            bool throwIfDuplicate = BaseOption.DEFAULT_ThrowIfDuplicate
            )
            where T : BaseOption
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));
            if (val < min || val > max)
                throw new InvalidRangeException($"Range Required: {min} <= {key} <= {max}");
            return baseOption.SetOption(key, val.ToString(), throwIfDuplicate);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseOption"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="throwIfDuplicate"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidRangeException"></exception>
        public static T SetOptionRange<T>(
            this T baseOption,
            string key,
            TimeSpan val,
            TimeSpan min,
            TimeSpan max,
            bool throwIfDuplicate = BaseOption.DEFAULT_ThrowIfDuplicate
            )
            where T : BaseOption
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));
            if (val < min || val > max)
                throw new InvalidRangeException($"Range Required: {min:hh\\:mm\\:ss\\.fff} <= {key:hh\\:mm\\:ss\\.fff} <= {max:hh\\:mm\\:ss\\.fff}");
            return baseOption.SetOption(key, val.ToString(), throwIfDuplicate);
        }
    }
}
