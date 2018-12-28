using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeAtomicFlyAroundPositionDefinition : IBehTreeNodeAtomicFlyAroundBaseDefinition
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

#endregion
}
}