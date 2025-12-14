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
    unsafe class Phantom_XRMOD_Localization_Runtime_LocalizedStringKeyExtension_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.Localization.Runtime.LocalizedStringKeyExtension);
            args = new Type[]{typeof(System.String), typeof(Phantom.XRMOD.Localization.Runtime.LocalizationModule)};
            method = type.GetMethod("Localized", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Localized_0);
            args = new Type[]{typeof(System.String), typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope)};
            method = type.GetMethod("Localized", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Localized_1);
            args = new Type[]{typeof(System.String), typeof(System.String), typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope)};
            method = type.GetMethod("Localized", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Localized_2);
            args = new Type[]{typeof(System.String), typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope), typeof(System.Object[])};
            method = type.GetMethod("Localized", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Localized_3);





        }


        static StackObject* Localized_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationModule @_module = (Phantom.XRMOD.Localization.Runtime.LocalizationModule)typeof(Phantom.XRMOD.Localization.Runtime.LocalizationModule).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_key = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.Localization.Runtime.LocalizedStringKeyExtension.Localized(@_key, @_module);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Localized_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationScope tmp_LocalizationScope = (Phantom.XRMOD.Localization.Runtime.LocalizationScope)typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_key = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.Localization.Runtime.LocalizedStringKeyExtension.Localized(@_key, tmp_LocalizationScope);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Localized_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationScope tmp_LocalizationScope = (Phantom.XRMOD.Localization.Runtime.LocalizationScope)typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_dynamicValue = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_key = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.Localization.Runtime.LocalizedStringKeyExtension.Localized(@_key, @_dynamicValue, tmp_LocalizationScope);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Localized_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object[] @_dynamicValues = (System.Object[])typeof(System.Object[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.Localization.Runtime.LocalizationScope tmp_LocalizationScope = (Phantom.XRMOD.Localization.Runtime.LocalizationScope)typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_key = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.Localization.Runtime.LocalizedStringKeyExtension.Localized(@_key, tmp_LocalizationScope, @_dynamicValues);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
