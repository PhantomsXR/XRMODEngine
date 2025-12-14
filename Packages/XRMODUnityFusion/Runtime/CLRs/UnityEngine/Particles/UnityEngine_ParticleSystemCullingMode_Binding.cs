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
    unsafe class UnityEngine_ParticleSystemCullingMode_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ParticleSystemCullingMode);

            field = type.GetField("Automatic", flag);
            app.RegisterCLRFieldGetter(field, get_Automatic_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Automatic_0, null);
            field = type.GetField("PauseAndCatchup", flag);
            app.RegisterCLRFieldGetter(field, get_PauseAndCatchup_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_PauseAndCatchup_1, null);
            field = type.GetField("Pause", flag);
            app.RegisterCLRFieldGetter(field, get_Pause_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Pause_2, null);
            field = type.GetField("AlwaysSimulate", flag);
            app.RegisterCLRFieldGetter(field, get_AlwaysSimulate_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_AlwaysSimulate_3, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ParticleSystemCullingMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ParticleSystemCullingMode[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.ParticleSystemCullingMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ParticleSystemCullingMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Automatic_0(ref object o)
        {
            return UnityEngine.ParticleSystemCullingMode.Automatic;
        }

        static StackObject* CopyToStack_Automatic_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemCullingMode.Automatic;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_PauseAndCatchup_1(ref object o)
        {
            return UnityEngine.ParticleSystemCullingMode.PauseAndCatchup;
        }

        static StackObject* CopyToStack_PauseAndCatchup_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemCullingMode.PauseAndCatchup;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Pause_2(ref object o)
        {
            return UnityEngine.ParticleSystemCullingMode.Pause;
        }

        static StackObject* CopyToStack_Pause_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemCullingMode.Pause;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_AlwaysSimulate_3(ref object o)
        {
            return UnityEngine.ParticleSystemCullingMode.AlwaysSimulate;
        }

        static StackObject* CopyToStack_AlwaysSimulate_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemCullingMode.AlwaysSimulate;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ParticleSystemCullingMode();
            ins = (UnityEngine.ParticleSystemCullingMode)o;
            return ins;
        }


    }
}
