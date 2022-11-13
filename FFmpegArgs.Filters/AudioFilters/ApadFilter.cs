/*
apad AVOptions:
  packet_size       <int>        ..F.A...... set silence packet size (from 0 to INT_MAX) (default 4096)
  pad_len           <int64>      ..F.A...... set number of samples of silence to add (from -1 to I64_MAX) (default -1)
  whole_len         <int64>      ..F.A...... set minimum target number of samples in the audio stream (from -1 to I64_MAX) (default -1)
  pad_dur           <duration>   ..F.A...... set duration of silence to add (default 0)
  whole_dur         <duration>   ..F.A...... set minimum target duration in the audio stream (default 0)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// T.. apad              A->A       Pad audio with silence.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#apad"/>
    /// </summary>
    public class ApadFilter : AudioToAudioFilter, ITimelineSupport
    {
        internal ApadFilter(AudioMap audioMap) : base("apad", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// set silence packet size (from 0 to INT_MAX) (default 4096)
        /// </summary>
        /// <param name="packet_size"></param>
        /// <returns></returns>
        public ApadFilter PacketSize(int packet_size)
            => this.SetOptionRange("packet_size", packet_size, 0, INT_MAX);

        /// <summary>
        /// set number of samples of silence to add (from -1 to I64_MAX) (default -1)
        /// </summary>
        /// <param name="pad_len"></param>
        /// <returns></returns>
        public ApadFilter PadLen(long pad_len)
            => this.SetOptionRange("pad_len", pad_len, -1, I64_MAX);

        /// <summary>
        /// set minimum target number of samples in the audio stream (from -1 to I64_MAX) (default -1)
        /// </summary>
        /// <param name="whole_len"></param>
        /// <returns></returns>
        public ApadFilter WholeLen(long whole_len)
            => this.SetOptionRange("whole_len", whole_len, -1, I64_MAX);

        /// <summary>
        /// set duration of silence to add (default 0)
        /// </summary>
        /// <param name="pad_dur"></param>
        /// <returns></returns>
        public ApadFilter PadDur(TimeSpan pad_dur)
            => this.SetOptionRange("pad_dur", pad_dur, TimeSpan.Zero, TimeSpan.MaxValue);

        /// <summary>
        /// set minimum target duration in the audio stream (default 0)
        /// </summary>
        /// <param name="whole_dur"></param>
        /// <returns></returns>
        public ApadFilter WholeDur(TimeSpan whole_dur)
            => this.SetOptionRange("whole_dur", whole_dur, TimeSpan.Zero, TimeSpan.MaxValue);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class ApadFilterExtensions
    {
        /// <summary>
        /// Pad the end of an audio stream with silence.<br></br>
        /// This can be used together with ffmpeg -shortest to extend audio streams to the same length as the video stream.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#apad"/>
        /// </summary>
        public static ApadFilter ApadFilter(this AudioMap audioMap)
          => new ApadFilter(audioMap);
    }
}
