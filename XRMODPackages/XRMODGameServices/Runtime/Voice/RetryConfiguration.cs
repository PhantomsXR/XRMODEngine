using System;

namespace Phantom.XRMOD.GameServices.Runtime
{
    /// <summary>
    /// Configuration class for retry mechanism in voice services.
    /// Defines parameters for exponential backoff retry strategy.
    /// </summary>
    [Serializable]
    public class RetryConfiguration
    {
        /// <summary>
        /// Maximum number of retry attempts before giving up.
        /// Default: 3 attempts
        /// </summary>
        public int MaxRetryCount = 3;

        /// <summary>
        /// Initial delay in milliseconds before the first retry attempt.
        /// Default: 1000ms (1 second)
        /// </summary>
        public int InitialDelayMs = 1000;

        /// <summary>
        /// Maximum delay in milliseconds between retry attempts.
        /// Default: 10000ms (10 seconds)
        /// </summary>
        public int MaxDelayMs = 10000;

        /// <summary>
        /// Multiplier for exponential backoff calculation.
        /// Each retry delay = min(InitialDelayMs * (BackoffMultiplier ^ attemptNumber), MaxDelayMs)
        /// Default: 2.0
        /// </summary>
        public float BackoffMultiplier = 2.0f;

        /// <summary>
        /// Overall timeout in milliseconds for the entire initialization process.
        /// If exceeded, all operations are cancelled and failure is reported.
        /// Default: 30000ms (30 seconds)
        /// </summary>
        public int OverallTimeoutMs = 30000;

        /// <summary>
        /// Creates a new RetryConfiguration with default values.
        /// </summary>
        public RetryConfiguration()
        {
            // Default values are set via field initializers above
        }

        /// <summary>
        /// Creates a new RetryConfiguration with custom values.
        /// </summary>
        /// <param name="maxRetryCount">Maximum number of retry attempts</param>
        /// <param name="initialDelayMs">Initial delay in milliseconds</param>
        /// <param name="maxDelayMs">Maximum delay in milliseconds</param>
        /// <param name="backoffMultiplier">Exponential backoff multiplier</param>
        /// <param name="overallTimeoutMs">Overall timeout in milliseconds</param>
        public RetryConfiguration(int maxRetryCount, int initialDelayMs, int maxDelayMs, 
                                  float backoffMultiplier, int overallTimeoutMs)
        {
            MaxRetryCount = maxRetryCount;
            InitialDelayMs = initialDelayMs;
            MaxDelayMs = maxDelayMs;
            BackoffMultiplier = backoffMultiplier;
            OverallTimeoutMs = overallTimeoutMs;
        }
    }
}