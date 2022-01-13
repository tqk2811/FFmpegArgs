namespace FFmpegArgs.Filters.Autogens
{
public class FieldorderFilterGen : ImageToImageFilter,ITimelineSupport
{
internal FieldorderFilterGen(ImageMap input) : base("fieldorder",input) { AddMapOut(); }
/// <summary>
///  output field order (from 0 to 1) (default tff)
/// </summary>
public FieldorderFilterGen order(FieldorderFilterGenOrder order) => this.SetOption("order", order.GetEnumAttribute<NameAttribute>().Name);
}
public static class FieldorderFilterGenExtensions
{
/// <summary>
/// Set the field order.
/// </summary>
public static FieldorderFilterGen FieldorderFilterGen(this ImageMap input0) => new FieldorderFilterGen(input0);
/// <summary>
/// Set the field order.
/// </summary>
public static FieldorderFilterGen FieldorderFilterGen(this ImageMap input0,FieldorderFilterGenConfig config)
{
var result = new FieldorderFilterGen(input0);
if(config?.order != null) result.order(config.order.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class FieldorderFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  output field order (from 0 to 1) (default tff)
/// </summary>
public FieldorderFilterGenOrder? order { get; set; }
public string TimelineSupport { get; set; }
}
public enum FieldorderFilterGenOrder
{
[Name("bff")] bff,
[Name("tff")] tff,
}

}
