using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;

namespace UnityFusion.Runtime.Generated
{
    public static class CLRBindings
    {
        public static UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector3>
            s_UnityEngine_Vector3_Binding_Binder = null;

        public static UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector2>
            s_UnityEngine_Vector2_Binding_Binder = null;

        public static UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Quaternion>
            s_UnityEngine_Quaternion_Binding_Binder = null;
        
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterToAutoExecuted()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(_data =>
            {
                if (_data is UnityFusionArgs tmp_Data)
                {
                    Initializer(tmp_Data.AppDomain as Enviorment.AppDomain);
                }
            }, nameof(ActionParameterDataType.RegisterBuiltInCLR));
        }

        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initializer(Enviorment.AppDomain _app)
        {
            UnityFusion.CLR.TypeSystem.CLRType __clrType = null;
            __clrType = (UnityFusion.CLR.TypeSystem.CLRType) _app.GetType(typeof(UnityEngine.Vector3));
            s_UnityEngine_Vector3_Binding_Binder =
                __clrType.ValueTypeBinder as UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector3>;
            __clrType = (UnityFusion.CLR.TypeSystem.CLRType) _app.GetType(typeof(UnityEngine.Vector2));
            s_UnityEngine_Vector2_Binding_Binder =
                __clrType.ValueTypeBinder as UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector2>;
            __clrType = (UnityFusion.CLR.TypeSystem.CLRType) _app.GetType(typeof(UnityEngine.Quaternion));
            s_UnityEngine_Quaternion_Binding_Binder =
                __clrType.ValueTypeBinder as UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Quaternion>;
            
            UnityFusionClrBinding.Binding(_app);
            PhantomsClrBinding.Binding(_app);
            SystemClrBinding.Binding(_app);
            UnityEngineClrBinding.Binding(_app);
            UnityEngine_Pose_Binding.Register(_app);
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE UnityFusion Appdomain destroy
        /// </summary>
        public static void Shutdown(Enviorment.AppDomain _app)
        {
        }
    }
}