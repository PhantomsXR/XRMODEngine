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
    unsafe class Phantom_XRMOD_PhotonModule_Runtime_NetworkCharacterControllerLocalPositionSync_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.NetworkCharacterControllerLocalPositionSync);
            args = new Type[]{};
            method = type.GetMethod("get_Velocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Velocity_0);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_Velocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Velocity_1);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("Move", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Move_2);
            args = new Type[]{typeof(System.Nullable<UnityEngine.Vector3>), typeof(System.Nullable<UnityEngine.Quaternion>)};
            method = type.GetMethod("Teleport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Teleport_3);


        }


        static StackObject* get_Velocity_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.NetworkCharacterControllerLocalPositionSync instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.NetworkCharacterControllerLocalPositionSync)typeof(Phantom.XRMOD.PhotonModule.Runtime.NetworkCharacterControllerLocalPositionSync).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Velocity;

            if (UnityFusion.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                UnityFusion.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);
                return __ret + 1;
            } else {
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
            }
        }

        static StackObject* set_Velocity_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = new UnityEngine.Vector3();
            if (UnityFusion.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                UnityFusion.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @value, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.PhotonModule.Runtime.NetworkCharacterControllerLocalPositionSync instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.NetworkCharacterControllerLocalPositionSync)typeof(Phantom.XRMOD.PhotonModule.Runtime.NetworkCharacterControllerLocalPositionSync).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Velocity = value;

            return __ret;
        }

        static StackObject* Move_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @direction = new UnityEngine.Vector3();
            if (UnityFusion.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder != null) {
                UnityFusion.Runtime.Generated.CLRBindings.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @direction, __intp, ptr_of_this_method, __mStack, true);
            } else {
                @direction = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.PhotonModule.Runtime.NetworkCharacterControllerLocalPositionSync instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.NetworkCharacterControllerLocalPositionSync)typeof(Phantom.XRMOD.PhotonModule.Runtime.NetworkCharacterControllerLocalPositionSync).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Move(@direction);

            return __ret;
        }

        static StackObject* Teleport_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Nullable<UnityEngine.Quaternion> @rotation = (System.Nullable<UnityEngine.Quaternion>)typeof(System.Nullable<UnityEngine.Quaternion>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Nullable<UnityEngine.Vector3> @position = (System.Nullable<UnityEngine.Vector3>)typeof(System.Nullable<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.PhotonModule.Runtime.NetworkCharacterControllerLocalPositionSync instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.NetworkCharacterControllerLocalPositionSync)typeof(Phantom.XRMOD.PhotonModule.Runtime.NetworkCharacterControllerLocalPositionSync).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Teleport(@position, @rotation);

            return __ret;
        }



    }
}
