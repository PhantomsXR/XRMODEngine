// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Threading.Tasks;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public interface IAutoProcessCommand
    {
        Task Execute();
        IAutoProcessCommand SetNext(IAutoProcessCommand _nextCommand);
    }
}