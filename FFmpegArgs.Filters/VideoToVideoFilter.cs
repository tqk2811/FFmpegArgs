using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters
{
    public abstract class VideoToVideoFilter : BaseFilter<BaseMap, BaseMap>
    {
        internal VideoToVideoFilter(string filterName, params BaseMap[] baseMaps) : base(filterName, baseMaps)
        {

        }
    }
}
