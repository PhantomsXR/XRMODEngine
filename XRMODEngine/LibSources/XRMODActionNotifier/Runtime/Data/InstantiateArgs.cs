using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    public class InstantiateArgs:BaseNotificationData
    {
        public GameObject Prefab;
        public Transform Parent;
        public Vector3 Position;
        public Quaternion Rotation;
    }
}