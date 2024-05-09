namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.. fieldorder        V->V       Set the field order.
/// </summary>
public class FieldorderFilterGen : ImageToImageFilter,ITimelineSupport
{
internal FieldorderFilterGen(ImageMap input) : base("fieldorder",input) { AddMapOut(); }
/// <summary>
///  output field order (from 0 to 1) (default tff)
/// </summary>
public FieldorderFilterGen order(FieldorderFilterGenOrder order) => this.SetOption("order", order.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class FieldorderFilterGenExtensions
{
/// <summary>
/// Set the field order.
/// </summary>
public static FieldorderFilterGen FieldorderFilterGen(this ImageMap input0) => new FieldorderFilterGen(input0);
}
/// <summary>
///  output field order (from 0 to 1) (default tff)
/// </summary>
public enum FieldorderFilterGenOrder
{
/// <summary>
/// bff             0            ..FV....... bottom field first
/// </summary>
[Name("bff")] bff,
/// <summary>
/// tff             1            ..FV....... top field first
/// </summary>
[Name("tff")] tff,
}

}
