using System;
using Goap.Agent.Core;
using Goap.Runtime;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace UnityFusion.CLRBinding.Adapter
{
    public class GoapActionBase2Adapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get { return typeof(GoapActionBase<IActionDataAdapter.Adapter, IActionPropertiesAdapter.Adapter>); }
        }

        public override Type AdaptorType
        {
            get { return typeof(Adapter); }
        }

        public override object CreateCLRInstance(UnityFusion.Runtime.Enviorment.AppDomain appdomain,
            ILTypeInstance instance)
        {
            return new Adapter(appdomain, instance);
        }

        public class Adapter : GoapActionBase<IActionDataAdapter.Adapter, IActionPropertiesAdapter.Adapter>,
            CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<IActionPropertiesAdapter.Adapter> mget_Properties_0 =
                new CrossBindingFunctionInfo<IActionPropertiesAdapter.Adapter>("get_Properties");

            CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference,
                Goap.Agent.Core.ITarget, System.Single> mGetCost_1 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver,
                    Goap.Agent.Core.IComponentReference, Goap.Agent.Core.ITarget, System.Single>(
                    "GetCost");

            CrossBindingFunctionInfo<System.Single> mGetStoppingDistance_2 =
                new CrossBindingFunctionInfo<System.Single>("GetStoppingDistance");

            CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, System.Single,
                    Goap.Agent.Core.IActionData, Goap.Agent.Core.IComponentReference, System.Boolean>
                mIsInRange_3 =
                    new CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, System.Single,
                        Goap.Agent.Core.IActionData, Goap.Agent.Core.IComponentReference, System.Boolean>(
                        "IsInRange");

            CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, IActionDataAdapter.Adapter,
                System.Boolean> mIsValid_4 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver,
                    IActionDataAdapter.Adapter, System.Boolean>("IsValid");

            CrossBindingFunctionInfo<IActionDataAdapter.Adapter> mCreateData_5 =
                new CrossBindingFunctionInfo<IActionDataAdapter.Adapter>("CreateData");

            CrossBindingMethodInfo mCreated_6 = new CrossBindingMethodInfo("Created");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, IActionDataAdapter.Adapter>
                mStart_7 =
                    new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent,
                        IActionDataAdapter.Adapter>("Start");

            CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference,
                System.Boolean> mIsEnabled_8 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver,
                    Goap.Agent.Core.IComponentReference, System.Boolean>("IsEnabled");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, IActionDataAdapter.Adapter>
                mBeforePerform_9 =
                    new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent,
                        IActionDataAdapter.Adapter>("BeforePerform");

            CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, IActionDataAdapter.Adapter,
                Goap.Agent.Core.IActionContext, Goap.Agent.Core.IActionRunState> mPerform_10 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent,
                    IActionDataAdapter.Adapter, Goap.Agent.Core.IActionContext,
                    Goap.Agent.Core.IActionRunState>("Perform");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, IActionDataAdapter.Adapter>
                mEnd_11 =
                    new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent,
                        IActionDataAdapter.Adapter>("End");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, IActionDataAdapter.Adapter>
                mStop_12 =
                    new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent,
                        IActionDataAdapter.Adapter>("Stop");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, IActionDataAdapter.Adapter>
                mComplete_13 =
                    new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent,
                        IActionDataAdapter.Adapter>("Complete");

            CrossBindingFunctionInfo<Goap.Agent.Core.IActionData> mGetData_14 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IActionData>("GetData");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData> mStart_15 =
                new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData>(
                    "Start");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData>
                mBeforePerform_16 =
                    new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData>(
                        "BeforePerform");

            CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData,
                Goap.Agent.Core.IActionContext, Goap.Agent.Core.IActionRunState> mPerform_17 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData,
                    Goap.Agent.Core.IActionContext, Goap.Agent.Core.IActionRunState>("Perform");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData> mStop_18 =
                new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData>(
                    "Stop");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData> mComplete_19 =
                new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData>(
                    "Complete");

            CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, System.Boolean> mIsEnabled_20 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, System.Boolean>("IsEnabled");

            CrossBindingMethodInfo mEnable_21 = new CrossBindingMethodInfo("Enable");

            CrossBindingMethodInfo<Goap.Agent.Core.IActionDisabler> mDisable_22 =
                new CrossBindingMethodInfo<Goap.Agent.Core.IActionDisabler>("Disable");

            bool isInvokingToString;
            ILTypeInstance instance;
            UnityFusion.Runtime.Enviorment.AppDomain appdomain;

            public Adapter()
            {
            }

            public Adapter(UnityFusion.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
            {
                this.appdomain = appdomain;
                this.instance = instance;
            }

            public ILTypeInstance ILInstance
            {
                get { return instance; }
            }

            public override System.Single GetCost(Goap.Agent.Core.IActionReceiver agent,
                Goap.Agent.Core.IComponentReference references, Goap.Agent.Core.ITarget target)
            {
                if (mGetCost_1.CheckShouldInvokeBase(this.instance))
                    return base.GetCost(agent, references, target);
                else
                    return mGetCost_1.Invoke(this.instance, agent, references, target);
            }

            public override System.Single GetStoppingDistance()
            {
                if (mGetStoppingDistance_2.CheckShouldInvokeBase(this.instance))
                    return base.GetStoppingDistance();
                else
                    return mGetStoppingDistance_2.Invoke(this.instance);
            }

            public override System.Boolean IsInRange(Goap.Agent.Core.IMonoAgent agent, System.Single distance,
                Goap.Agent.Core.IActionData data, Goap.Agent.Core.IComponentReference references)
            {
                if (mIsInRange_3.CheckShouldInvokeBase(this.instance))
                    return base.IsInRange(agent, distance, data, references);
                else
                    return mIsInRange_3.Invoke(this.instance, agent, distance, data, references);
            }

            public override System.Boolean IsValid(Goap.Agent.Core.IActionReceiver agent,
                IActionDataAdapter.Adapter data)
            {
                if (mIsValid_4.CheckShouldInvokeBase(this.instance))
                    return base.IsValid(agent, data);
                else
                    return mIsValid_4.Invoke(this.instance, agent, data);
            }

            // public override IActionDataAdapter.Adapter CreateData()
            // {
            //     return mCreateData_5.Invoke(this.instance);
            // }

            public override void Created()
            {
                if (mCreated_6.CheckShouldInvokeBase(this.instance))
                    base.Created();
                else
                    mCreated_6.Invoke(this.instance);
            }

            public override void Start(Goap.Agent.Core.IMonoAgent agent,
                IActionDataAdapter.Adapter data)
            {
                if (mStart_7.CheckShouldInvokeBase(this.instance))
                    base.Start(agent, data);
                else
                    mStart_7.Invoke(this.instance, agent, data);
            }

            public override System.Boolean IsEnabled(Goap.Agent.Core.IActionReceiver receiver,
                Goap.Agent.Core.IComponentReference references)
            {
                if (mIsEnabled_8.CheckShouldInvokeBase(this.instance))
                    return base.IsEnabled(receiver, references);
                else
                    return mIsEnabled_8.Invoke(this.instance, receiver, references);
            }

            public override void BeforePerform(Goap.Agent.Core.IMonoAgent agent,
                IActionDataAdapter.Adapter data)
            {
                if (mBeforePerform_9.CheckShouldInvokeBase(this.instance))
                    base.BeforePerform(agent, data);
                else
                    mBeforePerform_9.Invoke(this.instance, agent, data);
            }

            public override Goap.Agent.Core.IActionRunState Perform(Goap.Agent.Core.IMonoAgent agent,
                IActionDataAdapter.Adapter data, Goap.Agent.Core.IActionContext context)
            {
                return mPerform_10.Invoke(this.instance, agent, data, context);
            }

            public override void End(Goap.Agent.Core.IMonoAgent agent,
                IActionDataAdapter.Adapter data)
            {
                if (mEnd_11.CheckShouldInvokeBase(this.instance))
                    base.End(agent, data);
                else
                    mEnd_11.Invoke(this.instance, agent, data);
            }

            public override void Stop(Goap.Agent.Core.IMonoAgent agent,
                IActionDataAdapter.Adapter data)
            {
                if (mStop_12.CheckShouldInvokeBase(this.instance))
                    base.Stop(agent, data);
                else
                    mStop_12.Invoke(this.instance, agent, data);
            }

            public override void Complete(Goap.Agent.Core.IMonoAgent agent,
                IActionDataAdapter.Adapter data)
            {
                if (mComplete_13.CheckShouldInvokeBase(this.instance))
                    base.Complete(agent, data);
                else
                    mComplete_13.Invoke(this.instance, agent, data);
            }

            public IActionData GetData()
            {
                return mGetData_14.Invoke(this.instance);
            }

            public override IActionDataAdapter.Adapter CreateData()
            {
                return mCreateData_5.Invoke(this.instance);
            }

            public void Start(Goap.Agent.Core.IMonoAgent agent, Goap.Agent.Core.IActionData data)
            {
                mStart_15.Invoke(this.instance, agent, data);
            }

            public void BeforePerform(Goap.Agent.Core.IMonoAgent agent, Goap.Agent.Core.IActionData data)
            {
                mBeforePerform_16.Invoke(this.instance, agent, data);
            }

            public Goap.Agent.Core.IActionRunState Perform(Goap.Agent.Core.IMonoAgent agent,
                Goap.Agent.Core.IActionData data, Goap.Agent.Core.IActionContext context)
            {
                return mPerform_17.Invoke(this.instance, agent, data, context);
            }

            public void Stop(Goap.Agent.Core.IMonoAgent agent, Goap.Agent.Core.IActionData data)
            {
                mStop_18.Invoke(this.instance, agent, data);
            }

            public void Complete(Goap.Agent.Core.IMonoAgent agent, Goap.Agent.Core.IActionData data)
            {
                mComplete_19.Invoke(this.instance, agent, data);
            }

            public System.Boolean IsEnabled(Goap.Agent.Core.IActionReceiver agent)
            {
                return mIsEnabled_20.Invoke(this.instance, agent);
            }

            public void Enable()
            {
                mEnable_21.Invoke(this.instance);
            }

            public void Disable(Goap.Agent.Core.IActionDisabler disabler)
            {
                mDisable_22.Invoke(this.instance, disabler);
            }

            public override IActionPropertiesAdapter.Adapter Properties
            {
                get
                {
                    if (mget_Properties_0.CheckShouldInvokeBase(this.instance))
                        return base.Properties;
                    else
                        return mget_Properties_0.Invoke(this.instance);
                }
            }

            public override string ToString()
            {
                IMethod m = appdomain.ObjectType.GetMethod("ToString", 0);
                m = instance.Type.GetVirtualMethod(m);
                if (m == null || m is ILMethod)
                {
                    if (!isInvokingToString)
                    {
                        isInvokingToString = true;
                        string res = instance.ToString();
                        isInvokingToString = false;
                        return res;
                    }
                    else
                        return instance.Type.FullName;
                }
                else
                    return instance.Type.FullName;
            }
        }
    }
}