/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Core.Runtime.

The QuestPlatform cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact info@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Generic implementation of a singleton for Unity <see cref="MonoBehaviour"/> components.
    /// Ensures that only one instance of the component exists in the scene and provides global access.
    /// </summary>
    /// <typeparam name="T">The type of the MonoBehaviour to make a singleton.</typeparam>
    public class MonoBehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static readonly object _lock = new object();
        private static T _instance;

        /// <summary>
        /// Gets the singleton instance of type <typeparamref name="T"/>.
        /// Lazily finds or creates an instance if none exists.
        /// </summary>
        public static T Instance
        {
            get
            {
                if (_APPLICATION_IS_QUITTING)
                {
                    Debug.LogWarning(
                        $"[Singleton] Instance '{typeof(T)}' already destroyed on application quit. Won't create again - returning null.");
                    return null;
                }

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = (T) FindAnyObjectByType(typeof(T));

                        if (FindObjectsByType(typeof(T), FindObjectsSortMode.None).Length > 1)
                        {
                            Debug.LogError(
                                $"[Singleton] Something went really wrong - there should never be more than 1 singleton! Reopening the scene might fix it.");
                            return _instance;
                        }

                        if (_instance == null)
                        {
                            GameObject tmp_SingletonObject = new GameObject();
                            _instance = tmp_SingletonObject.AddComponent<T>();
                            tmp_SingletonObject.name = $"(Singleton) {typeof(T)}";
                            DontDestroyOnLoad(tmp_SingletonObject);
                        }
                        else
                        {
                            Debug.Log($"[Singleton] Using instance already created: {_instance.gameObject.name}");
                        }
                    }

                    return _instance;
                }
            }
        }

        private static bool _APPLICATION_IS_QUITTING = false;

        /// <summary>
        /// Marks the instance as destroyed when the application quits to prevent "ghost" object creation.
        /// </summary>
        protected virtual void OnDestroy()
        {
            _APPLICATION_IS_QUITTING = true;
        }
    }
}