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
    unsafe class Unity_PolySpatial_VolumeCamera_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.PolySpatial.VolumeCamera);
            args = new Type[]{typeof(System.Action<System.Nullable<System.Double>, System.Nullable<System.Double>>)};
            method = type.GetMethod("add_ImmersionChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_ImmersionChanged_0);
            args = new Type[]{typeof(System.Action<System.Nullable<System.Double>, System.Nullable<System.Double>>)};
            method = type.GetMethod("remove_ImmersionChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_ImmersionChanged_1);
            args = new Type[]{};
            method = type.GetMethod("get_CullingMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CullingMask_2);
            args = new Type[]{typeof(UnityEngine.LayerMask)};
            method = type.GetMethod("set_CullingMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_CullingMask_3);
            args = new Type[]{};
            method = type.GetMethod("get_WindowConfiguration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_WindowConfiguration_4);
            args = new Type[]{typeof(Unity.PolySpatial.VolumeCameraWindowConfiguration)};
            method = type.GetMethod("set_WindowConfiguration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_WindowConfiguration_5);
            args = new Type[]{};
            method = type.GetMethod("get_WindowMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_WindowMode_6);
            args = new Type[]{};
            method = type.GetMethod("get_OutputDimensions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_OutputDimensions_7);
            args = new Type[]{};
            method = type.GetMethod("get_Dimensions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Dimensions_8);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_Dimensions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Dimensions_9);
            args = new Type[]{};
            method = type.GetMethod("get_ScaleWithWindow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ScaleWithWindow_10);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_ScaleWithWindow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ScaleWithWindow_11);
            args = new Type[]{};
            method = type.GetMethod("get_VolumeSpaceToWorldSpaceMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_VolumeSpaceToWorldSpaceMatrix_12);
            args = new Type[]{};
            method = type.GetMethod("get_WorldSpaceToVolumeSpaceMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_WorldSpaceToVolumeSpaceMatrix_13);
            args = new Type[]{};
            method = type.GetMethod("get_WindowOpen", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_WindowOpen_14);
            args = new Type[]{};
            method = type.GetMethod("get_WindowFocused", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_WindowFocused_15);
            args = new Type[]{};
            method = type.GetMethod("OpenWindow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OpenWindow_16);
            args = new Type[]{};
            method = type.GetMethod("CloseWindow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CloseWindow_17);

            field = type.GetField("OpenWindowOnLoad", flag);
            app.RegisterCLRFieldGetter(field, get_OpenWindowOnLoad_0);
            app.RegisterCLRFieldSetter(field, set_OpenWindowOnLoad_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OpenWindowOnLoad_0, AssignFromStack_OpenWindowOnLoad_0);
            field = type.GetField("WindowStateChanged", flag);
            app.RegisterCLRFieldGetter(field, get_WindowStateChanged_1);
            app.RegisterCLRFieldSetter(field, set_WindowStateChanged_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_WindowStateChanged_1, AssignFromStack_WindowStateChanged_1);
            field = type.GetField("ViewpointChanged", flag);
            app.RegisterCLRFieldGetter(field, get_ViewpointChanged_2);
            app.RegisterCLRFieldSetter(field, set_ViewpointChanged_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_ViewpointChanged_2, AssignFromStack_ViewpointChanged_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.PolySpatial.VolumeCamera());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.PolySpatial.VolumeCamera[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* add_ImmersionChanged_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Nullable<System.Double>, System.Nullable<System.Double>> @value = (System.Action<System.Nullable<System.Double>, System.Nullable<System.Double>>)typeof(System.Action<System.Nullable<System.Double>, System.Nullable<System.Double>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Unity.PolySpatial.VolumeCamera.ImmersionChanged += value;

            return __ret;
        }

        static StackObject* remove_ImmersionChanged_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Nullable<System.Double>, System.Nullable<System.Double>> @value = (System.Action<System.Nullable<System.Double>, System.Nullable<System.Double>>)typeof(System.Action<System.Nullable<System.Double>, System.Nullable<System.Double>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Unity.PolySpatial.VolumeCamera.ImmersionChanged -= value;

            return __ret;
        }

        static StackObject* get_CullingMask_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CullingMask;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_CullingMask_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LayerMask @value = (UnityEngine.LayerMask)typeof(UnityEngine.LayerMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CullingMask = value;

            return __ret;
        }

        static StackObject* get_WindowConfiguration_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.WindowConfiguration;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_WindowConfiguration_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCameraWindowConfiguration @value = (Unity.PolySpatial.VolumeCameraWindowConfiguration)typeof(Unity.PolySpatial.VolumeCameraWindowConfiguration).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WindowConfiguration = value;

            return __ret;
        }

        static StackObject* get_WindowMode_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.WindowMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_OutputDimensions_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.OutputDimensions;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Dimensions_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Dimensions;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Dimensions_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Dimensions = value;

            return __ret;
        }

        static StackObject* get_ScaleWithWindow_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ScaleWithWindow;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_ScaleWithWindow_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScaleWithWindow = value;

            return __ret;
        }

        static StackObject* get_VolumeSpaceToWorldSpaceMatrix_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.VolumeSpaceToWorldSpaceMatrix;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_WorldSpaceToVolumeSpaceMatrix_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.WorldSpaceToVolumeSpaceMatrix;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_WindowOpen_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.WindowOpen;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_WindowFocused_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.WindowFocused;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* OpenWindow_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OpenWindow();

            return __ret;
        }

        static StackObject* CloseWindow_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VolumeCamera instance_of_this_method = (Unity.PolySpatial.VolumeCamera)typeof(Unity.PolySpatial.VolumeCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CloseWindow();

            return __ret;
        }


        static object get_OpenWindowOnLoad_0(ref object o)
        {
            return ((Unity.PolySpatial.VolumeCamera)o).OpenWindowOnLoad;
        }

        static StackObject* CopyToStack_OpenWindowOnLoad_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.PolySpatial.VolumeCamera)o).OpenWindowOnLoad;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_OpenWindowOnLoad_0(ref object o, object v)
        {
            ((Unity.PolySpatial.VolumeCamera)o).OpenWindowOnLoad = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_OpenWindowOnLoad_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @OpenWindowOnLoad = ptr_of_this_method->Value == 1;
            ((Unity.PolySpatial.VolumeCamera)o).OpenWindowOnLoad = @OpenWindowOnLoad;
            return ptr_of_this_method;
        }

        static object get_WindowStateChanged_1(ref object o)
        {
            return ((Unity.PolySpatial.VolumeCamera)o).WindowStateChanged;
        }

        static StackObject* CopyToStack_WindowStateChanged_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.PolySpatial.VolumeCamera)o).WindowStateChanged;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_WindowStateChanged_1(ref object o, object v)
        {
            ((Unity.PolySpatial.VolumeCamera)o).WindowStateChanged = (UnityEngine.Events.UnityEvent<Unity.PolySpatial.VolumeCamera, Unity.PolySpatial.VolumeCamera.WindowState>)v;
        }

        static StackObject* AssignFromStack_WindowStateChanged_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<Unity.PolySpatial.VolumeCamera, Unity.PolySpatial.VolumeCamera.WindowState> @WindowStateChanged = (UnityEngine.Events.UnityEvent<Unity.PolySpatial.VolumeCamera, Unity.PolySpatial.VolumeCamera.WindowState>)typeof(UnityEngine.Events.UnityEvent<Unity.PolySpatial.VolumeCamera, Unity.PolySpatial.VolumeCamera.WindowState>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.PolySpatial.VolumeCamera)o).WindowStateChanged = @WindowStateChanged;
            return ptr_of_this_method;
        }

        static object get_ViewpointChanged_2(ref object o)
        {
            return ((Unity.PolySpatial.VolumeCamera)o).ViewpointChanged;
        }

        static StackObject* CopyToStack_ViewpointChanged_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.PolySpatial.VolumeCamera)o).ViewpointChanged;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ViewpointChanged_2(ref object o, object v)
        {
            ((Unity.PolySpatial.VolumeCamera)o).ViewpointChanged = (UnityEngine.Events.UnityEvent<Unity.PolySpatial.VolumeCamera.Viewpoint>)v;
        }

        static StackObject* AssignFromStack_ViewpointChanged_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<Unity.PolySpatial.VolumeCamera.Viewpoint> @ViewpointChanged = (UnityEngine.Events.UnityEvent<Unity.PolySpatial.VolumeCamera.Viewpoint>)typeof(UnityEngine.Events.UnityEvent<Unity.PolySpatial.VolumeCamera.Viewpoint>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.PolySpatial.VolumeCamera)o).ViewpointChanged = @ViewpointChanged;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.PolySpatial.VolumeCamera();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
