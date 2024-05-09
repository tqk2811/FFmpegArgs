namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC nnedi             V->V       Apply neural network edge directed interpolation intra-only deinterlacer.
/// </summary>
public class NnediFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal NnediFilterGen(ImageMap input) : base("nnedi",input) { AddMapOut(); }
/// <summary>
///  set weights file (default "nnedi3_weights.bin")
/// </summary>
public NnediFilterGen weights(string weights) => this.SetOption("weights",weights);
/// <summary>
///  set which frames to deinterlace (from 0 to 1) (default all)
/// </summary>
public NnediFilterGen deint(NnediFilterGenDeint deint) => this.SetOption("deint", deint.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set mode of operation (from -2 to 3) (default a)
/// </summary>
public NnediFilterGen field(NnediFilterGenField field) => this.SetOption("field", field.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set which planes to process (from 0 to 15) (default 7)
/// </summary>
public NnediFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set size of local neighborhood around each pixel, used by the predictor neural network (from 0 to 6) (default s32x4)
/// </summary>
public NnediFilterGen nsize(NnediFilterGenNsize nsize) => this.SetOption("nsize", nsize.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set number of neurons in predictor neural network (from 0 to 4) (default n32)
/// </summary>
public NnediFilterGen nns(NnediFilterGenNns nns) => this.SetOption("nns", nns.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set quality (from 1 to 2) (default fast)
/// </summary>
public NnediFilterGen qual(NnediFilterGenQual qual) => this.SetOption("qual", qual.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set which set of weights to use in the predictor (from 0 to 1) (default a)
/// </summary>
public NnediFilterGen etype(NnediFilterGenEtype etype) => this.SetOption("etype", etype.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set prescreening (from 0 to 4) (default new)
/// </summary>
public NnediFilterGen pscrn(NnediFilterGenPscrn pscrn) => this.SetOption("pscrn", pscrn.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class NnediFilterGenExtensions
{
/// <summary>
/// Apply neural network edge directed interpolation intra-only deinterlacer.
/// </summary>
public static NnediFilterGen NnediFilterGen(this ImageMap input0) => new NnediFilterGen(input0);
}
/// <summary>
///  set which frames to deinterlace (from 0 to 1) (default all)
/// </summary>
public enum NnediFilterGenDeint
{
/// <summary>
/// all             0            ..FV.....T. deinterlace all frames
/// </summary>
[Name("all")] all,
/// <summary>
/// interlaced      1            ..FV.....T. only deinterlace frames marked as interlaced
/// </summary>
[Name("interlaced")] interlaced,
}

/// <summary>
///  set mode of operation (from -2 to 3) (default a)
/// </summary>
public enum NnediFilterGenField
{
/// <summary>
/// af              -2           ..FV.....T. use frame flags, both fields
/// </summary>
[Name("af")] af,
/// <summary>
/// a               -1           ..FV.....T. use frame flags, single field
/// </summary>
[Name("a")] a,
/// <summary>
/// t               0            ..FV.....T. use top field only
/// </summary>
[Name("t")] t,
/// <summary>
/// b               1            ..FV.....T. use bottom field only
/// </summary>
[Name("b")] b,
/// <summary>
/// tf              2            ..FV.....T. use both fields, top first
/// </summary>
[Name("tf")] tf,
/// <summary>
/// bf              3            ..FV.....T. use both fields, bottom first
/// </summary>
[Name("bf")] bf,
}

/// <summary>
///  set size of local neighborhood around each pixel, used by the predictor neural network (from 0 to 6) (default s32x4)
/// </summary>
public enum NnediFilterGenNsize
{
/// <summary>
/// s8x6            0            ..FV.....T.
/// </summary>
[Name("s8x6")] s8x6,
/// <summary>
/// s16x6           1            ..FV.....T.
/// </summary>
[Name("s16x6")] s16x6,
/// <summary>
/// s32x6           2            ..FV.....T.
/// </summary>
[Name("s32x6")] s32x6,
/// <summary>
/// s48x6           3            ..FV.....T.
/// </summary>
[Name("s48x6")] s48x6,
/// <summary>
/// s8x4            4            ..FV.....T.
/// </summary>
[Name("s8x4")] s8x4,
/// <summary>
/// s16x4           5            ..FV.....T.
/// </summary>
[Name("s16x4")] s16x4,
/// <summary>
/// s32x4           6            ..FV.....T.
/// </summary>
[Name("s32x4")] s32x4,
}

/// <summary>
///  set number of neurons in predictor neural network (from 0 to 4) (default n32)
/// </summary>
public enum NnediFilterGenNns
{
/// <summary>
/// n16             0            ..FV.....T.
/// </summary>
[Name("n16")] n16,
/// <summary>
/// n32             1            ..FV.....T.
/// </summary>
[Name("n32")] n32,
/// <summary>
/// n64             2            ..FV.....T.
/// </summary>
[Name("n64")] n64,
/// <summary>
/// n128            3            ..FV.....T.
/// </summary>
[Name("n128")] n128,
/// <summary>
/// n256            4            ..FV.....T.
/// </summary>
[Name("n256")] n256,
}

/// <summary>
///  set quality (from 1 to 2) (default fast)
/// </summary>
public enum NnediFilterGenQual
{
/// <summary>
/// fast            1            ..FV.....T.
/// </summary>
[Name("fast")] fast,
/// <summary>
/// slow            2            ..FV.....T.
/// </summary>
[Name("slow")] slow,
}

/// <summary>
///  set which set of weights to use in the predictor (from 0 to 1) (default a)
/// </summary>
public enum NnediFilterGenEtype
{
/// <summary>
/// a               0            ..FV.....T. weights trained to minimize absolute error
/// </summary>
[Name("a")] a,
/// <summary>
/// abs             0            ..FV.....T. weights trained to minimize absolute error
/// </summary>
[Name("abs")] abs,
/// <summary>
/// s               1            ..FV.....T. weights trained to minimize squared error
/// </summary>
[Name("s")] s,
/// <summary>
/// mse             1            ..FV.....T. weights trained to minimize squared error
/// </summary>
[Name("mse")] mse,
}

/// <summary>
///  set prescreening (from 0 to 4) (default new)
/// </summary>
public enum NnediFilterGenPscrn
{
/// <summary>
/// none            0            ..FV.....T.
/// </summary>
[Name("none")] none,
/// <summary>
/// original        1            ..FV.....T.
/// </summary>
[Name("original")] original,
/// <summary>
/// new             2            ..FV.....T.
/// </summary>
[Name("new")] _new,
/// <summary>
/// new2            3            ..FV.....T.
/// </summary>
[Name("new2")] new2,
/// <summary>
/// new3            4            ..FV.....T.
/// </summary>
[Name("new3")] new3,
}

}
