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
        public FilterGraph FilterGraph { get; } = new FilterGraph();

        /// <summary>
        /// 
        /// </summary>
        public FFmpegArg()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="audio"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="InvalidRangeException"></exception>
        public IEnumerable<AudioMap> AddAudiosInput(AudioInput audio)
        {
            if (audio == null) throw new ArgumentNullException(nameof(audio));
            if (_inputs.Contains(audio)) throw new InvalidOperationException("Sound was add to input before");
            //if (count <= 0) throw new InvalidRangeException($"{nameof(count)} must be greater than 0");
            if (audio.PipeStream != null && _inputs.FirstOrDefault(x => x.PipeStream != null)?.PipeStream != null)
                throw new InvalidOperationException("Only allow one PipeStream (stdin)");
            _inputs.Add(audio);

            List<AudioMap> results = new List<AudioMap>();
            foreach (var inputStream in audio.AudioInputAVStreams)
            {
                results.Add(new AudioMap(this, FilterGraph, inputStream));
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
            //if (count <= 0) throw new InvalidRangeException($"{nameof(count)} must be greater than 0");
            if (image.PipeStream != null && _inputs.FirstOrDefault(x => x.PipeStream != null)?.PipeStream != null)
                throw new InvalidOperationException("Only allow one PipeStream (stdin)");
            _inputs.Add(image);

            List<ImageMap> results = new List<ImageMap>();
            foreach (var inputStream in image.ImageInputAVStreams)
            {
                results.Add(new ImageMap(this, FilterGraph, inputStream));
            }
            return results;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="video"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public VideoMap AddVideoInput(VideoInput video)
        {
            if (video == null) throw new ArgumentNullException(nameof(video));
            if (_inputs.Contains(video)) throw new InvalidOperationException("Video was add to input before");
            if (video.PipeStream != null && _inputs.FirstOrDefault(x => x.PipeStream != null)?.PipeStream != null)
                throw new InvalidOperationException("Only allow one PipeStream (stdin)");

            _inputs.Add(video);

            List<ImageMap> imageMaps = new List<ImageMap>();
            List<AudioMap> audioMaps = new List<AudioMap>();
            foreach (var inputStream in video.ImageInputAVStreams)
            {
                imageMaps.Add(new ImageMap(this, FilterGraph, inputStream));
            }
            foreach (var inputStream in video.AudioInputAVStreams)
            {
                audioMaps.Add(new AudioMap(this, FilterGraph, inputStream));
            }
            return new VideoMap(imageMaps, audioMaps);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="output"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public void AddOutput(BaseOutput output)
        {
            if (output == null) throw new ArgumentNullException(nameof(output));
            if (_outputs.Contains(output)) throw new InvalidOperationException("This output was add before");
            if (output.FilterGraph != this.FilterGraph) throw new InvalidOperationException("This output are not same FilterGraph");

            if (output.PipeStream != null && _outputs.FirstOrDefault(x => x.PipeStream != null)?.PipeStream != null)
                throw new InvalidOperationException("Only allow one PipeStream (stdout)");

            _outputs.Add(output);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetGlobalArgs()
        {
            return string.Join(" ", GetFlagArgs(), GetOptionArgs());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetInputsArgs()
        {
            if (!_inputs.Any()) throw new InvalidOperationException($"Input is empty");
            return string.Join(" ", _inputs);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetOutputsArgs()
        {
            if (!_outputs.Any()) throw new InvalidOperationException($"Output is empty");
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
