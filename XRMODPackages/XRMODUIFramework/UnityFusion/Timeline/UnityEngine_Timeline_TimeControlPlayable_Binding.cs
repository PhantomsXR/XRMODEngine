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
    unsafe class UnityEngine_Timeline_TimeControlPlayable_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Timeline.TimeControlPlayable);
            args = new Type[]{typeof(UnityEngine.Playables.PlayableGraph), typeof(UnityEngine.Timeline.ITimeControl)};
            method = type.GetMethod("Create", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Create_0);
            args = new Type[]{typeof(UnityEngine.Timeline.ITimeControl)};
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_1);
            args = new Type[]{typeof(UnityEngine.Playables.Playable), typeof(UnityEngine.Playables.FrameData)};
            method = type.GetMethod("PrepareFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PrepareFrame_2);
            args = new Type[]{typeof(UnityEngine.Playables.Playable), typeof(UnityEngine.Playables.FrameData)};
            method = type.GetMethod("OnBehaviourPlay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnBehaviourPlay_3);
            args = new Type[]{typeof(UnityEngine.Playables.Playable), typeof(UnityEngine.Playables.FrameData)};
            method = type.GetMethod("OnBehaviourPause", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnBehaviourPause_4);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Timeline.TimeControlPlayable());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Timeline.TimeControlPlayable[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Create_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.ITimeControl @timeControl = (UnityEngine.Timeline.ITimeControl)typeof(UnityEngine.Timeline.ITimeControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableGraph @graph = (UnityEngine.Playables.PlayableGraph)typeof(UnityEngine.Playables.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Timeline.TimeControlPlayable.Create(@graph, @timeControl);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Initialize_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.ITimeControl @timeControl = (UnityEngine.Timeline.ITimeControl)typeof(UnityEngine.Timeline.ITimeControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimeControlPlayable instance_of_this_method = (UnityEngine.Timeline.TimeControlPlayable)typeof(UnityEngine.Timeline.TimeControlPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialize(@timeControl);

            return __ret;
        }

        static StackObject* PrepareFrame_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            UnityEngine.Timeline.TimeControlPlayable instance_of_this_method = (UnityEngine.Timeline.TimeControlPlayable)typeof(UnityEngine.Timeline.TimeControlPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PrepareFrame(@playable, @info);

            return __ret;
        }

        static StackObject* OnBehaviourPlay_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            UnityEngine.Timeline.TimeControlPlayable instance_of_this_method = (UnityEngine.Timeline.TimeControlPlayable)typeof(UnityEngine.Timeline.TimeControlPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnBehaviourPlay(@playable, @info);

            return __ret;
        }

        static StackObject* OnBehaviourPause_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            UnityEngine.Timeline.TimeControlPlayable instance_of_this_method = (UnityEngine.Timeline.TimeControlPlayable)typeof(UnityEngine.Timeline.TimeControlPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnBehaviourPause(@playable, @info);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Timeline.TimeControlPlayable();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif