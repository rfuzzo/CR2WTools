using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphMimicLookAtSystemNode : CBehaviorGraphBaseMimicNode
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

[REDProp("cachedTargetNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedTargetNode { get; set;}

[REDProp("cachedControlVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

[REDProp("cachedLevelVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedLevelVariableNode { get; set;}

[REDProp("eyeHorLeftTrack")]
public string EyeHorLeftTrack { get; set;}

[REDProp("eyeVerLeftTrack")]
public string EyeVerLeftTrack { get; set;}

[REDProp("eyeHorRightTrack")]
public string EyeHorRightTrack { get; set;}

[REDProp("eyeVerRightTrack")]
public string EyeVerRightTrack { get; set;}

[REDProp("eyeLeftPlacerBone")]
public string EyeLeftPlacerBone { get; set;}

[REDProp("eyeRightPlacerBone")]
public string EyeRightPlacerBone { get; set;}

[REDProp("eyeHorMax")]
public float EyeHorMax { get; set;}

[REDProp("eyeVerMax")]
public float EyeVerMax { get; set;}

[REDProp("dampTime")]
public float DampTime { get; set;}

[REDProp("dampCurve")]
public Ptr<CCurve> DampCurve { get; set;}

#endregion
}
}