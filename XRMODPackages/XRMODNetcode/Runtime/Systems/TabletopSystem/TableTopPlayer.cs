// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.NetcodeModule.Runtime.Gameplay;

namespace Phantom.XRMOD.NetcodeModule.Runtime.TableSystem
{
    public class TableTopPlayer : NGOPlayerBase
    {
        private TableTopNetworkedSystem tableTopNetworkedSystem;

        private void Awake()
        {
            tableTopNetworkedSystem = FindFirstObjectByType<TableTopNetworkedSystem>();
        }

        public override void OnNetworkSpawn()
        {
            base.OnNetworkSpawn();
            // var tmp_PlayerRef = NetworkManager.SetLocalPlayerRef(NetworkObject.OwnerClientId);
            // tableTopManager.PlayerJoin(tmp_PlayerRef);
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
            // if (NetworkManager != null && NetworkManager.IsConnectedClient)
            // {
            //     tableTopManager.PlayerLeft(NetworkManager.LocalPlayerRef());
            // }
        }
    }
}