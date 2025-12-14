using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.XRMODSimulator.Editor
{
    public class RuntimeUINotchAdapter : MonoBehaviour
    {
        private Rect lastSafeArea = Rect.zero;

        // Start is called before the first frame update
        void Start()
        {
            lastSafeArea = Screen.safeArea;
            var tmp_Doc = GetComponent<UIDocument>();
            VisualElement tmp_Root = tmp_Doc.rootVisualElement;
            var tmp_NotchAdapterArea = tmp_Root.Q<VisualElement>("adapt_for_notch_devices");
            tmp_NotchAdapterArea.style.paddingTop = new StyleLength(new Length(lastSafeArea.yMin));
        }
    }
}