/*===============================================================================
Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XR-MOD SDK.

The XR-MOD SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System;

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// A generic wrapper around a property that notifies subscribers when its value changes.
    /// Provides a simplified Reactive-like pattern for data binding.
    /// </summary>
    /// <typeparam name="T">The type of the value to bind.</typeparam>
    public class BindableProperty<T>
    {
        private T value;

        /// <summary>
        /// Action invoked whenever the <see cref="Value"/> is updated.
        /// </summary>
        public Action<T> OnValueChanged;

        /// <summary>
        /// Gets or sets the current value. Invokes <see cref="OnValueChanged"/> when set.
        /// </summary>
        public T Value
        {
            get => this.value;
            set
            {
                this.value = value;
                OnValueChanged?.Invoke(this.value);
            }
        }

        /// <summary>
        /// Subscribes a callback to the <see cref="OnValueChanged"/> event.
        /// </summary>
        /// <param name="_callback">The callback method to execute when the value changes.</param>
        public void Subscribe(Action<T> _callback)
        {
            OnValueChanged += _callback;
        }

        /// <summary>
        /// Unsubscribes a callback from the <see cref="OnValueChanged"/> event.
        /// </summary>
        /// <param name="_callback">The callback method to remove.</param>
        public void Unsubscribe(Action<T> _callback)
        {
            OnValueChanged -= _callback;
        }
    }
}