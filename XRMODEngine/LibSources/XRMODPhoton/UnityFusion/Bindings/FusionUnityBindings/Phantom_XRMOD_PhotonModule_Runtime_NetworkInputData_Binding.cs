#if FUSION2 && XRMOD_INSTALL
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
    unsafe class Phantom_XRMOD_PhotonModule_Runtime_NetworkInputData_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("IsUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsUp_0);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("IsDown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsDown_1);
            args = new Type[]{typeof(System.UInt32), typeof(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)};
            method = type.GetMethod("WasPressed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WasPressed_2);

            field = type.GetField("MOUSE_LEFT_BUTTON", flag);
            app.RegisterCLRFieldGetter(field, get_MOUSE_LEFT_BUTTON_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOUSE_LEFT_BUTTON_0, null);
            field = type.GetField("MOUSE_RIGHT_BUTTON", flag);
            app.RegisterCLRFieldGetter(field, get_MOUSE_RIGHT_BUTTON_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOUSE_RIGHT_BUTTON_1, null);
            field = type.GetField("MOUSE_MID_BUTTON", flag);
            app.RegisterCLRFieldGetter(field, get_MOUSE_MID_BUTTON_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOUSE_MID_BUTTON_2, null);
            field = type.GetField("GAMEPAD_NORTH_BUTTON", flag);
            app.RegisterCLRFieldGetter(field, get_GAMEPAD_NORTH_BUTTON_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_GAMEPAD_NORTH_BUTTON_3, null);
            field = type.GetField("GAMEPAD_SOUTH_BUTTON", flag);
            app.RegisterCLRFieldGetter(field, get_GAMEPAD_SOUTH_BUTTON_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_GAMEPAD_SOUTH_BUTTON_4, null);
            field = type.GetField("GAMEPAD_EAST_BUTTON", flag);
            app.RegisterCLRFieldGetter(field, get_GAMEPAD_EAST_BUTTON_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_GAMEPAD_EAST_BUTTON_5, null);
            field = type.GetField("GAMEPAD_WEST_BUTTON", flag);
            app.RegisterCLRFieldGetter(field, get_GAMEPAD_WEST_BUTTON_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_GAMEPAD_WEST_BUTTON_6, null);
            field = type.GetField("GAMEPAD_RIGHT_TRIGGER_BUTTON", flag);
            app.RegisterCLRFieldGetter(field, get_GAMEPAD_RIGHT_TRIGGER_BUTTON_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_GAMEPAD_RIGHT_TRIGGER_BUTTON_7, null);
            field = type.GetField("GAMEPAD_RIGHT_SHOULDER_BUTTON", flag);
            app.RegisterCLRFieldGetter(field, get_GAMEPAD_RIGHT_SHOULDER_BUTTON_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_GAMEPAD_RIGHT_SHOULDER_BUTTON_8, null);
            field = type.GetField("GAMEPAD_Left_TRIGGER_BUTTON", flag);
            app.RegisterCLRFieldGetter(field, get_GAMEPAD_Left_TRIGGER_BUTTON_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_GAMEPAD_Left_TRIGGER_BUTTON_9, null);
            field = type.GetField("GAMEPAD_Left_SHOULDER_BUTTON", flag);
            app.RegisterCLRFieldGetter(field, get_GAMEPAD_Left_SHOULDER_BUTTON_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_GAMEPAD_Left_SHOULDER_BUTTON_10, null);
            field = type.GetField("DpadValue", flag);
            app.RegisterCLRFieldGetter(field, get_DpadValue_11);
            app.RegisterCLRFieldSetter(field, set_DpadValue_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_DpadValue_11, AssignFromStack_DpadValue_11);
            field = type.GetField("LeftJoystickValue", flag);
            app.RegisterCLRFieldGetter(field, get_LeftJoystickValue_12);
            app.RegisterCLRFieldSetter(field, set_LeftJoystickValue_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_LeftJoystickValue_12, AssignFromStack_LeftJoystickValue_12);
            field = type.GetField("RightJoystickValue", flag);
            app.RegisterCLRFieldGetter(field, get_RightJoystickValue_13);
            app.RegisterCLRFieldSetter(field, set_RightJoystickValue_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_RightJoystickValue_13, AssignFromStack_RightJoystickValue_13);
            field = type.GetField("RightTrigger", flag);
            app.RegisterCLRFieldGetter(field, get_RightTrigger_14);
            app.RegisterCLRFieldSetter(field, set_RightTrigger_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_RightTrigger_14, AssignFromStack_RightTrigger_14);
            field = type.GetField("RightShoulder", flag);
            app.RegisterCLRFieldGetter(field, get_RightShoulder_15);
            app.RegisterCLRFieldSetter(field, set_RightShoulder_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_RightShoulder_15, AssignFromStack_RightShoulder_15);
            field = type.GetField("LeftTrigger", flag);
            app.RegisterCLRFieldGetter(field, get_LeftTrigger_16);
            app.RegisterCLRFieldSetter(field, set_LeftTrigger_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_LeftTrigger_16, AssignFromStack_LeftTrigger_16);
            field = type.GetField("LeftShoulder", flag);
            app.RegisterCLRFieldGetter(field, get_LeftShoulder_17);
            app.RegisterCLRFieldSetter(field, set_LeftShoulder_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_LeftShoulder_17, AssignFromStack_LeftShoulder_17);
            field = type.GetField("Option", flag);
            app.RegisterCLRFieldGetter(field, get_Option_18);
            app.RegisterCLRFieldSetter(field, set_Option_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_Option_18, AssignFromStack_Option_18);
            field = type.GetField("Share", flag);
            app.RegisterCLRFieldGetter(field, get_Share_19);
            app.RegisterCLRFieldSetter(field, set_Share_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_Share_19, AssignFromStack_Share_19);
            field = type.GetField("LeftJoystickPressed", flag);
            app.RegisterCLRFieldGetter(field, get_LeftJoystickPressed_20);
            app.RegisterCLRFieldSetter(field, set_LeftJoystickPressed_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_LeftJoystickPressed_20, AssignFromStack_LeftJoystickPressed_20);
            field = type.GetField("RightJoystickPressed", flag);
            app.RegisterCLRFieldGetter(field, get_RightJoystickPressed_21);
            app.RegisterCLRFieldSetter(field, set_RightJoystickPressed_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_RightJoystickPressed_21, AssignFromStack_RightJoystickPressed_21);
            field = type.GetField("Buttons", flag);
            app.RegisterCLRFieldGetter(field, get_Buttons_22);
            app.RegisterCLRFieldSetter(field, set_Buttons_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_Buttons_22, AssignFromStack_Buttons_22);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* IsUp_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 @_button = (uint)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)typeof(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.IsUp(@_button);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsDown_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 @_button = (uint)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)typeof(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.IsDown(@_button);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* WasPressed_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData @_oldInput = (Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)typeof(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt32 @_button = (uint)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)typeof(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.WasPressed(@_button, @_oldInput);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_MOUSE_LEFT_BUTTON_0(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.MOUSE_LEFT_BUTTON;
        }

        static StackObject* CopyToStack_MOUSE_LEFT_BUTTON_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.MOUSE_LEFT_BUTTON;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_MOUSE_RIGHT_BUTTON_1(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.MOUSE_RIGHT_BUTTON;
        }

        static StackObject* CopyToStack_MOUSE_RIGHT_BUTTON_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.MOUSE_RIGHT_BUTTON;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_MOUSE_MID_BUTTON_2(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.MOUSE_MID_BUTTON;
        }

        static StackObject* CopyToStack_MOUSE_MID_BUTTON_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.MOUSE_MID_BUTTON;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_GAMEPAD_NORTH_BUTTON_3(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_NORTH_BUTTON;
        }

        static StackObject* CopyToStack_GAMEPAD_NORTH_BUTTON_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_NORTH_BUTTON;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_GAMEPAD_SOUTH_BUTTON_4(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_SOUTH_BUTTON;
        }

        static StackObject* CopyToStack_GAMEPAD_SOUTH_BUTTON_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_SOUTH_BUTTON;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_GAMEPAD_EAST_BUTTON_5(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_EAST_BUTTON;
        }

        static StackObject* CopyToStack_GAMEPAD_EAST_BUTTON_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_EAST_BUTTON;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_GAMEPAD_WEST_BUTTON_6(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_WEST_BUTTON;
        }

        static StackObject* CopyToStack_GAMEPAD_WEST_BUTTON_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_WEST_BUTTON;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_GAMEPAD_RIGHT_TRIGGER_BUTTON_7(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_RIGHT_TRIGGER_BUTTON;
        }

        static StackObject* CopyToStack_GAMEPAD_RIGHT_TRIGGER_BUTTON_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_RIGHT_TRIGGER_BUTTON;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_GAMEPAD_RIGHT_SHOULDER_BUTTON_8(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_RIGHT_SHOULDER_BUTTON;
        }

        static StackObject* CopyToStack_GAMEPAD_RIGHT_SHOULDER_BUTTON_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_RIGHT_SHOULDER_BUTTON;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_GAMEPAD_Left_TRIGGER_BUTTON_9(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_Left_TRIGGER_BUTTON;
        }

        static StackObject* CopyToStack_GAMEPAD_Left_TRIGGER_BUTTON_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_Left_TRIGGER_BUTTON;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_GAMEPAD_Left_SHOULDER_BUTTON_10(ref object o)
        {
            return Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_Left_SHOULDER_BUTTON;
        }

        static StackObject* CopyToStack_GAMEPAD_Left_SHOULDER_BUTTON_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData.GAMEPAD_Left_SHOULDER_BUTTON;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_DpadValue_11(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).DpadValue;
        }

        static StackObject* CopyToStack_DpadValue_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).DpadValue;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_DpadValue_11(ref object o, object v)
        {
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.DpadValue = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_DpadValue_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @DpadValue = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.DpadValue = @DpadValue;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_LeftJoystickValue_12(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).LeftJoystickValue;
        }

        static StackObject* CopyToStack_LeftJoystickValue_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).LeftJoystickValue;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LeftJoystickValue_12(ref object o, object v)
        {
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.LeftJoystickValue = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_LeftJoystickValue_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @LeftJoystickValue = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.LeftJoystickValue = @LeftJoystickValue;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_RightJoystickValue_13(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).RightJoystickValue;
        }

        static StackObject* CopyToStack_RightJoystickValue_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).RightJoystickValue;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_RightJoystickValue_13(ref object o, object v)
        {
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.RightJoystickValue = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_RightJoystickValue_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @RightJoystickValue = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.RightJoystickValue = @RightJoystickValue;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_RightTrigger_14(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).RightTrigger;
        }

        static StackObject* CopyToStack_RightTrigger_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).RightTrigger;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_RightTrigger_14(ref object o, object v)
        {
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.RightTrigger = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_RightTrigger_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @RightTrigger = *(float*)&ptr_of_this_method->Value;
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.RightTrigger = @RightTrigger;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_RightShoulder_15(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).RightShoulder;
        }

        static StackObject* CopyToStack_RightShoulder_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).RightShoulder;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_RightShoulder_15(ref object o, object v)
        {
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.RightShoulder = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_RightShoulder_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @RightShoulder = *(float*)&ptr_of_this_method->Value;
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.RightShoulder = @RightShoulder;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_LeftTrigger_16(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).LeftTrigger;
        }

        static StackObject* CopyToStack_LeftTrigger_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).LeftTrigger;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_LeftTrigger_16(ref object o, object v)
        {
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.LeftTrigger = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_LeftTrigger_16(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @LeftTrigger = *(float*)&ptr_of_this_method->Value;
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.LeftTrigger = @LeftTrigger;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_LeftShoulder_17(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).LeftShoulder;
        }

        static StackObject* CopyToStack_LeftShoulder_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).LeftShoulder;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_LeftShoulder_17(ref object o, object v)
        {
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.LeftShoulder = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_LeftShoulder_17(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @LeftShoulder = *(float*)&ptr_of_this_method->Value;
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.LeftShoulder = @LeftShoulder;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Option_18(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).Option;
        }

        static StackObject* CopyToStack_Option_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).Option;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_Option_18(ref object o, object v)
        {
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.Option = (System.Boolean)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Option_18(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @Option = ptr_of_this_method->Value == 1;
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.Option = @Option;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Share_19(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).Share;
        }

        static StackObject* CopyToStack_Share_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).Share;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_Share_19(ref object o, object v)
        {
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.Share = (System.Boolean)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Share_19(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @Share = ptr_of_this_method->Value == 1;
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.Share = @Share;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_LeftJoystickPressed_20(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).LeftJoystickPressed;
        }

        static StackObject* CopyToStack_LeftJoystickPressed_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).LeftJoystickPressed;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_LeftJoystickPressed_20(ref object o, object v)
        {
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.LeftJoystickPressed = (System.Boolean)v;
            o = ins;
        }

        static StackObject* AssignFromStack_LeftJoystickPressed_20(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @LeftJoystickPressed = ptr_of_this_method->Value == 1;
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.LeftJoystickPressed = @LeftJoystickPressed;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_RightJoystickPressed_21(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).RightJoystickPressed;
        }

        static StackObject* CopyToStack_RightJoystickPressed_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).RightJoystickPressed;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_RightJoystickPressed_21(ref object o, object v)
        {
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.RightJoystickPressed = (System.Boolean)v;
            o = ins;
        }

        static StackObject* AssignFromStack_RightJoystickPressed_21(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @RightJoystickPressed = ptr_of_this_method->Value == 1;
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.RightJoystickPressed = @RightJoystickPressed;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Buttons_22(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).Buttons;
        }

        static StackObject* CopyToStack_Buttons_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o).Buttons;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static void set_Buttons_22(ref object o, object v)
        {
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.Buttons = (System.UInt32)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Buttons_22(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt32 @Buttons = (uint)ptr_of_this_method->Value;
            Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData ins =(Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            ins.Buttons = @Buttons;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData();
            ins = (Phantom.XRMOD.PhotonModule.Runtime.NetworkInputData)o;
            return ins;
        }


    }
}
#endif