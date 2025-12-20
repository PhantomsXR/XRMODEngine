using System;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.DataRequest;

namespace Phantom.XRMOD.SDKEntry.Runtime.Models
{
    [Serializable]
    public struct QueryParameter
    {
        public string URL;
        public string Token;
        public int Timeout;
        public string AppKey; 
        public string BundleId;
        public BackendType BackendType;
        public string experienceUid;
        public string Platform;
        public string Env;
        public string AssetBundleJsonUrl;
        public string AssetBundleContentUrl;
        public uint Crc;
        public string Hash;
    }
}
