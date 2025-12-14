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
    unsafe class Goap_Runtime_GoapBehaviour_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Goap.Runtime.GoapBehaviour);
            args = new Type[]{};
            method = type.GetMethod("get_RunCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_RunCount_0);
            args = new Type[]{};
            method = type.GetMethod("get_RunTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_RunTime_1);
            args = new Type[]{};
            method = type.GetMethod("get_CompleteTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CompleteTime_2);
            args = new Type[]{};
            method = type.GetMethod("get_Agents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Agents_3);

            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetAgentType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAgentType_0);
            args = new Type[]{};
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_1);

            field = type.GetField("agentTypeConfigFactories", flag);
            app.RegisterCLRFieldGetter(field, get_agentTypeConfigFactories_0);
            app.RegisterCLRFieldSetter(field, set_agentTypeConfigFactories_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_agentTypeConfigFactories_0, AssignFromStack_agentTypeConfigFactories_0);

        }

         static StackObject* GetAgentType_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @id = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoapBehaviour instance_of_this_method = (Goap.Runtime.GoapBehaviour)typeof(Goap.Runtime.GoapBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAgentType(@id);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Initialize_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapBehaviour instance_of_this_method = (Goap.Runtime.GoapBehaviour)typeof(Goap.Runtime.GoapBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialize();

            return __ret;
        }


        static object get_agentTypeConfigFactories_0(ref object o)
        {
            return ((Goap.Runtime.GoapBehaviour)o).agentTypeConfigFactories;
        }

        static StackObject* CopyToStack_agentTypeConfigFactories_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Goap.Runtime.GoapBehaviour)o).agentTypeConfigFactories;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_agentTypeConfigFactories_0(ref object o, object v)
        {
            ((Goap.Runtime.GoapBehaviour)o).agentTypeConfigFactories = (System.Collections.Generic.List<Goap.Runtime.AgentTypeFactoryBase>)v;
        }

        static StackObject* AssignFromStack_agentTypeConfigFactories_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.List<Goap.Runtime.AgentTypeFactoryBase> @agentTypeConfigFactories = (System.Collections.Generic.List<Goap.Runtime.AgentTypeFactoryBase>)typeof(System.Collections.Generic.List<Goap.Runtime.AgentTypeFactoryBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Goap.Runtime.GoapBehaviour)o).agentTypeConfigFactories = @agentTypeConfigFactories;
            return ptr_of_this_method;
        }


        static StackObject* get_RunCount_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapBehaviour instance_of_this_method = (Goap.Runtime.GoapBehaviour)typeof(Goap.Runtime.GoapBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RunCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_RunTime_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapBehaviour instance_of_this_method = (Goap.Runtime.GoapBehaviour)typeof(Goap.Runtime.GoapBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RunTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_CompleteTime_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapBehaviour instance_of_this_method = (Goap.Runtime.GoapBehaviour)typeof(Goap.Runtime.GoapBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CompleteTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_Agents_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapBehaviour instance_of_this_method = (Goap.Runtime.GoapBehaviour)typeof(Goap.Runtime.GoapBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Agents;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}
