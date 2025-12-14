using System;
using System.Reflection;
using Goap.Agent.Core;
using Phantom.XRMOD.UnityFusion.Runtime;
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
    public class LocalTargetSensorBaseAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType => typeof(Goap.Runtime.LocalTargetSensorBase);

        public override Type AdaptorType => typeof(Adapter);

        public override object CreateCLRInstance(UnityFusion.Runtime.Enviorment.AppDomain appdomain,
            ILTypeInstance instance)
        {
            return new Adapter(appdomain, instance);
        }

        public class Adapter : Goap.Runtime.LocalTargetSensorBase, CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<Goap.Core.ISensorTimer> mget_Timer_0 =
                new CrossBindingFunctionInfo<Goap.Core.ISensorTimer>("get_Timer");

            CrossBindingMethodInfo mCreated_1 = new CrossBindingMethodInfo("Created");
            CrossBindingMethodInfo mUpdate_2 = new CrossBindingMethodInfo("Update");

            CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference,
                Goap.Agent.Core.ITarget, Goap.Agent.Core.ITarget> mSense_3 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference,
                    Goap.Agent.Core.ITarget, Goap.Agent.Core.ITarget>("Sense");

            bool isInvokingToString;
            ILTypeInstance instance;
            UnityFusion.Runtime.Enviorment.AppDomain appdomain;

            public Adapter()
            {
                appdomain = CodesHook.GetAppDomain;
            }

            public Adapter(UnityFusion.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
            {
                this.appdomain = appdomain;
                this.instance = instance;
            }

            public ILTypeInstance ILInstance
            {
                get { return instance; }
            }

            public override void Created()
            {
                mCreated_1.Invoke(this.instance);
            }

            public override void Update()
            {
                mUpdate_2.Invoke(this.instance);
            }

            private MethodInfo senseMethod;
            private readonly object[] senseMethodParam = new object[3];

            public override Goap.Agent.Core.ITarget Sense(Goap.Agent.Core.IActionReceiver agent,
                Goap.Agent.Core.IComponentReference references, Goap.Agent.Core.ITarget existingTarget)
            {
                senseMethodParam[0] = agent;
                senseMethodParam[1] = references;
                senseMethodParam[2] = existingTarget;

                if (senseMethod == null)
                    senseMethod = instance.Type.ReflectionType.GetMethod(nameof(Sense));

                if (senseMethod != null)
                {
                    var tmp_Result = senseMethod.Invoke(instance.CLRInstance, senseMethodParam);
                    if (tmp_Result is ITargetAdapter.Adapter tmp_Adapter)
                        return tmp_Adapter;
                    return tmp_Result as ITarget;
                }

                // var tmp_Data = mCreateData_5.Invoke(this.instance);
                // return tmp_Data;
                return mSense_3.Invoke(this.instance, agent, references, existingTarget);
            }

            public override Goap.Core.ISensorTimer Timer
            {
                get
                {
                    if (mget_Timer_0.CheckShouldInvokeBase(this.instance))
                        return base.Timer;
                    else
                        return mget_Timer_0.Invoke(this.instance);
                }
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