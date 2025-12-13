#if XR_HAND
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Assertions;
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
    unsafe class Phantom_XRMOD_XRMODInput_Runtime_CustomGestureData_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData);

            field = type.GetField("GestureHandOrPose", flag);
            app.RegisterCLRFieldGetter(field, get_GestureHandOrPose_0);
            app.RegisterCLRFieldSetter(field, set_GestureHandOrPose_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_GestureHandOrPose_0, AssignFromStack_GestureHandOrPose_0);
            field = type.GetField("MinimumHoldTime", flag);
            app.RegisterCLRFieldGetter(field, get_MinimumHoldTime_1);
            app.RegisterCLRFieldSetter(field, set_MinimumHoldTime_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_MinimumHoldTime_1, AssignFromStack_MinimumHoldTime_1);
            field = type.GetField("GestureDetectionInterval", flag);
            app.RegisterCLRFieldGetter(field, get_GestureDetectionInterval_2);
            app.RegisterCLRFieldSetter(field, set_GestureDetectionInterval_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_GestureDetectionInterval_2, AssignFromStack_GestureDetectionInterval_2);
            field = type.GetField("OnPerformed", flag);
            app.RegisterCLRFieldGetter(field, get_OnPerformed_3);
            app.RegisterCLRFieldSetter(field, set_OnPerformed_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnPerformed_3, AssignFromStack_OnPerformed_3);
            field = type.GetField("OnEnded", flag);
            app.RegisterCLRFieldGetter(field, get_OnEnded_4);
            app.RegisterCLRFieldSetter(field, set_OnEnded_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnEnded_4, AssignFromStack_OnEnded_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_GestureHandOrPose_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).GestureHandOrPose;
        }

        static StackObject* CopyToStack_GestureHandOrPose_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).GestureHandOrPose;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_GestureHandOrPose_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).GestureHandOrPose = (UnityEngine.ScriptableObject)v;
        }

        static StackObject* AssignFromStack_GestureHandOrPose_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.ScriptableObject @GestureHandOrPose = (UnityEngine.ScriptableObject)typeof(UnityEngine.ScriptableObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).GestureHandOrPose = @GestureHandOrPose;
            return ptr_of_this_method;
        }

        static object get_MinimumHoldTime_1(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).MinimumHoldTime;
        }

        static StackObject* CopyToStack_MinimumHoldTime_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).MinimumHoldTime;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MinimumHoldTime_1(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).MinimumHoldTime = (System.Single)v;
        }

        static StackObject* AssignFromStack_MinimumHoldTime_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @MinimumHoldTime = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).MinimumHoldTime = @MinimumHoldTime;
            return ptr_of_this_method;
        }

        static object get_GestureDetectionInterval_2(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).GestureDetectionInterval;
        }

        static StackObject* CopyToStack_GestureDetectionInterval_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).GestureDetectionInterval;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_GestureDetectionInterval_2(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).GestureDetectionInterval = (System.Single)v;
        }

        static StackObject* AssignFromStack_GestureDetectionInterval_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @GestureDetectionInterval = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).GestureDetectionInterval = @GestureDetectionInterval;
            return ptr_of_this_method;
        }

        static object get_OnPerformed_3(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).OnPerformed;
        }

        static StackObject* CopyToStack_OnPerformed_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).OnPerformed;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnPerformed_3(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).OnPerformed = (UnityEngine.Events.UnityAction)v;
        }

        static StackObject* AssignFromStack_OnPerformed_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityAction @OnPerformed = (UnityEngine.Events.UnityAction)typeof(UnityEngine.Events.UnityAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).OnPerformed = @OnPerformed;
            return ptr_of_this_method;
        }

        static object get_OnEnded_4(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).OnEnded;
        }

        static StackObject* CopyToStack_OnEnded_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).OnEnded;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnEnded_4(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).OnEnded = (UnityEngine.Events.UnityAction)v;
        }

        static StackObject* AssignFromStack_OnEnded_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityAction @OnEnded = (UnityEngine.Events.UnityAction)typeof(UnityEngine.Events.UnityAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)o).OnEnded = @OnEnded;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif