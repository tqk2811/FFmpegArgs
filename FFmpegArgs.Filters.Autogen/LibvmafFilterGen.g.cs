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
public class LibvmafFilterGen : ImageToImageFilter
{
internal LibvmafFilterGen(params ImageMap[] inputs) : base("libvmaf",inputs) { AddMapOut(); }
/// <summary>
///  Set the model to be used for computing vmaf. (default "/usr/local/share/model/vmaf_v0.6.1.pkl")
/// </summary>
public LibvmafFilterGen model_path(string model_path) => this.SetOption("model_path",model_path);
/// <summary>
///  Set the file path to be used to store logs.
/// </summary>
public LibvmafFilterGen log_path(string log_path) => this.SetOption("log_path",log_path);
/// <summary>
///  Set the format of the log (csv, json or xml).
/// </summary>
public LibvmafFilterGen log_fmt(string log_fmt) => this.SetOption("log_fmt",log_fmt);
/// <summary>
///  Enables transform for computing vmaf. (default false)
/// </summary>
public LibvmafFilterGen enable_transform(bool enable_transform) => this.SetOption("enable_transform",enable_transform.ToFFmpegFlag());
/// <summary>
///  Invokes the phone model that will generate higher VMAF scores. (default false)
/// </summary>
public LibvmafFilterGen phone_model(bool phone_model) => this.SetOption("phone_model",phone_model.ToFFmpegFlag());
/// <summary>
///  Enables computing psnr along with vmaf. (default false)
/// </summary>
public LibvmafFilterGen psnr(bool psnr) => this.SetOption("psnr",psnr.ToFFmpegFlag());
/// <summary>
///  Enables computing ssim along with vmaf. (default false)
/// </summary>
public LibvmafFilterGen ssim(bool ssim) => this.SetOption("ssim",ssim.ToFFmpegFlag());
/// <summary>
///  Enables computing ms-ssim along with vmaf. (default false)
/// </summary>
public LibvmafFilterGen ms_ssim(bool ms_ssim) => this.SetOption("ms_ssim",ms_ssim.ToFFmpegFlag());
/// <summary>
///  Set the pool method to be used for computing vmaf.
/// </summary>
public LibvmafFilterGen pool(string pool) => this.SetOption("pool",pool);
/// <summary>
///  Set number of threads to be used when computing vmaf. (from 0 to UINT32_MAX) (default 0)
/// </summary>
public LibvmafFilterGen n_threads(int n_threads) => this.SetOptionRange("n_threads", n_threads,0,UINT32_MAX);
/// <summary>
///  Set interval for frame subsampling used when computing vmaf. (from 1 to UINT32_MAX) (default 1)
/// </summary>
public LibvmafFilterGen n_subsample(int n_subsample) => this.SetOptionRange("n_subsample", n_subsample,1,UINT32_MAX);
/// <summary>
///  Enables confidence interval. (default false)
/// </summary>
public LibvmafFilterGen enable_conf_interval(bool enable_conf_interval) => this.SetOption("enable_conf_interval",enable_conf_interval.ToFFmpegFlag());
}
public static class LibvmafFilterGenExtensions
{
/// <summary>
/// Calculate the VMAF between two video streams.
/// </summary>
public static LibvmafFilterGen LibvmafFilterGen(this ImageMap input0, ImageMap input1) => new LibvmafFilterGen(input0, input1);
/// <summary>
/// Calculate the VMAF between two video streams.
/// </summary>
public static LibvmafFilterGen LibvmafFilterGen(this ImageMap input0, ImageMap input1,LibvmafFilterGenConfig config)
{
var result = new LibvmafFilterGen(input0, input1);
if(!string.IsNullOrWhiteSpace(config?.model_path)) result.model_path(config.model_path);
if(!string.IsNullOrWhiteSpace(config?.log_path)) result.log_path(config.log_path);
if(!string.IsNullOrWhiteSpace(config?.log_fmt)) result.log_fmt(config.log_fmt);
if(config?.enable_transform != null) result.enable_transform(config.enable_transform.Value);
if(config?.phone_model != null) result.phone_model(config.phone_model.Value);
if(config?.psnr != null) result.psnr(config.psnr.Value);
if(config?.ssim != null) result.ssim(config.ssim.Value);
if(config?.ms_ssim != null) result.ms_ssim(config.ms_ssim.Value);
if(!string.IsNullOrWhiteSpace(config?.pool)) result.pool(config.pool);
if(config?.n_threads != null) result.n_threads(config.n_threads.Value);
if(config?.n_subsample != null) result.n_subsample(config.n_subsample.Value);
if(config?.enable_conf_interval != null) result.enable_conf_interval(config.enable_conf_interval.Value);
return result;
}
}
public class LibvmafFilterGenConfig
{
/// <summary>
///  Set the model to be used for computing vmaf. (default "/usr/local/share/model/vmaf_v0.6.1.pkl")
/// </summary>
public string model_path { get; set; }
/// <summary>
///  Set the file path to be used to store logs.
/// </summary>
public string log_path { get; set; }
/// <summary>
///  Set the format of the log (csv, json or xml).
/// </summary>
public string log_fmt { get; set; }
/// <summary>
///  Enables transform for computing vmaf. (default false)
/// </summary>
public bool? enable_transform { get; set; }
/// <summary>
///  Invokes the phone model that will generate higher VMAF scores. (default false)
/// </summary>
public bool? phone_model { get; set; }
/// <summary>
///  Enables computing psnr along with vmaf. (default false)
/// </summary>
public bool? psnr { get; set; }
/// <summary>
///  Enables computing ssim along with vmaf. (default false)
/// </summary>
public bool? ssim { get; set; }
/// <summary>
///  Enables computing ms-ssim along with vmaf. (default false)
/// </summary>
public bool? ms_ssim { get; set; }
/// <summary>
///  Set the pool method to be used for computing vmaf.
/// </summary>
public string pool { get; set; }
/// <summary>
///  Set number of threads to be used when computing vmaf. (from 0 to UINT32_MAX) (default 0)
/// </summary>
public int? n_threads { get; set; }
/// <summary>
///  Set interval for frame subsampling used when computing vmaf. (from 1 to UINT32_MAX) (default 1)
/// </summary>
public int? n_subsample { get; set; }
/// <summary>
///  Enables confidence interval. (default false)
/// </summary>
public bool? enable_conf_interval { get; set; }
}
}
