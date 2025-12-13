// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Models.Runtime;
using UnityEngine;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.Models;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    public class OfflineLicenseValidator : ICommand
    {
        public void Execute()
        {
            JsonWebToken.JsonSerializer = new LitJsonSerializer();
            var tmp_Token = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value.dashboardConfig.token
                .Split("|");
            var tmp_OfflineToken = JsonWebToken.DecodeToObject<OfflineLicense>(tmp_Token[0], tmp_Token[1]);
            if (tmp_Token[1].Decrypt() != Application.identifier)
                throw new SignatureTimeExpirationException("Identifier Name not matched");
            JsonWebToken.ValidateToken(tmp_OfflineToken.expiration_time);
        }
    }
}