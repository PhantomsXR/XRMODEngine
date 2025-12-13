using UnityEngine;
using Phantom.XRMOD.SDKEntry.Runtime;

namespace Phantom.XRMOD.SDKEntry.Test
{
    public class SupabaseIntegrationTest : MonoBehaviour
    {
        public string SupabaseUrl = "YOUR_SUPABASE_URL";
        public string SupabaseKey = "YOUR_SUPABASE_ANON_KEY";
        public string ProjectAppKey = "YOUR_APP_KEY";
        public string ProjectAppSecret = "YOUR_APP_SECRET";
        public string ExperienceId = "YOUR_EXPERIENCE_ID";
        public string Platform = "Android"; // or iOS

        public async void Start()
        {
            // Assuming SDKEntryPoint is attached to the same GameObject or found in scene
            var sdkEntryPoint = FindObjectOfType<SDKEntryPoint>();
            if (sdkEntryPoint == null)
            {
                Debug.LogError("SDKEntryPoint not found in scene.");
                return;
            }

            Debug.Log("Starting Supabase Query Test...");

            var (statusCode, error, package) = await sdkEntryPoint.QuerySupabaseExperience(
                SupabaseUrl,
                SupabaseKey,
                ExperienceId,
                Platform,
                ProjectAppKey,
                ProjectAppSecret
            );

            if (statusCode == 200)
            {
                Debug.Log($"Success! Package Found.");
                Debug.Log($"Bundle URL: {package.BundleUrl}");
                Debug.Log($"Bundle JSON: {package.BundleJson}");
                Debug.Log($"Version: {package.Version}");
                Debug.Log($"File Size: {package.FileSize}");
            }
            else
            {
                Debug.LogError($"Query Failed. Status: {statusCode}, Error: {error}");
            }
        }
    }
}
