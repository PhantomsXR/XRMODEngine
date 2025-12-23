// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.ActionNotification.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    public partial class ActionNotificationCenter
    {
        private readonly Dictionary<string, HashSet<INotificationHandler>> handlers = new();
        private readonly Queue<Action> _pendingOps = new();
        private bool isPosting = false;

        /// <summary>
        /// Registers a general notification handler. Handles reentrancy.
        /// </summary>
        public void AddHandler(INotificationHandler _handler)
        {
            if (isPosting)
            {
                _pendingOps.Enqueue(() => AddHandlerInternal(_handler));
            }
            else
            {
                AddHandlerInternal(_handler);
            }
        }


        public void RemoveHandler(string _name, INotificationHandler _handler)
        {
            if (isPosting)
            {
                _pendingOps.Enqueue(() => RemoveHandlerInternal(_name, _handler));
            }
            else
            {
                RemoveHandlerInternal(_name, _handler);
            }
        }

        public void RemoveHandler(string _name)
        {
            if (isPosting)
            {
                _pendingOps.Enqueue(() => RemoveHandlerInternal(_name));
            }
            else
            {
                RemoveHandlerInternal(_name);
            }
        }

        public List<object> Post(string _name, BaseNotificationData _data)
        {
            ApplyPendingOps();

            if (!handlers.TryGetValue(_name, out var tmp_Set)) return null;

            var tmp_Results = new List<object>();
            isPosting = true;

            foreach (var tmp_Handler in tmp_Set)
                tmp_Handler.Invoke(_data, tmp_Results);

            isPosting = false;

            return tmp_Results;
        }

        public async Task<List<object>> PostAsync(string _name, BaseNotificationData _data)
        {
            ApplyPendingOps();

            if (!handlers.TryGetValue(_name, out var tmp_Set)) return null;

            var tmp_Results = new List<object>();
            isPosting = true;

            foreach (var h in tmp_Set)
                await h.InvokeAsync(_data, tmp_Results);

            isPosting = false;


            return tmp_Results;
        }

        private void AddHandlerInternal(INotificationHandler _handler)
        {
            if (!handlers.TryGetValue(_handler.Name, out var tmp_Set))
            {
                tmp_Set = new HashSet<INotificationHandler>();
                handlers[_handler.Name] = tmp_Set;
            }

            tmp_Set.Add(_handler);
        }

        private void RemoveHandlerInternal(string _name, INotificationHandler _handler)
        {
            if (handlers.TryGetValue(_name, out var tmp_Set))
            {
                if (tmp_Set.Remove(_handler) && tmp_Set.Count == 0)
                    handlers.Remove(_name);
            }
        }

        private void RemoveHandlerInternal(string _name)
        {
            handlers.Remove(_name);
        }


        private void ApplyPendingOps()
        {
            while (_pendingOps.Count > 0)
            {
                var tmp_Op = _pendingOps.Dequeue();
                tmp_Op.Invoke();
            }
        }
    }
}