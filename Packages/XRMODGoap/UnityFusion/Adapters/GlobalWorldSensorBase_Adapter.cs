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
    public class GlobalWorldSensorBaseAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get
            {
                return typeof(Goap.Runtime.GlobalWorldSensorBase);
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

        public class Adapter : Goap.Runtime.GlobalWorldSensorBase, CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<Goap.Core.ISensorTimer> mget_Timer_0 = new CrossBindingFunctionInfo<Goap.Core.ISensorTimer>("get_Timer");
            CrossBindingMethodInfo mCreated_1 = new CrossBindingMethodInfo("Created");
            CrossBindingFunctionInfo<Goap.Core.SenseValue> mSense_2 = new CrossBindingFunctionInfo<Goap.Core.SenseValue>("Sense");

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

            public override void Created()
            {
                mCreated_1.Invoke(this.instance);
            }

            public override Goap.Core.SenseValue Sense()
            {
                return mSense_2.Invoke(this.instance);
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

