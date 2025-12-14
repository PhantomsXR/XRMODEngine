using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.Scripting;

namespace Phantom.XRMOD.GameServices.Runtime
{
    /// <summary>
    /// Activity represent the activity containing the status of a player.
    /// </summary>
    [Preserve]
    [DataContract]
    public class Activity
    {
        /// <summary>
        /// Status of the player.
        /// </summary>
        [Preserve]
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }
    }
}