using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3AardEntity : W3SignEntity
{
#region RED Properties

[REDProp("aspects")]
public Array<SAardAspect> Aspects { get; set;}

[REDProp("effects")]
public Array<SAardEffects> Effects { get; set;}

[REDProp("waterTestOffsetZ")]
public float WaterTestOffsetZ { get; set;}

[REDProp("waterTestDistancePerc")]
public float WaterTestDistancePerc { get; set;}

[REDProp("projectileCollision")]
public Array<CName> ProjectileCollision { get; set;}

[REDProp("processThrow_alternateCast")]
public bool ProcessThrow_alternateCast { get; set;}

#endregion
}
}