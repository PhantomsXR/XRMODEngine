// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the UnityFusion.Adapter.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using Phantom.XRMOD.Core.Runtime;

namespace UnityFusion.CLRBinding.Adapter
{
    public class BaseMonoCrossBindingAdaptor :XRMODBehaviour, CrossBindingAdaptorType
    {
        protected ILTypeInstance instance;
        protected AppDomain appdomain;
        
        public BaseMonoCrossBindingAdaptor(AppDomain _appdomain, ILTypeInstance _instance)
        {
            this.appdomain = _appdomain;
            this.instance = _instance;
        }

        public ILTypeInstance ILInstance
        {
            get => instance;
            set => instance = value;
        }

        public UnityFusion.Runtime.Enviorment.AppDomain AppDomain
        {
            get => appdomain;
            set => appdomain = value;
        }
        public BaseMonoCrossBindingAdaptor(){}
    }
}