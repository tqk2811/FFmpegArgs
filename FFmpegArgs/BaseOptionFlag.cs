using System;
using System.Collections.Generic;
using System.Linq;
namespace FFmpegArgs
{
    public abstract class BaseOptionFlag : BaseOption
    {
        internal readonly HashSet<string> _flags = new HashSet<string>();
        protected string GetArgs()
        {
            return string.Join(" ", _flags.Concat(_options.Select(x => $"{x.Key} {x.Value}")));
        }
    }
    public static class BaseOptionFlagExtension
    {
        public static T SetFlag<T>(this T baseOptionFlag, string flag) where T : BaseOptionFlag
        {
            if (string.IsNullOrEmpty(flag)) throw new ArgumentNullException(nameof(flag));
            baseOptionFlag._flags.Add(flag);
            return baseOptionFlag;
        }
    }
}
