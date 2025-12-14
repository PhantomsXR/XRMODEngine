// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.LitJson.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;

namespace LitJson
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public sealed class LitJsonNonSerializedAttribute : Attribute
    {

    }
    
    public static class Extensions
    {
        public static void WriteProperty(this JsonWriter _w, string _name, long _value)
        {
            _w.WritePropertyName(_name);
            _w.Write(_value);
        }

        public static void WriteProperty(this JsonWriter _w, string _name, string _value)
        {
            _w.WritePropertyName(_name);
            _w.Write(_value);
        }

        public static void WriteProperty(this JsonWriter _w, string _name, bool _value)
        {
            _w.WritePropertyName(_name);
            _w.Write(_value);
        }

        public static void WriteProperty(this JsonWriter _w, string _name, double _value)
        {
            _w.WritePropertyName(_name);
            _w.Write(_value);
        }
    }
}