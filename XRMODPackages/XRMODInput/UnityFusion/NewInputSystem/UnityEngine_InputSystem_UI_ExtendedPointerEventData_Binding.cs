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
    unsafe class UnityEngine_InputSystem_UI_ExtendedPointerEventData_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData);
            args = new Type[]{};
            method = type.GetMethod("get_control", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_control_0);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputControl)};
            method = type.GetMethod("set_control", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_control_1);
            args = new Type[]{};
            method = type.GetMethod("get_device", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_device_2);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputDevice)};
            method = type.GetMethod("set_device", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_device_3);
            args = new Type[]{};
            method = type.GetMethod("get_touchId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_touchId_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_touchId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_touchId_5);
            args = new Type[]{};
            method = type.GetMethod("get_pointerType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pointerType_6);
            args = new Type[]{typeof(UnityEngine.InputSystem.UI.UIPointerType)};
            method = type.GetMethod("set_pointerType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_pointerType_7);
            args = new Type[]{};
            method = type.GetMethod("get_uiToolkitPointerId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_uiToolkitPointerId_8);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_uiToolkitPointerId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_uiToolkitPointerId_9);
            args = new Type[]{};
            method = type.GetMethod("get_trackedDevicePosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_trackedDevicePosition_10);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_trackedDevicePosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_trackedDevicePosition_11);
            args = new Type[]{};
            method = type.GetMethod("get_trackedDeviceOrientation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_trackedDeviceOrientation_12);
            args = new Type[]{typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("set_trackedDeviceOrientation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_trackedDeviceOrientation_13);
            args = new Type[]{};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_14);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.UI.ExtendedPointerEventData[s]);

            args = new Type[]{typeof(UnityEngine.EventSystems.EventSystem)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_control_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.control;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_control_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputControl @value = (UnityEngine.InputSystem.InputControl)typeof(UnityEngine.InputSystem.InputControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.control = value;

            return __ret;
        }

        static StackObject* get_device_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.device;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_device_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputDevice @value = (UnityEngine.InputSystem.InputDevice)typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.device = value;

            return __ret;
        }

        static StackObject* get_touchId_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.touchId;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_touchId_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.touchId = value;

            return __ret;
        }

        static StackObject* get_pointerType_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pointerType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_pointerType_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.UIPointerType @value = (UnityEngine.InputSystem.UI.UIPointerType)typeof(UnityEngine.InputSystem.UI.UIPointerType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.pointerType = value;

            return __ret;
        }

        static StackObject* get_uiToolkitPointerId_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.uiToolkitPointerId;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_uiToolkitPointerId_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.uiToolkitPointerId = value;

            return __ret;
        }

        static StackObject* get_trackedDevicePosition_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.trackedDevicePosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_trackedDevicePosition_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trackedDevicePosition = value;

            return __ret;
        }

        static StackObject* get_trackedDeviceOrientation_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.trackedDeviceOrientation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_trackedDeviceOrientation_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @value = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trackedDeviceOrientation = value;

            return __ret;
        }

        static StackObject* ToString_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.ExtendedPointerEventData instance_of_this_method = (UnityEngine.InputSystem.UI.ExtendedPointerEventData)typeof(UnityEngine.InputSystem.UI.ExtendedPointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ToString();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.EventSystems.EventSystem @eventSystem = (UnityEngine.EventSystems.EventSystem)typeof(UnityEngine.EventSystems.EventSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new UnityEngine.InputSystem.UI.ExtendedPointerEventData(@eventSystem);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
