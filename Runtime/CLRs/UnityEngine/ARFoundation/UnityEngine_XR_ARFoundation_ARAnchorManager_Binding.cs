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
    unsafe class UnityEngine_XR_ARFoundation_ARAnchorManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.ARFoundation.ARAnchorManager);
            args = new Type[]{};
            method = type.GetMethod("get_anchorPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_anchorPrefab_0);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_anchorPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_anchorPrefab_1);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.ARAnchorsChangedEventArgs>)};
            method = type.GetMethod("add_anchorsChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_anchorsChanged_2);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.ARAnchorsChangedEventArgs>)};
            method = type.GetMethod("remove_anchorsChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_anchorsChanged_3);
            args = new Type[]{typeof(UnityEngine.XR.ARFoundation.ARPlane), typeof(UnityEngine.Pose)};
            method = type.GetMethod("AttachAnchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AttachAnchor_4);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.TrackableId)};
            method = type.GetMethod("GetAnchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAnchor_5);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.ARFoundation.ARAnchorManager());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.ARFoundation.ARAnchorManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_anchorPrefab_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARAnchorManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARAnchorManager)typeof(UnityEngine.XR.ARFoundation.ARAnchorManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.anchorPrefab;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_anchorPrefab_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARAnchorManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARAnchorManager)typeof(UnityEngine.XR.ARFoundation.ARAnchorManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.anchorPrefab = value;

            return __ret;
        }

        static StackObject* add_anchorsChanged_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.ARFoundation.ARAnchorsChangedEventArgs> @value = (System.Action<UnityEngine.XR.ARFoundation.ARAnchorsChangedEventArgs>)typeof(System.Action<UnityEngine.XR.ARFoundation.ARAnchorsChangedEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARAnchorManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARAnchorManager)typeof(UnityEngine.XR.ARFoundation.ARAnchorManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.anchorsChanged += value;

            return __ret;
        }

        static StackObject* remove_anchorsChanged_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.ARFoundation.ARAnchorsChangedEventArgs> @value = (System.Action<UnityEngine.XR.ARFoundation.ARAnchorsChangedEventArgs>)typeof(System.Action<UnityEngine.XR.ARFoundation.ARAnchorsChangedEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARAnchorManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARAnchorManager)typeof(UnityEngine.XR.ARFoundation.ARAnchorManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.anchorsChanged -= value;

            return __ret;
        }

        static StackObject* AttachAnchor_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Pose @pose = (UnityEngine.Pose)typeof(UnityEngine.Pose).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARPlane @plane = (UnityEngine.XR.ARFoundation.ARPlane)typeof(UnityEngine.XR.ARFoundation.ARPlane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.ARFoundation.ARAnchorManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARAnchorManager)typeof(UnityEngine.XR.ARFoundation.ARAnchorManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AttachAnchor(@plane, @pose);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAnchor_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.TrackableId @trackableId = (UnityEngine.XR.ARSubsystems.TrackableId)typeof(UnityEngine.XR.ARSubsystems.TrackableId).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARAnchorManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARAnchorManager)typeof(UnityEngine.XR.ARFoundation.ARAnchorManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAnchor(@trackableId);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.ARFoundation.ARAnchorManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif