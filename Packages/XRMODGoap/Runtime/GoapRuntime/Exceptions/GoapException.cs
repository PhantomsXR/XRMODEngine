using System;

namespace Goap.Runtime
{
    public class GoapException : Exception
    {
        public GoapException(string message) : base(message)
        {
        }
    }
}