using System;
using System.Collections.Generic;
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
    unsafe class UnityFusion_CLRBinding_Adapter_ScriptableCapabilityFactoryBaseAdapter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityFusion.CLRBinding.Adapter.ScriptableCapabilityFactoryBaseAdapter);
            args = new Type[]{};
            method = type.GetMethod("get_BaseCLRType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_BaseCLRType_0);
            args = new Type[]{};
            method = type.GetMethod("get_AdaptorType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AdaptorType_1);
            args = new Type[]{typeof(UnityFusion.Runtime.Enviorment.AppDomain), typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)};
            method = type.GetMethod("CreateCLRInstance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateCLRInstance_2);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityFusion.CLRBinding.Adapter.ScriptableCapabilityFactoryBaseAdapter());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityFusion.CLRBinding.Adapter.ScriptableCapabilityFactoryBaseAdapter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_BaseCLRType_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityFusion.CLRBinding.Adapter.ScriptableCapabilityFactoryBaseAdapter instance_of_this_method = (UnityFusion.CLRBinding.Adapter.ScriptableCapabilityFactoryBaseAdapter)typeof(UnityFusion.CLRBinding.Adapter.ScriptableCapabilityFactoryBaseAdapter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.BaseCLRType;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_AdaptorType_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityFusion.CLRBinding.Adapter.ScriptableCapabilityFactoryBaseAdapter instance_of_this_method = (UnityFusion.CLRBinding.Adapter.ScriptableCapabilityFactoryBaseAdapter)typeof(UnityFusion.CLRBinding.Adapter.ScriptableCapabilityFactoryBaseAdapter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AdaptorType;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateCLRInstance_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityFusion.Runtime.Intepreter.ILTypeInstance @instance = (UnityFusion.Runtime.Intepreter.ILTypeInstance)typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityFusion.Runtime.Enviorment.AppDomain @appdomain = (UnityFusion.Runtime.Enviorment.AppDomain)typeof(UnityFusion.Runtime.Enviorment.AppDomain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityFusion.CLRBinding.Adapter.ScriptableCapabilityFactoryBaseAdapter instance_of_this_method = (UnityFusion.CLRBinding.Adapter.ScriptableCapabilityFactoryBaseAdapter)typeof(UnityFusion.CLRBinding.Adapter.ScriptableCapabilityFactoryBaseAdapter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreateCLRInstance(@appdomain, @instance);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance, true);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method, true);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityFusion.CLRBinding.Adapter.ScriptableCapabilityFactoryBaseAdapter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
