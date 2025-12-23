/*===============================================================================
Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XRMODEngineCore.Runtime.

The ARMOD-SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Generic singleton template for non-MonoBehaviour classes.
    /// Provides a thread-safe way to access a single instance of a class.
    /// </summary>
    /// <typeparam name="T">The type of the class to make a singleton (must have a parameterless constructor).</typeparam>
    public class SingletonTemplate<T> where T : class, new()
    {
        private static T _SINGLETON;

        /// <summary>
        /// Protected constructor to prevent instantiation outside of the template.
        /// </summary>
        protected SingletonTemplate()
        {
        }

        /// <summary>
        /// Gets the singleton instance of type <typeparamref name="T"/>.
        /// </summary>
        public static T GetInstance => _SINGLETON ??= new T();
    }
}