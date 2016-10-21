using System;

namespace SkeletonCode.CurrencyConverter
{
    [Serializable()]
    public class InvalidCurrencyException : System.Exception
    {
        public InvalidCurrencyException() : base() { }
        public InvalidCurrencyException(string message) : base(message) { }
        public InvalidCurrencyException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected InvalidCurrencyException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}
