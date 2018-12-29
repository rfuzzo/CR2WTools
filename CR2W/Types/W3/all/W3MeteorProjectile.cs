using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MeteorProjectile : W3FireballProjectile
{
#region RED Properties

[REDProp("explosionRadius")]
public float ExplosionRadius { get; set;}

[REDProp("markerEntityTemplate")]
public Handle<CEntityTemplate> MarkerEntityTemplate { get; set;}

[REDProp("destroyMarkerAfter")]
public float DestroyMarkerAfter { get; set;}

[REDProp("markerEntity")]
public Handle<CEntity> MarkerEntity { get; set;}

#endregion
}
}