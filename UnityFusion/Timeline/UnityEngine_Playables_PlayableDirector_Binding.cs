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
    unsafe class UnityEngine_Playables_PlayableDirector_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Playables.PlayableDirector);
            args = new Type[] { };
            method = type.GetMethod("get_state", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_state_0);
            args = new Type[] {typeof(UnityEngine.Playables.DirectorWrapMode)};
            method = type.GetMethod("set_extrapolationMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_extrapolationMode_1);
            args = new Type[] { };
            method = type.GetMethod("get_extrapolationMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_extrapolationMode_2);
            args = new Type[] { };
            method = type.GetMethod("get_playableAsset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playableAsset_3);
            args = new Type[] {typeof(UnityEngine.Playables.PlayableAsset)};
            method = type.GetMethod("set_playableAsset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playableAsset_4);
            args = new Type[] { };
            method = type.GetMethod("get_playableGraph", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playableGraph_5);
            args = new Type[] { };
            method = type.GetMethod("get_playOnAwake", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playOnAwake_6);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_playOnAwake", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playOnAwake_7);
            args = new Type[] { };
            method = type.GetMethod("DeferredEvaluate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeferredEvaluate_8);
            args = new Type[] {typeof(UnityEngine.Playables.PlayableAsset)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_9);
            args = new Type[]
                {typeof(UnityEngine.Playables.PlayableAsset), typeof(UnityEngine.Playables.DirectorWrapMode)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_10);
            args = new Type[] {typeof(UnityEngine.Object), typeof(UnityEngine.Object)};
            method = type.GetMethod("SetGenericBinding", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGenericBinding_11);
            args = new Type[] {typeof(UnityEngine.Playables.DirectorUpdateMode)};
            method = type.GetMethod("set_timeUpdateMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_timeUpdateMode_12);
            args = new Type[] { };
            method = type.GetMethod("get_timeUpdateMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_timeUpdateMode_13);
            args = new Type[] {typeof(System.Double)};
            method = type.GetMethod("set_time", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_time_14);
            args = new Type[] { };
            method = type.GetMethod("get_time", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_time_15);
            args = new Type[] {typeof(System.Double)};
            method = type.GetMethod("set_initialTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_initialTime_16);
            args = new Type[] { };
            method = type.GetMethod("get_initialTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_initialTime_17);
            args = new Type[] { };
            method = type.GetMethod("get_duration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_duration_18);
            args = new Type[] { };
            method = type.GetMethod("Evaluate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Evaluate_19);
            args = new Type[] { };
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_20);
            args = new Type[] { };
            method = type.GetMethod("Stop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Stop_21);
            args = new Type[] { };
            method = type.GetMethod("Pause", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Pause_22);
            args = new Type[] { };
            method = type.GetMethod("Resume", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Resume_23);
            args = new Type[] { };
            method = type.GetMethod("RebuildGraph", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RebuildGraph_24);
            args = new Type[] {typeof(UnityEngine.PropertyName)};
            method = type.GetMethod("ClearReferenceValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearReferenceValue_25);
            args = new Type[] {typeof(UnityEngine.PropertyName), typeof(UnityEngine.Object)};
            method = type.GetMethod("SetReferenceValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetReferenceValue_26);
            args = new Type[] {typeof(UnityEngine.PropertyName), typeof(System.Boolean).MakeByRefType()};
            method = type.GetMethod("GetReferenceValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetReferenceValue_27);
            args = new Type[] {typeof(UnityEngine.Object)};
            method = type.GetMethod("GetGenericBinding", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGenericBinding_28);
            args = new Type[] {typeof(UnityEngine.Object)};
            method = type.GetMethod("ClearGenericBinding", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearGenericBinding_29);
            args = new Type[] { };
            method = type.GetMethod("RebindPlayableGraphOutputs", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RebindPlayableGraphOutputs_30);
            args = new Type[] {typeof(System.Action<UnityEngine.Playables.PlayableDirector>)};
            method = type.GetMethod("add_played", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_played_31);
            args = new Type[] {typeof(System.Action<UnityEngine.Playables.PlayableDirector>)};
            method = type.GetMethod("remove_played", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_played_32);
            args = new Type[] {typeof(System.Action<UnityEngine.Playables.PlayableDirector>)};
            method = type.GetMethod("add_paused", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_paused_33);
            args = new Type[] {typeof(System.Action<UnityEngine.Playables.PlayableDirector>)};
            method = type.GetMethod("remove_paused", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_paused_34);
            args = new Type[] {typeof(System.Action<UnityEngine.Playables.PlayableDirector>)};
            method = type.GetMethod("add_stopped", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_stopped_35);
            args = new Type[] {typeof(System.Action<UnityEngine.Playables.PlayableDirector>)};
            method = type.GetMethod("remove_stopped", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_stopped_36);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Playables.PlayableDirector());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Playables.PlayableDirector[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* get_state_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.state;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_extrapolationMode_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.DirectorWrapMode @value =
                (UnityEngine.Playables.DirectorWrapMode) typeof(UnityEngine.Playables.DirectorWrapMode).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.extrapolationMode = value;

            return __ret;
        }

        static StackObject* get_extrapolationMode_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.extrapolationMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_playableAsset_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playableAsset;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_playableAsset_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableAsset @value =
                (UnityEngine.Playables.PlayableAsset) typeof(UnityEngine.Playables.PlayableAsset).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playableAsset = value;

            return __ret;
        }

        static StackObject* get_playableGraph_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playableGraph;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_playOnAwake_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playOnAwake;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_playOnAwake_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playOnAwake = value;

            return __ret;
        }

        static StackObject* DeferredEvaluate_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DeferredEvaluate();

            return __ret;
        }

        static StackObject* Play_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableAsset @asset =
                (UnityEngine.Playables.PlayableAsset) typeof(UnityEngine.Playables.PlayableAsset).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(@asset);

            return __ret;
        }

        static StackObject* Play_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.DirectorWrapMode @mode =
                (UnityEngine.Playables.DirectorWrapMode) typeof(UnityEngine.Playables.DirectorWrapMode).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableAsset @asset =
                (UnityEngine.Playables.PlayableAsset) typeof(UnityEngine.Playables.PlayableAsset).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(@asset, @mode);

            return __ret;
        }

        static StackObject* SetGenericBinding_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Object @value = (UnityEngine.Object) typeof(UnityEngine.Object).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Object @key = (UnityEngine.Object) typeof(UnityEngine.Object).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGenericBinding(@key, @value);

            return __ret;
        }

        static StackObject* set_timeUpdateMode_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.DirectorUpdateMode @value =
                (UnityEngine.Playables.DirectorUpdateMode)
                typeof(UnityEngine.Playables.DirectorUpdateMode).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.timeUpdateMode = value;

            return __ret;
        }

        static StackObject* get_timeUpdateMode_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.timeUpdateMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_time_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @value = *(double*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.time = value;

            return __ret;
        }

        static StackObject* get_time_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.time;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_initialTime_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @value = *(double*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.initialTime = value;

            return __ret;
        }

        static StackObject* get_initialTime_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.initialTime;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_duration_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.duration;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Evaluate_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Evaluate();

            return __ret;
        }

        static StackObject* Play_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play();

            return __ret;
        }

        static StackObject* Stop_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Stop();

            return __ret;
        }

        static StackObject* Pause_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Pause();

            return __ret;
        }

        static StackObject* Resume_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Resume();

            return __ret;
        }

        static StackObject* RebuildGraph_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RebuildGraph();

            return __ret;
        }

        static StackObject* ClearReferenceValue_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PropertyName @id = (UnityEngine.PropertyName) typeof(UnityEngine.PropertyName).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearReferenceValue(@id);

            return __ret;
        }

        static StackObject* SetReferenceValue_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Object @value = (UnityEngine.Object) typeof(UnityEngine.Object).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PropertyName @id = (UnityEngine.PropertyName) typeof(UnityEngine.PropertyName).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetReferenceValue(@id, @value);

            return __ret;
        }

        static StackObject* GetReferenceValue_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @idValid = __intp.RetriveInt32(ptr_of_this_method, __mStack) == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PropertyName @id = (UnityEngine.PropertyName) typeof(UnityEngine.PropertyName).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);

            var result_of_this_method = instance_of_this_method.GetReferenceValue(@id, out @idValid);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    ___dst->ObjectType = ObjectTypes.Integer;
                    ___dst->Value = @idValid ? 1 : 0;
                    ;
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @idValid;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @idValid);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @idValid;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @idValid);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Boolean[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @idValid;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGenericBinding_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Object @key = (UnityEngine.Object) typeof(UnityEngine.Object).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetGenericBinding(@key);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ClearGenericBinding_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Object @key = (UnityEngine.Object) typeof(UnityEngine.Object).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearGenericBinding(@key);

            return __ret;
        }

        static StackObject* RebindPlayableGraphOutputs_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RebindPlayableGraphOutputs();

            return __ret;
        }

        static StackObject* add_played_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Playables.PlayableDirector> @value =
                (System.Action<UnityEngine.Playables.PlayableDirector>)
                typeof(System.Action<UnityEngine.Playables.PlayableDirector>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.played += value;

            return __ret;
        }

        static StackObject* remove_played_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Playables.PlayableDirector> @value =
                (System.Action<UnityEngine.Playables.PlayableDirector>)
                typeof(System.Action<UnityEngine.Playables.PlayableDirector>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.played -= value;

            return __ret;
        }

        static StackObject* add_paused_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Playables.PlayableDirector> @value =
                (System.Action<UnityEngine.Playables.PlayableDirector>)
                typeof(System.Action<UnityEngine.Playables.PlayableDirector>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.paused += value;

            return __ret;
        }

        static StackObject* remove_paused_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Playables.PlayableDirector> @value =
                (System.Action<UnityEngine.Playables.PlayableDirector>)
                typeof(System.Action<UnityEngine.Playables.PlayableDirector>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.paused -= value;

            return __ret;
        }

        static StackObject* add_stopped_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Playables.PlayableDirector> @value =
                (System.Action<UnityEngine.Playables.PlayableDirector>)
                typeof(System.Action<UnityEngine.Playables.PlayableDirector>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.stopped += value;

            return __ret;
        }

        static StackObject* remove_stopped_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Playables.PlayableDirector> @value =
                (System.Action<UnityEngine.Playables.PlayableDirector>)
                typeof(System.Action<UnityEngine.Playables.PlayableDirector>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector instance_of_this_method =
                (UnityEngine.Playables.PlayableDirector) typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.stopped -= value;

            return __ret;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Playables.PlayableDirector();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
#endif