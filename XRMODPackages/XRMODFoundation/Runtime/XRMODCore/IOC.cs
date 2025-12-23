/*===============================================================================
Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XRMODEngineCore.Runtime.

The XRMODEngineCore.Runtime cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// A simple Inversion of Control (IoC) container for dependency management within XRMOD.
    /// Handles registration and resolution of singletons, modules, and commands.
    /// </summary>
    public class Ioc
    {
        /// <summary>
        /// Gets the internal map of registered types and their corresponding instances.
        /// </summary>
        public Dictionary<Type, object> InstanceMap { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ioc"/> class.
        /// </summary>
        public Ioc()
        {
            InstanceMap = new Dictionary<Type, object>();
        }

        /// <summary>
        /// Registers an instance of a specific type in the container.
        /// </summary>
        /// <typeparam name="T">The type to register (must be a class).</typeparam>
        /// <param name="_instance">The instance to register.</param>
        /// <returns>True if the registration was successful; otherwise, false.</returns>
        public bool Register<T>(T _instance) where T : class
        {
            return InstanceMap.TryAdd(typeof(T), _instance);
        }

        /// <summary>
        /// Unregisters and releases an instance of a specific type from the container.
        /// </summary>
        /// <typeparam name="T">The type to unregister.</typeparam>
        /// <returns>True if the instance was found and removed; otherwise, false.</returns>
        public bool UnRegister<T>() where T : class
        {
            if (!InstanceMap.TryGetValue(typeof(T), out var tmp_Instance)) return false;

            switch (tmp_Instance)
            {
                case IReleaseCommand tmp_Command:
                    tmp_Command.Release();
                    break;
                case IModule tmp_Module:
                    tmp_Module.StopModule();
                    break;
            }

            InstanceMap.Remove(typeof(T));
            return true;
        }

        /// <summary>
        /// Unregisters and releases an instance of a specific type from the container.
        /// </summary>
        /// <param name="_type">The type to unregister.</param>
        /// <returns>True if the instance was found and removed; otherwise, false.</returns>
        public bool UnRegister(Type _type)
        {
            if (!InstanceMap.TryGetValue(_type, out var tmp_Instance)) return false;

            switch (tmp_Instance)
            {
                case IReleaseCommand tmp_Command:
                    tmp_Command.Release();
                    break;
                case IModule tmp_Module:
                    tmp_Module.StopModule();
                    break;
            }

            InstanceMap.Remove(_type);
            return true;
        }

        /// <summary>
        /// Unregisters and releases all instances currently stored in the container.
        /// </summary>
        public void UnRegisterAll()
        {
            List<Type> tmp_Objects = InstanceMap.Select(_pair => _pair.Key).ToList();
            foreach (var tmp_Obj in tmp_Objects)
            {
                UnRegister(tmp_Obj);
            }
        }

        /// <summary>
        /// Resolves an instance of a specific type from the container.
        /// </summary>
        /// <typeparam name="T">The type to resolve.</typeparam>
        /// <returns>The registered instance if found; otherwise, the default value for the type.</returns>
        public T Resolve<T>() where T : class
        {
            return InstanceMap.TryGetValue(typeof(T), out var tmp_ResolveObj) ? (T) tmp_ResolveObj : default(T);
        }
    }
}