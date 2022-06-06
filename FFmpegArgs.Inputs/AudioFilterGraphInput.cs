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
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AudioFilterGraphInput AddFilter(Action<IAudioFilterGraph> filterGraph)
        {
            if (filterGraph == null)
                throw new ArgumentNullException(nameof(filterGraph));
            filterGraph.Invoke(FilterGraph);
            return this;
        }

        /// <summary>
        /// Audio Stream Input
        /// </summary>
        public AudioInputAVStream AudioInputAVStream { get { return base.AudioInputAVStreams.FirstOrDefault(); } }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public override string ToString()
        {
            string filter = FilterGraph.GetFiltersInputArgs();
            if (string.IsNullOrWhiteSpace(filter)) throw new NullReferenceException($"{nameof(ImageFilterGraphInput)}.{nameof(FilterGraph)} is empty");

            var map_args = base.InputAVStreams.Select(x => x.ToString());
            List<string> args = new List<string>()
            {
                GetFlagArgs(),
                GetOptionArgs(),
            };
            args.AddRange(map_args);
            args.Add(filter.Contains(" ") ? $"-i \"{filter}\"" : $"-i {filter}");

            return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
        }
    }
}
