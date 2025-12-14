using System;
using System.Collections.Generic;
using System.Reflection;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif
namespace UnityFusion.Runtime.Generated
{
    class CLRBindings
    {

//will auto register in unity
#if UNITY_5_3_OR_NEWER
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
#endif
        static private void RegisterBindingAction()
        {
            UnityFusion.Runtime.CLRBinding.CLRBindingUtils.RegisterBindingAction(Initialize);
        }
        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            UnityEngine_Splines_BezierCurve_Binding.Register(app);
            UnityEngine_Splines_BezierKnot_Binding.Register(app);
            UnityEngine_Splines_TangentMode_Binding.Register(app);
            UnityEngine_Splines_BezierTangent_Binding.Register(app);
            UnityEngine_Splines_CurveUtility_Binding.Register(app);
            UnityEngine_Splines_IDataPoint_Binding.Register(app);
            UnityEngine_Splines_EmbeddedSplineData_Binding.Register(app);
            UnityEngine_Splines_EmbeddedSplineDataType_Binding.Register(app);
            UnityEngine_Splines_InterpolatorUtility_Binding.Register(app);
            UnityEngine_Splines_DistanceToInterpolation_Binding.Register(app);
            UnityEngine_Splines_IHasEmptyCurves_Binding.Register(app);
            UnityEngine_Splines_ISpline_Binding.Register(app);
            UnityEngine_Splines_ISplineContainer_Binding.Register(app);
            UnityEngine_Splines_KnotLinkCollection_Binding.Register(app);
            UnityEngine_Splines_NativeSpline_Binding.Register(app);
            UnityEngine_Splines_SplineIndexAttribute_Binding.Register(app);
            UnityEngine_Splines_EmbeddedSplineDataField_Binding.Register(app);
            UnityEngine_Splines_EmbeddedSplineDataFieldsAttribute_Binding.Register(app);
            UnityEngine_Splines_Spline_Binding.Register(app);
            UnityEngine_Splines_SplineAnimate_Binding.Register(app);
            UnityEngine_Splines_SplineComponent_Binding.Register(app);
            UnityEngine_Splines_SplineContainer_Binding.Register(app);
            UnityEngine_Splines_PathIndexUnit_Binding.Register(app);
            UnityEngine_Splines_SplineExtrude_Binding.Register(app);
            UnityEngine_Splines_SplineFactory_Binding.Register(app);
            UnityEngine_Splines_SplineInfo_Binding.Register(app);
            UnityEngine_Splines_SplineInstantiate_Binding.Register(app);
            UnityEngine_Splines_GetPosition_Binding.Register(app);
            UnityEngine_Splines_GetPositionTangentNormal_Binding.Register(app);
            UnityEngine_Splines_SplineJobs_Binding.Register(app);
            UnityEngine_Splines_SplineKnotIndex_Binding.Register(app);
            UnityEngine_Splines_SplineMath_Binding.Register(app);
            UnityEngine_Splines_SplineMesh_Binding.Register(app);
            UnityEngine_Splines_SplineModification_Binding.Register(app);
            UnityEngine_Splines_SplinePath_Binding.Register(app);
            UnityEngine_Splines_SliceDirection_Binding.Register(app);
            UnityEngine_Splines_SplineRange_Binding.Register(app);
            UnityEngine_Splines_SplineUtility_Binding.Register(app);
            UnityEngine_Splines_Interpolators_LerpFloat_Binding.Register(app);
            UnityEngine_Splines_Interpolators_LerpFloat2_Binding.Register(app);
            UnityEngine_Splines_Interpolators_LerpFloat3_Binding.Register(app);
            UnityEngine_Splines_Interpolators_LerpFloat4_Binding.Register(app);
            UnityEngine_Splines_Interpolators_SlerpFloat2_Binding.Register(app);
            UnityEngine_Splines_Interpolators_SlerpFloat3_Binding.Register(app);
            UnityEngine_Splines_Interpolators_LerpQuaternion_Binding.Register(app);
            UnityEngine_Splines_Interpolators_LerpColor_Binding.Register(app);
            UnityEngine_Splines_Interpolators_SmoothStepFloat_Binding.Register(app);
            UnityEngine_Splines_Interpolators_SmoothStepFloat2_Binding.Register(app);
            UnityEngine_Splines_Interpolators_SmoothStepFloat3_Binding.Register(app);
            UnityEngine_Splines_Interpolators_SmoothStepFloat4_Binding.Register(app);
            UnityEngine_Splines_Interpolators_SlerpQuaternion_Binding.Register(app);
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE UnityFusion Appdomain destroy
        /// </summary>
        public static void Shutdown(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}
