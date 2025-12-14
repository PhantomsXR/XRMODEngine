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
    public class PoolStack
    {
        private int index = -1;
        private int count = 0;

        private List<PoolCell> cellStack = new();

        public List<PoolCell> CellRegistry { get; protected set; } = new();

        public IEnumerator CellGenerator;

        public bool ActiveOnGet = false;
        public Vector3 PrefabScale = Vector3.one;
        public Transform Container;

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

        public void Remove(PoolCell _cell)
        {
            for (int tmp_Idx = 0; tmp_Idx < index; tmp_Idx++)
            {
                if (cellStack[tmp_Idx] == _cell)
                {
                    for (; tmp_Idx < index; ++tmp_Idx)
                    {
                        cellStack[tmp_Idx] = cellStack[tmp_Idx + 1];
                    }

                    cellStack[index] = null;
                    --index;
                }
            }
        }

        public void RemoveAll()
        {
            count = 0;
            index = 1;
            cellStack.Clear();
            CellRegistry.Clear();
        }

        public void RegisterCell(PoolCell _cell)
        {
            CellRegistry.Add(_cell);
        }

        public PoolCell GenerateCell()
        {
            CellGenerator.MoveNext();
            PoolCell tmp_PoolCell = CellGenerator.Current as PoolCell;
            RegisterCell(tmp_PoolCell);
            return tmp_PoolCell;
        }
    }
}