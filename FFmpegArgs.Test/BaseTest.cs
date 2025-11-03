using System.Globalization;
using System.Threading;

namespace FFmpegArgs.Test
{
    public class BaseTest
    {
        static BaseTest()
        {
            CultureInfo viVN = new CultureInfo("vi-VN");
            CultureInfo.DefaultThreadCurrentCulture = viVN;
            CultureInfo.DefaultThreadCurrentUICulture = viVN;
            Thread.CurrentThread.CurrentCulture = viVN;
            Thread.CurrentThread.CurrentUICulture = viVN;
        }
    }
}
