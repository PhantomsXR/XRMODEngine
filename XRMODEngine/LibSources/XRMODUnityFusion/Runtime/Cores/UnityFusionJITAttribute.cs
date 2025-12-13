using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityFusion.Runtime
{
    public static class UnityFusionJITFlags
    {
        public const int None = 0;
        /// <summary>
        /// Method will be JIT when method is called multiple time
        /// </summary>
        public const int JITOnDemand = 1;
        /// <summary>
        /// Method will be JIT immediately when called, instead of progressively warm up
        /// </summary>
        public const int JITImmediately = 2;
        /// <summary>
        /// Method will not be JIT when called
        /// </summary>
        public const int NoJIT = 4;
        /// <summary>
        /// Method will always be inlined when called
        /// </summary>
        public const int ForceInline = 8;
    }
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class UnityFusionJITAttribute : Attribute
    {
        int flags;

        public int Flags { get { return flags; } }
        public UnityFusionJITAttribute()
        {
            this.flags = UnityFusionJITFlags.JITOnDemand;
        }

        public UnityFusionJITAttribute(int flags)
        {
            this.flags = flags;
        }
    }
}
