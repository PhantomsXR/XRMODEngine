// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODUtilites.Runtime.
// //
// // The UnityVisionOSLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic; 
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    /// <summary>
    /// Adapter component that adds and manages a sorting group, specifically for Apple VisionOS via PolySpatial.
    /// Controls the rendering order of multiple objects in a 3D scene.
    /// </summary>
    public class SortingGroupComponentAdapter : MonoBehaviour
    {
        /// <summary>
        /// Enum defining depth pass types for the sorting group.
        /// </summary>
        public enum DepthPassType : int
        {
            /// <summary>
            /// Draws depth of renderer after drawing all color.
            /// </summary>
            PostPass,

            /// <summary>
            /// Draws depth of renderer before drawing any color.
            /// </summary>
            PrePass,

            /// <summary>
            /// Draws depth and color at the same time.
            /// </summary>
            Unseparated,
        }

        [SerializeField] private DepthPassType depthPass;

        [SerializeField, Tooltip("List of all renderers belonging to this sort group.")]
        List<RendererSorting> renderers = new List<RendererSorting>();


        /// <summary>
        /// The depth pass type currently in use.
        /// </summary>
        public BindableProperty<DepthPassType> DepthPass = new();

        /// <summary>
        /// The list of renderers and their associated sort order.
        /// </summary>
        public BindableProperty<List<RendererSorting>> Renderers = new();

        /// <summary>
        /// Data structure defining the sorting order for a specific renderer.
        /// </summary>
        [System.Serializable]
        public struct RendererSorting : IEquatable<RendererSorting>
        {
            /// <summary>
            /// Drawing order within the sorting group. Lower values are drawn first and capture input last.
            /// </summary>
            [Tooltip("Order within the sort group. Lower values indicate they should be drawn first.")]
            public int Order;

            /// <summary>
            /// The GameObject containing the <see cref="UnityEngine.Renderer"/> instance to draw at the associated order in the group.
            /// </summary>
            /// <remarks>
            /// A GameObject can only belong to one sorting group. If you try to add
            /// a GameObject to a second group, the action is ignored.
            ///
            /// If you set <see cref="ApplyToDescendants"/> to <c>true</c>, then any child
            /// GameObjects are also included in the sorting group at their parent's order.
            /// (The parent does not need to have a renderer or collider in this case.)
            /// </remarks>
            [Tooltip("The renderer the sort order should apply to.")]
            public GameObject Renderer;

            /// <summary>
            /// Whether the sort order should also be applied to all descendant renderers.
            /// </summary>
            [Tooltip("Whether the sort order should also be applied to all descendant renderers.")]
            public bool ApplyToDescendants;

            /// <summary>
            /// For comparing if two RendererSortings are equal, used for insertion and remove from Lists.
            /// </summary>
            /// <param name="other">The RendererSorting to compare</param>
            /// <returns>True if the RendererSortings are equal, false otherwise</returns>
            public readonly bool Equals(RendererSorting other)
            {
                return Order == other.Order && Renderer == other.Renderer &&
                       ApplyToDescendants == other.ApplyToDescendants;
            }

            /// <summary>
            /// Overload to determine object equality
            /// </summary>
            /// <param name="obj">The object to check against</param>
            /// <returns>True if obj is an equivalent RendererSorting, false otherwise</returns>
            public override readonly bool Equals(object obj)
            {
                return obj is RendererSorting other && Equals(other);
            }

            /// <inheritdoc/>
            public override readonly int GetHashCode()
            {
                return HashCode.Combine(Order, Renderer, ApplyToDescendants);
            }
        }

#if VISIONOS_INSTALL
        private Unity.PolySpatial.VisionOSSortingGroup sortingGroup;

        private void Start()
        {
            sortingGroup = gameObject.AddComponent<Unity.PolySpatial.VisionOSSortingGroup>();
            DepthPass.OnValueChanged = _depthPass =>
            {
                sortingGroup.DepthPass = (Unity.PolySpatial.VisionOSSortingGroup.DepthPassType) _depthPass;
            };

            Renderers.OnValueChanged = _renderers =>
            {
                ObservableList<Unity.PolySpatial.VisionOSSortingGroup.RendererSorting> tmp_RendererSortings =
                    new ObservableList<Unity.PolySpatial.VisionOSSortingGroup.RendererSorting>();
                foreach (RendererSorting tmp_RendererSorting in _renderers)
                {
                    tmp_RendererSortings.Add(new Unity.PolySpatial.VisionOSSortingGroup.RendererSorting
                    {
                        Order = tmp_RendererSorting.Order,
                        Renderer = tmp_RendererSorting.Renderer,
                        ApplyToDescendants = tmp_RendererSorting.ApplyToDescendants
                    });
                }

                sortingGroup.Renderers = tmp_RendererSortings;
            };

            DepthPass.Value = depthPass;
            Renderers.Value = renderers;
        }

        private void OnEnable()
        {
            if (sortingGroup)
                sortingGroup.enabled = true;
        }

        private void OnDisable()
        {
            if (sortingGroup)
                sortingGroup.enabled = false;
        }
#endif
    }
}