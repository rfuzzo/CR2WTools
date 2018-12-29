using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FlammableDamageEntity : CInteractiveEntity
{
#region RED Properties

[REDProp("explosionEntity")]
public Handle<CEntityTemplate> ExplosionEntity { get; set;}

[REDProp("spawnedExplosion")]
public Handle<CDamageAreaEntity> SpawnedExplosion { get; set;}

[REDProp("victim")]
public Handle<CActor> Victim { get; set;}

[REDProp("pos")]
public Vector Pos { get; set;}

#endregion
}
}