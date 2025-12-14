// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System.Threading.Tasks;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler nextHandler;
      
        public IHandler SetNext(IHandler _header)
        {
            nextHandler = _header;
            return nextHandler;
        }

        public IHandler GetNext()
        {
            return nextHandler;
        }

        public virtual void Handle()
        {
            nextHandler?.Handle();
        }
    }
}