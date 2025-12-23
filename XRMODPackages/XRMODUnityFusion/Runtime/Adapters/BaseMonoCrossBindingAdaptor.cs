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
    /// <summary>
    /// Base class for all MonoBehaviour-based cross-binding adapters.
    /// Facilitates the mapping between a Unity GameObject and an ILRuntime/CLR instance.
    /// </summary>
    public class BaseMonoCrossBindingAdaptor :XRMODBehaviour, CrossBindingAdaptorType
    {
        /// <summary> The associated ILRuntime/CLR instance. </summary>
        protected ILTypeInstance instance;
        /// <summary> The AppDomain where the instance resides. </summary>
        protected AppDomain appdomain;
        
        /// <summary>
        /// Initializes a new instance of the adapter.
        /// </summary>
        /// <param name="_appdomain">The source AppDomain.</param>
        /// <param name="_instance">The hot-reload instance.</param>
        public BaseMonoCrossBindingAdaptor(AppDomain _appdomain, ILTypeInstance _instance)
        {
            this.appdomain = _appdomain;
            this.instance = _instance;
        }

        /// <summary> Gets or sets the ILRuntime instance. </summary>
        public ILTypeInstance ILInstance
        {
            get => instance;
            set => instance = value;
        }

        /// <summary> Gets or sets the associated AppDomain. </summary>
        public UnityFusion.Runtime.Enviorment.AppDomain AppDomain
        {
            get => appdomain;
            set => appdomain = value;
        }
        
        /// <summary> Default constructor. </summary>
        public BaseMonoCrossBindingAdaptor(){}
    }
}