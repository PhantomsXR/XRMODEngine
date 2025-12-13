// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.AuthenticationSystem.Runtime.
// //
// // The Nin1 cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using AuthenticationModule.Runtime;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public enum PlatformProviderType
    {
        Apple,
        Google,
        Meta,
        Rokid,
        Pico
    }

    public static class PlatformProviderFactory
    {
        public static IPlatformSignInProvider GetPlatformProvider(PlatformProviderType _providerType,
            string _clientId = null, string _clientSecret = null)
        {
            switch (_providerType)
            {
                case PlatformProviderType.Apple:
                    return new SignInWithAppleProvider();
                case PlatformProviderType.Google:
                    return new SingInWithGooglePlayProvider();
                case PlatformProviderType.Meta:
                    return new SignInWithMetaProvider();
                case PlatformProviderType.Rokid:
                    return new SignInWithRokidProvider(_clientId, _clientSecret);
                case PlatformProviderType.Pico:
                    return new SignInWithPicoProvider();
                default:
                    throw new ArgumentOutOfRangeException(nameof(_providerType), _providerType, null);
            }
        }
    }
}