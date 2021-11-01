using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Cores.Outputs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpegArgs.Outputs
{
  public class VideoFileOutput : VideoOutput
  {
    readonly string _filePath;
    public VideoFileOutput(string filePath, ImageMap imageMap, AudioMap audioMap)
    {
      if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
      this._filePath = filePath;

      ImageMap = imageMap ?? throw new ArgumentNullException(nameof(imageMap));
      AudioMap = audioMap ?? throw new ArgumentNullException(nameof(audioMap));
    }

    public override string ToString()
    {
      List<string> args = new List<string>()
      {
        GetArgs(),
        "-map",
        ImageMap.IsInput ? $"\"{ImageMap.MapName}:v:{ImageMap.InputIndex}\"" :  $"\"[{ImageMap.MapName}\"]",
        "-map",
        AudioMap.IsInput ? $"\"{AudioMap.MapName}:a:{ImageMap.InputIndex}\"" :  $"\"[{AudioMap.MapName}\"]",
        _filePath.Contains(" ") ? $"\"{_filePath}\"" : _filePath
      };
      return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
    }
  }
}
