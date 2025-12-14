#if FUSION2 && XRMOD_INSTALL

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
    unsafe class Fusion_Addons_KCC_StepUpProcessor_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.StepUpProcessor);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCC)};
            method = type.GetMethod("GetPriority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPriority_0);
            args = new Type[]{typeof(Fusion.Addons.KCC.AfterMoveStep), typeof(Fusion.Addons.KCC.KCC), typeof(Fusion.Addons.KCC.KCCData)};
            method = type.GetMethod("Execute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Execute_1);

            field = type.GetField("DefaultPriority", flag);
            app.RegisterCLRFieldGetter(field, get_DefaultPriority_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_DefaultPriority_0, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.StepUpProcessor());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.StepUpProcessor[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* GetPriority_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.StepUpProcessor instance_of_this_method = (Fusion.Addons.KCC.StepUpProcessor)typeof(Fusion.Addons.KCC.StepUpProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPriority(@kcc);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Execute_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData @data = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.AfterMoveStep @stage = (Fusion.Addons.KCC.AfterMoveStep)typeof(Fusion.Addons.KCC.AfterMoveStep).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Addons.KCC.StepUpProcessor instance_of_this_method = (Fusion.Addons.KCC.StepUpProcessor)typeof(Fusion.Addons.KCC.StepUpProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Execute(@stage, @kcc, @data);

            return __ret;
        }


        static object get_DefaultPriority_0(ref object o)
        {
            return Fusion.Addons.KCC.StepUpProcessor.DefaultPriority;
        }

        static StackObject* CopyToStack_DefaultPriority_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.StepUpProcessor.DefaultPriority;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.StepUpProcessor();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif