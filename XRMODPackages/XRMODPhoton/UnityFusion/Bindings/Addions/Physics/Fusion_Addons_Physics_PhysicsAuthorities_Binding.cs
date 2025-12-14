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
    unsafe class Fusion_Addons_Physics_PhysicsAuthorities_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field; 
            Type type = typeof(Fusion.Addons.Physics.PhysicsAuthorities);

            field = type.GetField("Auto", flag);
            app.RegisterCLRFieldGetter(field, get_Auto_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Auto_0, null);
            field = type.GetField("Unity", flag);
            app.RegisterCLRFieldGetter(field, get_Unity_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Unity_1, null);
            field = type.GetField("Fusion", flag);
            app.RegisterCLRFieldGetter(field, get_Fusion_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Fusion_2, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.Physics.PhysicsAuthorities());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.Physics.PhysicsAuthorities[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Fusion.Addons.Physics.PhysicsAuthorities instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Fusion.Addons.Physics.PhysicsAuthorities[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Auto_0(ref object o)
        {
            return Fusion.Addons.Physics.PhysicsAuthorities.Auto;
        }

        static StackObject* CopyToStack_Auto_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.Physics.PhysicsAuthorities.Auto;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Unity_1(ref object o)
        {
            return Fusion.Addons.Physics.PhysicsAuthorities.Unity;
        }

        static StackObject* CopyToStack_Unity_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.Physics.PhysicsAuthorities.Unity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Fusion_2(ref object o)
        {
            return Fusion.Addons.Physics.PhysicsAuthorities.Fusion;
        }

        static StackObject* CopyToStack_Fusion_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.Physics.PhysicsAuthorities.Fusion;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Fusion.Addons.Physics.PhysicsAuthorities();
            ins = (Fusion.Addons.Physics.PhysicsAuthorities)o;
            return ins;
        }


    }
}
#endif