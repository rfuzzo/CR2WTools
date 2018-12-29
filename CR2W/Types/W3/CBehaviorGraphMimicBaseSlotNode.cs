using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphMimicBaseSlotNode : CBehaviorGraphAnimationBaseSlotNode
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("activateNotification")]
public CName ActivateNotification { get; set;}

[REDProp("deactivateNotification")]
public CName DeactivateNotification { get; set;}

[REDProp("generateEditorFragments")]
public bool GenerateEditorFragments { get; set;}

[REDProp("id")]
public uint Id { get; set;}

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("loopPlayback")]
public bool LoopPlayback { get; set;}

[REDProp("playbackSpeed")]
public float PlaybackSpeed { get; set;}

[REDProp("applyMotion")]
public bool ApplyMotion { get; set;}

[REDProp("extractMotionTranslation")]
public bool ExtractMotionTranslation { get; set;}

[REDProp("extractMotionRotation")]
public bool ExtractMotionRotation { get; set;}

[REDProp("fireLoopEvent")]
public bool FireLoopEvent { get; set;}

[REDProp("loopEventName")]
public CName LoopEventName { get; set;}

[REDProp("useFovTrack")]
public bool UseFovTrack { get; set;}

[REDProp("useDofTrack")]
public bool UseDofTrack { get; set;}

[REDProp("gatherEvents")]
public bool GatherEvents { get; set;}

[REDProp("autoFireEffects")]
public bool AutoFireEffects { get; set;}

[REDProp("gatherSyncTokens")]
public bool GatherSyncTokens { get; set;}

[REDProp("cachedForceTimeNode")]
public Ptr<CBehaviorGraphValueNode> CachedForceTimeNode { get; set;}

[REDProp("cachedSpeedTimeNode")]
public Ptr<CBehaviorGraphValueNode> CachedSpeedTimeNode { get; set;}

[REDProp("cachedForcePropNode")]
public Ptr<CBehaviorGraphValueNode> CachedForcePropNode { get; set;}

[REDProp("slotName")]
public CName SlotName { get; set;}

[REDProp("animPrefix")]
public string AnimPrefix { get; set;}

[REDProp("animSufix")]
public string AnimSufix { get; set;}

#endregion
}
}