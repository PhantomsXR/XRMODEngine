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
    unsafe class Fusion_EnableOnSingleRunner_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.EnableOnSingleRunner);
            args = new Type[]{};
            method = type.GetMethod("FindRecognizedTypes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindRecognizedTypes_0);
            args = new Type[]{};
            method = type.GetMethod("FindNestedRecognizedTypes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindNestedRecognizedTypes_1);

            field = type.GetField("PreferredRunner", flag);
            app.RegisterCLRFieldGetter(field, get_PreferredRunner_0);
            app.RegisterCLRFieldSetter(field, set_PreferredRunner_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_PreferredRunner_0, AssignFromStack_PreferredRunner_0);
            field = type.GetField("Components", flag);
            app.RegisterCLRFieldGetter(field, get_Components_1);
            app.RegisterCLRFieldSetter(field, set_Components_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Components_1, AssignFromStack_Components_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.EnableOnSingleRunner());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.EnableOnSingleRunner[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* FindRecognizedTypes_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.EnableOnSingleRunner instance_of_this_method = (Fusion.EnableOnSingleRunner)typeof(Fusion.EnableOnSingleRunner).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FindRecognizedTypes();

            return __ret;
        }

        static StackObject* FindNestedRecognizedTypes_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.EnableOnSingleRunner instance_of_this_method = (Fusion.EnableOnSingleRunner)typeof(Fusion.EnableOnSingleRunner).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FindNestedRecognizedTypes();

            return __ret;
        }


        static object get_PreferredRunner_0(ref object o)
        {
            return ((Fusion.EnableOnSingleRunner)o).PreferredRunner;
        }

        static StackObject* CopyToStack_PreferredRunner_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.EnableOnSingleRunner)o).PreferredRunner;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PreferredRunner_0(ref object o, object v)
        {
            ((Fusion.EnableOnSingleRunner)o).PreferredRunner = (Fusion.RunnerVisibilityLink.PreferredRunners)v;
        }

        static StackObject* AssignFromStack_PreferredRunner_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.RunnerVisibilityLink.PreferredRunners @PreferredRunner = (Fusion.RunnerVisibilityLink.PreferredRunners)typeof(Fusion.RunnerVisibilityLink.PreferredRunners).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.EnableOnSingleRunner)o).PreferredRunner = @PreferredRunner;
            return ptr_of_this_method;
        }

        static object get_Components_1(ref object o)
        {
            return ((Fusion.EnableOnSingleRunner)o).Components;
        }

        static StackObject* CopyToStack_Components_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.EnableOnSingleRunner)o).Components;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Components_1(ref object o, object v)
        {
            ((Fusion.EnableOnSingleRunner)o).Components = (UnityEngine.Component[])v;
        }

        static StackObject* AssignFromStack_Components_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Component[] @Components = (UnityEngine.Component[])typeof(UnityEngine.Component[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.EnableOnSingleRunner)o).Components = @Components;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.EnableOnSingleRunner();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
