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
    unsafe class UnityEngine_ModifiableMassProperties_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ModifiableMassProperties);

            field = type.GetField("inverseMassScale", flag);
            app.RegisterCLRFieldGetter(field, get_inverseMassScale_0);
            app.RegisterCLRFieldSetter(field, set_inverseMassScale_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_inverseMassScale_0, AssignFromStack_inverseMassScale_0);
            field = type.GetField("inverseInertiaScale", flag);
            app.RegisterCLRFieldGetter(field, get_inverseInertiaScale_1);
            app.RegisterCLRFieldSetter(field, set_inverseInertiaScale_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_inverseInertiaScale_1, AssignFromStack_inverseInertiaScale_1);
            field = type.GetField("otherInverseMassScale", flag);
            app.RegisterCLRFieldGetter(field, get_otherInverseMassScale_2);
            app.RegisterCLRFieldSetter(field, set_otherInverseMassScale_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_otherInverseMassScale_2, AssignFromStack_otherInverseMassScale_2);
            field = type.GetField("otherInverseInertiaScale", flag);
            app.RegisterCLRFieldGetter(field, get_otherInverseInertiaScale_3);
            app.RegisterCLRFieldSetter(field, set_otherInverseInertiaScale_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_otherInverseInertiaScale_3, AssignFromStack_otherInverseInertiaScale_3);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ModifiableMassProperties());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ModifiableMassProperties[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.ModifiableMassProperties instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ModifiableMassProperties[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_inverseMassScale_0(ref object o)
        {
            return ((UnityEngine.ModifiableMassProperties)o).inverseMassScale;
        }

        static StackObject* CopyToStack_inverseMassScale_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.ModifiableMassProperties)o).inverseMassScale;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_inverseMassScale_0(ref object o, object v)
        {
            UnityEngine.ModifiableMassProperties ins =(UnityEngine.ModifiableMassProperties)o;
            ins.inverseMassScale = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_inverseMassScale_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @inverseMassScale = *(float*)&ptr_of_this_method->Value;
            UnityEngine.ModifiableMassProperties ins =(UnityEngine.ModifiableMassProperties)o;
            ins.inverseMassScale = @inverseMassScale;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_inverseInertiaScale_1(ref object o)
        {
            return ((UnityEngine.ModifiableMassProperties)o).inverseInertiaScale;
        }

        static StackObject* CopyToStack_inverseInertiaScale_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.ModifiableMassProperties)o).inverseInertiaScale;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_inverseInertiaScale_1(ref object o, object v)
        {
            UnityEngine.ModifiableMassProperties ins =(UnityEngine.ModifiableMassProperties)o;
            ins.inverseInertiaScale = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_inverseInertiaScale_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @inverseInertiaScale = *(float*)&ptr_of_this_method->Value;
            UnityEngine.ModifiableMassProperties ins =(UnityEngine.ModifiableMassProperties)o;
            ins.inverseInertiaScale = @inverseInertiaScale;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_otherInverseMassScale_2(ref object o)
        {
            return ((UnityEngine.ModifiableMassProperties)o).otherInverseMassScale;
        }

        static StackObject* CopyToStack_otherInverseMassScale_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.ModifiableMassProperties)o).otherInverseMassScale;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_otherInverseMassScale_2(ref object o, object v)
        {
            UnityEngine.ModifiableMassProperties ins =(UnityEngine.ModifiableMassProperties)o;
            ins.otherInverseMassScale = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_otherInverseMassScale_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @otherInverseMassScale = *(float*)&ptr_of_this_method->Value;
            UnityEngine.ModifiableMassProperties ins =(UnityEngine.ModifiableMassProperties)o;
            ins.otherInverseMassScale = @otherInverseMassScale;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_otherInverseInertiaScale_3(ref object o)
        {
            return ((UnityEngine.ModifiableMassProperties)o).otherInverseInertiaScale;
        }

        static StackObject* CopyToStack_otherInverseInertiaScale_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.ModifiableMassProperties)o).otherInverseInertiaScale;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_otherInverseInertiaScale_3(ref object o, object v)
        {
            UnityEngine.ModifiableMassProperties ins =(UnityEngine.ModifiableMassProperties)o;
            ins.otherInverseInertiaScale = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_otherInverseInertiaScale_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @otherInverseInertiaScale = *(float*)&ptr_of_this_method->Value;
            UnityEngine.ModifiableMassProperties ins =(UnityEngine.ModifiableMassProperties)o;
            ins.otherInverseInertiaScale = @otherInverseInertiaScale;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ModifiableMassProperties();
            ins = (UnityEngine.ModifiableMassProperties)o;
            return ins;
        }


    }
}
