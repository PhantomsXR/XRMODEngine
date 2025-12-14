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
    unsafe class UnityEngine_ParticleSystemSortMode_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ParticleSystemSortMode);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_None_0, null);
            field = type.GetField("Distance", flag);
            app.RegisterCLRFieldGetter(field, get_Distance_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Distance_1, null);
            field = type.GetField("OldestInFront", flag);
            app.RegisterCLRFieldGetter(field, get_OldestInFront_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_OldestInFront_2, null);
            field = type.GetField("YoungestInFront", flag);
            app.RegisterCLRFieldGetter(field, get_YoungestInFront_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_YoungestInFront_3, null);
            field = type.GetField("Depth", flag);
            app.RegisterCLRFieldGetter(field, get_Depth_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Depth_4, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ParticleSystemSortMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ParticleSystemSortMode[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.ParticleSystemSortMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ParticleSystemSortMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.ParticleSystemSortMode.None;
        }

        static StackObject* CopyToStack_None_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemSortMode.None;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Distance_1(ref object o)
        {
            return UnityEngine.ParticleSystemSortMode.Distance;
        }

        static StackObject* CopyToStack_Distance_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemSortMode.Distance;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OldestInFront_2(ref object o)
        {
            return UnityEngine.ParticleSystemSortMode.OldestInFront;
        }

        static StackObject* CopyToStack_OldestInFront_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemSortMode.OldestInFront;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_YoungestInFront_3(ref object o)
        {
            return UnityEngine.ParticleSystemSortMode.YoungestInFront;
        }

        static StackObject* CopyToStack_YoungestInFront_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemSortMode.YoungestInFront;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Depth_4(ref object o)
        {
            return UnityEngine.ParticleSystemSortMode.Depth;
        }

        static StackObject* CopyToStack_Depth_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemSortMode.Depth;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ParticleSystemSortMode();
            ins = (UnityEngine.ParticleSystemSortMode)o;
            return ins;
        }


    }
}
