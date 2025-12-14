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
    unsafe class Fusion_NetworkCharacterController_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.NetworkCharacterController);
            args = new Type[]{};
            method = type.GetMethod("get_Velocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Velocity_0);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_Velocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Velocity_1);
            args = new Type[]{};
            method = type.GetMethod("get_Grounded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Grounded_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_Grounded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Grounded_3);
            args = new Type[]{typeof(System.Nullable<UnityEngine.Vector3>), typeof(System.Nullable<UnityEngine.Quaternion>)};
            method = type.GetMethod("Teleport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Teleport_4);
            args = new Type[]{typeof(System.Boolean), typeof(System.Nullable<System.Single>)};
            method = type.GetMethod("Jump", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Jump_5);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("Move", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Move_6);
            args = new Type[]{};
            method = type.GetMethod("Spawned", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Spawned_7);
            args = new Type[]{};
            method = type.GetMethod("Render", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Render_8);

            field = type.GetField("gravity", flag);
            app.RegisterCLRFieldGetter(field, get_gravity_0);
            app.RegisterCLRFieldSetter(field, set_gravity_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_gravity_0, AssignFromStack_gravity_0);
            field = type.GetField("jumpImpulse", flag);
            app.RegisterCLRFieldGetter(field, get_jumpImpulse_1);
            app.RegisterCLRFieldSetter(field, set_jumpImpulse_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_jumpImpulse_1, AssignFromStack_jumpImpulse_1);
            field = type.GetField("acceleration", flag);
            app.RegisterCLRFieldGetter(field, get_acceleration_2);
            app.RegisterCLRFieldSetter(field, set_acceleration_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_acceleration_2, AssignFromStack_acceleration_2);
            field = type.GetField("braking", flag);
            app.RegisterCLRFieldGetter(field, get_braking_3);
            app.RegisterCLRFieldSetter(field, set_braking_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_braking_3, AssignFromStack_braking_3);
            field = type.GetField("maxSpeed", flag);
            app.RegisterCLRFieldGetter(field, get_maxSpeed_4);
            app.RegisterCLRFieldSetter(field, set_maxSpeed_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_maxSpeed_4, AssignFromStack_maxSpeed_4);
            field = type.GetField("rotationSpeed", flag);
            app.RegisterCLRFieldGetter(field, get_rotationSpeed_5);
            app.RegisterCLRFieldSetter(field, set_rotationSpeed_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_rotationSpeed_5, AssignFromStack_rotationSpeed_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.NetworkCharacterController());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.NetworkCharacterController[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Velocity_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkCharacterController instance_of_this_method = (Fusion.NetworkCharacterController)typeof(Fusion.NetworkCharacterController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Velocity;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Velocity_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkCharacterController instance_of_this_method = (Fusion.NetworkCharacterController)typeof(Fusion.NetworkCharacterController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Velocity = value;

            return __ret;
        }

        static StackObject* get_Grounded_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkCharacterController instance_of_this_method = (Fusion.NetworkCharacterController)typeof(Fusion.NetworkCharacterController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Grounded;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_Grounded_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkCharacterController instance_of_this_method = (Fusion.NetworkCharacterController)typeof(Fusion.NetworkCharacterController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Grounded = value;

            return __ret;
        }

        static StackObject* Teleport_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Nullable<UnityEngine.Quaternion> @rotation = (System.Nullable<UnityEngine.Quaternion>)typeof(System.Nullable<UnityEngine.Quaternion>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Nullable<UnityEngine.Vector3> @position = (System.Nullable<UnityEngine.Vector3>)typeof(System.Nullable<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.NetworkCharacterController instance_of_this_method = (Fusion.NetworkCharacterController)typeof(Fusion.NetworkCharacterController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Teleport(@position, @rotation);

            return __ret;
        }

        static StackObject* Jump_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Nullable<System.Single> @overrideImpulse = (System.Nullable<System.Single>)typeof(System.Nullable<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @ignoreGrounded = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.NetworkCharacterController instance_of_this_method = (Fusion.NetworkCharacterController)typeof(Fusion.NetworkCharacterController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Jump(@ignoreGrounded, @overrideImpulse);

            return __ret;
        }

        static StackObject* Move_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @direction = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkCharacterController instance_of_this_method = (Fusion.NetworkCharacterController)typeof(Fusion.NetworkCharacterController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Move(@direction);

            return __ret;
        }

        static StackObject* Spawned_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkCharacterController instance_of_this_method = (Fusion.NetworkCharacterController)typeof(Fusion.NetworkCharacterController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Spawned();

            return __ret;
        }

        static StackObject* Render_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkCharacterController instance_of_this_method = (Fusion.NetworkCharacterController)typeof(Fusion.NetworkCharacterController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Render();

            return __ret;
        }


        static object get_gravity_0(ref object o)
        {
            return ((Fusion.NetworkCharacterController)o).gravity;
        }

        static StackObject* CopyToStack_gravity_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkCharacterController)o).gravity;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_gravity_0(ref object o, object v)
        {
            ((Fusion.NetworkCharacterController)o).gravity = (System.Single)v;
        }

        static StackObject* AssignFromStack_gravity_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @gravity = *(float*)&ptr_of_this_method->Value;
            ((Fusion.NetworkCharacterController)o).gravity = @gravity;
            return ptr_of_this_method;
        }

        static object get_jumpImpulse_1(ref object o)
        {
            return ((Fusion.NetworkCharacterController)o).jumpImpulse;
        }

        static StackObject* CopyToStack_jumpImpulse_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkCharacterController)o).jumpImpulse;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_jumpImpulse_1(ref object o, object v)
        {
            ((Fusion.NetworkCharacterController)o).jumpImpulse = (System.Single)v;
        }

        static StackObject* AssignFromStack_jumpImpulse_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @jumpImpulse = *(float*)&ptr_of_this_method->Value;
            ((Fusion.NetworkCharacterController)o).jumpImpulse = @jumpImpulse;
            return ptr_of_this_method;
        }

        static object get_acceleration_2(ref object o)
        {
            return ((Fusion.NetworkCharacterController)o).acceleration;
        }

        static StackObject* CopyToStack_acceleration_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkCharacterController)o).acceleration;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_acceleration_2(ref object o, object v)
        {
            ((Fusion.NetworkCharacterController)o).acceleration = (System.Single)v;
        }

        static StackObject* AssignFromStack_acceleration_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @acceleration = *(float*)&ptr_of_this_method->Value;
            ((Fusion.NetworkCharacterController)o).acceleration = @acceleration;
            return ptr_of_this_method;
        }

        static object get_braking_3(ref object o)
        {
            return ((Fusion.NetworkCharacterController)o).braking;
        }

        static StackObject* CopyToStack_braking_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkCharacterController)o).braking;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_braking_3(ref object o, object v)
        {
            ((Fusion.NetworkCharacterController)o).braking = (System.Single)v;
        }

        static StackObject* AssignFromStack_braking_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @braking = *(float*)&ptr_of_this_method->Value;
            ((Fusion.NetworkCharacterController)o).braking = @braking;
            return ptr_of_this_method;
        }

        static object get_maxSpeed_4(ref object o)
        {
            return ((Fusion.NetworkCharacterController)o).maxSpeed;
        }

        static StackObject* CopyToStack_maxSpeed_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkCharacterController)o).maxSpeed;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_maxSpeed_4(ref object o, object v)
        {
            ((Fusion.NetworkCharacterController)o).maxSpeed = (System.Single)v;
        }

        static StackObject* AssignFromStack_maxSpeed_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @maxSpeed = *(float*)&ptr_of_this_method->Value;
            ((Fusion.NetworkCharacterController)o).maxSpeed = @maxSpeed;
            return ptr_of_this_method;
        }

        static object get_rotationSpeed_5(ref object o)
        {
            return ((Fusion.NetworkCharacterController)o).rotationSpeed;
        }

        static StackObject* CopyToStack_rotationSpeed_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkCharacterController)o).rotationSpeed;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_rotationSpeed_5(ref object o, object v)
        {
            ((Fusion.NetworkCharacterController)o).rotationSpeed = (System.Single)v;
        }

        static StackObject* AssignFromStack_rotationSpeed_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @rotationSpeed = *(float*)&ptr_of_this_method->Value;
            ((Fusion.NetworkCharacterController)o).rotationSpeed = @rotationSpeed;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.NetworkCharacterController();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
