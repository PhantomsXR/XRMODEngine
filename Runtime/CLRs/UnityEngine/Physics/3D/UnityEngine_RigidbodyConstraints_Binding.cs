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
    unsafe class UnityEngine_RigidbodyConstraints_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.RigidbodyConstraints);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_None_0, null);
            field = type.GetField("FreezePositionX", flag);
            app.RegisterCLRFieldGetter(field, get_FreezePositionX_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_FreezePositionX_1, null);
            field = type.GetField("FreezePositionY", flag);
            app.RegisterCLRFieldGetter(field, get_FreezePositionY_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_FreezePositionY_2, null);
            field = type.GetField("FreezePositionZ", flag);
            app.RegisterCLRFieldGetter(field, get_FreezePositionZ_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_FreezePositionZ_3, null);
            field = type.GetField("FreezeRotationX", flag);
            app.RegisterCLRFieldGetter(field, get_FreezeRotationX_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_FreezeRotationX_4, null);
            field = type.GetField("FreezeRotationY", flag);
            app.RegisterCLRFieldGetter(field, get_FreezeRotationY_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_FreezeRotationY_5, null);
            field = type.GetField("FreezeRotationZ", flag);
            app.RegisterCLRFieldGetter(field, get_FreezeRotationZ_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_FreezeRotationZ_6, null);
            field = type.GetField("FreezePosition", flag);
            app.RegisterCLRFieldGetter(field, get_FreezePosition_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_FreezePosition_7, null);
            field = type.GetField("FreezeRotation", flag);
            app.RegisterCLRFieldGetter(field, get_FreezeRotation_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_FreezeRotation_8, null);
            field = type.GetField("FreezeAll", flag);
            app.RegisterCLRFieldGetter(field, get_FreezeAll_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_FreezeAll_9, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.RigidbodyConstraints());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.RigidbodyConstraints[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.RigidbodyConstraints instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RigidbodyConstraints[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.RigidbodyConstraints.None;
        }

        static StackObject* CopyToStack_None_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.RigidbodyConstraints.None;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_FreezePositionX_1(ref object o)
        {
            return UnityEngine.RigidbodyConstraints.FreezePositionX;
        }

        static StackObject* CopyToStack_FreezePositionX_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.RigidbodyConstraints.FreezePositionX;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_FreezePositionY_2(ref object o)
        {
            return UnityEngine.RigidbodyConstraints.FreezePositionY;
        }

        static StackObject* CopyToStack_FreezePositionY_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.RigidbodyConstraints.FreezePositionY;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_FreezePositionZ_3(ref object o)
        {
            return UnityEngine.RigidbodyConstraints.FreezePositionZ;
        }

        static StackObject* CopyToStack_FreezePositionZ_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.RigidbodyConstraints.FreezePositionZ;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_FreezeRotationX_4(ref object o)
        {
            return UnityEngine.RigidbodyConstraints.FreezeRotationX;
        }

        static StackObject* CopyToStack_FreezeRotationX_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.RigidbodyConstraints.FreezeRotationX;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_FreezeRotationY_5(ref object o)
        {
            return UnityEngine.RigidbodyConstraints.FreezeRotationY;
        }

        static StackObject* CopyToStack_FreezeRotationY_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.RigidbodyConstraints.FreezeRotationY;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_FreezeRotationZ_6(ref object o)
        {
            return UnityEngine.RigidbodyConstraints.FreezeRotationZ;
        }

        static StackObject* CopyToStack_FreezeRotationZ_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.RigidbodyConstraints.FreezeRotationZ;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_FreezePosition_7(ref object o)
        {
            return UnityEngine.RigidbodyConstraints.FreezePosition;
        }

        static StackObject* CopyToStack_FreezePosition_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.RigidbodyConstraints.FreezePosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_FreezeRotation_8(ref object o)
        {
            return UnityEngine.RigidbodyConstraints.FreezeRotation;
        }

        static StackObject* CopyToStack_FreezeRotation_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.RigidbodyConstraints.FreezeRotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_FreezeAll_9(ref object o)
        {
            return UnityEngine.RigidbodyConstraints.FreezeAll;
        }

        static StackObject* CopyToStack_FreezeAll_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.RigidbodyConstraints.FreezeAll;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.RigidbodyConstraints();
            ins = (UnityEngine.RigidbodyConstraints)o;
            return ins;
        }


    }
}
