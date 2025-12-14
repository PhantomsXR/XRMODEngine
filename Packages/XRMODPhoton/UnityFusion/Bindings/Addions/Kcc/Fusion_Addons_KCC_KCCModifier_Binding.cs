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
    unsafe class Fusion_Addons_KCC_KCCModifier_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCModifier);
            args = new Type[]{};
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_0);
            args = new Type[]{};
            method = type.GetMethod("Deinitialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Deinitialize_1);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCCModifier)};
            method = type.GetMethod("CopyFromOther", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyFromOther_2);

            field = type.GetField("Processor", flag);
            app.RegisterCLRFieldGetter(field, get_Processor_0);
            app.RegisterCLRFieldSetter(field, set_Processor_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Processor_0, AssignFromStack_Processor_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCModifier());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCModifier[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Initialize_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCModifier instance_of_this_method = (Fusion.Addons.KCC.KCCModifier)typeof(Fusion.Addons.KCC.KCCModifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialize();

            return __ret;
        }

        static StackObject* Deinitialize_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCModifier instance_of_this_method = (Fusion.Addons.KCC.KCCModifier)typeof(Fusion.Addons.KCC.KCCModifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Deinitialize();

            return __ret;
        }

        static StackObject* CopyFromOther_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCModifier @other = (Fusion.Addons.KCC.KCCModifier)typeof(Fusion.Addons.KCC.KCCModifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCModifier instance_of_this_method = (Fusion.Addons.KCC.KCCModifier)typeof(Fusion.Addons.KCC.KCCModifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyFromOther(@other);

            return __ret;
        }


        static object get_Processor_0(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCModifier)o).Processor;
        }

        static StackObject* CopyToStack_Processor_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCModifier)o).Processor;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Processor_0(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCModifier)o).Processor = (Fusion.Addons.KCC.IKCCProcessor)v;
        }

        static StackObject* AssignFromStack_Processor_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.IKCCProcessor @Processor = (Fusion.Addons.KCC.IKCCProcessor)typeof(Fusion.Addons.KCC.IKCCProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCModifier)o).Processor = @Processor;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCModifier();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif