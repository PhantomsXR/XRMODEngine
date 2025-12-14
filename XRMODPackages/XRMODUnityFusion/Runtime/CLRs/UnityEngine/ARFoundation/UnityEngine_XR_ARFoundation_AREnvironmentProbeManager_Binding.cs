#if USE_ARFOUNDATION
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
    unsafe class UnityEngine_XR_ARFoundation_AREnvironmentProbeManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.ARFoundation.AREnvironmentProbeManager);
            args = new Type[]{};
            method = type.GetMethod("get_automaticPlacementRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_automaticPlacementRequested_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_automaticPlacementRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_automaticPlacementRequested_1);
            args = new Type[]{};
            method = type.GetMethod("get_automaticPlacementEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_automaticPlacementEnabled_2);
            args = new Type[]{};
            method = type.GetMethod("get_environmentTextureFilterMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_environmentTextureFilterMode_3);
            args = new Type[]{typeof(UnityEngine.FilterMode)};
            method = type.GetMethod("set_environmentTextureFilterMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_environmentTextureFilterMode_4);
            args = new Type[]{};
            method = type.GetMethod("get_environmentTextureHDRRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_environmentTextureHDRRequested_5);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_environmentTextureHDRRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_environmentTextureHDRRequested_6);
            args = new Type[]{};
            method = type.GetMethod("get_environmentTextureHDREnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_environmentTextureHDREnabled_7);
            args = new Type[]{};
            method = type.GetMethod("get_debugPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_debugPrefab_8);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_debugPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_debugPrefab_9);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.AREnvironmentProbesChangedEvent>)};
            method = type.GetMethod("add_environmentProbesChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_environmentProbesChanged_10);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.AREnvironmentProbesChangedEvent>)};
            method = type.GetMethod("remove_environmentProbesChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_environmentProbesChanged_11);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.TrackableId)};
            method = type.GetMethod("GetEnvironmentProbe", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetEnvironmentProbe_12);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.ARFoundation.AREnvironmentProbeManager());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.ARFoundation.AREnvironmentProbeManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_automaticPlacementRequested_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AREnvironmentProbeManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AREnvironmentProbeManager)typeof(UnityEngine.XR.ARFoundation.AREnvironmentProbeManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.automaticPlacementRequested;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_automaticPlacementRequested_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AREnvironmentProbeManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AREnvironmentProbeManager)typeof(UnityEngine.XR.ARFoundation.AREnvironmentProbeManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.automaticPlacementRequested = value;

            return __ret;
        }

        static StackObject* get_automaticPlacementEnabled_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AREnvironmentProbeManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AREnvironmentProbeManager)typeof(UnityEngine.XR.ARFoundation.AREnvironmentProbeManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.automaticPlacementEnabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_environmentTextureFilterMode_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AREnvironmentProbeManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AREnvironmentProbeManager)typeof(UnityEngine.XR.ARFoundation.AREnvironmentProbeManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.environmentTextureFilterMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_environmentTextureFilterMode_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.FilterMode @value = (UnityEngine.FilterMode)typeof(UnityEngine.FilterMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AREnvironmentProbeManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AREnvironmentProbeManager)typeof(UnityEngine.XR.ARFoundation.AREnvironmentProbeManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.environmentTextureFilterMode = value;

            return __ret;
        }

        static StackObject* get_environmentTextureHDRRequested_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AREnvironmentProbeManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AREnvironmentProbeManager)typeof(UnityEngine.XR.ARFoundation.AREnvironmentProbeManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.environmentTextureHDRRequested;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_environmentTextureHDRRequested_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AREnvironmentProbeManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AREnvironmentProbeManager)typeof(UnityEngine.XR.ARFoundation.AREnvironmentProbeManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.environmentTextureHDRRequested = value;

            return __ret;
        }

        static StackObject* get_environmentTextureHDREnabled_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AREnvironmentProbeManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AREnvironmentProbeManager)typeof(UnityEngine.XR.ARFoundation.AREnvironmentProbeManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.environmentTextureHDREnabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_debugPrefab_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AREnvironmentProbeManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AREnvironmentProbeManager)typeof(UnityEngine.XR.ARFoundation.AREnvironmentProbeManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.debugPrefab;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_debugPrefab_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AREnvironmentProbeManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AREnvironmentProbeManager)typeof(UnityEngine.XR.ARFoundation.AREnvironmentProbeManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.debugPrefab = value;

            return __ret;
        }

        static StackObject* add_environmentProbesChanged_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.ARFoundation.AREnvironmentProbesChangedEvent> @value = (System.Action<UnityEngine.XR.ARFoundation.AREnvironmentProbesChangedEvent>)typeof(System.Action<UnityEngine.XR.ARFoundation.AREnvironmentProbesChangedEvent>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AREnvironmentProbeManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AREnvironmentProbeManager)typeof(UnityEngine.XR.ARFoundation.AREnvironmentProbeManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.environmentProbesChanged += value;

            return __ret;
        }

        static StackObject* remove_environmentProbesChanged_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.ARFoundation.AREnvironmentProbesChangedEvent> @value = (System.Action<UnityEngine.XR.ARFoundation.AREnvironmentProbesChangedEvent>)typeof(System.Action<UnityEngine.XR.ARFoundation.AREnvironmentProbesChangedEvent>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AREnvironmentProbeManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AREnvironmentProbeManager)typeof(UnityEngine.XR.ARFoundation.AREnvironmentProbeManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.environmentProbesChanged -= value;

            return __ret;
        }

        static StackObject* GetEnvironmentProbe_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.TrackableId @trackableId = (UnityEngine.XR.ARSubsystems.TrackableId)typeof(UnityEngine.XR.ARSubsystems.TrackableId).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AREnvironmentProbeManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AREnvironmentProbeManager)typeof(UnityEngine.XR.ARFoundation.AREnvironmentProbeManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetEnvironmentProbe(@trackableId);

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

            var result_of_this_method = new UnityEngine.XR.ARFoundation.AREnvironmentProbeManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif