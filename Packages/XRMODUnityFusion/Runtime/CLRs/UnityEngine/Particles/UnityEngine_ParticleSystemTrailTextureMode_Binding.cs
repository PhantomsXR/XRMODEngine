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
    unsafe class UnityEngine_ParticleSystemTrailTextureMode_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ParticleSystemTrailTextureMode);

            field = type.GetField("Stretch", flag);
            app.RegisterCLRFieldGetter(field, get_Stretch_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Stretch_0, null);
            field = type.GetField("Tile", flag);
            app.RegisterCLRFieldGetter(field, get_Tile_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Tile_1, null);
            field = type.GetField("DistributePerSegment", flag);
            app.RegisterCLRFieldGetter(field, get_DistributePerSegment_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_DistributePerSegment_2, null);
            field = type.GetField("RepeatPerSegment", flag);
            app.RegisterCLRFieldGetter(field, get_RepeatPerSegment_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_RepeatPerSegment_3, null);
            field = type.GetField("Static", flag);
            app.RegisterCLRFieldGetter(field, get_Static_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Static_4, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ParticleSystemTrailTextureMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ParticleSystemTrailTextureMode[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.ParticleSystemTrailTextureMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ParticleSystemTrailTextureMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Stretch_0(ref object o)
        {
            return UnityEngine.ParticleSystemTrailTextureMode.Stretch;
        }

        static StackObject* CopyToStack_Stretch_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemTrailTextureMode.Stretch;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Tile_1(ref object o)
        {
            return UnityEngine.ParticleSystemTrailTextureMode.Tile;
        }

        static StackObject* CopyToStack_Tile_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemTrailTextureMode.Tile;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_DistributePerSegment_2(ref object o)
        {
            return UnityEngine.ParticleSystemTrailTextureMode.DistributePerSegment;
        }

        static StackObject* CopyToStack_DistributePerSegment_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemTrailTextureMode.DistributePerSegment;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RepeatPerSegment_3(ref object o)
        {
            return UnityEngine.ParticleSystemTrailTextureMode.RepeatPerSegment;
        }

        static StackObject* CopyToStack_RepeatPerSegment_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemTrailTextureMode.RepeatPerSegment;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Static_4(ref object o)
        {
            return UnityEngine.ParticleSystemTrailTextureMode.Static;
        }

        static StackObject* CopyToStack_Static_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemTrailTextureMode.Static;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ParticleSystemTrailTextureMode();
            ins = (UnityEngine.ParticleSystemTrailTextureMode)o;
            return ins;
        }


    }
}
