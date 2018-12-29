using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphConstraintNodeCameraFocus : CBehaviorGraphConstraintNode
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

[REDProp("useDampCurve")]
public bool UseDampCurve { get; set;}

[REDProp("dampCurve")]
public Ptr<CCurve> DampCurve { get; set;}

[REDProp("dampTimeAxisScale")]
public float DampTimeAxisScale { get; set;}

[REDProp("dampTimeSpeed")]
public float DampTimeSpeed { get; set;}

[REDProp("useFollowCurve")]
public bool UseFollowCurve { get; set;}

[REDProp("followCurve")]
public Ptr<CCurve> FollowCurve { get; set;}

[REDProp("followTimeAxisScale")]
public float FollowTimeAxisScale { get; set;}

[REDProp("followTimeSpeed")]
public float FollowTimeSpeed { get; set;}

[REDProp("targetObject")]
public Ptr<IBehaviorConstraintObject> TargetObject { get; set;}

[REDProp("dampType")]
public EBehaviorConstraintDampType DampType { get; set;}

[REDProp("cachedInputNode")]
public Ptr<CBehaviorGraphNode> CachedInputNode { get; set;}

[REDProp("cachedControlValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

[REDProp("cachedDurationValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedDurationValueNode { get; set;}

[REDProp("cachedDurationFollowValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedDurationFollowValueNode { get; set;}

[REDProp("cachedSpeedFollowValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedSpeedFollowValueNode { get; set;}

[REDProp("cachedSpeedDampValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedSpeedDampValueNode { get; set;}

[REDProp("bone")]
public string Bone { get; set;}

[REDProp("bone2")]
public string Bone2 { get; set;}

#endregion
}
}