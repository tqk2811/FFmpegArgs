namespace FFmpegArgs.Filters.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
    public class FloatRangeAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public FloatRangeAttribute(float min, float max)
        {
            this.Min = min;
            this.Max = max;
        }
        /// <summary>
        /// 
        /// </summary>
        public float Min { get; }
        /// <summary>
        /// 
        /// </summary>
        public float Max { get; }
    }
}
