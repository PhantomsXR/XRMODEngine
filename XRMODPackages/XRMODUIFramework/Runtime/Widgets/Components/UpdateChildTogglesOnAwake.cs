using UnityEngine;
using UnityEngine.UI;

namespace Phantom.XRMOD.UIFramework.Runtime
{
    public class UpdateChildTogglesOnAwake : MonoBehaviour
    {
        private void Awake()
        {
            foreach (var toggle in GetComponentsInChildren<Toggle>())
            {
                toggle.onValueChanged.Invoke(toggle.isOn);
            }
        }
    }
}
