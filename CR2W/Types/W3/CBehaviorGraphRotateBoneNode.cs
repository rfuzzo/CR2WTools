using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphRotateBoneNode : CBehaviorGraphBaseNode
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

[REDProp("boneName")]
public string BoneName { get; set;}

[REDProp("axis")]
public EBoneRotationAxis Axis { get; set;}

[REDProp("scale")]
public float Scale { get; set;}

[REDProp("biasAngle")]
public float BiasAngle { get; set;}

[REDProp("minAngle")]
public float MinAngle { get; set;}

[REDProp("maxAngle")]
public float MaxAngle { get; set;}

[REDProp("clampRotation")]
public bool ClampRotation { get; set;}

[REDProp("localSpace")]
public bool LocalSpace { get; set;}

[REDProp("cachedControlVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

[REDProp("cachedAngleMinNode")]
public Ptr<CBehaviorGraphValueNode> CachedAngleMinNode { get; set;}

[REDProp("cachedAngleMaxNode")]
public Ptr<CBehaviorGraphValueNode> CachedAngleMaxNode { get; set;}

#endregion
}
}