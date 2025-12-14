using System;
using System.Collections.Generic;
using System.Linq;
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
    unsafe class
        System_Collections_Generic_List_1_UnityFusion_CLRBinding_Adapter_XRMODBehaviourAdapter_Binding_Adapter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type =
                typeof(System.Collections.Generic.List<UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>);
            args = new Type[] {typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter)};
            method = type.GetMethod("Add", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Add_0);
            args = new Type[] {typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter)};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_1);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("get_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Item_2);
            args = new Type[] { };
            method = type.GetMethod("get_Count", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Count_3);
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_2);
            args = new Type[]
            {
                typeof(System.Collections.Generic.IEnumerable<
                    UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>)
            };

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }

        static StackObject* Clear_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>
                instance_of_this_method =
                    (System.Collections.Generic.List<UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>)
                    typeof(
                            System.Collections.Generic.List<
                                UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>)
                        .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                            (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }


        static StackObject* Add_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter @item =
                (UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter)
                typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>
                instance_of_this_method =
                    (System.Collections.Generic.List<UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>)
                    typeof(
                            System.Collections.Generic.List<
                                UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>)
                        .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                            (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Add(@item);

            return __ret;
        }

        static StackObject* Remove_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter @item =
                (UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter)
                typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>
                instance_of_this_method =
                    (System.Collections.Generic.List<UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>)
                    typeof(
                            System.Collections.Generic.List<
                                UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>)
                        .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                            (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Remove(@item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_Item_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>
                instance_of_this_method =
                    (System.Collections.Generic.List<UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>)
                    typeof(
                            System.Collections.Generic.List<
                                UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>)
                        .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                            (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method[index];

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Count_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>
                instance_of_this_method =
                    (System.Collections.Generic.List<UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>)
                    typeof(
                            System.Collections.Generic.List<
                                UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>)
                        .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                            (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Count;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method =
                new System.Collections.Generic.List<UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter>();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}