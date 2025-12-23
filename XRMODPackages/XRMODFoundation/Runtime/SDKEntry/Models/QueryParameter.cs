using System;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.DataRequest;

namespace Phantom.XRMOD.SDKEntry.Runtime.Models
{ 
    /// <summary>
    /// Parameters used when querying or launching an XR experience via the SDK entry point.
    /// </summary>
    [Serializable]
    public struct QueryParameter
    {
        /// <summary> Base URL for backend services. </summary>
        public string URL;
        /// <summary> Authentication token for secured requests. </summary>
        public string Token;
        /// <summary> Network request timeout in seconds. </summary>
        public int Timeout;
        /// <summary> Unique application key assigned to the developer. </summary>
        public string AppKey; 
        /// <summary> Application bundle identifier (package name). </summary>
        public string BundleId;
        /// <summary> The type of backend system being queried. </summary>
        public BackendType BackendType;
        /// <summary> Unique ID for a specific XR experience. </summary>
        public string experienceUid;
        /// <summary> Target operating system platform. </summary>
        public string Platform;
        /// <summary> Deployment environment (e.g., Development, Production). </summary>
        public string Env;
        /// <summary> Direct URL to the asset bundle manifest. </summary>
        public string AssetBundleJsonUrl;
        /// <summary> Direct URL to the asset bundle file. </summary>
        public string AssetBundleContentUrl;
        /// <summary> Expected CRC value for integrity check. </summary>
        public uint Crc;
        /// <summary> Expected hash value for integrity check. </summary>
        public string Hash;
    }
}
