using System;
using UnityEngine;

namespace Phantom.XRMOD.RenderAssistant.Runtime.structs
{
    [Serializable] public struct LightInfo
    {
        public Light light;
        public int lightmapBaketype;
        public int mixedLightingMode;
    }
}
