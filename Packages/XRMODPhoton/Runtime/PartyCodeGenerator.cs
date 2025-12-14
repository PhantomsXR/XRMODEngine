// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if FUSION2
using System;
using System.Security.Cryptography;
using System.Text;
using Fusion;
using UnityEngine;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public class PartyCodeGenerator
    {
        /// <summary>
        /// Available characters for the code generation. The default setup skips O and 0 for example.
        /// </summary>
        [InlineHelp] public string ValidCharacters = "ABCDEFGHIJKLMNPQRSTUVWXYZ123456789";

        /// <summary>
        /// The length of the party code.
        /// </summary>
        [InlineHelp, Range(1, 32)] public int Length = 8;

        /// <summary>
        /// The position of the encoded region.
        /// </summary>
        [InlineHelp, Range(1, 32)] public int EncodedRegionPosition = 4;

        /// <summary>
        /// Create a random party code with default length.
        /// </summary>
        /// <returns>Random code</returns>
        public virtual string Create()
        {
            return Create(Length);
        }

        /// <summary>
        /// Create a party code with variable length.
        /// </summary>
        /// <param name="_length">Code length</param>
        /// <returns>Random code</returns>
        public virtual string Create(int _length)
        {
            return Create(_length, ValidCharacters);
        }

        /// <summary>
        /// Creates a random party code.
        /// </summary>
        /// <param name="_length">Code length</param>
        /// <param name="_validCharacters">Useable characters</param>
        /// <returns>Random code</returns>
        public static string Create(int _length, string _validCharacters)
        {
            _length = Math.Max(1, Math.Min(_length, 128));

            // m = 238 = highest multiple of 34 in 255
            var m = Mathf.FloorToInt((255.0f / _validCharacters.Length)) * _validCharacters.Length;
            if (m <= 0)
            {
                Debug.LogError($"Number of valid character ({_validCharacters.Length}) has to be less than 255.");
                return null;
            }

            var res = new StringBuilder();
            using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
            {
                while (res.Length != _length)
                {
                    var bytes = new byte[8];
                    provider.GetBytes(bytes);
                    foreach (var b in bytes)
                    {
                        if (b >= m || res.Length == _length) continue;
                        var character = _validCharacters[b % _validCharacters.Length];
                        res.Append(character);
                    }
                }
            }

            return res.ToString();
        }

        /// <summary>
        /// Checks if a party code is valid.
        /// </summary>
        /// <param name="_code">Code</param>
        /// <returns>True, if the party code consists of the desired length and characters</returns>
        public virtual bool IsValid(string _code)
        {
            return IsValid(_code, Length);
        }

        /// <summary>
        /// Checks if a party code is valid.
        /// </summary>
        /// <param name="_code">Code</param>
        /// <param name="_length">Variable length</param>
        /// <returns>True, if the party code consists of the desired length and characters</returns>
        public virtual bool IsValid(string _code, int _length)
        {
            if (string.IsNullOrEmpty(_code))
            {
                return false;
            }

            if (_code.Length != Length)
            {
                return false;
            }

            for (int i = 0; i < _code.Length; i++)
            {
                if (ValidCharacters.Contains(_code[i]) == false)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Substitutes one character with the region.
        /// </summary>
        /// <param name="_code">Code</param>
        /// <param name="_region">Region index</param>
        /// <returns>New code</returns>
        public virtual string EncodeRegion(string _code, int _region)
        {
            if (string.IsNullOrEmpty(_code))
            {
                return null;
            }

            if (_region < 0 || _region >= 32)
            {
                return null;
            }

            if (_region >= ValidCharacters.Length)
            {
                return null;
            }

            var index = Math.Clamp(EncodedRegionPosition, 0, _code.Length - 1);

            if (index < 0 || index >= _code.Length)
            {
                return null;
            }

            return _code.Remove(index, 1).Insert(index, ValidCharacters[_region].ToString());
        }

        /// <summary>
        /// Reads the characater at the position <see cref="EncodedRegionPosition"/> as a int.
        /// </summary>
        /// <param name="code">Code</param>
        /// <returns>Region index</returns>
        public virtual int DecodeRegion(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return -1;
            }

            var index = Math.Clamp(EncodedRegionPosition, 0, code.Length - 1);

            if (index < 0 || index >= code.Length)
            {
                return -1;
            }

            return ValidCharacters.IndexOf(code[index]);
        }
    }
}
#endif