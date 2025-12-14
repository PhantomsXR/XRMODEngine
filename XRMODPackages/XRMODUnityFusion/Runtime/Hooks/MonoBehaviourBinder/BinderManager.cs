// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System;
using System.Collections.Generic;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public enum BindingPhase
    {
        AddClass,
        SetValue,
        Activate,
        SetRenderer
    }
    
    public class BinderManager : MonoBehaviourSingleton<BinderManager>
    {
        private BindingOrchestrator bindingOrchestrator;
        

        private void Awake()
        {
            var tmp_BindingSteps = new List<IBindingStep>()
            {
                new AddRuntimeScriptStep(),
                new SetValueStep(),
                new ActivateStep(),
                new RenderGameObjectStep()
            };
            bindingOrchestrator = new BindingOrchestrator(tmp_BindingSteps);
            ActionNotificationCenter.DefaultCenter.AddObserver(DoBindingBatch,
                nameof(ActionParameterDataType.ProcessMonoBinderBatch));
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            ActionNotificationCenter.DefaultCenter.RemoveObserver(
                nameof(ActionParameterDataType.ProcessMonoBinderBatch), DoBindingBatch);
        }

        private void DoBindingBatch(BaseNotificationData _obj)
        {
            var tmp_MonoBinders =
                Object.FindObjectsByType<MonoBinder>(FindObjectsInactive.Include, FindObjectsSortMode.InstanceID);
            DoBind(tmp_MonoBinders);
        }

        public void DoBind(List<MonoBinder> _monoBinders)
        {
            DoBind(_monoBinders.ToArray());
        }

        public async void DoBind(MonoBinder[] _monoBinders)
        {
            try
            {
                //var tmp_Reverse = _monoBinders.Reverse();
                await bindingOrchestrator.BindScriptBatch(_monoBinders);
            }
            catch (Exception tmp_E)
            {
                Debug.LogException(tmp_E);
                throw;
            }
        }

        public async void DoBind(MonoBinder _monoBinder)
        {
            try
            {
                await bindingOrchestrator.BindScript(_monoBinder);
            }
            catch (Exception tmp_E)
            {
                Debug.LogException(tmp_E);
                throw;
            }
        }

        public async void DoBind()
        {
            try
            {
                var tmp_AllMonoBinders =
                    FindObjectsByType<MonoBinder>(FindObjectsInactive.Include, FindObjectsSortMode.None);
                if (tmp_AllMonoBinders is {Length: > 0})
                {
                    await bindingOrchestrator.BindScriptBatch(tmp_AllMonoBinders);
                }
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                throw;
            }
        }
    }
}