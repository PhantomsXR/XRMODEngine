using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Supabase;
using Newtonsoft.Json.Linq;
using Phantom.XRMOD.SDKEntry.Runtime;
using Postgrest;
using UnityEngine;
using Client = Supabase.Client;

namespace Phantom.XRMOD.SDKEntry.Supabase
{
    public class SupabaseManager
    {
        private Client _client;
        private static SupabaseManager _instance;

        public static SupabaseManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SupabaseManager();
                }

                return _instance;
            }
        }

        /// <summary>
        /// Initialize the Supabase client.
        /// </summary>
        /// <param name="_url">Supabase URL</param>
        /// <param name="_key">Supabase Anon Key</param>
        public async Task InitializeAsync(string _url, string _key)
        {
            var tmp_Options = new SupabaseOptions
            {
                AutoRefreshToken = true,
                AutoConnectRealtime = false
            };
            _client = await Client.InitializeAsync(_url, _key, tmp_Options);
        }

        /// <summary>
        /// Query Experience Package data.
        /// </summary>
        /// <param name="_experienceId">Experience ID</param>
        /// <param name="_platformName">Platform Name (e.g., "Android", "iOS")</param>
        /// <param name="_appKey">Project App Key</param>
        /// <param name="_appSecret">Project App Secret</param>
        /// <param name="_environment"></param>
        /// <returns>Tuple with status code, error message, and package object</returns>
        public async Task<(int statusCode, string error, ExperiencePlatformPackage package)> QueryExperiencePackage(
            string _experienceId, string _platformName, string _appKey, string _appSecret, string _environment)
        {
            if (_client == null)
            {
                return (500, "Supabase client not initialized", null);
            }

            try
            {
                // 1. Validate Project (Auth) & Get Environment
                var projectResponse = await _client.From<Project>().Match(new Dictionary<string, string>()
                    {
                        {"app_key", _appKey},
                        {"app_secret", _appSecret},
                        {"environment", _environment},
                    })
                    .Get();

                if (projectResponse.Models.Count == 0)
                {
                    Debug.LogWarning($"[SupabaseManager] Unauthorized: Invalid App Key or Secret. AppKey: {_appKey}");
                    return (401, "Unauthorized: Invalid App Key or Secret", null);
                }

                // 2. Resolve Platform ID
                // We assume a 'platforms' table exists with 'name' column.
                // If platform names are case-sensitive in DB, ensure exact match or use ILike if supported/needed.
                // Here we assume exact match or user provides correct casing.
                var platformResponse = await _client.From<Platform>().Match(new Dictionary<string, string>()
                    {
                        {"code", _platformName.ToLower()},
                        {"is_active", "true"},
                    })
                    .Get();

                if (platformResponse.Models.Count == 0)
                {
                    Debug.LogWarning($"[SupabaseManager] Platform '{_platformName}' not found.");
                    return (404, $"Platform '{_platformName}' not found", null);
                }

                var platformId = platformResponse.Models[0].Id;

                // 3. Query Experience Platform Package
                // We filter by ExperienceId, PlatformId, Environment, and IsActive
                var packageResponse = await _client.From<ExperiencePlatformPackage>()
                    .Match(new Dictionary<string, string>()
                    {
                        {"experience_id", _experienceId},
                        {"platform_id", platformId},
                        {"environment", _environment},
                    })
                    .Get();

                if (packageResponse.Models.Count == 0)
                {
                    Debug.LogWarning(
                        $"[SupabaseManager] Experience Package not found. ExperienceId: {_experienceId}, Platform: {_platformName}, Environment: {_environment}");
                    return (404, "Experience Package not found for this platform/environment", null);
                }

                var package = packageResponse.Models[0];

                if (string.IsNullOrEmpty(package.BundleUrl))
                {
                    Debug.LogWarning($"[SupabaseManager] Package Bundle URL is empty. PackageId: {package.Id}");
                    return (404, "Package Bundle URL is empty", null);
                }
                
                return (200, null, package);
            }
            catch (Exception ex)
            {
                Debug.LogError($"Supabase Query Error: {ex.Message}");
                return (500, ex.Message, null);
            }
        }
    }
}