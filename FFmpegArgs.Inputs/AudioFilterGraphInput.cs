namespace FFmpegArgs.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioFilterGraphInput : AudioInput
    {
        /// <summary>
        /// 
        /// </summary>
        public IAudioFilterGraph FilterGraph { get; } = new FilterGraph();
        
        /// <summary>
        /// 
        /// </summary>
        public AudioFilterGraphInput() : base(1)
        {
            this.Format(DemuxingFileFormat.lavfi);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        public AudioFilterGraphInput(Action<IAudioFilterGraph> filterGraph) : this()
        {
            AddFilter(filterGraph);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AudioFilterGraphInput AddFilter(Action<IAudioFilterGraph> filterGraph)
        {
            if (filterGraph == null)
                throw new ArgumentNullException(nameof(filterGraph));
            filterGraph.Invoke(FilterGraph);
            return this;
        }

        public override IEnumerable<string> GetAllArgs()
        {
            string filter = FilterGraph.GetFiltersInputArgs();
            if (string.IsNullOrWhiteSpace(filter)) throw new NullReferenceException($"{nameof(ImageFilterGraphInput)}.{nameof(FilterGraph)} is empty");

            List<string> args =
            [
                .. GetFlagArgs(),
                .. GetOptionArgs(),
                .. GetAVStreamArgs(),
                "-i",
                filter
            ];
            return args;
        }
    }
}
