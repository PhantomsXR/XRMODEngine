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
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    public class UnityFusionMessageBridge : SingletonTemplate<UnityFusionMessageBridge>
    {
        private const string _CONST_MSG_SERVER_CHANNEL = "UF_MSG_Forward";
        private const string _CONST_MSG_CLIENT_CHANNEL = "UF_MSG_Client";


        private const int _CONST_CONST_MSG_HEADER_LENGTH = 12;

        private readonly OnEventCustomNetworkMessagingEventArgs messagingEventArgs = new();

        private CustomMessagingManager msgMgr;


        public void Register()
        {
            msgMgr = NetworkManager.Singleton.CustomMessagingManager;

            if (NetworkManager.Singleton.IsServer)
            {
                msgMgr.UnregisterNamedMessageHandler(_CONST_MSG_SERVER_CHANNEL);
                msgMgr.RegisterNamedMessageHandler(_CONST_MSG_SERVER_CHANNEL, OnServerSideReceive);
            }

            if (NetworkManager.Singleton.IsClient)
            {
                msgMgr.UnregisterNamedMessageHandler(_CONST_MSG_CLIENT_CHANNEL);
                msgMgr.RegisterNamedMessageHandler(_CONST_MSG_CLIENT_CHANNEL, OnClientSideReceive);
            }
        }


        #region Custom Messaging

        public void SendToClient(ulong _clientId, byte[] _data)
        {
            if (!NetworkManager.Singleton.IsClient) return;
            using var tmp_Writer = new FastBufferWriter(_data.Length + _CONST_CONST_MSG_HEADER_LENGTH, Allocator.Temp);
            tmp_Writer.WriteValueSafe(_clientId);
            tmp_Writer.WriteValueSafe(_data.Length);
            tmp_Writer.WriteBytesSafe(_data);
            msgMgr.SendNamedMessage(_CONST_MSG_SERVER_CHANNEL, NetworkManager.ServerClientId,
                tmp_Writer);
        }

        public void SendToAll(byte[] _data)
        {
            if (!NetworkManager.Singleton.IsClient) return;
            using var tmp_Writer = new FastBufferWriter(_data.Length + _CONST_CONST_MSG_HEADER_LENGTH, Allocator.Temp);
            tmp_Writer.WriteValueSafe(ulong.MaxValue);
            tmp_Writer.WriteValueSafe(_data.Length);
            tmp_Writer.WriteBytesSafe(_data);
            msgMgr.SendNamedMessage(_CONST_MSG_SERVER_CHANNEL, NetworkManager.ServerClientId,
                tmp_Writer);
        }

        private void OnClientSideReceive(ulong _clientId, FastBufferReader _reader)
        {
            _reader.ReadValueSafe(out int tmp_Len);
            var tmp_Buf = new byte[tmp_Len];
            _reader.ReadBytesSafe(ref tmp_Buf, tmp_Len);
            messagingEventArgs.MessagingData = tmp_Buf;
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                messagingEventArgs);
        }

        private void OnServerSideReceive(ulong _sender, FastBufferReader _reader)
        {
            try
            {
                _reader.ReadValueSafe(out ulong tmp_TargetClientId);
                _reader.ReadValueSafe(out int tmp_Len);
                var tmp_Buf = new byte[tmp_Len];
                _reader.ReadBytesSafe(ref tmp_Buf, tmp_Len);

                using var tmp_Writer = new FastBufferWriter(tmp_Len + _CONST_CONST_MSG_HEADER_LENGTH, Allocator.Temp);
                tmp_Writer.WriteValueSafe(tmp_Len);
                tmp_Writer.WriteBytesSafe(tmp_Buf);

                if (tmp_TargetClientId != ulong.MaxValue)
                {
                    msgMgr.SendNamedMessage(_CONST_MSG_CLIENT_CHANNEL, tmp_TargetClientId, tmp_Writer);
                }
                else
                {
                    foreach (ulong tmp_ClientId in NetworkManager.Singleton.ConnectedClientsIds)
                    {
                        msgMgr.SendNamedMessage(_CONST_MSG_CLIENT_CHANNEL, tmp_ClientId, tmp_Writer);
                    }
                }
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogException(tmp_Exception);
            }
        }

        #endregion
    }
}