using System;
using System.Threading.Tasks;
using Phantom.XRMOD.SDKEntry.Supabase;
using UnityEngine;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    public partial class SDKEntryPoint
    {
        /// <summary>
        /// Query Supabase for Experience Package data.
        /// </summary>
        /// <param name="_url">Supabase URL</param>
        /// <param name="_supabaseKey">Supabase Anon Key</param>
        /// <param name="_experienceId">Experience ID</param>
        /// <param name="_platform">Platform Name (e.g., "Android", "iOS")</param>
        /// <param name="_appKey">Project App Key</param>
        /// <param name="_appSecret">Project App Secret</param>
        /// <returns>Task with (StatusCode, ErrorMessage, PackageObject)</returns>
        public async Task<(int statusCode, string error, ExperiencePlatformPackage package)> QuerySupabaseExperience(
            string _url, string _supabaseKey, string _experienceId,
            string _platform, string _appKey, string _appSecret)
        {
            try
            {
                if (string.IsNullOrEmpty(_url) || string.IsNullOrEmpty(_supabaseKey))
                {
                    Debug.LogError("Supabase URL or Key is empty.");
                    return (500, "Supabase URL or Key is empty.", null);
                }

                // Initialize Supabase Client
                await SupabaseManager.Instance.InitializeAsync(_url, _supabaseKey);

                // Perform Query
                return await SupabaseManager.Instance.QueryExperiencePackage(_experienceId, _platform, _appKey,
                    _appSecret, sdkEntryPointModel.SDKInformation.environmentType.ToString().ToLower());
            }
            catch (Exception ex)
            {
                Debug.LogError($"QuerySupabaseExperience Exception: {ex.Message}");
                return (500, ex.Message, null);
            }
        }
    }
}