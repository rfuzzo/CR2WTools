using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphBlendOverrideNode : CBehaviorGraphNode
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

[REDProp("synchronize")]
public bool Synchronize { get; set;}

[REDProp("syncMethod")]
public Ptr<IBehaviorSyncMethod> SyncMethod { get; set;}

[REDProp("synchronizeInputFromParent")]
public bool SynchronizeInputFromParent { get; set;}

[REDProp("synchronizeOverrideFromParent")]
public bool SynchronizeOverrideFromParent { get; set;}

[REDProp("syncMethodFromParent")]
public Ptr<IBehaviorSyncMethod> SyncMethodFromParent { get; set;}

[REDProp("lodAtOrAboveLevel")]
public EBehaviorLod LodAtOrAboveLevel { get; set;}

/*[REDProp("Bones with weights")]
public Array<SBehaviorGraphBoneInfo> Bones with weights { get; set;}*/

[REDProp("alwaysActiveOverrideInput")]
public bool AlwaysActiveOverrideInput { get; set;}

[REDProp("getDeltaMotionFromOverride")]
public bool GetDeltaMotionFromOverride { get; set;}

[REDProp("cachedInputNode")]
public Ptr<CBehaviorGraphNode> CachedInputNode { get; set;}

[REDProp("cachedOverrideInputNode")]
public Ptr<CBehaviorGraphNode> CachedOverrideInputNode { get; set;}

[REDProp("cachedControlVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

#endregion
}
}