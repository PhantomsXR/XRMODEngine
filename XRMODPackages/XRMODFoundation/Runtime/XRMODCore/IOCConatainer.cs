/*===============================================================================
Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XRMODEngineCore.Runtime.

The XRMODEngineCore.Runtime cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Static access point for the global <see cref="Ioc"/> container instance.
    /// Provides a convenient way to retrieve the singleton IoC instance.
    /// </summary>
    public static class IocContainer
    {
        private static Ioc instance;

        /// <summary>
        /// Gets the singleton <see cref="Ioc"/> instance. Initializes it if necessary.
        /// </summary>
        public static Ioc GetIoc => instance ??= new Ioc();
    }
}