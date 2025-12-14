using System;
using UnityEngine;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace UnityFusion.CLRBinding.Adapter
{
    public class IActionDataAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType => typeof(Goap.Agent.Core.IActionData);

        public override Type AdaptorType => typeof(Adapter);

        public override object CreateCLRInstance(UnityFusion.Runtime.Enviorment.AppDomain appdomain,
            ILTypeInstance instance)
        {
            return new Adapter(appdomain, instance);
        }

        public class Adapter : Goap.Agent.Core.IActionData, CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<Goap.Agent.Core.ITarget> mget_Target_0 = new("get_Target");

            CrossBindingMethodInfo<Goap.Agent.Core.ITarget> mset_Target_1 = new("set_Target");

            bool isInvokingToString;
            ILTypeInstance instance;
            UnityFusion.Runtime.Enviorment.AppDomain appdomain;

            public Adapter()
            {
            }

            public Adapter(Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
            {
                this.appdomain = appdomain;
                this.instance = instance;
            }

            public ILTypeInstance ILInstance => instance;

            public Goap.Agent.Core.ITarget Target
            {
                get => mget_Target_0.Invoke(this.instance);
                set => mset_Target_1.Invoke(this.instance, value);
            }

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