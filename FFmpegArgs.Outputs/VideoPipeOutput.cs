﻿namespace FFmpegArgs.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoPipeOutput : VideoOutput
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="streamOutput"></param>
        /// <param name="format"></param>
        /// <param name="imageMap"></param>
        /// <param name="audioMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public VideoPipeOutput(Stream streamOutput, MuxingFileFormat format, ImageMap imageMap, AudioMap audioMap) : base(imageMap, audioMap)
        {
            PipeStream = streamOutput ?? throw new ArgumentNullException(nameof(streamOutput));
            if (!streamOutput.CanWrite) throw new InvalidOperationException("input stream.CanWrite is required");
            this.Format(format);
        }

        /// <summary>
        /// 
        /// </summary>
        public override Stream PipeStream { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            List<string> args = new List<string>()
            {
                GetArgs(),
                "-map",
                $"[{ImageMap.MapName}]",
                "-map",
                $"[{AudioMap.MapName}]",
                $"pipe:{StdOut}"
            };
            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}