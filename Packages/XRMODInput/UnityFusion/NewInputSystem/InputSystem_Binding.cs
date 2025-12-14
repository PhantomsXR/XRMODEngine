using System;
using System.Collections.Generic;
using System.Linq;
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
    unsafe class InputSystem_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.InputSystem);
            MethodInfo[] methods = type.GetMethods(flag).Where(t => !t.IsGenericMethod).ToArray();
            args = new Type[] {typeof(System.Action<System.String, UnityEngine.InputSystem.InputControlLayoutChange>)};
            method = type.GetMethod("add_onLayoutChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onLayoutChange_0);
            args = new Type[] {typeof(System.Action<System.String, UnityEngine.InputSystem.InputControlLayoutChange>)};
            method = type.GetMethod("remove_onLayoutChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onLayoutChange_1);
            args = new Type[]
            {
                typeof(System.Type), typeof(System.String),
                typeof(System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)
            };
            method = type.GetMethod("RegisterLayout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterLayout_2);
            args = new Type[]
            {
                typeof(System.String), typeof(System.String),
                typeof(System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)
            };
            method = type.GetMethod("RegisterLayout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterLayout_3);
            args = new Type[] {typeof(System.String), typeof(System.String)};
            method = type.GetMethod("RegisterLayoutOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterLayoutOverride_4);
            args = new Type[] {typeof(System.String), typeof(UnityEngine.InputSystem.Layouts.InputDeviceMatcher)};
            method = type.GetMethod("RegisterLayoutMatcher", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterLayoutMatcher_5);
            args = new Type[]
            {
                typeof(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout>), typeof(System.String),
                typeof(System.String), typeof(System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)
            };
            method = type.GetMethod("RegisterLayoutBuilder", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterLayoutBuilder_6);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("RemoveLayout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveLayout_7);
            args = new Type[] {typeof(UnityEngine.InputSystem.Layouts.InputDeviceDescription)};
            method = type.GetMethod("TryFindMatchingLayout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryFindMatchingLayout_8);
            args = new Type[] { };
            method = type.GetMethod("ListLayouts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ListLayouts_9);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("ListLayoutsBasedOn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ListLayoutsBasedOn_10);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("LoadLayout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadLayout_11);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("GetNameOfBaseLayout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNameOfBaseLayout_12);
            args = new Type[] {typeof(System.String), typeof(System.String)};
            method = type.GetMethod("IsFirstLayoutBasedOnSecond", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsFirstLayoutBasedOnSecond_13);
            args = new Type[] {typeof(System.Type), typeof(System.String)};
            method = type.GetMethod("RegisterProcessor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterProcessor_14);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("TryGetProcessor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetProcessor_15);
            args = new Type[] { };
            method = type.GetMethod("ListProcessors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ListProcessors_16);
            args = new Type[] { };
            method = type.GetMethod("get_devices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_devices_17);
            args = new Type[] { };
            method = type.GetMethod("get_disconnectedDevices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_disconnectedDevices_18);
            args = new Type[]
                {typeof(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)};
            method = type.GetMethod("add_onDeviceChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onDeviceChange_19);
            args = new Type[]
                {typeof(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)};
            method = type.GetMethod("remove_onDeviceChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onDeviceChange_20);
            args = new Type[] {typeof(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate)};
            method = type.GetMethod("add_onDeviceCommand", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onDeviceCommand_21);
            args = new Type[] {typeof(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate)};
            method = type.GetMethod("remove_onDeviceCommand", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onDeviceCommand_22);
            args = new Type[] {typeof(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate)};
            method = type.GetMethod("add_onFindLayoutForDevice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onFindLayoutForDevice_23);
            args = new Type[] {typeof(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate)};
            method = type.GetMethod("remove_onFindLayoutForDevice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onFindLayoutForDevice_24);
            args = new Type[] {typeof(System.String)};
            method = methods.Where(t => t.Name.Equals("GetDevice") && t.CheckMethodParams(args)).Single();
            app.RegisterCLRMethodRedirection(method, GetDevice_32);
            args = new Type[] {typeof(System.Type)};
            method = type.GetMethod("GetDevice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDevice_33);
            args = new Type[] {typeof(UnityEngine.InputSystem.InputDevice)};
            method = type.GetMethod("EnableDevice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EnableDevice_37);
            args = new Type[] {typeof(UnityEngine.InputSystem.InputDevice), typeof(System.Boolean)};
            method = type.GetMethod("DisableDevice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DisableDevice_38);
            args = new Type[] {typeof(UnityEngine.InputSystem.InputDevice), typeof(System.Boolean)};
            method = type.GetMethod("ResetDevice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetDevice_40);
            args = new Type[] { };
            method = type.GetMethod("PauseHaptics", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PauseHaptics_41);
            args = new Type[] { };
            method = type.GetMethod("ResumeHaptics", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResumeHaptics_42);
            args = new Type[] { };
            method = type.GetMethod("ResetHaptics", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetHaptics_43);
            args = new Type[] {typeof(UnityEngine.InputSystem.InputDevice), typeof(System.String)};
            method = type.GetMethod("SetDeviceUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDeviceUsage_44);
            args = new Type[]
                {typeof(UnityEngine.InputSystem.InputDevice), typeof(UnityEngine.InputSystem.Utilities.InternedString)};
            method = type.GetMethod("SetDeviceUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDeviceUsage_45);
            args = new Type[] {typeof(UnityEngine.InputSystem.InputDevice), typeof(System.String)};
            method = type.GetMethod("AddDeviceUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddDeviceUsage_46);
            args = new Type[]
                {typeof(UnityEngine.InputSystem.InputDevice), typeof(UnityEngine.InputSystem.Utilities.InternedString)};
            method = type.GetMethod("AddDeviceUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddDeviceUsage_47);
            args = new Type[] {typeof(UnityEngine.InputSystem.InputDevice), typeof(System.String)};
            method = type.GetMethod("RemoveDeviceUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveDeviceUsage_48);
            args = new Type[]
                {typeof(UnityEngine.InputSystem.InputDevice), typeof(UnityEngine.InputSystem.Utilities.InternedString)};
            method = type.GetMethod("RemoveDeviceUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveDeviceUsage_49);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("FindControl", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindControl_50);
            args = new Type[] {typeof(System.String)};
            method = methods.Where(t => t.Name.Equals("FindControls") && t.CheckMethodParams(args)).Single();
            app.RegisterCLRMethodRedirection(method, FindControls_51);
            args = new Type[] { };
            method = type.GetMethod("get_onEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onEvent_52);
            args = new Type[] {typeof(UnityEngine.InputSystem.LowLevel.InputEventListener)};
            method = type.GetMethod("set_onEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onEvent_53);
            args = new Type[] { };
            method = type.GetMethod("get_onAnyButtonPress", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onAnyButtonPress_54);
            args = new Type[] {typeof(UnityEngine.InputSystem.LowLevel.InputEventPtr)};
            method = type.GetMethod("QueueEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, QueueEvent_55);
            args = new Type[] {typeof(UnityEngine.InputSystem.InputDevice), typeof(System.Double)};
            method = type.GetMethod("QueueConfigChangeEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, QueueConfigChangeEvent_56);
            args = new Type[] {typeof(UnityEngine.InputSystem.InputDevice), typeof(System.Char), typeof(System.Double)};
            method = type.GetMethod("QueueTextEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, QueueTextEvent_57);

            args = new Type[] { };
            method = type.GetMethod("get_settings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_settings_63);
            args = new Type[] {typeof(UnityEngine.InputSystem.InputSettings)};
            method = type.GetMethod("set_settings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_settings_64);
            args = new Type[] {typeof(System.Action)};
            method = type.GetMethod("add_onSettingsChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onSettingsChange_65);
            args = new Type[] {typeof(System.Action)};
            method = type.GetMethod("remove_onSettingsChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onSettingsChange_66);


            args = new Type[] { };
            method = type.GetMethod("get_actions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_actions_69);
            args = new Type[] {typeof(UnityEngine.InputSystem.InputActionAsset)};
            method = type.GetMethod("set_actions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_actions_70);
            args = new Type[] {typeof(System.Action)};
            method = type.GetMethod("add_onActionsChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onActionsChange_71);
            args = new Type[] {typeof(System.Action)};
            method = type.GetMethod("remove_onActionsChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onActionsChange_72);
            args = new Type[] {typeof(System.Action<System.Object, UnityEngine.InputSystem.InputActionChange>)};
            method = type.GetMethod("add_onActionChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onActionChange_73);
            args = new Type[] {typeof(System.Action<System.Object, UnityEngine.InputSystem.InputActionChange>)};
            method = type.GetMethod("remove_onActionChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onActionChange_74);
            args = new Type[] {typeof(System.Type), typeof(System.String)};
            method = type.GetMethod("RegisterInteraction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterInteraction_75);
            args = new Type[] {typeof(System.Type), typeof(System.String)};
            method = type.GetMethod("RegisterBindingComposite", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterBindingComposite_78);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("TryGetBindingComposite", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetBindingComposite_79);
            args = new Type[] { };
            method = type.GetMethod("DisableAllEnabledActions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DisableAllEnabledActions_80);
            args = new Type[] { };
            method = type.GetMethod("ListEnabledActions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ListEnabledActions_81);
            args = new Type[] {typeof(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction>)};
            method = type.GetMethod("ListEnabledActions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ListEnabledActions_82);
            args = new Type[] { };
            method = type.GetMethod("get_remoting", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_remoting_83);
            args = new Type[] { };
            method = type.GetMethod("get_version", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_version_84);
            args = new Type[] { };
            method = type.GetMethod("get_runInBackground", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_runInBackground_85);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_runInBackground", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_runInBackground_86);
            args = new Type[] { };
            method = type.GetMethod("get_metrics", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_metrics_87);
        }


        static StackObject* add_onLayoutChange_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String, UnityEngine.InputSystem.InputControlLayoutChange> @value =
                (System.Action<System.String, UnityEngine.InputSystem.InputControlLayoutChange>)
                typeof(System.Action<System.String, UnityEngine.InputSystem.InputControlLayoutChange>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onLayoutChange += value;

            return __ret;
        }

        static StackObject* remove_onLayoutChange_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String, UnityEngine.InputSystem.InputControlLayoutChange> @value =
                (System.Action<System.String, UnityEngine.InputSystem.InputControlLayoutChange>)
                typeof(System.Action<System.String, UnityEngine.InputSystem.InputControlLayoutChange>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onLayoutChange -= value;

            return __ret;
        }

        static StackObject* RegisterLayout_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> @matches =
                (System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)
                typeof(System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Type @type = (System.Type) typeof(System.Type).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.RegisterLayout(@type, @name, @matches);

            return __ret;
        }

        static StackObject* RegisterLayout_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> @matches =
                (System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)
                typeof(System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @json = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.RegisterLayout(@json, @name, @matches);

            return __ret;
        }

        static StackObject* RegisterLayoutOverride_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @json = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.RegisterLayoutOverride(@json, @name);

            return __ret;
        }

        static StackObject* RegisterLayoutMatcher_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Layouts.InputDeviceMatcher @matcher =
                (UnityEngine.InputSystem.Layouts.InputDeviceMatcher)
                typeof(UnityEngine.InputSystem.Layouts.InputDeviceMatcher).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @layoutName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.RegisterLayoutMatcher(@layoutName, @matcher);

            return __ret;
        }

        static StackObject* RegisterLayoutBuilder_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> @matches =
                (System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)
                typeof(System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @baseLayout = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> @buildMethod =
                (System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout>)
                typeof(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.RegisterLayoutBuilder(@buildMethod, @name, @baseLayout, @matches);

            return __ret;
        }

        static StackObject* RemoveLayout_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.RemoveLayout(@name);

            return __ret;
        }

        static StackObject* TryFindMatchingLayout_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Layouts.InputDeviceDescription @deviceDescription =
                (UnityEngine.InputSystem.Layouts.InputDeviceDescription)
                typeof(UnityEngine.InputSystem.Layouts.InputDeviceDescription).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.TryFindMatchingLayout(@deviceDescription);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ListLayouts_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.ListLayouts();

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ListLayoutsBasedOn_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @baseLayout = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.ListLayoutsBasedOn(@baseLayout);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* LoadLayout_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.LoadLayout(@name);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetNameOfBaseLayout_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @layoutName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.GetNameOfBaseLayout(@layoutName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsFirstLayoutBasedOnSecond_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @secondLayoutName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @firstLayoutName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.InputSystem.InputSystem.IsFirstLayoutBasedOnSecond(@firstLayoutName, @secondLayoutName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RegisterProcessor_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @type = (System.Type) typeof(System.Type).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.RegisterProcessor(@type, @name);

            return __ret;
        }

        static StackObject* TryGetProcessor_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.TryGetProcessor(@name);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ListProcessors_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.ListProcessors();

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_devices_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.devices;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_disconnectedDevices_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.disconnectedDevices;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* add_onDeviceChange_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange> @value =
                (System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)
                typeof(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onDeviceChange += value;

            return __ret;
        }

        static StackObject* remove_onDeviceChange_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange> @value =
                (System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)
                typeof(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onDeviceChange -= value;

            return __ret;
        }

        static StackObject* add_onDeviceCommand_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate @value =
                (UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate)
                typeof(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onDeviceCommand += value;

            return __ret;
        }

        static StackObject* remove_onDeviceCommand_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate @value =
                (UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate)
                typeof(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onDeviceCommand -= value;

            return __ret;
        }

        static StackObject* add_onFindLayoutForDevice_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate @value =
                (UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate)
                typeof(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onFindLayoutForDevice += value;

            return __ret;
        }

        static StackObject* remove_onFindLayoutForDevice_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate @value =
                (UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate)
                typeof(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onFindLayoutForDevice -= value;

            return __ret;
        }


        static StackObject* GetDevice_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @nameOrLayout = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.GetDevice(@nameOrLayout);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetDevice_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type = (System.Type) typeof(System.Type).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.GetDevice(@type);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static StackObject* EnableDevice_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputDevice @device =
                (UnityEngine.InputSystem.InputDevice) typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.EnableDevice(@device);

            return __ret;
        }

        static StackObject* DisableDevice_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @keepSendingEvents = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputDevice @device =
                (UnityEngine.InputSystem.InputDevice) typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.DisableDevice(@device, @keepSendingEvents);

            return __ret;
        }


        static StackObject* ResetDevice_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @alsoResetDontResetControls = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputDevice @device =
                (UnityEngine.InputSystem.InputDevice) typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.ResetDevice(@device, @alsoResetDontResetControls);

            return __ret;
        }

        static StackObject* PauseHaptics_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.InputSystem.InputSystem.PauseHaptics();

            return __ret;
        }

        static StackObject* ResumeHaptics_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.InputSystem.InputSystem.ResumeHaptics();

            return __ret;
        }

        static StackObject* ResetHaptics_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.InputSystem.InputSystem.ResetHaptics();

            return __ret;
        }

        static StackObject* SetDeviceUsage_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @usage = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputDevice @device =
                (UnityEngine.InputSystem.InputDevice) typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.SetDeviceUsage(@device, @usage);

            return __ret;
        }

        static StackObject* SetDeviceUsage_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Utilities.InternedString @usage =
                (UnityEngine.InputSystem.Utilities.InternedString)
                typeof(UnityEngine.InputSystem.Utilities.InternedString).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputDevice @device =
                (UnityEngine.InputSystem.InputDevice) typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.SetDeviceUsage(@device, @usage);

            return __ret;
        }

        static StackObject* AddDeviceUsage_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @usage = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputDevice @device =
                (UnityEngine.InputSystem.InputDevice) typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.AddDeviceUsage(@device, @usage);

            return __ret;
        }

        static StackObject* AddDeviceUsage_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Utilities.InternedString @usage =
                (UnityEngine.InputSystem.Utilities.InternedString)
                typeof(UnityEngine.InputSystem.Utilities.InternedString).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputDevice @device =
                (UnityEngine.InputSystem.InputDevice) typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.AddDeviceUsage(@device, @usage);

            return __ret;
        }

        static StackObject* RemoveDeviceUsage_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @usage = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputDevice @device =
                (UnityEngine.InputSystem.InputDevice) typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.RemoveDeviceUsage(@device, @usage);

            return __ret;
        }

        static StackObject* RemoveDeviceUsage_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Utilities.InternedString @usage =
                (UnityEngine.InputSystem.Utilities.InternedString)
                typeof(UnityEngine.InputSystem.Utilities.InternedString).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputDevice @device =
                (UnityEngine.InputSystem.InputDevice) typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.RemoveDeviceUsage(@device, @usage);

            return __ret;
        }

        static StackObject* FindControl_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @path = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.FindControl(@path);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* FindControls_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @path = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.FindControls(@path);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_onEvent_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.onEvent;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onEvent_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.LowLevel.InputEventListener @value =
                (UnityEngine.InputSystem.LowLevel.InputEventListener)
                typeof(UnityEngine.InputSystem.LowLevel.InputEventListener).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onEvent = value;

            return __ret;
        }

        static StackObject* get_onAnyButtonPress_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.onAnyButtonPress;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* QueueEvent_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.LowLevel.InputEventPtr @eventPtr =
                (UnityEngine.InputSystem.LowLevel.InputEventPtr) typeof(UnityEngine.InputSystem.LowLevel.InputEventPtr)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.QueueEvent(@eventPtr);

            return __ret;
        }

        static StackObject* QueueConfigChangeEvent_56(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @time = *(double*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputDevice @device =
                (UnityEngine.InputSystem.InputDevice) typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.QueueConfigChangeEvent(@device, @time);

            return __ret;
        }

        static StackObject* QueueTextEvent_57(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @time = *(double*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Char @character = (char) ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputDevice @device =
                (UnityEngine.InputSystem.InputDevice) typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.QueueTextEvent(@device, @character, @time);

            return __ret;
        }


        static StackObject* get_settings_63(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.settings;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_settings_64(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputSettings @value =
                (UnityEngine.InputSystem.InputSettings) typeof(UnityEngine.InputSystem.InputSettings).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.settings = value;

            return __ret;
        }

        static StackObject* add_onSettingsChange_65(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action) typeof(System.Action).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onSettingsChange += value;

            return __ret;
        }

        static StackObject* remove_onSettingsChange_66(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action) typeof(System.Action).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onSettingsChange -= value;

            return __ret;
        }


        static StackObject* get_actions_69(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.actions;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_actions_70(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionAsset @value =
                (UnityEngine.InputSystem.InputActionAsset) typeof(UnityEngine.InputSystem.InputActionAsset)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.actions = value;

            return __ret;
        }

        static StackObject* add_onActionsChange_71(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action) typeof(System.Action).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onActionsChange += value;

            return __ret;
        }

        static StackObject* remove_onActionsChange_72(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action) typeof(System.Action).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onActionsChange -= value;

            return __ret;
        }

        static StackObject* add_onActionChange_73(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Object, UnityEngine.InputSystem.InputActionChange> @value =
                (System.Action<System.Object, UnityEngine.InputSystem.InputActionChange>)
                typeof(System.Action<System.Object, UnityEngine.InputSystem.InputActionChange>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onActionChange += value;

            return __ret;
        }

        static StackObject* remove_onActionChange_74(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Object, UnityEngine.InputSystem.InputActionChange> @value =
                (System.Action<System.Object, UnityEngine.InputSystem.InputActionChange>)
                typeof(System.Action<System.Object, UnityEngine.InputSystem.InputActionChange>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.onActionChange -= value;

            return __ret;
        }

        static StackObject* RegisterInteraction_75(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @type = (System.Type) typeof(System.Type).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.RegisterInteraction(@type, @name);

            return __ret;
        }


        static StackObject* RegisterBindingComposite_78(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @type = (System.Type) typeof(System.Type).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputSystem.RegisterBindingComposite(@type, @name);

            return __ret;
        }

        static StackObject* TryGetBindingComposite_79(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.TryGetBindingComposite(@name);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DisableAllEnabledActions_80(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.InputSystem.InputSystem.DisableAllEnabledActions();

            return __ret;
        }

        static StackObject* ListEnabledActions_81(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.ListEnabledActions();

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ListEnabledActions_82(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> @actions =
                (System.Collections.Generic.List<UnityEngine.InputSystem.InputAction>)
                typeof(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.ListEnabledActions(@actions);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_remoting_83(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.remoting;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_version_84(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.version;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_runInBackground_85(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.runInBackground;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_runInBackground_86(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.InputSystem.InputSystem.runInBackground = value;

            return __ret;
        }

        static StackObject* get_metrics_87(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.InputSystem.metrics;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}