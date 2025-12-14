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
    unsafe class UnityEngine_XR_VisionOS_InputDevices_VisionOSSpatialPointerControl_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl);
            args = new Type[]{};
            method = type.GetMethod("get_interactionId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interactionId_0);
            args = new Type[]{typeof(UnityEngine.InputSystem.Controls.IntegerControl)};
            method = type.GetMethod("set_interactionId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_interactionId_1);
            args = new Type[]{};
            method = type.GetMethod("get_startRayOrigin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_startRayOrigin_2);
            args = new Type[]{typeof(UnityEngine.InputSystem.Controls.Vector3Control)};
            method = type.GetMethod("set_startRayOrigin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_startRayOrigin_3);
            args = new Type[]{};
            method = type.GetMethod("get_startRayDirection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_startRayDirection_4);
            args = new Type[]{typeof(UnityEngine.InputSystem.Controls.Vector3Control)};
            method = type.GetMethod("set_startRayDirection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_startRayDirection_5);
            args = new Type[]{};
            method = type.GetMethod("get_startRayRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_startRayRotation_6);
            args = new Type[]{typeof(UnityEngine.InputSystem.Controls.QuaternionControl)};
            method = type.GetMethod("set_startRayRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_startRayRotation_7);
            args = new Type[]{};
            method = type.GetMethod("get_interactionRayRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interactionRayRotation_8);
            args = new Type[]{typeof(UnityEngine.InputSystem.Controls.QuaternionControl)};
            method = type.GetMethod("set_interactionRayRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_interactionRayRotation_9);
            args = new Type[]{};
            method = type.GetMethod("get_inputDevicePosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inputDevicePosition_10);
            args = new Type[]{typeof(UnityEngine.InputSystem.Controls.Vector3Control)};
            method = type.GetMethod("set_inputDevicePosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_inputDevicePosition_11);
            args = new Type[]{};
            method = type.GetMethod("get_inputDeviceRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inputDeviceRotation_12);
            args = new Type[]{typeof(UnityEngine.InputSystem.Controls.QuaternionControl)};
            method = type.GetMethod("set_inputDeviceRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_inputDeviceRotation_13);
            args = new Type[]{};
            method = type.GetMethod("get_kind", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_kind_14);
            args = new Type[]{typeof(UnityEngine.InputSystem.Controls.IntegerControl)};
            method = type.GetMethod("set_kind", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_kind_15);
            args = new Type[]{};
            method = type.GetMethod("get_phase", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_phase_16);
            args = new Type[]{typeof(UnityEngine.InputSystem.Controls.TouchPhaseControl)};
            method = type.GetMethod("set_phase", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_phase_17);
            args = new Type[]{};
            method = type.GetMethod("get_trackingState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_trackingState_18);
            args = new Type[]{typeof(UnityEngine.InputSystem.Controls.IntegerControl)};
            method = type.GetMethod("set_trackingState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_trackingState_19);
            args = new Type[]{};
            method = type.GetMethod("get_isTracked", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isTracked_20);
            args = new Type[]{typeof(UnityEngine.InputSystem.Controls.ButtonControl)};
            method = type.GetMethod("set_isTracked", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_isTracked_21);
            args = new Type[]{};
            method = type.GetMethod("get_isInProgress", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isInProgress_22);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_interactionId_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interactionId;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_interactionId_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Controls.IntegerControl @value = (UnityEngine.InputSystem.Controls.IntegerControl)typeof(UnityEngine.InputSystem.Controls.IntegerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactionId = value;

            return __ret;
        }

        static StackObject* get_startRayOrigin_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.startRayOrigin;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_startRayOrigin_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Controls.Vector3Control @value = (UnityEngine.InputSystem.Controls.Vector3Control)typeof(UnityEngine.InputSystem.Controls.Vector3Control).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.startRayOrigin = value;

            return __ret;
        }

        static StackObject* get_startRayDirection_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.startRayDirection;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_startRayDirection_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Controls.Vector3Control @value = (UnityEngine.InputSystem.Controls.Vector3Control)typeof(UnityEngine.InputSystem.Controls.Vector3Control).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.startRayDirection = value;

            return __ret;
        }

        static StackObject* get_startRayRotation_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.startRayRotation;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_startRayRotation_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Controls.QuaternionControl @value = (UnityEngine.InputSystem.Controls.QuaternionControl)typeof(UnityEngine.InputSystem.Controls.QuaternionControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.startRayRotation = value;

            return __ret;
        }

        static StackObject* get_interactionRayRotation_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interactionRayRotation;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_interactionRayRotation_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Controls.QuaternionControl @value = (UnityEngine.InputSystem.Controls.QuaternionControl)typeof(UnityEngine.InputSystem.Controls.QuaternionControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactionRayRotation = value;

            return __ret;
        }

        static StackObject* get_inputDevicePosition_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.inputDevicePosition;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_inputDevicePosition_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Controls.Vector3Control @value = (UnityEngine.InputSystem.Controls.Vector3Control)typeof(UnityEngine.InputSystem.Controls.Vector3Control).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.inputDevicePosition = value;

            return __ret;
        }

        static StackObject* get_inputDeviceRotation_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.inputDeviceRotation;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_inputDeviceRotation_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Controls.QuaternionControl @value = (UnityEngine.InputSystem.Controls.QuaternionControl)typeof(UnityEngine.InputSystem.Controls.QuaternionControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.inputDeviceRotation = value;

            return __ret;
        }

        static StackObject* get_kind_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.kind;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_kind_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Controls.IntegerControl @value = (UnityEngine.InputSystem.Controls.IntegerControl)typeof(UnityEngine.InputSystem.Controls.IntegerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.kind = value;

            return __ret;
        }

        static StackObject* get_phase_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.phase;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_phase_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Controls.TouchPhaseControl @value = (UnityEngine.InputSystem.Controls.TouchPhaseControl)typeof(UnityEngine.InputSystem.Controls.TouchPhaseControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.phase = value;

            return __ret;
        }

        static StackObject* get_trackingState_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.trackingState;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_trackingState_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Controls.IntegerControl @value = (UnityEngine.InputSystem.Controls.IntegerControl)typeof(UnityEngine.InputSystem.Controls.IntegerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trackingState = value;

            return __ret;
        }

        static StackObject* get_isTracked_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isTracked;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_isTracked_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Controls.ButtonControl @value = (UnityEngine.InputSystem.Controls.ButtonControl)typeof(UnityEngine.InputSystem.Controls.ButtonControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.isTracked = value;

            return __ret;
        }

        static StackObject* get_isInProgress_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isInProgress;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerControl();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
