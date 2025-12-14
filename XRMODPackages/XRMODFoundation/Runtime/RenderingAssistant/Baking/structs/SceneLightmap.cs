using UnityEngine;

namespace Phantom.XRMOD.RenderAssistant.Runtime.structs
{
    public struct SceneLightmap
    {
        public int lightMapIndex;
        public Texture2D texColor;
        public Texture2D texDir;
        public Texture2D texShadow;
    }
}
