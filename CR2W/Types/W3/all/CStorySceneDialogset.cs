using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneDialogset : CSkeletalAnimationSet
{
#region RED Properties

[REDProp("requiredSfxTag")]
public CName RequiredSfxTag { get; set;}

[REDProp("animations")]
public Array<Ptr<CSkeletalAnimationSetEntry>> Animations { get; set;}

[REDProp("extAnimEvents")]
public Array<Handle<CExtAnimEventsFile>> ExtAnimEvents { get; set;}

[REDProp("skeleton")]
public Handle<CSkeleton> Skeleton { get; set;}

[REDProp("compressedPoses")]
public Array<Ptr<ICompressedPose>> CompressedPoses { get; set;}

[REDProp("dialogsetName")]
public CName DialogsetName { get; set;}

[REDProp("dialogsetTransitionEvent")]
public CName DialogsetTransitionEvent { get; set;}

[REDProp("isDynamic")]
public bool IsDynamic { get; set;}

[REDProp("characterTrajectories")]
public Array<EngineTransform> CharacterTrajectories { get; set;}

[REDProp("cameraTrajectories")]
public Array<EngineTransform> CameraTrajectories { get; set;}

[REDProp("personalCameras")]
public Array<SScenePersonalCameraDescription> PersonalCameras { get; set;}

[REDProp("masterCameras")]
public Array<SSceneMasterCameraDescription> MasterCameras { get; set;}

[REDProp("customCameras")]
public Array<SSceneCustomCameraDescription> CustomCameras { get; set;}

[REDProp("cameraEyePositions")]
public Array<Vector> CameraEyePositions { get; set;}

[REDProp("slots")]
public Array<Ptr<CStorySceneDialogsetSlot>> Slots { get; set;}

[REDProp("cameras")]
public Array<StorySceneCameraDefinition> Cameras { get; set;}

#endregion
}
}