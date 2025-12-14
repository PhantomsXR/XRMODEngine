using System;
using System.Collections.Generic; 
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class PropertiesRenderer : IMGUIContainer
    {
        private Rect drawArea;
        private Vector2 scrollViewPosition;
        private AlgorithmType currentAlgorithmType;

        //Only Editor,For Avoid duplication
        private Dictionary<string, AbstractBlock> blockSubViewDict;

        private ProjectDetailCacheData editingDetailData;
        private const string CONST_SCRIPT_NAME_SPACE = "Phantom.XRMOD.XRMODPackageTools.Editor.";

        private readonly List<string> menuList = new List<string>
        {
            "Algorithm",
            "Version Checker",
            "Programmable",
            "Space Type",
            "Visualizer/Plane",
            "Visualizer/Point Cloud",
            "Features/XRWorld Scale",
            "Features/iOS/Coaching Overlay(iOS Only)",
            "Features/Environment Probe",
            "Features/Light Estimation",
            "Features/Post Processing",
            "Features/AR Interaction",
            "Features/Immersal",
            "Features/Face Mesh",
            "Features/Occlusion",
            "Graphics/Quality Level",
            "Features/Multiplayer",
            "Visualizer/Mesh",
            //"Features/MediaRecorder",
        };

        private readonly List<string> blocks = new List<string>
        {
            nameof(VersionBlock),
            nameof(AlgorithmBlock),
            nameof(ProgrammableBlock),
            nameof(SpaceTypeBlock),
            nameof(PlaneVisualizerBlock),
            nameof(PointCloudVisualizerBlock),
            nameof(XRWorldScaleBlock),
            nameof(CoachingOverlayBlock),
            nameof(EnvironmentProbeBlock),
            nameof(LightEstimationBlock),
            nameof(PostProcessingBlock),
            nameof(ARInteractionBlock),
            nameof(ImmersalBlock),
            nameof(FaceMeshBlock),
            nameof(OcclusionBlock),
            nameof(QualityBlock),
            nameof(MultiplayerBlock),
            nameof(MeshVisualizerBlock)
            //nameof(MediaRecorderBlock),
        };

        public void Initialization()
        { 
            editingDetailData = PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData().DetailCacheData;
            if (editingDetailData.GetBlock == null) return;
            blockSubViewDict = new Dictionary<string, AbstractBlock>();

            //Add dfault block
            var tmp_FullPathOfAlgorithmBlock = typeof(AlgorithmBlock).FullName;
            var tmp_FullPathOfVersionCheckerBlock = typeof(VersionBlock).FullName;
            var tmp_FullPathOfProgrammableBlock = typeof(ProgrammableBlock).FullName;

            if (!editingDetailData.GetBlock.Contains(tmp_FullPathOfAlgorithmBlock))
            {
                ConvertToBlock(tmp_FullPathOfAlgorithmBlock);
            }

            if (!editingDetailData.GetBlock.Contains(tmp_FullPathOfVersionCheckerBlock))
            {
                ConvertToBlock(tmp_FullPathOfVersionCheckerBlock);
            }

            var tmp_FullPathOfARWorldScaleBlock = typeof(XRWorldScaleBlock).FullName;
            if (!editingDetailData.GetBlock.Contains(tmp_FullPathOfARWorldScaleBlock))
            {
                ConvertToBlock(tmp_FullPathOfARWorldScaleBlock);
            }

            var tmp_FullPathOfSpaceTypeBlock = typeof(SpaceTypeBlock).FullName;
            if (!editingDetailData.GetBlock.Contains(tmp_FullPathOfSpaceTypeBlock))
            {
                ConvertToBlock(tmp_FullPathOfSpaceTypeBlock);
            }

            if (!editingDetailData.GetBlock.Contains(tmp_FullPathOfProgrammableBlock))
            {
                ConvertToBlock(tmp_FullPathOfProgrammableBlock);
            }


            currentAlgorithmType = editingDetailData.Configures.Algorithm;
            MappingBlock();

            onGUIHandler = () =>
            {
                drawArea = new Rect(contentRect.x, contentRect.y, contentRect.width, layout.height);
                DrawConfigure();
            };
        }


        private void MappingBlock()
        {
            List<string> tmp_UselessBlocks = new List<string>();
            foreach (var tmp_Block in editingDetailData.GetBlock)
            {
                Type tmp_Type = Type.GetType(tmp_Block);
                if (tmp_Type == null)
                {
                    tmp_UselessBlocks.Add(tmp_Block);
                    continue;
                }

                object tmp_Instance =
                    // ReSharper disable once PossiblyMistakenUseOfParamsMethod
                    Activator.CreateInstance(type: tmp_Type, args: editingDetailData.Configures);
                AddBlock(tmp_Instance as AbstractBlock);
            }

            foreach (string tmp_UselessBlock in tmp_UselessBlocks)
            {
                editingDetailData.RemoveBlockElement(tmp_UselessBlock);
            }

            tmp_UselessBlocks.Clear();
        }

        private bool AddBlock(AbstractBlock _abstractBlock)
        {
            var tmp_UniqueId = _abstractBlock.GetType().FullName;
            bool tmp_AlreadyExists =
                blockSubViewDict.TryGetValue(tmp_UniqueId ?? throw new Exception(), out AbstractBlock _);
            if (!tmp_AlreadyExists)
                blockSubViewDict.Add(tmp_UniqueId, _abstractBlock);

            return !tmp_AlreadyExists;
        }


        private void RemoveBlock(string _abstractBlock)
        {
            try
            {
                if (blockSubViewDict.TryGetValue(_abstractBlock, out AbstractBlock tmp_AbstractBlock))
                {
                    switch (editingDetailData.Configures.Algorithm)
                    {
#if HANDHELD_ARMODULE_INSTALL || ROKID_INSTALL
                        case AlgorithmType.Immersal:
                            if (tmp_AbstractBlock.GetType() == typeof(ImmersalBlock))
                                throw new Exception();
                            break;
#endif

#if HANDHELD_ARMODULE_INSTALL
                        case AlgorithmType.FaceMesh:
                            if (tmp_AbstractBlock.GetType() == typeof(FaceMeshBlock))
                                throw new Exception();
                            break;
#endif
                    }

                    if (tmp_AbstractBlock.GetType() == typeof(AlgorithmBlock)
                        || tmp_AbstractBlock.GetType() == typeof(VersionBlock)
                        || tmp_AbstractBlock.GetType() == typeof(XRWorldScaleBlock))
                        throw new Exception("Can not removing");

                    tmp_AbstractBlock.OnRemoved();
                    RemoveBlockCol(tmp_AbstractBlock);
                    blockSubViewDict.Remove(_abstractBlock);
                }
            }
            catch (Exception tmp_Exception)
            {
                EditorUtility.DisplayDialog("Error!", "You can not remove this property block!", "Ok");
            }
        }


        private void CachingBlockCol(AbstractBlock _abstractBlock)
        {
            string tmp_BlockName = _abstractBlock.GetType().FullName;
            if (!editingDetailData.GetBlock.Contains(tmp_BlockName))
                editingDetailData.AddBlockElement(tmp_BlockName);
        }

        private void RemoveBlockCol(AbstractBlock _abstractBlock)
        {
            editingDetailData.RemoveBlockElement(_abstractBlock.GetType().FullName);
        }


        private void DrawConfigure()
        {
            CheckDependentBlock();

            scrollViewPosition = EditorGUILayout.BeginScrollView(scrollViewPosition);

            //Draw and add remove button for this block
            foreach (var tmp_Block in editingDetailData.GetBlock)
            {
                if (!blockSubViewDict.TryGetValue(tmp_Block, out AbstractBlock tmp_AbstractBlock)) continue;
                var tmp_Area = tmp_AbstractBlock.DrawBlock(drawArea);
                if (!Utility.RightClicked(tmp_Area)) continue;

                var tmp_Menu = new GenericMenu();
                tmp_Menu.AddItem(new GUIContent("Remove"), false,
                    () => { RemoveBlock(tmp_Block); });
                tmp_Menu.ShowAsContext();
                EditorGUILayout.EndScrollView();
                return;
            }


            GUILayout.Space(20);

            //Paint only when the number of blocks is 1
            if (editingDetailData.GetBlock.Count <= 1)
            {
                EditorGUILayout.BeginVertical();
                GUILayout.FlexibleSpace();
                GUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                EditorGUILayout.HelpBox(" Right-click to add configuration options ", MessageType.Info);
                GUILayout.FlexibleSpace();
                GUILayout.EndHorizontal();
                GUILayout.FlexibleSpace();
                EditorGUILayout.EndVertical();
            }

            EditorGUILayout.EndScrollView();
            if (!Utility.RightClicked(drawArea)) return;
            RightClickedMenu();
        }

        private void CheckDependentBlock()
        {
            if (currentAlgorithmType == editingDetailData.Configures.Algorithm) return;
            currentAlgorithmType = editingDetailData.Configures.Algorithm;

            switch (currentAlgorithmType)
            {
#if HANDHELD_ARMODULE_INSTALL
                case AlgorithmType.FocusSlam:
#endif
                case AlgorithmType.Anchor:
                {
                    var tmp_BlockFullName = typeof(PlaneVisualizerBlock).FullName;
                    if (!editingDetailData.GetBlock.Contains(tmp_BlockFullName))
                        ConvertToBlock(tmp_BlockFullName);

                    var tmp_MeshVisualizerBlockFullName = typeof(MeshVisualizerBlock).FullName;
                    if (editingDetailData.GetBlock.Contains(tmp_MeshVisualizerBlockFullName))
                    {
                        RemoveBlock(tmp_MeshVisualizerBlockFullName);
                    }

                    break;
                }
#if HANDHELD_ARMODULE_INSTALL || QUEST_INSTALL || VISIONOS_INSTALL
                case AlgorithmType.Meshing:
                {
                    var tmp_BlockFullName = typeof(MeshVisualizerBlock).FullName;
                    if (!editingDetailData.GetBlock.Contains(tmp_BlockFullName))
                        ConvertToBlock(tmp_BlockFullName);

                    var tmp_PlaneVisualizerBlockFullName = typeof(PlaneVisualizerBlock).FullName;
                    if (editingDetailData.GetBlock.Contains(tmp_PlaneVisualizerBlockFullName))
                    {
                        RemoveBlock(tmp_PlaneVisualizerBlockFullName);
                    }

                    break;
                }
#endif
                default:
                {
                    var tmp_BlockFullName = typeof(PlaneVisualizerBlock).FullName;
                    if (editingDetailData.GetBlock.Contains(tmp_BlockFullName))
                    {
                        RemoveBlock(tmp_BlockFullName);
                    }

                    break;
                }
            }

#if HANDHELD_ARMODULE_INSTALL || ROKID_INSTALL
            //Remove immersal block when algorithm is not immersal
            if (editingDetailData.Configures.Algorithm != AlgorithmType.Immersal)
            {
                var tmp_BlockFullName = typeof(ImmersalBlock).FullName;
                if (editingDetailData.GetBlock.Contains(tmp_BlockFullName))
                {
                    RemoveBlock(tmp_BlockFullName);
                }
            }

            // algorithm is immersal it will add automatic
            if (editingDetailData.Configures.Algorithm == AlgorithmType.Immersal)
            {
                var tmp_BlockFullName = typeof(ImmersalBlock).FullName;
                if (!editingDetailData.GetBlock.Contains(tmp_BlockFullName))
                    ConvertToBlock(tmp_BlockFullName);
            }

#endif
#if HANDHELD_ARMODULE_INSTALL
            if (editingDetailData.Configures.Algorithm != AlgorithmType.FaceMesh)
            {
                var tmp_BlockFullName = typeof(FaceMeshBlock).FullName;
                if (editingDetailData.GetBlock.Contains(tmp_BlockFullName))
                {
                    RemoveBlock(tmp_BlockFullName);
                }
            }

            if (editingDetailData.Configures.Algorithm == AlgorithmType.FaceMesh)
            {
                var tmp_BlockFullName = typeof(FaceMeshBlock).FullName;
                if (!editingDetailData.GetBlock.Contains(tmp_BlockFullName))
                    ConvertToBlock(tmp_BlockFullName);
            }
#endif
        }

        private void RightClickedMenu()
        {
            var tmp_MenuContext = new GenericMenu();
            for (int tmp_MenuIdx = 0; tmp_MenuIdx < menuList.Count; tmp_MenuIdx++)
            {
                var tmp_Idx = tmp_MenuIdx;
                tmp_MenuContext.AddItem(new GUIContent(menuList[tmp_MenuIdx]), false,
                    () => ConvertToBlock($"{CONST_SCRIPT_NAME_SPACE}{blocks[tmp_Idx]}"));
            }

            tmp_MenuContext.ShowAsContext();
        }


        /// <summary>
        /// Use the name of the block to convert the corresponding block object.
        /// </summary>
        /// <param name="_blockType">name of the block</param>
        private void ConvertToBlock(string _blockType)
        {
            var tmp_Block = BlockFactory.CreateBlock(_blockType, editingDetailData.Configures);
            if (AddBlock(tmp_Block))
            {
                CachingBlockCol(tmp_Block);
            }
            else
            {
                EditorUtility.DisplayDialog("Error!", "The block already exists, please do not add it repeatedly.",
                    "Ok");
            }
        }

        protected override void Dispose(bool disposeManaged)
        {
            base.Dispose(disposeManaged);
            EditorUtility.SetDirty(editingDetailData.Configures);
        }
    }
}