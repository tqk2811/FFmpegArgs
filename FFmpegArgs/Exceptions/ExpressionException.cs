using System;

namespace FFmpegArgs.Exceptions
{
    public class ExpressionException : Exception
    {
        internal ExpressionException(string message) : base(message)
        {

        }
    }

    public class InvalidTokenExpressionException : ExpressionException
    {
        internal InvalidTokenExpressionException(string message) : base(message)
        {

        }
    }

    public class InvalidInputExpressionException : ExpressionException
    {
        internal InvalidInputExpressionException(string message) : base(message)
        {

        }
    }
}
