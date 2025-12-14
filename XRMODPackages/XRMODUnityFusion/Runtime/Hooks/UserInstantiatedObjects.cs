// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the UnityFusion.Runtime.CodeHook.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;
using Phantom.XRMOD.Core.Runtime;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public class UserInstantiatedObjects : IReleaseCommand
    {
        private readonly List<Object> userInstantiateGameObjects = new();

        public void AddGameObject(Object _object)
        {
            userInstantiateGameObjects.Add(_object);
        }


        public void Release(string _projectName = null)
        {
            try
            {
                for (int tmp_Idx = 0; tmp_Idx < userInstantiateGameObjects.Count; tmp_Idx++)
                {
                    var tmp_Obj = userInstantiateGameObjects[tmp_Idx];
                    if (tmp_Obj == null) continue;
                    Object.Destroy(tmp_Obj);
                }


                userInstantiateGameObjects.Clear();
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                throw;
            }
        }
    }
}