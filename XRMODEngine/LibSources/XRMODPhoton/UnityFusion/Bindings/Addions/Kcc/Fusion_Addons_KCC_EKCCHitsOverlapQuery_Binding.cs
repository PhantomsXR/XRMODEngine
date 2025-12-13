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
    unsafe class Fusion_Addons_KCC_EKCCHitsOverlapQuery_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field; 
            Type type = typeof(Fusion.Addons.KCC.EKCCHitsOverlapQuery);

            field = type.GetField("Default", flag);
            app.RegisterCLRFieldGetter(field, get_Default_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Default_0, null);
            field = type.GetField("Reuse", flag);
            app.RegisterCLRFieldGetter(field, get_Reuse_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Reuse_1, null);
            field = type.GetField("New", flag);
            app.RegisterCLRFieldGetter(field, get_New_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_New_2, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.EKCCHitsOverlapQuery());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.EKCCHitsOverlapQuery[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Fusion.Addons.KCC.EKCCHitsOverlapQuery instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Fusion.Addons.KCC.EKCCHitsOverlapQuery[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Default_0(ref object o)
        {
            return Fusion.Addons.KCC.EKCCHitsOverlapQuery.Default;
        }

        static StackObject* CopyToStack_Default_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.EKCCHitsOverlapQuery.Default;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Reuse_1(ref object o)
        {
            return Fusion.Addons.KCC.EKCCHitsOverlapQuery.Reuse;
        }

        static StackObject* CopyToStack_Reuse_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.EKCCHitsOverlapQuery.Reuse;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_New_2(ref object o)
        {
            return Fusion.Addons.KCC.EKCCHitsOverlapQuery.New;
        }

        static StackObject* CopyToStack_New_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.EKCCHitsOverlapQuery.New;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Fusion.Addons.KCC.EKCCHitsOverlapQuery();
            ins = (Fusion.Addons.KCC.EKCCHitsOverlapQuery)o;
            return ins;
        }


    }
}
#endif