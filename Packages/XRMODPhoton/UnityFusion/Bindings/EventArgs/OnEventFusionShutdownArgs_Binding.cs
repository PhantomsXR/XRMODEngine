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
    unsafe class OnEventFusionShutdownArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionShutdownArgs);

            field = type.GetField("ShutdownReason", flag);
            app.RegisterCLRFieldGetter(field, get_ShutdownReason_0);
            app.RegisterCLRFieldSetter(field, set_ShutdownReason_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ShutdownReason_0, AssignFromStack_ShutdownReason_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionShutdownArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionShutdownArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_ShutdownReason_0(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionShutdownArgs)o).ShutdownReason;
        }

        static StackObject* CopyToStack_ShutdownReason_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionShutdownArgs)o).ShutdownReason;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ShutdownReason_0(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionShutdownArgs)o).ShutdownReason = (Fusion.ShutdownReason)v;
        }

        static StackObject* AssignFromStack_ShutdownReason_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.ShutdownReason @ShutdownReason = (Fusion.ShutdownReason)typeof(Fusion.ShutdownReason).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionShutdownArgs)o).ShutdownReason = @ShutdownReason;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionShutdownArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif