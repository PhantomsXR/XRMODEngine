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
    unsafe class UnityEngine_MeshColliderCookingOptions_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.MeshColliderCookingOptions);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_None_0, null);
            field = type.GetField("CookForFasterSimulation", flag);
            app.RegisterCLRFieldGetter(field, get_CookForFasterSimulation_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_CookForFasterSimulation_1, null);
            field = type.GetField("EnableMeshCleaning", flag);
            app.RegisterCLRFieldGetter(field, get_EnableMeshCleaning_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_EnableMeshCleaning_2, null);
            field = type.GetField("WeldColocatedVertices", flag);
            app.RegisterCLRFieldGetter(field, get_WeldColocatedVertices_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_WeldColocatedVertices_3, null);
            field = type.GetField("UseFastMidphase", flag);
            app.RegisterCLRFieldGetter(field, get_UseFastMidphase_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_UseFastMidphase_4, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.MeshColliderCookingOptions());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.MeshColliderCookingOptions[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.MeshColliderCookingOptions instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.MeshColliderCookingOptions[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.MeshColliderCookingOptions.None;
        }

        static StackObject* CopyToStack_None_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.MeshColliderCookingOptions.None;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CookForFasterSimulation_1(ref object o)
        {
            return UnityEngine.MeshColliderCookingOptions.CookForFasterSimulation;
        }

        static StackObject* CopyToStack_CookForFasterSimulation_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.MeshColliderCookingOptions.CookForFasterSimulation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_EnableMeshCleaning_2(ref object o)
        {
            return UnityEngine.MeshColliderCookingOptions.EnableMeshCleaning;
        }

        static StackObject* CopyToStack_EnableMeshCleaning_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.MeshColliderCookingOptions.EnableMeshCleaning;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_WeldColocatedVertices_3(ref object o)
        {
            return UnityEngine.MeshColliderCookingOptions.WeldColocatedVertices;
        }

        static StackObject* CopyToStack_WeldColocatedVertices_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.MeshColliderCookingOptions.WeldColocatedVertices;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_UseFastMidphase_4(ref object o)
        {
            return UnityEngine.MeshColliderCookingOptions.UseFastMidphase;
        }

        static StackObject* CopyToStack_UseFastMidphase_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.MeshColliderCookingOptions.UseFastMidphase;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.MeshColliderCookingOptions();
            ins = (UnityEngine.MeshColliderCookingOptions)o;
            return ins;
        }


    }
}
