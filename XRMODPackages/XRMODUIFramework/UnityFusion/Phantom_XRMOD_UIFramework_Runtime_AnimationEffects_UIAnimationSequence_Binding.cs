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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_AnimationEffects_UIAnimationSequence_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationSequence);
            args = new Type[]{};
            method = type.GetMethod("PlaySequence", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlaySequence_0);

            field = type.GetField("steps", flag);
            app.RegisterCLRFieldGetter(field, get_steps_0);
            app.RegisterCLRFieldSetter(field, set_steps_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_steps_0, AssignFromStack_steps_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationSequence());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationSequence[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* PlaySequence_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationSequence instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationSequence)typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationSequence).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PlaySequence();

            return __ret;
        }


        static object get_steps_0(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationSequence)o).steps;
        }

        static StackObject* CopyToStack_steps_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationSequence)o).steps;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_steps_0(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationSequence)o).steps = (System.Collections.Generic.List<Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationStep>)v;
        }

        static StackObject* AssignFromStack_steps_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.List<Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationStep> @steps = (System.Collections.Generic.List<Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationStep>)typeof(System.Collections.Generic.List<Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationStep>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationSequence)o).steps = @steps;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationSequence();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
