namespace FFmpegArgs.Cores.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseFilter : BaseOption, IFilter
    {
        private List<BaseMap> _mapsIn { get; } = new List<BaseMap>();
        /// <summary>
        /// 
        /// </summary>
        protected List<BaseMap> _mapsOut { get; } = new List<BaseMap>();



        /// <summary>
        /// 
        /// </summary>
        public IFilterGraph FilterGraph { get; }
        /// <summary>
        /// 
        /// </summary>
        public int FilterIndex { get; }
        /// <summary>
        /// 
        /// </summary>
        public string FilterName { get; }

        IEnumerable<BaseMap> IFilter.MapsOut => _mapsOut;
        IEnumerable<BaseMap> IFilter.MapsIn => _mapsIn;
        BaseMap IFilter.MapOut => _mapsOut.First();//if throw then it InvalidOperationException


        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="mapsIn"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        protected BaseFilter(string filterName, params BaseMap[] mapsIn)
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


        public override string ToString() => GetFilterValue();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public string GetFilterValue()
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

        /// <summary>
        /// 
        /// </summary>
        protected abstract void AddMapOut();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        protected abstract void AddMapOut(int index);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        protected virtual void AddMultiMapOut(int count)
        {
            for (int i = 0; i < count; i++) AddMapOut(i);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TIn"></typeparam>
    /// <typeparam name="TOut"></typeparam>
    public abstract class BaseFilter<TIn, TOut> : BaseFilter, IFilter<TIn, TOut>
      where TIn : BaseMap
      where TOut : BaseMap
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<TOut> MapsOut => ((IFilter)this).MapsOut.Cast<TOut>();
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<TIn> MapsIn => ((IFilter)this).MapsIn.Cast<TIn>();
        /// <summary>
        /// 
        /// </summary>
        public TOut MapOut => (TOut)this._mapsOut.First();//if throw then it InvalidOperationException


        /// <inheritdoc cref="BaseFilter.BaseFilter(string, BaseMap[])"/>
        protected BaseFilter(string filterName, params TIn[] mapsIn) : base(filterName, mapsIn)
        {

        }
    }
}
