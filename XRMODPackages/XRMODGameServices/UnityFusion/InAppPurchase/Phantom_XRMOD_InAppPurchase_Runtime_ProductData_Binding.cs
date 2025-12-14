#if UNITY_IN_APP_PURCHASE
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
    unsafe class Phantom_XRMOD_InAppPurchase_Runtime_ProductData_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.InAppPurchase.Runtime.ProductData);

            field = type.GetField("ProductUid", flag);
            app.RegisterCLRFieldGetter(field, get_ProductUid_0);
            app.RegisterCLRFieldSetter(field, set_ProductUid_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ProductUid_0, AssignFromStack_ProductUid_0);
            field = type.GetField("ProductName", flag);
            app.RegisterCLRFieldGetter(field, get_ProductName_1);
            app.RegisterCLRFieldSetter(field, set_ProductName_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ProductName_1, AssignFromStack_ProductName_1);
            field = type.GetField("ProductType", flag);
            app.RegisterCLRFieldGetter(field, get_ProductType_2);
            app.RegisterCLRFieldSetter(field, set_ProductType_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_ProductType_2, AssignFromStack_ProductType_2);
            field = type.GetField("ProductPrice", flag);
            app.RegisterCLRFieldGetter(field, get_ProductPrice_3);
            app.RegisterCLRFieldSetter(field, set_ProductPrice_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_ProductPrice_3, AssignFromStack_ProductPrice_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.InAppPurchase.Runtime.ProductData());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.InAppPurchase.Runtime.ProductData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_ProductUid_0(ref object o)
        {
            return ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductUid;
        }

        static StackObject* CopyToStack_ProductUid_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductUid;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ProductUid_0(ref object o, object v)
        {
            ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductUid = (System.String)v;
        }

        static StackObject* AssignFromStack_ProductUid_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @ProductUid = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductUid = @ProductUid;
            return ptr_of_this_method;
        }

        static object get_ProductName_1(ref object o)
        {
            return ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductName;
        }

        static StackObject* CopyToStack_ProductName_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ProductName_1(ref object o, object v)
        {
            ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductName = (System.String)v;
        }

        static StackObject* AssignFromStack_ProductName_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @ProductName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductName = @ProductName;
            return ptr_of_this_method;
        }

        static object get_ProductType_2(ref object o)
        {
            return ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductType;
        }

        static StackObject* CopyToStack_ProductType_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ProductType_2(ref object o, object v)
        {
            ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductType = (UnityEngine.Purchasing.ProductType)v;
        }

        static StackObject* AssignFromStack_ProductType_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Purchasing.ProductType @ProductType = (UnityEngine.Purchasing.ProductType)typeof(UnityEngine.Purchasing.ProductType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductType = @ProductType;
            return ptr_of_this_method;
        }

        static object get_ProductPrice_3(ref object o)
        {
            return ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductPrice;
        }

        static StackObject* CopyToStack_ProductPrice_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductPrice;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ProductPrice_3(ref object o, object v)
        {
            ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductPrice = (System.String)v;
        }

        static StackObject* AssignFromStack_ProductPrice_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @ProductPrice = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.InAppPurchase.Runtime.ProductData)o).ProductPrice = @ProductPrice;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.InAppPurchase.Runtime.ProductData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif