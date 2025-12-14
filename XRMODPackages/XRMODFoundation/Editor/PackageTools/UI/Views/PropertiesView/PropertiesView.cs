using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class PropertiesView : VisualElement
    {
        public new class UxmlFactory : UxmlFactory<PropertiesView, VisualElement.UxmlTraits>
        {
        }

        public PropertiesView()
        {
            var tmp_PropertiesRenderer = new PropertiesRenderer();
            Add(tmp_PropertiesRenderer);
            tmp_PropertiesRenderer.Initialization();

            AddToClassList("full-vertical-view");
            tmp_PropertiesRenderer.AddToClassList("full-vertical-view");
            EditorNotificationCenter.Center.AddObserver(_data => { tmp_PropertiesRenderer.Initialization(); },
                nameof(EditingProjectCommand));
        }
    }
}