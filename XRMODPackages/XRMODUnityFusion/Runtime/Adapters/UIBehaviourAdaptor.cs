// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the UnityFusion.Adapter.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using JetBrains.Annotations;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityEngine.EventSystems;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;

namespace UnityFusion.CLRBinding.Adapter
{
    /// <summary>
    /// Adapter for the custom <see cref="UIMonoBehaviour"/>.
    /// Handles specialized UI lifecycle and event systems for hot-reload UI components.
    /// </summary>
    public class UIBehaviourAdaptor : CrossBindingAdaptor
    {
        public override Type BaseCLRType => typeof(UIMonoBehaviour);


        public override Type AdaptorType => typeof(Adapter);


        public override object CreateCLRInstance(AppDomain _appdomain, ILTypeInstance _instance)
        {
            return new Adapter(_appdomain, _instance);
        }

        /// <summary>
        /// The implementation class that bridges UIBehaviour messages and input events to the hot-reload domain.
        /// </summary>
        public class Adapter : UIMonoBehaviour,CrossBindingAdaptorType, IDragHandler, IBeginDragHandler,
            IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerClickHandler,
            IPointerExitHandler, IPointerMoveHandler
        {
            CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData> mOnDrag_0 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData>("OnDrag");

            CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData> mOnBeginDrag_1 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData>("OnBeginDrag");

            CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData> mOnEndDrag_2 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData>("OnEndDrag");

            CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData> mOnPointerDown_3 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData>("OnPointerDown");

            CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData> mOnPointerUp_4 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData>("OnPointerUp");

            CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData> mOnPointerEnter_5 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData>("OnPointerEnter");

            CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData> mOnPointerClick_6 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData>("OnPointerClick");

            CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData> mOnPointerExit_7 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData>("OnPointerExit");

            CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData> mOnPointerMove_8 =
                new CrossBindingMethodInfo<UnityEngine.EventSystems.PointerEventData>("OnPointerMove");


            protected ILTypeInstance instance;
            protected AppDomain appdomain;

            public Adapter(AppDomain _appdomain, ILTypeInstance _instance)
            {
                this.appdomain = _appdomain;
                this.instance = _instance;
            }

            public ILTypeInstance ILInstance
            {
                get => instance;
                set => instance = value;
            }

            public UnityFusion.Runtime.Enviorment.AppDomain AppDomain
            {
                get => appdomain;
                set => appdomain = value;
            }

            public Adapter()
            {
            }


            public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
            {
                mOnDrag_0.Invoke(this.instance, eventData);
            }

            public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
            {
                mOnBeginDrag_1.Invoke(this.instance, eventData);
            }

            public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
            {
                mOnEndDrag_2.Invoke(this.instance, eventData);
            }

            public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
            {
                mOnPointerDown_3.Invoke(this.instance, eventData);
            }

            public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
            {
                mOnPointerUp_4.Invoke(this.instance, eventData);
            }

            public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
            {
                mOnPointerEnter_5.Invoke(this.instance, eventData);
            }

            public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
            {
                mOnPointerClick_6.Invoke(this.instance, eventData);
            }

            public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
            {
                mOnPointerExit_7.Invoke(this.instance, eventData);
            }

            public void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData)
            {
                mOnPointerMove_8.Invoke(this.instance, eventData);
            }
            
            
             #region MonoCallback

            object[] param0 = new object[0];
            private bool destroyed = false;
            IMethod awakeMethod;
            bool awakeMethodGot;
            private bool awaked = false;

            public void Awake()
            {
                if (instance == null) return;
                if (!awakeMethodGot)
                {
                    awakeMethod = instance.Type.GetMethod("Awake", 0);
                    awakeMethodGot = true;
                }

                if (awakeMethod != null)
                {
                    appdomain.Invoke(awakeMethod, instance, param0);
                }

                awaked = true;
                if (gameObject.activeSelf)
                    OnEnable();
            }


            IMethod onEnableMethod;
            bool onEnableMethodGot;
            private bool onEnableInvoked;

            private void OnEnable()
            {
                if (instance == null || destroyed || !awaked)
                {
                    return;
                }


                if (!onEnableMethodGot)
                {
                    onEnableMethod = instance.Type.GetMethod("OnEnable", 0);
                    onEnableMethodGot = true;
                }

                if (onEnableMethod != null && !onEnableInvoked)
                {
                    onEnableInvoked = true;
                    appdomain.Invoke(onEnableMethod, instance, param0);
                }
            }


            IMethod startMethod;
            bool startMethodGot;

