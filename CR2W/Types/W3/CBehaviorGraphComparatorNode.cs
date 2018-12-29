using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphComparatorNode : CBehaviorGraphValueNode
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

[REDProp("operation")]
public ECompareFunc Operation { get; set;}

[REDProp("firstValue")]
public float FirstValue { get; set;}

[REDProp("secondValue")]
public float SecondValue { get; set;}

[REDProp("trueValue")]
public float TrueValue { get; set;}

[REDProp("falseValue")]
public float FalseValue { get; set;}

[REDProp("cachedFirstInputNode")]
public Ptr<CBehaviorGraphValueNode> CachedFirstInputNode { get; set;}

[REDProp("cachedSecondInputNode")]
public Ptr<CBehaviorGraphValueNode> CachedSecondInputNode { get; set;}

[REDProp("cachedTrueInputNode")]
public Ptr<CBehaviorGraphValueNode> CachedTrueInputNode { get; set;}

[REDProp("cachedFalseInputNode")]
public Ptr<CBehaviorGraphValueNode> CachedFalseInputNode { get; set;}

#endregion
}
}