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
    public class NetworkBehaviourAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get
            {
                return typeof(Unity.Netcode.NetworkBehaviour);
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

        public class Adapter : Unity.Netcode.NetworkBehaviour, CrossBindingAdaptorType
        {
            CrossBindingMethodInfo<System.Int32> mOnDeferringDespawn_0 = new CrossBindingMethodInfo<System.Int32>("OnDeferringDespawn");
            class OnNetworkPreSpawn_1Info : CrossBindingMethodInfo
            {
                static Type[] pTypes = new Type[] {typeof(Unity.Netcode.NetworkManager).MakeByRefType()};

                public OnNetworkPreSpawn_1Info()
                    : base("OnNetworkPreSpawn")
                {

                }

                protected override Type ReturnType { get { return null; } }

                protected override Type[] Parameters { get { return pTypes; } }
                public void Invoke(ILTypeInstance instance, ref Unity.Netcode.NetworkManager networkManager)
                {
                    EnsureMethod(instance);

                    if (method != null)
                    {
                        invoking = true;
                        try
                        {
                            using (var ctx = domain.BeginInvoke(method))
                            {
                            ctx.PushObject(networkManager);
                                ctx.PushObject(instance);
                                ctx.PushReference(0);
                                ctx.Invoke();
                            networkManager = ctx.ReadObject<Unity.Netcode.NetworkManager>(0);
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
            OnNetworkPreSpawn_1Info mOnNetworkPreSpawn_1 = new OnNetworkPreSpawn_1Info();
            CrossBindingMethodInfo mOnNetworkSpawn_2 = new CrossBindingMethodInfo("OnNetworkSpawn");
            CrossBindingMethodInfo mOnNetworkPostSpawn_3 = new CrossBindingMethodInfo("OnNetworkPostSpawn");
            CrossBindingMethodInfo mOnNetworkSessionSynchronized_4 = new CrossBindingMethodInfo("OnNetworkSessionSynchronized");
            CrossBindingMethodInfo mOnInSceneObjectsSpawned_5 = new CrossBindingMethodInfo("OnInSceneObjectsSpawned");
            CrossBindingMethodInfo mOnNetworkDespawn_6 = new CrossBindingMethodInfo("OnNetworkDespawn");
            CrossBindingMethodInfo mOnGainedOwnership_7 = new CrossBindingMethodInfo("OnGainedOwnership");
            CrossBindingMethodInfo<System.UInt64, System.UInt64> mOnOwnershipChanged_8 = new CrossBindingMethodInfo<System.UInt64, System.UInt64>("OnOwnershipChanged");
            CrossBindingMethodInfo mOnLostOwnership_9 = new CrossBindingMethodInfo("OnLostOwnership");
            CrossBindingMethodInfo<Unity.Netcode.NetworkObject> mOnNetworkObjectParentChanged_10 = new CrossBindingMethodInfo<Unity.Netcode.NetworkObject>("OnNetworkObjectParentChanged");
            CrossBindingMethodInfo m__initializeVariables_11 = new CrossBindingMethodInfo("__initializeVariables");
            CrossBindingMethodInfo m__initializeRpcs_12 = new CrossBindingMethodInfo("__initializeRpcs");
            CrossBindingMethodInfo<System.Double> mOnReanticipate_13 = new CrossBindingMethodInfo<System.Double>("OnReanticipate");
            CrossBindingMethodInfo mOnDestroy_14 = new CrossBindingMethodInfo("OnDestroy");

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

            public override void OnDeferringDespawn(System.Int32 despawnTick)
            {
                if (mOnDeferringDespawn_0.CheckShouldInvokeBase(this.instance))
                    base.OnDeferringDespawn(despawnTick);
                else
                    mOnDeferringDespawn_0.Invoke(this.instance, despawnTick);
            }

            protected override void OnNetworkPreSpawn(ref Unity.Netcode.NetworkManager networkManager)
            {
                if (mOnNetworkPreSpawn_1.CheckShouldInvokeBase(this.instance))
                    base.OnNetworkPreSpawn(ref networkManager);
                else
                    mOnNetworkPreSpawn_1.Invoke(this.instance, ref networkManager);
            }

            public override void OnNetworkSpawn()
            {
                if (mOnNetworkSpawn_2.CheckShouldInvokeBase(this.instance))
                    base.OnNetworkSpawn();
                else
                    mOnNetworkSpawn_2.Invoke(this.instance);
            }

            protected override void OnNetworkPostSpawn()
            {
                if (mOnNetworkPostSpawn_3.CheckShouldInvokeBase(this.instance))
                    base.OnNetworkPostSpawn();
                else
                    mOnNetworkPostSpawn_3.Invoke(this.instance);
            }

            protected override void OnNetworkSessionSynchronized()
            {
                if (mOnNetworkSessionSynchronized_4.CheckShouldInvokeBase(this.instance))
                    base.OnNetworkSessionSynchronized();
                else
                    mOnNetworkSessionSynchronized_4.Invoke(this.instance);
            }

            protected override void OnInSceneObjectsSpawned()
            {
                if (mOnInSceneObjectsSpawned_5.CheckShouldInvokeBase(this.instance))
                    base.OnInSceneObjectsSpawned();
                else
                    mOnInSceneObjectsSpawned_5.Invoke(this.instance);
            }

            public override void OnNetworkDespawn()
            {
                if (mOnNetworkDespawn_6.CheckShouldInvokeBase(this.instance))
                    base.OnNetworkDespawn();
                else
                    mOnNetworkDespawn_6.Invoke(this.instance);
            }

            public override void OnGainedOwnership()
            {
                if (mOnGainedOwnership_7.CheckShouldInvokeBase(this.instance))
                    base.OnGainedOwnership();
                else
                    mOnGainedOwnership_7.Invoke(this.instance);
            }

            protected override void OnOwnershipChanged(System.UInt64 previous, System.UInt64 current)
            {
                if (mOnOwnershipChanged_8.CheckShouldInvokeBase(this.instance))
                    base.OnOwnershipChanged(previous, current);
                else
                    mOnOwnershipChanged_8.Invoke(this.instance, previous, current);
            }

            public override void OnLostOwnership()
            {
                if (mOnLostOwnership_9.CheckShouldInvokeBase(this.instance))
                    base.OnLostOwnership();
                else
                    mOnLostOwnership_9.Invoke(this.instance);
            }

            public override void OnNetworkObjectParentChanged(Unity.Netcode.NetworkObject parentNetworkObject)
            {
                if (mOnNetworkObjectParentChanged_10.CheckShouldInvokeBase(this.instance))
                    base.OnNetworkObjectParentChanged(parentNetworkObject);
                else
                    mOnNetworkObjectParentChanged_10.Invoke(this.instance, parentNetworkObject);
            }
            

            public override void OnReanticipate(System.Double lastRoundTripTime)
            {
                if (mOnReanticipate_13.CheckShouldInvokeBase(this.instance))
                    base.OnReanticipate(lastRoundTripTime);
                else
                    mOnReanticipate_13.Invoke(this.instance, lastRoundTripTime);
            }

            public override void OnDestroy()
            {
                if (mOnDestroy_14.CheckShouldInvokeBase(this.instance))
                    base.OnDestroy();
                else
                    mOnDestroy_14.Invoke(this.instance);
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

