using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphIk3Node : CBehaviorGraphBaseNode
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

[REDProp("cachedValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

[REDProp("cachedTargetPosNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedTargetPosNode { get; set;}

[REDProp("firstBone")]
public string FirstBone { get; set;}

[REDProp("secondBone")]
public string SecondBone { get; set;}

[REDProp("thirdBone")]
public string ThirdBone { get; set;}

[REDProp("endBone")]
public string EndBone { get; set;}

[REDProp("hingeAxis")]
public EAxis HingeAxis { get; set;}

#endregion
}
}