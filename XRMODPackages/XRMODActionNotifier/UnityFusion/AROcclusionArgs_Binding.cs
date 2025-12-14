using System;
using System.Collections.Generic;
using System.Reflection;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using UnityFusion.CLR.Utils;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif
namespace UnityFusion.Runtime.Generated
{
    unsafe class AROcclusionArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.ActionNotification.Runtime.AROcclusionArgs);

            field = type.GetField("OcclusionDataType", flag);
            app.RegisterCLRFieldGetter(field, get_OcclusionDataType_0);
            app.RegisterCLRFieldSetter(field, set_OcclusionDataType_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OcclusionDataType_0, AssignFromStack_OcclusionDataType_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.ActionNotification.Runtime.AROcclusionArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.ActionNotification.Runtime.AROcclusionArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_OcclusionDataType_0(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.AROcclusionArgs)o).OcclusionDataType;
        }

        static StackObject* CopyToStack_OcclusionDataType_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.AROcclusionArgs)o).OcclusionDataType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OcclusionDataType_0(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.AROcclusionArgs)o).OcclusionDataType = (Phantom.XRMOD.ActionNotification.Runtime.OcclusionDataType)v;
        }

        static StackObject* AssignFromStack_OcclusionDataType_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.ActionNotification.Runtime.OcclusionDataType @OcclusionDataType = (Phantom.XRMOD.ActionNotification.Runtime.OcclusionDataType)typeof(Phantom.XRMOD.ActionNotification.Runtime.OcclusionDataType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((Phantom.XRMOD.ActionNotification.Runtime.AROcclusionArgs)o).OcclusionDataType = @OcclusionDataType;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.ActionNotification.Runtime.AROcclusionArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
