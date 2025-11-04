using System;

namespace FFmpegArgs.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioFileOutput : AudioOutput
    {
        readonly string _filePath;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="audioMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public AudioFileOutput(string filePath, AudioMap audioMap) : base(audioMap)
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
            this._filePath = filePath;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="audioMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public AudioFileOutput(string filePath, params AudioMap[] audioMaps) : base(audioMaps)
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
            this._filePath = filePath;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="audioMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public AudioFileOutput(string filePath, IEnumerable<AudioMap> audioMaps) : base(audioMaps.ToArray())
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
            this._filePath = filePath;
        }

        public override IEnumerable<string> GetAllArgs()
        {
            List<string> args =
            [
                .. GetFlagArgs(),
                .. GetOptionArgs(),
                .. GetAVStreamArgs(),
                _filePath
            ];
            return args;
        }
    }
}
