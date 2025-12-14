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
    unsafe class InputActionRebindingExtensions_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.InputActionRebindingExtensions);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(System.String), typeof(UnityEngine.InputSystem.InputBinding)};
            method = type.GetMethod("GetParameterValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetParameterValue_0);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("GetParameterValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetParameterValue_1);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionMap), typeof(System.String), typeof(UnityEngine.InputSystem.Utilities.PrimitiveValue), typeof(UnityEngine.InputSystem.InputBinding)};
            method = type.GetMethod("ApplyParameterOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyParameterOverride_2);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionAsset), typeof(System.String), typeof(UnityEngine.InputSystem.Utilities.PrimitiveValue), typeof(UnityEngine.InputSystem.InputBinding)};
            method = type.GetMethod("ApplyParameterOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyParameterOverride_3);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(System.String), typeof(UnityEngine.InputSystem.Utilities.PrimitiveValue), typeof(UnityEngine.InputSystem.InputBinding)};
            method = type.GetMethod("ApplyParameterOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyParameterOverride_4);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(System.String), typeof(UnityEngine.InputSystem.Utilities.PrimitiveValue), typeof(System.Int32)};
            method = type.GetMethod("ApplyParameterOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyParameterOverride_5);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(UnityEngine.InputSystem.InputBinding)};
            method = type.GetMethod("GetBindingIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBindingIndex_6);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionMap), typeof(UnityEngine.InputSystem.InputBinding)};
            method = type.GetMethod("GetBindingIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBindingIndex_7);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(System.String), typeof(System.String)};
            method = type.GetMethod("GetBindingIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBindingIndex_8);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(UnityEngine.InputSystem.InputControl)};
            method = type.GetMethod("GetBindingForControl", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBindingForControl_9);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(UnityEngine.InputSystem.InputControl)};
            method = type.GetMethod("GetBindingIndexForControl", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBindingIndexForControl_10);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(UnityEngine.InputSystem.InputBinding.DisplayStringOptions), typeof(System.String)};
            method = type.GetMethod("GetBindingDisplayString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBindingDisplayString_11);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(UnityEngine.InputSystem.InputBinding), typeof(UnityEngine.InputSystem.InputBinding.DisplayStringOptions)};
            method = type.GetMethod("GetBindingDisplayString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBindingDisplayString_12);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(System.Int32), typeof(UnityEngine.InputSystem.InputBinding.DisplayStringOptions)};
            method = type.GetMethod("GetBindingDisplayString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBindingDisplayString_13);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(System.Int32), typeof(System.String).MakeByRefType(), typeof(System.String).MakeByRefType(), typeof(UnityEngine.InputSystem.InputBinding.DisplayStringOptions)};
            method = type.GetMethod("GetBindingDisplayString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBindingDisplayString_14);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(System.String), typeof(System.String), typeof(System.String)};
            method = type.GetMethod("ApplyBindingOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyBindingOverride_15);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(UnityEngine.InputSystem.InputBinding)};
            method = type.GetMethod("ApplyBindingOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyBindingOverride_16);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(System.Int32), typeof(UnityEngine.InputSystem.InputBinding)};
            method = type.GetMethod("ApplyBindingOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyBindingOverride_17);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(System.Int32), typeof(System.String)};
            method = type.GetMethod("ApplyBindingOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyBindingOverride_18);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionMap), typeof(UnityEngine.InputSystem.InputBinding)};
            method = type.GetMethod("ApplyBindingOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyBindingOverride_19);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionMap), typeof(System.Int32), typeof(UnityEngine.InputSystem.InputBinding)};
            method = type.GetMethod("ApplyBindingOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyBindingOverride_20);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(System.Int32)};
            method = type.GetMethod("RemoveBindingOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveBindingOverride_21);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(UnityEngine.InputSystem.InputBinding)};
            method = type.GetMethod("RemoveBindingOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveBindingOverride_22);
            args = new Type[]{typeof(UnityEngine.InputSystem.IInputActionCollection2)};
            method = type.GetMethod("RemoveAllBindingOverrides", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveAllBindingOverrides_23);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction)};
            method = type.GetMethod("RemoveAllBindingOverrides", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveAllBindingOverrides_24);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionMap), typeof(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>)};
            method = type.GetMethod("ApplyBindingOverrides", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyBindingOverrides_25);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionMap), typeof(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>)};
            method = type.GetMethod("RemoveBindingOverrides", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveBindingOverrides_26);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(UnityEngine.InputSystem.InputControl)};
            method = type.GetMethod("ApplyBindingOverridesOnMatchingControls", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyBindingOverridesOnMatchingControls_27);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionMap), typeof(UnityEngine.InputSystem.InputControl)};
            method = type.GetMethod("ApplyBindingOverridesOnMatchingControls", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyBindingOverridesOnMatchingControls_28);
            args = new Type[]{typeof(UnityEngine.InputSystem.IInputActionCollection2)};
            method = type.GetMethod("SaveBindingOverridesAsJson", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SaveBindingOverridesAsJson_29);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction)};
            method = type.GetMethod("SaveBindingOverridesAsJson", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SaveBindingOverridesAsJson_30);
            args = new Type[]{typeof(UnityEngine.InputSystem.IInputActionCollection2), typeof(System.String), typeof(System.Boolean)};
            method = type.GetMethod("LoadBindingOverridesFromJson", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadBindingOverridesFromJson_31);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(System.String), typeof(System.Boolean)};
            method = type.GetMethod("LoadBindingOverridesFromJson", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadBindingOverridesFromJson_32);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction), typeof(System.Int32)};
            method = type.GetMethod("PerformInteractiveRebinding", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PerformInteractiveRebinding_33);





        }


        static StackObject* GetParameterValue_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputBinding @bindingMask = (UnityEngine.InputSystem.InputBinding)typeof(UnityEngine.InputSystem.InputBinding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.GetParameterValue(@action, @name, @bindingMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetParameterValue_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @bindingIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.GetParameterValue(@action, @name, @bindingIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ApplyParameterOverride_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputBinding @bindingMask = (UnityEngine.InputSystem.InputBinding)typeof(UnityEngine.InputSystem.InputBinding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.Utilities.PrimitiveValue @value = (UnityEngine.InputSystem.Utilities.PrimitiveValue)typeof(UnityEngine.InputSystem.Utilities.PrimitiveValue).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.InputSystem.InputActionMap @actionMap = (UnityEngine.InputSystem.InputActionMap)typeof(UnityEngine.InputSystem.InputActionMap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.ApplyParameterOverride(@actionMap, @name, @value, @bindingMask);

            return __ret;
        }

        static StackObject* ApplyParameterOverride_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputBinding @bindingMask = (UnityEngine.InputSystem.InputBinding)typeof(UnityEngine.InputSystem.InputBinding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.Utilities.PrimitiveValue @value = (UnityEngine.InputSystem.Utilities.PrimitiveValue)typeof(UnityEngine.InputSystem.Utilities.PrimitiveValue).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.InputSystem.InputActionAsset @asset = (UnityEngine.InputSystem.InputActionAsset)typeof(UnityEngine.InputSystem.InputActionAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.ApplyParameterOverride(@asset, @name, @value, @bindingMask);

            return __ret;
        }

        static StackObject* ApplyParameterOverride_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputBinding @bindingMask = (UnityEngine.InputSystem.InputBinding)typeof(UnityEngine.InputSystem.InputBinding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.Utilities.PrimitiveValue @value = (UnityEngine.InputSystem.Utilities.PrimitiveValue)typeof(UnityEngine.InputSystem.Utilities.PrimitiveValue).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.ApplyParameterOverride(@action, @name, @value, @bindingMask);

            return __ret;
        }

        static StackObject* ApplyParameterOverride_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @bindingIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.Utilities.PrimitiveValue @value = (UnityEngine.InputSystem.Utilities.PrimitiveValue)typeof(UnityEngine.InputSystem.Utilities.PrimitiveValue).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.ApplyParameterOverride(@action, @name, @value, @bindingIndex);

            return __ret;
        }

        static StackObject* GetBindingIndex_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputBinding @bindingMask = (UnityEngine.InputSystem.InputBinding)typeof(UnityEngine.InputSystem.InputBinding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.GetBindingIndex(@action, @bindingMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetBindingIndex_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputBinding @bindingMask = (UnityEngine.InputSystem.InputBinding)typeof(UnityEngine.InputSystem.InputBinding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputActionMap @actionMap = (UnityEngine.InputSystem.InputActionMap)typeof(UnityEngine.InputSystem.InputActionMap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.GetBindingIndex(@actionMap, @bindingMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetBindingIndex_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @group = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.GetBindingIndex(@action, @group, @path);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetBindingForControl_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputControl @control = (UnityEngine.InputSystem.InputControl)typeof(UnityEngine.InputSystem.InputControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.GetBindingForControl(@action, @control);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetBindingIndexForControl_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputControl @control = (UnityEngine.InputSystem.InputControl)typeof(UnityEngine.InputSystem.InputControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.GetBindingIndexForControl(@action, @control);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetBindingDisplayString_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @group = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputBinding.DisplayStringOptions @options = (UnityEngine.InputSystem.InputBinding.DisplayStringOptions)typeof(UnityEngine.InputSystem.InputBinding.DisplayStringOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.GetBindingDisplayString(@action, @options, @group);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetBindingDisplayString_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputBinding.DisplayStringOptions @options = (UnityEngine.InputSystem.InputBinding.DisplayStringOptions)typeof(UnityEngine.InputSystem.InputBinding.DisplayStringOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputBinding @bindingMask = (UnityEngine.InputSystem.InputBinding)typeof(UnityEngine.InputSystem.InputBinding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.GetBindingDisplayString(@action, @bindingMask, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetBindingDisplayString_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputBinding.DisplayStringOptions @options = (UnityEngine.InputSystem.InputBinding.DisplayStringOptions)typeof(UnityEngine.InputSystem.InputBinding.DisplayStringOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @bindingIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.GetBindingDisplayString(@action, @bindingIndex, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetBindingDisplayString_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputBinding.DisplayStringOptions @options = (UnityEngine.InputSystem.InputBinding.DisplayStringOptions)typeof(UnityEngine.InputSystem.InputBinding.DisplayStringOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @controlPath = (System.String)typeof(System.String).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @deviceLayoutName = (System.String)typeof(System.String).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @bindingIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.GetBindingDisplayString(@action, @bindingIndex, out @deviceLayoutName, out @controlPath, @options);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @controlPath;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @controlPath;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @controlPath);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @controlPath;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @controlPath);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.String[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @controlPath;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @deviceLayoutName;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @deviceLayoutName;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @deviceLayoutName);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @deviceLayoutName;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @deviceLayoutName);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.String[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @deviceLayoutName;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ApplyBindingOverride_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @group = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @newPath = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.ApplyBindingOverride(@action, @newPath, @group, @path);

            return __ret;
        }

        static StackObject* ApplyBindingOverride_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputBinding @bindingOverride = (UnityEngine.InputSystem.InputBinding)typeof(UnityEngine.InputSystem.InputBinding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.ApplyBindingOverride(@action, @bindingOverride);

            return __ret;
        }

        static StackObject* ApplyBindingOverride_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputBinding @bindingOverride = (UnityEngine.InputSystem.InputBinding)typeof(UnityEngine.InputSystem.InputBinding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @bindingIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.ApplyBindingOverride(@action, @bindingIndex, @bindingOverride);

            return __ret;
        }

        static StackObject* ApplyBindingOverride_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @bindingIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.ApplyBindingOverride(@action, @bindingIndex, @path);

            return __ret;
        }

        static StackObject* ApplyBindingOverride_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputBinding @bindingOverride = (UnityEngine.InputSystem.InputBinding)typeof(UnityEngine.InputSystem.InputBinding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputActionMap @actionMap = (UnityEngine.InputSystem.InputActionMap)typeof(UnityEngine.InputSystem.InputActionMap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.ApplyBindingOverride(@actionMap, @bindingOverride);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ApplyBindingOverride_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputBinding @bindingOverride = (UnityEngine.InputSystem.InputBinding)typeof(UnityEngine.InputSystem.InputBinding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @bindingIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputActionMap @actionMap = (UnityEngine.InputSystem.InputActionMap)typeof(UnityEngine.InputSystem.InputActionMap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.ApplyBindingOverride(@actionMap, @bindingIndex, @bindingOverride);

            return __ret;
        }

        static StackObject* RemoveBindingOverride_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @bindingIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.RemoveBindingOverride(@action, @bindingIndex);

            return __ret;
        }

        static StackObject* RemoveBindingOverride_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputBinding @bindingMask = (UnityEngine.InputSystem.InputBinding)typeof(UnityEngine.InputSystem.InputBinding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.RemoveBindingOverride(@action, @bindingMask);

            return __ret;
        }

        static StackObject* RemoveAllBindingOverrides_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.IInputActionCollection2 @actions = (UnityEngine.InputSystem.IInputActionCollection2)typeof(UnityEngine.InputSystem.IInputActionCollection2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.RemoveAllBindingOverrides(@actions);

            return __ret;
        }

        static StackObject* RemoveAllBindingOverrides_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.RemoveAllBindingOverrides(@action);

            return __ret;
        }

        static StackObject* ApplyBindingOverrides_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> @overrides = (System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>)typeof(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputActionMap @actionMap = (UnityEngine.InputSystem.InputActionMap)typeof(UnityEngine.InputSystem.InputActionMap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.ApplyBindingOverrides(@actionMap, @overrides);

            return __ret;
        }

        static StackObject* RemoveBindingOverrides_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> @overrides = (System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>)typeof(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputActionMap @actionMap = (UnityEngine.InputSystem.InputActionMap)typeof(UnityEngine.InputSystem.InputActionMap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.RemoveBindingOverrides(@actionMap, @overrides);

            return __ret;
        }

        static StackObject* ApplyBindingOverridesOnMatchingControls_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputControl @control = (UnityEngine.InputSystem.InputControl)typeof(UnityEngine.InputSystem.InputControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.ApplyBindingOverridesOnMatchingControls(@action, @control);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ApplyBindingOverridesOnMatchingControls_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputControl @control = (UnityEngine.InputSystem.InputControl)typeof(UnityEngine.InputSystem.InputControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputActionMap @actionMap = (UnityEngine.InputSystem.InputActionMap)typeof(UnityEngine.InputSystem.InputActionMap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.ApplyBindingOverridesOnMatchingControls(@actionMap, @control);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SaveBindingOverridesAsJson_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.IInputActionCollection2 @actions = (UnityEngine.InputSystem.IInputActionCollection2)typeof(UnityEngine.InputSystem.IInputActionCollection2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.SaveBindingOverridesAsJson(@actions);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SaveBindingOverridesAsJson_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.SaveBindingOverridesAsJson(@action);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* LoadBindingOverridesFromJson_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @removeExisting = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.IInputActionCollection2 @actions = (UnityEngine.InputSystem.IInputActionCollection2)typeof(UnityEngine.InputSystem.IInputActionCollection2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.LoadBindingOverridesFromJson(@actions, @json, @removeExisting);

            return __ret;
        }

        static StackObject* LoadBindingOverridesFromJson_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @removeExisting = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.InputActionRebindingExtensions.LoadBindingOverridesFromJson(@action, @json, @removeExisting);

            return __ret;
        }

        static StackObject* PerformInteractiveRebinding_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @bindingIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.InputAction @action = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.InputActionRebindingExtensions.PerformInteractiveRebinding(@action, @bindingIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
