using System;
using System.Collections.Generic;
using System.Reflection;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;
using UnityFusion.CLRBinding.Adapter;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif
namespace UnityFusion.Runtime.Generated
{
    class CLRBindings
    {
//will auto register in unity
#if UNITY_5_3_OR_NEWER
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
#endif
        static private void RegisterBindingAction()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(RegisterAdapter,
                nameof(ActionParameterDataType.RegisterExtraAdaptor));
            UnityFusion.Runtime.CLRBinding.CLRBindingUtils.RegisterBindingAction(Initialize);
        }

        private static void RegisterAdapter(BaseNotificationData _data)
        {
            if (_data is not UnityFusionArgs tmp_UnityFusionNotificationData) return;
            var tmp_AppDomainOfUnityFusion = tmp_UnityFusionNotificationData.AppDomain as AppDomain;

            RegisterAdaters(tmp_AppDomainOfUnityFusion);
        }

        internal static UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector3>
            s_UnityEngine_Vector3_Binding_Binder = null;

        internal static UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector2>
            s_UnityEngine_Vector2_Binding_Binder = null;

        internal static UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Quaternion>
            s_UnityEngine_Quaternion_Binding_Binder = null;

        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            app.DelegateManager.RegisterMethodDelegate<Goap.Agent.Core.ITarget>();
            app.DelegateManager.RegisterMethodDelegate<Goap.Agent.Core.ITarget, System.Boolean>();
            app.DelegateManager.RegisterMethodDelegate<Goap.Agent.Core.IAction>();
            app.DelegateManager.RegisterMethodDelegate<Goap.Core.IGoapAction>();
            app.DelegateManager.RegisterFunctionDelegate<Goap.Core.SenseValue>();
            app.DelegateManager.RegisterMethodDelegate<Goap.Core.IGoalRequest>();
            app.DelegateManager.RegisterMethodDelegate<Goap.Core.IGoal>();

            app.DelegateManager.RegisterDelegateConvertor<Goap.Core.GoalDelegate>((act) =>
            {
                return new Goap.Core.GoalDelegate((goal) => { ((Action<Goap.Core.IGoal>) act)(goal); });
            });

            app.DelegateManager.RegisterDelegateConvertor<Goap.Core.GoalRequestDelegate>((act) =>
            {
                return new Goap.Core.GoalRequestDelegate((goal) =>
                {
                    ((Action<Goap.Core.IGoalRequest>) act)(goal);
                });
            });

            app.DelegateManager.RegisterDelegateConvertor<Goap.Core.GoapActionDelegate>((act) =>
            {
                return new Goap.Core.GoapActionDelegate((action) =>
                {
                    ((Action<Goap.Core.IGoapAction>) act)(action);
                });
            });

            app.DelegateManager.RegisterDelegateConvertor<Goap.Agent.Core.TargetDelegate>((act) =>
            {
                return new Goap.Agent.Core.TargetDelegate((target) =>
                {
                    ((Action<Goap.Agent.Core.ITarget>) act)(target);
                });
            });

            app.DelegateManager.RegisterDelegateConvertor<Goap.Agent.Core.TargetRangeDelegate>((act) =>
            {
                return new Goap.Agent.Core.TargetRangeDelegate((target, inRange) =>
                {
                    ((Action<Goap.Agent.Core.ITarget, System.Boolean>) act)(target, inRange);
                });
            });
            app.DelegateManager.RegisterDelegateConvertor<Goap.Agent.Core.EmptyDelegate>((act) =>
            {
                return new Goap.Agent.Core.EmptyDelegate(() => { ((Action) act)(); });
            });

            app.DelegateManager.RegisterDelegateConvertor<Goap.Agent.Core.ActionDelegate>((act) =>
            {
                return new Goap.Agent.Core.ActionDelegate((action) =>
                {
                    ((Action<Goap.Agent.Core.IAction>) act)(action);
                });
            });


            app.DelegateManager
                .RegisterFunctionDelegate<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference,
                    Goap.Core.SenseValue>();

