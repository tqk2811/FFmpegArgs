using FFmpegArgs.Cores.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpegArgs.Inputs
{
  public class ImageFileInput : BaseInput, IImageInput
  {
    readonly string _filePath;
    public ImageFileInput(string filePath)
    {
      if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
      this._filePath = filePath;
    }

    public override string ToString()
    {
      List<string> args = new List<string>()
      {
        GetArgs(),
        _filePath.Contains(" ") ? $"-i \"{_filePath}\"" : $"-i {_filePath}"
      };
      return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
    }
  }
}
