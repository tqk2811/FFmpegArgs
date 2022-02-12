namespace FFmpegArgs
{
    /// <summary>
    /// 
    /// </summary>
    public class FFmpegArg : BaseOptionFlag, IFFmpegArg
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<BaseInput> Inputs { get { return _inputs; } }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<BaseOutput> Outputs { get { return _outputs; } }



        readonly List<BaseInput> _inputs = new List<BaseInput>();
        readonly List<BaseOutput> _outputs = new List<BaseOutput>();

        /// <summary>
        /// 
        /// </summary>
        public IFilterGraph FilterGraph { get; } = new FilterGraph();

        /// <summary>
        /// 
        /// </summary>
        public FFmpegArg()
        {
        }
        /// <summary>
        /// Audio with multi channel
        /// </summary>
        /// <param name="sound"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public IEnumerable<AudioMap> AddAudiosInput(AudioInput sound, int count)
        {
            if (sound == null) throw new ArgumentNullException(nameof(sound));
            if (_inputs.Contains(sound)) throw new InvalidOperationException("Sound was add to input before");
            if (count <= 0) throw new InvalidRangeException($"{nameof(count)} <= 0");
            _inputs.Add(sound);
            List<AudioMap> results = new List<AudioMap>();
            for (int i = 0; i < count; i++)
            {
                results.Add(new AudioMap(FilterGraph, $"{_inputs.IndexOf(sound)}", i));
            }
            return results;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sound"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public AudioMap AddAudioInput(AudioInput sound)
        {
            if (sound == null) throw new ArgumentNullException(nameof(sound));
            if (_inputs.Contains(sound)) throw new InvalidOperationException("Sound was add to input before");
            _inputs.Add(sound);
            return new AudioMap(FilterGraph, $"{_inputs.IndexOf(sound)}", 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="InvalidRangeException"></exception>
        public IEnumerable<ImageMap> AddImagesInput(ImageInput image, int count)
        {
            if (image == null) throw new ArgumentNullException(nameof(image));
            if (_inputs.Contains(image)) throw new InvalidOperationException("Image was add to input before");
            if (count <= 0) throw new InvalidRangeException($"{nameof(count)} <= 0");
            _inputs.Add(image);
            List<ImageMap> results = new List<ImageMap>();
            for (int i = 0; i < count; i++)
            {
                results.Add(new ImageMap(FilterGraph, $"{_inputs.IndexOf(image)}", i));
            }
            return results;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public ImageMap AddImageInput(ImageInput image)
        {
            if (image == null) throw new ArgumentNullException(nameof(image));
            if (_inputs.Contains(image)) throw new InvalidOperationException("Image was add to input before");
            _inputs.Add(image);
            return new ImageMap(FilterGraph, $"{_inputs.IndexOf(image)}", 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="video"></param>
        /// <param name="imageCount"></param>
        /// <param name="audioCount"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public VideoMap AddVideoInput(VideoInput video, int imageCount = 1, int audioCount = 1)
        {
            if (video == null) throw new ArgumentNullException(nameof(video));
            if (_inputs.Contains(video)) throw new InvalidOperationException("Video was add to input before");
            _inputs.Add(video);
            int inputIndex = _inputs.IndexOf(video);
            List<ImageMap> imageMaps = new List<ImageMap>();
            List<AudioMap> audioMaps = new List<AudioMap>();
            for (int i = 0; i < imageCount; i++)
                imageMaps.Add(new ImageMap(FilterGraph, $"{inputIndex}", i));
            for (int i = 0; i < audioCount; i++)
                audioMaps.Add(new AudioMap(FilterGraph, $"{inputIndex}", i));
            return new VideoMap(imageMaps, audioMaps);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="output"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public void AddOutput(BaseOutput output)
        {
            if (output == null) throw new ArgumentNullException(nameof(output));
            if (_outputs.Contains(output)) throw new InvalidOperationException("This output was add before");
            if (output.FilterGraph != this.FilterGraph) throw new InvalidOperationException("This output are not same FilterGraph");
            _outputs.Add(output);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetGlobalArgs()
        {
            return GetArgs();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetInputsArgs()
        {
            return string.Join(" ", _inputs);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetOutputsArgs()
        {
            return string.Join(" ", _outputs);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="useChain"></param>
        /// <returns></returns>
        public string GetFullCommandline(bool useChain = true)
        {
            string filter = FilterGraph.GetFiltersArgs(false, useChain);
            string filter_complex = string.IsNullOrEmpty(filter) ? filter : $"-filter_complex \"{filter}\"";
            List<string> args = new List<string>()
            {
                GetGlobalArgs(),
                GetInputsArgs(),
                filter_complex,
                GetOutputsArgs()
            };
            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="script_name_or_path"></param>
        /// <returns></returns>
        public string GetFullCommandlineWithFilterScript(string script_name_or_path)
        {
            List<string> args = new List<string>()
            {
                GetGlobalArgs(),
                GetInputsArgs(),
                $"-filter_complex_script \"{script_name_or_path}\"",
                GetOutputsArgs()
            };
            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
