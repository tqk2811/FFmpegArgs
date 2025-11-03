namespace FFmpegArgs
{
    /// <summary>
    /// 
    /// </summary>
    public static class UtilsExtension
    {
        /// <summary>
        /// Do the action when condition is true
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="condition"></param>
        /// <param name="action"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public static T AndSetIf<T>(this T t, bool condition, Action<T> action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));
            if (condition) action.Invoke(t);
            return t;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static T AndSet<T>(this T t, Action<T> action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));
            action.Invoke(t);
            return t;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static int EnsureOdd(this int input)
        {
            if (input % 2 == 0) throw new InvalidOperationException("required input odd");
            return input;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static int EnsureEven(this int input)
        {
            if (input % 2 != 0) throw new InvalidOperationException("required input even");
            return input;
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static string ToFFmpegFlag(this bool flag)
            => flag ? "1" : "0";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string ToHexStringRGB(this Color color)
            => Inv($"0x{color.R:X2}{color.G:X2}{color.B:X2}");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string ToHexStringRGBA(this Color color)
            => Inv($"0x{color.R:X2}{color.G:X2}{color.B:X2}{color.A:X2}");

        /// <summary>
        /// <see href="https://ffmpeg.org/ffmpeg-utils.html#date-syntax"/>
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string ToFFmpegDate(this DateTime dateTime)
            => dateTime.ToStringInv("yyyy-MM-dd HH:mm:ss");



    }
}
