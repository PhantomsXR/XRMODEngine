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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_AnimationUI_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationUI);
            args = new Type[]{};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_0);
            args = new Type[]{};
            method = type.GetMethod("PlayReversed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayReversed_1);
            args = new Type[]{};
            method = type.GetMethod("Stop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Stop_2);
            args = new Type[]{typeof(System.Single), typeof(System.Action)};
            method = type.GetMethod("AddFunctionAt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddFunctionAt_3);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("add_OnSetActiveAllInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnSetActiveAllInput_4);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("remove_OnSetActiveAllInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnSetActiveAllInput_5);
            args = new Type[]{typeof(System.Action<UnityEngine.AudioClip>)};
            method = type.GetMethod("add_OnPlaySoundByFile", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnPlaySoundByFile_6);
            args = new Type[]{typeof(System.Action<UnityEngine.AudioClip>)};
            method = type.GetMethod("remove_OnPlaySoundByFile", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnPlaySoundByFile_7);
            args = new Type[]{typeof(System.Action<System.Int32>)};
            method = type.GetMethod("add_OnPlaySoundByIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnPlaySoundByIndex_8);
            args = new Type[]{typeof(System.Action<System.Int32>)};
            method = type.GetMethod("remove_OnPlaySoundByIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnPlaySoundByIndex_9);
            field = type.GetField("TotalDuration", flag);
            app.RegisterCLRFieldGetter(field, get_TotalDuration_0);
            app.RegisterCLRFieldSetter(field, set_TotalDuration_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_TotalDuration_0, AssignFromStack_TotalDuration_0);
            field = type.GetField("PlayOnStart", flag);
            app.RegisterCLRFieldGetter(field, get_PlayOnStart_1);
            app.RegisterCLRFieldSetter(field, set_PlayOnStart_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayOnStart_1, AssignFromStack_PlayOnStart_1);
            field = type.GetField("AnimationSequence", flag);
            app.RegisterCLRFieldGetter(field, get_AnimationSequence_2);
            app.RegisterCLRFieldSetter(field, set_AnimationSequence_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_AnimationSequence_2, AssignFromStack_AnimationSequence_2);
            field = type.GetField("OnAnimationEnded", flag);
            app.RegisterCLRFieldGetter(field, get_OnAnimationEnded_3);
            app.RegisterCLRFieldSetter(field, set_OnAnimationEnded_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnAnimationEnded_3, AssignFromStack_OnAnimationEnded_3);

            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.UIFramework.Runtime.AnimationUI());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.UIFramework.Runtime.AnimationUI[s]);

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
            Phantom.XRMOD.UIFramework.Runtime.AnimationUI instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.AnimationUI)typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play();

            return __ret;
        }

        static StackObject* PlayReversed_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.AnimationUI instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.AnimationUI)typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PlayReversed();

            return __ret;
        }

        static StackObject* Stop_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.AnimationUI instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.AnimationUI)typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Stop();

            return __ret;
        }

        static StackObject* AddFunctionAt_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @func = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @time = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.UIFramework.Runtime.AnimationUI instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.AnimationUI)typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AddFunctionAt(@time, @func);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* add_OnSetActiveAllInput_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> @value = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.UIFramework.Runtime.AnimationUI.OnSetActiveAllInput += value;

            return __ret;
        }

        static StackObject* remove_OnSetActiveAllInput_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> @value = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.UIFramework.Runtime.AnimationUI.OnSetActiveAllInput -= value;

            return __ret;
        }

        static StackObject* add_OnPlaySoundByFile_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.AudioClip> @value = (System.Action<UnityEngine.AudioClip>)typeof(System.Action<UnityEngine.AudioClip>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.UIFramework.Runtime.AnimationUI.OnPlaySoundByFile += value;

            return __ret;
        }

        static StackObject* remove_OnPlaySoundByFile_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.AudioClip> @value = (System.Action<UnityEngine.AudioClip>)typeof(System.Action<UnityEngine.AudioClip>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.UIFramework.Runtime.AnimationUI.OnPlaySoundByFile -= value;

            return __ret;
        }

        static StackObject* add_OnPlaySoundByIndex_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Int32> @value = (System.Action<System.Int32>)typeof(System.Action<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.UIFramework.Runtime.AnimationUI.OnPlaySoundByIndex += value;

            return __ret;
        }

        static StackObject* remove_OnPlaySoundByIndex_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Int32> @value = (System.Action<System.Int32>)typeof(System.Action<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.UIFramework.Runtime.AnimationUI.OnPlaySoundByIndex -= value;

            return __ret;
        }





        static object get_TotalDuration_0(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).TotalDuration;
        }

        static StackObject* CopyToStack_TotalDuration_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).TotalDuration;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_TotalDuration_0(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).TotalDuration = (System.Single)v;
        }

        static StackObject* AssignFromStack_TotalDuration_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @TotalDuration = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).TotalDuration = @TotalDuration;
            return ptr_of_this_method;
        }

        static object get_PlayOnStart_1(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).PlayOnStart;
        }

        static StackObject* CopyToStack_PlayOnStart_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).PlayOnStart;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_PlayOnStart_1(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).PlayOnStart = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_PlayOnStart_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @PlayOnStart = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).PlayOnStart = @PlayOnStart;
            return ptr_of_this_method;
        }

        static object get_AnimationSequence_2(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).AnimationSequence;
        }

        static StackObject* CopyToStack_AnimationSequence_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).AnimationSequence;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AnimationSequence_2(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).AnimationSequence = (Phantom.XRMOD.UIFramework.Runtime.Sequence[])v;
        }

        static StackObject* AssignFromStack_AnimationSequence_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence[] @AnimationSequence = (Phantom.XRMOD.UIFramework.Runtime.Sequence[])typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).AnimationSequence = @AnimationSequence;
            return ptr_of_this_method;
        }

        static object get_OnAnimationEnded_3(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).OnAnimationEnded;
        }

        static StackObject* CopyToStack_OnAnimationEnded_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).OnAnimationEnded;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnAnimationEnded_3(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).OnAnimationEnded = (System.Action)v;
        }

        static StackObject* AssignFromStack_OnAnimationEnded_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @OnAnimationEnded = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationUI)o).OnAnimationEnded = @OnAnimationEnded;
            return ptr_of_this_method;
        }

       

        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.UIFramework.Runtime.AnimationUI();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
