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
    unsafe class UnityEngine_XR_ARFoundation_ARTrackedImageManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.ARFoundation.ARTrackedImageManager);
            args = new Type[]{};
            method = type.GetMethod("get_referenceLibrary", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_referenceLibrary_0);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.IReferenceImageLibrary)};
            method = type.GetMethod("set_referenceLibrary", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_referenceLibrary_1);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.XRReferenceImageLibrary)};
            method = type.GetMethod("CreateRuntimeLibrary", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateRuntimeLibrary_2);
            args = new Type[]{};
            method = type.GetMethod("get_requestedMaxNumberOfMovingImages", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requestedMaxNumberOfMovingImages_3);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_requestedMaxNumberOfMovingImages", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_requestedMaxNumberOfMovingImages_4);
            args = new Type[]{};
            method = type.GetMethod("get_currentMaxNumberOfMovingImages", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentMaxNumberOfMovingImages_5);
            args = new Type[]{};
            method = type.GetMethod("get_trackedImagePrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_trackedImagePrefab_6);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_trackedImagePrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_trackedImagePrefab_7);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.ARTrackedImagesChangedEventArgs>)};
            method = type.GetMethod("add_trackedImagesChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_trackedImagesChanged_8);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.ARTrackedImagesChangedEventArgs>)};
            method = type.GetMethod("remove_trackedImagesChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_trackedImagesChanged_9);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.ARFoundation.ARTrackedImageManager());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.ARFoundation.ARTrackedImageManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_referenceLibrary_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARTrackedImageManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedImageManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedImageManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.referenceLibrary;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_referenceLibrary_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.IReferenceImageLibrary @value = (UnityEngine.XR.ARSubsystems.IReferenceImageLibrary)typeof(UnityEngine.XR.ARSubsystems.IReferenceImageLibrary).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARTrackedImageManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedImageManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedImageManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.referenceLibrary = value;

            return __ret;
        }

        static StackObject* CreateRuntimeLibrary_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.XRReferenceImageLibrary @serializedLibrary = (UnityEngine.XR.ARSubsystems.XRReferenceImageLibrary)typeof(UnityEngine.XR.ARSubsystems.XRReferenceImageLibrary).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARTrackedImageManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedImageManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedImageManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreateRuntimeLibrary(@serializedLibrary);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_requestedMaxNumberOfMovingImages_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARTrackedImageManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedImageManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedImageManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requestedMaxNumberOfMovingImages;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_requestedMaxNumberOfMovingImages_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARTrackedImageManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedImageManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedImageManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.requestedMaxNumberOfMovingImages = value;

            return __ret;
        }

        static StackObject* get_currentMaxNumberOfMovingImages_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARTrackedImageManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedImageManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedImageManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentMaxNumberOfMovingImages;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_trackedImagePrefab_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARTrackedImageManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedImageManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedImageManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.trackedImagePrefab;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_trackedImagePrefab_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARTrackedImageManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedImageManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedImageManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trackedImagePrefab = value;

            return __ret;
        }

        static StackObject* add_trackedImagesChanged_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.ARFoundation.ARTrackedImagesChangedEventArgs> @value = (System.Action<UnityEngine.XR.ARFoundation.ARTrackedImagesChangedEventArgs>)typeof(System.Action<UnityEngine.XR.ARFoundation.ARTrackedImagesChangedEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARTrackedImageManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedImageManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedImageManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trackedImagesChanged += value;

            return __ret;
        }

        static StackObject* remove_trackedImagesChanged_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.ARFoundation.ARTrackedImagesChangedEventArgs> @value = (System.Action<UnityEngine.XR.ARFoundation.ARTrackedImagesChangedEventArgs>)typeof(System.Action<UnityEngine.XR.ARFoundation.ARTrackedImagesChangedEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARTrackedImageManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedImageManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedImageManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trackedImagesChanged -= value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.ARFoundation.ARTrackedImageManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif