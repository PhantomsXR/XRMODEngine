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
    unsafe class UnityEngine_Splines_ISplineContainer_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Splines.ISplineContainer);
            args = new Type[]{};
            method = type.GetMethod("get_Splines", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Splines_0);
            args = new Type[]{typeof(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline>)};
            method = type.GetMethod("set_Splines", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Splines_1);
            args = new Type[]{};
            method = type.GetMethod("get_KnotLinkCollection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_KnotLinkCollection_2);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Splines.ISplineContainer[s]);


        }


        static StackObject* get_Splines_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.ISplineContainer instance_of_this_method = (UnityEngine.Splines.ISplineContainer)typeof(UnityEngine.Splines.ISplineContainer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Splines;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Splines_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> @value = (System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline>)typeof(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.ISplineContainer instance_of_this_method = (UnityEngine.Splines.ISplineContainer)typeof(UnityEngine.Splines.ISplineContainer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Splines = value;

            return __ret;
        }

        static StackObject* get_KnotLinkCollection_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.ISplineContainer instance_of_this_method = (UnityEngine.Splines.ISplineContainer)typeof(UnityEngine.Splines.ISplineContainer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.KnotLinkCollection;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
