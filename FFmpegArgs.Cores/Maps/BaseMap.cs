namespace FFmpegArgs.Cores.Maps
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseMap
    {
        /// <summary>
        /// Name
        /// </summary>
        protected readonly string _name;

        /// <summary>
        /// Unique name of map
        /// </summary>
        public abstract string MapName { get; }

        /// <summary>
        /// This map is output from input or filter output
        /// </summary>
        public bool IsInput { get; } = false;

        /// <summary>
        /// Stream Index Of Input
        /// </summary>
        public int StreamIndexOfInput { get; }

        /// <summary>
        /// 
        /// </summary>
        public IFilterGraph FilterGraph { get; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsMapped
        {
            get
            {
                return OutputMapped != null || FilterGraph.Filters.SelectMany(x => x.MapsIn).Any(y => this.Equals(y));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <param name="name"></param>
        /// <param name="streamIndexOfInput"></param>
        /// <exception cref="ArgumentNullException"></exception>
        protected BaseMap(IFilterGraph filterGraph, string name, int? streamIndexOfInput = null)
        {
            this.FilterGraph = filterGraph ?? throw new ArgumentNullException(nameof(filterGraph));
            this.IsInput = streamIndexOfInput != null;
            if (this.IsInput)
            {
                this.StreamIndexOfInput = streamIndexOfInput.Value;
                //name can be empty by source sink filter (non input)
                if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            }
            this._name = name;
        }

        /// <summary>
        /// MapName
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MapName;
        }

        internal BaseOutput OutputMapped { get; set; }
    }
}
