// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.GameServices.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;

namespace  Phantom.XRMOD.GameServices.Runtime
{
    public class SignInWithPicoProvider:IPlatformSignInProvider
    {
        public void Initialize(Action _onSuccess = null, Action _onFailure = null)
        {
            throw new NotImplementedException();
        }

        public void SignIn(Action<UserInfoModel> _successCallback, Action<string> _failedCallback)
        {
            throw new NotImplementedException();
        }
    }
}