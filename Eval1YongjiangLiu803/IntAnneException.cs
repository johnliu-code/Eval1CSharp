using System;
using System.Runtime.Serialization;

namespace Eval1YongjiangLiu803
{
    [Serializable]
    internal class IntAnneException : Exception
    {
        public IntAnneException()
        {
        }

        public IntAnneException(string message) : base(message)
        {
        }

        public IntAnneException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IntAnneException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}