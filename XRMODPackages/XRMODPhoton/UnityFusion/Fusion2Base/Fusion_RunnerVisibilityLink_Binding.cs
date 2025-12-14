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
    unsafe class Fusion_RunnerVisibilityLink_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.RunnerVisibilityLink);
            args = new Type[]{};
            method = type.GetMethod("get_IsOnSingleRunner", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsOnSingleRunner_0);
            args = new Type[]{};
            method = type.GetMethod("get_DefaultState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DefaultState_1);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_DefaultState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_DefaultState_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetEnabled_3);

            field = type.GetField("PreferredRunner", flag);
            app.RegisterCLRFieldGetter(field, get_PreferredRunner_0);
            app.RegisterCLRFieldSetter(field, set_PreferredRunner_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_PreferredRunner_0, AssignFromStack_PreferredRunner_0);
            field = type.GetField("Component", flag);
            app.RegisterCLRFieldGetter(field, get_Component_1);
            app.RegisterCLRFieldSetter(field, set_Component_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Component_1, AssignFromStack_Component_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.RunnerVisibilityLink());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.RunnerVisibilityLink[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_IsOnSingleRunner_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.RunnerVisibilityLink instance_of_this_method = (Fusion.RunnerVisibilityLink)typeof(Fusion.RunnerVisibilityLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsOnSingleRunner;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_DefaultState_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.RunnerVisibilityLink instance_of_this_method = (Fusion.RunnerVisibilityLink)typeof(Fusion.RunnerVisibilityLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DefaultState;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_DefaultState_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.RunnerVisibilityLink instance_of_this_method = (Fusion.RunnerVisibilityLink)typeof(Fusion.RunnerVisibilityLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DefaultState = value;

            return __ret;
        }

        static StackObject* SetEnabled_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @enabled = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.RunnerVisibilityLink instance_of_this_method = (Fusion.RunnerVisibilityLink)typeof(Fusion.RunnerVisibilityLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetEnabled(@enabled);

            return __ret;
        }


        static object get_PreferredRunner_0(ref object o)
        {
            return ((Fusion.RunnerVisibilityLink)o).PreferredRunner;
        }

        static StackObject* CopyToStack_PreferredRunner_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.RunnerVisibilityLink)o).PreferredRunner;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PreferredRunner_0(ref object o, object v)
        {
            ((Fusion.RunnerVisibilityLink)o).PreferredRunner = (Fusion.RunnerVisibilityLink.PreferredRunners)v;
        }

        static StackObject* AssignFromStack_PreferredRunner_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.RunnerVisibilityLink.PreferredRunners @PreferredRunner = (Fusion.RunnerVisibilityLink.PreferredRunners)typeof(Fusion.RunnerVisibilityLink.PreferredRunners).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.RunnerVisibilityLink)o).PreferredRunner = @PreferredRunner;
            return ptr_of_this_method;
        }

        static object get_Component_1(ref object o)
        {
            return ((Fusion.RunnerVisibilityLink)o).Component;
        }

        static StackObject* CopyToStack_Component_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.RunnerVisibilityLink)o).Component;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Component_1(ref object o, object v)
        {
            ((Fusion.RunnerVisibilityLink)o).Component = (UnityEngine.Component)v;
        }

        static StackObject* AssignFromStack_Component_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Component @Component = (UnityEngine.Component)typeof(UnityEngine.Component).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.RunnerVisibilityLink)o).Component = @Component;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.RunnerVisibilityLink();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
