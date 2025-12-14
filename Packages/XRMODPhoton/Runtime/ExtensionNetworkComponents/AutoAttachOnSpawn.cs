// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Fusion;
using UnityEngine;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public class AutoAttachOnSpawn : NetworkBehaviour
    {
        public Space Space = Space.World;
        [Networked,Capacity(32)] public string ParentPath { get; set; }
        [Networked] private Vector3 SyncedPosition { get; set; }
        [Networked] private Vector3 SyncedEulerAngles { get; set; }


        public override void Spawned()
        {
            switch (Space)
            {
                case Space.World:
                    SyncedPosition = transform.position;
                    SyncedEulerAngles = transform.eulerAngles;
                    break;
                case Space.Self:
                    SyncedPosition = transform.localPosition;
                    SyncedEulerAngles = transform.localEulerAngles;
                    break;
            }

            TryAttach();
        }

        private void TryAttach()
        {
            if (string.IsNullOrEmpty(ParentPath))
            {
                Debug.LogWarning($"[AutoAttachOnSpawn] ParentPath is not set, binding is skipped.");
                return;
            }

            Transform tmp_Parent = GameObject.Find(ParentPath)?.transform;
            if (tmp_Parent == null)
            {
                Debug.LogWarning($"[AutoAttachOnSpawn] The parent object path cannot be found：{ParentPath}");
                return;
            }

            transform.SetParent(tmp_Parent);

            switch (Space)
            {
                case Space.Self:
                    transform.localPosition = SyncedPosition;
                    transform.localRotation = Quaternion.Euler(SyncedEulerAngles);
                    break;
                case Space.World:
                    transform.position = SyncedPosition;
                    transform.rotation = Quaternion.Euler(SyncedEulerAngles);
                    break;
            }
        }
    }
}