namespace FFmpegArgs.Cores.Maps
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoMap
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<AudioMap> AudioMaps => _audioMaps;

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ImageMap> ImageMaps => _imageMaps;

        readonly List<AudioMap> _audioMaps = new List<AudioMap>();
        readonly List<ImageMap> _imageMaps = new List<ImageMap>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageMaps"></param>
        /// <param name="audioMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public VideoMap(IEnumerable<ImageMap> imageMaps, IEnumerable<AudioMap> audioMaps)
        {
            if (imageMaps == null || imageMaps.Any(x => x == null)) throw new ArgumentNullException(nameof(imageMaps));
            if (audioMaps == null || audioMaps.Any(x => x == null)) throw new ArgumentNullException(nameof(audioMaps));
            if (imageMaps.Select(x => x.FilterGraph).Concat(audioMaps.Select(x => x.FilterGraph)).Distinct().Count() != 1)
            {
                throw new InvalidOperationException("Map input are not same FilterGraph");
            }

            _imageMaps.AddRange(imageMaps);
            _audioMaps.AddRange(audioMaps);
        }
    }
}
