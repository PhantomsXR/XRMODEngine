// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XR-MOD SDK.
// //
// // The XR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;

namespace Phantom.XRMOD.Core.Runtime
{
    public class BindableProperty<T>
    {
        private T value;
        public Action<T> OnValueChanged;

        public T Value
        {
            get => this.value;
            set
            {
                this.value = value;
                OnValueChanged?.Invoke(this.value);
            }
        }

        public void Subscribe(Action<T> _callback)
        {
            OnValueChanged += _callback;
        }

        public void Unsubscribe(Action<T> _callback)
        {
            OnValueChanged -= _callback;
        }
    }
}