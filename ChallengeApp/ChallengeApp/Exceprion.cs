using System.Runtime.Serialization;

namespace ChallengeApp
{
    [Serializable]
    internal class Exceprion : Exception
    {
        public Exceprion()
        {
        }

        public Exceprion(string? message) : base(message)
        {
        }

        public Exceprion(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected Exceprion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}