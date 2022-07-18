using System;
using System.Runtime.Serialization;

namespace exception
{
    [Serializable]
    internal class Login : Exception
    {
        public Login()
        {
        }

        public Login(string message) : base(message)
        {
        }

        public Login(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Login(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}