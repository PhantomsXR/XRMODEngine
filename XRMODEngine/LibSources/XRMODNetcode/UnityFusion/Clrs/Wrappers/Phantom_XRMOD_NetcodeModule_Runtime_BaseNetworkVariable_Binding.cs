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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_BaseNetworkVariable_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable);

            field = type.GetField("UseChangeEvent", flag);
            app.RegisterCLRFieldGetter(field, get_UseChangeEvent_0);
            app.RegisterCLRFieldSetter(field, set_UseChangeEvent_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_UseChangeEvent_0, AssignFromStack_UseChangeEvent_0);
            field = type.GetField("Key", flag);
            app.RegisterCLRFieldGetter(field, get_Key_1);
            app.RegisterCLRFieldSetter(field, set_Key_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Key_1, AssignFromStack_Key_1);


            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable[s]);


        }



        static object get_UseChangeEvent_0(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable)o).UseChangeEvent;
        }

        static StackObject* CopyToStack_UseChangeEvent_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable)o).UseChangeEvent;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_UseChangeEvent_0(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable)o).UseChangeEvent = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_UseChangeEvent_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @UseChangeEvent = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable)o).UseChangeEvent = @UseChangeEvent;
            return ptr_of_this_method;
        }

        static object get_Key_1(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable)o).Key;
        }

        static StackObject* CopyToStack_Key_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable)o).Key;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Key_1(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable)o).Key = (System.String)v;
        }

        static StackObject* AssignFromStack_Key_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @Key = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable)o).Key = @Key;
            return ptr_of_this_method;
        }




    }
}
