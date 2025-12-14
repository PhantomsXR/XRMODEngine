using System;

namespace Goap.Agent.Runtime
{
    public class AgentException : Exception
    {
        public AgentException(string message) : base(message)
        {
        }
    }
}