using System;
namespace FFmpegArgs.Expressions
{
    /// <summary>
    /// 
    /// </summary>
    public static class ExpressionExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static FFmpegExpression Run(this Action<FFmpegExpression> action, FFmpegExpression expression)
        {
            action?.Invoke(expression);
            return expression;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Action<FFmpegExpression> Expression(this string str)
          => new Action<FFmpegExpression>(_e => _e.Check(str));
    }
}
