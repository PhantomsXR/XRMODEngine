// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineCore.Runtime.
// //
// // The XRMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;

namespace Phantom.XRMOD.Core.Runtime
{
    public static class FeatureManager
    {
        internal static readonly Dictionary<Type, IFeatureDecorator> featureDecorators =
            new Dictionary<Type, IFeatureDecorator>();


        public static bool AddFeature(Type _featureType, IFeatureDecorator _featureDecorator)
        {
            return featureDecorators.TryAdd(_featureType, _featureDecorator);
        }

        public static bool TryGetValue(Type _type, out IFeatureDecorator _featureDecorator)
        {
            return featureDecorators.TryGetValue(_type, out _featureDecorator);
        }

        public static bool RemoveValue(Type _type)
        {
            return featureDecorators.Remove(_type);
        }


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