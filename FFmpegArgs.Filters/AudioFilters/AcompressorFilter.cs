﻿/*
 acompressor AVOptions:
  level_in          <double>     ..F.A....T. set input gain (from 0.015625 to 64) (default 1)
  mode              <int>        ..F.A....T. set mode (from 0 to 1) (default downward)
     downward        0            ..F.A....T.
     upward          1            ..F.A....T.
  threshold         <double>     ..F.A....T. set threshold (from 0.000976563 to 1) (default 0.125)
  ratio             <double>     ..F.A....T. set ratio (from 1 to 20) (default 2)
  attack            <double>     ..F.A....T. set attack (from 0.01 to 2000) (default 20)
  release           <double>     ..F.A....T. set release (from 0.01 to 9000) (default 250)
  makeup            <double>     ..F.A....T. set make up gain (from 1 to 64) (default 1)
  knee              <double>     ..F.A....T. set knee (from 1 to 8) (default 2.82843)
  link              <int>        ..F.A....T. set link type (from 0 to 1) (default average)
     average         0            ..F.A....T.
     maximum         1            ..F.A....T.
  detection         <int>        ..F.A....T. set detection (from 0 to 1) (default rms)
     peak            0            ..F.A....T.
     rms             1            ..F.A....T.
  level_sc          <double>     ..F.A....T. set sidechain gain (from 0.015625 to 64) (default 1)
  mix               <double>     ..F.A....T. set mix (from 0 to 1) (default 1)
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ..C acompressor       A->A       Audio compressor.<br>
    /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#acompressor"/>
    /// </summary>
    public class AcompressorFilter : AudioToAudioFilter, ICommandSupport
    {
        internal AcompressorFilter(AudioMap audioMap) : base("acompressor", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set input gain. Default is 1. Range is between 0.015625 and 64.
        /// </summary>
        /// <param name="level_in"></param>
        /// <returns></returns>
        public AcompressorFilter LevelIn(double level_in)
            => this.SetOptionRange("level_in", level_in, 0.015625, 64);
        /// <summary>
        /// Set mode of compressor operation
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public AcompressorFilter Mode(AcompressorMode mode)
            => this.SetOption("mode", mode.ToString().ToLower());
        /// <summary>
        /// If a signal of stream rises above this level it will affect the gain reduction.<br></br> 
        /// By default it is 0.125. Range is between 0.00097563 and 1.
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public AcompressorFilter Threshold(double threshold)
            => this.SetOptionRange("threshold", threshold, 0.00097563, 1);
        /// <summary>
        /// Set a ratio by which the signal is reduced. 1:2 means that if the level rose 4dB above the threshold,<br></br> 
        /// it will be only 2dB above after the reduction.<br></br>
        /// Default is 2. Range is between 1 and 20.
        /// </summary>
        /// <param name="ratio"></param>
        /// <returns></returns>
        public AcompressorFilter Ratio(double ratio)
            => this.SetOptionRange("ratio", ratio, 1, 20);
        /// <summary>
        /// Amount of milliseconds the signal has to rise above the threshold before gain reduction starts. <br></br>
        /// Default is 20. Range is between 0.01 and 2000.
        /// </summary>
        /// <param name="attack"></param>
        /// <returns></returns>
        public AcompressorFilter Attack(double attack)
            => this.SetOptionRange("attack", attack, 0.01f, 2000);
        /// <summary>
        /// Amount of milliseconds the signal has to fall below the threshold before reduction is decreased again.<br>
        /// </br> Default is 250. Range is between 0.01 and 9000.
        /// </summary>
        /// <param name="release"></param>
        /// <returns></returns>
        public AcompressorFilter Release(double release)
            => this.SetOptionRange("release", release, 0.01f, 9000);
        /// <summary>
        /// Set the amount by how much signal will be amplified after processing.<br>
        /// </br> Default is 1. Range is from 1 to 64.
        /// </summary>
        /// <param name="makeup"></param>
        /// <returns></returns>
        public AcompressorFilter Makeup(double makeup)
            => this.SetOptionRange("makeup", makeup, 1, 64);
        /// <summary>
        /// Curve the sharp knee around the threshold to enter gain reduction more softly.<br>
        /// </br> Default is 2.82843. Range is between 1 and 8.
        /// </summary>
        /// <param name="knee"></param>
        /// <returns></returns>
        public AcompressorFilter Knee(double knee)
            => this.SetOptionRange("knee", knee, 1, 8);
        /// <summary>
        /// Choose if the average level between all channels of input stream <br>
        /// </br>or the louder(maximum) channel of input stream affects the reduction.<br>
        /// </br> Default is average.
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public AcompressorFilter Link(AcompressorLink link)
            => this.SetOption("link", link.ToString().ToLower());
        /// <summary>
        /// Should the exact signal be taken in case of peak or an RMS one in case of rms.<br>
        /// </br> Default is rms which is mostly smoother.
        /// </summary>
        /// <param name="detection"></param>
        /// <returns></returns>
        public AcompressorFilter Detection(AcompressorDetection detection)
            => this.SetOption("detection", detection.ToString().ToLower());
        /// <summary>
        /// How much to use compressed signal in output.<br>
        /// </br> Default is 1. Range is between 0 and 1.
        /// </summary>
        /// <param name="mix"></param>
        /// <returns></returns>
        public AcompressorFilter Mix(double mix)
            => this.SetOptionRange("mix", mix, 0, 1);
        /// <summary>
        /// set sidechain gain (from 0.015625 to 64) (default 1)
        /// </summary>
        /// <returns></returns>
        public AcompressorFilter LevelSc(double level_sc)
            => this.SetOptionRange("level_sc", level_sc, 0.015625, 64);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AcompressorFilterExtension
    {
        /// <summary>
        /// A compressor is mainly used to reduce the dynamic range of a signal. Especially modern music is mostly compressed at a high ratio to improve the overall loudness. It’s done to get the highest attention of a listener, "fatten" the sound and bring more "power" to the track. If a signal is compressed too much it may sound dull or "dead" afterwards or it may start to "pump" (which could be a powerful effect but can also destroy a track completely). The right compression is the key to reach a professional sound and is the high art of mixing and mastering. Because of its complex settings it may take a long time to get the right feeling for this kind of effect.<br></br><br></br>
        /// Compression is done by detecting the volume above a chosen level threshold and dividing it by the factor set with ratio.So if you set the threshold to -12dB and your signal reaches -6dB a ratio of 2:1 will result in a signal at -9dB.Because an exact manipulation of the signal would cause distortion of the waveform the reduction can be levelled over the time.This is done by setting "Attack" and "Release". attack determines how long the signal has to rise above the threshold before any reduction will occur and release sets the time the signal has to fall below the threshold to reduce the reduction again.Shorter signals than the chosen attack time will be left untouched. The overall reduction of the signal can be made up afterwards with the makeup setting.So compressing the peaks of a signal about 6dB and raising the makeup to this level results in a signal twice as loud than the source. To gain a softer entry in the compression the knee flattens the hard edge at the threshold in the range of the chosen decibels.
        /// <br></br><see href="https://ffmpeg.org/ffmpeg-filters.html#acompressor"/>
        /// </summary>
        /// <param name="audioMap"></param>
        /// <returns></returns>
        public static AcompressorFilter AcompressorFilter(this AudioMap audioMap) => new AcompressorFilter(audioMap);
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum AcompressorMode
    {
        Upward,
        Downward
    }
    public enum AcompressorLink
    {
        Average,
        Maximum
    }
    public enum AcompressorDetection
    {
        Peak,
        Rms
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
