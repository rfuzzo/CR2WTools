using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphLookAtSystemNode : CBehaviorGraphConstraintNode
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

[REDProp("cachedLevelVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedLevelVariableNode { get; set;}

[REDProp("cachedWeightsVariableNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedWeightsVariableNode { get; set;}

[REDProp("cachedLimitVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedLimitVariableNode { get; set;}

[REDProp("cachedCompressedDataVariableNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedCompressedDataVariableNode { get; set;}

[REDProp("firstBone")]
public string FirstBone { get; set;}

[REDProp("secondBone")]
public string SecondBone { get; set;}

[REDProp("thirdBone")]
public string ThirdBone { get; set;}

[REDProp("localOffset")]
public Vector LocalOffset { get; set;}

[REDProp("deadZone")]
public float DeadZone { get; set;}

[REDProp("deadZoneDist")]
public float DeadZoneDist { get; set;}

[REDProp("limitDampTime")]
public float LimitDampTime { get; set;}

[REDProp("levelDampTime")]
public float LevelDampTime { get; set;}

[REDProp("internalDampCurve")]
public Ptr<CCurve> InternalDampCurve { get; set;}

[REDProp("dampForFirstTarget")]
public float DampForFirstTarget { get; set;}

[REDProp("range")]
public float Range { get; set;}

[REDProp("firstWeight")]
public float FirstWeight { get; set;}

[REDProp("secondWeight")]
public float SecondWeight { get; set;}

[REDProp("thirdWeight")]
public float ThirdWeight { get; set;}

#endregion
}
}