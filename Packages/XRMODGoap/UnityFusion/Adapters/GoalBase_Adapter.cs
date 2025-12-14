using System;
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
    public class GoalBaseAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get
            {
                return typeof(Goap.Runtime.GoalBase);
            }
        }

        public override Type AdaptorType
        {
            get
            {
                return typeof(Adapter);
            }
        }

        public override object CreateCLRInstance(UnityFusion.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
        {
            return new Adapter(appdomain, instance);
        }

        public class Adapter : Goap.Runtime.GoalBase, CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference, System.Single> mGetCost_0 = new CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference, System.Single>("GetCost");

            bool isInvokingToString;
            ILTypeInstance instance;
            UnityFusion.Runtime.Enviorment.AppDomain appdomain;

            public Adapter()
            {

            }

            public Adapter(UnityFusion.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
            {
                this.appdomain = appdomain;
                this.instance = instance;
            }

            public ILTypeInstance ILInstance { get { return instance; } }

            public override System.Single GetCost(Goap.Agent.Core.IActionReceiver agent, Goap.Agent.Core.IComponentReference references)
            {
                if (mGetCost_0.CheckShouldInvokeBase(this.instance))
                    return base.GetCost(agent, references);
                else
                    return mGetCost_0.Invoke(this.instance, agent, references);
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

