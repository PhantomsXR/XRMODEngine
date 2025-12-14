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
    unsafe class Unity_AI_Navigation_NavMeshSurface_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Unity.AI.Navigation.NavMeshSurface);
            args = new Type[]{};
            method = type.GetMethod("get_agentTypeID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_agentTypeID_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_agentTypeID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_agentTypeID_1);
            args = new Type[]{};
            method = type.GetMethod("get_collectObjects", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_collectObjects_2);
            args = new Type[]{typeof(Unity.AI.Navigation.CollectObjects)};
            method = type.GetMethod("set_collectObjects", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_collectObjects_3);
            args = new Type[]{};
            method = type.GetMethod("get_size", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_size_4);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_size", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_size_5);
            args = new Type[]{};
            method = type.GetMethod("get_center", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_center_6);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_center", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_center_7);
            args = new Type[]{};
            method = type.GetMethod("get_layerMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_layerMask_8);
            args = new Type[]{typeof(UnityEngine.LayerMask)};
            method = type.GetMethod("set_layerMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_layerMask_9);
            args = new Type[]{};
            method = type.GetMethod("get_useGeometry", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useGeometry_10);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshCollectGeometry)};
            method = type.GetMethod("set_useGeometry", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useGeometry_11);
            args = new Type[]{};
            method = type.GetMethod("get_defaultArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultArea_12);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_defaultArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultArea_13);
            args = new Type[]{};
            method = type.GetMethod("get_ignoreNavMeshAgent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ignoreNavMeshAgent_14);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_ignoreNavMeshAgent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ignoreNavMeshAgent_15);
            args = new Type[]{};
            method = type.GetMethod("get_ignoreNavMeshObstacle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ignoreNavMeshObstacle_16);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_ignoreNavMeshObstacle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ignoreNavMeshObstacle_17);
            args = new Type[]{};
            method = type.GetMethod("get_overrideTileSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_overrideTileSize_18);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_overrideTileSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_overrideTileSize_19);
            args = new Type[]{};
            method = type.GetMethod("get_tileSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_tileSize_20);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_tileSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_tileSize_21);
            args = new Type[]{};
            method = type.GetMethod("get_overrideVoxelSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_overrideVoxelSize_22);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_overrideVoxelSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_overrideVoxelSize_23);
            args = new Type[]{};
            method = type.GetMethod("get_voxelSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_voxelSize_24);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_voxelSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_voxelSize_25);
            args = new Type[]{};
            method = type.GetMethod("get_minRegionArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_minRegionArea_26);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_minRegionArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_minRegionArea_27);
            args = new Type[]{};
            method = type.GetMethod("get_buildHeightMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_buildHeightMesh_28);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_buildHeightMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_buildHeightMesh_29);
            args = new Type[]{};
            method = type.GetMethod("get_navMeshData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_navMeshData_30);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshData)};
            method = type.GetMethod("set_navMeshData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_navMeshData_31);
            args = new Type[]{};
            method = type.GetMethod("get_activeSurfaces", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeSurfaces_32);
            args = new Type[]{};
            method = type.GetMethod("AddData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddData_33);
            args = new Type[]{};
            method = type.GetMethod("RemoveData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveData_34);
            args = new Type[]{};
            method = type.GetMethod("GetBuildSettings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBuildSettings_35);
            args = new Type[]{};
            method = type.GetMethod("BuildNavMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BuildNavMesh_36);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshData)};
            method = type.GetMethod("UpdateNavMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateNavMesh_37);



            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.AI.Navigation.NavMeshSurface());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.AI.Navigation.NavMeshSurface[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_agentTypeID_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.agentTypeID;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_agentTypeID_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.agentTypeID = value;

            return __ret;
        }

        static StackObject* get_collectObjects_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.collectObjects;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_collectObjects_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.CollectObjects @value = (Unity.AI.Navigation.CollectObjects)typeof(Unity.AI.Navigation.CollectObjects).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.collectObjects = value;

            return __ret;
        }

        static StackObject* get_size_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.size;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_size_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.size = value;

            return __ret;
        }

        static StackObject* get_center_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.center;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_center_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.center = value;

            return __ret;
        }

        static StackObject* get_layerMask_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.layerMask;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_layerMask_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LayerMask @value = (UnityEngine.LayerMask)typeof(UnityEngine.LayerMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.layerMask = value;

            return __ret;
        }

        static StackObject* get_useGeometry_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useGeometry;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_useGeometry_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshCollectGeometry @value = (UnityEngine.AI.NavMeshCollectGeometry)typeof(UnityEngine.AI.NavMeshCollectGeometry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useGeometry = value;

            return __ret;
        }

        static StackObject* get_defaultArea_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.defaultArea;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_defaultArea_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.defaultArea = value;

            return __ret;
        }

        static StackObject* get_ignoreNavMeshAgent_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ignoreNavMeshAgent;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_ignoreNavMeshAgent_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ignoreNavMeshAgent = value;

            return __ret;
        }

        static StackObject* get_ignoreNavMeshObstacle_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ignoreNavMeshObstacle;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_ignoreNavMeshObstacle_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ignoreNavMeshObstacle = value;

            return __ret;
        }

        static StackObject* get_overrideTileSize_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.overrideTileSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_overrideTileSize_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.overrideTileSize = value;

            return __ret;
        }

        static StackObject* get_tileSize_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.tileSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_tileSize_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.tileSize = value;

            return __ret;
        }

        static StackObject* get_overrideVoxelSize_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.overrideVoxelSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_overrideVoxelSize_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.overrideVoxelSize = value;

            return __ret;
        }

        static StackObject* get_voxelSize_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.voxelSize;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_voxelSize_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.voxelSize = value;

            return __ret;
        }

        static StackObject* get_minRegionArea_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.minRegionArea;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_minRegionArea_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.minRegionArea = value;

            return __ret;
        }

        static StackObject* get_buildHeightMesh_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.buildHeightMesh;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_buildHeightMesh_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.buildHeightMesh = value;

            return __ret;
        }

        static StackObject* get_navMeshData_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.navMeshData;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_navMeshData_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshData @value = (UnityEngine.AI.NavMeshData)typeof(UnityEngine.AI.NavMeshData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.navMeshData = value;

            return __ret;
        }

        static StackObject* get_activeSurfaces_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Unity.AI.Navigation.NavMeshSurface.activeSurfaces;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AddData_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddData();

            return __ret;
        }

        static StackObject* RemoveData_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveData();

            return __ret;
        }

        static StackObject* GetBuildSettings_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetBuildSettings();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BuildNavMesh_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.BuildNavMesh();

            return __ret;
        }

        static StackObject* UpdateNavMesh_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshData @data = (UnityEngine.AI.NavMeshData)typeof(UnityEngine.AI.NavMeshData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshSurface instance_of_this_method = (Unity.AI.Navigation.NavMeshSurface)typeof(Unity.AI.Navigation.NavMeshSurface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.UpdateNavMesh(@data);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.AI.Navigation.NavMeshSurface();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
