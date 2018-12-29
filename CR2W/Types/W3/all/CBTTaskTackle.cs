using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskTackle : IBehTreeTask
{
#region RED Properties

[REDProp("dealDamage")]
public bool DealDamage { get; set;}

[REDProp("activeOnAnimEvent")]
public bool ActiveOnAnimEvent { get; set;}

[REDProp("bCollisionWithActor")]
public bool BCollisionWithActor { get; set;}

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("xmlDamageName")]
public CName XmlDamageName { get; set;}

[REDProp("collidedActor")]
public Handle<CActor> CollidedActor { get; set;}

#endregion
}
}