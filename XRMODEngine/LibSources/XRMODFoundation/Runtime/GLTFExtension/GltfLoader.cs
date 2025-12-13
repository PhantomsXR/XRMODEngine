// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XR-MOD SDK.
// //
// // The XR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GLTFast;
using GLTFast.Loading;
using GLTFast.Logging;
using GLTFast.Materials;
using UnityEngine;

namespace Phantom.XRMOD.GLTFExtension.Runtime
{
    public class GltfLoader : GltfAsset
    {
        [Tooltip("Create a box collider encapsulating the glTF asset")]
        public bool createBoxCollider = true;

        [NonSerialized] public Bounds bounds;
        public GameObject LoadedGameObject { get; private set; }

        public override async Task<bool> Load(
            string url,
            IDownloadProvider downloadProvider = null,
            IDeferAgent deferAgent = null,
            IMaterialGenerator materialGenerator = null,
            ICodeLogger logger = null
        )
        {
            Importer = new GltfImport(downloadProvider, deferAgent, materialGenerator);
            var success = await Importer.Load(url);
            if (success)
            {
                var insta = (GameObjectBoundsInstantiator) GetDefaultInstantiator(logger);
                // Auto-Instantiate
                if (SceneId >= 0)
                {
                    success = await Importer.InstantiateSceneAsync(insta, SceneId);
                    CurrentSceneId = success ? SceneId : (int?) null;
                }
                else
                {
                    success = await Importer.InstantiateSceneAsync(insta);
                    CurrentSceneId = Importer.DefaultSceneIndex;
                }

                SceneInstance = insta.SceneInstance;

                if (success)
                {
                    SetBounds(insta);
                }
            }

            return success;
        }

        public override async Task<bool> InstantiateScene(int sceneIndex, ICodeLogger logger = null)
        {
            var instantiator = (GameObjectBoundsInstantiator) GetDefaultInstantiator(logger);
            var success = await base.InstantiateScene(sceneIndex, instantiator);
            CurrentSceneId = success ? sceneIndex : (int?) null;
            SceneInstance = instantiator.SceneInstance;
            if (success)
            {
                if (SceneInstance.Cameras is {Count: > 0})
                {
                    foreach (Camera tmp_Camera in SceneInstance.Cameras)
                    {
                        tmp_Camera.enabled = false;
                    }
                }

                SetBounds(instantiator);
                LoadedGameObject = this.gameObject;
            }

            return success;
        }

        protected override IInstantiator GetDefaultInstantiator(ICodeLogger logger)
        {
            return new GameObjectBoundsInstantiator(Importer, transform, logger);
        }


        void SetBounds(GameObjectBoundsInstantiator insta)
        {
            var sceneBounds = insta.SceneInstance != null ? insta.CalculateBounds() : null;
            if (sceneBounds.HasValue)
            {
                bounds = sceneBounds.Value;
                if (createBoxCollider)
                {
#if UNITY_PHYSICS
                    var boxCollider = gameObject.AddComponent<BoxCollider>();
                    boxCollider.center = bounds.center;
                    boxCollider.size = bounds.size;
#else
                    Debug.LogError(
                        "GltfBoundsAsset requires the built-in Physics package to be enabled (in the Package Manager)");
#endif
                }
            }
        }
    }

    public static class ExtensionFroTransform
    {
        public static List<GameObject> GetAllChildren(this Transform _parent)
        {
            List<GameObject> tmp_Children = new List<GameObject>();

            Queue<Transform> tmp_Queue = new Queue<Transform>();
            tmp_Queue.Enqueue(_parent);
            while (tmp_Queue.Count > 0)
            {
                var c = tmp_Queue.Dequeue();

                tmp_Children.Add(c.gameObject);

                foreach (Transform t in c)
                    tmp_Queue.Enqueue(t);
            }

            return tmp_Children;
        }
    }
}