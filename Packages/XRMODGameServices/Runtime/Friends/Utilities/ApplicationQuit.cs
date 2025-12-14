using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class ApplicationQuit : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                Quit();
        }

        [UsedImplicitly]
        public void Quit()
        {
#if(UNITY_EDITOR)
            EditorApplication.ExitPlaymode();
#else   
            Application.Quit();
#endif
        }
    }
}