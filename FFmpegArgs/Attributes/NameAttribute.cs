using System;
namespace FFmpegArgs.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
    public class NameAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public NameAttribute(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; }
    }
}
