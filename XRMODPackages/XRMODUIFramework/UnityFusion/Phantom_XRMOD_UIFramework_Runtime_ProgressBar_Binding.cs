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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_ProgressBar_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar);
            args = new Type[]{};
            method = type.GetMethod("get_FillRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_FillRect_0);
            args = new Type[]{typeof(UnityEngine.RectTransform)};
            method = type.GetMethod("set_FillRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_FillRect_1);
            args = new Type[]{};
            method = type.GetMethod("get_MinValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MinValue_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_MinValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MinValue_3);
            args = new Type[]{};
            method = type.GetMethod("get_MaxValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxValue_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_MaxValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxValue_5);
            args = new Type[]{};
            method = type.GetMethod("get_Value", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Value_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_Value", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Value_7);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("SetValueWithoutNotify", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetValueWithoutNotify_8);
            args = new Type[]{};
            method = type.GetMethod("get_NormalizedValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_NormalizedValue_9);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_NormalizedValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_NormalizedValue_10);
            args = new Type[]{};
            method = type.GetMethod("get_OnValueChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_OnValueChanged_11);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar.ProgressBarEvent)};
            method = type.GetMethod("set_OnValueChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_OnValueChanged_12);
            args = new Type[]{typeof(UnityEngine.UI.CanvasUpdate)};
            method = type.GetMethod("Rebuild", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Rebuild_13);
            args = new Type[]{};
            method = type.GetMethod("LayoutComplete", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LayoutComplete_14);
            args = new Type[]{};
            method = type.GetMethod("GraphicUpdateComplete", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GraphicUpdateComplete_15);



            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.UIFramework.Runtime.ProgressBar[s]);


        }


        static StackObject* get_FillRect_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FillRect;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_FillRect_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectTransform @value = (UnityEngine.RectTransform)typeof(UnityEngine.RectTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FillRect = value;

            return __ret;
        }

        static StackObject* get_MinValue_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MinValue;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MinValue_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MinValue = value;

            return __ret;
        }

        static StackObject* get_MaxValue_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxValue;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MaxValue_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxValue = value;

            return __ret;
        }

        static StackObject* get_Value_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Value;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_Value_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Value = value;

            return __ret;
        }

        static StackObject* SetValueWithoutNotify_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @input = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetValueWithoutNotify(@input);

            return __ret;
        }

        static StackObject* get_NormalizedValue_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.NormalizedValue;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_NormalizedValue_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.NormalizedValue = value;

            return __ret;
        }

        static StackObject* get_OnValueChanged_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.OnValueChanged;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_OnValueChanged_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar.ProgressBarEvent @value = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar.ProgressBarEvent)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar.ProgressBarEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnValueChanged = value;

            return __ret;
        }

        static StackObject* Rebuild_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UI.CanvasUpdate @executing = (UnityEngine.UI.CanvasUpdate)typeof(UnityEngine.UI.CanvasUpdate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Rebuild(@executing);

            return __ret;
        }

        static StackObject* LayoutComplete_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LayoutComplete();

            return __ret;
        }

        static StackObject* GraphicUpdateComplete_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.ProgressBar instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ProgressBar)typeof(Phantom.XRMOD.UIFramework.Runtime.ProgressBar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GraphicUpdateComplete();

            return __ret;
        }





    }
}