            void Start()
            {
                if (instance == null || destroyed || !awaked) return;
                if (!startMethodGot)
                {
                    startMethod = instance.Type.GetMethod("Start", 0);
                    startMethodGot = true;
                }

                if (startMethod != null)
                {
                    appdomain.Invoke(startMethod, instance, param0);
                }
            }

            IMethod updateMethod;
            bool updateMethodGot;

            void Update()
            {
                if (instance == null || destroyed) return;
                if (!updateMethodGot)
                {
                    updateMethod = instance.Type.GetMethod("Update", 0);
                    updateMethodGot = true;
                }

                if (updateMethod != null)
                {
                    appdomain.Invoke(updateMethod, instance, param0);
                }
            }


            IMethod fixedUpdateMethod;
            bool fixedUpdateMethodGot;

            void FixedUpdate()
            {
                if (instance == null || destroyed) return;
                if (!fixedUpdateMethodGot)
                {
                    fixedUpdateMethod = instance.Type.GetMethod("FixedUpdate", 0);
                    fixedUpdateMethodGot = true;
                }

                if (fixedUpdateMethod != null)
                {
                    appdomain.Invoke(fixedUpdateMethod, instance, param0);
                }
            }


            IMethod lateUpdateMethod;
            bool lateUpdateMethodGot;

            void LateUpdate()
            {
                if (instance == null || destroyed) return;
                if (!lateUpdateMethodGot)
                {
                    lateUpdateMethod = instance.Type.GetMethod("LateUpdate", 0);
                    lateUpdateMethodGot = true;
                }

                if (lateUpdateMethod != null)
                {
                    appdomain.Invoke(lateUpdateMethod, instance, param0);
                }
            }


            IMethod onDestroyMethod;
            bool onDestroyMethodGot;

            private void OnDestroy()
            {
                if (instance == null || destroyed || appdomain == null) return;
                if (!onDestroyMethodGot)
                {
                    onDestroyMethod = instance.Type.GetMethod("OnDestroy", 0);
                    onDestroyMethodGot = true;
                }

                if (onDestroyMethod != null)
                {
                    try
                    {
                        appdomain.Invoke(onDestroyMethod, instance, param0);
                    }
                    catch (Exception tmp_Exception)
                    {
                        Debug.LogError($"[{this.gameObject.name}]:{tmp_Exception}");
                    }
                }
 
                //To avoid null exception after destroy
                destroyed = true;
            }


            IMethod onDisableMethod;
            bool onDisableMethodGot;

            private void OnDisable()
            {
                onEnableInvoked = false;

                if (instance == null || destroyed) return;
                if (!onDisableMethodGot)
                {
                    onDisableMethod = instance.Type.GetMethod("OnDisable", 0);
                    onDisableMethodGot = true;
                }

                if (onDisableMethod != null)
                {
                    appdomain.Invoke(onDisableMethod, instance, param0);
                }
            }


            IMethod onApplicationFocusMethod;
            bool onApplicationFocusMethodGot;

            private void OnApplicationFocus(bool _hasFocus)
            {
                if (instance == null || destroyed) return;
                if (!onApplicationFocusMethodGot)
                {
                    onApplicationFocusMethod = instance.Type.GetMethod("OnApplicationFocus", 1);
                    onApplicationFocusMethodGot = true;
                }

                if (onApplicationFocusMethod != null)
                {
                    appdomain.Invoke(onApplicationFocusMethod, instance, _hasFocus);
                }
            }


            IMethod onApplicationPauseMethod;
            bool onApplicationPauseMethodGot;

            private void OnApplicationPause(bool _hasFocus)
            {
                if (instance == null || destroyed) return;
                if (!onApplicationPauseMethodGot)
                {
                    onApplicationPauseMethod = instance.Type.GetMethod("OnApplicationPause", 1);
                    onApplicationPauseMethodGot = true;
                }

                if (onApplicationPauseMethod != null)
                {
                    appdomain.Invoke(onApplicationPauseMethod, instance, _hasFocus);
                }
            }


            private IMethod onMouseDownMethod;
            bool onMouseDownMethodGot;

            private void OnMouseDown()
            {
                if (instance == null || destroyed) return;
                if (!onMouseDownMethodGot)
                {
                    onMouseDownMethod = instance.Type.GetMethod("OnMouseDown", 0);
                    onMouseDownMethodGot = true;
                }

                if (onMouseDownMethod != null)
                {
                    appdomain.Invoke(onMouseDownMethod, instance);
                }
            }

            private IMethod onMouseUpMethod;
            bool onMouseUpMethodGot;

