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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_NetcodeConnectionEventArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeConnectionEventArgs);

            field = type.GetField("NetworkManager", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkManager_0);
            app.RegisterCLRFieldSetter(field, set_NetworkManager_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_NetworkManager_0, AssignFromStack_NetworkManager_0);
            field = type.GetField("ConnectionEventData", flag);
            app.RegisterCLRFieldGetter(field, get_ConnectionEventData_1);
            app.RegisterCLRFieldSetter(field, set_ConnectionEventData_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ConnectionEventData_1, AssignFromStack_ConnectionEventData_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.NetcodeModule.Runtime.NetcodeConnectionEventArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.NetcodeConnectionEventArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_NetworkManager_0(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeConnectionEventArgs)o).NetworkManager;
        }

        static StackObject* CopyToStack_NetworkManager_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeConnectionEventArgs)o).NetworkManager;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NetworkManager_0(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeConnectionEventArgs)o).NetworkManager = (Unity.Netcode.NetworkManager)v;
        }

        static StackObject* AssignFromStack_NetworkManager_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkManager @NetworkManager = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeConnectionEventArgs)o).NetworkManager = @NetworkManager;
            return ptr_of_this_method;
        }

        static object get_ConnectionEventData_1(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeConnectionEventArgs)o).ConnectionEventData;
        }

        static StackObject* CopyToStack_ConnectionEventData_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeConnectionEventArgs)o).ConnectionEventData;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ConnectionEventData_1(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeConnectionEventArgs)o).ConnectionEventData = (Unity.Netcode.ConnectionEventData)v;
        }

        static StackObject* AssignFromStack_ConnectionEventData_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.ConnectionEventData @ConnectionEventData = (Unity.Netcode.ConnectionEventData)typeof(Unity.Netcode.ConnectionEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeConnectionEventArgs)o).ConnectionEventData = @ConnectionEventData;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.NetcodeModule.Runtime.NetcodeConnectionEventArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
