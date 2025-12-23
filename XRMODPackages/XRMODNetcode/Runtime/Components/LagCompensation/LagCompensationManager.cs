// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

namespace Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation
{
    /// <summary>
    /// The main class for controlling lag compensation in networked gameplay.
    /// </summary>
    /// <remarks>
    /// Lag compensation allows the server to "rewind" object positions to compensate for client latency,
    /// enabling more accurate hit detection and gameplay logic. This is essential for fast-paced multiplayer games.
    /// </remarks>
    public class LagCompensationManager : MonoBehaviour
    {
        /// <summary>
        /// Gets the singleton instance of the LagCompensationManager.
        /// </summary>
        public static LagCompensationManager Singleton { get; private set; }

        NetworkManager m_NetworkManager;

        [SerializeField] float m_SecondsHistory;

        [SerializeField]
        [Tooltip(
            "If true this will sync transform changes after the rollback back to the physics engine so that queries like raycasts use the compensated positions")]
        bool m_SyncTransforms = true;

        /// <summary>
        /// Gets the list of simulation objects being tracked for lag compensation.
        /// </summary>
        public readonly List<TrackedObject> SimulationObjects = new List<TrackedObject>();

        private void Awake()
        {
            if (Singleton != null && Singleton != this)
            {
                Destroy(gameObject);
                return;
            }

            Singleton = this;

            DontDestroyOnLoad(gameObject);
        }

        private void Update()
        {
            if (m_NetworkManager == null)
            {
                var networkManger = NetworkManager.Singleton;
                if (networkManger != null && networkManger.IsServer ||
                    networkManger.IsClient) // check if networkmanager is running
                {
                    m_NetworkManager = networkManger;
                    m_NetworkManager.NetworkTickSystem.Tick += AddFrames;
                }
            }
            else
            {
                if (m_NetworkManager.IsServer == false && m_NetworkManager.IsClient == false) // no longer running
                {
                    m_NetworkManager.NetworkTickSystem.Tick -= AddFrames;
                    m_NetworkManager = null;
                }
            }
        }

        /// <summary>
        /// Turns time back a given amount of seconds, invokes an action, and then restores the current state.
        /// </summary>
        /// <param name="secondsAgo">The amount of seconds to rewind.</param>
        /// <param name="action">The action to invoke when time is turned back (e.g., perform raycasts or collision checks).</param>
        public void Simulate(float secondsAgo, Action action)
        {
            Simulate(secondsAgo, SimulationObjects, action);
        }

        /// <summary>
        /// Turns time back a given amount of seconds on the given objects, invokes an action, and then restores the current state.
        /// </summary>
        /// <param name="secondsAgo">The amount of seconds to rewind.</param>
        /// <param name="simulatedObjects">The objects to simulate back in time.</param>
        /// <param name="action">The action to invoke when time is turned back.</param>
        /// <exception cref="NotServerException">Thrown if called from a client.</exception>
        public void Simulate(float secondsAgo, IList<TrackedObject> simulatedObjects, Action action)
        {
            if (!NetworkManager.Singleton.IsServer)
            {
                throw new NotServerException("Only the server can perform lag compensation");
            }

            for (int i = 0; i < simulatedObjects.Count; i++)
            {
                simulatedObjects[i].ReverseTransform(secondsAgo);
            }

            if (!Physics.autoSyncTransforms && m_SyncTransforms)
            {
                Physics.SyncTransforms();
            }

            action.Invoke();

            for (int i = 0; i < simulatedObjects.Count; i++)
            {
                simulatedObjects[i].ResetStateTransform();
            }

            if (!Physics.autoSyncTransforms && m_SyncTransforms)
            {
                Physics.SyncTransforms();
            }
        }

        /// <summary>
        /// Turns time back based on the estimated RTT of a client, invokes an action, and then restores the current state.
        /// </summary>
        /// <param name="clientId">The client ID whose RTT to use for compensation.</param>
        /// <param name="action">The action to invoke when time is turned back.</param>
        /// <exception cref="NotServerException">Thrown if called from a client.</exception>
        public void Simulate(ulong clientId, Action action)
        {
            if (!NetworkManager.Singleton.IsServer)
            {
                throw new NotServerException("Only the server can perform lag compensation");
            }

            float millisecondsDelay =
                NetworkManager.Singleton.NetworkConfig.NetworkTransport.GetCurrentRtt(clientId) / 2f;
            Simulate(millisecondsDelay * 1000f, action);
        }

        internal void AddFrames()
        {
            for (int i = 0; i < SimulationObjects.Count; i++)
            {
                SimulationObjects[i].AddFrame();
            }
        }

        internal int MaxQueuePoints()
        {
            return (int) (m_SecondsHistory / (1f / NetworkManager.Singleton.NetworkConfig.TickRate));
        }
    }
}