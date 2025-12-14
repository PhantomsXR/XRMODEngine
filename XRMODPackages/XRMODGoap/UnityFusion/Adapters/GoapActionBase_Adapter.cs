using System;
using System.Reflection;
using Goap.Agent.Core;
using Goap.Runtime;
using UnityEngine;
using UnityFusion.CLR.Method;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using Object = System.Object;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace UnityFusion.CLRBinding.Adapter
{
    public class GoapActionBaseAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType => typeof(GoapActionBase<IActionDataAdapter.Adapter>);

        public override Type AdaptorType => typeof(Adapter);

        public override object CreateCLRInstance(UnityFusion.Runtime.Enviorment.AppDomain appdomain,
            ILTypeInstance instance)
        {
            return new Adapter(appdomain, instance);
        }

        public class Adapter : GoapActionBase<IActionDataAdapter.Adapter>, CrossBindingAdaptorType
        {
            private const BindingFlags _CONST_FLAGS =
                BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public;

            CrossBindingFunctionInfo<Goap.Agent.Runtime.EmptyActionProperties>
                mget_Properties_0 = new("get_Properties");

            CrossBindingFunctionInfo<IActionReceiver, IComponentReference, ITarget, float> mGetCost_1 = new("GetCost");

            CrossBindingFunctionInfo<Single> mGetStoppingDistance_2 = new("GetStoppingDistance");

            CrossBindingFunctionInfo<IMonoAgent, float, IActionData, IComponentReference, Boolean> mIsInRange_3 =
                new("IsInRange");

            CrossBindingFunctionInfo<IActionReceiver, IActionDataAdapter.Adapter, bool> mIsValid_4 = new("IsValid");

            CrossBindingFunctionInfo<IActionDataAdapter.Adapter> mCreateData_5 = new("CreateData");

            CrossBindingMethodInfo mCreated_6 = new("Created");
            CrossBindingFunctionInfo<IActionDataAdapter.Adapter> mGetData = new("GetData");


            CrossBindingFunctionInfo<IActionReceiver, IComponentReference, bool> mIsEnabled_8 = new("IsEnabled");

            CrossBindingFunctionInfo<IMonoAgent, IActionDataAdapter.Adapter, IActionContext, IActionRunState>
                mPerform_10 = new("Perform");


            bool isInvokingToString;
            ILTypeInstance instance;
            UnityFusion.Runtime.Enviorment.AppDomain appdomain;

            public Adapter()
            {
            }

            public Adapter(Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
            {
                this.appdomain = appdomain;
                this.instance = instance;
            }

            public ILTypeInstance ILInstance => instance;

            public override Single GetCost(IActionReceiver agent, IComponentReference references, ITarget target)
            {
                if (mGetCost_1.CheckShouldInvokeBase(this.instance))
                    return base.GetCost(agent, references, target);
                else
                    return mGetCost_1.Invoke(this.instance, agent, references, target);
            }

            public override Single GetStoppingDistance()
            {
                if (mGetStoppingDistance_2.CheckShouldInvokeBase(this.instance))
                    return base.GetStoppingDistance();
                else
                    return mGetStoppingDistance_2.Invoke(this.instance);
            }

            public override Boolean IsInRange(IMonoAgent agent, Single distance,
                IActionData data, IComponentReference references)
            {
                if (mIsInRange_3.CheckShouldInvokeBase(this.instance))
                    return base.IsInRange(agent, distance, data, references);
                else
                    return mIsInRange_3.Invoke(this.instance, agent, distance, data, references);
            }


            public override Boolean IsValid(IActionReceiver agent,
                IActionDataAdapter.Adapter data)
            {
                if (mIsValid_4.CheckShouldInvokeBase(this.instance))
                    return base.IsValid(agent, data);
                else
                    return mIsValid_4.Invoke(this.instance, agent, data);
            }


            private MethodInfo createDataMethod;

            public override IActionDataAdapter.Adapter CreateData()
            {
                if (createDataMethod == null)
                    createDataMethod = instance.Type.ReflectionType.GetMethod(nameof(CreateData), _CONST_FLAGS);

                if (createDataMethod != null)
                {
                    var tmp_ActionData = createDataMethod.Invoke(instance.CLRInstance, null);
                    return tmp_ActionData as IActionDataAdapter.Adapter;
                }

                var tmp_Data = mCreateData_5.Invoke(this.instance);
                return tmp_Data;
            }

            public override void Created()
            {
                if (mCreated_6.CheckShouldInvokeBase(this.instance))
                    base.Created();
                else
                    mCreated_6.Invoke(this.instance);
            }

            private MethodInfo startMethod;
            private readonly object[] startMethodParam = new object[2];

            public override void Start(IMonoAgent agent, IActionDataAdapter.Adapter data)
            {
                if (startMethod == null)
                    startMethod = instance.Type.ReflectionType.GetMethod(nameof(Start), _CONST_FLAGS);

                if (startMethod == null) return;
                startMethodParam[0] = agent;
                startMethodParam[1] = data;
                startMethod.Invoke(instance.CLRInstance, startMethodParam);
            }


            public override Boolean IsEnabled(IActionReceiver receiver, IComponentReference references)
            {
                return mIsEnabled_8.CheckShouldInvokeBase(this.instance)
                    ? base.IsEnabled(receiver, references)
                    : mIsEnabled_8.Invoke(this.instance, receiver, references);
            }


            private MethodInfo beforePerformMethod;
            private readonly object[] beforePerformMethodParam = new object[2];

            public override void BeforePerform(Goap.Agent.Core.IMonoAgent agent,
                IActionDataAdapter.Adapter data)
            {
                if (beforePerformMethod == null)
                    beforePerformMethod = instance.Type.ReflectionType.GetMethod(nameof(BeforePerform), _CONST_FLAGS);
                if (beforePerformMethod == null) return;
                beforePerformMethodParam[0] = agent;
                beforePerformMethodParam[1] = data;
                beforePerformMethod.Invoke(instance.CLRInstance, beforePerformMethodParam);
            }

            private MethodInfo performMethod;
            private object[] performParam = new object[3];

            public override IActionRunState Perform(IMonoAgent agent,
                IActionDataAdapter.Adapter data, IActionContext context)
            {
                if (performMethod == null)
                    performMethod = instance.Type.ReflectionType.GetMethod(nameof(Perform), _CONST_FLAGS);
                if (performMethod == null) return mPerform_10.Invoke(this.instance, agent, data, context);
                performParam[0] = agent;
                performParam[1] = data;
                performParam[2] = context;
                return performMethod.Invoke(instance.CLRInstance, performParam) as IActionRunState;
            }

            private MethodInfo endMethod;
            private object[] endMethodParam = new object[2];

            public override void End(IMonoAgent agent,
                IActionDataAdapter.Adapter data)
            {
                if (endMethod == null)
                    endMethod = instance.Type.ReflectionType.GetMethod(nameof(End), _CONST_FLAGS);
                if (endMethod == null || stopMethod is CLRMethod) return;
                endMethodParam[0] = agent;
                endMethodParam[1] = data;
                endMethod.Invoke(instance.CLRInstance, endMethodParam);
            }


            private MethodInfo stopMethod;
            private object[] stopMethodParam = new object[2];

            public override void Stop(IMonoAgent agent,
                IActionDataAdapter.Adapter data)
            {
                if (stopMethod == null)
                    stopMethod = instance.Type.ReflectionType.GetMethod(nameof(Stop), _CONST_FLAGS);
                if (stopMethod == null || stopMethod is CLRMethod) return;
                stopMethodParam[0] = agent;
                stopMethodParam[1] = data;
                stopMethod.Invoke(instance.CLRInstance, stopMethodParam);
            }


            private MethodInfo completeMethodInfo;
            private object[] completeMethodInfoParam = new object[2];

            public override void Complete(IMonoAgent agent, IActionDataAdapter.Adapter data)
            {
                if (completeMethodInfo == null)
                    completeMethodInfo = instance.Type.ReflectionType.GetMethod(nameof(Complete), _CONST_FLAGS);
                if (completeMethodInfo == null) return;
                completeMethodInfoParam[0] = agent;
                completeMethodInfoParam[1] = data;
                completeMethodInfo.Invoke(instance.CLRInstance, completeMethodInfoParam);
            }

            public override Goap.Agent.Runtime.EmptyActionProperties Properties =>
                mget_Properties_0.CheckShouldInvokeBase(this.instance)
                    ? base.Properties
                    : mget_Properties_0.Invoke(this.instance);

            public override string ToString()
            {
                IMethod m = appdomain.ObjectType.GetMethod("ToString", 0);
                m = instance.Type.GetVirtualMethod(m);
                if (m != null && m is not ILMethod) return instance.Type.FullName;
                if (isInvokingToString) return instance.Type.FullName;
                isInvokingToString = true;
                string res = instance.ToString();
                isInvokingToString = false;
                return res;
            }
        }
    }
}