using System;
using System.Collections.Generic;

namespace Phantom.XRMOD.SDKEntry.Runtime.Models
{


    [Serializable]
    public class SupabaseExperienceAssets
    {
        public string platform; 
        public string bundle_url;
        public string config_url;
        public long size; 
        public string experience_id;
        public string project_id;
    }

    [Serializable]
    public class ApiResponse<T>
    {
        public int Code;
        public T Data;
        public string Message;
    }
    
    
    [Serializable]
    public class ApiResponseSupabase<T>
    {
        public int code;
        public T data;
        public string error;
        public string message;
    }
}
