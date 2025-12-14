// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Core.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine; 

namespace Phantom.XRMOD.Core.Runtime
{
    public class UpdateBatchOptimization : MonoBehaviour
    {
        private readonly List<Action> updateActions = new();
        private readonly List<Action> lateUpdateActions = new();
        private readonly List<Action> fixedUpdateActions = new();

        private void Update()
        {
            for (int tmp_I = 0; tmp_I < updateActions.Count; tmp_I++)
            {
                updateActions[tmp_I]?.Invoke();
            }
        }

        private void LateUpdate()
        {
            for (int tmp_I = 0; tmp_I < lateUpdateActions.Count; tmp_I++)
            {
                lateUpdateActions[tmp_I]?.Invoke();
            }
        }

        private void FixedUpdate()
        {
            for (int tmp_I = 0; tmp_I < fixedUpdateActions.Count; tmp_I++)
            {
                fixedUpdateActions[tmp_I]?.Invoke();
            }
        }


        #region Public API

        /// <summary>
        /// Register a callback to be called every frame in Update.
        /// </summary>
        public void RegisterUpdate(Action _action)
        {
            if (_action != null && !updateActions.Contains(_action))
                updateActions.Add(_action);
        }

        /// <summary>
        /// Unregister a previously registered Update callback.
        /// </summary>
        public void UnregisterUpdate(Action _action)
        {
            if (_action != null)
                updateActions.Remove(_action);
        }

        /// <summary>
        /// Register a callback to be called every frame in LateUpdate.
        /// </summary>
        public void RegisterLateUpdate(Action _action)
        {
            if (_action != null && !lateUpdateActions.Contains(_action))
                lateUpdateActions.Add(_action);
        }

        /// <summary>
        /// Unregister a previously registered LateUpdate callback.
        /// </summary>
        public void UnregisterLateUpdate(Action _action)
        {
            if (_action != null)
                lateUpdateActions.Remove(_action);
        }

        /// <summary>
        /// Register a callback to be called every physics tick in FixedUpdate.
        /// </summary>
        public void RegisterFixedUpdate(Action _action)
        {
            if (_action != null && !fixedUpdateActions.Contains(_action))
                fixedUpdateActions.Add(_action);
        }

        /// <summary>
        /// Unregister a previously registered FixedUpdate callback.
        /// </summary>
        public void UnregisterFixedUpdate(Action _action)
        {
            if (_action != null)
                fixedUpdateActions.Remove(_action);
        }

        #endregion
    }
}