namespace FFmpegArgs.Cores.Attributes
{
    /*
     D..... = Decoding supported
     .E.... = Encoding supported
     ..V... = Video codec
     ..A... = Audio codec
     ..S... = Subtitle codec
     ..D... = Data codec
     ..T... = Attachment codec
     ...I.. = Intra frame-only codec
     ....L. = Lossy compression
     .....S = Lossless compression
    */
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
    public class CodecFlagAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="flag"></param>
        public CodecFlagAttribute(string flag)
        {
            this.Flag = flag;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Flag { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="flags"></param>
        /// <returns></returns>
        public bool CheckFlag(params char[] flags)
        {
            foreach (char c in flags)
            {
                if(!Flag.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
