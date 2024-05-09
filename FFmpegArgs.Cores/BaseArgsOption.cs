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
        public virtual string GetOptionArgs()
        {
            return string.Join(" ", Options.Select(x => $"{x.Key} {x.Value}"));
        }
    }
}
