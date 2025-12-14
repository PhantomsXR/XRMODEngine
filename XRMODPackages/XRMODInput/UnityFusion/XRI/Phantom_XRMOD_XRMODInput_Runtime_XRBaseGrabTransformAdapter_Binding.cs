#if USE_XRI

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
    unsafe class Phantom_XRMOD_XRMODInput_Runtime_XRBaseGrabTransformAdapter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)};
            method = type.GetMethod("OnLink", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnLink_0);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable), typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase), typeof(UnityEngine.Pose).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType()};
            method = type.GetMethod("Process", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Process_1);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)};
            method = type.GetMethod("OnGrab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnGrab_2);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable), typeof(UnityEngine.Pose), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("OnGrabCountChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnGrabCountChanged_3);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)};
            method = type.GetMethod("OnUnlink", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnUnlink_4);

            field = type.GetField("OnLinkEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnLinkEvent_0);
            app.RegisterCLRFieldSetter(field, set_OnLinkEvent_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnLinkEvent_0, AssignFromStack_OnLinkEvent_0);
            field = type.GetField("OnUnlinkEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnUnlinkEvent_1);
            app.RegisterCLRFieldSetter(field, set_OnUnlinkEvent_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnUnlinkEvent_1, AssignFromStack_OnUnlinkEvent_1);
            field = type.GetField("OnGrabEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnGrabEvent_2);
            app.RegisterCLRFieldSetter(field, set_OnGrabEvent_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnGrabEvent_2, AssignFromStack_OnGrabEvent_2);
            field = type.GetField("OnGrabChanged", flag);
            app.RegisterCLRFieldGetter(field, get_OnGrabChanged_3);
            app.RegisterCLRFieldSetter(field, set_OnGrabChanged_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnGrabChanged_3, AssignFromStack_OnGrabChanged_3);
            field = type.GetField("OnProcessEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnProcessEvent_4);
            app.RegisterCLRFieldSetter(field, set_OnProcessEvent_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnProcessEvent_4, AssignFromStack_OnProcessEvent_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* OnLink_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable @_grabInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnLink(@_grabInteractable);

            return __ret;
        }

        static StackObject* Process_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @_localScale = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Pose @_targetPose = (UnityEngine.Pose)typeof(UnityEngine.Pose).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase @_updatePhase = (UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable @_grabInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            instance_of_this_method.Process(@_grabInteractable, @_updatePhase, ref @_targetPose, ref @_localScale);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @_localScale;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_localScale;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_localScale);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_localScale;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_localScale);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Vector3[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_localScale;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @_targetPose;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_targetPose;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_targetPose);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_targetPose;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_targetPose);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Pose[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_targetPose;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* OnGrab_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable @_grabInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnGrab(@_grabInteractable);

            return __ret;
        }

        static StackObject* OnGrabCountChanged_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @_localScale = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Pose @_targetPose = (UnityEngine.Pose)typeof(UnityEngine.Pose).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable @_grabInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnGrabCountChanged(@_grabInteractable, @_targetPose, @_localScale);

            return __ret;
        }

        static StackObject* OnUnlink_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable @_grabInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnUnlink(@_grabInteractable);

            return __ret;
        }


        static object get_OnLinkEvent_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnLinkEvent;
        }

        static StackObject* CopyToStack_OnLinkEvent_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnLinkEvent;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnLinkEvent_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnLinkEvent = (UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>)v;
        }

        static StackObject* AssignFromStack_OnLinkEvent_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable> @OnLinkEvent = (UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>)typeof(UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnLinkEvent = @OnLinkEvent;
            return ptr_of_this_method;
        }

        static object get_OnUnlinkEvent_1(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnUnlinkEvent;
        }

        static StackObject* CopyToStack_OnUnlinkEvent_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnUnlinkEvent;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnUnlinkEvent_1(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnUnlinkEvent = (UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>)v;
        }

        static StackObject* AssignFromStack_OnUnlinkEvent_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable> @OnUnlinkEvent = (UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>)typeof(UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnUnlinkEvent = @OnUnlinkEvent;
            return ptr_of_this_method;
        }

        static object get_OnGrabEvent_2(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnGrabEvent;
        }

        static StackObject* CopyToStack_OnGrabEvent_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnGrabEvent;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnGrabEvent_2(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnGrabEvent = (UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>)v;
        }

        static StackObject* AssignFromStack_OnGrabEvent_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable> @OnGrabEvent = (UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>)typeof(UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnGrabEvent = @OnGrabEvent;
            return ptr_of_this_method;
        }

        static object get_OnGrabChanged_3(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnGrabChanged;
        }

        static StackObject* CopyToStack_OnGrabChanged_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnGrabChanged;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnGrabChanged_3(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnGrabChanged = (UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable, Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper, Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper>)v;
        }

        static StackObject* AssignFromStack_OnGrabChanged_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable, Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper, Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper> @OnGrabChanged = (UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable, Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper, Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper>)typeof(UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable, Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper, Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnGrabChanged = @OnGrabChanged;
            return ptr_of_this_method;
        }

        static object get_OnProcessEvent_4(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnProcessEvent;
        }

        static StackObject* CopyToStack_OnProcessEvent_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnProcessEvent;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnProcessEvent_4(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnProcessEvent = (UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable, UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase, Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper, Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper>)v;
        }

        static StackObject* AssignFromStack_OnProcessEvent_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable, UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase, Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper, Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper> @OnProcessEvent = (UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable, UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase, Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper, Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper>)typeof(UnityEngine.Events.UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable, UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase, Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper, Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter)o).OnProcessEvent = @OnProcessEvent;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODInput.Runtime.XRBaseGrabTransformAdapter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif