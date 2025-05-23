﻿namespace FFmpegArgs.Filters.BaseFilters
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AudioToAudioFilter : BaseFilter<AudioMap, AudioMap>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="mapsIn"></param>
        protected AudioToAudioFilter(string filterName, params AudioMap[] mapsIn) : base(filterName, mapsIn)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        protected override void AddMapOut() 
            => _mapsOut.Add(new AudioMap(FilterGraph, $"f_{FilterIndex}"));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        protected override void AddMapOut(int index) 
            => _mapsOut.Add(new AudioMap(FilterGraph, $"f_{FilterIndex}_{index}"));
    }
}
