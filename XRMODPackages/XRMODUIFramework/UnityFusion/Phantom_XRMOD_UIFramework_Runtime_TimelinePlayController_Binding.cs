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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_TimelinePlayController_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController);
            args = new Type[]{};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_1);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_2);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_3);
            args = new Type[]{};
            method = type.GetMethod("Stop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Stop_4);
            args = new Type[]{};
            method = type.GetMethod("Pause", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Pause_5);

            field = type.GetField("PlayableDirector", flag);
            app.RegisterCLRFieldGetter(field, get_PlayableDirector_0);
            app.RegisterCLRFieldSetter(field, set_PlayableDirector_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayableDirector_0, AssignFromStack_PlayableDirector_0);
            field = type.GetField("TimelineSegmentationConfigs", flag);
            app.RegisterCLRFieldGetter(field, get_TimelineSegmentationConfigs_1);
            app.RegisterCLRFieldSetter(field, set_TimelineSegmentationConfigs_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_TimelineSegmentationConfigs_1, AssignFromStack_TimelineSegmentationConfigs_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Play_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController)typeof(Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play();

            return __ret;
        }

        static StackObject* Play_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_segmentationId = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController)typeof(Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(@_segmentationId);

            return __ret;
        }

        static StackObject* Play_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_segmentationName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController)typeof(Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(@_segmentationName);

            return __ret;
        }

        static StackObject* Play_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig @_segmentationConfig = (Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)typeof(Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController)typeof(Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(@_segmentationConfig);

            return __ret;
        }

        static StackObject* Stop_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController)typeof(Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Stop();

            return __ret;
        }

        static StackObject* Pause_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController)typeof(Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Pause();

            return __ret;
        }


        static object get_PlayableDirector_0(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController)o).PlayableDirector;
        }

        static StackObject* CopyToStack_PlayableDirector_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController)o).PlayableDirector;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlayableDirector_0(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController)o).PlayableDirector = (UnityEngine.Playables.PlayableDirector)v;
        }

        static StackObject* AssignFromStack_PlayableDirector_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Playables.PlayableDirector @PlayableDirector = (UnityEngine.Playables.PlayableDirector)typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController)o).PlayableDirector = @PlayableDirector;
            return ptr_of_this_method;
        }

        static object get_TimelineSegmentationConfigs_1(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController)o).TimelineSegmentationConfigs;
        }

        static StackObject* CopyToStack_TimelineSegmentationConfigs_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController)o).TimelineSegmentationConfigs;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TimelineSegmentationConfigs_1(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController)o).TimelineSegmentationConfigs = (Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig[])v;
        }

        static StackObject* AssignFromStack_TimelineSegmentationConfigs_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig[] @TimelineSegmentationConfigs = (Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig[])typeof(Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController)o).TimelineSegmentationConfigs = @TimelineSegmentationConfigs;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.UIFramework.Runtime.TimelinePlayController();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
