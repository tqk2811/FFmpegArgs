namespace FFmpegArgs.Cores.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseOutput : BaseInputOutput
    {
        /// <summary>
        /// 
        /// </summary>
        public IFilterGraph FilterGraph { get; }


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
            foreach (var map in baseMaps) map.OutputMapped = this;
        }
    }
}
