using System.Collections.Generic;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    [System.Serializable]
    public class GroupModel : BaseModel
    {
        public List<ContentModel> Assets = new List<ContentModel>();
    }
}
