using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Cores.Outputs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpegArgs.Outputs
{
    public class AudioFileOutput : AudioOutput
    {
        readonly string _filePath;
        public AudioFileOutput(string filePath, AudioMap audioMap)
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
            this._filePath = filePath;

            AudioMap = audioMap ?? throw new ArgumentNullException(nameof(audioMap));
        }

        public override string ToString()
        {
            List<string> args = new List<string>()
            {
                GetArgs(),
                "-map",
                AudioMap.IsInput ? $"\"{AudioMap.MapName}:a:{AudioMap.InputIndex}\"" : $"\"[{AudioMap.MapName}]\"",
                _filePath.Contains(" ") ? $"\"{_filePath}\"" : _filePath
            };
            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
