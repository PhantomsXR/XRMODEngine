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
    unsafe class UnityEngine_XR_ARFoundation_ARTrackedObjectManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.ARFoundation.ARTrackedObjectManager);
            args = new Type[]{};
            method = type.GetMethod("get_referenceLibrary", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_referenceLibrary_0);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.XRReferenceObjectLibrary)};
            method = type.GetMethod("set_referenceLibrary", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_referenceLibrary_1);
            args = new Type[]{};
            method = type.GetMethod("get_trackedObjectPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_trackedObjectPrefab_2);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_trackedObjectPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_trackedObjectPrefab_3);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.ARTrackedObjectsChangedEventArgs>)};
            method = type.GetMethod("add_trackedObjectsChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_trackedObjectsChanged_4);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.ARTrackedObjectsChangedEventArgs>)};
            method = type.GetMethod("remove_trackedObjectsChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_trackedObjectsChanged_5);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.ARFoundation.ARTrackedObjectManager());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.ARFoundation.ARTrackedObjectManager[s]);

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
            UnityEngine.XR.ARFoundation.ARTrackedObjectManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedObjectManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedObjectManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
            UnityEngine.XR.ARSubsystems.XRReferenceObjectLibrary @value = (UnityEngine.XR.ARSubsystems.XRReferenceObjectLibrary)typeof(UnityEngine.XR.ARSubsystems.XRReferenceObjectLibrary).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARTrackedObjectManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedObjectManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedObjectManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.referenceLibrary = value;

            return __ret;
        }

        static StackObject* get_trackedObjectPrefab_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARTrackedObjectManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedObjectManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedObjectManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.trackedObjectPrefab;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_trackedObjectPrefab_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARTrackedObjectManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedObjectManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedObjectManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trackedObjectPrefab = value;

            return __ret;
        }

        static StackObject* add_trackedObjectsChanged_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.ARFoundation.ARTrackedObjectsChangedEventArgs> @value = (System.Action<UnityEngine.XR.ARFoundation.ARTrackedObjectsChangedEventArgs>)typeof(System.Action<UnityEngine.XR.ARFoundation.ARTrackedObjectsChangedEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARTrackedObjectManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedObjectManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedObjectManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trackedObjectsChanged += value;

            return __ret;
        }

        static StackObject* remove_trackedObjectsChanged_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.ARFoundation.ARTrackedObjectsChangedEventArgs> @value = (System.Action<UnityEngine.XR.ARFoundation.ARTrackedObjectsChangedEventArgs>)typeof(System.Action<UnityEngine.XR.ARFoundation.ARTrackedObjectsChangedEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARTrackedObjectManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARTrackedObjectManager)typeof(UnityEngine.XR.ARFoundation.ARTrackedObjectManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trackedObjectsChanged -= value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.ARFoundation.ARTrackedObjectManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif