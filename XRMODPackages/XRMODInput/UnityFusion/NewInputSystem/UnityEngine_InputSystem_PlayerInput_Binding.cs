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
    unsafe class UnityEngine_InputSystem_PlayerInput_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.PlayerInput);
            args = new Type[]{};
            method = type.GetMethod("get_inputIsActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inputIsActive_0);
            args = new Type[]{};
            method = type.GetMethod("get_playerIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playerIndex_1);
            args = new Type[]{};
            method = type.GetMethod("get_splitScreenIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_splitScreenIndex_2);
            args = new Type[]{};
            method = type.GetMethod("get_actions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_actions_3);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionAsset)};
            method = type.GetMethod("set_actions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_actions_4);
            args = new Type[]{};
            method = type.GetMethod("get_currentControlScheme", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentControlScheme_5);
            args = new Type[]{};
            method = type.GetMethod("get_defaultControlScheme", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultControlScheme_6);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_defaultControlScheme", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultControlScheme_7);
            args = new Type[]{};
            method = type.GetMethod("get_neverAutoSwitchControlSchemes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_neverAutoSwitchControlSchemes_8);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_neverAutoSwitchControlSchemes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_neverAutoSwitchControlSchemes_9);
            args = new Type[]{};
            method = type.GetMethod("get_currentActionMap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentActionMap_10);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionMap)};
            method = type.GetMethod("set_currentActionMap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_currentActionMap_11);
            args = new Type[]{};
            method = type.GetMethod("get_defaultActionMap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultActionMap_12);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_defaultActionMap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultActionMap_13);
            args = new Type[]{};
            method = type.GetMethod("get_notificationBehavior", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_notificationBehavior_14);
            args = new Type[]{typeof(UnityEngine.InputSystem.PlayerNotifications)};
            method = type.GetMethod("set_notificationBehavior", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_notificationBehavior_15);
            args = new Type[]{};
            method = type.GetMethod("get_actionEvents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_actionEvents_16);
            args = new Type[]{typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent>)};
            method = type.GetMethod("set_actionEvents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_actionEvents_17);
            args = new Type[]{};
            method = type.GetMethod("get_deviceLostEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deviceLostEvent_18);
            args = new Type[]{};
            method = type.GetMethod("get_deviceRegainedEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deviceRegainedEvent_19);
            args = new Type[]{};
            method = type.GetMethod("get_controlsChangedEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_controlsChangedEvent_20);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>)};
            method = type.GetMethod("add_onActionTriggered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onActionTriggered_21);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>)};
            method = type.GetMethod("remove_onActionTriggered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onActionTriggered_22);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.PlayerInput>)};
            method = type.GetMethod("add_onDeviceLost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onDeviceLost_23);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.PlayerInput>)};
            method = type.GetMethod("remove_onDeviceLost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onDeviceLost_24);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.PlayerInput>)};
            method = type.GetMethod("add_onDeviceRegained", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onDeviceRegained_25);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.PlayerInput>)};
            method = type.GetMethod("remove_onDeviceRegained", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onDeviceRegained_26);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.PlayerInput>)};
            method = type.GetMethod("add_onControlsChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onControlsChanged_27);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.PlayerInput>)};
            method = type.GetMethod("remove_onControlsChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onControlsChanged_28);
            args = new Type[]{};
            method = type.GetMethod("get_camera", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_camera_29);
            args = new Type[]{typeof(UnityEngine.Camera)};
            method = type.GetMethod("set_camera", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_camera_30);
            args = new Type[]{};
            method = type.GetMethod("get_uiInputModule", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_uiInputModule_31);
            args = new Type[]{typeof(UnityEngine.InputSystem.UI.InputSystemUIInputModule)};
            method = type.GetMethod("set_uiInputModule", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_uiInputModule_32);
            args = new Type[]{};
            method = type.GetMethod("get_user", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_user_33);
            args = new Type[]{};
            method = type.GetMethod("get_devices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_devices_34);
            args = new Type[]{};
            method = type.GetMethod("get_hasMissingRequiredDevices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasMissingRequiredDevices_35);
            args = new Type[]{};
            method = type.GetMethod("get_all", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_all_36);
            args = new Type[]{};
            method = type.GetMethod("get_isSinglePlayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isSinglePlayer_37);
            args = new Type[]{};
            method = type.GetMethod("ActivateInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ActivateInput_38);
            args = new Type[]{};
            method = type.GetMethod("DeactivateInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeactivateInput_39);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputDevice[])};
            method = type.GetMethod("SwitchCurrentControlScheme", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SwitchCurrentControlScheme_40);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.InputSystem.InputDevice[])};
            method = type.GetMethod("SwitchCurrentControlScheme", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SwitchCurrentControlScheme_41);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("SwitchCurrentActionMap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SwitchCurrentActionMap_42);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPlayerByIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPlayerByIndex_43);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputDevice)};
            method = type.GetMethod("FindFirstPairedToDevice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindFirstPairedToDevice_44);
            args = new Type[]{typeof(UnityEngine.GameObject), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(UnityEngine.InputSystem.InputDevice)};
            method = type.GetMethod("Instantiate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Instantiate_45);
            args = new Type[]{typeof(UnityEngine.GameObject), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(UnityEngine.InputSystem.InputDevice[])};
            method = type.GetMethod("Instantiate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Instantiate_46);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction.CallbackContext)};
            method = type.GetMethod("DebugLogAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DebugLogAction_47);

            field = type.GetField("DeviceLostMessage", flag);
            app.RegisterCLRFieldGetter(field, get_DeviceLostMessage_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_DeviceLostMessage_0, null);
            field = type.GetField("DeviceRegainedMessage", flag);
            app.RegisterCLRFieldGetter(field, get_DeviceRegainedMessage_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_DeviceRegainedMessage_1, null);
            field = type.GetField("ControlsChangedMessage", flag);
            app.RegisterCLRFieldGetter(field, get_ControlsChangedMessage_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_ControlsChangedMessage_2, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.PlayerInput());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.PlayerInput[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_inputIsActive_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.inputIsActive;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_playerIndex_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playerIndex;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_splitScreenIndex_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.splitScreenIndex;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_actions_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.actions;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_actions_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionAsset @value = (UnityEngine.InputSystem.InputActionAsset)typeof(UnityEngine.InputSystem.InputActionAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.actions = value;

            return __ret;
        }

        static StackObject* get_currentControlScheme_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentControlScheme;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_defaultControlScheme_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.defaultControlScheme;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_defaultControlScheme_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.defaultControlScheme = value;

            return __ret;
        }

        static StackObject* get_neverAutoSwitchControlSchemes_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.neverAutoSwitchControlSchemes;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_neverAutoSwitchControlSchemes_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.neverAutoSwitchControlSchemes = value;

            return __ret;
        }

        static StackObject* get_currentActionMap_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentActionMap;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_currentActionMap_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionMap @value = (UnityEngine.InputSystem.InputActionMap)typeof(UnityEngine.InputSystem.InputActionMap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.currentActionMap = value;

            return __ret;
        }

        static StackObject* get_defaultActionMap_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.defaultActionMap;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_defaultActionMap_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.defaultActionMap = value;

            return __ret;
        }

        static StackObject* get_notificationBehavior_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.notificationBehavior;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_notificationBehavior_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerNotifications @value = (UnityEngine.InputSystem.PlayerNotifications)typeof(UnityEngine.InputSystem.PlayerNotifications).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.notificationBehavior = value;

            return __ret;
        }

        static StackObject* get_actionEvents_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.actionEvents;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_actionEvents_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> @value = (UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent>)typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.actionEvents = value;

            return __ret;
        }

        static StackObject* get_deviceLostEvent_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.deviceLostEvent;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_deviceRegainedEvent_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.deviceRegainedEvent;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_controlsChangedEvent_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.controlsChangedEvent;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* add_onActionTriggered_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> @value = (System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>)typeof(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onActionTriggered += value;

            return __ret;
        }

        static StackObject* remove_onActionTriggered_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> @value = (System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>)typeof(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onActionTriggered -= value;

            return __ret;
        }

        static StackObject* add_onDeviceLost_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.PlayerInput> @value = (System.Action<UnityEngine.InputSystem.PlayerInput>)typeof(System.Action<UnityEngine.InputSystem.PlayerInput>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onDeviceLost += value;

            return __ret;
        }

        static StackObject* remove_onDeviceLost_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.PlayerInput> @value = (System.Action<UnityEngine.InputSystem.PlayerInput>)typeof(System.Action<UnityEngine.InputSystem.PlayerInput>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onDeviceLost -= value;

            return __ret;
        }

        static StackObject* add_onDeviceRegained_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.PlayerInput> @value = (System.Action<UnityEngine.InputSystem.PlayerInput>)typeof(System.Action<UnityEngine.InputSystem.PlayerInput>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onDeviceRegained += value;

            return __ret;
        }

        static StackObject* remove_onDeviceRegained_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.PlayerInput> @value = (System.Action<UnityEngine.InputSystem.PlayerInput>)typeof(System.Action<UnityEngine.InputSystem.PlayerInput>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onDeviceRegained -= value;

            return __ret;
        }

        static StackObject* add_onControlsChanged_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.PlayerInput> @value = (System.Action<UnityEngine.InputSystem.PlayerInput>)typeof(System.Action<UnityEngine.InputSystem.PlayerInput>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onControlsChanged += value;

            return __ret;
        }

        static StackObject* remove_onControlsChanged_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.PlayerInput> @value = (System.Action<UnityEngine.InputSystem.PlayerInput>)typeof(System.Action<UnityEngine.InputSystem.PlayerInput>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onControlsChanged -= value;

            return __ret;
        }

        static StackObject* get_camera_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.camera;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_camera_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera @value = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.camera = value;

            return __ret;
        }

        static StackObject* get_uiInputModule_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.uiInputModule;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_uiInputModule_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.InputSystemUIInputModule @value = (UnityEngine.InputSystem.UI.InputSystemUIInputModule)typeof(UnityEngine.InputSystem.UI.InputSystemUIInputModule).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.uiInputModule = value;

            return __ret;
        }

        static StackObject* get_user_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.user;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_devices_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.devices;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_hasMissingRequiredDevices_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasMissingRequiredDevices;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_all_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.PlayerInput.all;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_isSinglePlayer_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.PlayerInput.isSinglePlayer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ActivateInput_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ActivateInput();

            return __ret;
        }

        static StackObject* DeactivateInput_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DeactivateInput();

            return __ret;
        }

        static StackObject* SwitchCurrentControlScheme_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputDevice[] @devices = (UnityEngine.InputSystem.InputDevice[])typeof(UnityEngine.InputSystem.InputDevice[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SwitchCurrentControlScheme(@devices);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SwitchCurrentControlScheme_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputDevice[] @devices = (UnityEngine.InputSystem.InputDevice[])typeof(UnityEngine.InputSystem.InputDevice[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @controlScheme = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SwitchCurrentControlScheme(@controlScheme, @devices);

            return __ret;
        }

        static StackObject* SwitchCurrentActionMap_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @mapNameOrId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SwitchCurrentActionMap(@mapNameOrId);

            return __ret;
        }

        static StackObject* GetPlayerByIndex_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @playerIndex = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.InputSystem.PlayerInput.GetPlayerByIndex(@playerIndex);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* FindFirstPairedToDevice_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputDevice @device = (UnityEngine.InputSystem.InputDevice)typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.PlayerInput.FindFirstPairedToDevice(@device);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Instantiate_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputDevice @pairWithDevice = (UnityEngine.InputSystem.InputDevice)typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @splitScreenIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @controlScheme = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @playerIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.GameObject @prefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.PlayerInput.Instantiate(@prefab, @playerIndex, @controlScheme, @splitScreenIndex, @pairWithDevice);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Instantiate_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputDevice[] @pairWithDevices = (UnityEngine.InputSystem.InputDevice[])typeof(UnityEngine.InputSystem.InputDevice[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @splitScreenIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @controlScheme = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @playerIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.GameObject @prefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.PlayerInput.Instantiate(@prefab, @playerIndex, @controlScheme, @splitScreenIndex, @pairWithDevices);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DebugLogAction_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputAction.CallbackContext @context = (UnityEngine.InputSystem.InputAction.CallbackContext)typeof(UnityEngine.InputSystem.InputAction.CallbackContext).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInput instance_of_this_method = (UnityEngine.InputSystem.PlayerInput)typeof(UnityEngine.InputSystem.PlayerInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DebugLogAction(@context);

            return __ret;
        }


        static object get_DeviceLostMessage_0(ref object o)
        {
            return UnityEngine.InputSystem.PlayerInput.DeviceLostMessage;
        }

        static StackObject* CopyToStack_DeviceLostMessage_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.PlayerInput.DeviceLostMessage;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_DeviceRegainedMessage_1(ref object o)
        {
            return UnityEngine.InputSystem.PlayerInput.DeviceRegainedMessage;
        }

        static StackObject* CopyToStack_DeviceRegainedMessage_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.PlayerInput.DeviceRegainedMessage;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ControlsChangedMessage_2(ref object o)
        {
            return UnityEngine.InputSystem.PlayerInput.ControlsChangedMessage;
        }

        static StackObject* CopyToStack_ControlsChangedMessage_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.PlayerInput.ControlsChangedMessage;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.InputSystem.PlayerInput();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
