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
    unsafe class Phantom_XRMOD_PhotonModule_Runtime_ConnectFailReason_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.ConnectFailReason);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_None_0, null);
            field = type.GetField("UserRequest", flag);
            app.RegisterCLRFieldGetter(field, get_UserRequest_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_UserRequest_1, null);
            field = type.GetField("ApplicationQuit", flag);
            app.RegisterCLRFieldGetter(field, get_ApplicationQuit_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_ApplicationQuit_2, null);
            field = type.GetField("Disconnect", flag);
            app.RegisterCLRFieldGetter(field, get_Disconnect_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Disconnect_3, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.PhotonModule.Runtime.ConnectFailReason());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.PhotonModule.Runtime.ConnectFailReason[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_None_0(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.ConnectFailReason.None;
        }

        static StackObject* CopyToStack_None_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.ConnectFailReason.None;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_UserRequest_1(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.ConnectFailReason.UserRequest;
        }

        static StackObject* CopyToStack_UserRequest_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.ConnectFailReason.UserRequest;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_ApplicationQuit_2(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.ConnectFailReason.ApplicationQuit;
        }

        static StackObject* CopyToStack_ApplicationQuit_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.ConnectFailReason.ApplicationQuit;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_Disconnect_3(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.ConnectFailReason.Disconnect;
        }

        static StackObject* CopyToStack_Disconnect_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.ConnectFailReason.Disconnect;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.PhotonModule.Runtime.ConnectFailReason();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif