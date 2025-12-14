using System;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using JetBrains.Annotations;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;

namespace UnityFusion.CLRBinding.Adapter
{
    public class XRMODBehaviourAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType => typeof(XRMODBehaviour);

        public override Type AdaptorType => typeof(Adapter);


        public override object CreateCLRInstance(UnityFusion.Runtime.Enviorment.AppDomain _appdomain,
            ILTypeInstance _instance)
        {
            return new Adapter(_appdomain, _instance);
        }

        public class Adapter : BaseMonoCrossBindingAdaptor
        {
            public Adapter(UnityFusion.Runtime.Enviorment.AppDomain _appdomain, ILTypeInstance _instance) : base(
                _appdomain, _instance)
            {
                this.appdomain = _appdomain;
                this.instance = _instance;
            }

            #region MonoCallback

            object[] param0 = null;
            private bool destroyed = false;
            IMethod awakeMethod;
            bool awakeMethodGot;
            private bool awaked = false;

            public void Awake()
            {
                if (instance == null) return;
                if (!awakeMethodGot)
                {
                    awakeMethod = instance.Type.GetMethod(nameof(Awake), 0);
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
                    onEnableMethod = instance.Type.GetMethod(nameof(OnEnable), 0);
                    onEnableMethodGot = true;
                }

                if (onEnableMethod != null && !onEnableInvoked)
                {
                    appdomain.Invoke(onEnableMethod, instance, param0);
                }

                onEnableInvoked = true;
            }


            IMethod startMethod;
            bool startMethodGot;

            void Start()
            {
                if (instance == null || destroyed || !awaked || !onEnableInvoked) return;
                if (!startMethodGot)
                {
                    startMethod = instance.Type.GetMethod(nameof(Start), 0);
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
                    updateMethod = instance.Type.GetMethod(nameof(Update), 0);
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
                    fixedUpdateMethod = instance.Type.GetMethod(nameof(FixedUpdate), 0);
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
                    lateUpdateMethod = instance.Type.GetMethod(nameof(LateUpdate), 0);
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
                    onDestroyMethod = instance.Type.GetMethod(nameof(OnDestroy), 0);
                    onDestroyMethodGot = true;
                }

                if (onDestroyMethod != null)
                {
                    appdomain.Invoke(onDestroyMethod, instance, param0);
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
                    onDisableMethod = instance.Type.GetMethod(nameof(OnDisable), 0);
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
                    onApplicationFocusMethod = instance.Type.GetMethod(nameof(OnApplicationFocus), 1);
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
                    onApplicationPauseMethod = instance.Type.GetMethod(nameof(OnApplicationPause), 1);
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
                    onMouseDownMethod = instance.Type.GetMethod(nameof(OnMouseDown), 0);
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
                    onTriggerEnterMethod = instance.Type.GetMethod(nameof(OnTriggerEnter), 1);
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
                    onTriggerStayMethod = instance.Type.GetMethod(nameof(OnTriggerStay), 1);
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
                    onTriggerExitMethod = instance.Type.GetMethod(nameof(OnTriggerExit), 1);
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
                    onCollisionEnterMethod = instance.Type.GetMethod(nameof(OnCollisionEnter), 1);
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
                    onCollisionStayMethod = instance.Type.GetMethod(nameof(OnCollisionStay), 1);
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
                    onCollisionExitMethod = instance.Type.GetMethod(nameof(OnCollisionExit), 1);
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

                if (onTriggerExit2DMethod != null)
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
                    onAnimatorIkMethod = instance.Type.GetMethod(nameof(OnAnimatorIK), 1);
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
                    onParticleTriggerMethod = instance.Type.GetMethod(nameof(OnParticleTrigger), 0);
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
                    onParticleCollisionMethod = instance.Type.GetMethod(nameof(OnParticleCollision), 1);
                    onParticleCollisionMethodGot = true;
                }

                if (onParticleCollisionMethod != null)
                {
                    appdomain.Invoke(onParticleCollisionMethod, instance, _other);
                }
            }

            #endregion


            IMethod onGUIMethod;
            bool onGUIMethodGot;


            public void OnGUI()
            {
                if (instance == null || destroyed) return;
                if (!onGUIMethodGot)
                {
                    onGUIMethod = instance.Type.GetMethod("OnGUI", 0);
                    onGUIMethodGot = true;
                }

                if (onGUIMethod != null)
                {
                    appdomain.Invoke(onGUIMethod, instance, null);
                }
            }


            #region Gizmos

            IMethod onGizmosDrawMethod;
            bool onGizmosDrawMethodGot;


            public void OnDrawGizmos()
            {
                if (instance == null || destroyed) return;
                if (!onGizmosDrawMethodGot)
                {
                    onGizmosDrawMethod = instance.Type.GetMethod(nameof(OnDrawGizmos), 0);
                    onGizmosDrawMethodGot = true;
                }

                if (onGizmosDrawMethod != null)
                {
                    appdomain.Invoke(onGizmosDrawMethod, instance, null);
                }
            }


            IMethod onDrawGizmosSelectedMethod;
            bool onDrawGizmosSelectedMethodGot;

            public void OnDrawGizmosSelected()
            {
                if (instance == null || destroyed) return;
                if (!onDrawGizmosSelectedMethodGot)
                {
                    onDrawGizmosSelectedMethod = instance.Type.GetMethod(nameof(OnDrawGizmosSelected), 0);
                    onDrawGizmosSelectedMethodGot = true;
                }

                if (onDrawGizmosSelectedMethod != null)
                {
                    appdomain.Invoke(onDrawGizmosSelectedMethod, instance, null);
                }
            }

            #endregion


            public override string ToString()
            {
                IMethod tmp_Method = appdomain.ObjectType.GetMethod(nameof(ToString), 0);
                tmp_Method = instance.Type.GetVirtualMethod(tmp_Method);
                if (tmp_Method == null || tmp_Method is ILMethod)
                {
                    return instance.ToString();
                }
                else
                    return instance.Type.FullName;
            }


            public virtual void Reset()
            {
                awakeMethodGot = false;
                startMethodGot = false;
                updateMethodGot = false;
                fixedUpdateMethodGot = false;
                lateUpdateMethodGot = false;
                onEnableMethodGot = false;
                onDisableMethodGot = false;
                onDisableMethodGot = false;
                onTriggerEnterMethodGot = false;
                onTriggerStayMethodGot = false;
                onTriggerExitMethodGot = false;
                onCollisionEnterMethodGot = false;
                onCollisionStayMethodGot = false;
                onCollisionExitMethodGot = false;
                onDrawGizmosSelectedMethodGot = false;
                instance = null;
                appdomain = null;
                onDestroyMethodGot = false;
            }
        }
    }
}