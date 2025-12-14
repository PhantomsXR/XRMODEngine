using System;
using System.Reflection;
using Goap.Agent.Core;
using UnityEngine;
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
    public class IGoapActionAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get { return typeof(Goap.Core.IGoapAction); }
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

        public class Adapter : Goap.Core.IGoapAction, CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference,
                Goap.Agent.Core.ITarget, System.Single> mGetCost_0 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference,
                    Goap.Agent.Core.ITarget, System.Single>("GetCost");

            CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.ActionMoveMode> mGetMoveMode_1 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.ActionMoveMode>("GetMoveMode");

            CrossBindingFunctionInfo<System.Single> mGetStoppingDistance_2 =
                new CrossBindingFunctionInfo<System.Single>("GetStoppingDistance");

            CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, System.Single, Goap.Agent.Core.IActionData,
                Goap.Agent.Core.IComponentReference, System.Boolean> mIsInRange_3 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, System.Single, Goap.Agent.Core.IActionData,
                    Goap.Agent.Core.IComponentReference, System.Boolean>("IsInRange");

            CrossBindingFunctionInfo<Goap.Agent.Core.IActionData> mGetData_4 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IActionData>("GetData");

            CrossBindingMethodInfo mCreated_5 = new CrossBindingMethodInfo("Created");

            CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IActionData, System.Boolean>
                mIsValid_6 =
                    new CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IActionData,
                        System.Boolean>("IsValid");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData> mStart_7 =
                new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData>("Start");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData> mBeforePerform_8 =
                new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData>("BeforePerform");

            CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData,
                Goap.Agent.Core.IActionContext, Goap.Agent.Core.IActionRunState> mPerform_9 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData,
                    Goap.Agent.Core.IActionContext, Goap.Agent.Core.IActionRunState>("Perform");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData> mStop_10 =
                new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData>("Stop");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData> mComplete_11 =
                new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData>("Complete");

            CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, System.Boolean, System.Boolean> mIsExecutable_12 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, System.Boolean, System.Boolean>(
                    "IsExecutable");

            CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, System.Boolean> mIsEnabled_13 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, System.Boolean>("IsEnabled");

            CrossBindingMethodInfo mEnable_14 = new CrossBindingMethodInfo("Enable");

            CrossBindingMethodInfo<Goap.Agent.Core.IActionDisabler> mDisable_15 =
                new CrossBindingMethodInfo<Goap.Agent.Core.IActionDisabler>("Disable");

            CrossBindingFunctionInfo<Goap.Core.IActionConfig> mget_Config_16 =
                new CrossBindingFunctionInfo<Goap.Core.IActionConfig>("get_Config");

            CrossBindingMethodInfo<Goap.Core.IActionConfig> mSetConfig_17 =
                new CrossBindingMethodInfo<Goap.Core.IActionConfig>("SetConfig");

            CrossBindingFunctionInfo<System.Guid> mget_Guid_18 = new CrossBindingFunctionInfo<System.Guid>("get_Guid");

            CrossBindingFunctionInfo<Goap.Core.IEffect[]> mget_Effects_19 =
                new CrossBindingFunctionInfo<Goap.Core.IEffect[]>("get_Effects");

            CrossBindingFunctionInfo<Goap.Core.ICondition[]> mget_Conditions_20 =
                new CrossBindingFunctionInfo<Goap.Core.ICondition[]>("get_Conditions");

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

            public System.Single GetCost(Goap.Agent.Core.IActionReceiver agent,
                Goap.Agent.Core.IComponentReference references, Goap.Agent.Core.ITarget target)
            {
                return mGetCost_0.Invoke(this.instance, agent, references, target);
            }

            public Goap.Agent.Core.ActionMoveMode GetMoveMode(Goap.Agent.Core.IMonoAgent agent)
            {
                return mGetMoveMode_1.Invoke(this.instance, agent);
            }

            public System.Single GetStoppingDistance()
            {
                return mGetStoppingDistance_2.Invoke(this.instance);
            }

            public System.Boolean IsInRange(Goap.Agent.Core.IMonoAgent agent, System.Single distance,
                Goap.Agent.Core.IActionData data, Goap.Agent.Core.IComponentReference references)
            {
                return mIsInRange_3.Invoke(this.instance, agent, distance, data, references);
            }

            private MethodInfo createDataMethod;

            public Goap.Agent.Core.IActionData GetData()
            {
                if (createDataMethod == null)
                    createDataMethod = instance.Type.ReflectionType.GetMethod("CreateData");

                if (createDataMethod != null)
                {
                    return createDataMethod.Invoke(instance.CLRInstance, null) as IActionDataAdapter.Adapter;
                }

                return mGetData_4.Invoke(this.instance);
            }

            public void Created()
            {
                mCreated_5.Invoke(this.instance);
            }

            public System.Boolean IsValid(Goap.Agent.Core.IActionReceiver agent, Goap.Agent.Core.IActionData data)
            {
                return mIsValid_6.Invoke(this.instance, agent, data);
            }

            public void Start(Goap.Agent.Core.IMonoAgent agent, Goap.Agent.Core.IActionData data)
            {
                mStart_7.Invoke(this.instance, agent, data);
            }

            public void BeforePerform(Goap.Agent.Core.IMonoAgent agent, Goap.Agent.Core.IActionData data)
            {
                mBeforePerform_8.Invoke(this.instance, agent, data);
            }

            public Goap.Agent.Core.IActionRunState Perform(Goap.Agent.Core.IMonoAgent agent,
                Goap.Agent.Core.IActionData data, Goap.Agent.Core.IActionContext context)
            {
                Debug.Log("IGOAP");

                return mPerform_9.Invoke(this.instance, agent, data, context);
            }

            public void Stop(Goap.Agent.Core.IMonoAgent agent, Goap.Agent.Core.IActionData data)
            {
                mStop_10.Invoke(this.instance, agent, data);
            }

            public void Complete(Goap.Agent.Core.IMonoAgent agent, Goap.Agent.Core.IActionData data)
            {
                mComplete_11.Invoke(this.instance, agent, data);
            }

            public System.Boolean IsExecutable(Goap.Agent.Core.IActionReceiver agent, System.Boolean conditionsMet)
            {
                return mIsExecutable_12.Invoke(this.instance, agent, conditionsMet);
            }

            public System.Boolean IsEnabled(Goap.Agent.Core.IActionReceiver agent)
            {
                return mIsEnabled_13.Invoke(this.instance, agent);
            }

            public void Enable(IActionReceiver receiver)
            {
                throw new NotImplementedException();
            }

            public void Disable(IActionReceiver receiver, IActionDisabler disabler)
            {
                throw new NotImplementedException();
            }

            public void Enable()
            {
                mEnable_14.Invoke(this.instance);
            }

            public void Disable(Goap.Agent.Core.IActionDisabler disabler)
            {
                mDisable_15.Invoke(this.instance, disabler);
            }

            public void SetConfig(Goap.Core.IActionConfig config)
            {
                mSetConfig_17.Invoke(this.instance, config);
            }

            public Goap.Core.IActionConfig Config
            {
                get { return mget_Config_16.Invoke(this.instance); }
            }

            public System.Guid Guid
            {
                get { return mget_Guid_18.Invoke(this.instance); }
            }

            public Goap.Core.IEffect[] Effects
            {
                get { return mget_Effects_19.Invoke(this.instance); }
            }

            public Goap.Core.ICondition[] Conditions
            {
                get { return mget_Conditions_20.Invoke(this.instance); }
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