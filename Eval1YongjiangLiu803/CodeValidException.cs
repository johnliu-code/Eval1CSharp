using System;
using System.Runtime.Serialization;

namespace Eval1YongjiangLiu803
{
    [Serializable]
    internal class CodeValidException : Exception
    {
        public CodeValidException()
        {
        }

        public CodeValidException(string message) : base(message)
        {
        }

        public CodeValidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CodeValidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}