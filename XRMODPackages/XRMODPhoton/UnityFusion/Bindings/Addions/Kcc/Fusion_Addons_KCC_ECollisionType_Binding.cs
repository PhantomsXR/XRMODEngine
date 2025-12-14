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
    unsafe class Fusion_Addons_KCC_ECollisionType_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field; 
            Type type = typeof(Fusion.Addons.KCC.ECollisionType);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_None_0, null);
            field = type.GetField("Ground", flag);
            app.RegisterCLRFieldGetter(field, get_Ground_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Ground_1, null);
            field = type.GetField("Slope", flag);
            app.RegisterCLRFieldGetter(field, get_Slope_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Slope_2, null);
            field = type.GetField("Wall", flag);
            app.RegisterCLRFieldGetter(field, get_Wall_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Wall_3, null);
            field = type.GetField("Hang", flag);
            app.RegisterCLRFieldGetter(field, get_Hang_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Hang_4, null);
            field = type.GetField("Top", flag);
            app.RegisterCLRFieldGetter(field, get_Top_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Top_5, null);
            field = type.GetField("Trigger", flag);
            app.RegisterCLRFieldGetter(field, get_Trigger_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_Trigger_6, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.ECollisionType());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.ECollisionType[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Fusion.Addons.KCC.ECollisionType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Fusion.Addons.KCC.ECollisionType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return Fusion.Addons.KCC.ECollisionType.None;
        }

        static StackObject* CopyToStack_None_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.ECollisionType.None;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Ground_1(ref object o)
        {
            return Fusion.Addons.KCC.ECollisionType.Ground;
        }

        static StackObject* CopyToStack_Ground_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.ECollisionType.Ground;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Slope_2(ref object o)
        {
            return Fusion.Addons.KCC.ECollisionType.Slope;
        }

        static StackObject* CopyToStack_Slope_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.ECollisionType.Slope;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Wall_3(ref object o)
        {
            return Fusion.Addons.KCC.ECollisionType.Wall;
        }

        static StackObject* CopyToStack_Wall_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.ECollisionType.Wall;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Hang_4(ref object o)
        {
            return Fusion.Addons.KCC.ECollisionType.Hang;
        }

        static StackObject* CopyToStack_Hang_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.ECollisionType.Hang;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Top_5(ref object o)
        {
            return Fusion.Addons.KCC.ECollisionType.Top;
        }

        static StackObject* CopyToStack_Top_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.ECollisionType.Top;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Trigger_6(ref object o)
        {
            return Fusion.Addons.KCC.ECollisionType.Trigger;
        }

        static StackObject* CopyToStack_Trigger_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.ECollisionType.Trigger;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Fusion.Addons.KCC.ECollisionType();
            ins = (Fusion.Addons.KCC.ECollisionType)o;
            return ins;
        }


    }
}
#endif
