/*
concat AVOptions:
  n                 <int>        ..FVA...... specify the number of segments (from 1 to INT_MAX) (default 2)
  v                 <int>        ..FV....... specify the number of video streams (from 0 to INT_MAX) (default 1)
  a                 <int>        ..F.A...... specify the number of audio streams (from 0 to INT_MAX) (default 0)
  unsafe            <boolean>    ..FVA...... enable unsafe mode (default false)
*/
namespace FFmpegArgs.Filters.MultimediaFilters
{
    /// <summary>
    /// ..C concat            N->N       Concatenate audio and video streams.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#concat
    /// </summary>
    public class ConcatFilter : VideoToVideoFilter, ICommandSupport
    {
        readonly List<ImageMap> _imageMapsOut = new List<ImageMap>();
        readonly List<AudioMap> _audioMapsOut = new List<AudioMap>();
        
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ImageMap> ImageMapsOut { get { return _imageMapsOut; } }
        
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<AudioMap> AudioMapsOut { get { return _audioMapsOut; } }
        
        /// <summary>
        /// Concatenate audio and video streams, joining them together one after the other.<br>
        /// </br>The filter works on segments of synchronized video and audio streams.All segments must have the same number of streams of each type, and that will also be the number of streams at output.
        /// </summary>
        /// <param name="concatGroups">input: n * (v + a) => output: (v + a)</param>
        public ConcatFilter(IEnumerable<ConcatGroup> concatGroups) : this(concatGroups.ToArray())
        {
        }
        /// <summary>
        /// Concatenate audio and video streams, joining them together one after the other.<br>
        /// </br>The filter works on segments of synchronized video and audio streams.All segments must have the same number of streams of each type, and that will also be the number of streams at output.
        /// </summary>
        /// <param name="concatGroups">input: n * (v + a) => output: (v + a)</param>
        public ConcatFilter(params ConcatGroup[] concatGroups)
          : base("concat", concatGroups.SelectMany(x => x.AllMaps).ToArray())
        {
            if (concatGroups == null || concatGroups.Length < 1) throw new ArgumentNullException(nameof(concatGroups));
            //check input are same;
            var video_counts = concatGroups.GroupBy(x => x.ImageMaps.Count);
            if (video_counts.Count() != 1) throw new ArgumentException("Number of image per group are not same");
            var audio_counts = concatGroups.GroupBy(x => x.AudioMaps.Count);
            if (audio_counts.Count() != 1) throw new ArgumentException("Number of audio per group are not same");

            
            int index = 0;
            foreach (var img in concatGroups.First().ImageMaps)
            {
                ImageMap imageMap = new ImageMap(img.FilterGraph, $"f_{FilterIndex}_v{index++}");
                _mapsOut.Add(imageMap);
                _imageMapsOut.Add(imageMap);
            }
            
            index = 0;
            foreach (var img in concatGroups.First().AudioMaps)
            {
                AudioMap audioMap = new AudioMap(img.FilterGraph, $"f_{FilterIndex}_a{index++}");
                _mapsOut.Add(audioMap);
                _audioMapsOut.Add(audioMap);
            }
            
            
            this.SetOption("n", concatGroups.Length);
            this.SetOption("v", concatGroups.First().ImageMaps.Count);
            this.SetOption("a", concatGroups.First().AudioMaps.Count);
        }

        /// <summary>
        /// Activate unsafe mode: do not fail if segments have a different format. (default false)
        /// </summary>
        /// <param name="unsafeMode"></param>
        /// <returns></returns>
        public ConcatFilter Unsafe(bool unsafeMode)
            => this.SetOption("unsafe", unsafeMode.ToFFmpegFlag());
    }
    
    /// <summary>
    /// 
    /// </summary>
    public static class ConcatFilterExtension
    {
        /// <summary>
        /// Concatenate audio and video streams, joining them together one after the other.<br>
        /// </br>The filter works on segments of synchronized video and audio streams.All segments must have the same number of streams of each type, and that will also be the number of streams at output.
        /// </summary>
        /// <param name="concatGroups">input: n * (v + a) => output: (v + a)</param>
        public static ConcatFilter ConcatFilter(this IEnumerable<ConcatGroup> concatGroups)
            => new ConcatFilter(concatGroups);
    }
    
    /// <summary>
    /// 
    /// </summary>
    public class ConcatGroup
    {
        /// <summary>
        /// 
        /// </summary>
        public ConcatGroup() { }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageMaps"></param>
        /// <param name="audioMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ConcatGroup(IEnumerable<ImageMap> imageMaps, IEnumerable<AudioMap> audioMaps)
        {
            ImageMaps.AddRange(imageMaps ?? throw new ArgumentNullException(nameof(imageMaps)));
            AudioMaps.AddRange(audioMaps ?? throw new ArgumentNullException(nameof(audioMaps)));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="audioMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ConcatGroup(ImageMap imageMap, AudioMap audioMap)
        {
            ImageMaps.Add(imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
            AudioMaps.Add(audioMap ?? throw new ArgumentNullException(nameof(audioMap)));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ConcatGroup(params ImageMap[] imageMaps)
        {
            ImageMaps.AddRange(imageMaps ?? throw new ArgumentNullException(nameof(imageMaps)));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="audioMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ConcatGroup(params AudioMap[] audioMaps)
        {
            AudioMaps.AddRange(audioMaps ?? throw new ArgumentNullException(nameof(audioMaps)));
        }
        /// <summary>
        /// 
        /// </summary>
        public List<ImageMap> ImageMaps { get; } = new List<ImageMap>();
        /// <summary>
        /// 
        /// </summary>
        public List<AudioMap> AudioMaps { get; } = new List<AudioMap>();
        internal IEnumerable<BaseMap> AllMaps { get { return ImageMaps.Cast<BaseMap>().Concat(AudioMaps); } }
    }
}
