using System;

namespace FFmpegArgs.Filters
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
    public class FloatRangeAttribute : Attribute
    {
        public FloatRangeAttribute(float min, float max)
        {
            this.Min = min;
            this.Max = max;
        }
        public float Min { get; }
        public float Max { get; }
    }
}
