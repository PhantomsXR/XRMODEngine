/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.XRMODUtilites.Runtime.

The  XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime.UniPool
{
    /// <summary>
    /// Provides a static interface for interacting with the UniPool object pooling system.
    /// All operations are delegated to an internal PoolManager instance.
    /// </summary>
    public static class UniPool
    {
        internal static PoolManager Pool;

        /// <summary>
        /// Retrieves an available instance of a GameObject from the pool based on its prefab.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab to retrieve an instance of.</param>
        /// <returns>A PoolCell containing the retrieved GameObject instance.</returns>
        public static PoolCell Get(GameObject _prefab)
        {
            return Pool.Get(_prefab);
        }

        /// <summary>
        /// Retrieves an available instance of a GameObject from the pool, and attempts to get a component of type T from it.
        /// </summary>
        /// <typeparam name="T">The type of component to retrieve from the pooled GameObject.</typeparam>
        /// <param name="_prefab">The GameObject prefab to retrieve an instance of.</param>
        /// <param name="_componentInChildren">If true, searches for the component in children as well.</param>
        /// <returns>A PoolCell containing the retrieved GameObject instance and its component.</returns>
        public static PoolCell Get<T>(GameObject _prefab, bool _componentInChildren = false)
        {
            return Pool.Get<T>(_prefab, _componentInChildren);
        }

        /// <summary>
        /// Retrieves an available instance of a GameObject from the pool based on its registered name.
        /// </summary>
        /// <param name="_name">The registered name of the GameObject prefab.</param>
        /// <returns>A PoolCell containing the retrieved GameObject instance.</returns>
        public static PoolCell Get(string _name)
        {
            return Pool.Get(_name);
        }

        /// <summary>
        /// Releases a PoolCell back into the pool, making its GameObject available for reuse.
        /// </summary>
        /// <param name="_cell">The PoolCell to release.</param>
        public static void Release(PoolCell _cell)
        {
            Pool.Release(_cell);
        }

        /// <summary>
        /// Releases a GameObject back into the pool, making it available for reuse.
        /// </summary>
        /// <param name="_gameObject">The GameObject to release.</param>
        public static void Release(GameObject _gameObject)
        {
            Pool.Release(_gameObject);
        }

        /// <summary>
        /// Releases a Transform's associated GameObject back into the pool, making it available for reuse.
        /// </summary>
        /// <param name="_transform">The Transform whose GameObject is to be released.</param>
        public static void Release(Transform _transform)
        {
            Pool.Release(_transform);
        }

        /// <summary>
        /// Releases a Component's associated GameObject back into the pool, making it available for reuse.
        /// </summary>
        /// <param name="_component">The Component whose GameObject is to be released.</param>
        public static void Release(object _component)
        {
            Pool.Release(_component);
        }

        /// <summary>
        /// Releases all active instances of a specific GameObject prefab back into the pool.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab whose instances are to be released.</param>
        public static void ReleaseAll(GameObject _prefab)
        {
            Pool.ReleaseAll(_prefab);
        }

        /// <summary>
        /// Releases all active instances of GameObjects registered under a specific name back into the pool.
        /// </summary>
        /// <param name="_name">The registered name of the GameObject prefab.</param>
        public static void ReleaseAll(string _name)
        {
            Pool.ReleaseAll(_name);
        }

        /// <summary>
        /// Releases a PoolCell back into the pool after a specified delay.
        /// </summary>
        /// <param name="_cell">The PoolCell to release.</param>
        /// <param name="_delay">The delay in seconds before releasing the PoolCell.</param>
        public static void Release(PoolCell _cell, float _delay)
        {
            Pool.Release(_cell, _delay);
        }

        /// <summary>
        /// Releases a GameObject back into the pool after a specified delay.
        /// </summary>
        /// <param name="_gameObject">The GameObject to release.</param>
        /// <param name="_delay">The delay in seconds before releasing the GameObject.</param>
        public static void Release(GameObject _gameObject, float _delay)
        {
            Pool.Release(_gameObject, _delay);
        }

        /// <summary>
        /// Releases a Transform's associated GameObject back into the pool after a specified delay.
        /// </summary>
        /// <param name="_transform">The Transform whose GameObject is to be released.</param>
        /// <param name="_delay">The delay in seconds before releasing the GameObject.</param>
        public static void Release(Transform _transform, float _delay)
        {
            Pool.Release(_transform, _delay);
        }

        /// <summary>
        /// Releases a Component's associated GameObject back into the pool after a specified delay.
        /// </summary>
        /// <param name="_component">The Component whose GameObject is to be released.</param>
        /// <param name="_delay">The delay in seconds before releasing the GameObject.</param>
        public static void Release(object _component, float _delay)
        {
            Pool.Release(_component, _delay);
        }

        /// <summary>
        /// Releases all active instances of a specific GameObject prefab back into the pool after a specified delay.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab whose instances are to be released.</param>
        /// <param name="_delay">The delay in seconds before releasing all instances.</param>
        public static void ReleaseAll(GameObject _prefab, float _delay)
        {
            Pool.ReleaseAll(_prefab, _delay);
        }

        /// <summary>
        /// Releases all active instances of GameObjects registered under a specific name back into the pool after a specified delay.
        /// </summary>
        /// <param name="_name">The registered name of the GameObject prefab.</param>
        /// <param name="_delay">The delay in seconds before releasing all instances.</param>
        public static void ReleaseAll(string _name, float _delay)
        {
            Pool.ReleaseAll(_name, _delay);
        }

        /// <summary>
        /// Registers a GameObject prefab with the pooling system.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab to register.</param>
        /// <param name="_container">The Transform to parent pooled instances under. If null, instances will be parented under the PoolManager's default container.</param>
        /// <returns>True if registration was successful, false otherwise.</returns>
        public static bool Register(GameObject _prefab, Transform _container = null)
        {
            return Pool.Register(_prefab, _container);
        }

        /// <summary>
        /// Registers a GameObject prefab with the pooling system under a specific name.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab to register.</param>
        /// <param name="_name">The name to register the prefab under.</param>
        /// <param name="_container">The Transform to parent pooled instances under. If null, instances will be parented under the PoolManager's default container.</param>
        /// <returns>True if registration was successful, false otherwise.</returns>
        public static bool Register(GameObject _prefab, string _name, Transform _container = null)
        {
            return Pool.Register(_prefab, _name, _container);
        }

        /// <summary>
        /// Registers a GameObject prefab with the pooling system, associating it with a specific component type.
        /// </summary>
        /// <typeparam name="T">The component type associated with the prefab.</typeparam>
        /// <param name="_prefab">The GameObject prefab to register.</param>
        /// <param name="_container">The Transform to parent pooled instances under. If null, instances will be parented under the PoolManager's default container.</param>
        /// <param name="_componentInChildren">If true, the component will be searched for in children as well.</param>
        /// <returns>True if registration was successful, false otherwise.</returns>
        public static bool Register<T>(GameObject _prefab, Transform _container = null,
            bool _componentInChildren = false)
        {
            return Pool.Register(_prefab, typeof(T), _container, _componentInChildren);
        }

        /// <summary>
        /// Registers a GameObject prefab with the pooling system under a specific name, associating it with a specific component type.
        /// </summary>
        /// <typeparam name="T">The component type associated with the prefab.</typeparam>
        /// <param name="_prefab">The GameObject prefab to register.</param>
        /// <param name="_name">The name to register the prefab under.</param>
        /// <param name="_container">The Transform to parent pooled instances under. If null, instances will be parented under the PoolManager's default container.</param>
        /// <param name="_componentInChildren">If true, the component will be searched for in children as well.</param>
        /// <returns>True if registration was successful, false otherwise.</returns>
        public static bool Register<T>(GameObject _prefab, string _name, Transform _container = null,
            bool _componentInChildren = false)
        {
            return Pool.Register(_prefab, typeof(T), _name, _container, _componentInChildren);
        }

        /// <summary>
        /// Unregisters a GameObject prefab from the pooling scheme and destroys all its instances.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab to unregister.</param>
        public static void Unregister(GameObject _prefab)
        {
            Pool.Unregister(_prefab);
        }

        /// <summary>
        /// Unregisters a GameObject prefab (by its registered name) from the pooling scheme and destroys all its instances.
        /// </summary>
        /// <param name="_name">The registered name of the GameObject prefab to unregister.</param>
        public static void Unregister(string _name)
        {
            Pool.Unregister(_name);
        }

        /// <summary>
        /// Pre-fills the pool with a specified amount of instances for a given GameObject prefab.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab to fill the pool with.</param>
        /// <param name="_amount">The number of instances to create and add to the pool.</param>
        public static void Fill(GameObject _prefab, int _amount)
        {
            Pool.Fill(_prefab, _amount);
        }
        
        public static void Fill(GameObject _prefab, int _amount,Transform _parent)
        {
            Pool.Fill(_prefab, _amount,_parent);
        }

        /// <summary>
        /// Pre-fills the pool with a specified amount of instances for a GameObject registered under a specific name.
        /// </summary>
        /// <param name="_name">The registered name of the GameObject prefab.</param>
        /// <param name="_amount">The number of instances to create and add to the pool.</param>
        public static void Fill(string _name, int _amount)
        {
            Pool.Fill(_name, _amount);
        }

        /// <summary>
        /// Removes a specific PoolCell from the pooling scheme. Optionally destroys the associated GameObject.
        /// </summary>
        /// <param name="_cell">The PoolCell to remove.</param>
        /// <param name="_destroy">If true, the GameObject associated with the PoolCell will be destroyed.</param>
        public static void Remove(PoolCell _cell, bool _destroy = true)
        {
            Pool.Remove(_cell, _destroy);
        }

        /// <summary>
        /// Removes a specific GameObject from the pooling scheme. Optionally destroys the GameObject.
        /// </summary>
        /// <param name="_gameObject">The GameObject to remove.</param>
        /// <param name="_destroy">If true, the GameObject will be destroyed.</param>
        public static void Remove(GameObject _gameObject, bool _destroy = true)
        {
            Pool.Remove(_gameObject, _destroy);
        }

        /// <summary>
        /// Removes a Transform's associated GameObject from the pooling scheme. Optionally destroys the GameObject.
        /// </summary>
        /// <param name="_transform">The Transform whose GameObject is to be removed.</param>
        /// <param name="_destroy">If true, the GameObject will be destroyed.</param>
        public static void Remove(Transform _transform, bool _destroy = true)
        {
            Pool.Remove(_transform, _destroy);
        }

        /// <summary>
        /// Removes a Component's associated GameObject from the pooling scheme. Optionally destroys the GameObject.
        /// </summary>
        /// <param name="_component">The Component whose GameObject is to be removed.</param>
        /// <param name="_destroy">If true, the GameObject will be destroyed.</param>
        public static void Remove(object _component, bool _destroy = true)
        {
            Pool.Remove(_component, _destroy);
        }

        /// <summary>
        /// Destroys all instances of a specific GameObject prefab, regardless of their active state or pool status.
        /// This does not unregister the prefab from the pool.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab whose instances are to be destroyed.</param>
        public static void DestroyAll(GameObject _prefab)
        {
            Pool.DestroyAll(_prefab);
        }

        /// <summary>
        /// Destroys all instances of GameObjects registered under a specific name, regardless of their active state or pool status.
        /// This does not unregister the prefab from the pool.
        /// </summary>
        /// <param name="_name">The registered name of the GameObject prefab.</param>
        public static void DestroyAll(string _name)
        {
            Pool.DestroyAll(_name);
        }

        /// <summary>
        /// Clears and destroys all instances and registrations within the entire pooling system.
        /// Resets the UniPool to its initial state.
        /// </summary>
        public static void DestroyAll()
        {
            Pool.DestroyAll();
        }
    }
}