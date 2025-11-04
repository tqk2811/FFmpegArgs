namespace FFplayArgs
{
    /// <summary>
    /// 
    /// </summary>
    public class FFplayArg : BaseArgsOptionFlag, IFFplayArg
    {
        readonly List<BaseInput> _inputs = new List<BaseInput>();

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<BaseInput> Inputs { get { return _inputs; } }

        /// <summary>
        /// 
        /// </summary>
        public FilterGraph FilterGraph { get; } = new FilterGraph();





        /// <summary>
        /// Audio with multi channel
        /// </summary>
        /// <param name="audio"></param>
        /// <returns></returns>
        public IEnumerable<AudioMap> AddAudiosInput(AudioInput audio)
        {
            if (audio == null) throw new ArgumentNullException(nameof(audio));
            if (_inputs.Contains(audio)) throw new InvalidOperationException("Sound was add to input before");
            //if (count <= 0) throw new InvalidRangeException($"{nameof(count)} <= 0");
            _inputs.Add(audio);

            List<AudioMap> results = new List<AudioMap>();
            foreach (var streamInput in audio.AudioInputAVStreams)
            {
                results.Add(new AudioMap(this, FilterGraph, streamInput));
            }
            return results;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="InvalidRangeException"></exception>
        public IEnumerable<ImageMap> AddImagesInput(ImageInput image)
        {
            if (image == null) throw new ArgumentNullException(nameof(image));
            if (_inputs.Contains(image)) throw new InvalidOperationException("Image was add to input before");
            //if (count <= 0) throw new InvalidRangeException($"{nameof(count)} <= 0");
            _inputs.Add(image);
            List<ImageMap> results = new List<ImageMap>();
            foreach (var streamInput in image.ImageInputAVStreams)
            {
                results.Add(new ImageMap(this, FilterGraph, streamInput));
            }
            return results;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="video"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public VideoMap AddVideoInput(VideoInput video)
        {
            if (video == null) throw new ArgumentNullException(nameof(video));
            if (_inputs.Contains(video)) throw new InvalidOperationException("Video was add to input before");
            _inputs.Add(video);
            int inputIndex = _inputs.IndexOf(video);
            List<ImageMap> imageMaps = new List<ImageMap>();
            List<AudioMap> audioMaps = new List<AudioMap>();
            foreach (var streamInput in video.ImageInputAVStreams)
            {
                imageMaps.Add(new ImageMap(this, FilterGraph, streamInput));
            }
            foreach (var streamInput in video.AudioInputAVStreams)
            {
                audioMaps.Add(new AudioMap(this, FilterGraph, streamInput));
            }
            return new VideoMap(imageMaps, audioMaps);
        }





        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetGlobalArgs()
        {
            return GetFlagArgs().Concat(GetOptionArgs());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetInputsArgs()
        {
            return _inputs.SelectMany(x => x.GetAllArgs());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="useChain"></param>
        /// <returns></returns>
        public IEnumerable<string> GetFullCommandline(bool useChain = true)
        {
            string filter = FilterGraph.GetFiltersArgs(false, useChain);
            string[] filter_complex;
            if (!string.IsNullOrWhiteSpace(filter))
            {
                filter_complex = new string[]
                {
                    "-filter_complex",
                    filter
                };
            }
            else filter_complex = new string[0];

            List<string> args =
            [
                .. GetGlobalArgs(),
                .. GetInputsArgs(),
                .. filter_complex
            ];
            return args;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="script_name_or_path"></param>
        /// <returns></returns>
        public IEnumerable<string> GetFullCommandlineWithFilterScript(string script_name_or_path)
        {
            List<string> args =
            [
                .. GetGlobalArgs(),
                .. GetInputsArgs(),
                "filter_complex_script",
                script_name_or_path,
            ];
            return args;
        }

        public override IEnumerable<string> GetAllArgs() => GetFullCommandline(true);
    }
}
