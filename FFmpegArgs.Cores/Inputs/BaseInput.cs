namespace FFmpegArgs.Cores.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseInput : BaseInputOutput, IInput
    {
        /// <summary>
        /// 
        /// </summary>
        protected const int StdIn = 0;

        /// <summary>
        /// 
        /// </summary>
        public abstract IEnumerable<InputAVStream> InputAVStreams { get; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetAVStreamArg()
        {
            return string.Join(" ", InputAVStreams);
        }
    }
}
