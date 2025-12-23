using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.RenderAssistant.Runtime.structs;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace Phantom.XRMOD.RenderAssistant.Runtime
{
    /// <summary>
    /// Component that facilitates "baking" lightmap data into a prefab.
    /// This allows prefabs to maintain their baked lighting information when instantiated in different scenes.
    /// </summary>
    [ExecuteInEditMode]
    public class PrefabBaker : MonoBehaviour
    {
        /// <summary> Information about lights included in the bake. </summary>
        [SerializeField] public LightInfo[] lights;
        /// <summary> Renderers whose lightmap data is being preserved. </summary>
        [SerializeField] public Renderer[] renderers;
        /// <summary> The lightmap index for each renderer. </summary>
        [SerializeField] public int[] renderersLightmapIndex;
        /// <summary> The lightmap offset and scale (ST) for each renderer. </summary>
        [SerializeField] public Vector4[] renderersLightmapOffsetScale;
        /// <summary> The baked color lightmap textures. </summary>
        [SerializeField] public Texture2D[] texturesColor;
        /// <summary> The baked directional lightmap textures. </summary>
        [SerializeField] public Texture2D[] texturesDir;
        /// <summary> The baked shadow mask textures. </summary>
        [SerializeField] public Texture2D[] texturesShadow;
        /// <summary> The light probes data to use when these objects are moved. </summary>
        public LightProbes LightProbes;

        /// <summary>
        /// Retrieves all baked textures (color, directional, and shadow) as a nested array.
        /// </summary>
        /// <returns>A 2D array of textures.</returns>
        public Texture2D[][] AllTextures() => new Texture2D[][]
        {
            texturesColor, texturesDir, texturesShadow
        };

        /// <summary>
        /// Checks if the baker has any valid bake data to apply.
        /// </summary>
        public bool HasBakeData => (renderers?.Length ?? 0) > 0 && (texturesColor?.Length ?? 0) > 0;

        /// <summary>
        /// Checks if the current baked data is already fully applied to the global LightmapSettings.
        /// </summary>
        public bool BakeApplied
        {
            get
            {
                bool hasColors = Utils.SceneHasAllLightmaps(texturesColor);
                bool hasDirs = Utils.SceneHasAllLightmaps(texturesDir);
                bool hasShadows = Utils.SceneHasAllLightmaps(texturesShadow);
                return hasColors && hasDirs && hasShadows;
            }
        }

        void Start()
        {
            // Warnning : this will mess up the renderer lightmaps reference
            // // StaticBatchingUtility.Combine( gameObject );

            if (!LightProbes) return;
            LightmapSettings.lightProbes = LightProbes;
            LightProbes.TetrahedralizeAsync();
        }

        /// <summary>
        /// True if a bake was just applied in the current session.
        /// </summary>
        public bool BakeJustApplied { private set; get; } = false;

        void Awake()
        {
            BakeApply();
            ActionNotificationCenter.DefaultCenter.AddObserver((_data) => { ForceLightingBakeApply(); },
                nameof(ActionParameterDataType.ForceLightingBakeApply));
        }

        /// <summary>
        /// Attempts to apply the baked lightmap data to the renderers and global settings.
        /// </summary>
        public void BakeApply()
        {
            if (!HasBakeData)
            {
                BakeJustApplied = false;
                return;
            }


            if (!BakeApplied)
            {
                BakeJustApplied = Utils.Apply(this);
            }
        }

        private void ForceLightingBakeApply()
        {
            BakeJustApplied = Utils.Apply(this);
        }

        void OnEnable()
        {
            if (!Application.isPlaying)

                BakeApply();

            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        void OnSceneLoaded(Scene _scene, LoadSceneMode _mode)
        {
            BakeApply();
        }

        void OnDisable()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }

        public static System.Action onValidate;

        private void OnValidate()
        {
            onValidate?.Invoke();
        }
    }
}