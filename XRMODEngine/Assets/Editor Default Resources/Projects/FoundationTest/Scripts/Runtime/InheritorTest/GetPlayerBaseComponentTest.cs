using Phantom.XRMOD.Core.Runtime;
using UnityEngine.Assertions;

namespace FoundationTest.Runtime
{
    public class GetPlayerBaseComponentTest : XRMODBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            var tmp_PlayerBase = transform.GetComponent<PlayerBase>();
            var tmp_PlayerVisual = GetComponentInChildren<PlayerVisual>();
            Assert.IsNotNull(tmp_PlayerVisual);
            Assert.IsNotNull(tmp_PlayerBase);
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}