namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. whisper           A-&gt;A       Transcribe audio using whisper.cpp.
    /// </summary>
    public class WhisperFilterGen : AudioToAudioFilter
    {
        internal WhisperFilterGen(AudioMap input) : base("whisper", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Path to the whisper.cpp model file
        /// </summary>
        public WhisperFilterGen model(String model) => this.SetOption("model", model.ToStringInv());
        /// <summary>
        ///  Language for transcription (&#39;auto&#39; for auto-detect) (default &quot;auto&quot;)
        /// </summary>
        public WhisperFilterGen language(String language) => this.SetOption("language", language.ToStringInv());
        /// <summary>
        ///  Audio queue size (default 3)
        /// </summary>
        public WhisperFilterGen queue(TimeSpan queue) => this.SetOptionRange("queue", queue, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  Use GPU for processing (default true)
        /// </summary>
        public WhisperFilterGen use_gpu(bool use_gpu) => this.SetOption("use_gpu", use_gpu.ToFFmpegFlag());
        /// <summary>
        ///  GPU device to use (from 0 to INT_MAX) (default 0)
        /// </summary>
        public WhisperFilterGen gpu_device(int gpu_device) => this.SetOptionRange("gpu_device", gpu_device, 0, INT_MAX);
        /// <summary>
        ///  Output destination (default &quot;&quot;)
        /// </summary>
        public WhisperFilterGen destination(String destination) => this.SetOption("destination", destination.ToStringInv());
        /// <summary>
        ///  Output format (text|srt|json) (default &quot;text&quot;)
        /// </summary>
        public WhisperFilterGen format(String format) => this.SetOption("format", format.ToStringInv());
        /// <summary>
        ///  Path to the VAD model file
        /// </summary>
        public WhisperFilterGen vad_model(String vad_model) => this.SetOption("vad_model", vad_model.ToStringInv());
        /// <summary>
        ///  VAD threshold (from 0 to 1) (default 0.5)
        /// </summary>
        public WhisperFilterGen vad_threshold(float vad_threshold) => this.SetOptionRange("vad_threshold", vad_threshold, 0, 1);
        /// <summary>
        ///  Minimum speech duration for VAD (default 0.1)
        /// </summary>
        public WhisperFilterGen vad_min_speech_duration(TimeSpan vad_min_speech_duration) => this.SetOptionRange("vad_min_speech_duration", vad_min_speech_duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  Minimum silence duration for VAD (default 0.5)
        /// </summary>
        public WhisperFilterGen vad_min_silence_duration(TimeSpan vad_min_silence_duration) => this.SetOptionRange("vad_min_silence_duration", vad_min_silence_duration, TimeSpan.Zero, TimeSpan.MaxValue);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Transcribe audio using whisper.cpp.
        /// </summary>
        public static WhisperFilterGen WhisperFilterGen(this AudioMap input0) => new WhisperFilterGen(input0);
    }
}