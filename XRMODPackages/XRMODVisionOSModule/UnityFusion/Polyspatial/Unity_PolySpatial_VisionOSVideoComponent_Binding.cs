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
    unsafe class Unity_PolySpatial_VisionOSVideoComponent_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Unity.PolySpatial.VisionOSVideoComponent);
            args = new Type[]{};
            method = type.GetMethod("get_targetMaterialRenderer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_targetMaterialRenderer_0);
            args = new Type[]{typeof(UnityEngine.MeshRenderer)};
            method = type.GetMethod("set_targetMaterialRenderer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_targetMaterialRenderer_1);
            args = new Type[]{};
            method = type.GetMethod("get_clip", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_clip_2);
            args = new Type[]{typeof(UnityEngine.Video.VideoClip)};
            method = type.GetMethod("set_clip", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_clip_3);
            args = new Type[]{};
            method = type.GetMethod("get_isLooping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isLooping_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_isLooping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_isLooping_5);
            args = new Type[]{};
            method = type.GetMethod("get_playOnAwake", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playOnAwake_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_playOnAwake", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playOnAwake_7);
            args = new Type[]{};
            method = type.GetMethod("GetState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetState_8);
            args = new Type[]{};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_9);
            args = new Type[]{};
            method = type.GetMethod("Stop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Stop_10);
            args = new Type[]{};
            method = type.GetMethod("Pause", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Pause_11);
            args = new Type[]{typeof(System.UInt16)};
            method = type.GetMethod("GetDirectAudioMute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDirectAudioMute_12);
            args = new Type[]{typeof(System.UInt16), typeof(System.Boolean)};
            method = type.GetMethod("SetDirectAudioMute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDirectAudioMute_13);
            args = new Type[]{typeof(System.UInt16)};
            method = type.GetMethod("GetDirectAudioVolume", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDirectAudioVolume_14);
            args = new Type[]{typeof(System.UInt16), typeof(System.Single)};
            method = type.GetMethod("SetDirectAudioVolume", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDirectAudioVolume_15);



            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.PolySpatial.VisionOSVideoComponent());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.PolySpatial.VisionOSVideoComponent[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_targetMaterialRenderer_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TargetMaterialRenderer;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_targetMaterialRenderer_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MeshRenderer @value = (UnityEngine.MeshRenderer)typeof(UnityEngine.MeshRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TargetMaterialRenderer = value;

            return __ret;
        }

        static StackObject* get_clip_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Clip;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_clip_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Video.VideoClip @value = (UnityEngine.Video.VideoClip)typeof(UnityEngine.Video.VideoClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clip = value;

            return __ret;
        }

        static StackObject* get_isLooping_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsLooping;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_isLooping_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.IsLooping = value;

            return __ret;
        }

        static StackObject* get_playOnAwake_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PlayOnAwake;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_playOnAwake_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PlayOnAwake = value;

            return __ret;
        }

        static StackObject* GetState_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetState();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Play_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play();

            return __ret;
        }

        static StackObject* Stop_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Stop();

            return __ret;
        }

        static StackObject* Pause_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Pause();

            return __ret;
        }

        static StackObject* GetDirectAudioMute_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 @trackIndex = (ushort)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetDirectAudioMute(@trackIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetDirectAudioMute_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @mute = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt16 @trackIndex = (ushort)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDirectAudioMute(@trackIndex, @mute);

            return __ret;
        }

        static StackObject* GetDirectAudioVolume_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 @trackIndex = (ushort)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetDirectAudioVolume(@trackIndex);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetDirectAudioVolume_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @volume = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt16 @trackIndex = (ushort)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.PolySpatial.VisionOSVideoComponent instance_of_this_method = (Unity.PolySpatial.VisionOSVideoComponent)typeof(Unity.PolySpatial.VisionOSVideoComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDirectAudioVolume(@trackIndex, @volume);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.PolySpatial.VisionOSVideoComponent();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
