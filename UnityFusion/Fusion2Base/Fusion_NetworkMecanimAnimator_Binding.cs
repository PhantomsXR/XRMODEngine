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
    unsafe class Fusion_NetworkMecanimAnimator_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.NetworkMecanimAnimator);
            args = new Type[]{};
            method = type.GetMethod("get_DynamicWordCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DynamicWordCount_0);
            args = new Type[]{};
            method = type.GetMethod("Spawned", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Spawned_1);
            args = new Type[]{};
            method = type.GetMethod("Render", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Render_2);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("SetTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTrigger_3);
            args = new Type[]{typeof(System.String), typeof(System.Boolean)};
            method = type.GetMethod("SetTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTrigger_4);

            field = type.GetField("Animator", flag);
            app.RegisterCLRFieldGetter(field, get_Animator_0);
            app.RegisterCLRFieldSetter(field, set_Animator_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Animator_0, AssignFromStack_Animator_0);
            field = type.GetField("ApplyTiming", flag);
            app.RegisterCLRFieldGetter(field, get_ApplyTiming_1);
            app.RegisterCLRFieldSetter(field, set_ApplyTiming_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ApplyTiming_1, AssignFromStack_ApplyTiming_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.NetworkMecanimAnimator());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.NetworkMecanimAnimator[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_DynamicWordCount_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkMecanimAnimator instance_of_this_method = (Fusion.NetworkMecanimAnimator)typeof(Fusion.NetworkMecanimAnimator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DynamicWordCount;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Spawned_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkMecanimAnimator instance_of_this_method = (Fusion.NetworkMecanimAnimator)typeof(Fusion.NetworkMecanimAnimator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Spawned();

            return __ret;
        }

        static StackObject* Render_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkMecanimAnimator instance_of_this_method = (Fusion.NetworkMecanimAnimator)typeof(Fusion.NetworkMecanimAnimator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Render();

            return __ret;
        }

        static StackObject* SetTrigger_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @passThroughOnInputAuthority = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @triggerHash = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.NetworkMecanimAnimator instance_of_this_method = (Fusion.NetworkMecanimAnimator)typeof(Fusion.NetworkMecanimAnimator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTrigger(@triggerHash, @passThroughOnInputAuthority);

            return __ret;
        }

        static StackObject* SetTrigger_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @passThroughOnInputAuthority = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @trigger = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.NetworkMecanimAnimator instance_of_this_method = (Fusion.NetworkMecanimAnimator)typeof(Fusion.NetworkMecanimAnimator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTrigger(@trigger, @passThroughOnInputAuthority);

            return __ret;
        }


        static object get_Animator_0(ref object o)
        {
            return ((Fusion.NetworkMecanimAnimator)o).Animator;
        }

        static StackObject* CopyToStack_Animator_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkMecanimAnimator)o).Animator;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Animator_0(ref object o, object v)
        {
            ((Fusion.NetworkMecanimAnimator)o).Animator = (UnityEngine.Animator)v;
        }

        static StackObject* AssignFromStack_Animator_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Animator @Animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.NetworkMecanimAnimator)o).Animator = @Animator;
            return ptr_of_this_method;
        }

        static object get_ApplyTiming_1(ref object o)
        {
            return ((Fusion.NetworkMecanimAnimator)o).ApplyTiming;
        }

        static StackObject* CopyToStack_ApplyTiming_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkMecanimAnimator)o).ApplyTiming;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ApplyTiming_1(ref object o, object v)
        {
            ((Fusion.NetworkMecanimAnimator)o).ApplyTiming = (Fusion.RenderSource)v;
        }

        static StackObject* AssignFromStack_ApplyTiming_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.RenderSource @ApplyTiming = (Fusion.RenderSource)typeof(Fusion.RenderSource).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.NetworkMecanimAnimator)o).ApplyTiming = @ApplyTiming;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.NetworkMecanimAnimator();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
