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
    unsafe class Fusion_Addons_Physics_TRSThresholds_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.Physics.TRSThresholds);
            args = new Type[]{};
            method = type.GetMethod("get_Default", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Default_0);

            field = type.GetField("UseEnergy", flag);
            app.RegisterCLRFieldGetter(field, get_UseEnergy_0);
            app.RegisterCLRFieldSetter(field, set_UseEnergy_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_UseEnergy_0, AssignFromStack_UseEnergy_0);
            field = type.GetField("Position", flag);
            app.RegisterCLRFieldGetter(field, get_Position_1);
            app.RegisterCLRFieldSetter(field, set_Position_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Position_1, AssignFromStack_Position_1);
            field = type.GetField("Rotation", flag);
            app.RegisterCLRFieldGetter(field, get_Rotation_2);
            app.RegisterCLRFieldSetter(field, set_Rotation_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Rotation_2, AssignFromStack_Rotation_2);
            field = type.GetField("Scale", flag);
            app.RegisterCLRFieldGetter(field, get_Scale_3);
            app.RegisterCLRFieldSetter(field, set_Scale_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Scale_3, AssignFromStack_Scale_3);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.Physics.TRSThresholds());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.Physics.TRSThresholds[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Fusion.Addons.Physics.TRSThresholds instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Fusion.Addons.Physics.TRSThresholds[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* get_Default_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Fusion.Addons.Physics.TRSThresholds.Default;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_UseEnergy_0(ref object o)
        {
            return ((Fusion.Addons.Physics.TRSThresholds)o).UseEnergy;
        }

        static StackObject* CopyToStack_UseEnergy_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.TRSThresholds)o).UseEnergy;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_UseEnergy_0(ref object o, object v)
        {
            Fusion.Addons.Physics.TRSThresholds ins =(Fusion.Addons.Physics.TRSThresholds)o;
            ins.UseEnergy = (System.Boolean)v;
            o = ins;
        }

        static StackObject* AssignFromStack_UseEnergy_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @UseEnergy = ptr_of_this_method->Value == 1;
            Fusion.Addons.Physics.TRSThresholds ins =(Fusion.Addons.Physics.TRSThresholds)o;
            ins.UseEnergy = @UseEnergy;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Position_1(ref object o)
        {
            return ((Fusion.Addons.Physics.TRSThresholds)o).Position;
        }

        static StackObject* CopyToStack_Position_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.TRSThresholds)o).Position;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Position_1(ref object o, object v)
        {
            Fusion.Addons.Physics.TRSThresholds ins =(Fusion.Addons.Physics.TRSThresholds)o;
            ins.Position = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Position_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Position = *(float*)&ptr_of_this_method->Value;
            Fusion.Addons.Physics.TRSThresholds ins =(Fusion.Addons.Physics.TRSThresholds)o;
            ins.Position = @Position;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Rotation_2(ref object o)
        {
            return ((Fusion.Addons.Physics.TRSThresholds)o).Rotation;
        }

        static StackObject* CopyToStack_Rotation_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.TRSThresholds)o).Rotation;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Rotation_2(ref object o, object v)
        {
            Fusion.Addons.Physics.TRSThresholds ins =(Fusion.Addons.Physics.TRSThresholds)o;
            ins.Rotation = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Rotation_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Rotation = *(float*)&ptr_of_this_method->Value;
            Fusion.Addons.Physics.TRSThresholds ins =(Fusion.Addons.Physics.TRSThresholds)o;
            ins.Rotation = @Rotation;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Scale_3(ref object o)
        {
            return ((Fusion.Addons.Physics.TRSThresholds)o).Scale;
        }

        static StackObject* CopyToStack_Scale_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.TRSThresholds)o).Scale;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Scale_3(ref object o, object v)
        {
            Fusion.Addons.Physics.TRSThresholds ins =(Fusion.Addons.Physics.TRSThresholds)o;
            ins.Scale = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Scale_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Scale = *(float*)&ptr_of_this_method->Value;
            Fusion.Addons.Physics.TRSThresholds ins =(Fusion.Addons.Physics.TRSThresholds)o;
            ins.Scale = @Scale;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Fusion.Addons.Physics.TRSThresholds();
            ins = (Fusion.Addons.Physics.TRSThresholds)o;
            return ins;
        }


    }
}
#endif