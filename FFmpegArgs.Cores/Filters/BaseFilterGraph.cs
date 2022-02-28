using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Cores.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseFilterGraph 
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<IFilter<BaseMap, BaseMap>> Filters { get { return _filters; } }

        readonly List<IFilter<BaseMap, BaseMap>> _filters = new List<IFilter<BaseMap, BaseMap>>();




        internal int AddFilter(IFilter<BaseMap, BaseMap> filter)
        {
            if (_filters.IndexOf(filter) >= 0)
                throw new InvalidOperationException("this filter was added");

            if (!filter.FilterGraph.Equals(this)) 
                throw new InvalidOperationException("this filter.FilterGraph not same with this FilterGraph");

            _filters.Add(filter);
            return _filters.IndexOf(filter);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="withNewLine"></param>
        /// <param name="useChain"></param>
        /// <returns></returns>
        public abstract string GetFiltersArgs(bool withNewLine = false, bool useChain = true);


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract string GetFiltersInputArgs();
    }
}
