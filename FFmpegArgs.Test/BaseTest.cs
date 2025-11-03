using System.Globalization;
using System.Threading;

namespace FFmpegArgs.Test
{
    public class BaseTest
    {
        static BaseTest()
        {
            CultureInfo viVN = new CultureInfo("vi-VN");
            CultureInfo Turkish = new CultureInfo("tr-TR");
            CultureInfo cultureInfo = Turkish;

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
    }
}
