namespace FFmpegArgs.Cores.Maps
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseMap : IMap
    {
        /// <summary>
        /// Name
        /// </summary>
        protected readonly string? _name;

        /// <summary>
        /// Unique name of map
        /// </summary>
        public abstract string MapName { get; }

        /// <summary>
        /// This map is output from input or filter output
        /// </summary>
#if NET5_0_OR_GREATER
        [MemberNotNullWhen(true, nameof(BaseFFArg),nameof(InputAVStream))]
#endif
        public bool IsInput { get { return InputAVStream != null; } }

        /// <summary>
        /// 
        /// </summary>
        public int IndexOfInput
        {
            get
            {
                if (!IsInput) return -1;
                return BaseFFArg!.Inputs.ToList().IndexOf(InputAVStream!.BaseInput);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public IFilterGraph FilterGraph { get; }

        /// <summary>
        /// 
        /// </summary>
        public IBaseFFArg? BaseFFArg { get; }

        /// <summary>
        /// 
        /// </summary>
        public InputAVStream? InputAVStream { get; }

        /// <summary>
        /// 
        /// </summary>
        public OutputAVStream? OutputAVStream { get; internal set; }


        /// <summary>
        /// 
        /// </summary>
        public bool IsMapped
        {
            get
            {
                return OutputAVStream != null || FilterGraph.Filters.SelectMany(x => x.MapsIn).Any(y => this.Equals(y));
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"></exception>
        protected BaseMap(IFilterGraph filterGraph, string name)
        {
            this.FilterGraph = filterGraph ?? throw new ArgumentNullException(nameof(filterGraph));
            this._name = name;//no check, can be empty by filter input/filter source
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        protected BaseMap(IBaseFFArg baseFFArg, IFilterGraph filterGraph, InputAVStream inputAVStream)
        {
            this.FilterGraph = filterGraph ?? throw new ArgumentNullException(nameof(filterGraph));
            this.BaseFFArg = baseFFArg ?? throw new ArgumentNullException(nameof(baseFFArg));
            this.InputAVStream = inputAVStream ?? throw new ArgumentNullException(nameof(inputAVStream));
        }

        /// <summary>
        /// MapName
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MapName;
        }
    }
}
