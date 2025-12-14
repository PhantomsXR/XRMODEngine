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
    unsafe class Unity_PolySpatial_PolySpatialObjectUtils_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Unity.PolySpatial.PolySpatialObjectUtils);
            args = new Type[]{typeof(UnityEngine.RenderTexture)};
            method = type.GetMethod("MarkDirty", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MarkDirty_0);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("GetPolySpatialIdentifier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPolySpatialIdentifier_1);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("GetGameObjectForPolySpatialIdentifier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGameObjectForPolySpatialIdentifier_2);





        }


        static StackObject* MarkDirty_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTexture @renderTexture = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Unity.PolySpatial.PolySpatialObjectUtils.MarkDirty(@renderTexture);

            return __ret;
        }

        static StackObject* GetPolySpatialIdentifier_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @go = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Unity.PolySpatial.PolySpatialObjectUtils.GetPolySpatialIdentifier(@go);

            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetGameObjectForPolySpatialIdentifier_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @id = *(ulong*)&ptr_of_this_method->Value;


            var result_of_this_method = Unity.PolySpatial.PolySpatialObjectUtils.GetGameObjectForPolySpatialIdentifier(@id);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
