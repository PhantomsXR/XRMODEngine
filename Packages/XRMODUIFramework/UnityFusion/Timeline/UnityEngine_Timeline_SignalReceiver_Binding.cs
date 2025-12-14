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
    unsafe class UnityEngine_Timeline_SignalReceiver_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Timeline.SignalReceiver);
            args = new Type[]{typeof(UnityEngine.Playables.Playable), typeof(UnityEngine.Playables.INotification), typeof(System.Object)};
            method = type.GetMethod("OnNotify", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNotify_0);
            args = new Type[]{typeof(UnityEngine.Timeline.SignalAsset), typeof(UnityEngine.Events.UnityEvent)};
            method = type.GetMethod("AddReaction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddReaction_1);
            args = new Type[]{typeof(UnityEngine.Events.UnityEvent)};
            method = type.GetMethod("AddEmptyReaction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddEmptyReaction_2);
            args = new Type[]{typeof(UnityEngine.Timeline.SignalAsset)};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_3);
            args = new Type[]{};
            method = type.GetMethod("GetRegisteredSignals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRegisteredSignals_4);
            args = new Type[]{typeof(UnityEngine.Timeline.SignalAsset)};
            method = type.GetMethod("GetReaction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetReaction_5);
            args = new Type[]{};
            method = type.GetMethod("Count", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Count_6);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Timeline.SignalAsset)};
            method = type.GetMethod("ChangeSignalAtIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ChangeSignalAtIndex_7);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("RemoveAtIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveAtIndex_8);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Events.UnityEvent)};
            method = type.GetMethod("ChangeReactionAtIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ChangeReactionAtIndex_9);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetReactionAtIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetReactionAtIndex_10);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetSignalAssetAtIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSignalAssetAtIndex_11);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Timeline.SignalReceiver());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Timeline.SignalReceiver[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* OnNotify_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @context = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.INotification @notification = (UnityEngine.Playables.INotification)typeof(UnityEngine.Playables.INotification).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Playables.Playable @origin = (UnityEngine.Playables.Playable)typeof(UnityEngine.Playables.Playable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Timeline.SignalReceiver instance_of_this_method = (UnityEngine.Timeline.SignalReceiver)typeof(UnityEngine.Timeline.SignalReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNotify(@origin, @notification, @context);

            return __ret;
        }

        static StackObject* AddReaction_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Events.UnityEvent @reaction = (UnityEngine.Events.UnityEvent)typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.SignalAsset @asset = (UnityEngine.Timeline.SignalAsset)typeof(UnityEngine.Timeline.SignalAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Timeline.SignalReceiver instance_of_this_method = (UnityEngine.Timeline.SignalReceiver)typeof(UnityEngine.Timeline.SignalReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddReaction(@asset, @reaction);

            return __ret;
        }

        static StackObject* AddEmptyReaction_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Events.UnityEvent @reaction = (UnityEngine.Events.UnityEvent)typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.SignalReceiver instance_of_this_method = (UnityEngine.Timeline.SignalReceiver)typeof(UnityEngine.Timeline.SignalReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AddEmptyReaction(@reaction);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Remove_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.SignalAsset @asset = (UnityEngine.Timeline.SignalAsset)typeof(UnityEngine.Timeline.SignalAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.SignalReceiver instance_of_this_method = (UnityEngine.Timeline.SignalReceiver)typeof(UnityEngine.Timeline.SignalReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Remove(@asset);

            return __ret;
        }

        static StackObject* GetRegisteredSignals_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.SignalReceiver instance_of_this_method = (UnityEngine.Timeline.SignalReceiver)typeof(UnityEngine.Timeline.SignalReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetRegisteredSignals();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetReaction_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.SignalAsset @key = (UnityEngine.Timeline.SignalAsset)typeof(UnityEngine.Timeline.SignalAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.SignalReceiver instance_of_this_method = (UnityEngine.Timeline.SignalReceiver)typeof(UnityEngine.Timeline.SignalReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetReaction(@key);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Count_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.SignalReceiver instance_of_this_method = (UnityEngine.Timeline.SignalReceiver)typeof(UnityEngine.Timeline.SignalReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Count();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ChangeSignalAtIndex_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.SignalAsset @newKey = (UnityEngine.Timeline.SignalAsset)typeof(UnityEngine.Timeline.SignalAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @idx = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Timeline.SignalReceiver instance_of_this_method = (UnityEngine.Timeline.SignalReceiver)typeof(UnityEngine.Timeline.SignalReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ChangeSignalAtIndex(@idx, @newKey);

            return __ret;
        }

        static StackObject* RemoveAtIndex_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @idx = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.SignalReceiver instance_of_this_method = (UnityEngine.Timeline.SignalReceiver)typeof(UnityEngine.Timeline.SignalReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveAtIndex(@idx);

            return __ret;
        }

        static StackObject* ChangeReactionAtIndex_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Events.UnityEvent @reaction = (UnityEngine.Events.UnityEvent)typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @idx = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Timeline.SignalReceiver instance_of_this_method = (UnityEngine.Timeline.SignalReceiver)typeof(UnityEngine.Timeline.SignalReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ChangeReactionAtIndex(@idx, @reaction);

            return __ret;
        }

        static StackObject* GetReactionAtIndex_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @idx = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.SignalReceiver instance_of_this_method = (UnityEngine.Timeline.SignalReceiver)typeof(UnityEngine.Timeline.SignalReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetReactionAtIndex(@idx);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetSignalAssetAtIndex_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @idx = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.SignalReceiver instance_of_this_method = (UnityEngine.Timeline.SignalReceiver)typeof(UnityEngine.Timeline.SignalReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetSignalAssetAtIndex(@idx);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Timeline.SignalReceiver();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif