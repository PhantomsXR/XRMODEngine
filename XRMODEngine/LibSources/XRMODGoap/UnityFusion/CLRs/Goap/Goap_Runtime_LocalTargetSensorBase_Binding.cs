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
    unsafe class Goap_Runtime_LocalTargetSensorBase_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Goap.Runtime.LocalTargetSensorBase);
            args = new Type[]{};
            method = type.GetMethod("get_Key", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Key_0);
            args = new Type[]{};
            method = type.GetMethod("get_Config", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Config_1);
            args = new Type[]{};
            method = type.GetMethod("get_Timer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Timer_2);
            args = new Type[]{typeof(Goap.Core.ITargetSensorConfig)};
            method = type.GetMethod("SetConfig", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetConfig_3);
            args = new Type[]{};
            method = type.GetMethod("Created", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Created_4);
            args = new Type[]{};
            method = type.GetMethod("Update", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Update_5);
            args = new Type[]{};
            method = type.GetMethod("GetKeys", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetKeys_6);
            args = new Type[]{typeof(Goap.Core.IWorldData), typeof(Goap.Agent.Core.IActionReceiver), typeof(Goap.Agent.Core.IComponentReference)};
            method = type.GetMethod("Sense", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sense_7);
            args = new Type[]{typeof(Goap.Agent.Core.IActionReceiver), typeof(Goap.Agent.Core.IComponentReference), typeof(Goap.Agent.Core.ITarget)};
            method = type.GetMethod("Sense", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sense_8);



            app.RegisterCLRCreateArrayInstance(type, s => new Goap.Runtime.LocalTargetSensorBase[s]);


        }


        static StackObject* get_Key_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.LocalTargetSensorBase instance_of_this_method = (Goap.Runtime.LocalTargetSensorBase)typeof(Goap.Runtime.LocalTargetSensorBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Key;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Config_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.LocalTargetSensorBase instance_of_this_method = (Goap.Runtime.LocalTargetSensorBase)typeof(Goap.Runtime.LocalTargetSensorBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Config;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Timer_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.LocalTargetSensorBase instance_of_this_method = (Goap.Runtime.LocalTargetSensorBase)typeof(Goap.Runtime.LocalTargetSensorBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Timer;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetConfig_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Core.ITargetSensorConfig @config = (Goap.Core.ITargetSensorConfig)typeof(Goap.Core.ITargetSensorConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.LocalTargetSensorBase instance_of_this_method = (Goap.Runtime.LocalTargetSensorBase)typeof(Goap.Runtime.LocalTargetSensorBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetConfig(@config);

            return __ret;
        }

        static StackObject* Created_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.LocalTargetSensorBase instance_of_this_method = (Goap.Runtime.LocalTargetSensorBase)typeof(Goap.Runtime.LocalTargetSensorBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Created();

            return __ret;
        }

        static StackObject* Update_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.LocalTargetSensorBase instance_of_this_method = (Goap.Runtime.LocalTargetSensorBase)typeof(Goap.Runtime.LocalTargetSensorBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Update();

            return __ret;
        }

        static StackObject* GetKeys_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.LocalTargetSensorBase instance_of_this_method = (Goap.Runtime.LocalTargetSensorBase)typeof(Goap.Runtime.LocalTargetSensorBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetKeys();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Sense_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.IComponentReference @references = (Goap.Agent.Core.IComponentReference)typeof(Goap.Agent.Core.IComponentReference).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IActionReceiver @agent = (Goap.Agent.Core.IActionReceiver)typeof(Goap.Agent.Core.IActionReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Core.IWorldData @worldData = (Goap.Core.IWorldData)typeof(Goap.Core.IWorldData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Goap.Runtime.LocalTargetSensorBase instance_of_this_method = (Goap.Runtime.LocalTargetSensorBase)typeof(Goap.Runtime.LocalTargetSensorBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Sense(@worldData, @agent, @references);

            return __ret;
        }

        static StackObject* Sense_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.ITarget @existingTarget = (Goap.Agent.Core.ITarget)typeof(Goap.Agent.Core.ITarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IComponentReference @references = (Goap.Agent.Core.IComponentReference)typeof(Goap.Agent.Core.IComponentReference).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Agent.Core.IActionReceiver @agent = (Goap.Agent.Core.IActionReceiver)typeof(Goap.Agent.Core.IActionReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Goap.Runtime.LocalTargetSensorBase instance_of_this_method = (Goap.Runtime.LocalTargetSensorBase)typeof(Goap.Runtime.LocalTargetSensorBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Sense(@agent, @references, @existingTarget);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
