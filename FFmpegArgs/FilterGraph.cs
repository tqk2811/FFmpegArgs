using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Inputs;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Cores.Outputs;
using FFmpegArgs.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpegArgs
{
    public sealed class FilterGraph : BaseOptionFlag
    {
        public IEnumerable<BaseInput> Inputs { get { return _inputs; } }
        public IEnumerable<BaseOutput> Outputs { get { return _outputs; } }
        public IEnumerable<IFilter<IMap, IMap>> Filters { get { return _filters; } }

        internal List<BaseInput> _inputs { get; } = new List<BaseInput>();
        internal List<BaseOutput> _outputs { get; } = new List<BaseOutput>();
        internal List<IFilter<IMap, IMap>> _filters { get; } = new List<IFilter<IMap, IMap>>();


        public FilterGraph()
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
            if (_inputs.Contains(sound)) throw new InvalidOperationException("Sound was add to input before");
            if (count <= 0) throw new InvalidRangeException($"{nameof(count)} <= 0");
            _inputs.Add(sound);
            List<AudioMap> results = new List<AudioMap>();
            for (int i = 0; i < count; i++)
            {
                results.Add(new AudioMap(this, $"{_inputs.IndexOf(sound)}") { IsInput = true, InputIndex = i });
            }
            return results;
        }

        public AudioMap AddAudioInput(AudioInput sound)
        {
            if (_inputs.Contains(sound)) throw new InvalidOperationException("Sound was add to input before");
            _inputs.Add(sound);
            return new AudioMap(this, $"{_inputs.IndexOf(sound)}") { IsInput = true , InputIndex = _inputs.IndexOf(sound) };
        }

        public IEnumerable<ImageMap> AddImagesInput(ImageInput image, int count)
        {
            if (_inputs.Contains(image)) throw new InvalidOperationException("Image was add to input before");
            if (count <= 0) throw new InvalidRangeException($"{nameof(count)} <= 0");
            _inputs.Add(image);
            List<ImageMap> results = new List<ImageMap>();
            for (int i = 0; i < count; i++)
            {
                results.Add(new ImageMap(this, $"{_inputs.IndexOf(image)}") { IsInput = true, InputIndex = i });
            }
            return results;
        }

        public ImageMap AddImageInput(ImageInput image)
        {
            if (_inputs.Contains(image)) throw new InvalidOperationException("Image was add to input before");
            _inputs.Add(image);
            return new ImageMap(this, $"{_inputs.IndexOf(image)}") { IsInput = true, InputIndex = _inputs.IndexOf(image) };
        }

        public VideoMap AddVideoInput(VideoInput video, int imageCount = 1, int audioCount = 1)
        {
            if (_inputs.Contains(video)) throw new InvalidOperationException("Video was add to input before");
            if (imageCount < 1 || audioCount < 1)
                throw new InvalidRangeException($"imageCount or audioCount < 1\r\nFor non audio, use {nameof(ImageInput)} instead");

            _inputs.Add(video);
            int inputIndex = _inputs.IndexOf(video);
            List<ImageMap> imageMaps = new List<ImageMap>();
            List<AudioMap> audioMaps = new List<AudioMap>();

            for (int i = 0; i < imageCount; i++)
                imageMaps.Add(new ImageMap(this, $"{inputIndex}") { IsInput = true, InputIndex = i });
            for (int i = 0; i < audioCount; i++)
                audioMaps.Add(new AudioMap(this, $"{inputIndex}") { IsInput = true, InputIndex = i });

            return new VideoMap(imageMaps, audioMaps);
        }

        public void AddOutput(BaseOutput output)
        {
            if (_outputs.Contains(output)) throw new InvalidOperationException("This output was add before");
            _outputs.Add(output);
        }

        public string GetGlobalArgs()
        {
            return GetArgs();
        }
        public string GetInputsArgs()
        {
            return string.Join(" ", _inputs);
        }
        public string GetOutputsArgs()
        {
            return string.Join(" ", _outputs);
        }
        public string GetFiltersArgs(bool withNewLine = false)
        {
            var filter_not_bind = Filters.FirstOrDefault(x => x.MapsOut.Any(y => !y.IsMapped));
            if (filter_not_bind != null)
                throw new FilterException($"Have Map in filter {filter_not_bind.FilterName} are not bind");

            if (withNewLine) return string.Join(";\r\n", _filters);
            else return string.Join(";", _filters);
        }

        public string GetFullCommandline()
        {
            List<string> args = new List<string>()
            {
                GetGlobalArgs(),
                GetInputsArgs(),
                $"-filter_complex \"{GetFiltersArgs()}\"",
                GetOutputsArgs()
            };
            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }

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
