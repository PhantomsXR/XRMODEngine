// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using Phantom.XRMOD.Core.Runtime;
using TMPro;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.U2D;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityFusion.CLRBinding.Adapter;
using UnityFusion.Reflection;
using UnityFusion.Runtime.Intepreter;

// ReSharper disable HeuristicUnreachableCode

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public static class MakeSureValueFactory
    {
        public static bool MakeSureValue(ref FieldInfo _fieldInfo, object _target, object _value)
        {
            bool tmp_IsListLike = false;
            if (_fieldInfo.FieldType is UnityFusionType tmp_FusionType)
            {
                if (tmp_FusionType.IsArray || tmp_FusionType.GetInterfaces().Contains(typeof(IList)))
                {
                    tmp_IsListLike = true;
                }
            }
            else
            {
                tmp_IsListLike = typeof(IList).IsAssignableFrom(_fieldInfo.FieldType);
            }

            // Generic
            if (!tmp_IsListLike || _value is not Array tmp_Array)
            {
                return new MakeSureGenericValue().MakeSureValue(ref _fieldInfo, _target, _value);
            }

            // Array
            Type tmp_FieldElementType = tmp_Array.GetType().GetElementType();
            if (tmp_FieldElementType == null) return true;
            switch (tmp_FieldElementType.Name)
            {
                case nameof(ParticleSystem):
                    new ParticleSystemValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(TrailRenderer):
                    new TrailRendererValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(LineRenderer):
                    new LineRendererValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Projector):
                    new ProjectorValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(LensFlare):
                    new LensFlareValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(ParticleSystemForceField):
                    new ParticleSystemForceFieldValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(WindZone):
                    new WindZoneValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(CharacterController):
                    new CharacterControllerValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(BoxCollider):
                    new BoxColliderValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(SphereCollider):
                    new SphereColliderValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(CapsuleCollider):
                    new CapsuleColliderValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(MeshCollider):
                    new MeshColliderValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(TerrainCollider):
                    new TerrainColliderValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(WheelCollider):
                    new WheelColliderValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Collider):
                    new ColliderValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Rigidbody):
                    new RigidbodyValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(ConstantForce):
                    new ConstantForceValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Cloth):
                    new ClothValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(FixedJoint):
                    new FixedJointValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(SpringJoint):
                    new SpringJointValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(HingeJoint):
                    new HingeJointValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(CharacterJoint):
                    new CharacterJointValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(ConfigurableJoint):
                    new ConfigurableJointValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(NavMeshAgent):
                    new NavMeshAgentValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(NavMeshObstacle):
                    new NavMeshObstacleValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(NavMeshLink):
                    new NavMeshLinkValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(NavMeshModifier):
                    new NavMeshModifierValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(NavMeshModifierVolume):
                    new NavMeshModifierVolumeValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(NavMeshSurface):
                    new NavMeshSurfaceValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(AudioSource):
                    new AudioSourceValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(AudioListener):
                    new AudioListenerValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(AudioReverbFilter):
                    new AudioReverbFilterValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(AudioReverbZone):
                    new AudioReverbZoneValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(AudioLowPassFilter):
                    new AudioLowPassFilterValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(AudioHighPassFilter):
                    new AudioHighPassFilterValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(AudioEchoFilter):
                    new AudioEchoFilterValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(AudioDistortionFilter):
                    new AudioDistortionFilterValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(AudioChorusFilter):
                    new AudioChorusFilterValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(VideoPlayer):
                    new VideoPlayerValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Camera):
                    new CameraValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Light):
                    new LightValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(LightProbeGroup):
                    new LightProbeGroupValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(LightProbeProxyVolume):
                    new LightProbeProxyVolumeValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(ReflectionProbe):
                    new ReflectionProbeValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(OcclusionArea):
                    new OcclusionAreaValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(LODGroup):
                    new LODGroupValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(CanvasRenderer):
                    new CanvasRendererValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(SpriteRenderer):
                    new SpriteRendererValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(SortingGroup):
                    new SortingGroupValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Skybox):
                    new SkyboxValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(StreamingController):
                    new StreamingControllerValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(FlareLayer):
                    new FlareLayerValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(RectTransform):
                    new RectTransformValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Canvas):
                    new CanvasValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(CanvasGroup):
                    new CanvasGroupValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(CanvasScaler):
                    new CanvasScalerValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(VerticalLayoutGroup):
                    new VerticalLayoutGroupValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(HorizontalLayoutGroup):
                    new HorizontalLayoutGroupValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(GridLayoutGroup):
                    new GridLayoutGroupValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(LayoutElement):
                    new LayoutElementValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(ContentSizeFitter):
                    new ContentSizeFitterValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(AspectRatioFitter):
                    new AspectRatioFitterValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Text):
                    new TextValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Image):
                    new ImageValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(RawImage):
                    new RawImageValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Button):
                    new ButtonValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(InputField):
                    new InputFieldValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(TextMeshProUGUI):
                    new TextMeshProUGUIValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(TMP_InputField):
                    new TMP_InputFieldValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Dropdown):
                    new DropdownValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(TMP_Dropdown):
                    new TMP_DropdownValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Slider):
                    new SliderValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Scrollbar):
                    new ScrollbarValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Toggle):
                    new ToggleValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(ToggleGroup):
                    new ToggleGroupValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Selectable):
                    new SelectableValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Outline):
                    new OutlineValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Shadow):
                    new ShadowValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Mask):
                    new MaskValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(RectMask2D):
                    new RectMask2DValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(PositionAsUV1):
                    new PositionAsUV1Value().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Animator):
                    new AnimatorValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(PlayableDirector):
                    new PlayableDirectorValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Animation):
                    new AnimationValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Transform):
                    new TransformValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Terrain):
                    new TerrainValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Volume):
                    new VolumeValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(BillboardRenderer):
                    new BillboardRendererValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(SpriteShapeRenderer):
                    new SpriteShapeRendererValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Grid):
                    new GridValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(PositionConstraint):
                    new PositionConstraintValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(RotationConstraint):
                    new RotationConstraintValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(ScaleConstraint):
                    new ScaleConstraintValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(ParentConstraint):
                    new ParentConstraintValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(AimConstraint):
                    new AimConstraintValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(LookAtConstraint):
                    new LookAtConstraintValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Texture2D):
                    new Texture2DValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Shader):
                    new ShaderValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Sprite):
                    new SpriteValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Material):
                    new MaterialValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(AnimationClip):
                    new AnimationClipValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Mesh):
                    new MeshValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Color):
                    new ColorValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(VideoClip):
                    new VideoClipValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(AudioClip):
                    new AudioClipValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(ScriptableObject):
                    new ScriptableObjectValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Vector3):
                    new Vector3Value().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Vector2):
                    new Vector2Value().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Vector4):
                    new Vector4Value().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Quaternion):
                    new QuaternionValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(AnimationCurve):
                    new AnimationCurveValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(XRMODBehaviour):
                    new XRMODBehaviourValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(MonoBehaviour):
                    new MonoBehaviourValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Int32):
                    new Int32Value().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(Single):
                    new SingleValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(String):
                    new StringValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(MeshFilter):
                    new MeshFilterValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(MeshRenderer):
                    new MeshRendererValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(TextMeshPro):
                    new TextMeshProValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(TextMesh):
                    new TextMeshValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(GameObject):
                    new GameObjectValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(SkinnedMeshRenderer):
                    new SkinnedMeshRendererValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(UnityEngine.Object):
                    new ObjectValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
                case nameof(ILTypeInstance):
                    new ILTypeInstanceXRMODBehaviourAdapterValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;

#if USE_AUDIO_MODULE
                case nameof(Phantom.XRMOD.AudioModule.Runtime.AudioEmitter):
                    new AudioEmitterValue().MakeSureValue(ref _fieldInfo, _target, _value);
                    break;
#endif
            }

            return true;
        }
    }
}