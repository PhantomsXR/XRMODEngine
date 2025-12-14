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
    unsafe class UnityEngine_InputSystem_PlayerInputManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.PlayerInputManager);
            args = new Type[]{};
            method = type.GetMethod("get_splitScreen", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_splitScreen_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_splitScreen", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_splitScreen_1);
            args = new Type[]{};
            method = type.GetMethod("get_maintainAspectRatioInSplitScreen", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maintainAspectRatioInSplitScreen_2);
            args = new Type[]{};
            method = type.GetMethod("get_fixedNumberOfSplitScreens", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fixedNumberOfSplitScreens_3);
            args = new Type[]{};
            method = type.GetMethod("get_splitScreenArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_splitScreenArea_4);
            args = new Type[]{};
            method = type.GetMethod("get_playerCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playerCount_5);
            args = new Type[]{};
            method = type.GetMethod("get_maxPlayerCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxPlayerCount_6);
            args = new Type[]{};
            method = type.GetMethod("get_joiningEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_joiningEnabled_7);
            args = new Type[]{};
            method = type.GetMethod("get_joinBehavior", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_joinBehavior_8);
            args = new Type[]{typeof(UnityEngine.InputSystem.PlayerJoinBehavior)};
            method = type.GetMethod("set_joinBehavior", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_joinBehavior_9);
            args = new Type[]{};
            method = type.GetMethod("get_joinAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_joinAction_10);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionProperty)};
            method = type.GetMethod("set_joinAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_joinAction_11);
            args = new Type[]{};
            method = type.GetMethod("get_notificationBehavior", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_notificationBehavior_12);
            args = new Type[]{typeof(UnityEngine.InputSystem.PlayerNotifications)};
            method = type.GetMethod("set_notificationBehavior", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_notificationBehavior_13);
            args = new Type[]{};
            method = type.GetMethod("get_playerJoinedEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playerJoinedEvent_14);
            args = new Type[]{};
            method = type.GetMethod("get_playerLeftEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playerLeftEvent_15);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.PlayerInput>)};
            method = type.GetMethod("add_onPlayerJoined", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onPlayerJoined_16);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.PlayerInput>)};
            method = type.GetMethod("remove_onPlayerJoined", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onPlayerJoined_17);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.PlayerInput>)};
            method = type.GetMethod("add_onPlayerLeft", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onPlayerLeft_18);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.PlayerInput>)};
            method = type.GetMethod("remove_onPlayerLeft", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onPlayerLeft_19);
            args = new Type[]{};
            method = type.GetMethod("get_playerPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playerPrefab_20);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_playerPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playerPrefab_21);
            args = new Type[]{};
            method = type.GetMethod("get_instance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_instance_22);
            args = new Type[]{};
            method = type.GetMethod("EnableJoining", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EnableJoining_23);
            args = new Type[]{};
            method = type.GetMethod("DisableJoining", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DisableJoining_24);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction.CallbackContext)};
            method = type.GetMethod("JoinPlayerFromAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, JoinPlayerFromAction_25);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction.CallbackContext)};
            method = type.GetMethod("JoinPlayerFromActionIfNotAlreadyJoined", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, JoinPlayerFromActionIfNotAlreadyJoined_26);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.InputSystem.InputDevice)};
            method = type.GetMethod("JoinPlayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, JoinPlayer_27);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.InputSystem.InputDevice[])};
            method = type.GetMethod("JoinPlayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, JoinPlayer_28);

            field = type.GetField("PlayerJoinedMessage", flag);
            app.RegisterCLRFieldGetter(field, get_PlayerJoinedMessage_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayerJoinedMessage_0, null);
            field = type.GetField("PlayerLeftMessage", flag);
            app.RegisterCLRFieldGetter(field, get_PlayerLeftMessage_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayerLeftMessage_1, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.PlayerInputManager());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.PlayerInputManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_splitScreen_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.splitScreen;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_splitScreen_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.splitScreen = value;

            return __ret;
        }

        static StackObject* get_maintainAspectRatioInSplitScreen_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maintainAspectRatioInSplitScreen;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_fixedNumberOfSplitScreens_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.fixedNumberOfSplitScreens;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_splitScreenArea_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.splitScreenArea;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_playerCount_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playerCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxPlayerCount_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxPlayerCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_joiningEnabled_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.joiningEnabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_joinBehavior_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.joinBehavior;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_joinBehavior_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerJoinBehavior @value = (UnityEngine.InputSystem.PlayerJoinBehavior)typeof(UnityEngine.InputSystem.PlayerJoinBehavior).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.joinBehavior = value;

            return __ret;
        }

        static StackObject* get_joinAction_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.joinAction;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_joinAction_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionProperty @value = (UnityEngine.InputSystem.InputActionProperty)typeof(UnityEngine.InputSystem.InputActionProperty).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.joinAction = value;

            return __ret;
        }

        static StackObject* get_notificationBehavior_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.notificationBehavior;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_notificationBehavior_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerNotifications @value = (UnityEngine.InputSystem.PlayerNotifications)typeof(UnityEngine.InputSystem.PlayerNotifications).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.notificationBehavior = value;

            return __ret;
        }

        static StackObject* get_playerJoinedEvent_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playerJoinedEvent;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_playerLeftEvent_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playerLeftEvent;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* add_onPlayerJoined_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.PlayerInput> @value = (System.Action<UnityEngine.InputSystem.PlayerInput>)typeof(System.Action<UnityEngine.InputSystem.PlayerInput>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onPlayerJoined += value;

            return __ret;
        }

        static StackObject* remove_onPlayerJoined_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.PlayerInput> @value = (System.Action<UnityEngine.InputSystem.PlayerInput>)typeof(System.Action<UnityEngine.InputSystem.PlayerInput>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onPlayerJoined -= value;

            return __ret;
        }

        static StackObject* add_onPlayerLeft_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.PlayerInput> @value = (System.Action<UnityEngine.InputSystem.PlayerInput>)typeof(System.Action<UnityEngine.InputSystem.PlayerInput>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onPlayerLeft += value;

            return __ret;
        }

        static StackObject* remove_onPlayerLeft_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.PlayerInput> @value = (System.Action<UnityEngine.InputSystem.PlayerInput>)typeof(System.Action<UnityEngine.InputSystem.PlayerInput>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onPlayerLeft -= value;

            return __ret;
        }

        static StackObject* get_playerPrefab_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playerPrefab;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_playerPrefab_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playerPrefab = value;

            return __ret;
        }

        static StackObject* get_instance_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.PlayerInputManager.instance;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* EnableJoining_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.EnableJoining();

            return __ret;
        }

        static StackObject* DisableJoining_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DisableJoining();

            return __ret;
        }

        static StackObject* JoinPlayerFromAction_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputAction.CallbackContext @context = (UnityEngine.InputSystem.InputAction.CallbackContext)typeof(UnityEngine.InputSystem.InputAction.CallbackContext).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.JoinPlayerFromAction(@context);

            return __ret;
        }

        static StackObject* JoinPlayerFromActionIfNotAlreadyJoined_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputAction.CallbackContext @context = (UnityEngine.InputSystem.InputAction.CallbackContext)typeof(UnityEngine.InputSystem.InputAction.CallbackContext).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.JoinPlayerFromActionIfNotAlreadyJoined(@context);

            return __ret;
        }

        static StackObject* JoinPlayer_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputDevice @pairWithDevice = (UnityEngine.InputSystem.InputDevice)typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @controlScheme = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @splitScreenIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @playerIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.JoinPlayer(@playerIndex, @splitScreenIndex, @controlScheme, @pairWithDevice);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* JoinPlayer_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputDevice[] @pairWithDevices = (UnityEngine.InputSystem.InputDevice[])typeof(UnityEngine.InputSystem.InputDevice[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @controlScheme = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @splitScreenIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @playerIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.InputSystem.PlayerInputManager instance_of_this_method = (UnityEngine.InputSystem.PlayerInputManager)typeof(UnityEngine.InputSystem.PlayerInputManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.JoinPlayer(@playerIndex, @splitScreenIndex, @controlScheme, @pairWithDevices);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_PlayerJoinedMessage_0(ref object o)
        {
            return UnityEngine.InputSystem.PlayerInputManager.PlayerJoinedMessage;
        }

        static StackObject* CopyToStack_PlayerJoinedMessage_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.PlayerInputManager.PlayerJoinedMessage;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_PlayerLeftMessage_1(ref object o)
        {
            return UnityEngine.InputSystem.PlayerInputManager.PlayerLeftMessage;
        }

        static StackObject* CopyToStack_PlayerLeftMessage_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.PlayerInputManager.PlayerLeftMessage;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.InputSystem.PlayerInputManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
