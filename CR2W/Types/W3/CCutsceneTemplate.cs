using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CCutsceneTemplate : CSkeletalAnimationSet
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

/*[REDProp("Streaming option")]
public SAnimationBufferStreamingOption Streaming option { get; set;}

[REDProp("Number of non-streamable bones")]
public uint Number of non-streamable bones { get; set;}*/

[REDProp("modifiers")]
public Array<Ptr<ICutsceneModifier>> Modifiers { get; set;}

[REDProp("point")]
public TagList Point { get; set;}

[REDProp("lastLevelLoaded")]
public string LastLevelLoaded { get; set;}

[REDProp("actorsDef")]
public Array<SCutsceneActorDef> ActorsDef { get; set;}

[REDProp("isValid")]
public bool IsValid { get; set;}

[REDProp("fadeBefore")]
public float FadeBefore { get; set;}

[REDProp("fadeAfter")]
public float FadeAfter { get; set;}

[REDProp("cameraBlendInTime")]
public float CameraBlendInTime { get; set;}

[REDProp("cameraBlendOutTime")]
public float CameraBlendOutTime { get; set;}

[REDProp("blackscreenWhenLoading")]
public bool BlackscreenWhenLoading { get; set;}

[REDProp("checkActorsPosition")]
public bool CheckActorsPosition { get; set;}

[REDProp("entToHideTags")]
public Array<CName> EntToHideTags { get; set;}

[REDProp("usedInFiles")]
public Array<string> UsedInFiles { get; set;}

[REDProp("resourcesToPreloadManuallyPaths")]
public Array<string> ResourcesToPreloadManuallyPaths { get; set;}

[REDProp("reverbName")]
public string ReverbName { get; set;}

[REDProp("burnedAudioTrackName")]
public StringAnsi BurnedAudioTrackName { get; set;}

[REDProp("banksDependency")]
public Array<CName> BanksDependency { get; set;}

[REDProp("streamable")]
public bool Streamable { get; set;}

[REDProp("effects")]
public Array<Ptr<CFXDefinition>> Effects { get; set;}

#endregion
}
}