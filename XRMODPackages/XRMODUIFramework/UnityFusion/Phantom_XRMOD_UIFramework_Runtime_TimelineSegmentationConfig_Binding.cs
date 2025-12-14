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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_TimelineSegmentationConfig_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig);

            field = type.GetField("SegmentationName", flag);
            app.RegisterCLRFieldGetter(field, get_SegmentationName_0);
            app.RegisterCLRFieldSetter(field, set_SegmentationName_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_SegmentationName_0, AssignFromStack_SegmentationName_0);
            field = type.GetField("SegmentationStartTime", flag);
            app.RegisterCLRFieldGetter(field, get_SegmentationStartTime_1);
            app.RegisterCLRFieldSetter(field, set_SegmentationStartTime_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_SegmentationStartTime_1, AssignFromStack_SegmentationStartTime_1);
            field = type.GetField("SegmentationDuration", flag);
            app.RegisterCLRFieldGetter(field, get_SegmentationDuration_2);
            app.RegisterCLRFieldSetter(field, set_SegmentationDuration_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_SegmentationDuration_2, AssignFromStack_SegmentationDuration_2);
            field = type.GetField("OnStart", flag);
            app.RegisterCLRFieldGetter(field, get_OnStart_3);
            app.RegisterCLRFieldSetter(field, set_OnStart_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnStart_3, AssignFromStack_OnStart_3);
            field = type.GetField("OnPlaying", flag);
            app.RegisterCLRFieldGetter(field, get_OnPlaying_4);
            app.RegisterCLRFieldSetter(field, set_OnPlaying_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnPlaying_4, AssignFromStack_OnPlaying_4);
            field = type.GetField("OnCompleted", flag);
            app.RegisterCLRFieldGetter(field, get_OnCompleted_5);
            app.RegisterCLRFieldSetter(field, set_OnCompleted_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnCompleted_5, AssignFromStack_OnCompleted_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_SegmentationName_0(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).SegmentationName;
        }

        static StackObject* CopyToStack_SegmentationName_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).SegmentationName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SegmentationName_0(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).SegmentationName = (System.String)v;
        }

        static StackObject* AssignFromStack_SegmentationName_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @SegmentationName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).SegmentationName = @SegmentationName;
            return ptr_of_this_method;
        }

        static object get_SegmentationStartTime_1(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).SegmentationStartTime;
        }

        static StackObject* CopyToStack_SegmentationStartTime_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).SegmentationStartTime;
            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_SegmentationStartTime_1(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).SegmentationStartTime = (System.Double)v;
        }

        static StackObject* AssignFromStack_SegmentationStartTime_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Double @SegmentationStartTime = *(double*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).SegmentationStartTime = @SegmentationStartTime;
            return ptr_of_this_method;
        }

        static object get_SegmentationDuration_2(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).SegmentationDuration;
        }

        static StackObject* CopyToStack_SegmentationDuration_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).SegmentationDuration;
            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_SegmentationDuration_2(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).SegmentationDuration = (System.Double)v;
        }

        static StackObject* AssignFromStack_SegmentationDuration_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Double @SegmentationDuration = *(double*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).SegmentationDuration = @SegmentationDuration;
            return ptr_of_this_method;
        }

        static object get_OnStart_3(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).OnStart;
        }

        static StackObject* CopyToStack_OnStart_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).OnStart;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnStart_3(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).OnStart = (UnityEngine.Events.UnityEvent)v;
        }

        static StackObject* AssignFromStack_OnStart_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @OnStart = (UnityEngine.Events.UnityEvent)typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).OnStart = @OnStart;
            return ptr_of_this_method;
        }

        static object get_OnPlaying_4(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).OnPlaying;
        }

        static StackObject* CopyToStack_OnPlaying_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).OnPlaying;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnPlaying_4(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).OnPlaying = (UnityEngine.Events.UnityEvent)v;
        }

        static StackObject* AssignFromStack_OnPlaying_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @OnPlaying = (UnityEngine.Events.UnityEvent)typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).OnPlaying = @OnPlaying;
            return ptr_of_this_method;
        }

        static object get_OnCompleted_5(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).OnCompleted;
        }

        static StackObject* CopyToStack_OnCompleted_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).OnCompleted;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnCompleted_5(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).OnCompleted = (UnityEngine.Events.UnityEvent)v;
        }

        static StackObject* AssignFromStack_OnCompleted_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @OnCompleted = (UnityEngine.Events.UnityEvent)typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig)o).OnCompleted = @OnCompleted;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.UIFramework.Runtime.TimelineSegmentationConfig();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif