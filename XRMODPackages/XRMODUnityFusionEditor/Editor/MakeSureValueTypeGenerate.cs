// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.IO;
using System.Text;
using Phantom.XRMOD.Core.Runtime;
using TMPro;
using Unity.AI.Navigation;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.U2D;
using UnityEngine.UI;
using UnityEngine.Video;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.Runtime.Editor
{
    public class MakeSureValueTypeGenerate : UnityEditor.Editor
    {
        static void Generate(Type _type)
        {
            var tmp_TempleTxt = AssetDatabase.LoadAssetAtPath<TextAsset>(
                "Packages/com.phantomsxr.unityfusion.editor/Editor/Assets/Temple.txt").text;
            tmp_TempleTxt = tmp_TempleTxt.Replace("#SCRIPT_NAME#", $"{_type.Name}Value");
            tmp_TempleTxt = tmp_TempleTxt.Replace("#VALUE_TYPE#", _type.Name);
            File.WriteAllText(
                $"Packages/com.phantomsxr.unityfusion/Runtime/Hooks/Runtime/MonoBehaviourBinder/MakeSureValueFactory/ArrayNGeneric/{_type.Name}Value.cs",
                tmp_TempleTxt);
        }

        static void GenerateFactory(Type[] _uTypes)
        {
            StringBuilder tmp_Builder = new StringBuilder();
            for (int tmp_Idx = 0; tmp_Idx < _uTypes.Length; tmp_Idx++)
            {
                tmp_Builder.Append($"                case {_uTypes[tmp_Idx].Name}:\n");
                tmp_Builder.Append(
                    $"                    new {_uTypes[tmp_Idx].Name}Value().MakeSureValue(ref _fieldInfo, _target, _value);\n");
                tmp_Builder.Append("                    break;\n");
            }

            var tmp_FactoryTxt = AssetDatabase.LoadAssetAtPath<TextAsset>(
                "Packages/com.phantomsxr.unityfusion.editor/Editor/Assets/Factory.txt").text;
            tmp_FactoryTxt = tmp_FactoryTxt.Replace("#INSERT#", tmp_Builder.ToString());
            File.WriteAllText(
                $"Packages/com.phantomsxr.unityfusion/Runtime/Hooks/Runtime/MonoBehaviourBinder/MakeSureValueFactory/MakeSureFactory.cs",
                tmp_FactoryTxt);
        }

        [MenuItem("Tools/UnityFusion/MonoBinder Type Generate")]
        static void StartProcess()
        {
            const string tmp_const_FolderPath =
                "Packages/com.phantomsxr.unityfusion/Runtime/Hooks/Runtime/MonoBehaviourBinder/MakeSureValueFactory/ArrayNGeneric";

            DirectoryInfo tmp_Directory = new DirectoryInfo(tmp_const_FolderPath);
            FileInfo[] tmp_Files = tmp_Directory.GetFiles();
            foreach (FileInfo tmp_File in tmp_Files)
            {
                tmp_File.Delete();
            }

            foreach (var tmp_Type in _UNITY_TYPES)
            {
                Generate(tmp_Type);
            }

            GenerateFactory(_UNITY_TYPES);

            AssetDatabase.Refresh();
        }


        static readonly Type[] _UNITY_TYPES = new[]
        {
            typeof(ParticleSystem),
            typeof(TrailRenderer),
            typeof(LineRenderer),
            typeof(Projector),
            typeof(LensFlare),
            typeof(ParticleSystemForceField),
            typeof(WindZone),
            typeof(CharacterController),
            typeof(BoxCollider),
            typeof(SphereCollider),
            typeof(CapsuleCollider),
            typeof(MeshCollider),
            typeof(TerrainCollider),
            typeof(WheelCollider),
            typeof(Collider),
            typeof(Rigidbody),
            typeof(ConstantForce),
            typeof(Cloth),
            typeof(FixedJoint),
            typeof(SpringJoint),
            typeof(HingeJoint),
            typeof(CharacterJoint),
            typeof(ConfigurableJoint),
            typeof(NavMeshAgent),
            typeof(NavMeshObstacle),
            typeof(NavMeshLink),
            typeof(NavMeshModifier),
            typeof(NavMeshModifierVolume),
            typeof(NavMeshSurface),
            typeof(AudioSource),
            typeof(AudioListener),
            typeof(AudioReverbFilter),
            typeof(AudioReverbZone),
            typeof(AudioLowPassFilter),
            typeof(AudioHighPassFilter),
            typeof(AudioEchoFilter),
            typeof(AudioDistortionFilter),
            typeof(AudioChorusFilter),
            typeof(VideoPlayer),
            typeof(Camera),
            typeof(Light),
            typeof(LightProbeGroup),
            typeof(LightProbeProxyVolume),
            typeof(ReflectionProbe),
            typeof(OcclusionArea),
            typeof(LODGroup),
            typeof(CanvasRenderer),
            typeof(SpriteRenderer),
            typeof(SortingGroup),
            typeof(Skybox),
            typeof(StreamingController),
            typeof(FlareLayer),
            typeof(RectTransform),
            typeof(Canvas),
            typeof(CanvasGroup),
            typeof(CanvasScaler),
            typeof(VerticalLayoutGroup),
            typeof(HorizontalLayoutGroup),
            typeof(GridLayoutGroup),
            typeof(LayoutElement),
            typeof(ContentSizeFitter),
            typeof(AspectRatioFitter),
            typeof(Text),
            typeof(Image),
            typeof(RawImage),
            typeof(Button),
            typeof(InputField),
            typeof(TextMeshProUGUI),
            typeof(TMP_InputField),
            typeof(Dropdown),
            typeof(TMP_Dropdown),
            typeof(Slider),
            typeof(Scrollbar),
            typeof(Toggle),
            typeof(ToggleGroup),
            typeof(Selectable),
            typeof(Outline),
            typeof(Shadow),
            typeof(Mask),
            typeof(RectMask2D),
            typeof(PositionAsUV1),
            typeof(Animator),
            typeof(PlayableDirector),
            typeof(Animation),
            typeof(Transform),
            typeof(Terrain),
            typeof(Volume),
            typeof(BillboardRenderer),
            typeof(SpriteShapeRenderer),
            typeof(Grid),
            typeof(PositionConstraint),
            typeof(RotationConstraint),
            typeof(ScaleConstraint),
            typeof(ParentConstraint),
            typeof(AimConstraint),
            typeof(LookAtConstraint),
            typeof(Texture2D),
            typeof(Shader),
            typeof(Sprite),
            typeof(Material),
            typeof(AnimationClip),
            typeof(Mesh),
            typeof(Color),
            typeof(VideoClip),
            typeof(AudioClip),
            typeof(ScriptableObject),
            typeof(Vector3),
            typeof(Vector2),
            typeof(Vector4),
            typeof(Quaternion),
            typeof(AnimationCurve),
            typeof(XRMODBehaviour),
            typeof(int),
            typeof(float),
            typeof(string),
            typeof(MeshFilter),
            typeof(MeshRenderer),
            typeof(TextMeshPro),
            typeof(TextMesh),
            typeof(GameObject),
            typeof(SkinnedMeshRenderer),
            typeof(Object),
        };
    }
}