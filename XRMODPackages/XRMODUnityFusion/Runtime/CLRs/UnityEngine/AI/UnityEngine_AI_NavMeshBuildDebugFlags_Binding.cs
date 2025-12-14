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
    unsafe class UnityEngine_AI_NavMeshBuildDebugFlags_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.AI.NavMeshBuildDebugFlags);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_None_0, null);
            field = type.GetField("InputGeometry", flag);
            app.RegisterCLRFieldGetter(field, get_InputGeometry_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_InputGeometry_1, null);
            field = type.GetField("Voxels", flag);
            app.RegisterCLRFieldGetter(field, get_Voxels_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Voxels_2, null);
            field = type.GetField("Regions", flag);
            app.RegisterCLRFieldGetter(field, get_Regions_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Regions_3, null);
            field = type.GetField("RawContours", flag);
            app.RegisterCLRFieldGetter(field, get_RawContours_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_RawContours_4, null);
            field = type.GetField("SimplifiedContours", flag);
            app.RegisterCLRFieldGetter(field, get_SimplifiedContours_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_SimplifiedContours_5, null);
            field = type.GetField("PolygonMeshes", flag);
            app.RegisterCLRFieldGetter(field, get_PolygonMeshes_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_PolygonMeshes_6, null);
            field = type.GetField("PolygonMeshesDetail", flag);
            app.RegisterCLRFieldGetter(field, get_PolygonMeshesDetail_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_PolygonMeshesDetail_7, null);
            field = type.GetField("All", flag);
            app.RegisterCLRFieldGetter(field, get_All_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_All_8, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AI.NavMeshBuildDebugFlags());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AI.NavMeshBuildDebugFlags[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.AI.NavMeshBuildDebugFlags instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AI.NavMeshBuildDebugFlags[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.AI.NavMeshBuildDebugFlags.None;
        }

        static StackObject* CopyToStack_None_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.AI.NavMeshBuildDebugFlags.None;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_InputGeometry_1(ref object o)
        {
            return UnityEngine.AI.NavMeshBuildDebugFlags.InputGeometry;
        }

        static StackObject* CopyToStack_InputGeometry_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.AI.NavMeshBuildDebugFlags.InputGeometry;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Voxels_2(ref object o)
        {
            return UnityEngine.AI.NavMeshBuildDebugFlags.Voxels;
        }

        static StackObject* CopyToStack_Voxels_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.AI.NavMeshBuildDebugFlags.Voxels;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Regions_3(ref object o)
        {
            return UnityEngine.AI.NavMeshBuildDebugFlags.Regions;
        }

        static StackObject* CopyToStack_Regions_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.AI.NavMeshBuildDebugFlags.Regions;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RawContours_4(ref object o)
        {
            return UnityEngine.AI.NavMeshBuildDebugFlags.RawContours;
        }

        static StackObject* CopyToStack_RawContours_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.AI.NavMeshBuildDebugFlags.RawContours;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SimplifiedContours_5(ref object o)
        {
            return UnityEngine.AI.NavMeshBuildDebugFlags.SimplifiedContours;
        }

        static StackObject* CopyToStack_SimplifiedContours_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.AI.NavMeshBuildDebugFlags.SimplifiedContours;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_PolygonMeshes_6(ref object o)
        {
            return UnityEngine.AI.NavMeshBuildDebugFlags.PolygonMeshes;
        }

        static StackObject* CopyToStack_PolygonMeshes_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.AI.NavMeshBuildDebugFlags.PolygonMeshes;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_PolygonMeshesDetail_7(ref object o)
        {
            return UnityEngine.AI.NavMeshBuildDebugFlags.PolygonMeshesDetail;
        }

        static StackObject* CopyToStack_PolygonMeshesDetail_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.AI.NavMeshBuildDebugFlags.PolygonMeshesDetail;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_All_8(ref object o)
        {
            return UnityEngine.AI.NavMeshBuildDebugFlags.All;
        }

        static StackObject* CopyToStack_All_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.AI.NavMeshBuildDebugFlags.All;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.AI.NavMeshBuildDebugFlags();
            ins = (UnityEngine.AI.NavMeshBuildDebugFlags)o;
            return ins;
        }


    }
}
