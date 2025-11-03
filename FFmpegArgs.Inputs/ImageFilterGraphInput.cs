namespace FFmpegArgs.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageFilterGraphInput : ImageInput
    {
        /// <summary>
        /// 
        /// </summary>
        public IImageFilterGraph FilterGraph { get; } = new FilterGraph();
        /// <summary>
        /// 
        /// </summary>
        public ImageFilterGraphInput() : base(1)
        {
            this.Format(DemuxingFileFormat.lavfi);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        public ImageFilterGraphInput(Action<IImageFilterGraph> filterGraph) : this()
        {
            AddFilter(filterGraph);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ImageFilterGraphInput AddFilter(Action<IImageFilterGraph> filterGraph)
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
            string filter = FilterGraph.GetFiltersInputArgs();
            if (string.IsNullOrWhiteSpace(filter)) throw new NullReferenceException($"{nameof(ImageFilterGraphInput)}.{nameof(FilterGraph)} is empty");

            List<string> args = new List<string>()
            {
                GetFlagArgs(),
                GetOptionArgs(),
                GetAVStreamArg(),
                filter.ContainsOrd(" ") ? $"-i \"{filter}\"" : $"-i {filter}"
            };

            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
