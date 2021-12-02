using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using FFmpegArgs;
using FFmpegArgs.Cores;
using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
namespace FFmpegArgs.Filters.Autogens
{
public class SincFilterGen : SourceAudioFilter
{
internal SincFilterGen(FilterGraph input) : base("sinc",input) { AddMapOut(); }
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public SincFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,1,INT_MAX);
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public SincFilterGen r(int r) => this.SetOptionRange("r", r,1,INT_MAX);
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public SincFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples,1,INT_MAX);
/// <summary>
///  set high-pass filter frequency (from 0 to INT_MAX) (default 0)
/// </summary>
public SincFilterGen hp(float hp) => this.SetOptionRange("hp", hp,0,INT_MAX);
/// <summary>
///  set low-pass filter frequency (from 0 to INT_MAX) (default 0)
/// </summary>
public SincFilterGen lp(float lp) => this.SetOptionRange("lp", lp,0,INT_MAX);
/// <summary>
///  set filter phase response (from 0 to 100) (default 50)
/// </summary>
public SincFilterGen phase(float phase) => this.SetOptionRange("phase", phase,0,100);
/// <summary>
///  set kaiser window beta (from -1 to 256) (default -1)
/// </summary>
public SincFilterGen beta(float beta) => this.SetOptionRange("beta", beta,-1,256);
/// <summary>
///  set stop-band attenuation (from 40 to 180) (default 120)
/// </summary>
public SincFilterGen att(float att) => this.SetOptionRange("att", att,40,180);
/// <summary>
///  enable rounding (default false)
/// </summary>
public SincFilterGen round(bool round) => this.SetOption("round",round.ToFFmpegFlag());
/// <summary>
///  set number of taps for high-pass filter (from 0 to 32768) (default 0)
/// </summary>
public SincFilterGen hptaps(int hptaps) => this.SetOptionRange("hptaps", hptaps,0,32768);
/// <summary>
///  set number of taps for low-pass filter (from 0 to 32768) (default 0)
/// </summary>
public SincFilterGen lptaps(int lptaps) => this.SetOptionRange("lptaps", lptaps,0,32768);
}
public static class SincFilterGenExtensions
{
/// <summary>
/// Generate a sinc kaiser-windowed low-pass, high-pass, band-pass, or band-reject FIR coefficients.
/// </summary>
public static SincFilterGen SincFilterGen(this FilterGraph input0) => new SincFilterGen(input0);
/// <summary>
/// Generate a sinc kaiser-windowed low-pass, high-pass, band-pass, or band-reject FIR coefficients.
/// </summary>
public static SincFilterGen SincFilterGen(this FilterGraph input0,SincFilterGenConfig config)
{
var result = new SincFilterGen(input0);
if(config?.sample_rate != null) result.sample_rate(config.sample_rate);
if(config?.r != null) result.r(config.r);
if(config?.nb_samples != null) result.nb_samples(config.nb_samples);
if(config?.hp != null) result.hp(config.hp);
if(config?.lp != null) result.lp(config.lp);
if(config?.phase != null) result.phase(config.phase);
if(config?.beta != null) result.beta(config.beta);
if(config?.att != null) result.att(config.att);
if(config?.round != null) result.round(config.round);
if(config?.hptaps != null) result.hptaps(config.hptaps);
if(config?.lptaps != null) result.lptaps(config.lptaps);
return result;
}
}
public class SincFilterGenConfig
{
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public int sample_rate { get; set; }
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public int r { get; set; }
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public int nb_samples { get; set; }
/// <summary>
///  set high-pass filter frequency (from 0 to INT_MAX) (default 0)
/// </summary>
public float hp { get; set; }
/// <summary>
///  set low-pass filter frequency (from 0 to INT_MAX) (default 0)
/// </summary>
public float lp { get; set; }
/// <summary>
///  set filter phase response (from 0 to 100) (default 50)
/// </summary>
public float phase { get; set; }
/// <summary>
///  set kaiser window beta (from -1 to 256) (default -1)
/// </summary>
public float beta { get; set; }
/// <summary>
///  set stop-band attenuation (from 40 to 180) (default 120)
/// </summary>
public float att { get; set; }
/// <summary>
///  enable rounding (default false)
/// </summary>
public bool round { get; set; }
/// <summary>
///  set number of taps for high-pass filter (from 0 to 32768) (default 0)
/// </summary>
public int hptaps { get; set; }
/// <summary>
///  set number of taps for low-pass filter (from 0 to 32768) (default 0)
/// </summary>
public int lptaps { get; set; }
}
}
