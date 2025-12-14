using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.RenderAssistant.Runtime.structs;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace Phantom.XRMOD.RenderAssistant.Runtime
{
    [ExecuteInEditMode]
    public class PrefabBaker : MonoBehaviour
    {
        [SerializeField] public LightInfo[] lights;
        [SerializeField] public Renderer[] renderers;
        [SerializeField] public int[] renderersLightmapIndex;
        [SerializeField] public Vector4[] renderersLightmapOffsetScale;
        [SerializeField] public Texture2D[] texturesColor;
        [SerializeField] public Texture2D[] texturesDir;
        [SerializeField] public Texture2D[] texturesShadow;
        public LightProbes LightProbes;

        public Texture2D[][] AllTextures() => new Texture2D[][]
        {
            texturesColor, texturesDir, texturesShadow
        };

        public bool HasBakeData => (renderers?.Length ?? 0) > 0 && (texturesColor?.Length ?? 0) > 0;

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

        public bool BakeJustApplied { private set; get; } = false;

        void Awake()
        {
            BakeApply();
            ActionNotificationCenter.DefaultCenter.AddObserver((_data) => { ForceLightingBakeApply(); },
                nameof(ActionParameterDataType.ForceLightingBakeApply));
        }

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