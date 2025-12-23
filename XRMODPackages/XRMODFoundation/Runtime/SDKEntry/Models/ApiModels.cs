using System;
using System.Collections.Generic;

namespace Phantom.XRMOD.SDKEntry.Runtime.Models
{


    /// <summary>
    /// Data model for XR experience assets hosted on a Supabase backend.
    /// </summary>
    [Serializable]
    public class SupabaseExperienceAssets
    {
        /// <summary> Target platform (e.g., Android, iOS). </summary>
        public string platform; 
        /// <summary> URL for the asset bundle file. </summary>
        public string bundle_url;
        /// <summary> URL for the experience configuration JSON. </summary>
        public string config_url;
        /// <summary> Size of the asset bundle in bytes. </summary>
        public long size; 
        /// <summary> Unique identifier for the experience. </summary>
        public string experience_id;
        /// <summary> Unique identifier for the project. </summary>
        public string project_id;
    }

    /// <summary>
    /// Generic API response wrapper for standard backend systems.
    /// </summary>
    /// <typeparam name="T">The type of data contained in the response.</typeparam>
    [Serializable]
    public class ApiResponse<T>
    {
        /// <summary> Status code of the response. </summary>
        public int Code;
        /// <summary> The payload data. </summary>
        public T Data;
        /// <summary> Human-readable message from the server. </summary>
        public string Message;
    }
    
    
    /// <summary>
    /// Generic API response wrapper for Supabase backend systems.
    /// </summary>
    /// <typeparam name="T">The type of data contained in the response.</typeparam>
    [Serializable]
    public class ApiResponseSupabase<T>
    {
        /// <summary> Status code of the response. </summary>
        public int code;
        /// <summary> The payload data. </summary>
        public T data;
        /// <summary> Error message from the server if the request failed. </summary>
        public string error;
        /// <summary> Complementary message from the server. </summary>
        public string message;
    }
}
