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

    internal class InvalidFormat : SumCompareException
    {
        public InvalidFormat() : base() { }

        public InvalidFormat(string? message) : base(message) { }

        public InvalidFormat(string? message, Exception? innerException) : base(message, innerException) { }

        protected InvalidFormat(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

    internal class FileError : SumCompareException
    {
        public FileError() : base() { }

        public FileError(string? message) : base(message) { }

        public FileError(string? message, Exception? innerException) : base(message, innerException) { }

        protected FileError(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
