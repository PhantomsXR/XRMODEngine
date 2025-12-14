// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UXCore.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if USE_XRI

using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Utilities;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    /// <summary>
    /// Provides a means to smooth jittery <see cref="Vector3"/> signals.
    /// This filter is particularly effective for small and rapid movements,
    /// making it useful for applications like motion tracking or gesture recognition.
    /// </summary>
    /// <remarks>
    /// The filtering process relies on two main parameters: <c>minCutoff</c> and <c>beta</c>.
    /// <list type="bullet">
    /// <item>
    /// <term><c>minCutoff</c></term>
    /// <description> primarily influences the smoothing at low speeds.</description>
    /// </item>
    /// <item>
    /// <term><c>beta</c></term>
    /// <description> determines the filter's responsiveness to speed changes.</description>
    /// </item>
    /// </list>
    /// </remarks>
    public class OneEuroFilterVector3
    {
        Vector3 lastRawValue;
        Vector3 lastFilteredValue;
        readonly float minCutoff;
        readonly float beta;

        /// <summary>
        /// Initializes a new instance of the <see cref="OneEuroFilterVector3"/> with specified cutoff and beta values.
        /// </summary>
        /// <param name="_initialRawValue">The initial raw value for the filter.</param>
        /// <param name="_minCutoff">The minimum cutoff value for the filter. Default is 0.1f.</param>
        /// <param name="_beta">The beta value for the filter. Default is 0.02f.</param>
        /// <remarks>
        /// Filter parameters:
        /// <list type="bullet">
        /// <item>
        /// <term><paramref name="_minCutoff"/></term>
        /// <description>
        /// Controls the amount of smoothing at low speeds. A smaller value will introduce
        /// more smoothing and potential lag, helping to reduce low-frequency jitter. A larger value
        /// may feel more responsive but can let through more jitter. It's advised to start with a
        /// value around 0.1 for masking jitter in movements of about 1 cm.
        /// </description>
        /// </item>
        /// <item>
        /// <term><paramref name="_beta"/></term>
        /// <description>
        /// Determines the filter's adjustment to speed changes. A smaller value provides consistent
        /// smoothing, while a larger one introduces more aggressive adjustments for speed changes, offering
        /// responsive filtering at high speeds. A starting value of 0.02 is recommended, but fine-tuning
        /// might be necessary based on specific use cases.
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="Initialize"/>
        public OneEuroFilterVector3(Vector3 _initialRawValue, float _minCutoff = 0.1f, float _beta = 0.02f)
        {
            lastRawValue = _initialRawValue;
            lastFilteredValue = _initialRawValue;
            minCutoff = _minCutoff;
            beta = _beta;
        }

        /// <summary>
        /// Resets the initial raw value. Useful to recover from tracking loss.
        /// </summary>
        /// <param name="_initialRawValue">Raw value to reset filtering basis to.</param>
        public void Initialize(Vector3 _initialRawValue)
        {
            lastRawValue = _initialRawValue;
            lastFilteredValue = _initialRawValue;
        }

        /// <summary>
        /// Filters the given <see cref="Vector3"/> rawValue using the internal minCutoff and beta parameters.
        /// </summary>
        /// <param name="_rawValue">The raw <see cref="Vector3"/> value to be filtered.</param>
        /// <param name="_deltaTime">The time since the last filter update.</param>
        /// <returns>The filtered <see cref="Vector3"/> value.</returns>
        public Vector3 Filter(Vector3 _rawValue, float _deltaTime)
        {
            return Filter(_rawValue, _deltaTime, minCutoff, beta);
        }

        /// <summary>
        /// Filters the given <see cref="Vector3"/> rawValue using provided minCutoff and beta parameters.
        /// This method computes the speed of change in the signal and dynamically adjusts the amount of smoothing
        /// based on the speed and the provided minCutoff and beta values.
        /// </summary>
        /// <param name="_rawValue">The raw <see cref="Vector3"/> value to be filtered.</param>
        /// <param name="_deltaTime">The time since the last filter update.</param>
        /// <param name="_minCutoff">The minimum cutoff value for the filter. Influences the amount of smoothing at low speeds.</param>
        /// <param name="_beta">Determines the filter's adjustment to speed changes, influencing its responsiveness.</param>
        /// <returns>The filtered <see cref="Vector3"/> value.</returns>
        public Vector3 Filter(Vector3 _rawValue, float _deltaTime, float _minCutoff, float _beta)
        {
            // Calculate speed as a Vector3
            Vector3 tmp_Speed = (_rawValue - lastRawValue) / _deltaTime;

            // Compute cutoffs for x, y, and z
            Vector3 tmp_Cutoffs = new Vector3(_minCutoff, _minCutoff, _minCutoff);
            Vector3 tmp_BetaValues = new Vector3(_beta, _beta, _beta);

            // Incorporate speed into the cutoffs
            Vector3 tmp_CombinedCutoffs = tmp_Cutoffs + Vector3.Scale(tmp_BetaValues, tmp_Speed);

            // Compute alpha for x, y, and z
            BurstMathUtility.FastSafeDivide(Vector3.one, Vector3.one + tmp_CombinedCutoffs, out Vector3 alpha);

            Vector3 tmp_RawFiltered = Vector3.Scale(alpha, _rawValue);
            Vector3 tmp_LastFiltered = Vector3.Scale(Vector3.one - alpha, lastFilteredValue);

            // Calculate the final filtered value
            Vector3 tmp_FilteredValue = tmp_RawFiltered + tmp_LastFiltered;

            lastRawValue = _rawValue;
            lastFilteredValue = tmp_FilteredValue;

            return tmp_FilteredValue;
        }
    }
}

#endif