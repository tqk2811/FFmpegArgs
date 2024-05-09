namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... colorspace_cuda   V->V       CUDA accelerated video color converter
/// </summary>
public class Colorspace_cudaFilterGen : ImageToImageFilter
{
internal Colorspace_cudaFilterGen(ImageMap input) : base("colorspace_cuda",input) { AddMapOut(); }
/// <summary>
///  Output video range (from 0 to 2) (default 0)
/// </summary>
public Colorspace_cudaFilterGen range(Colorspace_cudaFilterGenRange range) => this.SetOption("range", range.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class Colorspace_cudaFilterGenExtensions
{
/// <summary>
/// CUDA accelerated video color converter
/// </summary>
public static Colorspace_cudaFilterGen Colorspace_cudaFilterGen(this ImageMap input0) => new Colorspace_cudaFilterGen(input0);
}
/// <summary>
///  Output video range (from 0 to 2) (default 0)
/// </summary>
public enum Colorspace_cudaFilterGenRange
{
/// <summary>
/// tv              1            ..FV....... Limited range
/// </summary>
[Name("tv")] tv,
/// <summary>
/// mpeg            1            ..FV....... Limited range
/// </summary>
[Name("mpeg")] mpeg,
/// <summary>
/// pc              2            ..FV....... Full range
/// </summary>
[Name("pc")] pc,
/// <summary>
/// jpeg            2            ..FV....... Full range
/// </summary>
[Name("jpeg")] jpeg,
}

}
