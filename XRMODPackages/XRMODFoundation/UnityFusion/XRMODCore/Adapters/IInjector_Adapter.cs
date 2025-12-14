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
    public class IInjectorAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get
            {
                return typeof(VContainer.IInjector);
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

        public class Adapter : VContainer.IInjector, CrossBindingAdaptorType
        {
            CrossBindingMethodInfo<System.Object, VContainer.IObjectResolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter>> mInject_0 = new CrossBindingMethodInfo<System.Object, VContainer.IObjectResolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter>>("Inject");
            CrossBindingFunctionInfo<VContainer.IObjectResolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter>, System.Object> mCreateInstance_1 = new CrossBindingFunctionInfo<VContainer.IObjectResolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter>, System.Object>("CreateInstance");

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

            public void Inject(System.Object instance, VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters)
            {
                mInject_0.Invoke(this.instance, instance, resolver, parameters);
            }

            public System.Object CreateInstance(VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters)
            {
                return mCreateInstance_1.Invoke(this.instance, resolver, parameters);
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

