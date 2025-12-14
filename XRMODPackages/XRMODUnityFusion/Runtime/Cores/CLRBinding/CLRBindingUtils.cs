using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityFusion.Runtime.CLRBinding
{
    public class CLRBindingUtils
    {
        private static event Action<UnityFusion.Runtime.Enviorment.AppDomain> initializeAction; 
        public static void RegisterBindingAction(Action<UnityFusion.Runtime.Enviorment.AppDomain> action)
        {
            initializeAction += action;
        }

        /// <summary>
        /// This method can instead of CLRBindings.Initialize for avoid compile error when hasn't generator bindingCode.
        /// </summary>
        /// <param name="appDomain"></param>
        public static void Initialize(UnityFusion.Runtime.Enviorment.AppDomain appDomain)
        {
            if (initializeAction != null)
            {
                initializeAction(appDomain);
            }
        }

    }
}
