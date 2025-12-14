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
    unsafe class LeanProp_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::LeanProp);

            field = type.GetField("position", flag);
            app.RegisterCLRFieldGetter(field, get_position_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_position_0, null);
            field = type.GetField("localPosition", flag);
            app.RegisterCLRFieldGetter(field, get_localPosition_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_localPosition_1, null);
            field = type.GetField("x", flag);
            app.RegisterCLRFieldGetter(field, get_x_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_x_2, null);
            field = type.GetField("y", flag);
            app.RegisterCLRFieldGetter(field, get_y_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_y_3, null);
            field = type.GetField("z", flag);
            app.RegisterCLRFieldGetter(field, get_z_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_z_4, null);
            field = type.GetField("localX", flag);
            app.RegisterCLRFieldGetter(field, get_localX_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_localX_5, null);
            field = type.GetField("localY", flag);
            app.RegisterCLRFieldGetter(field, get_localY_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_localY_6, null);
            field = type.GetField("localZ", flag);
            app.RegisterCLRFieldGetter(field, get_localZ_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_localZ_7, null);
            field = type.GetField("scale", flag);
            app.RegisterCLRFieldGetter(field, get_scale_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_scale_8, null);
            field = type.GetField("color", flag);
            app.RegisterCLRFieldGetter(field, get_color_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_color_9, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new global::LeanProp());
            app.RegisterCLRCreateArrayInstance(type, s => new global::LeanProp[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref global::LeanProp instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as global::LeanProp[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_position_0(ref object o)
        {
            return global::LeanProp.position;
        }

        static StackObject* CopyToStack_position_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanProp.position;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_localPosition_1(ref object o)
        {
            return global::LeanProp.localPosition;
        }

        static StackObject* CopyToStack_localPosition_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanProp.localPosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_x_2(ref object o)
        {
            return global::LeanProp.x;
        }

        static StackObject* CopyToStack_x_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanProp.x;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_y_3(ref object o)
        {
            return global::LeanProp.y;
        }

        static StackObject* CopyToStack_y_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanProp.y;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_z_4(ref object o)
        {
            return global::LeanProp.z;
        }

        static StackObject* CopyToStack_z_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanProp.z;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_localX_5(ref object o)
        {
            return global::LeanProp.localX;
        }

        static StackObject* CopyToStack_localX_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanProp.localX;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_localY_6(ref object o)
        {
            return global::LeanProp.localY;
        }

        static StackObject* CopyToStack_localY_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanProp.localY;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_localZ_7(ref object o)
        {
            return global::LeanProp.localZ;
        }

        static StackObject* CopyToStack_localZ_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanProp.localZ;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_scale_8(ref object o)
        {
            return global::LeanProp.scale;
        }

        static StackObject* CopyToStack_scale_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanProp.scale;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_color_9(ref object o)
        {
            return global::LeanProp.color;
        }

        static StackObject* CopyToStack_color_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanProp.color;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new global::LeanProp();
            ins = (global::LeanProp)o;
            return ins;
        }


    }
}
