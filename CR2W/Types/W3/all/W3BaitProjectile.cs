using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3BaitProjectile : W3BoltProjectile
{
#region RED Properties

[REDProp("foodSourceToGenerate")]
public Handle<CEntityTemplate> FoodSourceToGenerate { get; set;}

[REDProp("addScentToCollidedActors")]
public bool AddScentToCollidedActors { get; set;}

[REDProp("attractionDuration")]
public float AttractionDuration { get; set;}

[REDProp("m_BaitEntity")]
public Handle<CEntity> M_BaitEntity { get; set;}

#endregion
}
}