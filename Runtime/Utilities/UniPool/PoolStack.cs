// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODUtilites.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime.UniPool
{
    /// <summary>
    /// Manages a stack of <see cref="PoolCell"/> instances for a specific prefab.
    /// Handles allocation, retrieval (pop), and recycling (push) of pooled objects.
    /// </summary>
    public class PoolStack
    {
        private int index = -1;
        private int count = 0;

        private List<PoolCell> cellStack = new();

        /// <summary>
        /// A complete list of all cells (both active and pooled) managed by this stack.
        /// </summary>
        public List<PoolCell> CellRegistry { get; protected set; } = new();

        /// <summary>
        /// An enumerator used to generate new <see cref="PoolCell"/> instances on demand.
        /// </summary>
        public IEnumerator CellGenerator;

        /// <summary>
        /// Should the GameObject be active when retrieved from the pool?
        /// </summary>
        public bool ActiveOnGet = false;

        /// <summary>
        /// The original local scale of the prefab to restore on release.
        /// </summary>
        public Vector3 PrefabScale = Vector3.one;

        /// <summary>
        /// The default parent transform for objects in this stack.
        /// </summary>
        public Transform Container;

        /// <summary>
        /// Pushes a cell back onto the stack for reuse.
        /// </summary>
        /// <param name="_cell">The cell to recycle.</param>
        public void Push(PoolCell _cell)
        {
            ++index;
            if (index < count)
            {
                cellStack[index] = _cell;
            }
            else
            {
                cellStack.Add(_cell);
                ++count;
            }
        }

        /// <summary>
        /// Attempts to pop an available cell from the stack.
        /// </summary>
        /// <param name="_cell">The retrieved cell, or null if the stack is empty.</param>
        /// <returns>True if a cell was retrieved; otherwise, false.</returns>
        public bool TryPop(out PoolCell _cell)
        {
            if (index > -1)
            {
                _cell = cellStack[index];
                cellStack[index] = null;
                --index;
                return true;
            }

            _cell = null;
            return false;
        }

        /// <summary>
        /// Removes a specific cell from the stack (if it exists there).
        /// </summary>
        /// <param name="_cell">The cell to remove.</param>
        public void Remove(PoolCell _cell)
        {
            for (int tmp_Idx = 0; tmp_Idx <= index; tmp_Idx++)
            {
                if (cellStack[tmp_Idx] == _cell)
                {
                    for (int tmp_InnerIdx = tmp_Idx; tmp_InnerIdx < index; ++tmp_InnerIdx)
                    {
                        cellStack[tmp_InnerIdx] = cellStack[tmp_InnerIdx + 1];
                    }

                    cellStack[index] = null;
                    --index;
                    break;
                }
            }
        }

        /// <summary>
        /// Clears all cells from the stack and registry.
        /// </summary>
        public void RemoveAll()
        {
            count = 0;
            index = -1; // Fixed: should be -1 for empty
            cellStack.Clear();
            CellRegistry.Clear();
        }

        /// <summary>
        /// Registers a newly created cell into the registry.
        /// </summary>
        /// <param name="_cell">The cell to register.</param>
        public void RegisterCell(PoolCell _cell)
        {
            CellRegistry.Add(_cell);
        }

        /// <summary>
        /// Generates a new cell using the generator and registers it.
        /// </summary>
        /// <returns>The newly created <see cref="PoolCell"/>.</returns>
        public PoolCell GenerateCell()
        {
            CellGenerator.MoveNext();
            PoolCell tmp_PoolCell = CellGenerator.Current as PoolCell;
            RegisterCell(tmp_PoolCell);
            return tmp_PoolCell;
        }
    }
}