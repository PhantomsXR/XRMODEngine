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
    unsafe class UnityEngine_XR_VisionOS_InputDevices_VisionOSSpatialPointerState_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState);
            args = new Type[]{};
            method = type.GetMethod("get_Format", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Format_0);
            args = new Type[]{};
            method = type.GetMethod("get_Kind", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Kind_1);
            args = new Type[]{typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind)};
            method = type.GetMethod("set_Kind", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Kind_2);
            args = new Type[]{typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys)};
            method = type.GetMethod("IsModifierKeyPressed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsModifierKeyPressed_3);
            args = new Type[]{};
            method = type.GetMethod("get_format", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_format_4);
            args = new Type[]{typeof(System.Boolean), typeof(System.UInt16)};
            method = type.GetMethod("SetModifierKey", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetModifierKey_5);
            args = new Type[]{};
            method = type.GetMethod("get_phase", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_phase_6);
            args = new Type[]{typeof(UnityEngine.XR.VisionOS.VisionOSSpatialPointerPhase)};
            method = type.GetMethod("set_phase", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_phase_7);
            args = new Type[]{};
            method = type.GetMethod("get_isNoneEndedOrCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isNoneEndedOrCanceled_8);

            field = type.GetField("LayoutName", flag);
            app.RegisterCLRFieldGetter(field, get_LayoutName_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_LayoutName_0, null);
            field = type.GetField("SizeInBytes", flag);
            app.RegisterCLRFieldGetter(field, get_SizeInBytes_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_SizeInBytes_1, null);
            field = type.GetField("interactionId", flag);
            app.RegisterCLRFieldGetter(field, get_interactionId_2);
            app.RegisterCLRFieldSetter(field, set_interactionId_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_interactionId_2, AssignFromStack_interactionId_2);
            field = type.GetField("startRayOrigin", flag);
            app.RegisterCLRFieldGetter(field, get_startRayOrigin_3);
            app.RegisterCLRFieldSetter(field, set_startRayOrigin_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_startRayOrigin_3, AssignFromStack_startRayOrigin_3);
            field = type.GetField("startRayDirection", flag);
            app.RegisterCLRFieldGetter(field, get_startRayDirection_4);
            app.RegisterCLRFieldSetter(field, set_startRayDirection_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_startRayDirection_4, AssignFromStack_startRayDirection_4);
            field = type.GetField("startRayRotation", flag);
            app.RegisterCLRFieldGetter(field, get_startRayRotation_5);
            app.RegisterCLRFieldSetter(field, set_startRayRotation_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_startRayRotation_5, AssignFromStack_startRayRotation_5);
            field = type.GetField("interactionRayRotation", flag);
            app.RegisterCLRFieldGetter(field, get_interactionRayRotation_6);
            app.RegisterCLRFieldSetter(field, set_interactionRayRotation_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_interactionRayRotation_6, AssignFromStack_interactionRayRotation_6);
            field = type.GetField("inputDevicePosition", flag);
            app.RegisterCLRFieldGetter(field, get_inputDevicePosition_7);
            app.RegisterCLRFieldSetter(field, set_inputDevicePosition_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_inputDevicePosition_7, AssignFromStack_inputDevicePosition_7);
            field = type.GetField("inputDeviceRotation", flag);
            app.RegisterCLRFieldGetter(field, get_inputDeviceRotation_8);
            app.RegisterCLRFieldSetter(field, set_inputDeviceRotation_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_inputDeviceRotation_8, AssignFromStack_inputDeviceRotation_8);
            field = type.GetField("modifierKeys", flag);
            app.RegisterCLRFieldGetter(field, get_modifierKeys_9);
            app.RegisterCLRFieldSetter(field, set_modifierKeys_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_modifierKeys_9, AssignFromStack_modifierKeys_9);
            field = type.GetField("kindId", flag);
            app.RegisterCLRFieldGetter(field, get_kindId_10);
            app.RegisterCLRFieldSetter(field, set_kindId_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_kindId_10, AssignFromStack_kindId_10);
            field = type.GetField("phaseId", flag);
            app.RegisterCLRFieldGetter(field, get_phaseId_11);
            app.RegisterCLRFieldSetter(field, set_phaseId_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_phaseId_11, AssignFromStack_phaseId_11);
            field = type.GetField("isTracked", flag);
            app.RegisterCLRFieldGetter(field, get_isTracked_12);
            app.RegisterCLRFieldSetter(field, set_isTracked_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_isTracked_12, AssignFromStack_isTracked_12);
            field = type.GetField("trackingState", flag);
            app.RegisterCLRFieldGetter(field, get_trackingState_13);
            app.RegisterCLRFieldSetter(field, set_trackingState_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_trackingState_13, AssignFromStack_trackingState_13);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* get_Format_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState.Format;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Kind_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.Kind;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Kind_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind @value = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            instance_of_this_method.Kind = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* IsModifierKeyPressed_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys @key = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.IsModifierKeyPressed(@key);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_format_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.format;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetModifierKey_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 @modifierKey = (ushort)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @state = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            instance_of_this_method.SetModifierKey(@state, @modifierKey);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_phase_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.phase;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_phase_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.VisionOSSpatialPointerPhase @value = (UnityEngine.XR.VisionOS.VisionOSSpatialPointerPhase)typeof(UnityEngine.XR.VisionOS.VisionOSSpatialPointerPhase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            instance_of_this_method.phase = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_isNoneEndedOrCanceled_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.isNoneEndedOrCanceled;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_LayoutName_0(ref object o)
        {
            return UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState.LayoutName;
        }

        static StackObject* CopyToStack_LayoutName_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState.LayoutName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SizeInBytes_1(ref object o)
        {
            return UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState.SizeInBytes;
        }

        static StackObject* CopyToStack_SizeInBytes_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState.SizeInBytes;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_interactionId_2(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).interactionId;
        }

        static StackObject* CopyToStack_interactionId_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).interactionId;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_interactionId_2(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.interactionId = (System.Int32)v;
            o = ins;
        }

        static StackObject* AssignFromStack_interactionId_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @interactionId = ptr_of_this_method->Value;
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.interactionId = @interactionId;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_startRayOrigin_3(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).startRayOrigin;
        }

        static StackObject* CopyToStack_startRayOrigin_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).startRayOrigin;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_startRayOrigin_3(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.startRayOrigin = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_startRayOrigin_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @startRayOrigin = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.startRayOrigin = @startRayOrigin;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_startRayDirection_4(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).startRayDirection;
        }

        static StackObject* CopyToStack_startRayDirection_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).startRayDirection;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_startRayDirection_4(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.startRayDirection = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_startRayDirection_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @startRayDirection = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.startRayDirection = @startRayDirection;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_startRayRotation_5(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).startRayRotation;
        }

        static StackObject* CopyToStack_startRayRotation_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).startRayRotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_startRayRotation_5(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.startRayRotation = (UnityEngine.Quaternion)v;
            o = ins;
        }

        static StackObject* AssignFromStack_startRayRotation_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @startRayRotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.startRayRotation = @startRayRotation;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_interactionRayRotation_6(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).interactionRayRotation;
        }

        static StackObject* CopyToStack_interactionRayRotation_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).interactionRayRotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_interactionRayRotation_6(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.interactionRayRotation = (UnityEngine.Quaternion)v;
            o = ins;
        }

        static StackObject* AssignFromStack_interactionRayRotation_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @interactionRayRotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.interactionRayRotation = @interactionRayRotation;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_inputDevicePosition_7(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).inputDevicePosition;
        }

        static StackObject* CopyToStack_inputDevicePosition_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).inputDevicePosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_inputDevicePosition_7(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.inputDevicePosition = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_inputDevicePosition_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @inputDevicePosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.inputDevicePosition = @inputDevicePosition;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_inputDeviceRotation_8(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).inputDeviceRotation;
        }

        static StackObject* CopyToStack_inputDeviceRotation_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).inputDeviceRotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_inputDeviceRotation_8(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.inputDeviceRotation = (UnityEngine.Quaternion)v;
            o = ins;
        }

        static StackObject* AssignFromStack_inputDeviceRotation_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @inputDeviceRotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.inputDeviceRotation = @inputDeviceRotation;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_modifierKeys_9(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).modifierKeys;
        }

        static StackObject* CopyToStack_modifierKeys_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).modifierKeys;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_modifierKeys_9(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.modifierKeys = (System.UInt16)v;
            o = ins;
        }

        static StackObject* AssignFromStack_modifierKeys_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt16 @modifierKeys = (ushort)ptr_of_this_method->Value;
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.modifierKeys = @modifierKeys;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_kindId_10(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).kindId;
        }

        static StackObject* CopyToStack_kindId_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).kindId;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_kindId_10(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.kindId = (System.Byte)v;
            o = ins;
        }

        static StackObject* AssignFromStack_kindId_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Byte @kindId = (byte)ptr_of_this_method->Value;
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.kindId = @kindId;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_phaseId_11(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).phaseId;
        }

        static StackObject* CopyToStack_phaseId_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).phaseId;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_phaseId_11(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.phaseId = (System.Byte)v;
            o = ins;
        }

        static StackObject* AssignFromStack_phaseId_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Byte @phaseId = (byte)ptr_of_this_method->Value;
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.phaseId = @phaseId;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_isTracked_12(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).isTracked;
        }

        static StackObject* CopyToStack_isTracked_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).isTracked;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_isTracked_12(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.isTracked = (System.Boolean)v;
            o = ins;
        }

        static StackObject* AssignFromStack_isTracked_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @isTracked = ptr_of_this_method->Value == 1;
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.isTracked = @isTracked;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_trackingState_13(ref object o)
        {
            return ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).trackingState;
        }

        static StackObject* CopyToStack_trackingState_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o).trackingState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_trackingState_13(ref object o, object v)
        {
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.trackingState = (UnityEngine.XR.InputTrackingState)v;
            o = ins;
        }

        static StackObject* AssignFromStack_trackingState_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputTrackingState @trackingState = (UnityEngine.XR.InputTrackingState)typeof(UnityEngine.XR.InputTrackingState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState ins =(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            ins.trackingState = @trackingState;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState();
            ins = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerState)o;
            return ins;
        }


    }
}
