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
using UnityFusion.CLRBinding.Adapter;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif
namespace UnityFusion.Runtime.Generated
{
    unsafe class System_Collections_Generic_Queue_1_XRMODBehaviourAdapter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>);
            args = new Type[]{};
            method = type.GetMethod("get_Count", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Count_0);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_1);
            args = new Type[]{typeof(XRMODBehaviourAdapter.Adapter[]), typeof(System.Int32)};
            method = type.GetMethod("CopyTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTo_2);
            args = new Type[]{typeof(XRMODBehaviourAdapter.Adapter)};
            method = type.GetMethod("Enqueue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Enqueue_3);
            args = new Type[]{};
            method = type.GetMethod("GetEnumerator", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetEnumerator_4);
            args = new Type[]{};
            method = type.GetMethod("Dequeue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Dequeue_5);
  
            args = new Type[]{};
            method = type.GetMethod("Peek", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Peek_7);
     
            args = new Type[]{typeof(XRMODBehaviourAdapter.Adapter)};
            method = type.GetMethod("Contains", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Contains_9);
            args = new Type[]{};
            method = type.GetMethod("ToArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToArray_10);
            // args = new Type[]{};
            // method = type.GetMethod("TrimExcess", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, TrimExcess_11);



            app.RegisterCLRCreateDefaultInstance(type, () => new System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>());
            app.RegisterCLRCreateArrayInstance(type, s => new System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<XRMODBehaviourAdapter.Adapter>)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_2);

        }


        static StackObject* get_Count_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter> instance_of_this_method = (System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>)typeof(System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Count;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Clear_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter> instance_of_this_method = (System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>)typeof(System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }

        static StackObject* CopyTo_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @arrayIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            XRMODBehaviourAdapter.Adapter[] @array = (XRMODBehaviourAdapter.Adapter[])typeof(XRMODBehaviourAdapter.Adapter[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter> instance_of_this_method = (System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>)typeof(System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyTo(@array, @arrayIndex);

            return __ret;
        }

        static StackObject* Enqueue_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            XRMODBehaviourAdapter.Adapter @item = (XRMODBehaviourAdapter.Adapter)typeof(XRMODBehaviourAdapter.Adapter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter> instance_of_this_method = (System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>)typeof(System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Enqueue(@item);

            return __ret;
        }

        static StackObject* GetEnumerator_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter> instance_of_this_method = (System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>)typeof(System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetEnumerator();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Dequeue_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter> instance_of_this_method = (System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>)typeof(System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Dequeue();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

 
        static StackObject* Peek_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter> instance_of_this_method = (System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>)typeof(System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Peek();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

 
        static StackObject* Contains_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            XRMODBehaviourAdapter.Adapter @item = (XRMODBehaviourAdapter.Adapter)typeof(XRMODBehaviourAdapter.Adapter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter> instance_of_this_method = (System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>)typeof(System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Contains(@item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ToArray_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter> instance_of_this_method = (System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>)typeof(System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ToArray();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        // static StackObject* TrimExcess_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter> instance_of_this_method = (System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>)typeof(System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.TrimExcess();
        //
        //     return __ret;
        // }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @capacity = ptr_of_this_method->Value;


            var result_of_this_method = new System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>(@capacity);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<XRMODBehaviourAdapter.Adapter> @collection = (System.Collections.Generic.IEnumerable<XRMODBehaviourAdapter.Adapter>)typeof(System.Collections.Generic.IEnumerable<XRMODBehaviourAdapter.Adapter>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new System.Collections.Generic.Queue<XRMODBehaviourAdapter.Adapter>(@collection);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