            app.DelegateManager
                .RegisterFunctionDelegate<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference,
                    Goap.Agent.Core.ITarget, Goap.Agent.Core.ITarget>();
            
            Goap_Runtime_GoapBehaviour_Binding.Register(app);
            Goap_Runtime_GoalBuilder_1_Binding.Register(app);
            Goap_Core_IGoapAgentEvents_Binding.Register(app);
            Goap_Core_IGoapConfig_Binding.Register(app);
            Goap_Agent_Core_IActionReceiver_Binding.Register(app);
            Goap_Agent_Core_IComponentReference_Binding.Register(app);
            Goap_Agent_Runtime_AgentBehaviour_Binding.Register(app);
            Goap_Agent_Core_IAgentEvents_Binding.Register(app);
            Goap_Agent_Core_ITarget_Binding.Register(app);
            Goap_Agent_Core_IActionContext_Binding.Register(app);
            Goap_Agent_Core_IMonoBehaviour_Binding.Register(app);
            Goap_Runtime_GoapActionProvider_Binding.Register(app);
            Goap_Runtime_CapabilityBuilder_Binding.Register(app);
            Goap_Runtime_AgentTypeBuilder_Binding.Register(app);
            Goap_Agent_Core_IActionData_Binding.Register(app);
            Goap_Agent_Core_IActionState_Binding.Register(app);
            Goap_Agent_Core_ILogger_Binding.Register(app);
            Goap_Agent_Runtime_ActionDisabler_Binding.Register(app);
            Goap_Agent_Runtime_ActionProviderBase_Binding.Register(app);
            Goap_Agent_Runtime_Extensions_Binding.Register(app);
            Goap_Core_IGoalResult_Binding.Register(app);
            Goap_Core_SenseValue_Binding.Register(app);
            Goap_Runtime_ActionRunState_Binding.Register(app);
            Goap_Runtime_AgentTypeBehaviour_Binding.Register(app);
            Goap_Runtime_SensorTimer_Binding.Register(app);
            Goap_Runtime_PositionTarget_Binding.Register(app);
            Goap_Runtime_AgentTypeFactoryBase_Binding.Register(app);
            Goap_Runtime_AgentType_Binding.Register(app);
            Goap_Agent_Core_IAction_Binding.Register(app);
            Goap_Runtime_AgentTypeJobRunner_Binding.Register(app);
            Goap_Agent_Runtime_ActionRunner_Binding.Register(app);
            Goap_Runtime_CapabilityMultiSensor_Binding.Register(app);
            Goap_Runtime_MultiSensorBase_Binding.Register(app);
            Goap_Runtime_MultiSensorBuilder_Binding.Register(app);
            Goap_Runtime_MultiSensorConfig_Binding.Register(app);
            Goap_Agent_Runtime_DataReferenceInjector_Binding.Register(app);
            Goap_Runtime_GoalResult_Binding.Register(app);
            Goap_Runtime_TransformTarget_Binding.Register(app);
            Goap_Runtime_WorldKeyBase_Binding.Register(app);
            Goap_Runtime_WorldKeyBuilder_Binding.Register(app);
            Goap_Runtime_WorldKey_Binding.Register(app); 
            Goap_Runtime_TargetKeyBase_Binding.Register(app);
            Goap_Runtime_GlobalTargetSensorBase_Binding.Register(app);
            Goap_Runtime_LocalTargetSensorBase_Binding.Register(app);


