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
    unsafe class Unity_PolySpatial_VolumeCameraWindowConfiguration_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Unity.PolySpatial.VolumeCameraWindowConfiguration);
            args = new Type[]{};
            method = type.GetMethod("get_Mode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Mode_0);
            args = new Type[]{};
            method = type.GetMethod("get_Dimensions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Dimensions_1);
            args = new Type[]{};
            method = type.GetMethod("get_WindowResizeLimits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_WindowResizeLimits_2);
            args = new Type[]{};
            method = type.GetMethod("get_MinWindowSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MinWindowSize_3);
            args = new Type[]{};
            method = type.GetMethod("get_MaxWindowSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxWindowSize_4);
            args = new Type[]{};
            method = type.GetMethod("get_WorldAlignment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_WorldAlignment_5);



            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.PolySpatial.VolumeCameraWindowConfiguration());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.PolySpatial.VolumeCameraWindowConfiguration[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Mode_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCameraWindowConfiguration instance_of_this_method = (Unity.PolySpatial.VolumeCameraWindowConfiguration)typeof(Unity.PolySpatial.VolumeCameraWindowConfiguration).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Mode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Dimensions_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCameraWindowConfiguration instance_of_this_method = (Unity.PolySpatial.VolumeCameraWindowConfiguration)typeof(Unity.PolySpatial.VolumeCameraWindowConfiguration).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Dimensions;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_WindowResizeLimits_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCameraWindowConfiguration instance_of_this_method = (Unity.PolySpatial.VolumeCameraWindowConfiguration)typeof(Unity.PolySpatial.VolumeCameraWindowConfiguration).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.WindowResizeLimits;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_MinWindowSize_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCameraWindowConfiguration instance_of_this_method = (Unity.PolySpatial.VolumeCameraWindowConfiguration)typeof(Unity.PolySpatial.VolumeCameraWindowConfiguration).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MinWindowSize;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_MaxWindowSize_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCameraWindowConfiguration instance_of_this_method = (Unity.PolySpatial.VolumeCameraWindowConfiguration)typeof(Unity.PolySpatial.VolumeCameraWindowConfiguration).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxWindowSize;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_WorldAlignment_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCameraWindowConfiguration instance_of_this_method = (Unity.PolySpatial.VolumeCameraWindowConfiguration)typeof(Unity.PolySpatial.VolumeCameraWindowConfiguration).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.WorldAlignment;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.PolySpatial.VolumeCameraWindowConfiguration();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
