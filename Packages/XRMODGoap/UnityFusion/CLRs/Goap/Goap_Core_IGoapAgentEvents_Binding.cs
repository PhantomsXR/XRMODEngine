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
    unsafe class Goap_Core_IGoapAgentEvents_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Goap.Core.IGoapAgentEvents);
            args = new Type[]{typeof(Goap.Core.GoapActionDelegate)};
            method = type.GetMethod("add_OnActionEnd", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnActionEnd_0);
            args = new Type[]{typeof(Goap.Core.GoalRequestDelegate)};
            method = type.GetMethod("add_OnNoActionFound", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnNoActionFound_1);
            args = new Type[]{typeof(Goap.Core.GoalRequestDelegate)};
            method = type.GetMethod("remove_OnNoActionFound", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnNoActionFound_2);
            args = new Type[]{typeof(Goap.Core.GoapActionDelegate)};
            method = type.GetMethod("remove_OnActionEnd", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnActionEnd_3);


        }


        static StackObject* add_OnActionEnd_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Core.GoapActionDelegate @value = (Goap.Core.GoapActionDelegate)typeof(Goap.Core.GoapActionDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Core.IGoapAgentEvents instance_of_this_method = (Goap.Core.IGoapAgentEvents)typeof(Goap.Core.IGoapAgentEvents).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnActionEnd += value;

            return __ret;
        }

        static StackObject* add_OnNoActionFound_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Core.GoalRequestDelegate @value = (Goap.Core.GoalRequestDelegate)typeof(Goap.Core.GoalRequestDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Core.IGoapAgentEvents instance_of_this_method = (Goap.Core.IGoapAgentEvents)typeof(Goap.Core.IGoapAgentEvents).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNoActionFound += value;

            return __ret;
        }

        static StackObject* remove_OnNoActionFound_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Core.GoalRequestDelegate @value = (Goap.Core.GoalRequestDelegate)typeof(Goap.Core.GoalRequestDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Core.IGoapAgentEvents instance_of_this_method = (Goap.Core.IGoapAgentEvents)typeof(Goap.Core.IGoapAgentEvents).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNoActionFound -= value;

            return __ret;
        }

        static StackObject* remove_OnActionEnd_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Core.GoapActionDelegate @value = (Goap.Core.GoapActionDelegate)typeof(Goap.Core.GoapActionDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Core.IGoapAgentEvents instance_of_this_method = (Goap.Core.IGoapAgentEvents)typeof(Goap.Core.IGoapAgentEvents).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnActionEnd -= value;

            return __ret;
        }



    }
}
