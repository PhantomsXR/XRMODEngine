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
    unsafe class Phantom_XRMOD_XRMODAPI_Runtime_DeviceInfo_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo);

            field = type.GetField("deviceModel", flag);
            app.RegisterCLRFieldGetter(field, get_deviceModel_0);
            app.RegisterCLRFieldSetter(field, set_deviceModel_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_deviceModel_0, AssignFromStack_deviceModel_0);
            field = type.GetField("deviceName", flag);
            app.RegisterCLRFieldGetter(field, get_deviceName_1);
            app.RegisterCLRFieldSetter(field, set_deviceName_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_deviceName_1, AssignFromStack_deviceName_1);
            field = type.GetField("deviceUniqueIdentifier", flag);
            app.RegisterCLRFieldGetter(field, get_deviceUniqueIdentifier_2);
            app.RegisterCLRFieldSetter(field, set_deviceUniqueIdentifier_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_deviceUniqueIdentifier_2, AssignFromStack_deviceUniqueIdentifier_2);
            field = type.GetField("graphicsDeviceID", flag);
            app.RegisterCLRFieldGetter(field, get_graphicsDeviceID_3);
            app.RegisterCLRFieldSetter(field, set_graphicsDeviceID_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_graphicsDeviceID_3, AssignFromStack_graphicsDeviceID_3);
            field = type.GetField("graphicsDeviceName", flag);
            app.RegisterCLRFieldGetter(field, get_graphicsDeviceName_4);
            app.RegisterCLRFieldSetter(field, set_graphicsDeviceName_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_graphicsDeviceName_4, AssignFromStack_graphicsDeviceName_4);
            field = type.GetField("graphicsDeviceType", flag);
            app.RegisterCLRFieldGetter(field, get_graphicsDeviceType_5);
            app.RegisterCLRFieldSetter(field, set_graphicsDeviceType_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_graphicsDeviceType_5, AssignFromStack_graphicsDeviceType_5);
            field = type.GetField("graphicsDeviceVendor", flag);
            app.RegisterCLRFieldGetter(field, get_graphicsDeviceVendor_6);
            app.RegisterCLRFieldSetter(field, set_graphicsDeviceVendor_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_graphicsDeviceVendor_6, AssignFromStack_graphicsDeviceVendor_6);
            field = type.GetField("graphicsDeviceVendorID", flag);
            app.RegisterCLRFieldGetter(field, get_graphicsDeviceVendorID_7);
            app.RegisterCLRFieldSetter(field, set_graphicsDeviceVendorID_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_graphicsDeviceVendorID_7, AssignFromStack_graphicsDeviceVendorID_7);
            field = type.GetField("graphicsDeviceVersion", flag);
            app.RegisterCLRFieldGetter(field, get_graphicsDeviceVersion_8);
            app.RegisterCLRFieldSetter(field, set_graphicsDeviceVersion_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_graphicsDeviceVersion_8, AssignFromStack_graphicsDeviceVersion_8);
            field = type.GetField("graphicsMemorySize", flag);
            app.RegisterCLRFieldGetter(field, get_graphicsMemorySize_9);
            app.RegisterCLRFieldSetter(field, set_graphicsMemorySize_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_graphicsMemorySize_9, AssignFromStack_graphicsMemorySize_9);
            field = type.GetField("graphicsMultiThreaded", flag);
            app.RegisterCLRFieldGetter(field, get_graphicsMultiThreaded_10);
            app.RegisterCLRFieldSetter(field, set_graphicsMultiThreaded_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_graphicsMultiThreaded_10, AssignFromStack_graphicsMultiThreaded_10);
            field = type.GetField("graphicsShaderLevel", flag);
            app.RegisterCLRFieldGetter(field, get_graphicsShaderLevel_11);
            app.RegisterCLRFieldSetter(field, set_graphicsShaderLevel_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_graphicsShaderLevel_11, AssignFromStack_graphicsShaderLevel_11);
            field = type.GetField("maxTextureSize", flag);
            app.RegisterCLRFieldGetter(field, get_maxTextureSize_12);
            app.RegisterCLRFieldSetter(field, set_maxTextureSize_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_maxTextureSize_12, AssignFromStack_maxTextureSize_12);
            field = type.GetField("npotSupport", flag);
            app.RegisterCLRFieldGetter(field, get_npotSupport_13);
            app.RegisterCLRFieldSetter(field, set_npotSupport_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_npotSupport_13, AssignFromStack_npotSupport_13);
            field = type.GetField("operatingSystem", flag);
            app.RegisterCLRFieldGetter(field, get_operatingSystem_14);
            app.RegisterCLRFieldSetter(field, set_operatingSystem_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_operatingSystem_14, AssignFromStack_operatingSystem_14);
            field = type.GetField("processorCount", flag);
            app.RegisterCLRFieldGetter(field, get_processorCount_15);
            app.RegisterCLRFieldSetter(field, set_processorCount_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_processorCount_15, AssignFromStack_processorCount_15);
            field = type.GetField("processorFrequency", flag);
            app.RegisterCLRFieldGetter(field, get_processorFrequency_16);
            app.RegisterCLRFieldSetter(field, set_processorFrequency_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_processorFrequency_16, AssignFromStack_processorFrequency_16);
            field = type.GetField("processorType", flag);
            app.RegisterCLRFieldGetter(field, get_processorType_17);
            app.RegisterCLRFieldSetter(field, set_processorType_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_processorType_17, AssignFromStack_processorType_17);
            field = type.GetField("supportedRenderTargetCount", flag);
            app.RegisterCLRFieldGetter(field, get_supportedRenderTargetCount_18);
            app.RegisterCLRFieldSetter(field, set_supportedRenderTargetCount_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_supportedRenderTargetCount_18, AssignFromStack_supportedRenderTargetCount_18);
            field = type.GetField("supports2DArrayTextures", flag);
            app.RegisterCLRFieldGetter(field, get_supports2DArrayTextures_19);
            app.RegisterCLRFieldSetter(field, set_supports2DArrayTextures_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_supports2DArrayTextures_19, AssignFromStack_supports2DArrayTextures_19);
            field = type.GetField("supports3DTextures", flag);
            app.RegisterCLRFieldGetter(field, get_supports3DTextures_20);
            app.RegisterCLRFieldSetter(field, set_supports3DTextures_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_supports3DTextures_20, AssignFromStack_supports3DTextures_20);
            field = type.GetField("supportsAccelerometer", flag);
            app.RegisterCLRFieldGetter(field, get_supportsAccelerometer_21);
            app.RegisterCLRFieldSetter(field, set_supportsAccelerometer_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_supportsAccelerometer_21, AssignFromStack_supportsAccelerometer_21);
            field = type.GetField("supportsAudio", flag);
            app.RegisterCLRFieldGetter(field, get_supportsAudio_22);
            app.RegisterCLRFieldSetter(field, set_supportsAudio_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_supportsAudio_22, AssignFromStack_supportsAudio_22);
            field = type.GetField("supportsComputeShaders", flag);
            app.RegisterCLRFieldGetter(field, get_supportsComputeShaders_23);
            app.RegisterCLRFieldSetter(field, set_supportsComputeShaders_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_supportsComputeShaders_23, AssignFromStack_supportsComputeShaders_23);
            field = type.GetField("supportsGyroscope", flag);
            app.RegisterCLRFieldGetter(field, get_supportsGyroscope_24);
            app.RegisterCLRFieldSetter(field, set_supportsGyroscope_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_supportsGyroscope_24, AssignFromStack_supportsGyroscope_24);
            field = type.GetField("supportsImageEffects", flag);
            app.RegisterCLRFieldGetter(field, get_supportsImageEffects_25);
            app.RegisterCLRFieldSetter(field, set_supportsImageEffects_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_supportsImageEffects_25, AssignFromStack_supportsImageEffects_25);
            field = type.GetField("supportsLocationService", flag);
            app.RegisterCLRFieldGetter(field, get_supportsLocationService_26);
            app.RegisterCLRFieldSetter(field, set_supportsLocationService_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_supportsLocationService_26, AssignFromStack_supportsLocationService_26);
            field = type.GetField("supportsMotionVectors", flag);
            app.RegisterCLRFieldGetter(field, get_supportsMotionVectors_27);
            app.RegisterCLRFieldSetter(field, set_supportsMotionVectors_27);
            app.RegisterCLRFieldBinding(field, CopyToStack_supportsMotionVectors_27, AssignFromStack_supportsMotionVectors_27);
            field = type.GetField("supportsVibration", flag);
            app.RegisterCLRFieldGetter(field, get_supportsVibration_28);
            app.RegisterCLRFieldSetter(field, set_supportsVibration_28);
            app.RegisterCLRFieldBinding(field, CopyToStack_supportsVibration_28, AssignFromStack_supportsVibration_28);
            field = type.GetField("systemMemorySize", flag);
            app.RegisterCLRFieldGetter(field, get_systemMemorySize_29);
            app.RegisterCLRFieldSetter(field, set_systemMemorySize_29);
            app.RegisterCLRFieldBinding(field, CopyToStack_systemMemorySize_29, AssignFromStack_systemMemorySize_29);
            field = type.GetField("unsupportedIdentifier", flag);
            app.RegisterCLRFieldGetter(field, get_unsupportedIdentifier_30);
            app.RegisterCLRFieldSetter(field, set_unsupportedIdentifier_30);
            app.RegisterCLRFieldBinding(field, CopyToStack_unsupportedIdentifier_30, AssignFromStack_unsupportedIdentifier_30);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_deviceModel_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).deviceModel;
        }

        static StackObject* CopyToStack_deviceModel_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).deviceModel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_deviceModel_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).deviceModel = (System.String)v;
        }

        static StackObject* AssignFromStack_deviceModel_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @deviceModel = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).deviceModel = @deviceModel;
            return ptr_of_this_method;
        }

        static object get_deviceName_1(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).deviceName;
        }

        static StackObject* CopyToStack_deviceName_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).deviceName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_deviceName_1(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).deviceName = (System.String)v;
        }

        static StackObject* AssignFromStack_deviceName_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @deviceName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).deviceName = @deviceName;
            return ptr_of_this_method;
        }

        static object get_deviceUniqueIdentifier_2(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).deviceUniqueIdentifier;
        }

        static StackObject* CopyToStack_deviceUniqueIdentifier_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).deviceUniqueIdentifier;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_deviceUniqueIdentifier_2(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).deviceUniqueIdentifier = (System.String)v;
        }

        static StackObject* AssignFromStack_deviceUniqueIdentifier_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @deviceUniqueIdentifier = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).deviceUniqueIdentifier = @deviceUniqueIdentifier;
            return ptr_of_this_method;
        }

        static object get_graphicsDeviceID_3(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceID;
        }

        static StackObject* CopyToStack_graphicsDeviceID_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceID;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_graphicsDeviceID_3(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceID = (System.Int32)v;
        }

        static StackObject* AssignFromStack_graphicsDeviceID_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @graphicsDeviceID = ptr_of_this_method->Value;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceID = @graphicsDeviceID;
            return ptr_of_this_method;
        }

        static object get_graphicsDeviceName_4(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceName;
        }

        static StackObject* CopyToStack_graphicsDeviceName_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_graphicsDeviceName_4(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceName = (System.String)v;
        }

        static StackObject* AssignFromStack_graphicsDeviceName_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @graphicsDeviceName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceName = @graphicsDeviceName;
            return ptr_of_this_method;
        }

        static object get_graphicsDeviceType_5(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceType;
        }

        static StackObject* CopyToStack_graphicsDeviceType_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_graphicsDeviceType_5(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceType = (System.String)v;
        }

        static StackObject* AssignFromStack_graphicsDeviceType_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @graphicsDeviceType = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceType = @graphicsDeviceType;
            return ptr_of_this_method;
        }

        static object get_graphicsDeviceVendor_6(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceVendor;
        }

        static StackObject* CopyToStack_graphicsDeviceVendor_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceVendor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_graphicsDeviceVendor_6(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceVendor = (System.String)v;
        }

        static StackObject* AssignFromStack_graphicsDeviceVendor_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @graphicsDeviceVendor = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceVendor = @graphicsDeviceVendor;
            return ptr_of_this_method;
        }

        static object get_graphicsDeviceVendorID_7(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceVendorID;
        }

        static StackObject* CopyToStack_graphicsDeviceVendorID_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceVendorID;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_graphicsDeviceVendorID_7(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceVendorID = (System.Int32)v;
        }

        static StackObject* AssignFromStack_graphicsDeviceVendorID_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @graphicsDeviceVendorID = ptr_of_this_method->Value;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceVendorID = @graphicsDeviceVendorID;
            return ptr_of_this_method;
        }

        static object get_graphicsDeviceVersion_8(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceVersion;
        }

        static StackObject* CopyToStack_graphicsDeviceVersion_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceVersion;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_graphicsDeviceVersion_8(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceVersion = (System.String)v;
        }

        static StackObject* AssignFromStack_graphicsDeviceVersion_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @graphicsDeviceVersion = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsDeviceVersion = @graphicsDeviceVersion;
            return ptr_of_this_method;
        }

        static object get_graphicsMemorySize_9(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsMemorySize;
        }

        static StackObject* CopyToStack_graphicsMemorySize_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsMemorySize;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_graphicsMemorySize_9(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsMemorySize = (System.Int32)v;
        }

        static StackObject* AssignFromStack_graphicsMemorySize_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @graphicsMemorySize = ptr_of_this_method->Value;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsMemorySize = @graphicsMemorySize;
            return ptr_of_this_method;
        }

        static object get_graphicsMultiThreaded_10(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsMultiThreaded;
        }

        static StackObject* CopyToStack_graphicsMultiThreaded_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsMultiThreaded;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_graphicsMultiThreaded_10(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsMultiThreaded = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_graphicsMultiThreaded_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @graphicsMultiThreaded = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsMultiThreaded = @graphicsMultiThreaded;
            return ptr_of_this_method;
        }

        static object get_graphicsShaderLevel_11(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsShaderLevel;
        }

        static StackObject* CopyToStack_graphicsShaderLevel_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsShaderLevel;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_graphicsShaderLevel_11(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsShaderLevel = (System.Int32)v;
        }

        static StackObject* AssignFromStack_graphicsShaderLevel_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @graphicsShaderLevel = ptr_of_this_method->Value;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).graphicsShaderLevel = @graphicsShaderLevel;
            return ptr_of_this_method;
        }

        static object get_maxTextureSize_12(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).maxTextureSize;
        }

        static StackObject* CopyToStack_maxTextureSize_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).maxTextureSize;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_maxTextureSize_12(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).maxTextureSize = (System.Int32)v;
        }

        static StackObject* AssignFromStack_maxTextureSize_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @maxTextureSize = ptr_of_this_method->Value;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).maxTextureSize = @maxTextureSize;
            return ptr_of_this_method;
        }

        static object get_npotSupport_13(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).npotSupport;
        }

        static StackObject* CopyToStack_npotSupport_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).npotSupport;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_npotSupport_13(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).npotSupport = (System.String)v;
        }

        static StackObject* AssignFromStack_npotSupport_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @npotSupport = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).npotSupport = @npotSupport;
            return ptr_of_this_method;
        }

        static object get_operatingSystem_14(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).operatingSystem;
        }

        static StackObject* CopyToStack_operatingSystem_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).operatingSystem;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_operatingSystem_14(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).operatingSystem = (System.String)v;
        }

        static StackObject* AssignFromStack_operatingSystem_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @operatingSystem = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).operatingSystem = @operatingSystem;
            return ptr_of_this_method;
        }

        static object get_processorCount_15(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).processorCount;
        }

        static StackObject* CopyToStack_processorCount_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).processorCount;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_processorCount_15(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).processorCount = (System.Int32)v;
        }

        static StackObject* AssignFromStack_processorCount_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @processorCount = ptr_of_this_method->Value;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).processorCount = @processorCount;
            return ptr_of_this_method;
        }

        static object get_processorFrequency_16(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).processorFrequency;
        }

        static StackObject* CopyToStack_processorFrequency_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).processorFrequency;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_processorFrequency_16(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).processorFrequency = (System.Int32)v;
        }

        static StackObject* AssignFromStack_processorFrequency_16(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @processorFrequency = ptr_of_this_method->Value;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).processorFrequency = @processorFrequency;
            return ptr_of_this_method;
        }

        static object get_processorType_17(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).processorType;
        }

        static StackObject* CopyToStack_processorType_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).processorType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_processorType_17(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).processorType = (System.String)v;
        }

        static StackObject* AssignFromStack_processorType_17(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @processorType = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).processorType = @processorType;
            return ptr_of_this_method;
        }

        static object get_supportedRenderTargetCount_18(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportedRenderTargetCount;
        }

        static StackObject* CopyToStack_supportedRenderTargetCount_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportedRenderTargetCount;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_supportedRenderTargetCount_18(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportedRenderTargetCount = (System.Int32)v;
        }

        static StackObject* AssignFromStack_supportedRenderTargetCount_18(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @supportedRenderTargetCount = ptr_of_this_method->Value;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportedRenderTargetCount = @supportedRenderTargetCount;
            return ptr_of_this_method;
        }

        static object get_supports2DArrayTextures_19(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supports2DArrayTextures;
        }

        static StackObject* CopyToStack_supports2DArrayTextures_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supports2DArrayTextures;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_supports2DArrayTextures_19(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supports2DArrayTextures = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_supports2DArrayTextures_19(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @supports2DArrayTextures = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supports2DArrayTextures = @supports2DArrayTextures;
            return ptr_of_this_method;
        }

        static object get_supports3DTextures_20(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supports3DTextures;
        }

        static StackObject* CopyToStack_supports3DTextures_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supports3DTextures;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_supports3DTextures_20(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supports3DTextures = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_supports3DTextures_20(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @supports3DTextures = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supports3DTextures = @supports3DTextures;
            return ptr_of_this_method;
        }

        static object get_supportsAccelerometer_21(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsAccelerometer;
        }

        static StackObject* CopyToStack_supportsAccelerometer_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsAccelerometer;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_supportsAccelerometer_21(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsAccelerometer = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_supportsAccelerometer_21(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @supportsAccelerometer = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsAccelerometer = @supportsAccelerometer;
            return ptr_of_this_method;
        }

        static object get_supportsAudio_22(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsAudio;
        }

        static StackObject* CopyToStack_supportsAudio_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsAudio;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_supportsAudio_22(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsAudio = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_supportsAudio_22(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @supportsAudio = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsAudio = @supportsAudio;
            return ptr_of_this_method;
        }

        static object get_supportsComputeShaders_23(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsComputeShaders;
        }

        static StackObject* CopyToStack_supportsComputeShaders_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsComputeShaders;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_supportsComputeShaders_23(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsComputeShaders = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_supportsComputeShaders_23(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @supportsComputeShaders = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsComputeShaders = @supportsComputeShaders;
            return ptr_of_this_method;
        }

        static object get_supportsGyroscope_24(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsGyroscope;
        }

        static StackObject* CopyToStack_supportsGyroscope_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsGyroscope;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_supportsGyroscope_24(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsGyroscope = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_supportsGyroscope_24(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @supportsGyroscope = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsGyroscope = @supportsGyroscope;
            return ptr_of_this_method;
        }

        static object get_supportsImageEffects_25(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsImageEffects;
        }

        static StackObject* CopyToStack_supportsImageEffects_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsImageEffects;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_supportsImageEffects_25(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsImageEffects = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_supportsImageEffects_25(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @supportsImageEffects = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsImageEffects = @supportsImageEffects;
            return ptr_of_this_method;
        }

        static object get_supportsLocationService_26(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsLocationService;
        }

        static StackObject* CopyToStack_supportsLocationService_26(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsLocationService;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_supportsLocationService_26(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsLocationService = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_supportsLocationService_26(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @supportsLocationService = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsLocationService = @supportsLocationService;
            return ptr_of_this_method;
        }

        static object get_supportsMotionVectors_27(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsMotionVectors;
        }

        static StackObject* CopyToStack_supportsMotionVectors_27(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsMotionVectors;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_supportsMotionVectors_27(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsMotionVectors = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_supportsMotionVectors_27(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @supportsMotionVectors = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsMotionVectors = @supportsMotionVectors;
            return ptr_of_this_method;
        }

        static object get_supportsVibration_28(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsVibration;
        }

        static StackObject* CopyToStack_supportsVibration_28(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsVibration;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_supportsVibration_28(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsVibration = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_supportsVibration_28(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @supportsVibration = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).supportsVibration = @supportsVibration;
            return ptr_of_this_method;
        }

        static object get_systemMemorySize_29(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).systemMemorySize;
        }

        static StackObject* CopyToStack_systemMemorySize_29(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).systemMemorySize;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_systemMemorySize_29(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).systemMemorySize = (System.Int32)v;
        }

        static StackObject* AssignFromStack_systemMemorySize_29(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @systemMemorySize = ptr_of_this_method->Value;
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).systemMemorySize = @systemMemorySize;
            return ptr_of_this_method;
        }

        static object get_unsupportedIdentifier_30(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).unsupportedIdentifier;
        }

        static StackObject* CopyToStack_unsupportedIdentifier_30(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).unsupportedIdentifier;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_unsupportedIdentifier_30(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).unsupportedIdentifier = (System.String)v;
        }

        static StackObject* AssignFromStack_unsupportedIdentifier_30(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @unsupportedIdentifier = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo)o).unsupportedIdentifier = @unsupportedIdentifier;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODAPI.Runtime.DeviceInfo();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
