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
    unsafe class UnityEngine_XR_VisionOS_InputDevices_VisionOSSpatialPointerEvent_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent);

            field = type.GetField("interactionId", flag);
            app.RegisterCLRFieldGetter(field, get_interactionId_0);
            app.RegisterCLRFieldSetter(field, set_interactionId_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_interactionId_0, AssignFromStack_interactionId_0);
            field = type.GetField("rayOrigin", flag);
            app.RegisterCLRFieldGetter(field, get_rayOrigin_1);
            app.RegisterCLRFieldSetter(field, set_rayOrigin_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_rayOrigin_1, AssignFromStack_rayOrigin_1);
            field = type.GetField("rayDirection", flag);
            app.RegisterCLRFieldGetter(field, get_rayDirection_2);
            app.RegisterCLRFieldSetter(field, set_rayDirection_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_rayDirection_2, AssignFromStack_rayDirection_2);
            field = type.GetField("inputDevicePosition", flag);
            app.RegisterCLRFieldGetter(field, get_inputDevicePosition_3);
            app.RegisterCLRFieldSetter(field, set_inputDevicePosition_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_inputDevicePosition_3, AssignFromStack_inputDevicePosition_3);
            field = type.GetField("inputDeviceRotation", flag);
            app.RegisterCLRFieldGetter(field, get_inputDeviceRotation_4);
            app.RegisterCLRFieldSetter(field, set_inputDeviceRotation_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_inputDeviceRotation_4, AssignFromStack_inputDeviceRotation_4);
            field = type.GetField("modifierKeys", flag);
            app.RegisterCLRFieldGetter(field, get_modifierKeys_5);
            app.RegisterCLRFieldSetter(field, set_modifierKeys_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_modifierKeys_5, AssignFromStack_modifierKeys_5);
            field = type.GetField("kind", flag);
            app.RegisterCLRFieldGetter(field, get_kind_6);
            app.RegisterCLRFieldSetter(field, set_kind_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_kind_6, AssignFromStack_kind_6);
            field = type.GetField("phase", flag);
            app.RegisterCLRFieldGetter(field, get_phase_7);
            app.RegisterCLRFieldSetter(field, set_phase_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_phase_7, AssignFromStack_phase_7);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_interactionId_0(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).interactionId;
        }

        static StackObject* CopyToStack_interactionId_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).interactionId;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_interactionId_0(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.interactionId = (System.Int32)v;
            o = ins;
        }

        static StackObject* AssignFromStack_interactionId_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @interactionId = ptr_of_this_method->Value;
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.interactionId = @interactionId;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_rayOrigin_1(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).rayOrigin;
        }

        static StackObject* CopyToStack_rayOrigin_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).rayOrigin;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_rayOrigin_1(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.rayOrigin = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_rayOrigin_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @rayOrigin = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.rayOrigin = @rayOrigin;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_rayDirection_2(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).rayDirection;
        }

        static StackObject* CopyToStack_rayDirection_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).rayDirection;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_rayDirection_2(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.rayDirection = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_rayDirection_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @rayDirection = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.rayDirection = @rayDirection;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_inputDevicePosition_3(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).inputDevicePosition;
        }

        static StackObject* CopyToStack_inputDevicePosition_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).inputDevicePosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_inputDevicePosition_3(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.inputDevicePosition = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_inputDevicePosition_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @inputDevicePosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.inputDevicePosition = @inputDevicePosition;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_inputDeviceRotation_4(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).inputDeviceRotation;
        }

        static StackObject* CopyToStack_inputDeviceRotation_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).inputDeviceRotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_inputDeviceRotation_4(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.inputDeviceRotation = (UnityEngine.Quaternion)v;
            o = ins;
        }

        static StackObject* AssignFromStack_inputDeviceRotation_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @inputDeviceRotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.inputDeviceRotation = @inputDeviceRotation;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_modifierKeys_5(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).modifierKeys;
        }

        static StackObject* CopyToStack_modifierKeys_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).modifierKeys;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_modifierKeys_5(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.modifierKeys = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys)v;
            o = ins;
        }

        static StackObject* AssignFromStack_modifierKeys_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys @modifierKeys = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.modifierKeys = @modifierKeys;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_kind_6(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).kind;
        }

        static StackObject* CopyToStack_kind_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).kind;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_kind_6(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.kind = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind)v;
            o = ins;
        }

        static StackObject* AssignFromStack_kind_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind @kind = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.kind = @kind;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_phase_7(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).phase;
        }

        static StackObject* CopyToStack_phase_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o).phase;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_phase_7(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.phase = (UnityEngine.XR.VisionOS.VisionOSSpatialPointerPhase)v;
            o = ins;
        }

        static StackObject* AssignFromStack_phase_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.VisionOS.VisionOSSpatialPointerPhase @phase = (UnityEngine.XR.VisionOS.VisionOSSpatialPointerPhase)typeof(UnityEngine.XR.VisionOS.VisionOSSpatialPointerPhase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            ins.phase = @phase;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent();
            ins = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerEvent)o;
            return ins;
        }


    }
}
