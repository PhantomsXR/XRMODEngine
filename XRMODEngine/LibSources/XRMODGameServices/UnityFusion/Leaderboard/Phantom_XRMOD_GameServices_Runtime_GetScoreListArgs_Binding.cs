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
    unsafe class Phantom_XRMOD_GameServices_Runtime_GetScoreListArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.GetScoreListArgs);

            field = type.GetField("Offset", flag);
            app.RegisterCLRFieldGetter(field, get_Offset_0);
            app.RegisterCLRFieldSetter(field, set_Offset_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Offset_0, AssignFromStack_Offset_0);
            field = type.GetField("Limit", flag);
            app.RegisterCLRFieldGetter(field, get_Limit_1);
            app.RegisterCLRFieldSetter(field, set_Limit_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Limit_1, AssignFromStack_Limit_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.GameServices.Runtime.GetScoreListArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.GetScoreListArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_Offset_0(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.GetScoreListArgs)o).Offset;
        }

        static StackObject* CopyToStack_Offset_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.GetScoreListArgs)o).Offset;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Offset_0(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.GetScoreListArgs)o).Offset = (System.Int32)v;
        }

        static StackObject* AssignFromStack_Offset_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @Offset = ptr_of_this_method->Value;
            ((Phantom.XRMOD.GameServices.Runtime.GetScoreListArgs)o).Offset = @Offset;
            return ptr_of_this_method;
        }

        static object get_Limit_1(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.GetScoreListArgs)o).Limit;
        }

        static StackObject* CopyToStack_Limit_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.GetScoreListArgs)o).Limit;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Limit_1(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.GetScoreListArgs)o).Limit = (System.Int32)v;
        }

        static StackObject* AssignFromStack_Limit_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @Limit = ptr_of_this_method->Value;
            ((Phantom.XRMOD.GameServices.Runtime.GetScoreListArgs)o).Limit = @Limit;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.GameServices.Runtime.GetScoreListArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