            UnityFusion_CLRBinding_Adapter_AgentTypeFactoryBaseAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_CapabilityFactoryBaseAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_GlobalWorldSensorBaseAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_GoalBaseAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_GoapActionBase2Adapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_GoapActionBaseAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_GoapConfigInitializerBaseAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_IActionDataAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_IActionPropertiesAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_ITargetAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_LocalTargetSensorBaseAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_LocalWorldSensorBaseAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_MonoCapabilityFactoryBaseAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_MultiSensorBaseAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_ScriptableCapabilityFactoryBaseAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_TargetKeyBaseAdapter_Binding.Register(app);
            UnityFusion_CLRBinding_Adapter_WorldKeyBaseAdapter_Binding.Register(app);
            System_Collections_Generic_List_1_AgentTypeFactoryBase_Binding.Register(app);
            GoalBuilder_GoalBaseAdapter_Binding_Adapter_Binding.Register(app);
            TargetSensorBuilder_LocalTargetSensorBaseAdapter_Binding_Adapter_Binding.Register(app);
            WorldSensorBuilder_LocalWorldSensorBaseAdapter_Binding_Adapter_Binding.Register(app);
            LocalTargetSensorBaseAdapter_Binding_Adapter_Binding.Register(app);
            Goap_Runtime_ActionBuilder_1_Adapter_Binding.Register(app);
            ActionBuilder_GoapActionBase_Binding.Register(app);

            UnityFusion.CLR.TypeSystem.CLRType __clrType = null;
            __clrType = (UnityFusion.CLR.TypeSystem.CLRType) app.GetType(typeof(UnityEngine.Vector3));
            s_UnityEngine_Vector3_Binding_Binder =
                __clrType.ValueTypeBinder as UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector3>;
            __clrType = (UnityFusion.CLR.TypeSystem.CLRType) app.GetType(typeof(UnityEngine.Vector2));
            s_UnityEngine_Vector2_Binding_Binder =
                __clrType.ValueTypeBinder as UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector2>;
            __clrType = (UnityFusion.CLR.TypeSystem.CLRType) app.GetType(typeof(UnityEngine.Quaternion));
            s_UnityEngine_Quaternion_Binding_Binder =
                __clrType.ValueTypeBinder as UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Quaternion>;
        }

        private static void RegisterAdaters(AppDomain _domain)
        {
            _domain.RegisterCrossBindingAdaptor(new IActionDataAdapter());
            _domain.RegisterCrossBindingAdaptor(new GoapConfigInitializerBaseAdapter());
            _domain.RegisterCrossBindingAdaptor(new WorldKeyBaseAdapter());
            _domain.RegisterCrossBindingAdaptor(new TargetKeyBaseAdapter());
            _domain.RegisterCrossBindingAdaptor(new LocalTargetSensorBaseAdapter());
            _domain.RegisterCrossBindingAdaptor(new LocalWorldSensorBaseAdapter());
            _domain.RegisterCrossBindingAdaptor(new GoalBaseAdapter());
            _domain.RegisterCrossBindingAdaptor(new GlobalWorldSensorBaseAdapter());
            _domain.RegisterCrossBindingAdaptor(new MultiSensorBaseAdapter());
            _domain.RegisterCrossBindingAdaptor(new CapabilityFactoryBaseAdapter());
            _domain.RegisterCrossBindingAdaptor(new ScriptableCapabilityFactoryBaseAdapter());
            _domain.RegisterCrossBindingAdaptor(new MonoCapabilityFactoryBaseAdapter());
            _domain.RegisterCrossBindingAdaptor(new AgentTypeFactoryBaseAdapter());
            _domain.RegisterCrossBindingAdaptor(new GoapActionBaseAdapter());
            _domain.RegisterCrossBindingAdaptor(new GoapActionBase2Adapter());
            _domain.RegisterCrossBindingAdaptor(new ITargetAdapter());
            _domain.RegisterCrossBindingAdaptor(new IActionPropertiesAdapter());
            _domain.RegisterCrossBindingAdaptor(new IActionAdapter());
            _domain.RegisterCrossBindingAdaptor(new IGoapActionAdapter());
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE UnityFusion Appdomain destroy
        /// </summary>
        public static void Shutdown(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            s_UnityEngine_Vector3_Binding_Binder = null;
            s_UnityEngine_Vector2_Binding_Binder = null;
            s_UnityEngine_Quaternion_Binding_Binder = null;
        }
    }
}