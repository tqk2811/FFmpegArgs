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
    }
}
