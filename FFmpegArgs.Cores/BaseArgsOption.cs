namespace FFmpegArgs.Cores
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseArgsOption : BaseOption
    {
        /// <summary>
        /// 
        /// </summary>
        public BaseArgsOption()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseArgsOption"></param>
        public BaseArgsOption(BaseArgsOption baseArgsOption) : base(baseArgsOption)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> GetOptionArgs()
        {
            foreach (var item in Options)
            {
                yield return item.Key;
                yield return item.Value;
            }
        }
    }
}
