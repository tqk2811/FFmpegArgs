using FFmpegArgs.Cores.Maps;
using System;

namespace FFmpegArgs.Cores.Outputs
{
    public abstract class ImageOutput : BaseOutput, IImage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="audioMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        protected ImageOutput(ImageMap imageMap)
        {
            this.ImageMap = imageMap ?? throw new ArgumentNullException(nameof(imageMap));
            if (!this.ImageMap.IsInput)
            {
                if (this.ImageMap.IsMapped) throw new InvalidOperationException($"{nameof(imageMap)} was mapped, map only one-to-one");
                else this.ImageMap.IsMapped = true;
            }
        }
        public ImageMap ImageMap { get; }
    }
}
