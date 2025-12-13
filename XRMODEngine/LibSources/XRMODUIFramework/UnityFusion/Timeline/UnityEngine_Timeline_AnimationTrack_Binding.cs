#if USE_TIMELINE
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
    unsafe class UnityEngine_Timeline_AnimationTrack_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Timeline.AnimationTrack);
            args = new Type[]{};
            method = type.GetMethod("get_position", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_position_0);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_position", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_position_1);
            args = new Type[]{};
            method = type.GetMethod("get_rotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rotation_2);
            args = new Type[]{typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("set_rotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rotation_3);
            args = new Type[]{};
            method = type.GetMethod("get_eulerAngles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_eulerAngles_4);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_eulerAngles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_eulerAngles_5);
            args = new Type[]{};
            method = type.GetMethod("get_trackOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_trackOffset_6);
            args = new Type[]{typeof(UnityEngine.Timeline.TrackOffset)};
            method = type.GetMethod("set_trackOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_trackOffset_7);
            args = new Type[]{};
            method = type.GetMethod("get_matchTargetFields", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_matchTargetFields_8);
            args = new Type[]{typeof(UnityEngine.Timeline.MatchTargetFields)};
            method = type.GetMethod("set_matchTargetFields", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_matchTargetFields_9);
            args = new Type[]{};
            method = type.GetMethod("get_infiniteClip", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_infiniteClip_10);
            args = new Type[]{};
            method = type.GetMethod("get_avatarMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_avatarMask_11);
            args = new Type[]{typeof(UnityEngine.AvatarMask)};
            method = type.GetMethod("set_avatarMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_avatarMask_12);
            args = new Type[]{};
            method = type.GetMethod("get_applyAvatarMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_applyAvatarMask_13);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_applyAvatarMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_applyAvatarMask_14);
            args = new Type[]{};
            method = type.GetMethod("get_outputs", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_outputs_15);
            args = new Type[]{};
            method = type.GetMethod("get_inClipMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inClipMode_16);
            args = new Type[]{};
            method = type.GetMethod("get_infiniteClipOffsetPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_infiniteClipOffsetPosition_17);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_infiniteClipOffsetPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_infiniteClipOffsetPosition_18);
            args = new Type[]{};
            method = type.GetMethod("get_infiniteClipOffsetRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_infiniteClipOffsetRotation_19);
            args = new Type[]{typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("set_infiniteClipOffsetRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_infiniteClipOffsetRotation_20);
            args = new Type[]{};
            method = type.GetMethod("get_infiniteClipOffsetEulerAngles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_infiniteClipOffsetEulerAngles_21);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_infiniteClipOffsetEulerAngles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_infiniteClipOffsetEulerAngles_22);
            args = new Type[]{};
            method = type.GetMethod("get_infiniteClipPreExtrapolation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_infiniteClipPreExtrapolation_23);
            args = new Type[]{typeof(UnityEngine.Timeline.TimelineClip.ClipExtrapolation)};
            method = type.GetMethod("set_infiniteClipPreExtrapolation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_infiniteClipPreExtrapolation_24);
            args = new Type[]{};
            method = type.GetMethod("get_infiniteClipPostExtrapolation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_infiniteClipPostExtrapolation_25);
            args = new Type[]{typeof(UnityEngine.Timeline.TimelineClip.ClipExtrapolation)};
            method = type.GetMethod("set_infiniteClipPostExtrapolation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_infiniteClipPostExtrapolation_26);
            args = new Type[]{typeof(UnityEngine.AnimationClip)};
            method = type.GetMethod("CreateClip", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateClip_27);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("CreateInfiniteClip", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateInfiniteClip_28);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("CreateRecordableClip", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateRecordableClip_29);
            args = new Type[]{typeof(UnityEngine.Playables.PlayableDirector), typeof(UnityEngine.Timeline.IPropertyCollector)};
            method = type.GetMethod("GatherProperties", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GatherProperties_30);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Timeline.AnimationTrack());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Timeline.AnimationTrack[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_position_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.position;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_position_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.position = value;

            return __ret;
        }

        static StackObject* get_rotation_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rotation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rotation_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @value = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rotation = value;

            return __ret;
        }

        static StackObject* get_eulerAngles_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.eulerAngles;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_eulerAngles_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.eulerAngles = value;

            return __ret;
        }

        static StackObject* get_trackOffset_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.trackOffset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_trackOffset_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TrackOffset @value = (UnityEngine.Timeline.TrackOffset)typeof(UnityEngine.Timeline.TrackOffset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trackOffset = value;

            return __ret;
        }

        static StackObject* get_matchTargetFields_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.matchTargetFields;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_matchTargetFields_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.MatchTargetFields @value = (UnityEngine.Timeline.MatchTargetFields)typeof(UnityEngine.Timeline.MatchTargetFields).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.matchTargetFields = value;

            return __ret;
        }

        static StackObject* get_infiniteClip_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.infiniteClip;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_avatarMask_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.avatarMask;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_avatarMask_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AvatarMask @value = (UnityEngine.AvatarMask)typeof(UnityEngine.AvatarMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.avatarMask = value;

            return __ret;
        }

        static StackObject* get_applyAvatarMask_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.applyAvatarMask;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_applyAvatarMask_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.applyAvatarMask = value;

            return __ret;
        }

        static StackObject* get_outputs_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.outputs;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_inClipMode_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.inClipMode;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_infiniteClipOffsetPosition_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.infiniteClipOffsetPosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_infiniteClipOffsetPosition_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.infiniteClipOffsetPosition = value;

            return __ret;
        }

        static StackObject* get_infiniteClipOffsetRotation_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.infiniteClipOffsetRotation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_infiniteClipOffsetRotation_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @value = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.infiniteClipOffsetRotation = value;

            return __ret;
        }

        static StackObject* get_infiniteClipOffsetEulerAngles_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.infiniteClipOffsetEulerAngles;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_infiniteClipOffsetEulerAngles_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.infiniteClipOffsetEulerAngles = value;

            return __ret;
        }

        static StackObject* get_infiniteClipPreExtrapolation_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.infiniteClipPreExtrapolation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_infiniteClipPreExtrapolation_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip.ClipExtrapolation @value = (UnityEngine.Timeline.TimelineClip.ClipExtrapolation)typeof(UnityEngine.Timeline.TimelineClip.ClipExtrapolation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.infiniteClipPreExtrapolation = value;

            return __ret;
        }

        static StackObject* get_infiniteClipPostExtrapolation_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.infiniteClipPostExtrapolation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_infiniteClipPostExtrapolation_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip.ClipExtrapolation @value = (UnityEngine.Timeline.TimelineClip.ClipExtrapolation)typeof(UnityEngine.Timeline.TimelineClip.ClipExtrapolation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.infiniteClipPostExtrapolation = value;

            return __ret;
        }

        static StackObject* CreateClip_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationClip @clip = (UnityEngine.AnimationClip)typeof(UnityEngine.AnimationClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreateClip(@clip);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateInfiniteClip_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @infiniteClipName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CreateInfiniteClip(@infiniteClipName);

            return __ret;
        }

        static StackObject* CreateRecordableClip_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @animClipName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreateRecordableClip(@animClipName);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GatherProperties_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.IPropertyCollector @driver = (UnityEngine.Timeline.IPropertyCollector)typeof(UnityEngine.Timeline.IPropertyCollector).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector @director = (UnityEngine.Playables.PlayableDirector)typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Timeline.AnimationTrack instance_of_this_method = (UnityEngine.Timeline.AnimationTrack)typeof(UnityEngine.Timeline.AnimationTrack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GatherProperties(@director, @driver);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Timeline.AnimationTrack();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif