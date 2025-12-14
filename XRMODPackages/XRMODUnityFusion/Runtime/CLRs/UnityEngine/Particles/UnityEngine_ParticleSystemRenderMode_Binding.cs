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
    unsafe class UnityEngine_ParticleSystemRenderMode_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ParticleSystemRenderMode);

            field = type.GetField("Billboard", flag);
            app.RegisterCLRFieldGetter(field, get_Billboard_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Billboard_0, null);
            field = type.GetField("Stretch", flag);
            app.RegisterCLRFieldGetter(field, get_Stretch_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Stretch_1, null);
            field = type.GetField("HorizontalBillboard", flag);
            app.RegisterCLRFieldGetter(field, get_HorizontalBillboard_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_HorizontalBillboard_2, null);
            field = type.GetField("VerticalBillboard", flag);
            app.RegisterCLRFieldGetter(field, get_VerticalBillboard_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_VerticalBillboard_3, null);
            field = type.GetField("Mesh", flag);
            app.RegisterCLRFieldGetter(field, get_Mesh_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Mesh_4, null);
            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_None_5, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ParticleSystemRenderMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ParticleSystemRenderMode[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.ParticleSystemRenderMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ParticleSystemRenderMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Billboard_0(ref object o)
        {
            return UnityEngine.ParticleSystemRenderMode.Billboard;
        }

        static StackObject* CopyToStack_Billboard_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemRenderMode.Billboard;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Stretch_1(ref object o)
        {
            return UnityEngine.ParticleSystemRenderMode.Stretch;
        }

        static StackObject* CopyToStack_Stretch_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemRenderMode.Stretch;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_HorizontalBillboard_2(ref object o)
        {
            return UnityEngine.ParticleSystemRenderMode.HorizontalBillboard;
        }

        static StackObject* CopyToStack_HorizontalBillboard_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemRenderMode.HorizontalBillboard;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_VerticalBillboard_3(ref object o)
        {
            return UnityEngine.ParticleSystemRenderMode.VerticalBillboard;
        }

        static StackObject* CopyToStack_VerticalBillboard_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemRenderMode.VerticalBillboard;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Mesh_4(ref object o)
        {
            return UnityEngine.ParticleSystemRenderMode.Mesh;
        }

        static StackObject* CopyToStack_Mesh_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemRenderMode.Mesh;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_None_5(ref object o)
        {
            return UnityEngine.ParticleSystemRenderMode.None;
        }

        static StackObject* CopyToStack_None_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemRenderMode.None;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ParticleSystemRenderMode();
            ins = (UnityEngine.ParticleSystemRenderMode)o;
            return ins;
        }


    }
}
