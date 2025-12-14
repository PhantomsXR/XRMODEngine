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

namespace Phantom.XRMOD.Core.Runtime
{
    public abstract class BaseBuildFeature<T> where T : IFeatureDecorator, new()
    {
        protected T Create(params object[] _data)
        {
            T tmp_AlgorithmDecorator;

            if (CheckAlreadyDecorator(out var tmp_Decorator))
            {
                tmp_Decorator.StartAlgorithm();
                return (T) tmp_Decorator;
            }

            if (_data != null && _data.Length == 0)
            {
                System.Type[] tmp_Types = new System.Type[_data.Length];
                for (int tmp_Idx = 0; tmp_Idx < tmp_Types.Length; tmp_Idx++)
                {
                    tmp_Types[tmp_Idx] = _data[tmp_Idx].GetType();
                }

                var tmp_Ctors = typeof(T).GetConstructor(tmp_Types);
                tmp_AlgorithmDecorator = (T) tmp_Ctors.Invoke(_data);
            }
            else
            {
                tmp_AlgorithmDecorator = new T();
            }

            FeatureManager.AddFeature(typeof(T), tmp_AlgorithmDecorator);
            tmp_AlgorithmDecorator.StartAlgorithm();
            return tmp_AlgorithmDecorator;
        }

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