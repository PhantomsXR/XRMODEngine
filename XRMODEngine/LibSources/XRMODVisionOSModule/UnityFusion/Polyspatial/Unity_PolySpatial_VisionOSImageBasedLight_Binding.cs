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
    unsafe class Unity_PolySpatial_VisionOSImageBasedLight_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Unity.PolySpatial.VisionOSImageBasedLight);
            args = new Type[]{};
            method = type.GetMethod("get_FirstSource", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_FirstSource_0);
            args = new Type[]{typeof(UnityEngine.Texture)};
            method = type.GetMethod("set_FirstSource", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_FirstSource_1);
            args = new Type[]{};
            method = type.GetMethod("get_SecondSource", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SecondSource_2);
            args = new Type[]{typeof(UnityEngine.Texture)};
            method = type.GetMethod("set_SecondSource", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_SecondSource_3);
            args = new Type[]{};
            method = type.GetMethod("get_Blend", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Blend_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_Blend", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Blend_5);
            args = new Type[]{};
            method = type.GetMethod("get_InheritsRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_InheritsRotation_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_InheritsRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_InheritsRotation_7);
            args = new Type[]{};
            method = type.GetMethod("get_IntensityExponent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IntensityExponent_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_IntensityExponent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_IntensityExponent_9);



            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.PolySpatial.VisionOSImageBasedLight());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.PolySpatial.VisionOSImageBasedLight[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_FirstSource_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSImageBasedLight instance_of_this_method = (Unity.PolySpatial.VisionOSImageBasedLight)typeof(Unity.PolySpatial.VisionOSImageBasedLight).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FirstSource;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_FirstSource_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @value = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSImageBasedLight instance_of_this_method = (Unity.PolySpatial.VisionOSImageBasedLight)typeof(Unity.PolySpatial.VisionOSImageBasedLight).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FirstSource = value;

            return __ret;
        }

        static StackObject* get_SecondSource_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSImageBasedLight instance_of_this_method = (Unity.PolySpatial.VisionOSImageBasedLight)typeof(Unity.PolySpatial.VisionOSImageBasedLight).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SecondSource;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_SecondSource_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @value = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSImageBasedLight instance_of_this_method = (Unity.PolySpatial.VisionOSImageBasedLight)typeof(Unity.PolySpatial.VisionOSImageBasedLight).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SecondSource = value;

            return __ret;
        }

        static StackObject* get_Blend_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSImageBasedLight instance_of_this_method = (Unity.PolySpatial.VisionOSImageBasedLight)typeof(Unity.PolySpatial.VisionOSImageBasedLight).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Blend;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_Blend_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSImageBasedLight instance_of_this_method = (Unity.PolySpatial.VisionOSImageBasedLight)typeof(Unity.PolySpatial.VisionOSImageBasedLight).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Blend = value;

            return __ret;
        }

        static StackObject* get_InheritsRotation_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSImageBasedLight instance_of_this_method = (Unity.PolySpatial.VisionOSImageBasedLight)typeof(Unity.PolySpatial.VisionOSImageBasedLight).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.InheritsRotation;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_InheritsRotation_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSImageBasedLight instance_of_this_method = (Unity.PolySpatial.VisionOSImageBasedLight)typeof(Unity.PolySpatial.VisionOSImageBasedLight).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.InheritsRotation = value;

            return __ret;
        }

        static StackObject* get_IntensityExponent_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSImageBasedLight instance_of_this_method = (Unity.PolySpatial.VisionOSImageBasedLight)typeof(Unity.PolySpatial.VisionOSImageBasedLight).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IntensityExponent;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_IntensityExponent_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSImageBasedLight instance_of_this_method = (Unity.PolySpatial.VisionOSImageBasedLight)typeof(Unity.PolySpatial.VisionOSImageBasedLight).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.IntensityExponent = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.PolySpatial.VisionOSImageBasedLight();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
