namespace FFmpegArgs.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public class FilterGraphInput : VideoInput
    {
        /// <summary>
        /// 
        /// </summary>
        public BaseFilterGraph FilterGraph { get; } = new FilterGraph();
        /// <summary>
        /// 
        /// </summary>
        public FilterGraphInput()
        {
            this.Format(DemuxingFileFormat.lavfi);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public FilterGraphInput AddFilter(Action<BaseFilterGraph> filterGraph)
        {
            if (filterGraph == null)
                throw new ArgumentNullException(nameof(filterGraph));
            filterGraph.Invoke(FilterGraph);
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public override string ToString()
        {
            string filter = FilterGraph.GetFiltersInputArgs();
            if (string.IsNullOrWhiteSpace(filter)) throw new NullReferenceException($"{nameof(FilterGraphInput)}.{nameof(FilterGraph)} is empty");
            List<string> args = new List<string>()
            {
                GetArgs(),
                filter.Contains(" ") ? $"-i \"{filter}\"" : $"-i {filter}"
            };
            return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
        }
    }
}
