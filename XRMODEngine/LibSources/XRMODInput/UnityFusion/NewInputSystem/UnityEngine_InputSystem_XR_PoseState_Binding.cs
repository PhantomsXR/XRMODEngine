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
    unsafe class UnityEngine_InputSystem_XR_PoseState_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.XR.PoseState);
            args = new Type[]{};
            method = type.GetMethod("get_format", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_format_0);

            field = type.GetField("isTracked", flag);
            app.RegisterCLRFieldGetter(field, get_isTracked_0);
            app.RegisterCLRFieldSetter(field, set_isTracked_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_isTracked_0, AssignFromStack_isTracked_0);
            field = type.GetField("trackingState", flag);
            app.RegisterCLRFieldGetter(field, get_trackingState_1);
            app.RegisterCLRFieldSetter(field, set_trackingState_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_trackingState_1, AssignFromStack_trackingState_1);
            field = type.GetField("position", flag);
            app.RegisterCLRFieldGetter(field, get_position_2);
            app.RegisterCLRFieldSetter(field, set_position_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_position_2, AssignFromStack_position_2);
            field = type.GetField("rotation", flag);
            app.RegisterCLRFieldGetter(field, get_rotation_3);
            app.RegisterCLRFieldSetter(field, set_rotation_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_rotation_3, AssignFromStack_rotation_3);
            field = type.GetField("velocity", flag);
            app.RegisterCLRFieldGetter(field, get_velocity_4);
            app.RegisterCLRFieldSetter(field, set_velocity_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_velocity_4, AssignFromStack_velocity_4);
            field = type.GetField("angularVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_angularVelocity_5);
            app.RegisterCLRFieldSetter(field, set_angularVelocity_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_angularVelocity_5, AssignFromStack_angularVelocity_5);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.XR.PoseState());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.XR.PoseState[s]);

            args = new Type[]{typeof(System.Boolean), typeof(UnityEngine.XR.InputTrackingState), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.InputSystem.XR.PoseState instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.InputSystem.XR.PoseState[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* get_format_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.XR.PoseState instance_of_this_method = (UnityEngine.InputSystem.XR.PoseState)typeof(UnityEngine.InputSystem.XR.PoseState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.format;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_isTracked_0(ref object o)
        {
            return ((UnityEngine.InputSystem.XR.PoseState)o).isTracked;
        }

        static StackObject* CopyToStack_isTracked_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.InputSystem.XR.PoseState)o).isTracked;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_isTracked_0(ref object o, object v)
        {
            UnityEngine.InputSystem.XR.PoseState ins =(UnityEngine.InputSystem.XR.PoseState)o;
            ins.isTracked = (System.Boolean)v;
            o = ins;
        }

        static StackObject* AssignFromStack_isTracked_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @isTracked = ptr_of_this_method->Value == 1;
            UnityEngine.InputSystem.XR.PoseState ins =(UnityEngine.InputSystem.XR.PoseState)o;
            ins.isTracked = @isTracked;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_trackingState_1(ref object o)
        {
            return ((UnityEngine.InputSystem.XR.PoseState)o).trackingState;
        }

        static StackObject* CopyToStack_trackingState_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.InputSystem.XR.PoseState)o).trackingState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_trackingState_1(ref object o, object v)
        {
            UnityEngine.InputSystem.XR.PoseState ins =(UnityEngine.InputSystem.XR.PoseState)o;
            ins.trackingState = (UnityEngine.XR.InputTrackingState)v;
            o = ins;
        }

        static StackObject* AssignFromStack_trackingState_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputTrackingState @trackingState = (UnityEngine.XR.InputTrackingState)typeof(UnityEngine.XR.InputTrackingState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            UnityEngine.InputSystem.XR.PoseState ins =(UnityEngine.InputSystem.XR.PoseState)o;
            ins.trackingState = @trackingState;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_position_2(ref object o)
        {
            return ((UnityEngine.InputSystem.XR.PoseState)o).position;
        }

        static StackObject* CopyToStack_position_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.InputSystem.XR.PoseState)o).position;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_position_2(ref object o, object v)
        {
            UnityEngine.InputSystem.XR.PoseState ins =(UnityEngine.InputSystem.XR.PoseState)o;
            ins.position = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_position_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.InputSystem.XR.PoseState ins =(UnityEngine.InputSystem.XR.PoseState)o;
            ins.position = @position;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_rotation_3(ref object o)
        {
            return ((UnityEngine.InputSystem.XR.PoseState)o).rotation;
        }

        static StackObject* CopyToStack_rotation_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.InputSystem.XR.PoseState)o).rotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_rotation_3(ref object o, object v)
        {
            UnityEngine.InputSystem.XR.PoseState ins =(UnityEngine.InputSystem.XR.PoseState)o;
            ins.rotation = (UnityEngine.Quaternion)v;
            o = ins;
        }

        static StackObject* AssignFromStack_rotation_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.InputSystem.XR.PoseState ins =(UnityEngine.InputSystem.XR.PoseState)o;
            ins.rotation = @rotation;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_velocity_4(ref object o)
        {
            return ((UnityEngine.InputSystem.XR.PoseState)o).velocity;
        }

        static StackObject* CopyToStack_velocity_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.InputSystem.XR.PoseState)o).velocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_velocity_4(ref object o, object v)
        {
            UnityEngine.InputSystem.XR.PoseState ins =(UnityEngine.InputSystem.XR.PoseState)o;
            ins.velocity = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_velocity_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @velocity = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.InputSystem.XR.PoseState ins =(UnityEngine.InputSystem.XR.PoseState)o;
            ins.velocity = @velocity;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_angularVelocity_5(ref object o)
        {
            return ((UnityEngine.InputSystem.XR.PoseState)o).angularVelocity;
        }

        static StackObject* CopyToStack_angularVelocity_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.InputSystem.XR.PoseState)o).angularVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_angularVelocity_5(ref object o, object v)
        {
            UnityEngine.InputSystem.XR.PoseState ins =(UnityEngine.InputSystem.XR.PoseState)o;
            ins.angularVelocity = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_angularVelocity_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @angularVelocity = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.InputSystem.XR.PoseState ins =(UnityEngine.InputSystem.XR.PoseState)o;
            ins.angularVelocity = @angularVelocity;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.InputSystem.XR.PoseState();
            ins = (UnityEngine.InputSystem.XR.PoseState)o;
            return ins;
        }

        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @angularVelocity = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @velocity = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.XR.InputTrackingState @trackingState = (UnityEngine.XR.InputTrackingState)typeof(UnityEngine.XR.InputTrackingState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Boolean @isTracked = ptr_of_this_method->Value == 1;


            var result_of_this_method = new UnityEngine.InputSystem.XR.PoseState(@isTracked, @trackingState, @position, @rotation, @velocity, @angularVelocity);

            if(!isNewObj)
            {
                __ret--;
                WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                return __ret;
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
