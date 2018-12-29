using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHorseCharge : IBehTreeTask
{
#region RED Properties

[REDProp("dealDamage")]
public bool DealDamage { get; set;}

[REDProp("collisionWithActor")]
public bool CollisionWithActor { get; set;}

[REDProp("xmlDamageName")]
public CName XmlDamageName { get; set;}

[REDProp("collidedActor")]
public Handle<CActor> CollidedActor { get; set;}

#endregion
}
}