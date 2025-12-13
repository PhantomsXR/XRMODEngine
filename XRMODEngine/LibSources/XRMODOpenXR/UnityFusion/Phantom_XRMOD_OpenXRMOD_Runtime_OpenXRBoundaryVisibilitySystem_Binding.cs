#if QUEST_INSTALL

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
    unsafe class Phantom_XRMOD_OpenXRMOD_Runtime_OpenXRBoundaryVisibilitySystem_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.OpenXRMOD.Runtime.OpenXRBoundaryVisibilitySystem);
            args = new Type[]{};
            method = type.GetMethod("get_OnBoundaryVisibilityChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_OnBoundaryVisibilityChanged_0);
            args = new Type[]{typeof(Phantom.XRMOD.OpenXRMOD.Runtime.XrBoundaryVisibility)};
            method = type.GetMethod("ChangeBoundaryVisibility", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ChangeBoundaryVisibility_1);





        }


        static StackObject* get_OnBoundaryVisibilityChanged_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.OpenXRMOD.Runtime.OpenXRBoundaryVisibilitySystem.OnBoundaryVisibilityChanged;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ChangeBoundaryVisibility_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.OpenXRMOD.Runtime.XrBoundaryVisibility @_boundaryVisibility = (Phantom.XRMOD.OpenXRMOD.Runtime.XrBoundaryVisibility)typeof(Phantom.XRMOD.OpenXRMOD.Runtime.XrBoundaryVisibility).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.OpenXRMOD.Runtime.OpenXRBoundaryVisibilitySystem.ChangeBoundaryVisibility(@_boundaryVisibility);

            return __ret;
        }





    }
}
#endif