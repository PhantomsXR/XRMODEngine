/*===============================================================================
Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XRMODEngineCore.Runtime.

The XRMOD-SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Base abstract class for modules that provide a specific feature or algorithm decorator.
    /// Handles the creation and registration of <see cref="IFeatureDecorator"/> instances.
    /// </summary>
    /// <typeparam name="T">The type of feature decorator to build (must implement <see cref="IFeatureDecorator"/>).</typeparam>
    public abstract class BaseBuildFeature<T> where T : IFeatureDecorator, new()
    {
        /// <summary>
        /// Creates or retrieves a registered feature instance and starts its core logic.
        /// </summary>
        /// <param name="_data">Optional initialization data to pass to the feature's constructor.</param>
        /// <returns>The created or updated feature decorator instance.</returns>
        protected T Create(params object[] _data)
        {
            T tmp_AlgorithmDecorator;

            if (CheckAlreadyDecorator(out var tmp_Decorator))
            {
                tmp_Decorator.StartAlgorithm();
                return (T) tmp_Decorator;
            }

            if (_data != null && _data.Length > 0) // Fixed checking condition for arguments
            {
                System.Type[] tmp_Types = new System.Type[_data.Length];
                for (int tmp_Idx = 0; tmp_Idx < tmp_Types.Length; tmp_Idx++)
                {
                    tmp_Types[tmp_Idx] = _data[tmp_Idx].GetType();
                }

                var tmp_Ctors = typeof(T).GetConstructor(tmp_Types);
                if (tmp_Ctors != null)
                {
                    tmp_AlgorithmDecorator = (T) tmp_Ctors.Invoke(_data);
                }
                else
                {
                    // Fallback to default constructor if specific ctor not found
                    tmp_AlgorithmDecorator = new T();
                }
            }
            else
            {
                tmp_AlgorithmDecorator = new T();
            }

            FeatureManager.AddFeature(typeof(T), tmp_AlgorithmDecorator);
            tmp_AlgorithmDecorator.StartAlgorithm();
            return tmp_AlgorithmDecorator;
        }

        /// <summary>
        /// Stops and releases the registered feature instance from the <see cref="FeatureManager"/>.
        /// </summary>
        protected void ReleaseFeature()
        {
            if (!CheckAlreadyDecorator(out var tmp_Feature)) return;
            tmp_Feature.StopAlgorithm();
            FeatureManager.RemoveValue(tmp_Feature.GetType());
        }

        private bool CheckAlreadyDecorator(out IFeatureDecorator _featureDecorator)
        {
            return FeatureManager.TryGetValue(typeof(T), out _featureDecorator);
        }
    }
}