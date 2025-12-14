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
    unsafe class UnityEngine_Timeline_ActivationControlPlayable_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Timeline.ActivationControlPlayable);
            args = new Type[]{typeof(UnityEngine.Playables.PlayableGraph), typeof(UnityEngine.GameObject), typeof(UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState)};
            method = type.GetMethod("Create", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Create_0);
            args = new Type[]{typeof(UnityEngine.Playables.Playable), typeof(UnityEngine.Playables.FrameData)};
            method = type.GetMethod("OnBehaviourPlay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnBehaviourPlay_1);
            args = new Type[]{typeof(UnityEngine.Playables.Playable), typeof(UnityEngine.Playables.FrameData)};
            method = type.GetMethod("OnBehaviourPause", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnBehaviourPause_2);
            args = new Type[]{typeof(UnityEngine.Playables.Playable), typeof(UnityEngine.Playables.FrameData), typeof(System.Object)};
            method = type.GetMethod("ProcessFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ProcessFrame_3);
            args = new Type[]{typeof(UnityEngine.Playables.Playable)};
            method = type.GetMethod("OnGraphStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnGraphStart_4);
            args = new Type[]{typeof(UnityEngine.Playables.Playable)};
            method = type.GetMethod("OnPlayableDestroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnPlayableDestroy_5);

            field = type.GetField("gameObject", flag);
            app.RegisterCLRFieldGetter(field, get_gameObject_0);
            app.RegisterCLRFieldSetter(field, set_gameObject_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_gameObject_0, AssignFromStack_gameObject_0);
            field = type.GetField("postPlayback", flag);
            app.RegisterCLRFieldGetter(field, get_postPlayback_1);
            app.RegisterCLRFieldSetter(field, set_postPlayback_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_postPlayback_1, AssignFromStack_postPlayback_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Timeline.ActivationControlPlayable());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Timeline.ActivationControlPlayable[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Create_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState @postPlaybackState = (UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState)typeof(UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @gameObject = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Playables.PlayableGraph @graph = (UnityEngine.Playables.PlayableGraph)typeof(UnityEngine.Playables.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Timeline.ActivationControlPlayable.Create(@graph, @gameObject, @postPlaybackState);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OnBehaviourPlay_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.FrameData @info = (UnityEngine.Playables.FrameData)typeof(UnityEngine.Playables.FrameData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.Playable @playable = (UnityEngine.Playables.Playable)typeof(UnityEngine.Playables.Playable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Timeline.ActivationControlPlayable instance_of_this_method = (UnityEngine.Timeline.ActivationControlPlayable)typeof(UnityEngine.Timeline.ActivationControlPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnBehaviourPlay(@playable, @info);

            return __ret;
        }

        static StackObject* OnBehaviourPause_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.FrameData @info = (UnityEngine.Playables.FrameData)typeof(UnityEngine.Playables.FrameData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.Playable @playable = (UnityEngine.Playables.Playable)typeof(UnityEngine.Playables.Playable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Timeline.ActivationControlPlayable instance_of_this_method = (UnityEngine.Timeline.ActivationControlPlayable)typeof(UnityEngine.Timeline.ActivationControlPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnBehaviourPause(@playable, @info);

            return __ret;
        }

        static StackObject* ProcessFrame_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @userData = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.FrameData @info = (UnityEngine.Playables.FrameData)typeof(UnityEngine.Playables.FrameData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Playables.Playable @playable = (UnityEngine.Playables.Playable)typeof(UnityEngine.Playables.Playable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Timeline.ActivationControlPlayable instance_of_this_method = (UnityEngine.Timeline.ActivationControlPlayable)typeof(UnityEngine.Timeline.ActivationControlPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ProcessFrame(@playable, @info, @userData);

            return __ret;
        }

        static StackObject* OnGraphStart_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.Playable @playable = (UnityEngine.Playables.Playable)typeof(UnityEngine.Playables.Playable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.ActivationControlPlayable instance_of_this_method = (UnityEngine.Timeline.ActivationControlPlayable)typeof(UnityEngine.Timeline.ActivationControlPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnGraphStart(@playable);

            return __ret;
        }

        static StackObject* OnPlayableDestroy_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.Playable @playable = (UnityEngine.Playables.Playable)typeof(UnityEngine.Playables.Playable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.ActivationControlPlayable instance_of_this_method = (UnityEngine.Timeline.ActivationControlPlayable)typeof(UnityEngine.Timeline.ActivationControlPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnPlayableDestroy(@playable);

            return __ret;
        }


        static object get_gameObject_0(ref object o)
        {
            return ((UnityEngine.Timeline.ActivationControlPlayable)o).gameObject;
        }

        static StackObject* CopyToStack_gameObject_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Timeline.ActivationControlPlayable)o).gameObject;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_gameObject_0(ref object o, object v)
        {
            ((UnityEngine.Timeline.ActivationControlPlayable)o).gameObject = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_gameObject_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @gameObject = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((UnityEngine.Timeline.ActivationControlPlayable)o).gameObject = @gameObject;
            return ptr_of_this_method;
        }

        static object get_postPlayback_1(ref object o)
        {
            return ((UnityEngine.Timeline.ActivationControlPlayable)o).postPlayback;
        }

        static StackObject* CopyToStack_postPlayback_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Timeline.ActivationControlPlayable)o).postPlayback;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_postPlayback_1(ref object o, object v)
        {
            ((UnityEngine.Timeline.ActivationControlPlayable)o).postPlayback = (UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState)v;
        }

        static StackObject* AssignFromStack_postPlayback_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState @postPlayback = (UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState)typeof(UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((UnityEngine.Timeline.ActivationControlPlayable)o).postPlayback = @postPlayback;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Timeline.ActivationControlPlayable();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif