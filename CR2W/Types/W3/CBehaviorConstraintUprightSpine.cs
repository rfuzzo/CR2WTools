using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorConstraintUprightSpine : CBehaviorGraphPoseConstraintNode
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

[REDProp("cachedControlValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

[REDProp("bones")]
public SBehaviorConstraintUprightSpineBonesData Bones { get; set;}

[REDProp("leftHandIK")]
public STwoBonesIKSolverData LeftHandIK { get; set;}

[REDProp("rightHandIK")]
public STwoBonesIKSolverData RightHandIK { get; set;}

[REDProp("matchEntityFullSpeed")]
public float MatchEntityFullSpeed { get; set;}

#endregion
}
}