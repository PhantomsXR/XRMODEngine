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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_Ease_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.Ease);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("InQuint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InQuint_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("OutQuint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OutQuint_1);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("InOutQuint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InOutQuint_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("OutBackQuint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OutBackQuint_3);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("InQuart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InQuart_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("OutQuart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OutQuart_5);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("InOutQuart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InOutQuart_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("OutBackQuart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OutBackQuart_7);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("InCubic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InCubic_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("OutCubic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OutCubic_9);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("InOutCubic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InOutCubic_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("OutBackCubic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OutBackCubic_11);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("InQuad", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InQuad_12);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("OutQuad", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OutQuad_13);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("InOutQuad", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InOutQuad_14);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("OutBackQuad", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OutBackQuad_15);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("Linear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Linear_16);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("OutBackLinear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OutBackLinear_17);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("OutPowBack", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OutPowBack_18);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("OutBack", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OutBack_19);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.Ease.Type), typeof(Phantom.XRMOD.UIFramework.Runtime.Ease.Power)};
            method = type.GetMethod("GetEase", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetEase_20);





        }


        static StackObject* InQuint_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.InQuint(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OutQuint_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.OutQuint(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* InOutQuint_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.InOutQuint(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OutBackQuint_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.OutBackQuint(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* InQuart_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.InQuart(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OutQuart_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.OutQuart(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* InOutQuart_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.InOutQuart(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OutBackQuart_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.OutBackQuart(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* InCubic_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.InCubic(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OutCubic_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.OutCubic(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* InOutCubic_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.InOutCubic(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OutBackCubic_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.OutBackCubic(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* InQuad_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.InQuad(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OutQuad_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.OutQuad(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* InOutQuad_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.InOutQuad(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OutBackQuad_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.OutBackQuad(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Linear_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.Linear(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OutBackLinear_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.OutBackLinear(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OutPowBack_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @p = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.OutPowBack(@x, @p);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OutBack_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.OutBack(@x);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetEase_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.Ease.Power @power = (Phantom.XRMOD.UIFramework.Runtime.Ease.Power)typeof(Phantom.XRMOD.UIFramework.Runtime.Ease.Power).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.Ease.Type @type = (Phantom.XRMOD.UIFramework.Runtime.Ease.Type)typeof(Phantom.XRMOD.UIFramework.Runtime.Ease.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.Ease.GetEase(@type, @power);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
