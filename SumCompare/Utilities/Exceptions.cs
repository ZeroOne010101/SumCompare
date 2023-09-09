using System;
using System.Runtime.Serialization;

namespace SumCompare.Utilities
{
    internal class SumCompareException : Exception
    {
        public SumCompareException() : base() { }

        public SumCompareException(string? message) : base(message) { }

        public SumCompareException(string? message, Exception? innerException) : base(message, innerException) { }

        protected SumCompareException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

    internal class InvalidFilePath : SumCompareException
    {
        public InvalidFilePath() : base() { }

        public InvalidFilePath(string? message) : base(message) { }

        public InvalidFilePath(string? message, Exception? innerException) : base(message, innerException) { }

        protected InvalidFilePath(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
