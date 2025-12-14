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
    unsafe class Fusion_Addons_Physics_RunnerSimulatePhysicsBase_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.Physics.RunnerSimulatePhysicsBase);
            args = new Type[]{};
            method = type.GetMethod("get_PhysicsAuthority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PhysicsAuthority_0);
            args = new Type[]{};
            method = type.GetMethod("get_PhysicsTiming", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PhysicsTiming_1);
            args = new Type[]{};
            method = type.GetMethod("get_PhysicsSimulationDeltaTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PhysicsSimulationDeltaTime_2);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_OnBeforeSimulate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnBeforeSimulate_3);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_OnBeforeSimulate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnBeforeSimulate_4);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_OnAfterSimulate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnAfterSimulate_5);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_OnAfterSimulate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnAfterSimulate_6);
            args = new Type[]{};
            method = type.GetMethod("get_HasSimulatedThisTick", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_HasSimulatedThisTick_7);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("QueueBeforeSimulationCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, QueueBeforeSimulationCallback_8);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("QueueAfterSimulationCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, QueueAfterSimulationCallback_9);
            args = new Type[]{};
            method = type.GetMethod("FixedUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FixedUpdate_10);
            args = new Type[]{};
            method = type.GetMethod("FixedUpdateNetwork", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FixedUpdateNetwork_11);

            field = type.GetField("ClientPhysicsSimulation", flag);
            app.RegisterCLRFieldGetter(field, get_ClientPhysicsSimulation_0);
            app.RegisterCLRFieldSetter(field, set_ClientPhysicsSimulation_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientPhysicsSimulation_0, AssignFromStack_ClientPhysicsSimulation_0);
            field = type.GetField("DeltaTimeMultiplier", flag);
            app.RegisterCLRFieldGetter(field, get_DeltaTimeMultiplier_1);
            app.RegisterCLRFieldSetter(field, set_DeltaTimeMultiplier_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_DeltaTimeMultiplier_1, AssignFromStack_DeltaTimeMultiplier_1);
            field = type.GetField("SetUnityFixedTimestep", flag);
            app.RegisterCLRFieldGetter(field, get_SetUnityFixedTimestep_2);
            app.RegisterCLRFieldSetter(field, set_SetUnityFixedTimestep_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_SetUnityFixedTimestep_2, AssignFromStack_SetUnityFixedTimestep_2);


            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.Physics.RunnerSimulatePhysicsBase[s]);


        }


        static StackObject* get_PhysicsAuthority_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.Physics.RunnerSimulatePhysicsBase instance_of_this_method = (Fusion.Addons.Physics.RunnerSimulatePhysicsBase)typeof(Fusion.Addons.Physics.RunnerSimulatePhysicsBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PhysicsAuthority;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_PhysicsTiming_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.Physics.RunnerSimulatePhysicsBase instance_of_this_method = (Fusion.Addons.Physics.RunnerSimulatePhysicsBase)typeof(Fusion.Addons.Physics.RunnerSimulatePhysicsBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PhysicsTiming;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_PhysicsSimulationDeltaTime_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.Physics.RunnerSimulatePhysicsBase instance_of_this_method = (Fusion.Addons.Physics.RunnerSimulatePhysicsBase)typeof(Fusion.Addons.Physics.RunnerSimulatePhysicsBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PhysicsSimulationDeltaTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* add_OnBeforeSimulate_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.Physics.RunnerSimulatePhysicsBase instance_of_this_method = (Fusion.Addons.Physics.RunnerSimulatePhysicsBase)typeof(Fusion.Addons.Physics.RunnerSimulatePhysicsBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnBeforeSimulate += value;

            return __ret;
        }

        static StackObject* remove_OnBeforeSimulate_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.Physics.RunnerSimulatePhysicsBase instance_of_this_method = (Fusion.Addons.Physics.RunnerSimulatePhysicsBase)typeof(Fusion.Addons.Physics.RunnerSimulatePhysicsBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnBeforeSimulate -= value;

            return __ret;
        }

        static StackObject* add_OnAfterSimulate_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.Physics.RunnerSimulatePhysicsBase instance_of_this_method = (Fusion.Addons.Physics.RunnerSimulatePhysicsBase)typeof(Fusion.Addons.Physics.RunnerSimulatePhysicsBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnAfterSimulate += value;

            return __ret;
        }

        static StackObject* remove_OnAfterSimulate_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.Physics.RunnerSimulatePhysicsBase instance_of_this_method = (Fusion.Addons.Physics.RunnerSimulatePhysicsBase)typeof(Fusion.Addons.Physics.RunnerSimulatePhysicsBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnAfterSimulate -= value;

            return __ret;
        }

        static StackObject* get_HasSimulatedThisTick_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.Physics.RunnerSimulatePhysicsBase instance_of_this_method = (Fusion.Addons.Physics.RunnerSimulatePhysicsBase)typeof(Fusion.Addons.Physics.RunnerSimulatePhysicsBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.HasSimulatedThisTick;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* QueueBeforeSimulationCallback_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @callback = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.Physics.RunnerSimulatePhysicsBase instance_of_this_method = (Fusion.Addons.Physics.RunnerSimulatePhysicsBase)typeof(Fusion.Addons.Physics.RunnerSimulatePhysicsBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.QueueBeforeSimulationCallback(@callback);

            return __ret;
        }

        static StackObject* QueueAfterSimulationCallback_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @callback = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.Physics.RunnerSimulatePhysicsBase instance_of_this_method = (Fusion.Addons.Physics.RunnerSimulatePhysicsBase)typeof(Fusion.Addons.Physics.RunnerSimulatePhysicsBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.QueueAfterSimulationCallback(@callback);

            return __ret;
        }

        static StackObject* FixedUpdate_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.Physics.RunnerSimulatePhysicsBase instance_of_this_method = (Fusion.Addons.Physics.RunnerSimulatePhysicsBase)typeof(Fusion.Addons.Physics.RunnerSimulatePhysicsBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FixedUpdate();

            return __ret;
        }

        static StackObject* FixedUpdateNetwork_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.Physics.RunnerSimulatePhysicsBase instance_of_this_method = (Fusion.Addons.Physics.RunnerSimulatePhysicsBase)typeof(Fusion.Addons.Physics.RunnerSimulatePhysicsBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FixedUpdateNetwork();

            return __ret;
        }


        static object get_ClientPhysicsSimulation_0(ref object o)
        {
            return ((Fusion.Addons.Physics.RunnerSimulatePhysicsBase)o).ClientPhysicsSimulation;
        }

        static StackObject* CopyToStack_ClientPhysicsSimulation_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.RunnerSimulatePhysicsBase)o).ClientPhysicsSimulation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientPhysicsSimulation_0(ref object o, object v)
        {
            ((Fusion.Addons.Physics.RunnerSimulatePhysicsBase)o).ClientPhysicsSimulation = (Fusion.Addons.Physics.ClientPhysicsSimulation)v;
        }

        static StackObject* AssignFromStack_ClientPhysicsSimulation_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.Physics.ClientPhysicsSimulation @ClientPhysicsSimulation = (Fusion.Addons.Physics.ClientPhysicsSimulation)typeof(Fusion.Addons.Physics.ClientPhysicsSimulation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.Addons.Physics.RunnerSimulatePhysicsBase)o).ClientPhysicsSimulation = @ClientPhysicsSimulation;
            return ptr_of_this_method;
        }

        static object get_DeltaTimeMultiplier_1(ref object o)
        {
            return ((Fusion.Addons.Physics.RunnerSimulatePhysicsBase)o).DeltaTimeMultiplier;
        }

        static StackObject* CopyToStack_DeltaTimeMultiplier_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.RunnerSimulatePhysicsBase)o).DeltaTimeMultiplier;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_DeltaTimeMultiplier_1(ref object o, object v)
        {
            ((Fusion.Addons.Physics.RunnerSimulatePhysicsBase)o).DeltaTimeMultiplier = (System.Single)v;
        }

        static StackObject* AssignFromStack_DeltaTimeMultiplier_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @DeltaTimeMultiplier = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.Physics.RunnerSimulatePhysicsBase)o).DeltaTimeMultiplier = @DeltaTimeMultiplier;
            return ptr_of_this_method;
        }

        static object get_SetUnityFixedTimestep_2(ref object o)
        {
            return ((Fusion.Addons.Physics.RunnerSimulatePhysicsBase)o).SetUnityFixedTimestep;
        }

        static StackObject* CopyToStack_SetUnityFixedTimestep_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.RunnerSimulatePhysicsBase)o).SetUnityFixedTimestep;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SetUnityFixedTimestep_2(ref object o, object v)
        {
            ((Fusion.Addons.Physics.RunnerSimulatePhysicsBase)o).SetUnityFixedTimestep = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SetUnityFixedTimestep_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SetUnityFixedTimestep = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.Physics.RunnerSimulatePhysicsBase)o).SetUnityFixedTimestep = @SetUnityFixedTimestep;
            return ptr_of_this_method;
        }




    }
}
#endif