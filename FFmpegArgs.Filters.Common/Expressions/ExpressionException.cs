namespace FFmpegArgs.Filters.Exceptions
{
    /// <summary>
    /// 
    /// </summary>
    public class ExpressionException : Exception
    {
        internal ExpressionException(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class InvalidTokenExpressionException : ExpressionException
    {
        internal InvalidTokenExpressionException(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class InvalidInputExpressionException : ExpressionException
    {
        internal InvalidInputExpressionException(string message) : base(message)
        {
        }
    }
}
