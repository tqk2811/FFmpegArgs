using FFmpegArgs.Cores.Maps;
using System.Collections.Generic;
namespace FFmpegArgs.Cores.Filters
{
    public interface IFilter<out TIn, out TOut>
        where TIn : IMap
        where TOut : IMap
    {
        FilterGraph FilterGraph { get; }
        int FilterIndex { get; }
        string FilterName { get; }
        IEnumerable<TOut> MapsOut { get; }
        IEnumerable<TIn> MapsIn { get; }
        TOut MapOut { get; }
        IEnumerable<KeyValuePair<string, string>> Options { get; }
    }
}
