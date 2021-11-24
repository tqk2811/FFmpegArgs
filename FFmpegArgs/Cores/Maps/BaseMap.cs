namespace FFmpegArgs.Cores.Maps
{

    public abstract class BaseMap
    {
        public FilterGraph FilterGraph { get; }

        /// <summary>
        /// if video input (sound and video), it auto select by filter
        /// </summary>
        public string MapName { get; }

        public bool IsInput { get; internal set; } = false;

        public int InputIndex { get; internal set; } = 0;

        /// <summary>
        /// For non input, if IsMapped and map again -> throw exception
        /// </summary>
        public bool IsMapped { get; internal set; } = false;

        internal BaseMap(FilterGraph filterGraph, string name)
        {
            this.FilterGraph = filterGraph;
            this.MapName = name;
        }

        public abstract string GetMapOut();
    }
}
