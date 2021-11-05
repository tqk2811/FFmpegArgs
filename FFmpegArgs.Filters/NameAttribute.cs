using System;

namespace FFmpegArgs.Filters
{
  [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
  public class NameAttribute : Attribute
  {
    public NameAttribute(string name)
    {
      this.Name = name;
    }
    public string Name { get; }
  }
}