            private void OnMouseUp()
            {
                if (instance == null || destroyed) return;
                if (!onMouseUpMethodGot)
                {
                    onMouseUpMethod = instance.Type.GetMethod(nameof(OnMouseUp), 0);
                    onMouseUpMethodGot = true;
                }

                if (onMouseUpMethod != null)
                {
                    appdomain.Invoke(onMouseUpMethod, instance);
                }
            }

            #endregion

            #region Collider3D

            IMethod onTriggerEnterMethod;
            bool onTriggerEnterMethodGot;

            private void OnTriggerEnter(Collider _collider)
            {
                if (instance == null || destroyed) return;
                if (!onTriggerEnterMethodGot)
                {
                    onTriggerEnterMethod = instance.Type.GetMethod("OnTriggerEnter", 1);
                    onTriggerEnterMethodGot = true;
                }

                if (onTriggerEnterMethod != null)
                {
                    appdomain.Invoke(onTriggerEnterMethod, instance, _collider);
                }
            }


            IMethod onTriggerStayMethod;
            bool onTriggerStayMethodGot;

            private void OnTriggerStay(Collider _collider)
            {
                if (instance == null || destroyed) return;
                if (!onTriggerStayMethodGot)
                {
                    onTriggerStayMethod = instance.Type.GetMethod("OnTriggerStay", 1);
                    onTriggerStayMethodGot = true;
                }

                if (onTriggerStayMethod != null)
                {
                    appdomain.Invoke(onTriggerStayMethod, instance, _collider);
                }
            }


            IMethod onTriggerExitMethod;
            bool onTriggerExitMethodGot;

            private void OnTriggerExit(Collider _collider)
            {
                if (instance == null || destroyed) return;
                if (!onTriggerExitMethodGot)
                {
                    onTriggerExitMethod = instance.Type.GetMethod("OnTriggerExit", 1);
                    onTriggerExitMethodGot = true;
                }

                if (onTriggerExitMethod != null)
                {
                    appdomain.Invoke(onTriggerExitMethod, instance, _collider);
                }
            }


            IMethod onCollisionEnterMethod;
            bool onCollisionEnterMethodGot;

            private void OnCollisionEnter(Collision _collision)
            {
                if (instance == null || destroyed) return;
                if (!onCollisionEnterMethodGot)
                {
                    onCollisionEnterMethod = instance.Type.GetMethod("OnCollisionEnter", 1);
                    onCollisionEnterMethodGot = true;
                }

                if (onCollisionEnterMethod != null)
                {
                    appdomain.Invoke(onCollisionEnterMethod, instance, _collision);
                }
            }


            IMethod onCollisionStayMethod;
            bool onCollisionStayMethodGot;

            private void OnCollisionStay(Collision _collision)
            {
                if (instance == null || destroyed) return;
                if (!onCollisionStayMethodGot)
                {
                    onCollisionStayMethod = instance.Type.GetMethod("OnCollisionStay", 1);
                    onCollisionStayMethodGot = true;
                }

                if (onCollisionStayMethod != null)
                {
                    appdomain.Invoke(onCollisionStayMethod, instance, _collision);
                }
            }


            IMethod onCollisionExitMethod;
            bool onCollisionExitMethodGot;

            private void OnCollisionExit(Collision _collision)
            {
                if (instance == null || destroyed) return;
                if (!onCollisionExitMethodGot)
                {
                    onCollisionExitMethod = instance.Type.GetMethod("OnCollisionExit", 1);
                    onCollisionExitMethodGot = true;
                }

                if (onCollisionExitMethod != null)
                {
                    appdomain.Invoke(onCollisionExitMethod, instance, _collision);
                }
            }

            #endregion

            #region Collider2D

            IMethod onTriggerEnter2DMethod;
            bool onTriggerEnter2DMethodGot;

            private void OnTriggerEnter2D(Collider2D _collider)
            {
                if (instance == null || destroyed) return;
                if (!onTriggerEnter2DMethodGot)
                {
                    onTriggerEnter2DMethod = instance.Type.GetMethod(nameof(OnTriggerEnter2D), 1);
                    onTriggerEnter2DMethodGot = true;
                }

                if (onTriggerEnter2DMethod != null)
                {
                    appdomain.Invoke(onTriggerEnter2DMethod, instance, _collider);
                }
            }


            IMethod onTriggerSta2DyMethod;
            bool onTriggerStay2DMethodGot;

