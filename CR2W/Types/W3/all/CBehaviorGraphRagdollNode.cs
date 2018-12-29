using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphRagdollNode : CBehaviorGraphBaseNode
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

[REDProp("cachedInputNode")]
public Ptr<CBehaviorGraphNode> CachedInputNode { get; set;}

[REDProp("allowToProvidePreRagdollPose")]
public bool AllowToProvidePreRagdollPose { get; set;}

[REDProp("updateAndSampleInputIfPreRagdollWeightIsNonZero")]
public bool UpdateAndSampleInputIfPreRagdollWeightIsNonZero { get; set;}

[REDProp("keepInFrozenRagdollPose")]
public bool KeepInFrozenRagdollPose { get; set;}

[REDProp("switchToSwimming")]
public bool SwitchToSwimming { get; set;}

[REDProp("cachedControlVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

[REDProp("cachedRootBoneImpulseVariable")]
public Ptr<CBehaviorGraphVectorValueNode> CachedRootBoneImpulseVariable { get; set;}

#endregion
}
}