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
    unsafe class Phantom_XRMOD_Localization_Runtime_LocalizationModule_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.Localization.Runtime.LocalizationModule);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetLocalizedString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLocalizedString_0);
            args = new Type[]{typeof(System.Byte[]), typeof(System.String), typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope)};
            method = type.GetMethod("ChangeLanguage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ChangeLanguage_1);
            args = new Type[]{typeof(Phantom.XRMOD.Localization.Runtime.BaseLocalizedTextComponent), typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope)};
            method = type.GetMethod("AddText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddText_2);
            args = new Type[]{typeof(Phantom.XRMOD.Localization.Runtime.BaseLocalizedImageComponent), typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope)};
            method = type.GetMethod("AddImage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddImage_3);



            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.Localization.Runtime.LocalizationModule[s]);

            args = new Type[]{typeof(System.String), typeof(System.Byte[]), typeof(System.String), typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* GetLocalizedString_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_key = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.Localization.Runtime.LocalizationModule instance_of_this_method = (Phantom.XRMOD.Localization.Runtime.LocalizationModule)typeof(Phantom.XRMOD.Localization.Runtime.LocalizationModule).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLocalizedString(@_key);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ChangeLanguage_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationScope @_place = (Phantom.XRMOD.Localization.Runtime.LocalizationScope)typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_language = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Byte[] @_localizationTable = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.Localization.Runtime.LocalizationModule instance_of_this_method = (Phantom.XRMOD.Localization.Runtime.LocalizationModule)typeof(Phantom.XRMOD.Localization.Runtime.LocalizationModule).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ChangeLanguage(@_localizationTable, @_language, @_place);

            return __ret;
        }

        static StackObject* AddText_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationScope @_place = (Phantom.XRMOD.Localization.Runtime.LocalizationScope)typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.Localization.Runtime.BaseLocalizedTextComponent @_contentComponent = (Phantom.XRMOD.Localization.Runtime.BaseLocalizedTextComponent)typeof(Phantom.XRMOD.Localization.Runtime.BaseLocalizedTextComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.Localization.Runtime.LocalizationModule instance_of_this_method = (Phantom.XRMOD.Localization.Runtime.LocalizationModule)typeof(Phantom.XRMOD.Localization.Runtime.LocalizationModule).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddText(@_contentComponent, @_place);

            return __ret;
        }

        static StackObject* AddImage_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationScope @_place = (Phantom.XRMOD.Localization.Runtime.LocalizationScope)typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.Localization.Runtime.BaseLocalizedImageComponent @_contentComponent = (Phantom.XRMOD.Localization.Runtime.BaseLocalizedImageComponent)typeof(Phantom.XRMOD.Localization.Runtime.BaseLocalizedImageComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.Localization.Runtime.LocalizationModule instance_of_this_method = (Phantom.XRMOD.Localization.Runtime.LocalizationModule)typeof(Phantom.XRMOD.Localization.Runtime.LocalizationModule).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddImage(@_contentComponent, @_place);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationScope @_place = (Phantom.XRMOD.Localization.Runtime.LocalizationScope)typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_language = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Byte[] @_localizationTable = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @_projectName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new Phantom.XRMOD.Localization.Runtime.LocalizationModule(@_projectName, @_localizationTable, @_language, @_place);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
