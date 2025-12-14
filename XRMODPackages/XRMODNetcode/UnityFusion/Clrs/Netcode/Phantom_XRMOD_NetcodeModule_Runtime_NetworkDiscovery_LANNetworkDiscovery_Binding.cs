using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery;
using UnityEngine.Events;
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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_NetworkDiscovery_LANNetworkDiscovery_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery);
            args = new Type[] { };
            method = type.GetMethod("Awake", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Awake_0);
            args = new Type[] { };
            method = type.GetMethod("Update", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Update_1);

            field = type.GetField("ServerName", flag);
            app.RegisterCLRFieldGetter(field, get_ServerName_0);
            app.RegisterCLRFieldSetter(field, set_ServerName_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerName_0, AssignFromStack_ServerName_0);
            field = type.GetField("OnServerFound", flag);
            app.RegisterCLRFieldGetter(field, get_OnServerFound_1);
            app.RegisterCLRFieldSetter(field, set_OnServerFound_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnServerFound_1, AssignFromStack_OnServerFound_1);


            app.RegisterCLRCreateDefaultInstance(type,
                () => new Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery());
            app.RegisterCLRCreateArrayInstance(type,
                s => new Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* Awake_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Awake();

            return __ret;
        }

        static StackObject* Update_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Update();

            return __ret;
        }


        static object get_ServerName_0(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery) o).ServerName;
        }

        static StackObject* CopyToStack_ServerName_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery) o)
                .ServerName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerName_0(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery) o).ServerName =
                (System.String) v;
        }

        static StackObject* AssignFromStack_ServerName_0(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @ServerName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery) o).ServerName = @ServerName;
            return ptr_of_this_method;
        }

        static object get_OnServerFound_1(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery) o).OnServerFound;
        }

        static StackObject* CopyToStack_OnServerFound_1(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery) o)
                .OnServerFound;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnServerFound_1(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery) o).OnServerFound =
                (UnityEvent<IPEndPoint, DiscoveryResponseData>) v;
        }

        static StackObject* AssignFromStack_OnServerFound_1(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEvent<IPEndPoint, DiscoveryResponseData> @OnServerFound =
                (UnityEvent<IPEndPoint, DiscoveryResponseData>)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery) o).OnServerFound =
                @OnServerFound;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.LANNetworkDiscovery();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}