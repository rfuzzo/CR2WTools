using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphAnimatedRagdollNode : CBehaviorGraphValueNode
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

[REDProp("chanceToGoToRagdoll")]
public float ChanceToGoToRagdoll { get; set;}

[REDProp("stateBlendTime")]
public float StateBlendTime { get; set;}

[REDProp("maxFlightTime")]
public Vector2 MaxFlightTime { get; set;}

[REDProp("initialVelocityBoostZ")]
public Vector2 InitialVelocityBoostZ { get; set;}

[REDProp("gravity")]
public float Gravity { get; set;}

[REDProp("topVerticalVelocity")]
public float TopVerticalVelocity { get; set;}

[REDProp("switchAnimatedRagdollToRagdollEvent")]
public CName SwitchAnimatedRagdollToRagdollEvent { get; set;}

[REDProp("poseRotateIK")]
public SApplyRotationIKSolverData PoseRotateIK { get; set;}

[REDProp("dirIndices")]
public Array<SBehaviorGraphAnimatedRagdollDirDefinition> DirIndices { get; set;}

[REDProp("cachedNodes")]
public Array<Ptr<CBehaviorGraphNode>> CachedNodes { get; set;}

#endregion
}
}