            private void OnTriggerStay2D(Collider2D _collider)
            {
                if (instance == null || destroyed) return;
                if (!onTriggerStay2DMethodGot)
                {
                    onTriggerSta2DyMethod = instance.Type.GetMethod(nameof(OnTriggerStay2D), 1);
                    onTriggerStay2DMethodGot = true;
                }

                if (onTriggerSta2DyMethod != null)
                {
                    appdomain.Invoke(onTriggerSta2DyMethod, instance, _collider);
                }
            }


            IMethod onTriggerExit2DMethod;
            bool onTriggerExit2DMethodGot;

            private void OnTriggerExit2D(Collider2D _collider)
            {
                if (instance == null || destroyed) return;
                if (!onTriggerExit2DMethodGot)
                {
                    onTriggerExit2DMethod = instance.Type.GetMethod(nameof(OnTriggerExit2D), 1);
                    onTriggerExit2DMethodGot = true;
                }

                if (onTriggerExit2DMethodGot != null)
                {
                    appdomain.Invoke(onTriggerExit2DMethod, instance, _collider);
                }
            }


            IMethod onCollisionEnter2DMethod;
            bool onCollisionEnter2DMethodGot;

            private void OnCollisionEnter2D(Collision2D _collision)
            {
                if (instance == null || destroyed) return;
                if (!onCollisionEnter2DMethodGot)
                {
                    onCollisionEnter2DMethod = instance.Type.GetMethod(nameof(OnCollisionEnter2D), 1);
                    onCollisionEnter2DMethodGot = true;
                }

                if (onCollisionEnter2DMethod != null)
                {
                    appdomain.Invoke(onCollisionEnter2DMethod, instance, _collision);
                }
            }


            IMethod onCollisionStay2DMethod;
            bool onCollisionStay2DMethodGot;

            private void OnCollisionStay2D(Collision2D _collision)
            {
                if (instance == null || destroyed) return;
                if (!onCollisionStay2DMethodGot)
                {
                    onCollisionStayMethod = instance.Type.GetMethod(nameof(OnCollisionStay2D), 1);
                    onCollisionStay2DMethodGot = true;
                }

                if (onCollisionStay2DMethod != null)
                {
                    appdomain.Invoke(onCollisionStay2DMethod, instance, _collision);
                }
            }


            IMethod onCollisionExit2DMethod;
            bool onCollisionExit2DMethodGot;

            private void OnCollisionExit2D(Collision2D _collision)
            {
                if (instance == null || destroyed) return;
                if (!onCollisionExit2DMethodGot)
                {
                    onCollisionExit2DMethod = instance.Type.GetMethod(nameof(OnCollisionExit2D), 1);
                    onCollisionExit2DMethodGot = true;
                }

                if (onCollisionExit2DMethod != null)
                {
                    appdomain.Invoke(onCollisionExit2DMethod, instance, _collision);
                }
            }

            #endregion

            #region Animator

            IMethod onAnimatorIkMethod;
            bool onAnimatorIkMethodGot;


            public void OnAnimatorIK(int _layerIndex)
            {
                if (instance == null || destroyed) return;
                if (!onAnimatorIkMethodGot)
                {
                    onAnimatorIkMethod = instance.Type.GetMethod("OnAnimatorIK", 1);
                    onAnimatorIkMethodGot = true;
                }

                if (onAnimatorIkMethod != null)
                {
                    appdomain.Invoke(onAnimatorIkMethod, instance, _layerIndex);
                }
            }

            #endregion

            #region Partical

            private IMethod onParticleTriggerMethod;
            bool onParticleMethodGot;


            public void OnParticleTrigger()
            {
                if (instance == null || destroyed) return;
                if (!onParticleMethodGot)
                {
                    onParticleTriggerMethod = instance.Type.GetMethod("OnAnimatorIK", 0);
                    onParticleMethodGot = true;
                }

                if (onParticleTriggerMethod != null)
                {
                    appdomain.Invoke(onParticleTriggerMethod, instance, null);
                }
            }


            private IMethod onParticleCollisionMethod;
            bool onParticleCollisionMethodGot;

            public void OnParticleCollision([NotNull] GameObject _other)
            {
                if (instance == null || destroyed) return;
                if (_other == null) throw new ArgumentNullException(nameof(_other));
                if (!onParticleCollisionMethodGot)
                {
                    onParticleCollisionMethod = instance.Type.GetMethod("OnParticleCollision", 1);
                    onParticleCollisionMethodGot = true;
                }

                if (onParticleCollisionMethod != null)
                {
                    appdomain.Invoke(onParticleCollisionMethod, instance, _other);
                }
            }

            #endregion
        }
    }
}