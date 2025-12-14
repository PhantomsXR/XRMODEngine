#if FUSION2 && XRMOD_INSTALL
using System;
using Fusion;
using UnityEngine;
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
    public class SimulationBehaviourAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get { return typeof(Fusion.SimulationBehaviour); }
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

        public class Adapter : Fusion.SimulationBehaviour, CrossBindingAdaptorType, IPlayerLeft, IPlayerJoined
        {
            CrossBindingMethodInfo mFixedUpdateNetwork_0 = new("FixedUpdateNetwork");
            CrossBindingMethodInfo mRender_1 = new("Render");
            CrossBindingMethodInfo<PlayerRef> mPlayerJoined_1 = new("PlayerJoined");
            CrossBindingMethodInfo<PlayerRef> mPlayerLeft_1 = new("PlayerLeft");

            CrossBindingMethodInfo<System.Text.StringBuilder> mDump_2 = new("Dump");

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

            #region MonoCallback

            object[] param0 = new object[0];
            private bool destroyed = false;
            IMethod awakeMethod;
            bool awakeMethodGot;
            private bool awaked = false;

            public void Awake()
            {
                try
                {
                    if (instance == null) return;
                    if (!awakeMethodGot)
                    {
                        awakeMethod = instance.Type.GetMethod("Awake", 0);
                        awakeMethodGot = true;
                    }

                    if (awakeMethod != null)
                        appdomain.Invoke(awakeMethod, instance, param0);
                    awaked = true;
                }
                catch (Exception tmp_Exception)
                {
                    Debug.LogError(tmp_Exception);
                    throw;
                }
            }


            IMethod startMethod;
            bool startMethodGot;

            void Start()
            {
                try
                {
                    if (instance == null || destroyed) return;
                    if (!startMethodGot)
                    {
                        startMethod = instance.Type.GetMethod("Start", 0);
                        startMethodGot = true;
                    }

                    if (startMethod != null)
                    {
                        appdomain.Invoke(startMethod, instance, null);
                    }
                }
                catch (Exception tmp_Exception)
                {
                    Debug.LogError(tmp_Exception);
                    throw;
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
                    appdomain.Invoke(updateMethod, instance, null);
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
                    appdomain.Invoke(fixedUpdateMethod, instance, null);
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
                    appdomain.Invoke(lateUpdateMethod, instance, null);
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
                    appdomain.Invoke(onDestroyMethod, instance, null);
                }

                //To avoid null exception after destroy
                destroyed = true;
            }


            IMethod onEnableMethod;
            bool onEnableMethodGot;

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

                if (onEnableMethod != null)
                {
                    appdomain.Invoke(onEnableMethod, instance, null);
                }
            }


            IMethod onDisableMethod;
            bool onDisableMethodGot;

            private void OnDisable()
            {
                if (instance == null || destroyed) return;
                if (!onDisableMethodGot)
                {
                    onDisableMethod = instance.Type.GetMethod("OnDisable", 0);
                    onDisableMethodGot = true;
                }

                if (onDisableMethod != null)
                {
                    appdomain.Invoke(onDisableMethod, instance, null);
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

            public void OnParticleCollision(GameObject _other)
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

            #region Network

            public override void FixedUpdateNetwork()
            {
                if (mFixedUpdateNetwork_0.CheckShouldInvokeBase(this.instance))
                    base.FixedUpdateNetwork();
                else
                    mFixedUpdateNetwork_0.Invoke(this.instance);
            }

            public override void Render()
            {
                if (mRender_1.CheckShouldInvokeBase(this.instance))
                    base.Render();
                else
                    mRender_1.Invoke(this.instance);
            }

            public void Dump(System.Text.StringBuilder builder)
            {
                mDump_2.Invoke(this.instance, builder);
            }

            public void PlayerJoined(PlayerRef _player)
            {
                mPlayerJoined_1?.Invoke(this.instance, _player);
            }

            public void PlayerLeft(PlayerRef _player)
            {
                mPlayerLeft_1?.Invoke(this.instance, _player);
            }

            #endregion

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
#endif