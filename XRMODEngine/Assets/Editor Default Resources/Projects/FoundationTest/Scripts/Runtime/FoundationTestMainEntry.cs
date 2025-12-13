using UnityEngine;
using System.Threading.Tasks;
using Phantom.XRMOD.ActionNotification.Runtime;


namespace FoundationTest.Runtime
{
    public class FoundationTestMainEntry
    {
        private SharedData sharedData = SharedData.GetInstance;


        public void OnLoad()
        {
            // var tmp_RenderPiplineAsset =
            //     await sharedData.sharedData.XRMODAPI.LoadAssetAsync<UniversalRenderPipelineAsset>("OcclusionEffectPipeline");
            // Assert.IsNotNull(tmp_RenderPiplineAsset, "tmp_RenderPiplineAsset != null");
            // QualitySettings.renderPipeline = tmp_RenderPiplineAsset;
            sharedData.LoadAssets();
        }

        public void OnEvent(BaseNotificationData _data)
        {
        }

        public void OnUpdate()
        {
            //Like Unity Update method. Please delete the function if it is not used
        }

        /// <summary>
        ///     Release Memory after XR close. Please delete the function if it is not used
        /// </summary>
        public void ReleaseMemory(string _projectName)
        {
            if (nameof(FoundationTest) != _projectName) return;

            sharedData.Dispose();
            sharedData = null;
        }
    }
}