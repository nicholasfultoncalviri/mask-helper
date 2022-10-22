namespace MaskHelper.Core.Exceptions
{
    public class MaskHelperException : Exception
    {
        public MaskHelperException()
        { }

        public MaskHelperException(string? message)
            : base(message)
        { }

        public MaskHelperException(string? message, Exception? innerException)
            : base(message, innerException)
        { }
    }
}
