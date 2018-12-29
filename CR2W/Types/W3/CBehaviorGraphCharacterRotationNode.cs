using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphCharacterRotationNode : CBehaviorGraphBaseNode
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

[REDProp("axis")]
public Vector Axis { get; set;}

[REDProp("rotationSpeedMultiplier")]
public float RotationSpeedMultiplier { get; set;}

[REDProp("cachedControlVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

[REDProp("cachedBiasVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedBiasVariableNode { get; set;}

[REDProp("cachedAngleVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedAngleVariableNode { get; set;}

[REDProp("cachedMaxAngleVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedMaxAngleVariableNode { get; set;}

#endregion
}
}