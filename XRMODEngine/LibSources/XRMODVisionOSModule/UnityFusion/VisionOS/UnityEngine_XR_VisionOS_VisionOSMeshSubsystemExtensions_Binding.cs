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
    unsafe class UnityEngine_XR_VisionOS_VisionOSMeshSubsystemExtensions_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.VisionOS.VisionOSMeshSubsystemExtensions);
            args = new Type[]{typeof(UnityEngine.XR.XRMeshSubsystem), typeof(UnityEngine.XR.ARSubsystems.TrackableId), typeof(Unity.Collections.Allocator)};
            method = type.GetMethod("GetFaceClassifications", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetFaceClassifications_0);
            args = new Type[]{typeof(UnityEngine.XR.XRMeshSubsystem)};
            method = type.GetMethod("GetClassificationEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetClassificationEnabled_1);
            args = new Type[]{typeof(UnityEngine.XR.XRMeshSubsystem), typeof(System.Boolean)};
            method = type.GetMethod("SetClassificationEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetClassificationEnabled_2);





        }


        static StackObject* GetFaceClassifications_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Collections.Allocator @allocator = (Unity.Collections.Allocator)typeof(Unity.Collections.Allocator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARSubsystems.TrackableId @meshId = (UnityEngine.XR.ARSubsystems.TrackableId)typeof(UnityEngine.XR.ARSubsystems.TrackableId).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.XRMeshSubsystem @subsystem = (UnityEngine.XR.XRMeshSubsystem)typeof(UnityEngine.XR.XRMeshSubsystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.XR.VisionOS.VisionOSMeshSubsystemExtensions.GetFaceClassifications(@subsystem, @meshId, @allocator);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetClassificationEnabled_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.XRMeshSubsystem @subsystem = (UnityEngine.XR.XRMeshSubsystem)typeof(UnityEngine.XR.XRMeshSubsystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.XR.VisionOS.VisionOSMeshSubsystemExtensions.GetClassificationEnabled(@subsystem);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetClassificationEnabled_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @enabled = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.XRMeshSubsystem @subsystem = (UnityEngine.XR.XRMeshSubsystem)typeof(UnityEngine.XR.XRMeshSubsystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.XR.VisionOS.VisionOSMeshSubsystemExtensions.SetClassificationEnabled(@subsystem, @enabled);

            return __ret;
        }





    }
}
