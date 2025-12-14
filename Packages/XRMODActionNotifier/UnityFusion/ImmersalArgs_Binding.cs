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
    unsafe class ImmersalArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.ActionNotification.Runtime.OnEventImmersalEventArgs);

            field = type.GetField("MapId", flag);
            app.RegisterCLRFieldGetter(field, get_MapId_0);
            app.RegisterCLRFieldSetter(field, set_MapId_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_MapId_0, AssignFromStack_MapId_0);
            field = type.GetField("LocalizerPose", flag);
            app.RegisterCLRFieldGetter(field, get_LocalizerPose_1);
            app.RegisterCLRFieldSetter(field, set_LocalizerPose_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalizerPose_1, AssignFromStack_LocalizerPose_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.ActionNotification.Runtime.OnEventImmersalEventArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.ActionNotification.Runtime.OnEventImmersalEventArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_MapId_0(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.OnEventImmersalEventArgs)o).MapId;
        }

        static StackObject* CopyToStack_MapId_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.OnEventImmersalEventArgs)o).MapId;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MapId_0(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventImmersalEventArgs)o).MapId = (System.Int32)v;
        }

        static StackObject* AssignFromStack_MapId_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @MapId = ptr_of_this_method->Value;
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventImmersalEventArgs)o).MapId = @MapId;
            return ptr_of_this_method;
        }

        static object get_LocalizerPose_1(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.OnEventImmersalEventArgs)o).LocalizerPose;
        }

        static StackObject* CopyToStack_LocalizerPose_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.OnEventImmersalEventArgs)o).LocalizerPose;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LocalizerPose_1(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventImmersalEventArgs)o).LocalizerPose = (Phantom.XRMOD.ActionNotification.Runtime.LocalizerPose)v;
        }

        static StackObject* AssignFromStack_LocalizerPose_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.ActionNotification.Runtime.LocalizerPose @LocalizerPose = (Phantom.XRMOD.ActionNotification.Runtime.LocalizerPose)typeof(Phantom.XRMOD.ActionNotification.Runtime.LocalizerPose).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventImmersalEventArgs)o).LocalizerPose = @LocalizerPose;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.ActionNotification.Runtime.OnEventImmersalEventArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
