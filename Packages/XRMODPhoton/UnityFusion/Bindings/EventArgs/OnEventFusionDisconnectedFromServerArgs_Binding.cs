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
    unsafe class OnEventFusionDisconnectedFromServerArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionDisconnectedFromServerArgs);

            field = type.GetField("Reason", flag);
            app.RegisterCLRFieldGetter(field, get_Reason_0);
            app.RegisterCLRFieldSetter(field, set_Reason_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Reason_0, AssignFromStack_Reason_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionDisconnectedFromServerArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionDisconnectedFromServerArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_Reason_0(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionDisconnectedFromServerArgs)o).Reason;
        }

        static StackObject* CopyToStack_Reason_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionDisconnectedFromServerArgs)o).Reason;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Reason_0(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionDisconnectedFromServerArgs)o).Reason = (Fusion.Sockets.NetDisconnectReason)v;
        }

        static StackObject* AssignFromStack_Reason_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Sockets.NetDisconnectReason @Reason = (Fusion.Sockets.NetDisconnectReason)typeof(Fusion.Sockets.NetDisconnectReason).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionDisconnectedFromServerArgs)o).Reason = @Reason;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionDisconnectedFromServerArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif