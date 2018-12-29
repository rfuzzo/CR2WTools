using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeAtomicFlyAroundDefinition : IBehTreeNodeAtomicFlyAroundBaseDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("stayInGuardArea")]
public bool StayInGuardArea { get; set;}

[REDProp("distance")]
public CBehTreeValFloat Distance { get; set;}

[REDProp("distanceMax")]
public CBehTreeValFloat DistanceMax { get; set;}

[REDProp("height")]
public CBehTreeValFloat Height { get; set;}

[REDProp("heightMax")]
public CBehTreeValFloat HeightMax { get; set;}

[REDProp("randomizationDelay")]
public CBehTreeValFloat RandomizationDelay { get; set;}

[REDProp("pickTargetDistance")]
public CBehTreeValFloat PickTargetDistance { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

#endregion
}
}