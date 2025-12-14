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
    unsafe class Goap_Agent_Core_IAgentEvents_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Goap.Agent.Core.IAgentEvents);
            args = new Type[]{typeof(Goap.Agent.Core.TargetDelegate)};
            method = type.GetMethod("add_OnTargetInRange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnTargetInRange_0);
            args = new Type[]{typeof(Goap.Agent.Core.TargetRangeDelegate)};
            method = type.GetMethod("add_OnTargetChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnTargetChanged_1);
            args = new Type[]{typeof(Goap.Agent.Core.TargetDelegate)};
            method = type.GetMethod("add_OnTargetNotInRange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnTargetNotInRange_2);
            args = new Type[]{typeof(Goap.Agent.Core.EmptyDelegate)};
            method = type.GetMethod("add_OnTargetLost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnTargetLost_3);
            args = new Type[]{typeof(Goap.Agent.Core.TargetDelegate)};
            method = type.GetMethod("remove_OnTargetInRange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnTargetInRange_4);
            args = new Type[]{typeof(Goap.Agent.Core.TargetRangeDelegate)};
            method = type.GetMethod("remove_OnTargetChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnTargetChanged_5);
            args = new Type[]{typeof(Goap.Agent.Core.TargetDelegate)};
            method = type.GetMethod("remove_OnTargetNotInRange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnTargetNotInRange_6);
            args = new Type[]{typeof(Goap.Agent.Core.EmptyDelegate)};
            method = type.GetMethod("remove_OnTargetLost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnTargetLost_7);


        }


        static StackObject* add_OnTargetInRange_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.TargetDelegate @value = (Goap.Agent.Core.TargetDelegate)typeof(Goap.Agent.Core.TargetDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IAgentEvents instance_of_this_method = (Goap.Agent.Core.IAgentEvents)typeof(Goap.Agent.Core.IAgentEvents).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnTargetInRange += value;

            return __ret;
        }

        static StackObject* add_OnTargetChanged_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.TargetRangeDelegate @value = (Goap.Agent.Core.TargetRangeDelegate)typeof(Goap.Agent.Core.TargetRangeDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IAgentEvents instance_of_this_method = (Goap.Agent.Core.IAgentEvents)typeof(Goap.Agent.Core.IAgentEvents).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnTargetChanged += value;

            return __ret;
        }

        static StackObject* add_OnTargetNotInRange_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.TargetDelegate @value = (Goap.Agent.Core.TargetDelegate)typeof(Goap.Agent.Core.TargetDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IAgentEvents instance_of_this_method = (Goap.Agent.Core.IAgentEvents)typeof(Goap.Agent.Core.IAgentEvents).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnTargetNotInRange += value;

            return __ret;
        }

        static StackObject* add_OnTargetLost_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.EmptyDelegate @value = (Goap.Agent.Core.EmptyDelegate)typeof(Goap.Agent.Core.EmptyDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IAgentEvents instance_of_this_method = (Goap.Agent.Core.IAgentEvents)typeof(Goap.Agent.Core.IAgentEvents).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnTargetLost += value;

            return __ret;
        }

        static StackObject* remove_OnTargetInRange_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.TargetDelegate @value = (Goap.Agent.Core.TargetDelegate)typeof(Goap.Agent.Core.TargetDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IAgentEvents instance_of_this_method = (Goap.Agent.Core.IAgentEvents)typeof(Goap.Agent.Core.IAgentEvents).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnTargetInRange -= value;

            return __ret;
        }

        static StackObject* remove_OnTargetChanged_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.TargetRangeDelegate @value = (Goap.Agent.Core.TargetRangeDelegate)typeof(Goap.Agent.Core.TargetRangeDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IAgentEvents instance_of_this_method = (Goap.Agent.Core.IAgentEvents)typeof(Goap.Agent.Core.IAgentEvents).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnTargetChanged -= value;

            return __ret;
        }

        static StackObject* remove_OnTargetNotInRange_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.TargetDelegate @value = (Goap.Agent.Core.TargetDelegate)typeof(Goap.Agent.Core.TargetDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IAgentEvents instance_of_this_method = (Goap.Agent.Core.IAgentEvents)typeof(Goap.Agent.Core.IAgentEvents).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnTargetNotInRange -= value;

            return __ret;
        }

        static StackObject* remove_OnTargetLost_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.EmptyDelegate @value = (Goap.Agent.Core.EmptyDelegate)typeof(Goap.Agent.Core.EmptyDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IAgentEvents instance_of_this_method = (Goap.Agent.Core.IAgentEvents)typeof(Goap.Agent.Core.IAgentEvents).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnTargetLost -= value;

            return __ret;
        }



    }
}
