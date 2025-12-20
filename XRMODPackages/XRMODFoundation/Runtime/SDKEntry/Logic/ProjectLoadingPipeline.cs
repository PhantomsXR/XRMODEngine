using System.Collections.Generic;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.DataRequest;
using Phantom.XRMOD.SDKEntry.Runtime.Models;

namespace Phantom.XRMOD.SDKEntry.Runtime.Logic
{
    /// <summary>
    /// Responsible for building the project loading handler pipeline.
    /// </summary>
    public class ProjectLoadingPipeline
    {
        private readonly string experienceUid;

        public ProjectLoadingPipeline(string _experienceUid)
        {
            experienceUid = _experienceUid;
        }

        public void Execute()
        {
            var tmp_GetARExperienceProjectHandler =
                new FetchXRResourcesHandler(NetworkRequestType.InfoByUId, experienceUid);
            var tmp_CacheProjectInformationHandler = new CacheProjectInformationHandler();
            var tmp_OversizeCheckHandler = new OversizeCheckHandler();
            var tmp_GetXRPackageConfigHandler = new GetXRPackageConfigHandler();
            var tmp_SdkVersionCheckHandler = new SdkVersionCheckHandler();
            var tmp_LaunchXRModuleHandler = new LaunchXRModuleHandler();
            var tmp_LoadingUIHandler = new ExpericenLoadStateHandler();
            var tmp_CreateUIEventSystemHandler = new CreateUIEventSystemHandler();

            tmp_GetARExperienceProjectHandler
                .SetNext(tmp_CacheProjectInformationHandler)
                .SetNext(tmp_OversizeCheckHandler)
                .SetNext(tmp_LoadingUIHandler)
                .SetNext(tmp_GetXRPackageConfigHandler)
                .SetNext(tmp_SdkVersionCheckHandler)
                .SetNext(tmp_LaunchXRModuleHandler)
                .SetNext(tmp_CreateUIEventSystemHandler);

            tmp_GetARExperienceProjectHandler.Handle();
        }

        public void ExecuteContinueDownload()
        {
            var tmp_GetXRPackageConfigHandler = new GetXRPackageConfigHandler();
            var tmp_SdkVersionCheckHandler = new SdkVersionCheckHandler();
            var tmp_LaunchXRModuleHandler = new LaunchXRModuleHandler();
            var tmp_LoadingUIHandler = new ExpericenLoadStateHandler();
            var tmp_CreateUIEventSystemHandler = new CreateUIEventSystemHandler();

            tmp_GetXRPackageConfigHandler
                .SetNext(tmp_SdkVersionCheckHandler)
                .SetNext(tmp_LaunchXRModuleHandler)
                .SetNext(tmp_LoadingUIHandler)
                .SetNext(tmp_CreateUIEventSystemHandler);
            tmp_GetXRPackageConfigHandler.Handle();
        }
    }
}
