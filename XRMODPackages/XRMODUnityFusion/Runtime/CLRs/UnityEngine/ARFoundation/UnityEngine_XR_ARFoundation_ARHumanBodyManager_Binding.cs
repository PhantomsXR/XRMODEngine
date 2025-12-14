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
    unsafe class UnityEngine_XR_ARFoundation_ARHumanBodyManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager);
            args = new Type[]{};
            method = type.GetMethod("get_pose2DEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pose2DEnabled_0);
            args = new Type[]{};
            method = type.GetMethod("get_pose2DRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pose2DRequested_1);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_pose2DRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_pose2DRequested_2);
            args = new Type[]{};
            method = type.GetMethod("get_pose3DRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pose3DRequested_3);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_pose3DRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_pose3DRequested_4);
            args = new Type[]{};
            method = type.GetMethod("get_pose3DEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pose3DEnabled_5);
            args = new Type[]{};
            method = type.GetMethod("get_pose3DScaleEstimationRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pose3DScaleEstimationRequested_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_pose3DScaleEstimationRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_pose3DScaleEstimationRequested_7);
            args = new Type[]{};
            method = type.GetMethod("get_pose3DScaleEstimationEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pose3DScaleEstimationEnabled_8);
            args = new Type[]{};
            method = type.GetMethod("get_humanBodyPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_humanBodyPrefab_9);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_humanBodyPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_humanBodyPrefab_10);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.ARHumanBodiesChangedEventArgs>)};
            method = type.GetMethod("add_humanBodiesChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_humanBodiesChanged_11);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.ARHumanBodiesChangedEventArgs>)};
            method = type.GetMethod("remove_humanBodiesChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_humanBodiesChanged_12);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.TrackableId)};
            method = type.GetMethod("GetHumanBody", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetHumanBody_13);
            args = new Type[]{typeof(Unity.Collections.Allocator)};
            method = type.GetMethod("GetHumanBodyPose2DJoints", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetHumanBodyPose2DJoints_14);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.ARFoundation.ARHumanBodyManager());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.ARFoundation.ARHumanBodyManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_pose2DEnabled_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pose2DEnabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_pose2DRequested_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pose2DRequested;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_pose2DRequested_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.pose2DRequested = value;

            return __ret;
        }

        static StackObject* get_pose3DRequested_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pose3DRequested;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_pose3DRequested_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.pose3DRequested = value;

            return __ret;
        }

        static StackObject* get_pose3DEnabled_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pose3DEnabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_pose3DScaleEstimationRequested_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pose3DScaleEstimationRequested;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_pose3DScaleEstimationRequested_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.pose3DScaleEstimationRequested = value;

            return __ret;
        }

        static StackObject* get_pose3DScaleEstimationEnabled_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pose3DScaleEstimationEnabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_humanBodyPrefab_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.humanBodyPrefab;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_humanBodyPrefab_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.humanBodyPrefab = value;

            return __ret;
        }

        static StackObject* add_humanBodiesChanged_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.ARFoundation.ARHumanBodiesChangedEventArgs> @value = (System.Action<UnityEngine.XR.ARFoundation.ARHumanBodiesChangedEventArgs>)typeof(System.Action<UnityEngine.XR.ARFoundation.ARHumanBodiesChangedEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.humanBodiesChanged += value;

            return __ret;
        }

        static StackObject* remove_humanBodiesChanged_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.ARFoundation.ARHumanBodiesChangedEventArgs> @value = (System.Action<UnityEngine.XR.ARFoundation.ARHumanBodiesChangedEventArgs>)typeof(System.Action<UnityEngine.XR.ARFoundation.ARHumanBodiesChangedEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.humanBodiesChanged -= value;

            return __ret;
        }

        static StackObject* GetHumanBody_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.TrackableId @trackableId = (UnityEngine.XR.ARSubsystems.TrackableId)typeof(UnityEngine.XR.ARSubsystems.TrackableId).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetHumanBody(@trackableId);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetHumanBodyPose2DJoints_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Collections.Allocator @allocator = (Unity.Collections.Allocator)typeof(Unity.Collections.Allocator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARHumanBodyManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARHumanBodyManager)typeof(UnityEngine.XR.ARFoundation.ARHumanBodyManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetHumanBodyPose2DJoints(@allocator);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.ARFoundation.ARHumanBodyManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif