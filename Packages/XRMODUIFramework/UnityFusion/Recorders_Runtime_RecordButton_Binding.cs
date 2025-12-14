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
    unsafe class Recorders_Runtime_RecordButton_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Recorders.Runtime.RecordButton);

            field = type.GetField("maxDuration", flag);
            app.RegisterCLRFieldGetter(field, get_maxDuration_0);
            app.RegisterCLRFieldSetter(field, set_maxDuration_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_maxDuration_0, AssignFromStack_maxDuration_0);
            field = type.GetField("AutoRegisterEvent", flag);
            app.RegisterCLRFieldGetter(field, get_AutoRegisterEvent_1);
            app.RegisterCLRFieldSetter(field, set_AutoRegisterEvent_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_AutoRegisterEvent_1, AssignFromStack_AutoRegisterEvent_1);
            field = type.GetField("countdown", flag);
            app.RegisterCLRFieldGetter(field, get_countdown_2);
            app.RegisterCLRFieldSetter(field, set_countdown_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_countdown_2, AssignFromStack_countdown_2);
            field = type.GetField("OnLongPressStart", flag);
            app.RegisterCLRFieldGetter(field, get_OnLongPressStart_3);
            app.RegisterCLRFieldSetter(field, set_OnLongPressStart_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnLongPressStart_3, AssignFromStack_OnLongPressStart_3);
            field = type.GetField("OnLongPressStop", flag);
            app.RegisterCLRFieldGetter(field, get_OnLongPressStop_4);
            app.RegisterCLRFieldSetter(field, set_OnLongPressStop_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnLongPressStop_4, AssignFromStack_OnLongPressStop_4);
            field = type.GetField("OnClick", flag);
            app.RegisterCLRFieldGetter(field, get_OnClick_5);
            app.RegisterCLRFieldSetter(field, set_OnClick_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnClick_5, AssignFromStack_OnClick_5);
            field = type.GetField("DurationThreshold", flag);
            app.RegisterCLRFieldGetter(field, get_DurationThreshold_6);
            app.RegisterCLRFieldSetter(field, set_DurationThreshold_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_DurationThreshold_6, AssignFromStack_DurationThreshold_6);


            app.RegisterCLRCreateDefaultInstance(type, () => new Recorders.Runtime.RecordButton());
            app.RegisterCLRCreateArrayInstance(type, s => new Recorders.Runtime.RecordButton[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_maxDuration_0(ref object o)
        {
            return ((Recorders.Runtime.RecordButton)o).maxDuration;
        }

        static StackObject* CopyToStack_maxDuration_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Recorders.Runtime.RecordButton)o).maxDuration;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_maxDuration_0(ref object o, object v)
        {
            ((Recorders.Runtime.RecordButton)o).maxDuration = (System.Single)v;
        }

        static StackObject* AssignFromStack_maxDuration_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @maxDuration = *(float*)&ptr_of_this_method->Value;
            ((Recorders.Runtime.RecordButton)o).maxDuration = @maxDuration;
            return ptr_of_this_method;
        }

        static object get_AutoRegisterEvent_1(ref object o)
        {
            return ((Recorders.Runtime.RecordButton)o).AutoRegisterEvent;
        }

        static StackObject* CopyToStack_AutoRegisterEvent_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Recorders.Runtime.RecordButton)o).AutoRegisterEvent;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AutoRegisterEvent_1(ref object o, object v)
        {
            ((Recorders.Runtime.RecordButton)o).AutoRegisterEvent = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AutoRegisterEvent_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AutoRegisterEvent = ptr_of_this_method->Value == 1;
            ((Recorders.Runtime.RecordButton)o).AutoRegisterEvent = @AutoRegisterEvent;
            return ptr_of_this_method;
        }

        static object get_countdown_2(ref object o)
        {
            return ((Recorders.Runtime.RecordButton)o).countdown;
        }

        static StackObject* CopyToStack_countdown_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Recorders.Runtime.RecordButton)o).countdown;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_countdown_2(ref object o, object v)
        {
            ((Recorders.Runtime.RecordButton)o).countdown = (UnityEngine.UI.Image)v;
        }

        static StackObject* AssignFromStack_countdown_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Image @countdown = (UnityEngine.UI.Image)typeof(UnityEngine.UI.Image).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Recorders.Runtime.RecordButton)o).countdown = @countdown;
            return ptr_of_this_method;
        }

        static object get_OnLongPressStart_3(ref object o)
        {
            return ((Recorders.Runtime.RecordButton)o).OnLongPressStart;
        }

        static StackObject* CopyToStack_OnLongPressStart_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Recorders.Runtime.RecordButton)o).OnLongPressStart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnLongPressStart_3(ref object o, object v)
        {
            ((Recorders.Runtime.RecordButton)o).OnLongPressStart = (System.Action)v;
        }

        static StackObject* AssignFromStack_OnLongPressStart_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @OnLongPressStart = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Recorders.Runtime.RecordButton)o).OnLongPressStart = @OnLongPressStart;
            return ptr_of_this_method;
        }

        static object get_OnLongPressStop_4(ref object o)
        {
            return ((Recorders.Runtime.RecordButton)o).OnLongPressStop;
        }

        static StackObject* CopyToStack_OnLongPressStop_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Recorders.Runtime.RecordButton)o).OnLongPressStop;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnLongPressStop_4(ref object o, object v)
        {
            ((Recorders.Runtime.RecordButton)o).OnLongPressStop = (System.Action)v;
        }

        static StackObject* AssignFromStack_OnLongPressStop_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @OnLongPressStop = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Recorders.Runtime.RecordButton)o).OnLongPressStop = @OnLongPressStop;
            return ptr_of_this_method;
        }

        static object get_OnClick_5(ref object o)
        {
            return ((Recorders.Runtime.RecordButton)o).OnClick;
        }

        static StackObject* CopyToStack_OnClick_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Recorders.Runtime.RecordButton)o).OnClick;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnClick_5(ref object o, object v)
        {
            ((Recorders.Runtime.RecordButton)o).OnClick = (System.Action)v;
        }

        static StackObject* AssignFromStack_OnClick_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @OnClick = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Recorders.Runtime.RecordButton)o).OnClick = @OnClick;
            return ptr_of_this_method;
        }

        static object get_DurationThreshold_6(ref object o)
        {
            return ((Recorders.Runtime.RecordButton)o).DurationThreshold;
        }

        static StackObject* CopyToStack_DurationThreshold_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Recorders.Runtime.RecordButton)o).DurationThreshold;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_DurationThreshold_6(ref object o, object v)
        {
            ((Recorders.Runtime.RecordButton)o).DurationThreshold = (System.Single)v;
        }

        static StackObject* AssignFromStack_DurationThreshold_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @DurationThreshold = *(float*)&ptr_of_this_method->Value;
            ((Recorders.Runtime.RecordButton)o).DurationThreshold = @DurationThreshold;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Recorders.Runtime.RecordButton();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
