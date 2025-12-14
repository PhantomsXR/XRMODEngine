// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.GoapModue.UnityFusion.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Goap.Core;
using Goap.Runtime;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;

namespace UnityFusion.CLRBinding.Adapter
{
    public class WorldKeyBaseAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType => typeof(WorldKeyBase);

        public override Type AdaptorType => typeof(Adapter);

        public override object CreateCLRInstance(AppDomain appdomain, ILTypeInstance instance)
        {
            return new Adapter(appdomain, instance);
        }

        public class Adapter : WorldKeyBase, CrossBindingAdaptorType
        {

            bool isInvokingToString;
            ILTypeInstance instance;
            AppDomain appdomain;

            public Adapter()
            {

            }

            public Adapter(AppDomain appdomain, ILTypeInstance instance)
            {
                this.appdomain = appdomain;
                this.instance = instance;
            }

            public ILTypeInstance ILInstance { get { return instance; } }

            public override string ToString()
            {
                IMethod m = appdomain.ObjectType.GetMethod("ToString", 0);
                m = instance.Type.GetVirtualMethod(m);
                if (m == null || m is ILMethod)
                {
                    if (!isInvokingToString)
                    {
                        isInvokingToString = true;
                        string res = instance.ToString();
                        isInvokingToString = false;
                        return res;
                    }
                    else
                        return instance.Type.FullName;
                }
                else
                    return instance.Type.FullName;
            }
        }
    }
}