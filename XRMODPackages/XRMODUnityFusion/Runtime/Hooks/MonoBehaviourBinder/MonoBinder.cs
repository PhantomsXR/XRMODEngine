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
using System.Linq;
using UnityEngine;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.Runtime.Enviorment;
using Phantom.XRMOD.ActionNotification.Runtime;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public class MonoBinder : MonoBehaviour
    {
        public List<MonoData> ScriptList;
        public RenderStateType DefaultRenderState = RenderStateType.None;

        private readonly RuntimeFieldHandlerFactory runtimeFieldHandlerFactory = new(new DbAssetProvider());

        private readonly List<IScriptCreation> scriptCreations = new()
        {
            new MultipleInheritanceCreation(),
            new UIMonoBehaviourCreation(),
            new XRMODBehaviourCreation(),
        };

        private ScriptInstantiator scriptInstantiator;
        private IDataBinder dataBinder = new DataBinding();
        private int addedScriptCounter = 0;
        private bool isConverting;


        private void Awake()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(ProcessMonoBinderTrigger,
                nameof(ActionParameterDataType.ProcessMonoBinder));
        }

        private void OnDestroy()
        {
            addedScriptCounter = 0;
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.ProcessMonoBinder),
                ProcessMonoBinderTrigger);
        }

        public void ProcessMonoBinderTrigger(BaseNotificationData _baseNotification)
        {
            if (isConverting) return;
            isConverting = true;
            BinderManager.Instance.DoBind(this);
        }


        internal void AddRuntimeScript(MonoData _data)
        {
            try
            {
                if (DefaultRenderState == RenderStateType.None)
                {
                    DefaultRenderState = gameObject.activeSelf
                        ? RenderStateType.Visiable
                        : RenderStateType.Hiden;
                }

                if (addedScriptCounter >= ScriptList.Count) return;
                scriptInstantiator ??= new ScriptInstantiator(scriptCreations);
                scriptInstantiator.InstantiateScript(gameObject, _data);
                addedScriptCounter++;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogException(tmp_Exception);
            }
        }

        internal void SetValues(MonoData _monoData)
        {
            if (addedScriptCounter == 0)
            {
                Debug.Log($"{gameObject.name}'s {_monoData.ClassName} Script not added");
                return;
            }

            if (gameObject.name.Contains("RefAssetsTest"))
            {
            }

            dataBinder.BindData(_monoData);
        }

        internal void ActiveScript(MonoData _data)
        {
            try
            {
                string tmp_FullClassName =
                    $"{_data.ClassNamespace + (_data.ClassNamespace == "" ? "" : ".")}{_data.ClassName}";
                IType tmp_LoadedType = CodesHook.GetAppDomain.LoadedTypes[tmp_FullClassName];
                var tmp_ClrInstance = gameObject.GetComponents<CrossBindingAdaptorType>()
                    .Last(_clr => _clr.ILInstance.Type == tmp_LoadedType as ILType);

                if (_data.BoundData == false && _data.Fields != null && _data.Fields.Count > 0)
                {
                    Debug.LogWarning(
                        $"[Convert Error]:The {tmp_FullClassName} script on {name} lost data.This may cause some bugs.");
                }


                if (tmp_ClrInstance.GetType().IsSubclassOf(typeof(MonoBehaviour)))
                {
                    ((MonoBehaviour) tmp_ClrInstance).enabled = true;
                }

                _data.Activated = true;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError($"Error at:{gameObject.name}.{_data.ClassName}");
                Debug.LogException(tmp_Exception);
                throw;
            }
        }

        internal void Remove()
        {
            if (gameObject.scene.IsValid())
                Destroy(this);
            else
                DestroyImmediate(this, true);
        }

        internal void SetupGameObjectRenderState(bool _render)
        {
            gameObject.SetActive(_render);
        }
    }
}