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
    unsafe class LTEvent_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::LTEvent);

            field = type.GetField("id", flag);
            app.RegisterCLRFieldGetter(field, get_id_0);
            app.RegisterCLRFieldSetter(field, set_id_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_id_0, AssignFromStack_id_0);
            field = type.GetField("data", flag);
            app.RegisterCLRFieldGetter(field, get_data_1);
            app.RegisterCLRFieldSetter(field, set_data_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_data_1, AssignFromStack_data_1);


            app.RegisterCLRCreateArrayInstance(type, s => new global::LTEvent[s]);

            args = new Type[]{typeof(System.Int32), typeof(System.Object)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_id_0(ref object o)
        {
            return ((global::LTEvent)o).id;
        }

        static StackObject* CopyToStack_id_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTEvent)o).id;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_id_0(ref object o, object v)
        {
            ((global::LTEvent)o).id = (System.Int32)v;
        }

        static StackObject* AssignFromStack_id_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @id = ptr_of_this_method->Value;
            ((global::LTEvent)o).id = @id;
            return ptr_of_this_method;
        }

        static object get_data_1(ref object o)
        {
            return ((global::LTEvent)o).data;
        }

        static StackObject* CopyToStack_data_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTEvent)o).data;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance, true);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method, true);
        }

        static void set_data_1(ref object o, object v)
        {
            ((global::LTEvent)o).data = (System.Object)v;
        }

        static StackObject* AssignFromStack_data_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Object @data = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::LTEvent)o).data = @data;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @data = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @id = ptr_of_this_method->Value;


            var result_of_this_method = new global::LTEvent(@id, @data);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
