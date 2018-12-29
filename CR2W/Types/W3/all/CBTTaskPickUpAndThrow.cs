using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPickUpAndThrow : IBehTreeTask
{
#region RED Properties

[REDProp("projectileTemplate")]
public Handle<CEntityTemplate> ProjectileTemplate { get; set;}

[REDProp("proj")]
public Handle<W3AdvancedProjectile> Proj { get; set;}

[REDProp("range")]
public float Range { get; set;}

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("angleDist")]
public float AngleDist { get; set;}

[REDProp("slotName")]
public CName SlotName { get; set;}

[REDProp("pickUp")]
public bool PickUp { get; set;}

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

[REDProp("physicalComponent")]
public Handle<CComponent> PhysicalComponent { get; set;}

[REDProp("wantedHeadingVec")]
public Vector WantedHeadingVec { get; set;}

#endregion
}
}