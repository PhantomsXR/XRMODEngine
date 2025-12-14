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
    unsafe class UnityEngine_PhysicsShapeType2D_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.PhysicsShapeType2D);

            field = type.GetField("Circle", flag);
            app.RegisterCLRFieldGetter(field, get_Circle_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Circle_0, null);
            field = type.GetField("Capsule", flag);
            app.RegisterCLRFieldGetter(field, get_Capsule_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Capsule_1, null);
            field = type.GetField("Polygon", flag);
            app.RegisterCLRFieldGetter(field, get_Polygon_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Polygon_2, null);
            field = type.GetField("Edges", flag);
            app.RegisterCLRFieldGetter(field, get_Edges_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Edges_3, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.PhysicsShapeType2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.PhysicsShapeType2D[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.PhysicsShapeType2D instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.PhysicsShapeType2D[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Circle_0(ref object o)
        {
            return UnityEngine.PhysicsShapeType2D.Circle;
        }

        static StackObject* CopyToStack_Circle_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.PhysicsShapeType2D.Circle;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Capsule_1(ref object o)
        {
            return UnityEngine.PhysicsShapeType2D.Capsule;
        }

        static StackObject* CopyToStack_Capsule_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.PhysicsShapeType2D.Capsule;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Polygon_2(ref object o)
        {
            return UnityEngine.PhysicsShapeType2D.Polygon;
        }

        static StackObject* CopyToStack_Polygon_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.PhysicsShapeType2D.Polygon;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Edges_3(ref object o)
        {
            return UnityEngine.PhysicsShapeType2D.Edges;
        }

        static StackObject* CopyToStack_Edges_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.PhysicsShapeType2D.Edges;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.PhysicsShapeType2D();
            ins = (UnityEngine.PhysicsShapeType2D)o;
            return ins;
        }


    }
}
