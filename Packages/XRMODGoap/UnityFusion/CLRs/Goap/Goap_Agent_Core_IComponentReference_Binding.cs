using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using UnityFusion.Reflection;
using UnityFusion.CLR.Utils;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif
namespace UnityFusion.Runtime.Generated
{
    unsafe class Goap_Agent_Core_IComponentReference_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            MethodBase method;
            Type[] args;
            Type type = typeof(Goap.Agent.Core.IComponentReference);
            Dictionary<string, List<MethodInfo>> genericMethods = new Dictionary<string, List<MethodInfo>>();
            List<MethodInfo> lst = null;
            foreach (var m in type.GetMethods())
            {
                if (m.IsGenericMethodDefinition)
                {
                    if (!genericMethods.TryGetValue(m.Name, out lst))
                    {
                        lst = new List<MethodInfo>();
                        genericMethods[m.Name] = lst;
                    }

                    lst.Add(m);
                }
            }

            args = new Type[] {typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter)};
            if (genericMethods.TryGetValue("GetCachedComponent", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args,
                            typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, GetCachedComponent_0);

                        break;
                    }
                }
            }
        }


        static StackObject* GetCachedComponent_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.IComponentReference instance_of_this_method =
                (Goap.Agent.Core.IComponentReference) typeof(Goap.Agent.Core.IComponentReference).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_GenericArgumentType = __method.GenericArguments.First();
            object result_of_this_method;
            if (tmp_GenericArgumentType is CLRType)
            {
                result_of_this_method = instance_of_this_method.GetCachedComponent(tmp_GenericArgumentType.TypeForCLR);
            }
            else
            {
                result_of_this_method = instance_of_this_method.GetCachedComponent(tmp_GenericArgumentType.ReflectionType);
            }
 
            if (result_of_this_method is CrossBindingAdaptorType tmp_Type)
            {
                return ILIntepreter.PushObject(__ret, __mStack, tmp_Type.ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}