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
    unsafe class UnityEngine_ParticleSystemColliderQueryMode_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ParticleSystemColliderQueryMode);

            field = type.GetField("Disabled", flag);
            app.RegisterCLRFieldGetter(field, get_Disabled_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Disabled_0, null);
            field = type.GetField("One", flag);
            app.RegisterCLRFieldGetter(field, get_One_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_One_1, null);
            field = type.GetField("All", flag);
            app.RegisterCLRFieldGetter(field, get_All_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_All_2, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ParticleSystemColliderQueryMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ParticleSystemColliderQueryMode[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.ParticleSystemColliderQueryMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ParticleSystemColliderQueryMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Disabled_0(ref object o)
        {
            return UnityEngine.ParticleSystemColliderQueryMode.Disabled;
        }

        static StackObject* CopyToStack_Disabled_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemColliderQueryMode.Disabled;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_One_1(ref object o)
        {
            return UnityEngine.ParticleSystemColliderQueryMode.One;
        }

        static StackObject* CopyToStack_One_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemColliderQueryMode.One;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_All_2(ref object o)
        {
            return UnityEngine.ParticleSystemColliderQueryMode.All;
        }

        static StackObject* CopyToStack_All_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemColliderQueryMode.All;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ParticleSystemColliderQueryMode();
            ins = (UnityEngine.ParticleSystemColliderQueryMode)o;
            return ins;
        }


    }
}
