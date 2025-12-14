// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.GameServices.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public interface ITextMessage
    {
        Task SendDirectTextMessage(string _userId, string _message);

        Task<List<TextMessage>> FetchDirectTextMessageHistory(string _userId);

        Task EditDirectedTextMessage(TextMessage _message, string _editedMessageText);

        Task DeletingDirectTextMessage(string _messageId);
    }
}