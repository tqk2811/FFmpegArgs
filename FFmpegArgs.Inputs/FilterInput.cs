namespace FFmpegArgs.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public class FilterInput : VideoInput
    {
        readonly string _filter_string;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public FilterInput(string filter)
        {
            if (string.IsNullOrEmpty(filter)) throw new ArgumentNullException(nameof(filter));
            this._filter_string = filter;
        }
        /// <summary>
        /// 
        /// </summary>
        public BaseFilterGraph FilterGraph { get; } = new FilterGraph();
        /// <summary>
        /// 
        /// </summary>
        public FilterInput()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public FilterInput AddFilter(Action<BaseFilterGraph> filterGraph)
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
            string filter = this._filter_string;
            if (string.IsNullOrWhiteSpace(filter)) filter = FilterGraph.GetFiltersInputArgs();
            if (string.IsNullOrWhiteSpace(filter)) throw new NullReferenceException($"{nameof(FilterInput)} is empty");
            List<string> args = new List<string>()
            {
                GetArgs(),
                filter.Contains(" ") ? $"-f lavfi -i \"{filter}\"" : $"-f lavfi -i {filter}"
            };
            return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
        }
    }
}
