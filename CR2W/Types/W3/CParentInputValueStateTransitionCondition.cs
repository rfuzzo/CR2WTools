using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CParentInputValueStateTransitionCondition : IBehaviorStateTransitionCondition
{
#region RED Properties

[REDProp("parentValueName")]
public CName ParentValueName { get; set;}

[REDProp("compareFunc")]
public ECompareFunc CompareFunc { get; set;}

[REDProp("compareParentInputName")]
public CName CompareParentInputName { get; set;}

[REDProp("socketName")]
public CName SocketName { get; set;}

[REDProp("compareValue")]
public float CompareValue { get; set;}

[REDProp("useAbsoluteValue")]
public bool UseAbsoluteValue { get; set;}

[REDProp("epsilon")]
public float Epsilon { get; set;}

[REDProp("cachedParentInput")]
public Ptr<CBehaviorGraphValueNode> CachedParentInput { get; set;}

[REDProp("cachedCompareParentInput")]
public Ptr<CBehaviorGraphValueNode> CachedCompareParentInput { get; set;}

[REDProp("cachedTestedValue")]
public Ptr<CBehaviorGraphValueNode> CachedTestedValue { get; set;}

#endregion
}
}