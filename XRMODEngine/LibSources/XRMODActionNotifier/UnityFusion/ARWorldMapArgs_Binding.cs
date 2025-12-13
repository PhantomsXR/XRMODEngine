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
    unsafe class ARWorldMapArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.ActionNotification.Runtime.ARWorldMapArgs);

            field = type.GetField("MapData", flag);
            app.RegisterCLRFieldGetter(field, get_MapData_0);
            app.RegisterCLRFieldSetter(field, set_MapData_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_MapData_0, AssignFromStack_MapData_0);
            field = type.GetField("MapDataFilePath", flag);
            app.RegisterCLRFieldGetter(field, get_MapDataFilePath_1);
            app.RegisterCLRFieldSetter(field, set_MapDataFilePath_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_MapDataFilePath_1, AssignFromStack_MapDataFilePath_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.ActionNotification.Runtime.ARWorldMapArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.ActionNotification.Runtime.ARWorldMapArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_MapData_0(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.ARWorldMapArgs)o).MapData;
        }

        static StackObject* CopyToStack_MapData_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.ARWorldMapArgs)o).MapData;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_MapData_0(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.ARWorldMapArgs)o).MapData = (System.Byte[])v;
        }

        static StackObject* AssignFromStack_MapData_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Byte[] @MapData = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.ActionNotification.Runtime.ARWorldMapArgs)o).MapData = @MapData;
            return ptr_of_this_method;
        }

        static object get_MapDataFilePath_1(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.ARWorldMapArgs)o).MapDataFilePath;
        }

        static StackObject* CopyToStack_MapDataFilePath_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.ARWorldMapArgs)o).MapDataFilePath;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_MapDataFilePath_1(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.ARWorldMapArgs)o).MapDataFilePath = (System.String)v;
        }

        static StackObject* AssignFromStack_MapDataFilePath_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @MapDataFilePath = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.ActionNotification.Runtime.ARWorldMapArgs)o).MapDataFilePath = @MapDataFilePath;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.ActionNotification.Runtime.ARWorldMapArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
