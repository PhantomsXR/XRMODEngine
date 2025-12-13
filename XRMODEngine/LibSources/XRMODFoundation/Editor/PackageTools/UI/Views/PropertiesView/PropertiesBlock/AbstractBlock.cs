using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    [System.Serializable]
    public abstract class AbstractBlock
    {
        protected readonly Configures property;
        protected const string CONST_HELP_BASE_URL = "https://docs.phantomsxr.com/ar-block-features/";
        protected const string CONST_HELP_BUTTON_TITLE = "Document";
        
        public AbstractBlock(Configures _property)
        {
            property = _property;
        }
        public abstract Rect DrawBlock(Rect _area);
        
        public abstract bool OnRemoved();

        public abstract bool OpenReference();
    }
}