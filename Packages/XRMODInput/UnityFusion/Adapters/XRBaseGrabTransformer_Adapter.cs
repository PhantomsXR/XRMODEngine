#if USE_XRI

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
    public class XRBaseGrabTransformerAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get
            {
                return typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer);
            }
        }

        public override Type AdaptorType
        {
            get
            {
                return typeof(Adapter);
            }
        }

        public override object CreateCLRInstance(UnityFusion.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
        {
            return new Adapter(appdomain, instance);
        }

        public class Adapter : UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer, CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<System.Boolean> mget_canProcess_0 = new CrossBindingFunctionInfo<System.Boolean>("get_canProcess");
            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer.RegistrationMode> mget_registrationMode_1 = new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer.RegistrationMode>("get_registrationMode");
            CrossBindingMethodInfo mStart_2 = new CrossBindingMethodInfo("Start");
            CrossBindingMethodInfo mOnDestroy_3 = new CrossBindingMethodInfo("OnDestroy");
            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable> mOnLink_4 = new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>("OnLink");
            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable> mOnGrab_5 = new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>("OnGrab");
            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable, UnityEngine.Pose, UnityEngine.Vector3> mOnGrabCountChanged_6 = new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable, UnityEngine.Pose, UnityEngine.Vector3>("OnGrabCountChanged");
            class Process_7Info : CrossBindingMethodInfo
            {
                static Type[] pTypes = new Type[] {typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable), typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase), typeof(UnityEngine.Pose).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType()};

                public Process_7Info()
                    : base("Process")
                {

                }

                protected override Type ReturnType { get { return null; } }

                protected override Type[] Parameters { get { return pTypes; } }
                public void Invoke(ILTypeInstance instance, UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable, UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase updatePhase, ref UnityEngine.Pose targetPose, ref UnityEngine.Vector3 localScale)
                {
                    EnsureMethod(instance);

                    if (method != null)
                    {
                        invoking = true;
                        try
                        {
                            using (var ctx = domain.BeginInvoke(method))
                            {
                            ctx.PushObject(targetPose);
                            ctx.PushObject(localScale);
                                ctx.PushObject(instance);
                            ctx.PushObject(grabInteractable);
                            ctx.PushObject(updatePhase);
                                ctx.PushReference(0);
                                ctx.PushReference(1);
                                ctx.Invoke();
                            targetPose = ctx.ReadObject<UnityEngine.Pose>(0);
                            localScale = ctx.ReadObject<UnityEngine.Vector3>(1);
                            }
                        }
                        finally
                        {
                            invoking = false;
                        }
                    }
                }

                public override void Invoke(ILTypeInstance instance)
                {
                    throw new NotSupportedException();
                }
            }
            Process_7Info mProcess_7 = new Process_7Info();
            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable> mOnUnlink_8 = new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>("OnUnlink");

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

            public ILTypeInstance ILInstance { get { return instance; } }

            protected override void Start()
            {
                if (mStart_2.CheckShouldInvokeBase(this.instance))
                    base.Start();
                else
                    mStart_2.Invoke(this.instance);
            }

            protected override void OnDestroy()
            {
                if (mOnDestroy_3.CheckShouldInvokeBase(this.instance))
                    base.OnDestroy();
                else
                    mOnDestroy_3.Invoke(this.instance);
            }

            public override void OnLink(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable)
            {
                if (mOnLink_4.CheckShouldInvokeBase(this.instance))
                    base.OnLink(grabInteractable);
                else
                    mOnLink_4.Invoke(this.instance, grabInteractable);
            }

            public override void OnGrab(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable)
            {
                if (mOnGrab_5.CheckShouldInvokeBase(this.instance))
                    base.OnGrab(grabInteractable);
                else
                    mOnGrab_5.Invoke(this.instance, grabInteractable);
            }

            public override void OnGrabCountChanged(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable, UnityEngine.Pose targetPose, UnityEngine.Vector3 localScale)
            {
                if (mOnGrabCountChanged_6.CheckShouldInvokeBase(this.instance))
                    base.OnGrabCountChanged(grabInteractable, targetPose, localScale);
                else
                    mOnGrabCountChanged_6.Invoke(this.instance, grabInteractable, targetPose, localScale);
            }

            public override void Process(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable, UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase updatePhase, ref UnityEngine.Pose targetPose, ref UnityEngine.Vector3 localScale)
            {
                mProcess_7.Invoke(this.instance, grabInteractable, updatePhase, ref targetPose, ref localScale);
            }

            public override void OnUnlink(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable)
            {
                if (mOnUnlink_8.CheckShouldInvokeBase(this.instance))
                    base.OnUnlink(grabInteractable);
                else
                    mOnUnlink_8.Invoke(this.instance, grabInteractable);
            }

            public override System.Boolean canProcess
            {
            get
            {
                if (mget_canProcess_0.CheckShouldInvokeBase(this.instance))
                    return base.canProcess;
                else
                    return mget_canProcess_0.Invoke(this.instance);

            }
            }

            protected override UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer.RegistrationMode registrationMode
            {
            get
            {
                if (mget_registrationMode_1.CheckShouldInvokeBase(this.instance))
                    return base.registrationMode;
                else
                    return mget_registrationMode_1.Invoke(this.instance);

            }
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

#endif