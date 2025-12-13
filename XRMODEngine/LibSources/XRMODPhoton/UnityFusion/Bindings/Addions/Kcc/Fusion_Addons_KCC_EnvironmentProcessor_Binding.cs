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
    unsafe class Fusion_Addons_KCC_EnvironmentProcessor_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.EnvironmentProcessor);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCC)};
            method = type.GetMethod("GetPriority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPriority_0);
            args = new Type[]{typeof(Fusion.Addons.KCC.PrepareData), typeof(Fusion.Addons.KCC.KCC), typeof(Fusion.Addons.KCC.KCCData)};
            method = type.GetMethod("Execute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Execute_1);
            args = new Type[]{typeof(Fusion.Addons.KCC.ISetDynamicVelocity), typeof(Fusion.Addons.KCC.KCC), typeof(Fusion.Addons.KCC.KCCData)};
            method = type.GetMethod("Execute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Execute_2);
            args = new Type[]{typeof(Fusion.Addons.KCC.ISetKinematicDirection), typeof(Fusion.Addons.KCC.KCC), typeof(Fusion.Addons.KCC.KCCData)};
            method = type.GetMethod("Execute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Execute_3);
            args = new Type[]{typeof(Fusion.Addons.KCC.ISetKinematicTangent), typeof(Fusion.Addons.KCC.KCC), typeof(Fusion.Addons.KCC.KCCData)};
            method = type.GetMethod("Execute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Execute_4);
            args = new Type[]{typeof(Fusion.Addons.KCC.ISetKinematicSpeed), typeof(Fusion.Addons.KCC.KCC), typeof(Fusion.Addons.KCC.KCCData)};
            method = type.GetMethod("Execute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Execute_5);
            args = new Type[]{typeof(Fusion.Addons.KCC.ISetKinematicVelocity), typeof(Fusion.Addons.KCC.KCC), typeof(Fusion.Addons.KCC.KCCData)};
            method = type.GetMethod("Execute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Execute_6);
            args = new Type[]{typeof(Fusion.Addons.KCC.AfterMoveStep), typeof(Fusion.Addons.KCC.KCC), typeof(Fusion.Addons.KCC.KCCData)};
            method = type.GetMethod("Execute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Execute_7);

            field = type.GetField("DefaultPriority", flag);
            app.RegisterCLRFieldGetter(field, get_DefaultPriority_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_DefaultPriority_0, null);
            field = type.GetField("KinematicSpeed", flag);
            app.RegisterCLRFieldGetter(field, get_KinematicSpeed_1);
            app.RegisterCLRFieldSetter(field, set_KinematicSpeed_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_KinematicSpeed_1, AssignFromStack_KinematicSpeed_1);
            field = type.GetField("JumpMultiplier", flag);
            app.RegisterCLRFieldGetter(field, get_JumpMultiplier_2);
            app.RegisterCLRFieldSetter(field, set_JumpMultiplier_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_JumpMultiplier_2, AssignFromStack_JumpMultiplier_2);
            field = type.GetField("Gravity", flag);
            app.RegisterCLRFieldGetter(field, get_Gravity_3);
            app.RegisterCLRFieldSetter(field, set_Gravity_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Gravity_3, AssignFromStack_Gravity_3);
            field = type.GetField("RelativePriority", flag);
            app.RegisterCLRFieldGetter(field, get_RelativePriority_4);
            app.RegisterCLRFieldSetter(field, set_RelativePriority_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_RelativePriority_4, AssignFromStack_RelativePriority_4);
            field = type.GetField("MaxGroundAngle", flag);
            app.RegisterCLRFieldGetter(field, get_MaxGroundAngle_5);
            app.RegisterCLRFieldSetter(field, set_MaxGroundAngle_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_MaxGroundAngle_5, AssignFromStack_MaxGroundAngle_5);
            field = type.GetField("DynamicGroundFriction", flag);
            app.RegisterCLRFieldGetter(field, get_DynamicGroundFriction_6);
            app.RegisterCLRFieldSetter(field, set_DynamicGroundFriction_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_DynamicGroundFriction_6, AssignFromStack_DynamicGroundFriction_6);
            field = type.GetField("KinematicGroundAcceleration", flag);
            app.RegisterCLRFieldGetter(field, get_KinematicGroundAcceleration_7);
            app.RegisterCLRFieldSetter(field, set_KinematicGroundAcceleration_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_KinematicGroundAcceleration_7, AssignFromStack_KinematicGroundAcceleration_7);
            field = type.GetField("KinematicGroundFriction", flag);
            app.RegisterCLRFieldGetter(field, get_KinematicGroundFriction_8);
            app.RegisterCLRFieldSetter(field, set_KinematicGroundFriction_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_KinematicGroundFriction_8, AssignFromStack_KinematicGroundFriction_8);
            field = type.GetField("DynamicAirFriction", flag);
            app.RegisterCLRFieldGetter(field, get_DynamicAirFriction_9);
            app.RegisterCLRFieldSetter(field, set_DynamicAirFriction_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_DynamicAirFriction_9, AssignFromStack_DynamicAirFriction_9);
            field = type.GetField("KinematicAirAcceleration", flag);
            app.RegisterCLRFieldGetter(field, get_KinematicAirAcceleration_10);
            app.RegisterCLRFieldSetter(field, set_KinematicAirAcceleration_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_KinematicAirAcceleration_10, AssignFromStack_KinematicAirAcceleration_10);
            field = type.GetField("KinematicAirFriction", flag);
            app.RegisterCLRFieldGetter(field, get_KinematicAirFriction_11);
            app.RegisterCLRFieldSetter(field, set_KinematicAirFriction_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_KinematicAirFriction_11, AssignFromStack_KinematicAirFriction_11);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.EnvironmentProcessor());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.EnvironmentProcessor[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* GetPriority_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.EnvironmentProcessor instance_of_this_method = (Fusion.Addons.KCC.EnvironmentProcessor)typeof(Fusion.Addons.KCC.EnvironmentProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPriority(@kcc);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Execute_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData @data = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.PrepareData @stage = (Fusion.Addons.KCC.PrepareData)typeof(Fusion.Addons.KCC.PrepareData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Addons.KCC.EnvironmentProcessor instance_of_this_method = (Fusion.Addons.KCC.EnvironmentProcessor)typeof(Fusion.Addons.KCC.EnvironmentProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Execute(@stage, @kcc, @data);

            return __ret;
        }

        static StackObject* Execute_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData @data = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.ISetDynamicVelocity @stage = (Fusion.Addons.KCC.ISetDynamicVelocity)typeof(Fusion.Addons.KCC.ISetDynamicVelocity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Addons.KCC.EnvironmentProcessor instance_of_this_method = (Fusion.Addons.KCC.EnvironmentProcessor)typeof(Fusion.Addons.KCC.EnvironmentProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Execute(@stage, @kcc, @data);

            return __ret;
        }

        static StackObject* Execute_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData @data = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.ISetKinematicDirection @stage = (Fusion.Addons.KCC.ISetKinematicDirection)typeof(Fusion.Addons.KCC.ISetKinematicDirection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Addons.KCC.EnvironmentProcessor instance_of_this_method = (Fusion.Addons.KCC.EnvironmentProcessor)typeof(Fusion.Addons.KCC.EnvironmentProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Execute(@stage, @kcc, @data);

            return __ret;
        }

        static StackObject* Execute_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData @data = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.ISetKinematicTangent @stage = (Fusion.Addons.KCC.ISetKinematicTangent)typeof(Fusion.Addons.KCC.ISetKinematicTangent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Addons.KCC.EnvironmentProcessor instance_of_this_method = (Fusion.Addons.KCC.EnvironmentProcessor)typeof(Fusion.Addons.KCC.EnvironmentProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Execute(@stage, @kcc, @data);

            return __ret;
        }

        static StackObject* Execute_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData @data = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.ISetKinematicSpeed @stage = (Fusion.Addons.KCC.ISetKinematicSpeed)typeof(Fusion.Addons.KCC.ISetKinematicSpeed).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Addons.KCC.EnvironmentProcessor instance_of_this_method = (Fusion.Addons.KCC.EnvironmentProcessor)typeof(Fusion.Addons.KCC.EnvironmentProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Execute(@stage, @kcc, @data);

            return __ret;
        }

        static StackObject* Execute_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData @data = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.ISetKinematicVelocity @stage = (Fusion.Addons.KCC.ISetKinematicVelocity)typeof(Fusion.Addons.KCC.ISetKinematicVelocity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Addons.KCC.EnvironmentProcessor instance_of_this_method = (Fusion.Addons.KCC.EnvironmentProcessor)typeof(Fusion.Addons.KCC.EnvironmentProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Execute(@stage, @kcc, @data);

            return __ret;
        }

        static StackObject* Execute_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData @data = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.AfterMoveStep @stage = (Fusion.Addons.KCC.AfterMoveStep)typeof(Fusion.Addons.KCC.AfterMoveStep).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Addons.KCC.EnvironmentProcessor instance_of_this_method = (Fusion.Addons.KCC.EnvironmentProcessor)typeof(Fusion.Addons.KCC.EnvironmentProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Execute(@stage, @kcc, @data);

            return __ret;
        }


        static object get_DefaultPriority_0(ref object o)
        {
            return Fusion.Addons.KCC.EnvironmentProcessor.DefaultPriority;
        }

        static StackObject* CopyToStack_DefaultPriority_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.EnvironmentProcessor.DefaultPriority;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_KinematicSpeed_1(ref object o)
        {
            return ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicSpeed;
        }

        static StackObject* CopyToStack_KinematicSpeed_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicSpeed;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_KinematicSpeed_1(ref object o, object v)
        {
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicSpeed = (System.Single)v;
        }

        static StackObject* AssignFromStack_KinematicSpeed_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @KinematicSpeed = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicSpeed = @KinematicSpeed;
            return ptr_of_this_method;
        }

        static object get_JumpMultiplier_2(ref object o)
        {
            return ((Fusion.Addons.KCC.EnvironmentProcessor)o).JumpMultiplier;
        }

        static StackObject* CopyToStack_JumpMultiplier_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.EnvironmentProcessor)o).JumpMultiplier;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_JumpMultiplier_2(ref object o, object v)
        {
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).JumpMultiplier = (System.Single)v;
        }

        static StackObject* AssignFromStack_JumpMultiplier_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @JumpMultiplier = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).JumpMultiplier = @JumpMultiplier;
            return ptr_of_this_method;
        }

        static object get_Gravity_3(ref object o)
        {
            return ((Fusion.Addons.KCC.EnvironmentProcessor)o).Gravity;
        }

        static StackObject* CopyToStack_Gravity_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.EnvironmentProcessor)o).Gravity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Gravity_3(ref object o, object v)
        {
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).Gravity = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_Gravity_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Gravity = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).Gravity = @Gravity;
            return ptr_of_this_method;
        }

        static object get_RelativePriority_4(ref object o)
        {
            return ((Fusion.Addons.KCC.EnvironmentProcessor)o).RelativePriority;
        }

        static StackObject* CopyToStack_RelativePriority_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.EnvironmentProcessor)o).RelativePriority;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_RelativePriority_4(ref object o, object v)
        {
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).RelativePriority = (System.Int32)v;
        }

        static StackObject* AssignFromStack_RelativePriority_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @RelativePriority = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).RelativePriority = @RelativePriority;
            return ptr_of_this_method;
        }

        static object get_MaxGroundAngle_5(ref object o)
        {
            return ((Fusion.Addons.KCC.EnvironmentProcessor)o).MaxGroundAngle;
        }

        static StackObject* CopyToStack_MaxGroundAngle_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.EnvironmentProcessor)o).MaxGroundAngle;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MaxGroundAngle_5(ref object o, object v)
        {
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).MaxGroundAngle = (System.Single)v;
        }

        static StackObject* AssignFromStack_MaxGroundAngle_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @MaxGroundAngle = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).MaxGroundAngle = @MaxGroundAngle;
            return ptr_of_this_method;
        }

        static object get_DynamicGroundFriction_6(ref object o)
        {
            return ((Fusion.Addons.KCC.EnvironmentProcessor)o).DynamicGroundFriction;
        }

        static StackObject* CopyToStack_DynamicGroundFriction_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.EnvironmentProcessor)o).DynamicGroundFriction;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_DynamicGroundFriction_6(ref object o, object v)
        {
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).DynamicGroundFriction = (System.Single)v;
        }

        static StackObject* AssignFromStack_DynamicGroundFriction_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @DynamicGroundFriction = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).DynamicGroundFriction = @DynamicGroundFriction;
            return ptr_of_this_method;
        }

        static object get_KinematicGroundAcceleration_7(ref object o)
        {
            return ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicGroundAcceleration;
        }

        static StackObject* CopyToStack_KinematicGroundAcceleration_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicGroundAcceleration;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_KinematicGroundAcceleration_7(ref object o, object v)
        {
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicGroundAcceleration = (System.Single)v;
        }

        static StackObject* AssignFromStack_KinematicGroundAcceleration_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @KinematicGroundAcceleration = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicGroundAcceleration = @KinematicGroundAcceleration;
            return ptr_of_this_method;
        }

        static object get_KinematicGroundFriction_8(ref object o)
        {
            return ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicGroundFriction;
        }

        static StackObject* CopyToStack_KinematicGroundFriction_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicGroundFriction;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_KinematicGroundFriction_8(ref object o, object v)
        {
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicGroundFriction = (System.Single)v;
        }

        static StackObject* AssignFromStack_KinematicGroundFriction_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @KinematicGroundFriction = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicGroundFriction = @KinematicGroundFriction;
            return ptr_of_this_method;
        }

        static object get_DynamicAirFriction_9(ref object o)
        {
            return ((Fusion.Addons.KCC.EnvironmentProcessor)o).DynamicAirFriction;
        }

        static StackObject* CopyToStack_DynamicAirFriction_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.EnvironmentProcessor)o).DynamicAirFriction;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_DynamicAirFriction_9(ref object o, object v)
        {
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).DynamicAirFriction = (System.Single)v;
        }

        static StackObject* AssignFromStack_DynamicAirFriction_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @DynamicAirFriction = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).DynamicAirFriction = @DynamicAirFriction;
            return ptr_of_this_method;
        }

        static object get_KinematicAirAcceleration_10(ref object o)
        {
            return ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicAirAcceleration;
        }

        static StackObject* CopyToStack_KinematicAirAcceleration_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicAirAcceleration;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_KinematicAirAcceleration_10(ref object o, object v)
        {
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicAirAcceleration = (System.Single)v;
        }

        static StackObject* AssignFromStack_KinematicAirAcceleration_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @KinematicAirAcceleration = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicAirAcceleration = @KinematicAirAcceleration;
            return ptr_of_this_method;
        }

        static object get_KinematicAirFriction_11(ref object o)
        {
            return ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicAirFriction;
        }

        static StackObject* CopyToStack_KinematicAirFriction_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicAirFriction;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_KinematicAirFriction_11(ref object o, object v)
        {
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicAirFriction = (System.Single)v;
        }

        static StackObject* AssignFromStack_KinematicAirFriction_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @KinematicAirFriction = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.EnvironmentProcessor)o).KinematicAirFriction = @KinematicAirFriction;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.EnvironmentProcessor();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif