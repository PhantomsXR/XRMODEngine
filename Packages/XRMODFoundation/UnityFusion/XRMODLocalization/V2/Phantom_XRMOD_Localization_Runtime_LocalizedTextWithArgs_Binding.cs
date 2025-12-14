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
    unsafe class Phantom_XRMOD_Localization_Runtime_LocalizedTextWithArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs);
            args = new Type[]{typeof(System.Object[])};
            method = type.GetMethod("SetArgs", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetArgs_0);
            args = new Type[]{};
            method = type.GetMethod("Refresh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Refresh_1);
            args = new Type[]{};
            method = type.GetMethod("UpdateTemplate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateTemplate_2);

            field = type.GetField("LocalizationKey", flag);
            app.RegisterCLRFieldGetter(field, get_LocalizationKey_0);
            app.RegisterCLRFieldSetter(field, set_LocalizationKey_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalizationKey_0, AssignFromStack_LocalizationKey_0);
            field = type.GetField("Scope", flag);
            app.RegisterCLRFieldGetter(field, get_Scope_1);
            app.RegisterCLRFieldSetter(field, set_Scope_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Scope_1, AssignFromStack_Scope_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* SetArgs_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object[] @_args = (System.Object[])typeof(System.Object[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs instance_of_this_method = (Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs)typeof(Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetArgs(@_args);

            return __ret;
        }

        static StackObject* Refresh_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs instance_of_this_method = (Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs)typeof(Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Refresh();

            return __ret;
        }

        static StackObject* UpdateTemplate_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs instance_of_this_method = (Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs)typeof(Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UpdateTemplate();

            return __ret;
        }


        static object get_LocalizationKey_0(ref object o)
        {
            return ((Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs)o).LocalizationKey;
        }

        static StackObject* CopyToStack_LocalizationKey_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs)o).LocalizationKey;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LocalizationKey_0(ref object o, object v)
        {
            ((Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs)o).LocalizationKey = (System.String)v;
        }

        static StackObject* AssignFromStack_LocalizationKey_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @LocalizationKey = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs)o).LocalizationKey = @LocalizationKey;
            return ptr_of_this_method;
        }

        static object get_Scope_1(ref object o)
        {
            return ((Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs)o).Scope;
        }

        static StackObject* CopyToStack_Scope_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs)o).Scope;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Scope_1(ref object o, object v)
        {
            ((Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs)o).Scope = (Phantom.XRMOD.Localization.Runtime.LocalizationScope)v;
        }

        static StackObject* AssignFromStack_Scope_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Localization.Runtime.LocalizationScope @Scope = (Phantom.XRMOD.Localization.Runtime.LocalizationScope)typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs)o).Scope = @Scope;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.Localization.Runtime.LocalizedTextWithArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
