using System;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace UnityFusion.CLRBinding.Adapter
{
    /// <summary>
    /// Adapter for Unity's <see cref="UnityEngine.UI.MaskableGraphic"/>.
    /// Allows UI components in the hot-reload domain to inherit from MaskableGraphic.
    /// </summary>
    public class MaskableGraphicAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get { return typeof(UnityEngine.UI.MaskableGraphic); }
        }

        public override Type AdaptorType
        {
            get { return typeof(Adapter); }
        }

        public override object CreateCLRInstance(UnityFusion.Runtime.Enviorment.AppDomain appdomain,
            ILTypeInstance instance)
        {
            return new Adapter(appdomain, instance);
        }

        /// <summary>
        /// The implementation class that bridges MaskableGraphic messages to the hot-reload domain.
        /// </summary>
        public class Adapter : UnityEngine.UI.MaskableGraphic, CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<UnityEngine.Material, UnityEngine.Material> mGetModifiedMaterial_0 =
                new CrossBindingFunctionInfo<UnityEngine.Material, UnityEngine.Material>("GetModifiedMaterial");

            CrossBindingMethodInfo<UnityEngine.Rect, System.Boolean> mCull_1 =
                new CrossBindingMethodInfo<UnityEngine.Rect, System.Boolean>("Cull");

            CrossBindingMethodInfo<UnityEngine.Rect, System.Boolean> mSetClipRect_2 =
                new CrossBindingMethodInfo<UnityEngine.Rect, System.Boolean>("SetClipRect");

            CrossBindingMethodInfo<UnityEngine.Vector2> mSetClipSoftness_3 =
                new CrossBindingMethodInfo<UnityEngine.Vector2>("SetClipSoftness");

            CrossBindingMethodInfo mOnEnable_4 = new CrossBindingMethodInfo("OnEnable");
            CrossBindingMethodInfo mOnDisable_5 = new CrossBindingMethodInfo("OnDisable");
            CrossBindingMethodInfo mOnValidate_6 = new CrossBindingMethodInfo("OnValidate");
            CrossBindingMethodInfo mOnTransformParentChanged_7 = new CrossBindingMethodInfo("OnTransformParentChanged");
            CrossBindingMethodInfo mOnCanvasHierarchyChanged_8 = new CrossBindingMethodInfo("OnCanvasHierarchyChanged");
            CrossBindingMethodInfo mRecalculateClipping_9 = new CrossBindingMethodInfo("RecalculateClipping");
            CrossBindingMethodInfo mRecalculateMasking_10 = new CrossBindingMethodInfo("RecalculateMasking");

            CrossBindingFunctionInfo<UnityEngine.Color> mget_color_11 =
                new CrossBindingFunctionInfo<UnityEngine.Color>("get_color");

            CrossBindingMethodInfo<UnityEngine.Color> mset_color_12 =
                new CrossBindingMethodInfo<UnityEngine.Color>("set_color");

            CrossBindingFunctionInfo<System.Boolean> mget_raycastTarget_13 =
                new CrossBindingFunctionInfo<System.Boolean>("get_raycastTarget");

            CrossBindingMethodInfo<System.Boolean> mset_raycastTarget_14 =
                new CrossBindingMethodInfo<System.Boolean>("set_raycastTarget");

            CrossBindingMethodInfo mSetAllDirty_15 = new CrossBindingMethodInfo("SetAllDirty");
            CrossBindingMethodInfo mSetLayoutDirty_16 = new CrossBindingMethodInfo("SetLayoutDirty");
            CrossBindingMethodInfo mSetVerticesDirty_17 = new CrossBindingMethodInfo("SetVerticesDirty");
            CrossBindingMethodInfo mSetMaterialDirty_18 = new CrossBindingMethodInfo("SetMaterialDirty");

            CrossBindingMethodInfo mOnRectTransformDimensionsChange_19 =
                new CrossBindingMethodInfo("OnRectTransformDimensionsChange");

            CrossBindingMethodInfo mOnBeforeTransformParentChanged_20 =
                new CrossBindingMethodInfo("OnBeforeTransformParentChanged");

            CrossBindingFunctionInfo<UnityEngine.Material> mget_defaultMaterial_21 =
                new CrossBindingFunctionInfo<UnityEngine.Material>("get_defaultMaterial");

            CrossBindingFunctionInfo<UnityEngine.Material> mget_material_22 =
                new CrossBindingFunctionInfo<UnityEngine.Material>("get_material");

            CrossBindingMethodInfo<UnityEngine.Material> mset_material_23 =
                new CrossBindingMethodInfo<UnityEngine.Material>("set_material");

            CrossBindingFunctionInfo<UnityEngine.Material> mget_materialForRendering_24 =
                new CrossBindingFunctionInfo<UnityEngine.Material>("get_materialForRendering");

            CrossBindingFunctionInfo<UnityEngine.Texture> mget_mainTexture_25 =
                new CrossBindingFunctionInfo<UnityEngine.Texture>("get_mainTexture");

            CrossBindingMethodInfo mOnDestroy_26 = new CrossBindingMethodInfo("OnDestroy");
            CrossBindingMethodInfo mOnCullingChanged_27 = new CrossBindingMethodInfo("OnCullingChanged");

            CrossBindingMethodInfo<UnityEngine.UI.CanvasUpdate> mRebuild_28 =
                new CrossBindingMethodInfo<UnityEngine.UI.CanvasUpdate>("Rebuild");

            CrossBindingMethodInfo mLayoutComplete_29 = new CrossBindingMethodInfo("LayoutComplete");
            CrossBindingMethodInfo mGraphicUpdateComplete_30 = new CrossBindingMethodInfo("GraphicUpdateComplete");
            CrossBindingMethodInfo mUpdateMaterial_31 = new CrossBindingMethodInfo("UpdateMaterial");
            CrossBindingMethodInfo mUpdateGeometry_32 = new CrossBindingMethodInfo("UpdateGeometry");

            CrossBindingMethodInfo<UnityEngine.UI.VertexHelper> mOnPopulateMesh_33 =
                new CrossBindingMethodInfo<UnityEngine.UI.VertexHelper>("OnPopulateMesh");

            CrossBindingMethodInfo mOnRebuildRequested_34 = new CrossBindingMethodInfo("OnRebuildRequested");
            CrossBindingMethodInfo mReset_35 = new CrossBindingMethodInfo("Reset");

            CrossBindingMethodInfo mOnDidApplyAnimationProperties_36 =
                new CrossBindingMethodInfo("OnDidApplyAnimationProperties");

            CrossBindingMethodInfo mSetNativeSize_37 = new CrossBindingMethodInfo("SetNativeSize");

            CrossBindingFunctionInfo<UnityEngine.Vector2, UnityEngine.Camera, System.Boolean> mRaycast_38 =
                new CrossBindingFunctionInfo<UnityEngine.Vector2, UnityEngine.Camera, System.Boolean>("Raycast");

            CrossBindingMethodInfo<UnityEngine.Color, System.Single, System.Boolean, System.Boolean>
                mCrossFadeColor_39 =
                    new CrossBindingMethodInfo<UnityEngine.Color, System.Single, System.Boolean, System.Boolean>(
                        "CrossFadeColor");

            CrossBindingMethodInfo<UnityEngine.Color, System.Single, System.Boolean, System.Boolean, System.Boolean>
                mCrossFadeColor_40 =
                    new CrossBindingMethodInfo<UnityEngine.Color, System.Single, System.Boolean, System.Boolean,
                        System.Boolean>("CrossFadeColor");

            CrossBindingMethodInfo<System.Single, System.Single, System.Boolean> mCrossFadeAlpha_41 =
                new CrossBindingMethodInfo<System.Single, System.Single, System.Boolean>("CrossFadeAlpha");

            CrossBindingMethodInfo mAwake_42 = new CrossBindingMethodInfo("Awake");
            CrossBindingMethodInfo mStart_43 = new CrossBindingMethodInfo("Start");

            CrossBindingFunctionInfo<System.Boolean> mIsActive_44 =
                new CrossBindingFunctionInfo<System.Boolean>("IsActive");

            CrossBindingMethodInfo mOnCanvasGroupChanged_45 = new CrossBindingMethodInfo("OnCanvasGroupChanged");

            CrossBindingFunctionInfo<UnityEngine.GameObject> mget_gameObject_46 =
                new CrossBindingFunctionInfo<UnityEngine.GameObject>("get_gameObject");

            CrossBindingFunctionInfo<UnityEngine.Transform> mget_transform_47 =
                new CrossBindingFunctionInfo<UnityEngine.Transform>("get_transform");

            bool isInvokingToString;
            ILTypeInstance instance;
            UnityFusion.Runtime.Enviorment.AppDomain appdomain;

            public Adapter()
            {
            }

            public Adapter(UnityFusion.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
            {
                this.appdomain = appdomain;
                this.instance = instance;
            }

            public ILTypeInstance ILInstance
            {
                get { return instance; }
            }

            public override UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
            {
                if (mGetModifiedMaterial_0.CheckShouldInvokeBase(this.instance))
                    return base.GetModifiedMaterial(baseMaterial);
                else
                    return mGetModifiedMaterial_0.Invoke(this.instance, baseMaterial);
            }

            public override void Cull(UnityEngine.Rect clipRect, System.Boolean validRect)
            {
                if (mCull_1.CheckShouldInvokeBase(this.instance))
                    base.Cull(clipRect, validRect);
                else
                    mCull_1.Invoke(this.instance, clipRect, validRect);
            }

            public override void SetClipRect(UnityEngine.Rect clipRect, System.Boolean validRect)
            {
                if (mSetClipRect_2.CheckShouldInvokeBase(this.instance))
                    base.SetClipRect(clipRect, validRect);
                else
                    mSetClipRect_2.Invoke(this.instance, clipRect, validRect);
            }

            public override void SetClipSoftness(UnityEngine.Vector2 clipSoftness)
            {
                if (mSetClipSoftness_3.CheckShouldInvokeBase(this.instance))
                    base.SetClipSoftness(clipSoftness);
                else
                    mSetClipSoftness_3.Invoke(this.instance, clipSoftness);
            }

            protected override void OnEnable()
            {
                if (mOnEnable_4.CheckShouldInvokeBase(this.instance))
                    base.OnEnable();
                else
                    mOnEnable_4.Invoke(this.instance);
            }

            protected override void OnDisable()
            {
                if (mOnDisable_5.CheckShouldInvokeBase(this.instance))
                    base.OnDisable();
                else
                    mOnDisable_5.Invoke(this.instance);
            }
#if UNITY_EDITOR

            protected override void Reset()
            {
                if (mReset_35.CheckShouldInvokeBase(this.instance))
                    base.Reset();
                else
                    mReset_35.Invoke(this.instance);
            }

            protected override void OnValidate()
            {
                if (mOnValidate_6.CheckShouldInvokeBase(this.instance))
                    base.OnValidate();
                else
                    mOnValidate_6.Invoke(this.instance);
            }

            public override void OnRebuildRequested()
            {
                if (mOnRebuildRequested_34.CheckShouldInvokeBase(this.instance))
                    base.OnRebuildRequested();
                else
                    mOnRebuildRequested_34.Invoke(this.instance);
            }
#endif
            protected override void OnTransformParentChanged()
            {
                if (mOnTransformParentChanged_7.CheckShouldInvokeBase(this.instance))
                    base.OnTransformParentChanged();
                else
                    mOnTransformParentChanged_7.Invoke(this.instance);
            }

            protected override void OnCanvasHierarchyChanged()
            {
                if (mOnCanvasHierarchyChanged_8.CheckShouldInvokeBase(this.instance))
                    base.OnCanvasHierarchyChanged();
                else
                    mOnCanvasHierarchyChanged_8.Invoke(this.instance);
            }

            public override void RecalculateClipping()
            {
                if (mRecalculateClipping_9.CheckShouldInvokeBase(this.instance))
                    base.RecalculateClipping();
                else
                    mRecalculateClipping_9.Invoke(this.instance);
            }

            public override void RecalculateMasking()
            {
                if (mRecalculateMasking_10.CheckShouldInvokeBase(this.instance))
                    base.RecalculateMasking();
                else
                    mRecalculateMasking_10.Invoke(this.instance);
            }

            public override void SetAllDirty()
            {
                if (mSetAllDirty_15.CheckShouldInvokeBase(this.instance))
                    base.SetAllDirty();
                else
                    mSetAllDirty_15.Invoke(this.instance);
            }

            public override void SetLayoutDirty()
            {
                if (mSetLayoutDirty_16.CheckShouldInvokeBase(this.instance))
                    base.SetLayoutDirty();
                else
                    mSetLayoutDirty_16.Invoke(this.instance);
            }

            public override void SetVerticesDirty()
            {
                if (mSetVerticesDirty_17.CheckShouldInvokeBase(this.instance))
                    base.SetVerticesDirty();
                else
                    mSetVerticesDirty_17.Invoke(this.instance);
            }

            public override void SetMaterialDirty()
            {
                if (mSetMaterialDirty_18.CheckShouldInvokeBase(this.instance))
                    base.SetMaterialDirty();
                else
                    mSetMaterialDirty_18.Invoke(this.instance);
            }

            protected override void OnRectTransformDimensionsChange()
            {
                if (mOnRectTransformDimensionsChange_19.CheckShouldInvokeBase(this.instance))
                    base.OnRectTransformDimensionsChange();
                else
                    mOnRectTransformDimensionsChange_19.Invoke(this.instance);
            }

            protected override void OnBeforeTransformParentChanged()
            {
                if (mOnBeforeTransformParentChanged_20.CheckShouldInvokeBase(this.instance))
                    base.OnBeforeTransformParentChanged();
                else
                    mOnBeforeTransformParentChanged_20.Invoke(this.instance);
            }

            protected override void OnDestroy()
            {
                if (mOnDestroy_26.CheckShouldInvokeBase(this.instance))
                    base.OnDestroy();
                else
                    mOnDestroy_26.Invoke(this.instance);
            }

            public override void OnCullingChanged()
            {
                if (mOnCullingChanged_27.CheckShouldInvokeBase(this.instance))
                    base.OnCullingChanged();
                else
                    mOnCullingChanged_27.Invoke(this.instance);
            }

            public override void Rebuild(UnityEngine.UI.CanvasUpdate update)
            {
                if (mRebuild_28.CheckShouldInvokeBase(this.instance))
                    base.Rebuild(update);
                else
                    mRebuild_28.Invoke(this.instance, update);
            }

            public override void LayoutComplete()
            {
                if (mLayoutComplete_29.CheckShouldInvokeBase(this.instance))
                    base.LayoutComplete();
                else
                    mLayoutComplete_29.Invoke(this.instance);
            }

            public override void GraphicUpdateComplete()
            {
                if (mGraphicUpdateComplete_30.CheckShouldInvokeBase(this.instance))
                    base.GraphicUpdateComplete();
                else
                    mGraphicUpdateComplete_30.Invoke(this.instance);
            }

            protected override void UpdateMaterial()
            {
                if (mUpdateMaterial_31.CheckShouldInvokeBase(this.instance))
                    base.UpdateMaterial();
                else
                    mUpdateMaterial_31.Invoke(this.instance);
            }

            protected override void UpdateGeometry()
            {
                if (mUpdateGeometry_32.CheckShouldInvokeBase(this.instance))
                    base.UpdateGeometry();
                else
                    mUpdateGeometry_32.Invoke(this.instance);
            }

            protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
            {
                if (mOnPopulateMesh_33.CheckShouldInvokeBase(this.instance))
                    base.OnPopulateMesh(vh);
                else
                    mOnPopulateMesh_33.Invoke(this.instance, vh);
            }

            protected override void OnDidApplyAnimationProperties()
            {
                if (mOnDidApplyAnimationProperties_36.CheckShouldInvokeBase(this.instance))
                    base.OnDidApplyAnimationProperties();
                else
                    mOnDidApplyAnimationProperties_36.Invoke(this.instance);
            }

            public override void SetNativeSize()
            {
                if (mSetNativeSize_37.CheckShouldInvokeBase(this.instance))
                    base.SetNativeSize();
                else
                    mSetNativeSize_37.Invoke(this.instance);
            }

            public override System.Boolean Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
            {
                if (mRaycast_38.CheckShouldInvokeBase(this.instance))
                    return base.Raycast(sp, eventCamera);
                else
                    return mRaycast_38.Invoke(this.instance, sp, eventCamera);
            }

            public override void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration,
                System.Boolean ignoreTimeScale, System.Boolean useAlpha)
            {
                if (mCrossFadeColor_39.CheckShouldInvokeBase(this.instance))
                    base.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
                else
                    mCrossFadeColor_39.Invoke(this.instance, targetColor, duration, ignoreTimeScale, useAlpha);
            }

            public override void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration,
                System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB)
            {
                if (mCrossFadeColor_40.CheckShouldInvokeBase(this.instance))
                    base.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
                else
                    mCrossFadeColor_40.Invoke(this.instance, targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
            }

            public override void CrossFadeAlpha(System.Single alpha, System.Single duration,
                System.Boolean ignoreTimeScale)
            {
                if (mCrossFadeAlpha_41.CheckShouldInvokeBase(this.instance))
                    base.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
                else
                    mCrossFadeAlpha_41.Invoke(this.instance, alpha, duration, ignoreTimeScale);
            }

            protected override void Awake()
            {
                if (mAwake_42.CheckShouldInvokeBase(this.instance))
                    base.Awake();
                else
                    mAwake_42.Invoke(this.instance);
            }

            protected override void Start()
            {
                if (mStart_43.CheckShouldInvokeBase(this.instance))
                    base.Start();
                else
                    mStart_43.Invoke(this.instance);
            }

            public override System.Boolean IsActive()
            {
                if (mIsActive_44.CheckShouldInvokeBase(this.instance))
                    return base.IsActive();
                else
                    return mIsActive_44.Invoke(this.instance);
            }

            protected override void OnCanvasGroupChanged()
            {
                if (mOnCanvasGroupChanged_45.CheckShouldInvokeBase(this.instance))
                    base.OnCanvasGroupChanged();
                else
                    mOnCanvasGroupChanged_45.Invoke(this.instance);
            }

            public override UnityEngine.Color color
            {
                get
                {
                    if (mget_color_11.CheckShouldInvokeBase(this.instance))
                        return base.color;
                    else
                        return mget_color_11.Invoke(this.instance);
                }
                set
                {
                    if (mset_color_12.CheckShouldInvokeBase(this.instance))
                        base.color = value;
                    else
                        mset_color_12.Invoke(this.instance, value);
                }
            }

            public override System.Boolean raycastTarget
            {
                get
                {
                    if (mget_raycastTarget_13.CheckShouldInvokeBase(this.instance))
                        return base.raycastTarget;
                    else
                        return mget_raycastTarget_13.Invoke(this.instance);
                }
                set
                {
                    if (mset_raycastTarget_14.CheckShouldInvokeBase(this.instance))
                        base.raycastTarget = value;
                    else
                        mset_raycastTarget_14.Invoke(this.instance, value);
                }
            }

            public override UnityEngine.Material defaultMaterial
            {
                get
                {
                    if (mget_defaultMaterial_21.CheckShouldInvokeBase(this.instance))
                        return base.defaultMaterial;
                    else
                        return mget_defaultMaterial_21.Invoke(this.instance);
                }
            }

            public override UnityEngine.Material material
            {
                get
                {
                    if (mget_material_22.CheckShouldInvokeBase(this.instance))
                        return base.material;
                    else
                        return mget_material_22.Invoke(this.instance);
                }
                set
                {
                    if (mset_material_23.CheckShouldInvokeBase(this.instance))
                        base.material = value;
                    else
                        mset_material_23.Invoke(this.instance, value);
                }
            }

            public override UnityEngine.Material materialForRendering
            {
                get
                {
                    if (mget_materialForRendering_24.CheckShouldInvokeBase(this.instance))
                        return base.materialForRendering;
                    else
                        return mget_materialForRendering_24.Invoke(this.instance);
                }
            }

            public override UnityEngine.Texture mainTexture
            {
                get
                {
                    if (mget_mainTexture_25.CheckShouldInvokeBase(this.instance))
                        return base.mainTexture;
                    else
                        return mget_mainTexture_25.Invoke(this.instance);
                }
            }

            public UnityEngine.GameObject gameObject
            {
                get { return mget_gameObject_46.Invoke(this.instance); }
            }

            public UnityEngine.Transform transform
            {
                get { return mget_transform_47.Invoke(this.instance); }
            }

            public override string ToString()
            {
                IMethod m = appdomain.ObjectType.GetMethod("ToString", 0);
                m = instance.Type.GetVirtualMethod(m);
                if (m == null || m is ILMethod)
                {
                    if (!isInvokingToString)
                    {
                        isInvokingToString = true;
                        string res = instance.ToString();
                        isInvokingToString = false;
                        return res;
                    }
                    else
                        return instance.Type.FullName;
                }
                else
                    return instance.Type.FullName;
            }
        }
    }
}