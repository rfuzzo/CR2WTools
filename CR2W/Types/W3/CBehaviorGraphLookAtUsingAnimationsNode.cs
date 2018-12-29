using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphLookAtUsingAnimationsNode : CBehaviorGraphLookAtUsingAnimationsCommonBaseNode
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

/*[REDProp("Bone name")]
public CName Bone name { get; set;}

[REDProp("Use char. rotation")]
public bool Use char. rotation { get; set;}

[REDProp("Angle limit")]
public Vector2 Angle limit { get; set;}

[REDProp("Animation angle range")]
public Vector2 Animation angle range { get; set;}

[REDProp("Angle to stop looking")]
public float Angle to stop looking { get; set;}

[REDProp("Max 'Look at' speed")]
public float Max 'Look at' speed { get; set;}

[REDProp("'Look at' blend time")]
public float 'Look at' blend time { get; set;}

[REDProp("On//Off blend time")]
public float On//Off blend time { get; set;}*/

[REDProp("cachedInputNode")]
public Ptr<CBehaviorGraphNode> CachedInputNode { get; set;}

[REDProp("cachedLookAtVariableNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedLookAtVariableNode { get; set;}

[REDProp("cachedControlVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

[REDProp("cachedLookAtBlendTimeNode")]
public Ptr<CBehaviorGraphValueNode> CachedLookAtBlendTimeNode { get; set;}

/*[REDProp("Additive blend type")]
public EAdditiveType Additive blend type { get; set;}

[REDProp("Horizontal blend is first")]
public bool Horizontal blend is first { get; set;}

[REDProp("Alternative additive mapping")]
public bool Alternative additive mapping { get; set;}*/

[REDProp("cachedVerticalAdditiveInputNode")]
public Ptr<CBehaviorGraphNode> CachedVerticalAdditiveInputNode { get; set;}

[REDProp("cachedHorizontalAdditiveInputNode")]
public Ptr<CBehaviorGraphNode> CachedHorizontalAdditiveInputNode { get; set;}

#endregion
}
}