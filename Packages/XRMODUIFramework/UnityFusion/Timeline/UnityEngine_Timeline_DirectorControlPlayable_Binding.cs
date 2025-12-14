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
    unsafe class UnityEngine_Timeline_DirectorControlPlayable_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Timeline.DirectorControlPlayable);
            args = new Type[]{typeof(UnityEngine.Playables.PlayableGraph), typeof(UnityEngine.Playables.PlayableDirector)};
            method = type.GetMethod("Create", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Create_0);
            args = new Type[]{typeof(UnityEngine.Playables.Playable)};
            method = type.GetMethod("OnPlayableDestroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnPlayableDestroy_1);
            args = new Type[]{typeof(UnityEngine.Playables.Playable), typeof(UnityEngine.Playables.FrameData)};
            method = type.GetMethod("PrepareFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PrepareFrame_2);
            args = new Type[]{typeof(UnityEngine.Playables.Playable), typeof(UnityEngine.Playables.FrameData)};
            method = type.GetMethod("OnBehaviourPlay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnBehaviourPlay_3);
            args = new Type[]{typeof(UnityEngine.Playables.Playable), typeof(UnityEngine.Playables.FrameData)};
            method = type.GetMethod("OnBehaviourPause", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnBehaviourPause_4);
            args = new Type[]{typeof(UnityEngine.Playables.Playable), typeof(UnityEngine.Playables.FrameData), typeof(System.Object)};
            method = type.GetMethod("ProcessFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ProcessFrame_5);

            field = type.GetField("director", flag);
            app.RegisterCLRFieldGetter(field, get_director_0);
            app.RegisterCLRFieldSetter(field, set_director_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_director_0, AssignFromStack_director_0);
            field = type.GetField("pauseAction", flag);
            app.RegisterCLRFieldGetter(field, get_pauseAction_1);
            app.RegisterCLRFieldSetter(field, set_pauseAction_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_pauseAction_1, AssignFromStack_pauseAction_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Timeline.DirectorControlPlayable());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Timeline.DirectorControlPlayable[s]);

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
            UnityEngine.Playables.PlayableDirector @director = (UnityEngine.Playables.PlayableDirector)typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableGraph @graph = (UnityEngine.Playables.PlayableGraph)typeof(UnityEngine.Playables.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Timeline.DirectorControlPlayable.Create(@graph, @director);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OnPlayableDestroy_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Playables.Playable @playable = (UnityEngine.Playables.Playable)typeof(UnityEngine.Playables.Playable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.DirectorControlPlayable instance_of_this_method = (UnityEngine.Timeline.DirectorControlPlayable)typeof(UnityEngine.Timeline.DirectorControlPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnPlayableDestroy(@playable);

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
            UnityEngine.Timeline.DirectorControlPlayable instance_of_this_method = (UnityEngine.Timeline.DirectorControlPlayable)typeof(UnityEngine.Timeline.DirectorControlPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
            UnityEngine.Timeline.DirectorControlPlayable instance_of_this_method = (UnityEngine.Timeline.DirectorControlPlayable)typeof(UnityEngine.Timeline.DirectorControlPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
            UnityEngine.Timeline.DirectorControlPlayable instance_of_this_method = (UnityEngine.Timeline.DirectorControlPlayable)typeof(UnityEngine.Timeline.DirectorControlPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnBehaviourPause(@playable, @info);

            return __ret;
        }

        static StackObject* ProcessFrame_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @playerData = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.FrameData @info = (UnityEngine.Playables.FrameData)typeof(UnityEngine.Playables.FrameData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Playables.Playable @playable = (UnityEngine.Playables.Playable)typeof(UnityEngine.Playables.Playable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Timeline.DirectorControlPlayable instance_of_this_method = (UnityEngine.Timeline.DirectorControlPlayable)typeof(UnityEngine.Timeline.DirectorControlPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ProcessFrame(@playable, @info, @playerData);

            return __ret;
        }


        static object get_director_0(ref object o)
        {
            return ((UnityEngine.Timeline.DirectorControlPlayable)o).director;
        }

        static StackObject* CopyToStack_director_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Timeline.DirectorControlPlayable)o).director;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_director_0(ref object o, object v)
        {
            ((UnityEngine.Timeline.DirectorControlPlayable)o).director = (UnityEngine.Playables.PlayableDirector)v;
        }

        static StackObject* AssignFromStack_director_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Playables.PlayableDirector @director = (UnityEngine.Playables.PlayableDirector)typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((UnityEngine.Timeline.DirectorControlPlayable)o).director = @director;
            return ptr_of_this_method;
        }

        static object get_pauseAction_1(ref object o)
        {
            return ((UnityEngine.Timeline.DirectorControlPlayable)o).pauseAction;
        }

        static StackObject* CopyToStack_pauseAction_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Timeline.DirectorControlPlayable)o).pauseAction;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_pauseAction_1(ref object o, object v)
        {
            ((UnityEngine.Timeline.DirectorControlPlayable)o).pauseAction = (UnityEngine.Timeline.DirectorControlPlayable.PauseAction)v;
        }

        static StackObject* AssignFromStack_pauseAction_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Timeline.DirectorControlPlayable.PauseAction @pauseAction = (UnityEngine.Timeline.DirectorControlPlayable.PauseAction)typeof(UnityEngine.Timeline.DirectorControlPlayable.PauseAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((UnityEngine.Timeline.DirectorControlPlayable)o).pauseAction = @pauseAction;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Timeline.DirectorControlPlayable();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif