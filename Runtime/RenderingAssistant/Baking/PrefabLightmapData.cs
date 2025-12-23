using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Phantom.XRMOD.RenderAssistant.Runtime
{
    /// <summary>
    /// Component used to store and apply lightmap data for prefabs that are instantiated at runtime.
    /// This is an older implementation compared to <see cref="PrefabBaker"/> but still used in some contexts.
    /// </summary>
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    [ExecuteAlways]
    public class PrefabLightmapData : MonoBehaviour
    {
        /// <summary> Data structure storing lightmap assignment information for a renderer. </summary>
        [System.Serializable]
        public struct RendererInfo
        {
            /// <summary> The renderer component. </summary>
            public Renderer Renderer;
            /// <summary> The index of the lightmap in the global list. </summary>
            public int LightmapIndex;
            /// <summary> The UV offset and scale for the lightmap. </summary>
            public Vector4 LightmapOffsetScale;
        }

        /// <summary> Data structure storing basic information about a baked light. </summary>
        [System.Serializable]
        public struct LightInfo
        {
            /// <summary> The light component. </summary>
            public Light Light;
            /// <summary> The type of light baking (e.g., Baked, Mixed). </summary>
            public int LightmapBaketype;
            /// <summary> The mixed lighting mode. </summary>
            public int MixedLightingMode;
        }

        /// <summary> List of renderers and their corresponding lightmap data. </summary>
        public RendererInfo[] m_RendererInfo;
        /// <summary> Array of color lightmap textures. </summary>
        public Texture2D[] m_Lightmaps;
        /// <summary> Array of directional lightmap textures. </summary>
        public Texture2D[] m_LightmapsDir;
        /// <summary> Array of shadow mask textures. </summary>
        public Texture2D[] m_ShadowMasks;
        /// <summary> List of lights and their baking settings. </summary>
        public LightInfo[] m_LightInfo;


       public void Start()
        {
            Init();
        }

        /// <summary>
        /// Initializes the lightmaps in the scene by combining the prefab's lightmaps with existing scene lightmaps.
        /// </summary>
        public void Init()
        {
            if (m_RendererInfo == null || m_RendererInfo.Length == 0)
                return;

            var tmp_Lightmaps = LightmapSettings.lightmaps;
            int[] tmp_Offsetsindexes = new int[m_Lightmaps.Length];
            int tmp_Counttotal = tmp_Lightmaps.Length;
            List<LightmapData> tmp_CombinedLightmaps = new List<LightmapData>();

            for (int tmp_Index = 0; tmp_Index < m_Lightmaps.Length; tmp_Index++)
            {
                bool tmp_Exists = false;
                for (int j = 0; j < tmp_Lightmaps.Length; j++)
                {
                    if (m_Lightmaps[tmp_Index] != tmp_Lightmaps[j].lightmapColor) continue;
                    tmp_Exists = true;
                    tmp_Offsetsindexes[tmp_Index] = j;
                }

                if (tmp_Exists) continue;
                tmp_Offsetsindexes[tmp_Index] = tmp_Counttotal;
                var tmp_Newlightmapdata = new LightmapData
                {
                    lightmapColor = m_Lightmaps[tmp_Index],
                    lightmapDir = m_LightmapsDir.Length == m_Lightmaps.Length
                        ? m_LightmapsDir[tmp_Index]
                        : default,
                    shadowMask = m_ShadowMasks.Length == m_Lightmaps.Length
                        ? m_ShadowMasks[tmp_Index]
                        : default,
                };

                tmp_CombinedLightmaps.Add(tmp_Newlightmapdata);

                tmp_Counttotal += 1;
            }

            var tmp_CombinedLightmaps2 = new LightmapData[tmp_Counttotal];

            tmp_Lightmaps.CopyTo(tmp_CombinedLightmaps2, 0);
            tmp_CombinedLightmaps.ToArray().CopyTo(tmp_CombinedLightmaps2, tmp_Lightmaps.Length);

            bool tmp_Directional = true;

            foreach (var tmp_Texture in m_LightmapsDir)
            {
                if (tmp_Texture != null) continue;
                tmp_Directional = false;
                break;
            }

            LightmapSettings.lightmapsMode = (m_LightmapsDir.Length == m_Lightmaps.Length && tmp_Directional)
                ? LightmapsMode.CombinedDirectional
                : LightmapsMode.NonDirectional;
            ApplyRendererInfo(m_RendererInfo, tmp_Offsetsindexes, m_LightInfo);
            LightmapSettings.lightmaps = tmp_CombinedLightmaps2;
            Debug.Log("Finished");
        }

        void OnEnable()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        // called second
        void OnSceneLoaded(Scene _scene, LoadSceneMode _mode)
        {
            Init();
        }

        // called when the game is terminated
        void OnDisable()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }


        static void ApplyRendererInfo(RendererInfo[] _infos, int[] _lightmapOffsetIndex, LightInfo[] _lightsInfo)
        {
            foreach (var tmp_Info in _infos)
            {
                tmp_Info.Renderer.lightmapIndex = _lightmapOffsetIndex[tmp_Info.LightmapIndex];
                tmp_Info.Renderer.lightmapScaleOffset = tmp_Info.LightmapOffsetScale;

//                Material[] tmp_Mats = tmp_Info.Renderer.sharedMaterials;
//                foreach (var tmp_Mat in tmp_Mats)
//                {
//                    if (tmp_Mat != null && Shader.Find(tmp_Mat.shader.name) != null)
//                        tmp_Mat.shader = Shader.Find(tmp_Mat.shader.name);
//                }
            }

            for (int tmp_Index = 0; tmp_Index < _lightsInfo.Length; tmp_Index++)
            {
                var tmp_BakingOutput = new LightBakingOutput
                {
                    isBaked = true,
                    lightmapBakeType = (LightmapBakeType) _lightsInfo[tmp_Index].LightmapBaketype,
                    mixedLightingMode = (MixedLightingMode) _lightsInfo[tmp_Index].MixedLightingMode
                };

                _lightsInfo[tmp_Index].Light.bakingOutput = tmp_BakingOutput;
            }
        }
    }
}