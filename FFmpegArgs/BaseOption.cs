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

    public static T SetOptionRange<T>(this T baseOption, string key, int val, int min, int max) where T : BaseOption
    {
      if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
      if (val < min || val > max) throw new ArgumentOutOfRangeException($"Range Required: {min} <= {key} <= {max}");
      baseOption._options[key] = val.ToString();
      return baseOption;
    }
    public static T SetOptionRange<T>(this T baseOption, string key, float val, float min, float max) where T : BaseOption
    {
      if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
      if (float.IsNaN(val) || val < min || val > max) throw new ArgumentOutOfRangeException($"Range Required: {min} <= {key} <= {max}");
      baseOption._options[key] = val.ToString();
      return baseOption;
    }
    public static T SetOptionRange<T>(this T baseOption, string key, double val, double min, double max) where T : BaseOption
    {
      if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
      if (double.IsNaN(val) || val < min || val > max) throw new ArgumentOutOfRangeException($"Range Required: {min} <= {key} <= {max}");
      baseOption._options[key] = val.ToString();
      return baseOption;
    }
    public static T SetOptionRange<T>(this T baseOption, string key, long val, long min, long max) where T : BaseOption
    {
      if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
      if (val < min || val > max) throw new ArgumentOutOfRangeException($"Range Required: {min} <= {key} <= {max}");
      baseOption._options[key] = val.ToString();
      return baseOption;
    }
    public static T SetOptionRange<T>(this T baseOption, string key, decimal val, decimal min, decimal max) where T : BaseOption
    {
      if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
      if (val < min || val > max) throw new ArgumentOutOfRangeException($"Range Required: {min} <= {key} <= {max}");
      baseOption._options[key] = val.ToString();
      return baseOption;
    }
    public static T SetOptionRange<T>(this T baseOption, string key, TimeSpan val, TimeSpan min, TimeSpan max) where T : BaseOption
    {
      if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
      if (val < min || val > max) throw new ArgumentOutOfRangeException($"Range Required: {min:hh\\:mm\\:ss\\.fff} <= {key:hh\\:mm\\:ss\\.fff} <= {max:hh\\:mm\\:ss\\.fff}");
      baseOption._options[key] = val.TotalSeconds.ToString();
      return baseOption;
    }
  }
}
