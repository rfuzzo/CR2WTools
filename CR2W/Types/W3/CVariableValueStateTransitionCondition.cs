using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CVariableValueStateTransitionCondition : IBehaviorStateTransitionCondition
{
#region RED Properties

[REDProp("compareValue")]
public float CompareValue { get; set;}

[REDProp("compareFunc")]
public ECompareFunc CompareFunc { get; set;}

[REDProp("socketName")]
public CName SocketName { get; set;}

[REDProp("useAbsoluteValue")]
public bool UseAbsoluteValue { get; set;}

[REDProp("cachedVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedVariableNode { get; set;}

#endregion
}
}