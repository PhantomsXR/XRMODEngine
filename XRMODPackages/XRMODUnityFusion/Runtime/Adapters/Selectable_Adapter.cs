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
    /// Adapter for Unity's <see cref="UnityEngine.UI.Selectable"/>.
    /// Enables UI interaction logic to be implemented in the hot-reload domain.
    /// </summary>
    public class SelectableAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get { return typeof(UnityEngine.UI.Selectable); }
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
        /// The implementation class that bridges Selectable messages to the hot-reload domain.
        /// </summary>
        public class Adapter : UnityEngine.UI.Selectable, CrossBindingAdaptorType
        {
            CrossBindingMethodInfo mAwake_0 = new CrossBindingMethodInfo("Awake");
            CrossBindingMethodInfo mOnCanvasGroupChanged_1 = new CrossBindingMethodInfo("OnCanvasGroupChanged");

            CrossBindingFunctionInfo<System.Boolean> mIsInteractable_2 =
                new CrossBindingFunctionInfo<System.Boolean>("IsInteractable");

            CrossBindingMethodInfo mOnDidApplyAnimationProperties_3 =
                new CrossBindingMethodInfo("OnDidApplyAnimationProperties");

            CrossBindingMethodInfo mOnEnable_4 = new CrossBindingMethodInfo("OnEnable");
            CrossBindingMethodInfo mOnTransformParentChanged_5 = new CrossBindingMethodInfo("OnTransformParentChanged");
            CrossBindingMethodInfo mOnDisable_6 = new CrossBindingMethodInfo("OnDisable");
            CrossBindingMethodInfo mOnValidate_7 = new CrossBindingMethodInfo("OnValidate");
            CrossBindingMethodInfo mReset_8 = new CrossBindingMethodInfo("Reset");
            CrossBindingMethodInfo mInstantClearState_9 = new CrossBindingMethodInfo("InstantClearState");

            CrossBindingFunctionInfo<UnityEngine.UI.Selectable> mFindSelectableOnLeft_10 =
                new CrossBindingFunctionInfo<UnityEngine.UI.Selectable>("FindSelectableOnLeft");

            CrossBindingFunctionInfo<UnityEngine.UI.Selectable> mFindSelectableOnRight_11 =
                new CrossBindingFunctionInfo<UnityEngine.UI.Selectable>("FindSelectableOnRight");

            CrossBindingFunctionInfo<UnityEngine.UI.Selectable> mFindSelectableOnUp_12 =
                new CrossBindingFunctionInfo<UnityEngine.UI.Selectable>("FindSelectableOnUp");

            CrossBindingFunctionInfo<UnityEngine.UI.Selectable> mFindSelectableOnDown_13 =
                new CrossBindingFunctionInfo<UnityEngine.UI.Selectable>("FindSelectableOnDown");

            CrossBindingMethodInfo<UnityEngine.EventSystems.AxisEventData> mOnMove_14 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.AxisEventData>("OnMove");

            CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData> mOnPointerDown_15 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData>("OnPointerDown");

            CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData> mOnPointerUp_16 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData>("OnPointerUp");

            CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData> mOnPointerEnter_17 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData>("OnPointerEnter");

            CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData> mOnPointerExit_18 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData>("OnPointerExit");

            CrossBindingMethodInfo<UnityEngine.EventSystems.BaseEventData> mOnSelect_19 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.BaseEventData>("OnSelect");

            CrossBindingMethodInfo<UnityEngine.EventSystems.BaseEventData> mOnDeselect_20 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.BaseEventData>("OnDeselect");

            CrossBindingMethodInfo mSelect_21 = new CrossBindingMethodInfo("Select");
            CrossBindingMethodInfo mStart_22 = new CrossBindingMethodInfo("Start");
            CrossBindingMethodInfo mOnDestroy_23 = new CrossBindingMethodInfo("OnDestroy");

            CrossBindingFunctionInfo<System.Boolean> mIsActive_24 =
                new CrossBindingFunctionInfo<System.Boolean>("IsActive");

            CrossBindingMethodInfo mOnRectTransformDimensionsChange_25 =
                new CrossBindingMethodInfo("OnRectTransformDimensionsChange");

            CrossBindingMethodInfo mOnBeforeTransformParentChanged_26 =
                new CrossBindingMethodInfo("OnBeforeTransformParentChanged");

            CrossBindingMethodInfo mOnCanvasHierarchyChanged_27 =
                new CrossBindingMethodInfo("OnCanvasHierarchyChanged");

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

            protected override void Awake()
            {
                if (mAwake_0.CheckShouldInvokeBase(this.instance))
                    base.Awake();
                else
                    mAwake_0.Invoke(this.instance);
            }

            protected override void OnCanvasGroupChanged()
            {
                if (mOnCanvasGroupChanged_1.CheckShouldInvokeBase(this.instance))
                    base.OnCanvasGroupChanged();
                else
                    mOnCanvasGroupChanged_1.Invoke(this.instance);
            }

            public override System.Boolean IsInteractable()
            {
                if (mIsInteractable_2.CheckShouldInvokeBase(this.instance))
                    return base.IsInteractable();
                else
                    return mIsInteractable_2.Invoke(this.instance);
            }

            protected override void OnDidApplyAnimationProperties()
            {
                if (mOnDidApplyAnimationProperties_3.CheckShouldInvokeBase(this.instance))
                    base.OnDidApplyAnimationProperties();
                else
                    mOnDidApplyAnimationProperties_3.Invoke(this.instance);
            }

            protected override void OnEnable()
            {
                if (mOnEnable_4.CheckShouldInvokeBase(this.instance))
                    base.OnEnable();
                else
                    mOnEnable_4.Invoke(this.instance);
            }

            protected override void OnTransformParentChanged()
            {
                if (mOnTransformParentChanged_5.CheckShouldInvokeBase(this.instance))
                    base.OnTransformParentChanged();
                else
                    mOnTransformParentChanged_5.Invoke(this.instance);
            }

            protected override void OnDisable()
            {
                if (mOnDisable_6.CheckShouldInvokeBase(this.instance))
                    base.OnDisable();
                else
                    mOnDisable_6.Invoke(this.instance);
            }
#if UNITY_EDITOR
            protected override void OnValidate()
            {
                if (mOnValidate_7.CheckShouldInvokeBase(this.instance))
                    base.OnValidate();
                else
                    mOnValidate_7.Invoke(this.instance);
            }

            protected override void Reset()
            {
                if (mReset_8.CheckShouldInvokeBase(this.instance))
                    base.Reset();
                else
                    mReset_8.Invoke(this.instance);
            }
#endif

            protected override void InstantClearState()
            {
                if (mInstantClearState_9.CheckShouldInvokeBase(this.instance))
                    base.InstantClearState();
                else
                    mInstantClearState_9.Invoke(this.instance);
            }

            public override UnityEngine.UI.Selectable FindSelectableOnLeft()
            {
                if (mFindSelectableOnLeft_10.CheckShouldInvokeBase(this.instance))
                    return base.FindSelectableOnLeft();
                else
                    return mFindSelectableOnLeft_10.Invoke(this.instance);
            }

            public override UnityEngine.UI.Selectable FindSelectableOnRight()
            {
                if (mFindSelectableOnRight_11.CheckShouldInvokeBase(this.instance))
                    return base.FindSelectableOnRight();
                else
                    return mFindSelectableOnRight_11.Invoke(this.instance);
            }

            public override UnityEngine.UI.Selectable FindSelectableOnUp()
            {
                if (mFindSelectableOnUp_12.CheckShouldInvokeBase(this.instance))
                    return base.FindSelectableOnUp();
                else
                    return mFindSelectableOnUp_12.Invoke(this.instance);
            }

            public override UnityEngine.UI.Selectable FindSelectableOnDown()
            {
                if (mFindSelectableOnDown_13.CheckShouldInvokeBase(this.instance))
                    return base.FindSelectableOnDown();
                else
                    return mFindSelectableOnDown_13.Invoke(this.instance);
            }

            public override void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
            {
                if (mOnMove_14.CheckShouldInvokeBase(this.instance))
                    base.OnMove(eventData);
                else
                    mOnMove_14.Invoke(this.instance, eventData);
            }

            public override void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
            {
                if (mOnPointerDown_15.CheckShouldInvokeBase(this.instance))
                    base.OnPointerDown(eventData);
                else
                    mOnPointerDown_15.Invoke(this.instance, eventData);
            }

            public override void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
            {
                if (mOnPointerUp_16.CheckShouldInvokeBase(this.instance))
                    base.OnPointerUp(eventData);
                else
                    mOnPointerUp_16.Invoke(this.instance, eventData);
            }

            public override void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
            {
                if (mOnPointerEnter_17.CheckShouldInvokeBase(this.instance))
                    base.OnPointerEnter(eventData);
                else
                    mOnPointerEnter_17.Invoke(this.instance, eventData);
            }

            public override void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
            {
                if (mOnPointerExit_18.CheckShouldInvokeBase(this.instance))
                    base.OnPointerExit(eventData);
                else
                    mOnPointerExit_18.Invoke(this.instance, eventData);
            }

            public override void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
            {
                if (mOnSelect_19.CheckShouldInvokeBase(this.instance))
                    base.OnSelect(eventData);
                else
                    mOnSelect_19.Invoke(this.instance, eventData);
            }

            public override void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
            {
                if (mOnDeselect_20.CheckShouldInvokeBase(this.instance))
                    base.OnDeselect(eventData);
                else
                    mOnDeselect_20.Invoke(this.instance, eventData);
            }

            public override void Select()
            {
                if (mSelect_21.CheckShouldInvokeBase(this.instance))
                    base.Select();
                else
                    mSelect_21.Invoke(this.instance);
            }

            protected override void Start()
            {
                if (mStart_22.CheckShouldInvokeBase(this.instance))
                    base.Start();
                else
                    mStart_22.Invoke(this.instance);
            }

            protected override void OnDestroy()
            {
                if (mOnDestroy_23.CheckShouldInvokeBase(this.instance))
                    base.OnDestroy();
                else
                    mOnDestroy_23.Invoke(this.instance);
            }

            public override System.Boolean IsActive()
            {
                if (mIsActive_24.CheckShouldInvokeBase(this.instance))
                    return base.IsActive();
                else
                    return mIsActive_24.Invoke(this.instance);
            }

            protected override void OnRectTransformDimensionsChange()
            {
                if (mOnRectTransformDimensionsChange_25.CheckShouldInvokeBase(this.instance))
                    base.OnRectTransformDimensionsChange();
                else
                    mOnRectTransformDimensionsChange_25.Invoke(this.instance);
            }

            protected override void OnBeforeTransformParentChanged()
            {
                if (mOnBeforeTransformParentChanged_26.CheckShouldInvokeBase(this.instance))
                    base.OnBeforeTransformParentChanged();
                else
                    mOnBeforeTransformParentChanged_26.Invoke(this.instance);
            }

            protected override void OnCanvasHierarchyChanged()
            {
                if (mOnCanvasHierarchyChanged_27.CheckShouldInvokeBase(this.instance))
                    base.OnCanvasHierarchyChanged();
                else
                    mOnCanvasHierarchyChanged_27.Invoke(this.instance);
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