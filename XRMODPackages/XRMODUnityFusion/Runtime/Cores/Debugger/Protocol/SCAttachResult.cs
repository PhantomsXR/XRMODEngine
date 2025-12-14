using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityFusion.Runtime.Debugger.Protocol
{
    public enum AttachResults
    {
        OK,
        AlreadyAttached,
    }
    public class SCAttachResult
    {
        public AttachResults Result { get; set; }
        public int DebugServerVersion { get; set; }
    }
}
