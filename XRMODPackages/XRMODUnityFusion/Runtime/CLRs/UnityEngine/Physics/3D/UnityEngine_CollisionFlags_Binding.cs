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
    unsafe class UnityEngine_CollisionFlags_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.CollisionFlags);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_None_0, null);
            field = type.GetField("Sides", flag);
            app.RegisterCLRFieldGetter(field, get_Sides_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Sides_1, null);
            field = type.GetField("Above", flag);
            app.RegisterCLRFieldGetter(field, get_Above_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Above_2, null);
            field = type.GetField("Below", flag);
            app.RegisterCLRFieldGetter(field, get_Below_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Below_3, null);
            field = type.GetField("CollidedSides", flag);
            app.RegisterCLRFieldGetter(field, get_CollidedSides_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_CollidedSides_4, null);
            field = type.GetField("CollidedAbove", flag);
            app.RegisterCLRFieldGetter(field, get_CollidedAbove_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_CollidedAbove_5, null);
            field = type.GetField("CollidedBelow", flag);
            app.RegisterCLRFieldGetter(field, get_CollidedBelow_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_CollidedBelow_6, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.CollisionFlags());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.CollisionFlags[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.CollisionFlags instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.CollisionFlags[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.CollisionFlags.None;
        }

        static StackObject* CopyToStack_None_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.CollisionFlags.None;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Sides_1(ref object o)
        {
            return UnityEngine.CollisionFlags.Sides;
        }

        static StackObject* CopyToStack_Sides_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.CollisionFlags.Sides;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Above_2(ref object o)
        {
            return UnityEngine.CollisionFlags.Above;
        }

        static StackObject* CopyToStack_Above_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.CollisionFlags.Above;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Below_3(ref object o)
        {
            return UnityEngine.CollisionFlags.Below;
        }

        static StackObject* CopyToStack_Below_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.CollisionFlags.Below;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CollidedSides_4(ref object o)
        {
            return UnityEngine.CollisionFlags.CollidedSides;
        }

        static StackObject* CopyToStack_CollidedSides_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.CollisionFlags.CollidedSides;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CollidedAbove_5(ref object o)
        {
            return UnityEngine.CollisionFlags.CollidedAbove;
        }

        static StackObject* CopyToStack_CollidedAbove_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.CollisionFlags.CollidedAbove;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CollidedBelow_6(ref object o)
        {
            return UnityEngine.CollisionFlags.CollidedBelow;
        }

        static StackObject* CopyToStack_CollidedBelow_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.CollisionFlags.CollidedBelow;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.CollisionFlags();
            ins = (UnityEngine.CollisionFlags)o;
            return ins;
        }


    }
}
