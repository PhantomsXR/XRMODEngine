using System.IO;
using System.Threading.Tasks;
using Phantom.XRMOD.Localization.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;


#if USE_XRMOD_GAMESERVICES
using Phantom.XRMOD.GameServices.Runtime;
using Unity.Services.Core;
#endif

namespace Phantom.XRMOD.XRMODSimulator.Runtime
{
    public class Simulator : MonoBehaviour
    {
#if UNITY_EDITOR
        public string ProjectName;

        private string serverPath;

#if USE_XRMOD_GAMESERVICES
        internal UserInfoModel UserInfoModel = new();
#endif

        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }

        private void Start()
        {
            SDKInitialization.Initialize();
            CreateServer();
            Request();
        }

        [ContextMenu("Action/Request Project")]
        private async void Request()
        {
            var tmp_DelayTime = XRMODSimulatorSettings.GetOrCreateSettings().loadDelayTime;
            ProjectName = XRMODSimulatorSettings.GetOrCreateSettings().projectName;
            await Task.Delay(Mathf.CeilToInt(tmp_DelayTime) * 1000);
#if USE_XRMOD_GAMESERVICES
            if (XRMODSimulatorSettings.GetOrCreateSettings().useXRMODGameServices)
            {
                var tmp_XrmodGameServicesManager = FindFirstObjectByType<XRMODGameServicesManager>();
                tmp_XrmodGameServicesManager.GameServicesReady.AddListener(async () =>
                {
                    StartSimulating();
                });

                AuthenticationSystemManager.SignedInCallback += OnSignedInCallback;
                AuthenticationSystemManager.SignFailedCallback += OnSignFailedCallback;
                await tmp_XrmodGameServicesManager.InitializeUnityServicesAsync();
                await AuthenticationSystemManager.SignInWithAnonymous();
            }
            else
            {
                StartSimulating();
            }
#else
            StartSimulating();
#endif
        }

#if USE_XRMOD_GAMESERVICES
        private void OnSignFailedCallback(RequestFailedException _obj)
        {
            Debug.LogError(_obj);
        }

        private void OnSignedInCallback()
        {
            UserInfoModel = AuthenticationSystemManager.GetUserInfo(); 
        }
#endif

        [ContextMenu("Action/Release Project")]
        internal void ReleaseProject()
        {
            SDKEntryPoint tmp_Entry = FindFirstObjectByType<SDKEntryPoint>();
            tmp_Entry.ReleaseProcess("0");
        }

        private void OnDisable()
        {
            StopServing();
        }

        private void CreateServer()
        {
            serverPath = Application.dataPath.Replace("Assets", "ServerData");
            serverPath = Path.Combine(serverPath, RuntimePlatformHelper.GetPlatformName().ToLower());
        }


        public void StopServing()
        {
            //httpServer?.Stop();
        }

        public void StartSimulating()
        {
            SDKEntryPoint tmp_Entry = FindFirstObjectByType<SDKEntryPoint>();
            SDKConfiguration tmp_Configs = new SDKConfiguration
            {
                engineType = EngineType.Unity,
                dashboardConfig = new DashboardConfig {token = "", dashboardGateway = serverPath},
                customConfig = new CustomConfig(),
                imageCloudRecognizerConfig = new ImageCloudRecognizerConfig(),
                AppModel = AppModel.Simulator
            };

            LocalizationManagerV2.Instance.SetLanguage(XRMODSimulatorSettings.GetOrCreateSettings().systemLanguage);

            tmp_Entry.InitSDK(tmp_Configs);
            tmp_Entry.LaunchXRQuery(ProjectName.ToLower());
        }

#endif
    }
}