/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.XRMODUtilites.Runtime.

The  XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System;
using System.Collections;
using System.Collections.Generic;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime.UniPool
{
    /// <summary>
    /// Manages a pool of GameObjects for efficient reuse.
    /// </summary>
    public class PoolManager : MonoBehaviour
    {
        /// <summary>
        /// Default container for pooled objects. On Release, objects are returned to this container.
        /// </summary>
        [Tooltip("Default container. On Release return pooled objects to this container"), SerializeField]
        private Transform container;

        private Dictionary<GameObject, PoolStack> prefabCellStackMap = new();
        private Dictionary<PoolCell, PoolStack> cellStackMap = new();
        private Dictionary<string, PoolStack> nameCellStackMap = new();

        private Dictionary<GameObject, PoolCell> gameObjectCellMap = new();
        private Dictionary<Transform, PoolCell> transformCellMap = new();
        private Dictionary<object, PoolCell> componentCellMap = new();

        /// <summary>
        /// Indicates whether the pool is operating in XRMOD mode.
        /// </summary>
        internal bool isXRMOD;

        void Init()
        {
            if (container == null)
                container = transform;
            UniPool.Pool = this;
        }

        private void Awake()
        {
            Init();
        }

        #region Get

        /// <summary>
        /// Retrieves a GameObject from the pool based on its prefab.
        /// If no pooled instance is available, a new one is created.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab to retrieve from the pool.</param>
        /// <returns>A <see cref="PoolCell"/> containing the retrieved GameObject.</returns>
        internal PoolCell Get(GameObject _prefab)
        {
            PoolCell tmp_Cell = null;
            PoolStack tmp_CellStack = null;

            if (prefabCellStackMap.TryGetValue(_prefab, out tmp_CellStack))
            {
                if (!tmp_CellStack.TryPop(out tmp_Cell))
                {
                    tmp_Cell = AddPoolCell(tmp_CellStack);
                }

                // Fallback in case gameObject was somehow destroyed
                while (tmp_Cell.GameObject == null)
                {
                    Remove(tmp_Cell);
                    if (!tmp_CellStack.TryPop(out tmp_Cell))
                    {
                        tmp_Cell = AddPoolCell(tmp_CellStack);
                    }
                }
            }
            else
            {
                tmp_CellStack = new();
                tmp_CellStack.ActiveOnGet = _prefab.activeSelf;
                tmp_CellStack.PrefabScale = _prefab.transform.localScale;
                tmp_CellStack.Container = container;

                prefabCellStackMap[_prefab] = tmp_CellStack;

                tmp_CellStack.CellGenerator = CreatePoolCell(_prefab, container);
                tmp_Cell = AddPoolCell(tmp_CellStack);
            }

            tmp_Cell.IsPooled = false;


            if (tmp_CellStack.ActiveOnGet) tmp_Cell.GameObject.SetActive(true);
            return tmp_Cell;
        }

        /// <summary>
        /// Retrieves a GameObject from the pool based on its prefab, and attempts to get a component of type T from it.
        /// If no pooled instance is available, a new one is created.
        /// </summary>
        /// <typeparam name="T">The type of component to retrieve from the GameObject.</typeparam>
        /// <param name="_prefab">The GameObject prefab to retrieve from the pool.</param>
        /// <param name="_componentInChildren">If true, searches for the component in children as well.</param>
        /// <returns>A <see cref="PoolCell"/> containing the retrieved GameObject and its component.</returns>
        internal PoolCell Get<T>(GameObject _prefab, bool _componentInChildren = false)
        {
            PoolCell tmp_Cell = null;
            PoolStack tmp_CellStack = null;

            if (prefabCellStackMap.TryGetValue(_prefab, out tmp_CellStack))
            {
                if (!tmp_CellStack.TryPop(out tmp_Cell))
                {
                    tmp_Cell = AddPoolCell(tmp_CellStack);
                }

                // Fallback in case gameObject was somehow destroyed
                while (tmp_Cell.GameObject == null)
                {
                    Remove(tmp_Cell);
                    if (!tmp_CellStack.TryPop(out tmp_Cell))
                    {
                        tmp_Cell = AddPoolCell(tmp_CellStack);
                    }
                }
            }
            else
            {
                tmp_CellStack = new();
                tmp_CellStack.ActiveOnGet = _prefab.activeSelf;
                tmp_CellStack.PrefabScale = _prefab.transform.localScale;
                tmp_CellStack.Container = container;

                prefabCellStackMap[_prefab] = tmp_CellStack;

                tmp_CellStack.CellGenerator = CreatePoolCell<T>(_prefab, container, _componentInChildren);
                tmp_Cell = AddPoolCell(tmp_CellStack);
            }

            tmp_Cell.IsPooled = false;


            if (tmp_CellStack.ActiveOnGet) tmp_Cell.GameObject.SetActive(true);
            return tmp_Cell;
        }

        /// <summary>
        /// Retrieves a GameObject from the pool based on its prefab, and attempts to get a component of a specified type from it.
        /// If no pooled instance is available, a new one is created.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab to retrieve from the pool.</param>
        /// <param name="_type">The type of component to retrieve from the GameObject.</param>
        /// <param name="_componentInChildren">If true, searches for the component in children as well.</param>
        /// <returns>A <see cref="PoolCell"/> containing the retrieved GameObject and its component.</returns>
        internal PoolCell Get(GameObject _prefab, Type _type, bool _componentInChildren = false)
        {
            PoolCell tmp_Cell = null;

            if (prefabCellStackMap.TryGetValue(_prefab, out var tmp_CellStack))
            {
                if (!tmp_CellStack.TryPop(out tmp_Cell))
                {
                    tmp_Cell = AddPoolCell(tmp_CellStack);
                }

                // Fallback in case gameObject was somehow destroyed
                while (tmp_Cell.GameObject == null)
                {
                    Remove(tmp_Cell);
                    if (!tmp_CellStack.TryPop(out tmp_Cell))
                    {
                        tmp_Cell = AddPoolCell(tmp_CellStack);
                    }
                }
            }
            else
            {
                tmp_CellStack = new()
                {
                    ActiveOnGet = _prefab.activeSelf,
                    PrefabScale = _prefab.transform.localScale,
                    Container = container
                };

                prefabCellStackMap[_prefab] = tmp_CellStack;

                tmp_CellStack.CellGenerator = CreatePoolCell(_prefab, _type, container, _componentInChildren);
                tmp_Cell = AddPoolCell(tmp_CellStack);
            }

            tmp_Cell.IsPooled = false;


            if (tmp_CellStack.ActiveOnGet) tmp_Cell.GameObject.SetActive(true);
            return tmp_Cell;
        }

        /// <summary>
        /// Retrieves a GameObject from the pool using a registered name.
        /// If no pooled instance is available, a new one is created.
        /// </summary>
        /// <param name="_name">The registered name of the prefab to retrieve from the pool.</param>
        /// <returns>A <see cref="PoolCell"/> containing the retrieved GameObject, or null if the name is not registered.</returns>
        internal PoolCell Get(string _name)
        {
            if (!nameCellStackMap.TryGetValue(_name, out var tmp_CellStack))
            {
                return null;
            }

            if (!tmp_CellStack.TryPop(out var tmp_Cell))
            {
                tmp_Cell = AddPoolCell(tmp_CellStack);
            }

            // Fallback in case gameObject was somehow destroyed
            while (tmp_Cell.GameObject == null)
            {
                Remove(tmp_Cell);
                if (!tmp_CellStack.TryPop(out tmp_Cell))
                {
                    tmp_Cell = AddPoolCell(tmp_CellStack);
                }
            }

            tmp_Cell.IsPooled = false;


            if (tmp_CellStack.ActiveOnGet) tmp_Cell.GameObject.SetActive(true);
            return tmp_Cell;
        }

        /// <summary>
        /// Retrieves a GameObject from the pool using a registered name, and attempts to get a component of type T from it.
        /// This method simply calls the non-generic Get(string _name) as component retrieval is handled internally by PoolCell.
        /// </summary>
        /// <typeparam name="T">The type of component to retrieve from the GameObject.</typeparam>
        /// <param name="_name">The registered name of the prefab to retrieve from the pool.</param>
        /// <returns>A <see cref="PoolCell"/> containing the retrieved GameObject and its component, or null if the name is not registered.</returns>
        internal PoolCell Get<T>(string _name)
        {
            return Get(_name);
        }

        #endregion

        #region Register

        /// <summary>
        /// Registers a GameObject prefab with the pool manager without a specific name.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab to register.</param>
        /// <param name="_container">Optional: The transform to use as a container for pooled objects of this prefab. If null, the default container is used.</param>
        /// <returns>True if the prefab was successfully registered, false if it was already registered.</returns>
        internal bool Register(GameObject _prefab, Transform _container = null)
        {
            if (prefabCellStackMap.ContainsKey(_prefab)) return false;
            PoolStack tmp_CellStack = new PoolStack
            {
                ActiveOnGet = _prefab.activeSelf,
                PrefabScale = _prefab.transform.localScale,
                Container = _container != null ? _container : container
            };
            tmp_CellStack.CellGenerator = CreatePoolCell(_prefab, tmp_CellStack.Container);
            prefabCellStackMap[_prefab] = tmp_CellStack;
            return true;
        }

        /// <summary>
        /// Registers a GameObject prefab with the pool manager using a specific name.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab to register.</param>
        /// <param name="_name">The unique name to associate with this prefab in the pool.</param>
        /// <param name="_container">Optional: The transform to use as a container for pooled objects of this prefab. If null, the default container is used.</param>
        /// <returns>True if the prefab was successfully registered, false if the name or prefab was already registered.</returns>
        internal bool Register(GameObject _prefab, string _name, Transform _container = null)
        {
            if (nameCellStackMap.ContainsKey(_name) || prefabCellStackMap.ContainsKey(_prefab)) return false;
            PoolStack tmp_CellStack = new PoolStack
            {
                ActiveOnGet = _prefab.activeSelf,
                PrefabScale = _prefab.transform.localScale
            };
            tmp_CellStack.Container = _container != null ? _container : container;
            tmp_CellStack.CellGenerator = CreatePoolCell(_prefab, tmp_CellStack.Container);
            prefabCellStackMap[_prefab] = tmp_CellStack;
            nameCellStackMap[_name] = tmp_CellStack;
            return true;
        }

        /// <summary>
        /// Registers a GameObject prefab with the pool manager, specifying a component type to retrieve.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab to register.</param>
        /// <param name="_type">The type of component to retrieve from instances of this prefab.</param>
        /// <param name="_container">Optional: The transform to use as a container for pooled objects of this prefab. If null, the default container is used.</param>
        /// <param name="_componentInChildren">If true, searches for the component in children as well.</param>
        /// <returns>True if the prefab was successfully registered, false if it was already registered.</returns>
        internal bool Register(GameObject _prefab, Type _type, Transform _container = null,
            bool _componentInChildren = false)
        {
            if (prefabCellStackMap.ContainsKey(_prefab)) return false;
            PoolStack tmp_CellStack = new PoolStack
            {
                ActiveOnGet = _prefab.activeSelf,
                PrefabScale = _prefab.transform.localScale,
                Container = _container != null ? _container : container
            };
            tmp_CellStack.CellGenerator = CreatePoolCell(_prefab, _type, tmp_CellStack.Container, _componentInChildren);
            prefabCellStackMap[_prefab] = tmp_CellStack;
            return true;
        }

        /// <summary>
        /// Registers a GameObject prefab with the pool manager using a specific name and specifying a component type to retrieve.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab to register.</param>
        /// <param name="_type">The type of component to retrieve from instances of this prefab.</param>
        /// <param name="_name">The unique name to associate with this prefab in the pool.</param>
        /// <param name="_container">Optional: The transform to use as a container for pooled objects of this prefab. If null, the default container is used.</param>
        /// <param name="_componentInChildren">If true, searches for the component in children as well.</param>
        /// <returns>True if the prefab was successfully registered, false if the name or prefab was already registered.</returns>
        internal bool Register(GameObject _prefab, Type _type, string _name, Transform _container = null,
            bool _componentInChildren = false)
        {
            if (nameCellStackMap.ContainsKey(_name) || prefabCellStackMap.ContainsKey(_prefab)) return false;
            PoolStack tmp_CellStack = new PoolStack
            {
                ActiveOnGet = _prefab.activeSelf,
                PrefabScale = _prefab.transform.localScale,
                Container = _container != null ? _container : container
            };
            tmp_CellStack.CellGenerator = CreatePoolCell(_prefab, _type, tmp_CellStack.Container, _componentInChildren);
            prefabCellStackMap[_prefab] = tmp_CellStack;
            nameCellStackMap[_name] = tmp_CellStack;
            return true;
        }

        /// <summary>
        /// Registers a GameObject prefab with the pool manager, specifying a generic component type to retrieve.
        /// </summary>
        /// <typeparam name="T">The generic type of component to retrieve from instances of this prefab.</typeparam>
        /// <param name="_prefab">The GameObject prefab to register.</param>
        /// <param name="_container">Optional: The transform to use as a container for pooled objects of this prefab. If null, the default container is used.</param>
        /// <param name="_componentInChildren">If true, searches for the component in children as well.</param>
        /// <returns>True if the prefab was successfully registered, false if it was already registered.</returns>
        internal bool Register<T>(GameObject _prefab, Transform _container = null, bool _componentInChildren = false)
        {
            if (prefabCellStackMap.ContainsKey(_prefab)) return false;
            PoolStack tmp_CellStack = new PoolStack
            {
                ActiveOnGet = _prefab.activeSelf,
                PrefabScale = _prefab.transform.localScale,
                Container = _container != null ? _container : container
            };
            tmp_CellStack.CellGenerator = CreatePoolCell<T>(_prefab, tmp_CellStack.Container, _componentInChildren);
            prefabCellStackMap[_prefab] = tmp_CellStack;
            return true;
        }

        /// <summary>
        /// Registers a GameObject prefab with the pool manager using a specific name and specifying a generic component type to retrieve.
        /// </summary>
        /// <typeparam name="T">The generic type of component to retrieve from instances of this prefab.</typeparam>
        /// <param name="_prefab">The GameObject prefab to register.</param>
        /// <param name="_name">The unique name to associate with this prefab in the pool.</param>
        /// <param name="_container">Optional: The transform to use as a container for pooled objects of this prefab. If null, the default container is used.</param>
        /// <param name="_componentInChildren">If true, searches for the component in children as well.</param>
        /// <returns>True if the prefab was successfully registered, false if the name or prefab was already registered.</returns>
        internal bool Register<T>(GameObject _prefab, string _name, Transform _container = null,
            bool _componentInChildren = false)
        {
            if (nameCellStackMap.ContainsKey(_name) || prefabCellStackMap.ContainsKey(_prefab)) return false;
            PoolStack tmp_CellStack = new PoolStack
            {
                ActiveOnGet = _prefab.activeSelf,
                PrefabScale = _prefab.transform.localScale,
                Container = _container != null ? _container : container
            };
            tmp_CellStack.CellGenerator = CreatePoolCell<T>(_prefab, tmp_CellStack.Container, _componentInChildren);
            prefabCellStackMap[_prefab] = tmp_CellStack;
            nameCellStackMap[_name] = tmp_CellStack;
            return true;
        }

        /// <summary>
        /// Unregisters a GameObject prefab from the pool manager and destroys all its pooled instances.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab to unregister.</param>
        internal void Unregister(GameObject _prefab)
        {
            if (!prefabCellStackMap.ContainsKey(_prefab)) return;
            DestroyAll(_prefab);
            prefabCellStackMap.Remove(_prefab);
        }

        /// <summary>
        /// Unregisters a GameObject prefab from the pool manager using its registered name and destroys all its pooled instances.
        /// </summary>
        /// <param name="_name">The registered name of the prefab to unregister.</param>
        internal void Unregister(string _name)
        {
            GameObject tmp_Prefab = null;
            if (!nameCellStackMap.TryGetValue(_name, out PoolStack tmp_CellStack)) return;
            foreach (var tmp_Kvp in prefabCellStackMap)
            {
                if (tmp_Kvp.Value != tmp_CellStack) continue;
                tmp_Prefab = tmp_Kvp.Key;
                break;
            }

            if (tmp_Prefab == null) return;
            DestroyAll(tmp_Prefab);
            prefabCellStackMap.Remove(tmp_Prefab);
            nameCellStackMap.Remove(_name);
        }

        #endregion

        #region Release

        /// <summary>
        /// Releases a <see cref="PoolCell"/> back to its pool after a specified delay.
        /// </summary>
        /// <param name="_cell">The <see cref="PoolCell"/> to release.</param>
        /// <param name="_delay">The delay in seconds before releasing the cell.</param>
        internal void Release(PoolCell _cell, float _delay)
        {
            StartCoroutine(ReleaseWithDelay(_cell, _delay));
        }

        /// <summary>
        /// Releases a GameObject back to its pool after a specified delay.
        /// </summary>
        /// <param name="_gameObject">The GameObject to release.</param>
        /// <param name="_delay">The delay in seconds before releasing the GameObject.</param>
        internal void Release(GameObject _gameObject, float _delay)
        {
            StartCoroutine(ReleaseWithDelay(_gameObject, _delay));
        }

        /// <summary>
        /// Releases a Transform's GameObject back to its pool after a specified delay.
        /// </summary>
        /// <param name="_transform">The Transform whose GameObject to release.</param>
        /// <param name="_delay">The delay in seconds before releasing the GameObject.</param>
        internal void Release(Transform _transform, float _delay)
        {
            StartCoroutine(ReleaseWithDelay(_transform, _delay));
        }

        /// <summary>
        /// Releases a Component's GameObject back to its pool after a specified delay.
        /// </summary>
        /// <param name="_component">The Component whose GameObject to release. Must be a MonoBehaviour.</param>
        /// <param name="_delay">The delay in seconds before releasing the GameObject.</param>
        internal void Release(object _component, float _delay)
        {
            StartCoroutine(ReleaseWithDelay(_component, _delay));
        }

        /// <summary>
        /// Releases all active instances of a specific prefab back to its pool after a specified delay.
        /// </summary>
        /// <param name="_prefab">The prefab whose instances to release.</param>
        /// <param name="_delay">The delay in seconds before releasing all instances.</param>
        internal void ReleaseAll(GameObject _prefab, float _delay)
        {
            StartCoroutine(ReleaseAllWithDelay(_prefab, _delay));
        }

        /// <summary>
        /// Releases all active instances of a prefab identified by its registered name back to its pool after a specified delay.
        /// </summary>
        /// <param name="_name">The registered name of the prefab whose instances to release.</param>
        /// <param name="_delay">The delay in seconds before releasing all instances.</param>
        internal void ReleaseAll(string _name, float _delay)
        {
            StartCoroutine(ReleaseAllWithDelay(_name, _delay));
        }

        private IEnumerator ReleaseWithDelay(PoolCell _poolCell, float _delay)
        {
            yield return new WaitForSeconds(_delay);
            Release(_poolCell);
        }

        private IEnumerator ReleaseWithDelay(GameObject _gameObject, float _delay)
        {
            yield return new WaitForSeconds(_delay);
            Release(_gameObject);
        }

        private IEnumerator ReleaseWithDelay(Transform _transform, float _delay)
        {
            yield return new WaitForSeconds(_delay);
            Release(_transform);
        }

        private IEnumerator ReleaseWithDelay(object _component, float _delay)
        {
            yield return new WaitForSeconds(_delay);
            Release(_component);
        }

        private IEnumerator ReleaseAllWithDelay(GameObject _prefab, float _delay)
        {
            yield return new WaitForSeconds(_delay);
            ReleaseAll(_prefab);
        }

        private IEnumerator ReleaseAllWithDelay(string _name, float _delay)
        {
            yield return new WaitForSeconds(_delay);
            ReleaseAll(_name);
        }

        /// <summary>
        /// Releases a <see cref="PoolCell"/> back to its pool immediately.
        /// </summary>
        /// <param name="_cell">The <see cref="PoolCell"/> to release.</param>
        internal void Release(PoolCell _cell)
        {
            if (_cell.IsPooled) return;
            if (!cellStackMap.TryGetValue(_cell, out var tmp_CellStack)) return;
            tmp_CellStack.Push(_cell);
            _cell.IsPooled = true;
            _cell.GameObject.SetActive(false);
            _cell.Transform.parent = tmp_CellStack.Container;
            _cell.Transform.localScale = tmp_CellStack.PrefabScale;
        }

        /// <summary>
        /// Releases a GameObject back to its pool immediately.
        /// If the GameObject is not managed by the pool, it is destroyed.
        /// </summary>
        /// <param name="_gameObject">The GameObject to release.</param>
        internal void Release(GameObject _gameObject)
        {
            if (gameObjectCellMap.TryGetValue(_gameObject, out var tmp_Cell))
            {
                ProcessRelease(tmp_Cell);
            }
            else
            {
                Destroy(_gameObject);
            }
        }

        /// <summary>
        /// Releases a Transform's GameObject back to its pool immediately.
        /// If the GameObject is not managed by the pool, it is destroyed.
        /// </summary>
        /// <param name="_transform">The Transform whose GameObject to release.</param>
        internal void Release(Transform _transform)
        {
            if (transformCellMap.TryGetValue(_transform, out var tmp_Cell))
            {
                ProcessRelease(tmp_Cell);
            }
            else
            {
                Destroy(_transform.gameObject);
            }
        }

        /// <summary>
        /// Releases a Component's GameObject back to its pool immediately.
        /// If the GameObject is not managed by the pool, it is destroyed.
        /// </summary>
        /// <param name="_component">The Component whose GameObject to release. Must be a MonoBehaviour.</param>
        internal void Release(object _component)
        {
            if (componentCellMap.TryGetValue(_component, out var tmp_Cell))
            {
                ProcessRelease(tmp_Cell);
            }
            else
            {
                Destroy(((MonoBehaviour) _component).gameObject);
            }
        }

        /// <summary>
        /// Releases all active instances of a specific prefab back to its pool immediately.
        /// </summary>
        /// <param name="_prefab">The prefab whose instances to release.</param>
        internal void ReleaseAll(GameObject _prefab)
        {
            if (!prefabCellStackMap.TryGetValue(_prefab, out var tmp_CellStack)) return;
            List<PoolCell> tmp_CellList = tmp_CellStack.CellRegistry;
            for (int tmp_Idx = 0, tmp_Len = tmp_CellList.Count; tmp_Idx < tmp_Len; ++tmp_Idx)
            {
                var tmp_Cell = tmp_CellList[tmp_Idx];
                if (tmp_Cell.IsPooled) continue;
                tmp_CellStack.Push(tmp_Cell);

                tmp_Cell.IsPooled = true;
                tmp_Cell.GameObject.SetActive(false);
                tmp_Cell.Transform.parent = tmp_CellStack.Container;
                tmp_Cell.Transform.localScale = tmp_CellStack.PrefabScale;
            }
        }

        /// <summary>
        /// Releases all active instances of a prefab identified by its registered name back to its pool immediately.
        /// </summary>
        /// <param name="_name">The registered name of the prefab whose instances to release.</param>
        internal void ReleaseAll(string _name)
        {
            if (!nameCellStackMap.TryGetValue(_name, out var tmp_CellStack)) return;
            List<PoolCell> tmp_CellList = tmp_CellStack.CellRegistry;
            for (int tmp_Idx = 0, tmp_Len = tmp_CellList.Count; tmp_Idx < tmp_Len; ++tmp_Idx)
            {
                var tmp_Cell = tmp_CellList[tmp_Idx];
                if (tmp_Cell.IsPooled) continue;
                tmp_CellStack.Push(tmp_Cell);

                tmp_Cell.IsPooled = true;
                tmp_Cell.GameObject.SetActive(false);
                tmp_Cell.Transform.parent = tmp_CellStack.Container;
                tmp_Cell.Transform.localScale = tmp_CellStack.PrefabScale;
            }
        }

        private void ProcessRelease(PoolCell _cell)
        {
            if (_cell.IsPooled) return;

            PoolStack tmp_CellStack = cellStackMap[_cell];
            tmp_CellStack.Push(_cell);

            _cell.IsPooled = true;

            _cell.GameObject.SetActive(false);
            _cell.Transform.parent = tmp_CellStack.Container;
            _cell.Transform.localScale = tmp_CellStack.PrefabScale;
        }

        #endregion

        #region Fill

        /// <summary>
        /// Pre-fills the pool for a specific GameObject prefab with a given amount of instances.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab to pre-fill.</param>
        /// <param name="_amount">The number of instances to create and add to the pool.</param>
        internal void Fill(GameObject _prefab, int _amount)
        {
            if (!prefabCellStackMap.TryGetValue(_prefab, out var tmp_CellStack)) return;
            for (int tmp_Idx = 0; tmp_Idx < _amount; ++tmp_Idx)
            {
                var tmp_Cell = AddPoolCell(tmp_CellStack);
                tmp_CellStack.Push(tmp_Cell);
                tmp_Cell.IsPooled = true;
            }

            if (isXRMOD)
            {
                ActionNotificationCenter.DefaultCenter.PostNotification(
                    nameof(ActionParameterDataType.ProcessMonoBinderBatch), new BaseNotificationData());
            }
        }

        internal void Fill(GameObject _prefab, int _amount, Transform _parent)
        {
            if (!prefabCellStackMap.TryGetValue(_prefab, out var tmp_CellStack)) return;
            for (int tmp_Idx = 0; tmp_Idx < _amount; ++tmp_Idx)
            {
                var tmp_Cell = AddPoolCell(tmp_CellStack);
                tmp_CellStack.Push(tmp_Cell);
                tmp_Cell.IsPooled = true;
                tmp_Cell.Transform.SetParent(_parent);
            }

            if (isXRMOD)
            {
                ActionNotificationCenter.DefaultCenter.PostNotification(
                    nameof(ActionParameterDataType.ProcessMonoBinderBatch), new BaseNotificationData());
            }
        }

        /// <summary>
        /// Pre-fills the pool for a prefab identified by its registered name with a given amount of instances.
        /// </summary>
        /// <param name="_name">The registered name of the prefab to pre-fill.</param>
        /// <param name="_amount">The number of instances to create and add to the pool.</param>
        internal void Fill(string _name, int _amount)
        {
            if (!nameCellStackMap.TryGetValue(_name, out var tmp_CellStack)) return;
            for (int tmp_Idx = 0; tmp_Idx < _amount; ++tmp_Idx)
            {
                var tmp_Cell = AddPoolCell(tmp_CellStack);
                tmp_CellStack.Push(tmp_Cell);
                tmp_Cell.IsPooled = true;
            }

            if (isXRMOD)
            {
                ActionNotificationCenter.DefaultCenter.PostNotification(
                    nameof(ActionParameterDataType.ProcessMonoBinderBatch), new BaseNotificationData());
            }
        }

        #endregion

        private IEnumerator CreatePoolCell(GameObject _prefab, Transform _container)
        {
            for (;;)
            {
                yield return new PoolCell(_prefab, _container, isXRMOD);
            }
        }

        private IEnumerator CreatePoolCell(GameObject _prefab, Type _type, Transform _container,
            bool _componentInChildren)
        {
            for (;;)
            {
                var tmp_Cell = new PoolCell(_prefab, _container, isXRMOD);
                tmp_Cell.SetComponent(_type, _componentInChildren);
                yield return tmp_Cell;
            }
        }

        private IEnumerator CreatePoolCell<T>(GameObject _prefab, Transform _container, bool _componentInChildren)
        {
            for (;;)
            {
                var tmp_Cell = new PoolCell(_prefab, _container, isXRMOD);
                tmp_Cell.SetComponent<T>(_componentInChildren);
                yield return tmp_Cell;
            }
        }

        /// <summary>
        /// Removes a specific <see cref="PoolCell"/> from the pooling scheme.
        /// </summary>
        /// <param name="_cell">The <see cref="PoolCell"/> to remove.</param>
        /// <param name="_destroy">If true, the associated GameObject is destroyed. Otherwise, it is just removed from the pool management.</param>
        internal void Remove(PoolCell _cell, bool _destroy = true)
        {
            if (_cell.IsPooled)
            {
                cellStackMap[_cell].Remove(_cell);
            }

            cellStackMap.Remove(_cell);
            transformCellMap.Remove(_cell.Transform);
            if (_cell.Component != null) componentCellMap.Remove(_cell.Component);
            gameObjectCellMap.Remove(_cell.GameObject);
            if (_cell.GameObject != null && _destroy)
            {
                Destroy(_cell.GameObject);
            }
        }

        /// <summary>
        /// Removes a GameObject from the pooling scheme.
        /// </summary>
        /// <param name="_gameObject">The GameObject to remove.</param>
        /// <param name="_destroy">If true, the GameObject is destroyed. Otherwise, it is just removed from the pool management.</param>
        internal void Remove(GameObject _gameObject, bool _destroy = true)
        {
            if (gameObjectCellMap.TryGetValue(_gameObject, out var tmp_Cell))
            {
                Remove(tmp_Cell, _destroy);
            }
        }

        /// <summary>
        /// Removes a Transform's GameObject from the pooling scheme.
        /// </summary>
        /// <param name="_transform">The Transform whose GameObject to remove.</param>
        /// <param name="_destroy">If true, the GameObject is destroyed. Otherwise, it is just removed from the pool management.</param>
        internal void Remove(Transform _transform, bool _destroy = true)
        {
            if (transformCellMap.TryGetValue(_transform, out var tmp_Cell))
            {
                Remove(tmp_Cell, _destroy);
            }
        }

        /// <summary>
        /// Removes a Component's GameObject from the pooling scheme.
        /// </summary>
        /// <param name="_component">The Component whose GameObject to remove. Must be a MonoBehaviour.</param>
        /// <param name="_destroy">If true, the GameObject is destroyed. Otherwise, it is just removed from the pool management.</param>
        internal void Remove(object _component, bool _destroy = true)
        {
            if (componentCellMap.TryGetValue(_component, out var tmp_Cell))
            {
                Remove(tmp_Cell, _destroy);
            }
        }

        /// <summary>
        /// Destroys all pooled and active instances of a specific GameObject prefab.
        /// </summary>
        /// <param name="prefab">The GameObject prefab whose instances to destroy.</param>
        internal void DestroyAll(GameObject prefab)
        {
            if (!prefabCellStackMap.TryGetValue(prefab, out var tmp_CellStack)) return;
            List<PoolCell> tmp_CellList = tmp_CellStack.CellRegistry;

            for (int tmp_Idx = 0, tmp_Len = tmp_CellList.Count; tmp_Idx < tmp_Len; ++tmp_Idx)
            {
                var tmp_Cell = tmp_CellList[tmp_Idx];
                cellStackMap.Remove(tmp_Cell);
                transformCellMap.Remove(tmp_Cell.Transform);
                if (tmp_Cell.Component != null) componentCellMap.Remove(tmp_Cell.Component);
                gameObjectCellMap.Remove(tmp_Cell.GameObject);
                if (tmp_Cell.GameObject != null)
                {
                    Destroy(tmp_Cell.GameObject);
                }
            }

            tmp_CellStack.RemoveAll();
        }

        /// <summary>
        /// Destroys all pooled and active instances of a prefab identified by its registered name.
        /// </summary>
        /// <param name="_name">The registered name of the prefab whose instances to destroy.</param>
        internal void DestroyAll(string _name)
        {
            if (!nameCellStackMap.TryGetValue(_name, out var tmp_CellStack)) return;
            List<PoolCell> tmp_CellList = tmp_CellStack.CellRegistry;
            for (int tmp_Idx = 0, tmp_Len = tmp_CellList.Count; tmp_Idx < tmp_Len; ++tmp_Idx)
            {
                var tmp_Cell = tmp_CellList[tmp_Idx];
                cellStackMap.Remove(tmp_Cell);
                transformCellMap.Remove(tmp_Cell.Transform);
                if (tmp_Cell.Component != null) componentCellMap.Remove(tmp_Cell.Component);
                gameObjectCellMap.Remove(tmp_Cell.GameObject);
                if (tmp_Cell.GameObject != null)
                {
                    Destroy(tmp_Cell.GameObject);
                }
            }

            tmp_CellStack.RemoveAll();
        }

        /// <summary>
        /// Destroys all GameObjects managed by the pool manager, clearing all pools.
        /// </summary>
        internal void DestroyAll()
        {
            foreach (PoolCell tmp_Cell in cellStackMap.Keys)
            {
                Destroy(tmp_Cell.GameObject);
            }

            foreach (var tmp_Kvp in prefabCellStackMap)
            {
                var tmp_CellStack = tmp_Kvp.Value;
                tmp_CellStack.RemoveAll();
            }

            cellStackMap = new Dictionary<PoolCell, PoolStack>();
            gameObjectCellMap = new Dictionary<GameObject, PoolCell>();
            transformCellMap = new Dictionary<Transform, PoolCell>();
            componentCellMap = new Dictionary<object, PoolCell>();
        }

        PoolCell AddPoolCell(PoolStack _poolStack)
        {
            PoolCell tmp_Cell = _poolStack.GenerateCell();
            cellStackMap[tmp_Cell] = _poolStack;
            gameObjectCellMap[tmp_Cell.GameObject] = tmp_Cell;
            transformCellMap[tmp_Cell.Transform] = tmp_Cell;

            if (tmp_Cell.Component != null)
            {
                componentCellMap[tmp_Cell.Component] = tmp_Cell;
            }

            return tmp_Cell;
        }
    }
}