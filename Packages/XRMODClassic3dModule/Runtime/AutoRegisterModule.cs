using System.Collections;
using System.Collections.Generic;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.Classic3D.Runtime
{
    public class AutoRegisterModule : MonoBehaviour
    {
#if CLASSIC_3D_INSTALL
        private void Awake()
        {
            RegisterModule();
        }

        private void RegisterModule()
        {
            if (!RuntimePlatformHelper.IsClassic3D()) return;
            IocContainer.GetIoc.Register<IModule>(new Classic3DModule());
        }
#endif
    }
}