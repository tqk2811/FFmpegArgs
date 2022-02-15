namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... libvmaf           VV->V      Calculate the VMAF between two video streams.
/// </summary>
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
/// <summary>
/// </summary>
public static class LibvmafFilterGenExtensions
{
/// <summary>
/// Calculate the VMAF between two video streams.
/// </summary>
public static LibvmafFilterGen LibvmafFilterGen(this ImageMap input0, ImageMap input1) => new LibvmafFilterGen(input0, input1);
}
}
