using System;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;

namespace  UnityFusion.CLRBinding.Adapter
{   
    public class IComparer_1_TransformAdapter : CrossBindingAdaptor
    {
        static CrossBindingFunctionInfo<UnityEngine.Transform, UnityEngine.Transform, System.Int32> mCompare_0 = new CrossBindingFunctionInfo<UnityEngine.Transform, UnityEngine.Transform, System.Int32>("Compare");
        public override Type BaseCLRType
        {
            get
            {
                return typeof(System.Collections.Generic.IComparer<UnityEngine.Transform>);
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

        public class Adapter : System.Collections.Generic.IComparer<UnityEngine.Transform>, CrossBindingAdaptorType
        {
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

            public System.Int32 Compare(UnityEngine.Transform x, UnityEngine.Transform y)
            {
                return mCompare_0.Invoke(this.instance, x, y);
            }

            public override string ToString()
            {
                IMethod m = appdomain.ObjectType.GetMethod("ToString", 0);
                m = instance.Type.GetVirtualMethod(m);
                if (m == null || m is ILMethod)
                {
                    return instance.ToString();
                }
                else
                    return instance.Type.FullName;
            }
        }
    }
}

