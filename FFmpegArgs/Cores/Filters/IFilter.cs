using FFmpegArgs.Cores.Maps;
using System.Collections.Generic;

namespace FFmpegArgs.Cores.Filters
{
    public interface IFilter<out TIn, out TOut>
        where TIn : IMap
        where TOut : IMap
    {
        bool IsInput { get; }
        FilterGraph FilterGraph { get; }

        IEnumerable<TOut> MapsOut { get; }
        IEnumerable<TIn> MapsIn { get; }
        TOut MapOut { get; }
    }
}
