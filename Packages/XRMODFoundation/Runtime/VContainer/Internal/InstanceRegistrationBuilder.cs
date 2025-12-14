using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Phantom.XRMOD.UnityFusion.Runtime;
using UnityFusion.CLRBinding.Adapter;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;

namespace VContainer.Internal
{
    sealed class InstanceRegistrationBuilder : RegistrationBuilder
    {
        readonly object implementationInstance;

        private static System.Type GetImplementationType(object _obj, Type implementationType = null)
        {
#if ENABLE_UNITYFUSION
            if (CodesHook.GetAppDomain != null)
            {
                if (_obj is ILTypeInstance tmp_ILTypeInstance)
                {
                    return tmp_ILTypeInstance.Type.ReflectionType;
                }
                else if (_obj is XRMODBehaviourAdapter.Adapter tmp_Adapter)
                {
                    return tmp_Adapter.ILInstance.Type.ReflectionType;
                }
                else if (_obj is IList tmp_Array)
                {
                    if (tmp_Array.Count > 0 && tmp_Array.GetType().GetElementType() == typeof(ILTypeInstance))
                    {
                        if (tmp_Array[0] == null)
                            return implementationType;
                        var tmp_Value = tmp_Array[0] as ILTypeInstance;
                        return tmp_Value.Type.ReflectionType;
                    }
                    else if (tmp_Array.Count > 0 &&
                             tmp_Array.GetType().GetElementType() == typeof(XRMODBehaviourAdapter.Adapter))
                    {
                        var tmp_Value = tmp_Array[0] as XRMODBehaviourAdapter.Adapter;
                        return tmp_Value ? tmp_Value.ILInstance.Type.ReflectionType : implementationType;
                    }
                   
                }
            }

            return _obj.GetType();
#else
            return _obj.GetType();
#endif
        }

        public InstanceRegistrationBuilder(object implementationInstance, Type implementationType = null)
            : base(GetImplementationType(implementationInstance, implementationType), Lifetime.Singleton)
        {
            this.implementationInstance = implementationInstance;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Registration Build()
        {
            var spawner = new ExistingInstanceProvider(implementationInstance);
            return new Registration(ImplementationType, Lifetime, InterfaceTypes, spawner, Key);
        }
    }
}