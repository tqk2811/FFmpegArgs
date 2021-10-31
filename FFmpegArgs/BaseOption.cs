using System;
using System.Collections.Generic;

namespace FFmpegArgs
{
  public abstract class BaseOption
  {
    internal readonly Dictionary<string, string> _options = new Dictionary<string, string>();
  }

  public static class BaseOptionExtension
  {
    public static T SetOption<T>(this T baseOption, string key, string val) where T : BaseOption
    {
      if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
      if (string.IsNullOrEmpty(val)) throw new ArgumentNullException(nameof(val));
      baseOption._options[key] = val;
      return baseOption;
    }

    public static T SetOption<T>(this T baseOption, string key, object val) where T : BaseOption
    {
      if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
      if (val == null) throw new ArgumentNullException(nameof(val));
      baseOption._options[key] = val.ToString();
      return baseOption;
    }
  }
}
