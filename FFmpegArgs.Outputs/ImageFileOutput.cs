using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Cores.Outputs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpegArgs.Outputs
{
  public class ImageFileOutput : BaseOutput, IImageOutput
  {
    readonly string _filePath;
    public ImageFileOutput(string filePath, ImageMap imageMap)
    {
      if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
      this._filePath = filePath;
      this.ImageMap = imageMap ?? throw new ArgumentNullException(nameof(imageMap));
    }
    public ImageMap ImageMap { get; }



    public override string ToString()
    {
      List<string> args = new List<string>()
      {
        GetArgs(),
        "-map",
        ImageMap.IsInput ? $"\"{ImageMap.MapName}:v:{ImageMap.InputIndex}\"" : $"\"[{ImageMap.MapName}]\"",
        _filePath.Contains(" ") ? $"\"{_filePath}\"" : _filePath
      };
      return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
    }
  }
}
