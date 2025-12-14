// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Core.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.Core.Runtime
{
    public class MonoBehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        // 用于线程锁定的对象
        private static readonly object _lock = new object();

        // 单例的静态实例
        private static T _instance;

        /// <summary>
        /// 获取单例的全局唯一实例。
        /// </summary>
        public static T Instance
        {
            get
            {
                // 应用程序退出时，防止再次创建实例
                if (_APPLICATION_IS_QUITTING)
                {
                    Debug.LogWarning(
                        $"[Singleton] Instance '{typeof(T)}' already destroyed on application quit. Won't create again - returning null.");
                    return null;
                }

                // 使用锁确保线程安全
                lock (_lock)
                {
                    // 如果实例尚未创建
                    if (_instance == null)
                    {
                        // 尝试在场景中查找该类型的实例
                        _instance = (T) FindAnyObjectByType(typeof(T));

                        // 如果场景中存在多个实例，则发出警告
                        if (FindObjectsByType(typeof(T), FindObjectsSortMode.None).Length > 1)
                        {
                            Debug.LogError(
                                $"[Singleton] Something went really wrong - there should never be more than 1 singleton! Reopening the scene might fix it.");
                            return _instance;
                        }

                        // 如果在场景中找不到实例，则自动创建一个新的
                        if (_instance == null)
                        {
                            GameObject tmp_SingletonObject = new GameObject();
                            _instance = tmp_SingletonObject.AddComponent<T>();
                            tmp_SingletonObject.name = $"(Singleton) {typeof(T)}";
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

        // 标记应用程序是否正在退出，以防止在OnDestroy后再次创建实例
        private static bool _APPLICATION_IS_QUITTING = false;

        /// <summary>
        /// 当应用程序退出时，Unity会以随机顺序调用OnDestroy。
        /// 这个标志可以防止在对象销毁后再次调用Instance，从而避免创建“幽灵”对象。
        /// </summary>
        protected virtual void OnDestroy()
        {
            _APPLICATION_IS_QUITTING = true;
        }
    }
}