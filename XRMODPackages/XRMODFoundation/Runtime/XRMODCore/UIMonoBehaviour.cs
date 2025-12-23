/*===============================================================================
Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.

This file is part of the UnityFusion.Adapter.Runtime.

The ARMOD-SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;
using UnityEngine.EventSystems;

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Specialized <see cref="XRMODBehaviour"/> for UI components that requires handling pointer and drag events.
    /// Implements standard Unity Event System interfaces.
    /// </summary>
    public class UIMonoBehaviour : XRMODBehaviour, IDragHandler, IBeginDragHandler,
        IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerClickHandler,
        IPointerExitHandler, IPointerMoveHandler
    {
        public virtual void OnDrag(PointerEventData eventData)
        {
        }

        public virtual void OnBeginDrag(PointerEventData eventData)
        {
        }

        public virtual void OnEndDrag(PointerEventData eventData)
        {
        }

        public virtual void OnPointerDown(PointerEventData eventData)
        {
        }

        public virtual void OnPointerUp(PointerEventData eventData)
        {
        }

        public virtual void OnPointerEnter(PointerEventData eventData)
        {
        }

        public virtual void OnPointerClick(PointerEventData eventData)
        {
        }

        public virtual void OnPointerExit(PointerEventData eventData)
        {
        }

        public virtual void OnPointerMove(PointerEventData eventData)
        {
        }
    }
}