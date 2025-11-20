namespace FFmpegArgs.Cores.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseOutput : BaseInputOutput, IOutput
    {
        /// <summary>
        /// 
        /// </summary>
        protected const int StdOut = 1;

        /// <summary>
        /// 
        /// </summary>
        public IFilterGraph FilterGraph { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract IEnumerable<OutputAVStream> Streams { get; }

        public override IEnumerable<string> GetAVStreamArgs()
        {
            return Streams.SelectMany(x => x.GetAllArgs());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        internal BaseOutput(params BaseMap[] baseMaps)
        {
            if (baseMaps.Any(x => x == null)) throw new ArgumentNullException(nameof(baseMaps));
            if (baseMaps.Any(x => !x.IsInput && x.IsMapped)) throw new InvalidOperationException($"Some map to Output was Mapped, map only one-to-one except map from input");
            var filterGraphs = baseMaps.Select(x => x.FilterGraph).Distinct().ToList();
            if (filterGraphs.Count != 1) throw new InvalidOperationException($"Map to Output are not same FilterGraph");
            this.FilterGraph = filterGraphs.First();
        }
    }
}
