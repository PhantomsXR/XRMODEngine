// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VoiceModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Threading.Tasks;
using Unity.Services.Vivox;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class TextMessage
    {
        /// <summary>
        /// The account URI of the sender of the message for internal use.
        /// </summary>
        internal  string SenderURI;

        /// <summary>
        /// The URI of the channel a message is related to for internal use.
        /// </summary>
        internal  string ChannelURI;

        /// <summary>
        /// The PlayerId of the sender of the message.
        /// </summary>
        public string SenderPlayerId { get; internal set; }

        /// <summary>
        /// The DisplayName of the sender of the message.
        /// </summary>
        public string SenderDisplayName { get; internal set; }

        /// <summary>
        /// The PlayerId of the recipient of the message.
        /// This will only be populated in VivoxMessages provided by a <see cref="IVivoxService.GetDirectTextMessageHistoryAsync(string, int, ChatHistoryQueryOptions) query."/>
        /// </summary>
        public string RecipientPlayerId { get; internal set; }

        /// <summary>
        /// The ChannelName of the channel the message was sent in.
        /// IMPORTANT: null if the message was a DirectedMessage.
        /// </summary>
        public string ChannelName { get; internal set; }

        /// <summary>
        /// The text body of the message that was sent
        /// </summary>
        public string MessageText { get; internal set; }

        /// <summary>
        /// Whether or not the message was sent from the user to the channel.
        /// </summary>
        public bool FromSelf { get; internal set; }

        /// <summary>
        /// At what time the message was received.
        /// </summary>
        public DateTime ReceivedTime { get; internal set; }

        /// <summary>
        /// The language preference of the user that sent the message.
        /// </summary>
        public string Language { get; internal set; }

        /// <summary>
        /// Unique message id of the text message.
        /// </summary>
        public string MessageId { get; internal set; }

        /// <summary>
        /// Denotes if this message has been read/seen or not.
        /// </summary>
        public bool IsRead { get; internal set; }

        /// <summary>
        /// Denotes if this message was created as a result of a Speech-to-Text transcription.
        /// </summary>
        public bool IsTranscribedMessage { get; internal set; }

        internal Func<DateTime?, Task> OnSetMessageAsReadAsync;

        public async Task SetMessageAsReadAsync(DateTime? _time = null)
        {
            if (OnSetMessageAsReadAsync != null)
                await OnSetMessageAsReadAsync.Invoke(_time);
            else
                await Task.Yield();
        }
    }
}