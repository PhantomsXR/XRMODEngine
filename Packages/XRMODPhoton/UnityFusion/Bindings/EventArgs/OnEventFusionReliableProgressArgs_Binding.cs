#if FUSION2 && XRMOD_INSTALL
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
    unsafe class OnEventFusionReliableProgressArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs);

            field = type.GetField("PlayerRef", flag);
            app.RegisterCLRFieldGetter(field, get_PlayerRef_0);
            app.RegisterCLRFieldSetter(field, set_PlayerRef_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayerRef_0, AssignFromStack_PlayerRef_0);
            field = type.GetField("ReliableKey", flag);
            app.RegisterCLRFieldGetter(field, get_ReliableKey_1);
            app.RegisterCLRFieldSetter(field, set_ReliableKey_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ReliableKey_1, AssignFromStack_ReliableKey_1);
            field = type.GetField("Progress", flag);
            app.RegisterCLRFieldGetter(field, get_Progress_2);
            app.RegisterCLRFieldSetter(field, set_Progress_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Progress_2, AssignFromStack_Progress_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_PlayerRef_0(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs)o).PlayerRef;
        }

        static StackObject* CopyToStack_PlayerRef_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs)o).PlayerRef;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlayerRef_0(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs)o).PlayerRef = (Fusion.PlayerRef)v;
        }

        static StackObject* AssignFromStack_PlayerRef_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.PlayerRef @PlayerRef = (Fusion.PlayerRef)typeof(Fusion.PlayerRef).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs)o).PlayerRef = @PlayerRef;
            return ptr_of_this_method;
        }

        static object get_ReliableKey_1(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs)o).ReliableKey;
        }

        static StackObject* CopyToStack_ReliableKey_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs)o).ReliableKey;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ReliableKey_1(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs)o).ReliableKey = (Fusion.Sockets.ReliableKey)v;
        }

        static StackObject* AssignFromStack_ReliableKey_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Sockets.ReliableKey @ReliableKey = (Fusion.Sockets.ReliableKey)typeof(Fusion.Sockets.ReliableKey).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs)o).ReliableKey = @ReliableKey;
            return ptr_of_this_method;
        }

        static object get_Progress_2(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs)o).Progress;
        }

        static StackObject* CopyToStack_Progress_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs)o).Progress;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Progress_2(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs)o).Progress = (System.Single)v;
        }

        static StackObject* AssignFromStack_Progress_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Progress = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs)o).Progress = @Progress;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionReliableProgressArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif