using FFmpegArgs.Cores.Maps;
using System;
namespace FFmpegArgs.Cores.Outputs
{
    public abstract class VideoOutput : BaseOutput, IImage, IAudio
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="audioMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        protected VideoOutput(ImageMap imageMap,AudioMap audioMap)
        {
            this.ImageMap = imageMap ?? throw new ArgumentNullException(nameof(imageMap));
            this.AudioMap = audioMap ?? throw new ArgumentNullException(nameof(audioMap));
            if (ImageMap.FilterGraph != AudioMap.FilterGraph) throw new InvalidOperationException("Two map are not same FilterGraph");
            if(!this.ImageMap.IsInput)
            {
                if (this.ImageMap.IsMapped) throw new InvalidOperationException($"{nameof(imageMap)} was mapped, map only one-to-one");
                else this.ImageMap.IsMapped = true;
            }
            if (!this.AudioMap.IsInput)
            {
                if (this.AudioMap.IsMapped) throw new InvalidOperationException($"{nameof(audioMap)} was mapped, map only one-to-one");
                else this.AudioMap.IsMapped = true;
            }
        }
        public ImageMap ImageMap { get; }
        public AudioMap AudioMap { get; }
    }
}
