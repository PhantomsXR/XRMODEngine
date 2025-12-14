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
    unsafe class UnityEngine_XR_ARFoundation_ARFaceManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.ARFoundation.ARFaceManager);
            args = new Type[]{};
            method = type.GetMethod("get_facePrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_facePrefab_0);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_facePrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_facePrefab_1);
            args = new Type[]{};
            method = type.GetMethod("get_requestedMaximumFaceCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requestedMaximumFaceCount_2);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_requestedMaximumFaceCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_requestedMaximumFaceCount_3);
            args = new Type[]{};
            method = type.GetMethod("get_currentMaximumFaceCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentMaximumFaceCount_4);
            args = new Type[]{};
            method = type.GetMethod("get_supportedFaceCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supportedFaceCount_5);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.ARFacesChangedEventArgs>)};
            method = type.GetMethod("add_facesChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_facesChanged_6);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.ARFacesChangedEventArgs>)};
            method = type.GetMethod("remove_facesChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_facesChanged_7);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.TrackableId)};
            method = type.GetMethod("TryGetFace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetFace_8);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.ARFoundation.ARFaceManager());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.ARFoundation.ARFaceManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_facePrefab_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARFaceManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARFaceManager)typeof(UnityEngine.XR.ARFoundation.ARFaceManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.facePrefab;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_facePrefab_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARFaceManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARFaceManager)typeof(UnityEngine.XR.ARFoundation.ARFaceManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.facePrefab = value;

            return __ret;
        }

        static StackObject* get_requestedMaximumFaceCount_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARFaceManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARFaceManager)typeof(UnityEngine.XR.ARFoundation.ARFaceManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requestedMaximumFaceCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_requestedMaximumFaceCount_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARFaceManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARFaceManager)typeof(UnityEngine.XR.ARFoundation.ARFaceManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.requestedMaximumFaceCount = value;

            return __ret;
        }

        static StackObject* get_currentMaximumFaceCount_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARFaceManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARFaceManager)typeof(UnityEngine.XR.ARFoundation.ARFaceManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentMaximumFaceCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_supportedFaceCount_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARFaceManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARFaceManager)typeof(UnityEngine.XR.ARFoundation.ARFaceManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.supportedFaceCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* add_facesChanged_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.ARFoundation.ARFacesChangedEventArgs> @value = (System.Action<UnityEngine.XR.ARFoundation.ARFacesChangedEventArgs>)typeof(System.Action<UnityEngine.XR.ARFoundation.ARFacesChangedEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARFaceManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARFaceManager)typeof(UnityEngine.XR.ARFoundation.ARFaceManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.facesChanged += value;

            return __ret;
        }

        static StackObject* remove_facesChanged_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.ARFoundation.ARFacesChangedEventArgs> @value = (System.Action<UnityEngine.XR.ARFoundation.ARFacesChangedEventArgs>)typeof(System.Action<UnityEngine.XR.ARFoundation.ARFacesChangedEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARFaceManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARFaceManager)typeof(UnityEngine.XR.ARFoundation.ARFaceManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.facesChanged -= value;

            return __ret;
        }

        static StackObject* TryGetFace_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.TrackableId @faceId = (UnityEngine.XR.ARSubsystems.TrackableId)typeof(UnityEngine.XR.ARSubsystems.TrackableId).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARFaceManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARFaceManager)typeof(UnityEngine.XR.ARFoundation.ARFaceManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryGetFace(@faceId);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.ARFoundation.ARFaceManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif