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
    unsafe class UnityEngine_AI_NavMeshBuilder_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.AI.NavMeshBuilder);
            args = new Type[]{typeof(UnityEngine.Bounds), typeof(System.Int32), typeof(UnityEngine.AI.NavMeshCollectGeometry), typeof(System.Int32), typeof(System.Boolean), typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>), typeof(System.Boolean), typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)};
            method = type.GetMethod("CollectSources", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CollectSources_0);
            args = new Type[]{typeof(UnityEngine.Bounds), typeof(System.Int32), typeof(UnityEngine.AI.NavMeshCollectGeometry), typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>), typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)};
            method = type.GetMethod("CollectSources", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CollectSources_1);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Int32), typeof(UnityEngine.AI.NavMeshCollectGeometry), typeof(System.Int32), typeof(System.Boolean), typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>), typeof(System.Boolean), typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)};
            method = type.GetMethod("CollectSources", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CollectSources_2);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Int32), typeof(UnityEngine.AI.NavMeshCollectGeometry), typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>), typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)};
            method = type.GetMethod("CollectSources", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CollectSources_3);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshBuildSettings), typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>), typeof(UnityEngine.Bounds), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("BuildNavMeshData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BuildNavMeshData_4);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshData), typeof(UnityEngine.AI.NavMeshBuildSettings), typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>), typeof(UnityEngine.Bounds)};
            method = type.GetMethod("UpdateNavMeshData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateNavMeshData_5);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshData), typeof(UnityEngine.AI.NavMeshBuildSettings), typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>), typeof(UnityEngine.Bounds)};
            method = type.GetMethod("UpdateNavMeshDataAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateNavMeshDataAsync_6);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshData)};
            method = type.GetMethod("Cancel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Cancel_7);





        }


        static StackObject* CollectSources_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> @results = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @includeOnlyMarkedObjects = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> @markups = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>)typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @generateLinksByDefault = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @defaultArea = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.AI.NavMeshCollectGeometry @geometry = (UnityEngine.AI.NavMeshCollectGeometry)typeof(UnityEngine.AI.NavMeshCollectGeometry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @includedLayerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Bounds @includedWorldBounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.AI.NavMeshBuilder.CollectSources(@includedWorldBounds, @includedLayerMask, @geometry, @defaultArea, @generateLinksByDefault, @markups, @includeOnlyMarkedObjects, @results);

            return __ret;
        }

        static StackObject* CollectSources_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> @results = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> @markups = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>)typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @defaultArea = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.AI.NavMeshCollectGeometry @geometry = (UnityEngine.AI.NavMeshCollectGeometry)typeof(UnityEngine.AI.NavMeshCollectGeometry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @includedLayerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Bounds @includedWorldBounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.AI.NavMeshBuilder.CollectSources(@includedWorldBounds, @includedLayerMask, @geometry, @defaultArea, @markups, @results);

            return __ret;
        }

        static StackObject* CollectSources_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> @results = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @includeOnlyMarkedObjects = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> @markups = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>)typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @generateLinksByDefault = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @defaultArea = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.AI.NavMeshCollectGeometry @geometry = (UnityEngine.AI.NavMeshCollectGeometry)typeof(UnityEngine.AI.NavMeshCollectGeometry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @includedLayerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Transform @root = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.AI.NavMeshBuilder.CollectSources(@root, @includedLayerMask, @geometry, @defaultArea, @generateLinksByDefault, @markups, @includeOnlyMarkedObjects, @results);

            return __ret;
        }

        static StackObject* CollectSources_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> @results = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> @markups = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>)typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @defaultArea = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.AI.NavMeshCollectGeometry @geometry = (UnityEngine.AI.NavMeshCollectGeometry)typeof(UnityEngine.AI.NavMeshCollectGeometry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @includedLayerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Transform @root = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.AI.NavMeshBuilder.CollectSources(@root, @includedLayerMask, @geometry, @defaultArea, @markups, @results);

            return __ret;
        }

        static StackObject* BuildNavMeshData_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Bounds @localBounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> @sources = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.AI.NavMeshBuildSettings @buildSettings = (UnityEngine.AI.NavMeshBuildSettings)typeof(UnityEngine.AI.NavMeshBuildSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.AI.NavMeshBuilder.BuildNavMeshData(@buildSettings, @sources, @localBounds, @position, @rotation);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* UpdateNavMeshData_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Bounds @localBounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> @sources = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AI.NavMeshBuildSettings @buildSettings = (UnityEngine.AI.NavMeshBuildSettings)typeof(UnityEngine.AI.NavMeshBuildSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.AI.NavMeshData @data = (UnityEngine.AI.NavMeshData)typeof(UnityEngine.AI.NavMeshData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.AI.NavMeshBuilder.UpdateNavMeshData(@data, @buildSettings, @sources, @localBounds);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* UpdateNavMeshDataAsync_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Bounds @localBounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> @sources = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AI.NavMeshBuildSettings @buildSettings = (UnityEngine.AI.NavMeshBuildSettings)typeof(UnityEngine.AI.NavMeshBuildSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.AI.NavMeshData @data = (UnityEngine.AI.NavMeshData)typeof(UnityEngine.AI.NavMeshData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.AI.NavMeshBuilder.UpdateNavMeshDataAsync(@data, @buildSettings, @sources, @localBounds);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Cancel_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshData @data = (UnityEngine.AI.NavMeshData)typeof(UnityEngine.AI.NavMeshData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.AI.NavMeshBuilder.Cancel(@data);

            return __ret;
        }





    }
}
