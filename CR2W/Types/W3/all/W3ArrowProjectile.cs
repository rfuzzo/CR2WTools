using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ArrowProjectile : W3AdvancedProjectile
{
#region RED Properties

[REDProp("defaultTrail")]
public CName DefaultTrail { get; set;}

[REDProp("underwaterTrail")]
public CName UnderwaterTrail { get; set;}

[REDProp("boneName")]
public CName BoneName { get; set;}

[REDProp("activeTrail")]
public CName ActiveTrail { get; set;}

[REDProp("shouldBeAttachedToVictim")]
public bool ShouldBeAttachedToVictim { get; set;}

[REDProp("isOnFire")]
public bool IsOnFire { get; set;}

[REDProp("isUnderwater")]
public bool IsUnderwater { get; set;}

[REDProp("isBouncedArrow")]
public bool IsBouncedArrow { get; set;}

[REDProp("isScheduledForDestruction")]
public bool IsScheduledForDestruction { get; set;}

#endregion
}
}