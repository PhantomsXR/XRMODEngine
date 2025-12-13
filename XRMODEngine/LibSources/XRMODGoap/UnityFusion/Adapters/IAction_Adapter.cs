using System;
using System.Reflection;
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
    public class IActionAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get { return typeof(Goap.Agent.Core.IAction); }
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

        public class Adapter : Goap.Agent.Core.IAction, CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.ActionMoveMode> mGetMoveMode_0 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.ActionMoveMode>("GetMoveMode");

            CrossBindingFunctionInfo<System.Single> mGetStoppingDistance_1 =
                new CrossBindingFunctionInfo<System.Single>("GetStoppingDistance");

            CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, System.Single, Goap.Agent.Core.IActionData,
                Goap.Agent.Core.IComponentReference, System.Boolean> mIsInRange_2 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, System.Single, Goap.Agent.Core.IActionData,
                    Goap.Agent.Core.IComponentReference, System.Boolean>("IsInRange");

            CrossBindingFunctionInfo<Goap.Agent.Core.IActionData> mGetData_3 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IActionData>("GetData");

            CrossBindingMethodInfo mCreated_4 = new CrossBindingMethodInfo("Created");

            CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IActionData, System.Boolean>
                mIsValid_5 =
                    new CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IActionData,
                        System.Boolean>("IsValid");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData> mStart_6 =
                new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData>("Start");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData> mBeforePerform_7 =
                new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData>("BeforePerform");

            CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData,
                Goap.Agent.Core.IActionContext, Goap.Agent.Core.IActionRunState> mPerform_8 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData,
                    Goap.Agent.Core.IActionContext, Goap.Agent.Core.IActionRunState>("Perform");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData> mStop_9 =
                new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData>("Stop");

            CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData> mComplete_10 =
                new CrossBindingMethodInfo<Goap.Agent.Core.IMonoAgent, Goap.Agent.Core.IActionData>("Complete");

            CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, System.Boolean, System.Boolean> mIsExecutable_11 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, System.Boolean, System.Boolean>(
                    "IsExecutable");

            CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, System.Boolean> mIsEnabled_12 =
                new CrossBindingFunctionInfo<Goap.Agent.Core.IActionReceiver, System.Boolean>("IsEnabled");

            CrossBindingMethodInfo mEnable_13 = new CrossBindingMethodInfo("Enable");

            CrossBindingMethodInfo<Goap.Agent.Core.IActionDisabler> mDisable_14 =
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

            public Goap.Agent.Core.ActionMoveMode GetMoveMode(Goap.Agent.Core.IMonoAgent agent)
            {
                return mGetMoveMode_0.Invoke(this.instance, agent);
            }

            public System.Single GetStoppingDistance()
            {
                return mGetStoppingDistance_1.Invoke(this.instance);
            }

            public System.Boolean IsInRange(Goap.Agent.Core.IMonoAgent agent, System.Single distance,
                Goap.Agent.Core.IActionData data, Goap.Agent.Core.IComponentReference references)
            {
                return mIsInRange_2.Invoke(this.instance, agent, distance, data, references);
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

                return mGetData_3.Invoke(this.instance);
            }

            public void Created()
            {
                mCreated_4.Invoke(this.instance);
            }

            public System.Boolean IsValid(Goap.Agent.Core.IActionReceiver agent, Goap.Agent.Core.IActionData data)
            {
                return mIsValid_5.Invoke(this.instance, agent, data);
            }

            public void Start(Goap.Agent.Core.IMonoAgent agent, Goap.Agent.Core.IActionData data)
            {
                mStart_6.Invoke(this.instance, agent, data);
            }

            public void BeforePerform(Goap.Agent.Core.IMonoAgent agent, Goap.Agent.Core.IActionData data)
            {
                mBeforePerform_7.Invoke(this.instance, agent, data);
            }

            public Goap.Agent.Core.IActionRunState Perform(Goap.Agent.Core.IMonoAgent agent,
                Goap.Agent.Core.IActionData data, Goap.Agent.Core.IActionContext context)
            {
                var tmp_CreateMethod = instance.Type.ReflectionType.GetMethod("Perform");
                if (tmp_CreateMethod != null)
                {
                    var tmp_State = tmp_CreateMethod.Invoke(instance.CLRInstance, null);
                    Debug.Log(tmp_State);
                    return tmp_State as Goap.Agent.Core.IActionRunState;
                }

                var tmp_Data = mPerform_8.Invoke(this.instance, agent, data, context);
                return tmp_Data;
            }

            public void Stop(Goap.Agent.Core.IMonoAgent agent, Goap.Agent.Core.IActionData data)
            {
                mStop_9.Invoke(this.instance, agent, data);
            }

            public void Complete(Goap.Agent.Core.IMonoAgent agent, Goap.Agent.Core.IActionData data)
            {
                mComplete_10.Invoke(this.instance, agent, data);
            }

            public System.Boolean IsExecutable(Goap.Agent.Core.IActionReceiver agent, System.Boolean conditionsMet)
            {
                return mIsExecutable_11.Invoke(this.instance, agent, conditionsMet);
            }

            public System.Boolean IsEnabled(Goap.Agent.Core.IActionReceiver agent)
            {
                return mIsEnabled_12.Invoke(this.instance, agent);
            }

            public void Enable()
            {
                mEnable_13.Invoke(this.instance);
            }

            public void Disable(Goap.Agent.Core.IActionDisabler disabler)
            {
                mDisable_14.Invoke(this.instance, disabler);
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