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
        public abstract IEnumerable<InputAVStream> Streams { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetAVStreamArgs()
        {
            return Streams.SelectMany(x => x.GetAllArgs());
        }
    }
}
