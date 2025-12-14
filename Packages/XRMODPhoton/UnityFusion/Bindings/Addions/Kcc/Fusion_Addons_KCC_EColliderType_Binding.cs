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
    unsafe class Fusion_Addons_KCC_EColliderType_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field; 
            Type type = typeof(Fusion.Addons.KCC.EColliderType);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_None_0, null);
            field = type.GetField("Sphere", flag);
            app.RegisterCLRFieldGetter(field, get_Sphere_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Sphere_1, null);
            field = type.GetField("Capsule", flag);
            app.RegisterCLRFieldGetter(field, get_Capsule_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Capsule_2, null);
            field = type.GetField("Box", flag);
            app.RegisterCLRFieldGetter(field, get_Box_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Box_3, null);
            field = type.GetField("Mesh", flag);
            app.RegisterCLRFieldGetter(field, get_Mesh_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Mesh_4, null);
            field = type.GetField("Terrain", flag);
            app.RegisterCLRFieldGetter(field, get_Terrain_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Terrain_5, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.EColliderType());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.EColliderType[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Fusion.Addons.KCC.EColliderType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Fusion.Addons.KCC.EColliderType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return Fusion.Addons.KCC.EColliderType.None;
        }

        static StackObject* CopyToStack_None_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.EColliderType.None;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Sphere_1(ref object o)
        {
            return Fusion.Addons.KCC.EColliderType.Sphere;
        }

        static StackObject* CopyToStack_Sphere_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.EColliderType.Sphere;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Capsule_2(ref object o)
        {
            return Fusion.Addons.KCC.EColliderType.Capsule;
        }

        static StackObject* CopyToStack_Capsule_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.EColliderType.Capsule;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Box_3(ref object o)
        {
            return Fusion.Addons.KCC.EColliderType.Box;
        }

        static StackObject* CopyToStack_Box_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.EColliderType.Box;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Mesh_4(ref object o)
        {
            return Fusion.Addons.KCC.EColliderType.Mesh;
        }

        static StackObject* CopyToStack_Mesh_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.EColliderType.Mesh;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Terrain_5(ref object o)
        {
            return Fusion.Addons.KCC.EColliderType.Terrain;
        }

        static StackObject* CopyToStack_Terrain_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.EColliderType.Terrain;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Fusion.Addons.KCC.EColliderType();
            ins = (Fusion.Addons.KCC.EColliderType)o;
            return ins;
        }


    }
}
#endif