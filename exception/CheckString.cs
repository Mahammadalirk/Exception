using System;
using System.Runtime.Serialization;

namespace exception
{
    [Serializable]
    internal class CheckString : Exception
    {
        public CheckString()
        {
        }

        public CheckString(string message) : base(message)
        {
        }

        public CheckString(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CheckString(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}