using System;
using UnityEngine;

namespace Phantom.XRMOD.RenderAssistant.Runtime.structs
{
    [Serializable] public struct RendererInfo
    {
        public Renderer renderer;
        public int lightmapIndex;
        public Vector4 lightmapOffsetScale;
    }
}