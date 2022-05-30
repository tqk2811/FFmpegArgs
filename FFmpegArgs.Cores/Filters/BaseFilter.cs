namespace FFmpegArgs.Cores.Filters
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TIn"></typeparam>
    /// <typeparam name="TOut"></typeparam>
    public abstract class BaseFilter<TIn, TOut> : BaseOption, IFilter<TIn, TOut>
      where TIn : BaseMap
      where TOut : BaseMap
    {
        private List<BaseMap> _mapsIn { get; } = new List<BaseMap>();

        /// <summary>
        /// 
        /// </summary>
        protected List<BaseMap> _mapsOut { get; } = new List<BaseMap>();

        /// <summary>
        /// 
        /// </summary>
        public int FilterIndex { get; }
        /// <summary>
        /// 
        /// </summary>
        public string FilterName { get; }
        /// <summary>
        /// 
        /// </summary>
        public IFilterGraph FilterGraph { get; }
                
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<TOut> MapsOut => _mapsOut.Cast<TOut>();
        
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<TIn> MapsIn => _mapsIn.Cast<TIn>();
        
        /// <summary>
        /// 
        /// </summary>
        public TOut MapOut => _mapsOut.Cast<TOut>().FirstOrDefault();


        IEnumerable<BaseMap> IFilter.MapsOut => _mapsOut;

        IEnumerable<BaseMap> IFilter.MapsIn => _mapsIn;

        BaseMap IFilter.MapOut => MapOut;


        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="mapsIn"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        protected BaseFilter(string filterName, params TIn[] mapsIn)
        {
            if (string.IsNullOrWhiteSpace(filterName)) throw new ArgumentNullException(nameof(filterName));

            var filterGraphs = mapsIn.Select(x => x.FilterGraph).Distinct().ToList();
            if (filterGraphs.Count != 1) throw new InvalidOperationException($"{nameof(mapsIn)} are empty or not same {nameof(FilterGraph)}");

            if (mapsIn.Any(x => !x.IsInput && x.IsMapped))
                throw new InvalidOperationException("Map is only \"one to one\", except input");

            this.FilterGraph = filterGraphs.First();
            this.FilterName = filterName;
            _mapsIn.AddRange(mapsIn);

            FilterIndex = this.FilterGraph.AddFilter(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public override string ToString()
        {
            if (string.IsNullOrEmpty(FilterName)) throw new NullReferenceException(nameof(FilterName));
            if (_mapsOut.Count == 0) throw new NullReferenceException($"{FilterName} is empty output");
            string inputs = string.Join("", _mapsIn.Where(x => !string.IsNullOrWhiteSpace(x.MapName)).Select(x => $"[{x.MapName}]"));
            string outputs = string.Join("", _mapsOut.Select(x => $"[{x.MapName}]"));
            string options = GetFilterOptions();
            if (!string.IsNullOrEmpty(options)) options = "=" + options;
            return $"{inputs}{FilterName}{options}{outputs}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetFilterOptions()
        {
            return string.Join(":", Options.Select(x => $"{x.Key}={x.Value.FiltergraphEscapingLv1()}")).FiltergraphEscapingLv2();
        }
    }
}
