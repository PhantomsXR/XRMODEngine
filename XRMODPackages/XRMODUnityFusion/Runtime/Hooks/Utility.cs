// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the UnityFusion.Runtime.CodeHook.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Linq;
using System.Reflection;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using UnityFusion.CLR.Method;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLRBinding.Adapter;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityEngine;
using UnityEngine.Assertions;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;
using Extension = UnityFusion.CLR.Utils.Extensions;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public static class Utility
    {
        
        internal const BindingFlags CONST_ALL_BINDING_FLAGS = BindingFlags.NonPublic | BindingFlags.Public
                                                                            | BindingFlags.Instance |
                                                                            BindingFlags.Static;

        internal const string CONST_ADD_RUNTIME_CLASS = "AddRuntimeClass";
        /// <summary>
        /// Checkout the GameObject and the type in the IL
        /// </summary>
        /// <param name="_instance"></param>
        /// <param name="_gameObject"></param>
        /// <param name="_returnType"></param>
        public static void CheckoutIlTypeInstance(object _instance, out GameObject _gameObject, out ILType _returnType)
        {
            _returnType = null;
            switch (_instance)
            {
                case GameObject tmp_GameObject:
                    _gameObject = tmp_GameObject;
                    break;
                case ILTypeInstance tmp_TypeInstance:
                    _returnType = tmp_TypeInstance.Type;
                    _gameObject = FindGameFromILTypeInstance(tmp_TypeInstance);
                    Assert.IsNotNull(_gameObject);
                    break;
                default:
                    _gameObject = (_instance as Component)?.gameObject;
                    break;
            }
        }

        /// <summary>
        /// find ilrt gameObject
        /// </summary>
        /// <param name="_instance"></param>
        /// <returns>GameObject</returns>
        public static GameObject FindGameFromILTypeInstance(ILTypeInstance _instance)
        {
            var tmp_ReturnType = _instance.Type;
            if (tmp_ReturnType.ReflectionType == typeof(MonoBehaviour))
            {
                var tmp_PropertyInfo = tmp_ReturnType.ReflectionType.GetProperty("gameObject");
                if (tmp_PropertyInfo != null)
                    return tmp_PropertyInfo.GetValue((_instance as ILTypeInstance).CLRInstance) as GameObject;
            }
            else if (tmp_ReturnType.ReflectionType.IsSubclassOf(typeof(MonoBehaviour)))
            {
                if (tmp_ReturnType.ReflectionType.BaseType == null) return null;
                var tmp_PropertyInfo = tmp_ReturnType.ReflectionType.BaseType.GetProperty("gameObject");
                if (tmp_PropertyInfo != null)
                    return tmp_PropertyInfo.GetValue((_instance as ILTypeInstance).CLRInstance) as GameObject;
            }

            return null;
        }


        /// <summary>
        /// 获取对象的gameObject
        /// </summary>
        /// <param name="ins"></param>
        /// <returns></returns>
        public static GameObject GetGameObject(this object ins)
        {
            GameObject tmp_Instance = ins switch
            {
                GameObject tmp_Go => tmp_Go,
                ILTypeInstance ilt => FindGameFromILTypeInstance(ilt),
                Transform t => t.gameObject,
                Component c => c.gameObject,
                _ => null
            };

            return tmp_Instance;
        }


        /// <summary>
        /// 获取热更对象
        /// </summary>
        /// <param name="_gameObject"></param>
        /// <param name="_typeName"></param>
        /// <returns></returns>
        public static object[] GetILComponents(GameObject _gameObject, AppDomain _appDomain, string _typeName)
        {
            var tmp_ClrInstances = _gameObject.GetComponents<CrossBindingAdaptorType>();
            var tmp_Type = _appDomain.GetType(_typeName);
            object[] tmp_Ret = new object[tmp_ClrInstances.Length];
            int tmp_Idx = 0;
            foreach (var tmp_ClrInstance in tmp_ClrInstances)
            {
                if (tmp_ClrInstance.ILInstance != null && tmp_ClrInstance.ILInstance.Type.CanAssignTo(tmp_Type))
                {
                    tmp_Ret[tmp_Idx] = tmp_ClrInstance.ILInstance;
                    tmp_Idx++;
                }
            }

            Array.Resize(ref tmp_Ret, tmp_Idx);
            return tmp_Ret;
        }


        /// <summary>
        /// 获取热更对象
        /// </summary>
        /// <param name="_gameObject"></param>
        /// <param name="_type"></param>
        /// <returns></returns>
        public static object[] GetILComponents(GameObject _gameObject, ILType _type)
        {
            var tmp_ClrInstances = _gameObject.GetComponents<CrossBindingAdaptorType>();
            object[] tmp_Ret = new object[tmp_ClrInstances.Length];
            int tmp_Idx = 0;
            foreach (var tmp_ClrInstance in tmp_ClrInstances)
            {
                if (tmp_ClrInstance.ILInstance != null && tmp_ClrInstance.ILInstance.Type.CanAssignTo(_type))
                {
                    tmp_Ret[tmp_Idx] = tmp_ClrInstance.ILInstance;
                    tmp_Idx++;
                }
            }

            Array.Resize(ref tmp_Ret, tmp_Idx);

            return tmp_Ret;
        }


        /// <summary>
        /// 获取热更对象
        /// </summary>
        /// <param name="_gameObject"></param>
        /// <param name="_typeName"></param>
        /// <returns></returns>
        public static object GetILComponent(GameObject _gameObject, AppDomain _appDomain, string _typeName)
        {
            var tmp_ClrInstances = _gameObject.GetComponents<CrossBindingAdaptorType>();
            var tmp_Type = _appDomain.GetType(_typeName);
            foreach (var tmp_ClrInstance in tmp_ClrInstances)
            {
                if (tmp_ClrInstance.ILInstance != null && tmp_ClrInstance.ILInstance.Type.CanAssignTo(tmp_Type))
                {
                    return tmp_ClrInstance.ILInstance;
                }
            }

            return null;
        }

        /// <summary>
        /// SendMessage
        /// </summary>
        /// <param name="_appDomain"></param>
        /// <param name="_go"></param>
        /// <param name="_methodName"></param>
        /// <param name="_value"></param>
        /// <param name="_option"></param>
        public static bool SendMessageWithILTypeInstance(AppDomain _appDomain, GameObject _go, string _methodName,
            object _value = null,
            SendMessageOptions _option = SendMessageOptions.RequireReceiver)
        {
            bool tmp_Found = false;

            var tmp_ClrInstances = _go.GetComponents<CrossBindingAdaptorType>();
            foreach (var tmp_ClrInstance in tmp_ClrInstances)
            {
                if (tmp_ClrInstance.ILInstance == null) continue;
                IType tmp_T = tmp_ClrInstance.ILInstance.Type;
                if (_value == null)
                {
                    IMethod tmp_M = tmp_T.GetMethod(_methodName, 0);
                    if (tmp_M == null) continue;
                    _appDomain.Invoke(tmp_M, tmp_ClrInstance.ILInstance, null);
                    tmp_Found = true;
                }
                else
                {
                    IMethod m = tmp_T.GetMethod(_methodName, 1);
                    if (m == null) continue;
                    _appDomain.Invoke(m, tmp_ClrInstance.ILInstance, _value);
                    tmp_Found = true;
                }
            }

            return tmp_Found;
        }

        /// <summary>
        /// Instantiate GameObject
        /// </summary>
        /// <param name="_gameObjectInMemory">GameObject of prefab</param>
        /// <param name="_instancedGameObject">GameObject of instanced in the scene</param>
        /// <param name="_domain">Script domain</param>
        /// <param name="_type"></param>
        /// <returns>Object</returns>
        public static object DoBinding(GameObject _gameObjectInMemory, GameObject _instancedGameObject,
            AppDomain _domain, IType _type = null)
        {
            // Check if the game object uses custom scripts (e.g.MonoBehaviour/XRMODBehaviour script).
            if (_instancedGameObject.GetComponentsInChildren<CrossBindingAdaptorType>(true).Length == 0)
            {
                // Check if game object uses MonoBinder
                if (_instancedGameObject.GetComponentsInChildren<MonoBinder>(true).Length > 0)
                { 
                    BinderManager.Instance.DoBind(_instancedGameObject.GetComponentsInChildren<MonoBinder>(true).ToList());
                }

                return _instancedGameObject;
            }

            bool tmp_NeedClassBind = false;

            // Remove all MonoBinder after binding
            foreach (var tmp_Transform in _instancedGameObject.GetComponentsInChildren<Transform>())
            {
                var tmp_MonoBinder = tmp_Transform.GetComponent<MonoBinder>();
                if (tmp_MonoBinder != null && tmp_Transform.GetComponent<CrossBindingAdaptorType>() != null)
                {
                    Object.DestroyImmediate(tmp_MonoBinder);
                }
            }


            if (_gameObjectInMemory.GetComponentsInChildren<MonoBinder>(true).Length > 0)
            {
                tmp_NeedClassBind = true;
            }

            var tmp_ClrInstances = _instancedGameObject.GetComponentsInChildren<CrossBindingAdaptorType>(true);
            var tmp_ClrMemoryInstances = _gameObjectInMemory.GetComponentsInChildren<CrossBindingAdaptorType>(true);

            ILTypeInstance tmp_Result = null;
            for (int tmp_Idx = 0; tmp_Idx < tmp_ClrInstances.Length; tmp_Idx++)
            {
                var tmp_ClrInstance = tmp_ClrInstances[tmp_Idx];
                var tmp_ClrMemoryInstance = tmp_ClrMemoryInstances[tmp_Idx];

                ILTypeInstance tmp_ILInstance = tmp_ClrMemoryInstance.ILInstance.Clone();

                var tmp_TypeInMemoryObject = tmp_ClrMemoryInstance.GetType();
                if (tmp_ILInstance.Type == _type && tmp_Result == null)
                {
                    tmp_Result = tmp_ILInstance;
                }

                if (tmp_ClrMemoryInstance is XRMODBehaviourAdapter.Adapter tmp_Adaptor)
                {
                    tmp_Adaptor.Reset();
                    tmp_Adaptor.ILInstance = tmp_ILInstance;
                    tmp_Adaptor.AppDomain = _domain;
                }
                else
                {
                    var tmp_IlInstance = tmp_TypeInMemoryObject.GetField("instance",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                    var tmp_AppDomain = tmp_TypeInMemoryObject.GetField("appdomain",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                    tmp_IlInstance?.SetValue(tmp_ClrInstance, tmp_ILInstance);
                    tmp_AppDomain?.SetValue(tmp_ClrInstance, _domain);
                }

                if (tmp_ClrMemoryInstance.ILInstance.CLRInstance == tmp_ClrMemoryInstance)
                {
                    tmp_ILInstance.CLRInstance = tmp_ClrInstance;
                }
                else
                {
                    tmp_ILInstance.CLRInstance = tmp_ILInstance;
                }


                var tmp_AwakeMethod =
                    (tmp_ClrInstance.GetType() != null ? tmp_ClrInstance.GetType() : tmp_TypeInMemoryObject).GetMethod(
                        "Awake",
                        BindingFlags.Default | BindingFlags.Public
                                             | BindingFlags.Instance | BindingFlags.FlattenHierarchy |
                                             BindingFlags.NonPublic | BindingFlags.Static);
                if (tmp_AwakeMethod != null)
                {
                    tmp_AwakeMethod.Invoke(tmp_ClrInstance, null);
                }

                // if (tmp_NeedClassBind)
                // {
                //     BinderManager.DoBind();
                // }
                // else
                // {
                //     if (_instancedGameObject.GetComponentInChildren<MonoBinder>(true))
                //     {
                //         BinderManager.DoBind(_instancedGameObject.GetComponentsInChildren<MonoBinder>(true).ToList());
                //     }
                // }

                BinderManager.Instance.DoBind(_instancedGameObject.GetComponentsInChildren<MonoBinder>(true).ToList());
            }

            if (_type != null)
            {
                return tmp_Result;
            }

            return _instancedGameObject;
        }


        internal static void GetCrossBindingAdaptorComponent<T>(T _target, out object _result,
            ILType _ilType, CrossBindingAdaptorType[] _crossBindingAdaptorArray) where T : UnityEngine.Object
        {
            object[] tmp_IlInstances = new object[_crossBindingAdaptorArray.Length];
            int tmp_Idx = 0;
            foreach (var tmp_ClrInstance in _crossBindingAdaptorArray)
            {
                if (tmp_ClrInstance.ILInstance != null &&
                    tmp_ClrInstance.ILInstance.Type.CanAssignTo(_ilType))
                {
                    tmp_IlInstances[tmp_Idx] = tmp_ClrInstance.ILInstance;
                    tmp_Idx++;
                }
            }

            Array.Resize(ref tmp_IlInstances, tmp_Idx);
            int tmp_IlInstancesLength = tmp_IlInstances.Length;
            _result = Array.CreateInstance(_ilType.TypeForCLR, tmp_IlInstancesLength);
            for (int tmp_Indices = 0; tmp_Indices < tmp_IlInstancesLength; tmp_Indices++)
                ((Array) _result).SetValue(((ILTypeInstance) tmp_IlInstances[tmp_Indices]).CLRInstance, tmp_Indices);
        }

        public static GameObject ProcessPrefabMonoBinder(GameObject _prefab)
        {
            var tmp_MonoBinders = _prefab.GetComponentsInChildren<MonoBinder>(true);
            bool tmp_NeedClassBind = tmp_MonoBinders.Length > 0;
            if (!tmp_NeedClassBind)
                return _prefab;
            BinderManager.Instance.DoBind(tmp_MonoBinders.ToList());
            return _prefab;
        }

        public static void InvokeConstructor(ILTypeInstance _instance, IType _ilType)
        {
            var tmp_Method = _ilType.GetConstructor(Extension.EmptyParamList);
            if (tmp_Method != null && _instance != null)
            {
                CodesHook.GetAppDomain.Invoke(tmp_Method, _instance, null);
            }
        }


        internal static void ProcessMonoBinder<T>(AsyncInstantiateOperation<T> _resultOfThisMethod)
            where T : Object
        {
            _resultOfThisMethod.completed += _operation =>
            {
                foreach (var tmp_Go in (_resultOfThisMethod.Result as GameObject[])!)
                {
                    var tmp_MonoBinders = tmp_Go.GetComponentsInChildren<MonoBinder>(true).Reverse();
                    foreach (MonoBinder tmp_MonoBinder in tmp_MonoBinders)
                    {
                        tmp_MonoBinder.ProcessMonoBinderTrigger(null);
                    }
                }
            };
        }
    }
}