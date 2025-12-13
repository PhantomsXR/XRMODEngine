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
    unsafe class UnityEngine_InputSystem_XR_TrackedPoseDriver_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver);
            args = new Type[]{};
            method = type.GetMethod("get_trackingType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_trackingType_0);
            args = new Type[]{typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType)};
            method = type.GetMethod("set_trackingType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_trackingType_1);
            args = new Type[]{};
            method = type.GetMethod("get_updateType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_updateType_2);
            args = new Type[]{typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType)};
            method = type.GetMethod("set_updateType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_updateType_3);
            args = new Type[]{};
            method = type.GetMethod("get_ignoreTrackingState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ignoreTrackingState_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_ignoreTrackingState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ignoreTrackingState_5);
            args = new Type[]{};
            method = type.GetMethod("get_positionInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_positionInput_6);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionProperty)};
            method = type.GetMethod("set_positionInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_positionInput_7);
            args = new Type[]{};
            method = type.GetMethod("get_rotationInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rotationInput_8);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionProperty)};
            method = type.GetMethod("set_rotationInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rotationInput_9);
            args = new Type[]{};
            method = type.GetMethod("get_trackingStateInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_trackingStateInput_10);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionProperty)};
            method = type.GetMethod("set_trackingStateInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_trackingStateInput_11);
            args = new Type[]{};
            method = type.GetMethod("get_positionAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_positionAction_12);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction)};
            method = type.GetMethod("set_positionAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_positionAction_13);
            args = new Type[]{};
            method = type.GetMethod("get_rotationAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rotationAction_14);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputAction)};
            method = type.GetMethod("set_rotationAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rotationAction_15);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.XR.TrackedPoseDriver());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.XR.TrackedPoseDriver[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_trackingType_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.trackingType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_trackingType_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType @value = (UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trackingType = value;

            return __ret;
        }

        static StackObject* get_updateType_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.updateType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_updateType_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType @value = (UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.updateType = value;

            return __ret;
        }

        static StackObject* get_ignoreTrackingState_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ignoreTrackingState;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_ignoreTrackingState_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ignoreTrackingState = value;

            return __ret;
        }

        static StackObject* get_positionInput_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.positionInput;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_positionInput_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionProperty @value = (UnityEngine.InputSystem.InputActionProperty)typeof(UnityEngine.InputSystem.InputActionProperty).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.positionInput = value;

            return __ret;
        }

        static StackObject* get_rotationInput_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rotationInput;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rotationInput_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionProperty @value = (UnityEngine.InputSystem.InputActionProperty)typeof(UnityEngine.InputSystem.InputActionProperty).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rotationInput = value;

            return __ret;
        }

        static StackObject* get_trackingStateInput_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.trackingStateInput;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_trackingStateInput_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionProperty @value = (UnityEngine.InputSystem.InputActionProperty)typeof(UnityEngine.InputSystem.InputActionProperty).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trackingStateInput = value;

            return __ret;
        }

        static StackObject* get_positionAction_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.positionAction;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_positionAction_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputAction @value = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.positionAction = value;

            return __ret;
        }

        static StackObject* get_rotationAction_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rotationAction;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rotationAction_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputAction @value = (UnityEngine.InputSystem.InputAction)typeof(UnityEngine.InputSystem.InputAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.XR.TrackedPoseDriver instance_of_this_method = (UnityEngine.InputSystem.XR.TrackedPoseDriver)typeof(UnityEngine.InputSystem.XR.TrackedPoseDriver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rotationAction = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.InputSystem.XR.TrackedPoseDriver();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
