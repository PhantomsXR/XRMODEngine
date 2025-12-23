/*===============================================================================
Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XRMODEngineCore.Runtime.

The XRMOD-SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System;
using System.Collections.Generic;

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Static manager for registering and managing high-level XRMOD features and algorithms.
    /// Acts as a central registry for feature decorators.
    /// </summary>
    public static class FeatureManager
    {
        internal static readonly Dictionary<Type, IFeatureDecorator> featureDecorators =
            new Dictionary<Type, IFeatureDecorator>();

        /// <summary>
        /// Registers a new feature with the manager.
        /// </summary>
        /// <param name="_featureType">The type of the feature to register.</param>
        /// <param name="_featureDecorator">The implementation instance of the feature.</param>
        /// <returns>True if the feature was successfully added; otherwise, false.</returns>
        public static bool AddFeature(Type _featureType, IFeatureDecorator _featureDecorator)
        {
            return featureDecorators.TryAdd(_featureType, _featureDecorator);
        }

        /// <summary>
        /// Attempts to retrieve a feature implementation by its type.
        /// </summary>
        /// <param name="_type">The type of the feature to look up.</param>
        /// <param name="_featureDecorator">When this method returns, contains the feature implementation if found; otherwise, null.</param>
        /// <returns>True if the feature was found; otherwise, false.</returns>
        public static bool TryGetValue(Type _type, out IFeatureDecorator _featureDecorator)
        {
            return featureDecorators.TryGetValue(_type, out _featureDecorator);
        }

        /// <summary>
        /// Removes a registered feature from the manager.
        /// </summary>
        /// <param name="_type">The type of the feature to remove.</param>
        /// <returns>True if the feature was successfully removed; otherwise, false.</returns>
        public static bool RemoveValue(Type _type)
        {
            return featureDecorators.Remove(_type);
        }

        /// <summary>
        /// Stops all registered features and clears the registry.
        /// Should be called during SDK shutdown or cleanup.
        /// </summary>
        public static void CleanUpFeatures()
        {
            foreach (KeyValuePair<Type, IFeatureDecorator> tmp_Decorator in featureDecorators)
            {
                tmp_Decorator.Value.StopAlgorithm();
            }

            featureDecorators.Clear();
        }
    }
}