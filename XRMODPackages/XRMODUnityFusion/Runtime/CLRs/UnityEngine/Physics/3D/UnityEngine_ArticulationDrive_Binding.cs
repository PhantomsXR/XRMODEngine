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
    unsafe class UnityEngine_ArticulationDrive_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ArticulationDrive);

            field = type.GetField("lowerLimit", flag);
            app.RegisterCLRFieldGetter(field, get_lowerLimit_0);
            app.RegisterCLRFieldSetter(field, set_lowerLimit_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_lowerLimit_0, AssignFromStack_lowerLimit_0);
            field = type.GetField("upperLimit", flag);
            app.RegisterCLRFieldGetter(field, get_upperLimit_1);
            app.RegisterCLRFieldSetter(field, set_upperLimit_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_upperLimit_1, AssignFromStack_upperLimit_1);
            field = type.GetField("stiffness", flag);
            app.RegisterCLRFieldGetter(field, get_stiffness_2);
            app.RegisterCLRFieldSetter(field, set_stiffness_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_stiffness_2, AssignFromStack_stiffness_2);
            field = type.GetField("damping", flag);
            app.RegisterCLRFieldGetter(field, get_damping_3);
            app.RegisterCLRFieldSetter(field, set_damping_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_damping_3, AssignFromStack_damping_3);
            field = type.GetField("forceLimit", flag);
            app.RegisterCLRFieldGetter(field, get_forceLimit_4);
            app.RegisterCLRFieldSetter(field, set_forceLimit_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_forceLimit_4, AssignFromStack_forceLimit_4);
            field = type.GetField("target", flag);
            app.RegisterCLRFieldGetter(field, get_target_5);
            app.RegisterCLRFieldSetter(field, set_target_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_target_5, AssignFromStack_target_5);
            field = type.GetField("targetVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_targetVelocity_6);
            app.RegisterCLRFieldSetter(field, set_targetVelocity_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_targetVelocity_6, AssignFromStack_targetVelocity_6);
            field = type.GetField("driveType", flag);
            app.RegisterCLRFieldGetter(field, get_driveType_7);
            app.RegisterCLRFieldSetter(field, set_driveType_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_driveType_7, AssignFromStack_driveType_7);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ArticulationDrive());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ArticulationDrive[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.ArticulationDrive instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ArticulationDrive[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_lowerLimit_0(ref object o)
        {
            return ((UnityEngine.ArticulationDrive)o).lowerLimit;
        }

        static StackObject* CopyToStack_lowerLimit_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.ArticulationDrive)o).lowerLimit;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_lowerLimit_0(ref object o, object v)
        {
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.lowerLimit = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_lowerLimit_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @lowerLimit = *(float*)&ptr_of_this_method->Value;
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.lowerLimit = @lowerLimit;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_upperLimit_1(ref object o)
        {
            return ((UnityEngine.ArticulationDrive)o).upperLimit;
        }

        static StackObject* CopyToStack_upperLimit_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.ArticulationDrive)o).upperLimit;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_upperLimit_1(ref object o, object v)
        {
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.upperLimit = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_upperLimit_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @upperLimit = *(float*)&ptr_of_this_method->Value;
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.upperLimit = @upperLimit;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_stiffness_2(ref object o)
        {
            return ((UnityEngine.ArticulationDrive)o).stiffness;
        }

        static StackObject* CopyToStack_stiffness_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.ArticulationDrive)o).stiffness;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_stiffness_2(ref object o, object v)
        {
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.stiffness = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_stiffness_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @stiffness = *(float*)&ptr_of_this_method->Value;
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.stiffness = @stiffness;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_damping_3(ref object o)
        {
            return ((UnityEngine.ArticulationDrive)o).damping;
        }

        static StackObject* CopyToStack_damping_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.ArticulationDrive)o).damping;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_damping_3(ref object o, object v)
        {
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.damping = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_damping_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @damping = *(float*)&ptr_of_this_method->Value;
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.damping = @damping;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_forceLimit_4(ref object o)
        {
            return ((UnityEngine.ArticulationDrive)o).forceLimit;
        }

        static StackObject* CopyToStack_forceLimit_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.ArticulationDrive)o).forceLimit;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_forceLimit_4(ref object o, object v)
        {
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.forceLimit = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_forceLimit_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @forceLimit = *(float*)&ptr_of_this_method->Value;
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.forceLimit = @forceLimit;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_target_5(ref object o)
        {
            return ((UnityEngine.ArticulationDrive)o).target;
        }

        static StackObject* CopyToStack_target_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.ArticulationDrive)o).target;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_target_5(ref object o, object v)
        {
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.target = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_target_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @target = *(float*)&ptr_of_this_method->Value;
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.target = @target;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_targetVelocity_6(ref object o)
        {
            return ((UnityEngine.ArticulationDrive)o).targetVelocity;
        }

        static StackObject* CopyToStack_targetVelocity_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.ArticulationDrive)o).targetVelocity;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_targetVelocity_6(ref object o, object v)
        {
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.targetVelocity = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_targetVelocity_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @targetVelocity = *(float*)&ptr_of_this_method->Value;
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.targetVelocity = @targetVelocity;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_driveType_7(ref object o)
        {
            return ((UnityEngine.ArticulationDrive)o).driveType;
        }

        static StackObject* CopyToStack_driveType_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.ArticulationDrive)o).driveType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_driveType_7(ref object o, object v)
        {
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.driveType = (UnityEngine.ArticulationDriveType)v;
            o = ins;
        }

        static StackObject* AssignFromStack_driveType_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.ArticulationDriveType @driveType = (UnityEngine.ArticulationDriveType)typeof(UnityEngine.ArticulationDriveType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            UnityEngine.ArticulationDrive ins =(UnityEngine.ArticulationDrive)o;
            ins.driveType = @driveType;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ArticulationDrive();
            ins = (UnityEngine.ArticulationDrive)o;
            return ins;
        }


    }
}
