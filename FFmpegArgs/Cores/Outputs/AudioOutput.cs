using FFmpegArgs.Cores.Maps;
using System;

namespace FFmpegArgs.Cores.Outputs
{
    public abstract class AudioOutput : BaseOutput, IAudio
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="audioMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        protected AudioOutput(AudioMap audioMap)
        {
            this.AudioMap = audioMap ?? throw new ArgumentNullException(nameof(audioMap));
            if (!this.AudioMap.IsInput)
            {
                if (this.AudioMap.IsMapped) throw new InvalidOperationException($"{nameof(audioMap)} was mapped, map only one-to-one");
                else this.AudioMap.IsMapped = true;
            }
        }
        public AudioMap AudioMap { get; }
    }
}
