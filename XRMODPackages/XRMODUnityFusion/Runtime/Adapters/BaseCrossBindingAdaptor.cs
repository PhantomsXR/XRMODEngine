using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;

namespace UnityFusion.CLRBinding.Adapter
{
    /// <summary>
    /// Base interface for all cross-binding adapters in the UnityFusion system.
    /// Provides a hook for initialization when an instance is created in the hot-reload domain.
    /// </summary>
    public interface BaseCrossBindingAdaptor : CrossBindingAdaptorType
    {
        /// <summary>
        /// Hook called manually to simulate the Unity 'Awake' lifecycle method.
        /// </summary>
        void DoAwake();
    }
}
