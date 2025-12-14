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
    unsafe class Phantom_XRMOD_InAppPurchase_Runtime_PurchaseCallback_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback);

            field = type.GetField("OnPurchaseStateChange", flag);
            app.RegisterCLRFieldGetter(field, get_OnPurchaseStateChange_0);
            app.RegisterCLRFieldSetter(field, set_OnPurchaseStateChange_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnPurchaseStateChange_0, AssignFromStack_OnPurchaseStateChange_0);
            field = type.GetField("OnPurchaseFailedHandler", flag);
            app.RegisterCLRFieldGetter(field, get_OnPurchaseFailedHandler_1);
            app.RegisterCLRFieldSetter(field, set_OnPurchaseFailedHandler_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnPurchaseFailedHandler_1, AssignFromStack_OnPurchaseFailedHandler_1);
            field = type.GetField("OnRestoreHandler", flag);
            app.RegisterCLRFieldGetter(field, get_OnRestoreHandler_2);
            app.RegisterCLRFieldSetter(field, set_OnRestoreHandler_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnRestoreHandler_2, AssignFromStack_OnRestoreHandler_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_OnPurchaseStateChange_0(ref object o)
        {
            return ((Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback)o).OnPurchaseStateChange;
        }

        static StackObject* CopyToStack_OnPurchaseStateChange_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback)o).OnPurchaseStateChange;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnPurchaseStateChange_0(ref object o, object v)
        {
            ((Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback)o).OnPurchaseStateChange = (System.Action<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_OnPurchaseStateChange_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.Boolean> @OnPurchaseStateChange = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback)o).OnPurchaseStateChange = @OnPurchaseStateChange;
            return ptr_of_this_method;
        }

        static object get_OnPurchaseFailedHandler_1(ref object o)
        {
            return ((Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback)o).OnPurchaseFailedHandler;
        }

        static StackObject* CopyToStack_OnPurchaseFailedHandler_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback)o).OnPurchaseFailedHandler;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnPurchaseFailedHandler_1(ref object o, object v)
        {
            ((Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback)o).OnPurchaseFailedHandler = (System.Action<System.String>)v;
        }

        static StackObject* AssignFromStack_OnPurchaseFailedHandler_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.String> @OnPurchaseFailedHandler = (System.Action<System.String>)typeof(System.Action<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback)o).OnPurchaseFailedHandler = @OnPurchaseFailedHandler;
            return ptr_of_this_method;
        }

        static object get_OnRestoreHandler_2(ref object o)
        {
            return ((Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback)o).OnRestoreHandler;
        }

        static StackObject* CopyToStack_OnRestoreHandler_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback)o).OnRestoreHandler;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnRestoreHandler_2(ref object o, object v)
        {
            ((Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback)o).OnRestoreHandler = (System.Action<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_OnRestoreHandler_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.Boolean> @OnRestoreHandler = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback)o).OnRestoreHandler = @OnRestoreHandler;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.InAppPurchase.Runtime.PurchaseCallback();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
