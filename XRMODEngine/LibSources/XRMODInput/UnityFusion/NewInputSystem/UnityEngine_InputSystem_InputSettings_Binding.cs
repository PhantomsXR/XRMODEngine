#if UNITY_EDITOR || UNITY_IOS || UNITY_TVOS || PACKAGE_DOCS_GENERATION
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
    unsafe class UnityEngine_InputSystem_InputSettings_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.InputSettings);
            args = new Type[]{};
            method = type.GetMethod("get_updateMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_updateMode_0);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputSettings.UpdateMode)};
            method = type.GetMethod("set_updateMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_updateMode_1);
            args = new Type[]{};
            method = type.GetMethod("get_compensateForScreenOrientation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_compensateForScreenOrientation_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_compensateForScreenOrientation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_compensateForScreenOrientation_3);
            args = new Type[]{};
            method = type.GetMethod("get_defaultDeadzoneMin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultDeadzoneMin_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_defaultDeadzoneMin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultDeadzoneMin_5);
            args = new Type[]{};
            method = type.GetMethod("get_defaultDeadzoneMax", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultDeadzoneMax_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_defaultDeadzoneMax", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultDeadzoneMax_7);
            args = new Type[]{};
            method = type.GetMethod("get_defaultButtonPressPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultButtonPressPoint_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_defaultButtonPressPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultButtonPressPoint_9);
            args = new Type[]{};
            method = type.GetMethod("get_buttonReleaseThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_buttonReleaseThreshold_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_buttonReleaseThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_buttonReleaseThreshold_11);
            args = new Type[]{};
            method = type.GetMethod("get_defaultTapTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultTapTime_12);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_defaultTapTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultTapTime_13);
            args = new Type[]{};
            method = type.GetMethod("get_defaultSlowTapTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultSlowTapTime_14);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_defaultSlowTapTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultSlowTapTime_15);
            args = new Type[]{};
            method = type.GetMethod("get_defaultHoldTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultHoldTime_16);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_defaultHoldTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultHoldTime_17);
            args = new Type[]{};
            method = type.GetMethod("get_tapRadius", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_tapRadius_18);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_tapRadius", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_tapRadius_19);
            args = new Type[]{};
            method = type.GetMethod("get_multiTapDelayTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_multiTapDelayTime_20);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_multiTapDelayTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_multiTapDelayTime_21);
            args = new Type[]{};
            method = type.GetMethod("get_backgroundBehavior", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_backgroundBehavior_22);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputSettings.BackgroundBehavior)};
            method = type.GetMethod("set_backgroundBehavior", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_backgroundBehavior_23);
            args = new Type[]{};
            method = type.GetMethod("get_editorInputBehaviorInPlayMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_editorInputBehaviorInPlayMode_24);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode)};
            method = type.GetMethod("set_editorInputBehaviorInPlayMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_editorInputBehaviorInPlayMode_25);
            args = new Type[]{};
            method = type.GetMethod("get_inputActionPropertyDrawerMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inputActionPropertyDrawerMode_26);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode)};
            method = type.GetMethod("set_inputActionPropertyDrawerMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_inputActionPropertyDrawerMode_27);
            args = new Type[]{};
            method = type.GetMethod("get_maxEventBytesPerUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxEventBytesPerUpdate_28);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_maxEventBytesPerUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxEventBytesPerUpdate_29);
            args = new Type[]{};
            method = type.GetMethod("get_maxQueuedEventsPerUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxQueuedEventsPerUpdate_30);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_maxQueuedEventsPerUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxQueuedEventsPerUpdate_31);
            args = new Type[]{};
            method = type.GetMethod("get_supportedDevices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportedDevices_32);
            args = new Type[]{typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String>)};
            method = type.GetMethod("set_supportedDevices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_supportedDevices_33);
            args = new Type[]{};
            method = type.GetMethod("get_disableRedundantEventsMerging", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_disableRedundantEventsMerging_34);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_disableRedundantEventsMerging", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_disableRedundantEventsMerging_35);
            args = new Type[]{};
            method = type.GetMethod("get_shortcutKeysConsumeInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shortcutKeysConsumeInput_36);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_shortcutKeysConsumeInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shortcutKeysConsumeInput_37);
            args = new Type[]{typeof(System.String), typeof(System.Boolean)};
            method = type.GetMethod("SetInternalFeatureFlag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetInternalFeatureFlag_38);
            args = new Type[]{};
            method = type.GetMethod("get_iOS", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_iOS_39);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.InputSettings());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.InputSettings[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_updateMode_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.updateMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_updateMode_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings.UpdateMode @value = (UnityEngine.InputSystem.InputSettings.UpdateMode)typeof(UnityEngine.InputSystem.InputSettings.UpdateMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.updateMode = value;

            return __ret;
        }

        static StackObject* get_compensateForScreenOrientation_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.compensateForScreenOrientation;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_compensateForScreenOrientation_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.compensateForScreenOrientation = value;

            return __ret;
        }

        static StackObject* get_defaultDeadzoneMin_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.defaultDeadzoneMin;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_defaultDeadzoneMin_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.defaultDeadzoneMin = value;

            return __ret;
        }

        static StackObject* get_defaultDeadzoneMax_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.defaultDeadzoneMax;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_defaultDeadzoneMax_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.defaultDeadzoneMax = value;

            return __ret;
        }

        static StackObject* get_defaultButtonPressPoint_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.defaultButtonPressPoint;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_defaultButtonPressPoint_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.defaultButtonPressPoint = value;

            return __ret;
        }

        static StackObject* get_buttonReleaseThreshold_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.buttonReleaseThreshold;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_buttonReleaseThreshold_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.buttonReleaseThreshold = value;

            return __ret;
        }

        static StackObject* get_defaultTapTime_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.defaultTapTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_defaultTapTime_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.defaultTapTime = value;

            return __ret;
        }

        static StackObject* get_defaultSlowTapTime_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.defaultSlowTapTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_defaultSlowTapTime_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.defaultSlowTapTime = value;

            return __ret;
        }

        static StackObject* get_defaultHoldTime_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.defaultHoldTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_defaultHoldTime_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.defaultHoldTime = value;

            return __ret;
        }

        static StackObject* get_tapRadius_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.tapRadius;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_tapRadius_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.tapRadius = value;

            return __ret;
        }

        static StackObject* get_multiTapDelayTime_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.multiTapDelayTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_multiTapDelayTime_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.multiTapDelayTime = value;

            return __ret;
        }

        static StackObject* get_backgroundBehavior_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.backgroundBehavior;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_backgroundBehavior_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings.BackgroundBehavior @value = (UnityEngine.InputSystem.InputSettings.BackgroundBehavior)typeof(UnityEngine.InputSystem.InputSettings.BackgroundBehavior).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.backgroundBehavior = value;

            return __ret;
        }

        static StackObject* get_editorInputBehaviorInPlayMode_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.editorInputBehaviorInPlayMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_editorInputBehaviorInPlayMode_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode @value = (UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode)typeof(UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.editorInputBehaviorInPlayMode = value;

            return __ret;
        }

        static StackObject* get_inputActionPropertyDrawerMode_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.inputActionPropertyDrawerMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_inputActionPropertyDrawerMode_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode @value = (UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode)typeof(UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.inputActionPropertyDrawerMode = value;

            return __ret;
        }

        static StackObject* get_maxEventBytesPerUpdate_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxEventBytesPerUpdate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxEventBytesPerUpdate_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxEventBytesPerUpdate = value;

            return __ret;
        }

        static StackObject* get_maxQueuedEventsPerUpdate_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxQueuedEventsPerUpdate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxQueuedEventsPerUpdate_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxQueuedEventsPerUpdate = value;

            return __ret;
        }

        static StackObject* get_supportedDevices_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.supportedDevices;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_supportedDevices_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String> @value = (UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String>)typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.supportedDevices = value;

            return __ret;
        }

        static StackObject* get_disableRedundantEventsMerging_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.disableRedundantEventsMerging;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_disableRedundantEventsMerging_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.disableRedundantEventsMerging = value;

            return __ret;
        }

        static StackObject* get_shortcutKeysConsumeInput_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.shortcutKeysConsumeInput;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_shortcutKeysConsumeInput_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.shortcutKeysConsumeInput = value;

            return __ret;
        }

        static StackObject* SetInternalFeatureFlag_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @enabled = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @featureName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetInternalFeatureFlag(@featureName, @enabled);

            return __ret;
        }

        static StackObject* get_iOS_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings instance_of_this_method = (UnityEngine.InputSystem.InputSettings)typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.iOS;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.InputSystem.InputSettings();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif