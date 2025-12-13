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

using Fusion;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public class AuthorityTransferManager : NetworkBehaviour, IPlayerLeft
    {
        public void PlayerLeft(PlayerRef _player)
        {
            if (!Runner.IsSharedModeMasterClient)
                return;

            foreach (var tmp_Obj in Runner.GetAllNetworkObjects())
            {
                if ((tmp_Obj.Flags & NetworkObjectFlags.AllowStateAuthorityOverride) != 0 &&
                    tmp_Obj.StateAuthority == _player)
                {
                    tmp_Obj.RequestStateAuthority();
                }
            }
        }
    }
}