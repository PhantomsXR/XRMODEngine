using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;

namespace UnityFusion.CLRBinding.Adapter
{
    public interface BaseCrossBindingAdaptor : CrossBindingAdaptorType
    {
        void DoAwake();
    }
}
