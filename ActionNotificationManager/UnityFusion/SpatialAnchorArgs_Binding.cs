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
    unsafe class SpatialAnchorArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs);

            field = type.GetField("TaskId", flag);
            app.RegisterCLRFieldGetter(field, get_TaskId_0);
            app.RegisterCLRFieldSetter(field, set_TaskId_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_TaskId_0, AssignFromStack_TaskId_0);
            field = type.GetField("Result", flag);
            app.RegisterCLRFieldGetter(field, get_Result_1);
            app.RegisterCLRFieldSetter(field, set_Result_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Result_1, AssignFromStack_Result_1);
            field = type.GetField("AnchorId", flag);
            app.RegisterCLRFieldGetter(field, get_AnchorId_2);
            app.RegisterCLRFieldSetter(field, set_AnchorId_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_AnchorId_2, AssignFromStack_AnchorId_2);
            field = type.GetField("Uuid", flag);
            app.RegisterCLRFieldGetter(field, get_Uuid_3);
            app.RegisterCLRFieldSetter(field, set_Uuid_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Uuid_3, AssignFromStack_Uuid_3);
            field = type.GetField("Count", flag);
            app.RegisterCLRFieldGetter(field, get_Count_4);
            app.RegisterCLRFieldSetter(field, set_Count_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Count_4, AssignFromStack_Count_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_TaskId_0(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).TaskId;
        }

        static StackObject* CopyToStack_TaskId_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).TaskId;
            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_TaskId_0(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).TaskId = (System.UInt64)v;
        }

        static StackObject* AssignFromStack_TaskId_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt64 @TaskId = *(ulong*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).TaskId = @TaskId;
            return ptr_of_this_method;
        }

        static object get_Result_1(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).Result;
        }

        static StackObject* CopyToStack_Result_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).Result;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Result_1(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).Result = (System.String)v;
        }

        static StackObject* AssignFromStack_Result_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @Result = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).Result = @Result;
            return ptr_of_this_method;
        }

        static object get_AnchorId_2(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).AnchorId;
        }

        static StackObject* CopyToStack_AnchorId_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).AnchorId;
            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_AnchorId_2(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).AnchorId = (System.UInt64)v;
        }

        static StackObject* AssignFromStack_AnchorId_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt64 @AnchorId = *(ulong*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).AnchorId = @AnchorId;
            return ptr_of_this_method;
        }

        static object get_Uuid_3(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).Uuid;
        }

        static StackObject* CopyToStack_Uuid_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).Uuid;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Uuid_3(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).Uuid = (System.Guid)v;
        }

        static StackObject* AssignFromStack_Uuid_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Guid @Uuid = (System.Guid)typeof(System.Guid).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).Uuid = @Uuid;
            return ptr_of_this_method;
        }

        static object get_Count_4(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).Count;
        }

        static StackObject* CopyToStack_Count_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).Count;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static void set_Count_4(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).Count = (System.UInt32)v;
        }

        static StackObject* AssignFromStack_Count_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt32 @Count = (uint)ptr_of_this_method->Value;
            ((Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs)o).Count = @Count;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.ActionNotification.Runtime.SpatialAnchorArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
