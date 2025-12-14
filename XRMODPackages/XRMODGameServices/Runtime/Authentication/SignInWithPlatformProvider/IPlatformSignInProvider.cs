// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the AuthenticationSystem.Runtime.
// //
// // The Nin1 cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public interface IPlatformSignInProvider
    {
        void Initialize(Action _onSuccess = null, Action _onFailure = null);
        void SignIn(Action<UserInfoModel> _successCallback, Action<string> _failedCallback);
    }
}